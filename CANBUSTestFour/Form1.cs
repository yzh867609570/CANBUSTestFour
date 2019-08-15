using canlibCLSNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANBUSTestFour
{
    public partial class Form1 : Form
    {
        private int handle = -1;
        private int channel = -1;
        private int readHandle = -1;
        private bool onBus = false;
        private readonly BackgroundWorker dumper;

        public Form1()
        {
            InitializeComponent();

            //Sets up a BackgroundWorker and adds delegates to 
            //the DumpMessageLoop and ProcessMessage methods
            dumper = new BackgroundWorker();
            dumper.DoWork += DumpMessageLoop;
            dumper.WorkerReportsProgress = true;
            dumper.ProgressChanged += new ProgressChangedEventHandler(ProcessMessage);
        }

        //Initializes Canlib
        private void init_Button_Click(object sender, EventArgs e)
        {
            Canlib.canInitializeLibrary();
            statusText.Text = "Canlib initialized";
        }

        //Opens the channel selected in the "Channel" input box
        private void openChannel_Click(object sender, EventArgs e)
        {
            channel = Convert.ToInt32(channelText.Text);
            int hnd = Canlib.canOpenChannel(channel, Canlib.canOPEN_ACCEPT_VIRTUAL);

            CheckStatus("Open channel", (Canlib.canStatus)hnd);
            if (hnd >= 0)
            {
                handle = hnd;
            }
        }

        //Sets the bitrate
        private void setBitrate_Button_Click(object sender, EventArgs e)
        {
            int[] bitrates = new int[4] { Canlib.canBITRATE_125K, Canlib.canBITRATE_250K,
                                            Canlib.canBITRATE_500K, Canlib.BAUD_1M};
            int bitrate = bitrates[bitrateText.SelectedIndex];

            Canlib.canStatus status = Canlib.canSetBusParams(handle, bitrate, 0, 0, 0, 0, 0);

            CheckStatus("Setting bitrate to " + bitrateText.SelectedValue, status);
        }

        //Goes on bus
        private void busOn_Button_Click(object sender, EventArgs e)
        {
            Canlib.canStatus status = Canlib.canBusOn(handle);
            CheckStatus("Bus on", status);
            if (status == Canlib.canStatus.canOK)
            {
                onBus = true;

                //This starts the DumpMessageLoop method
                if (!dumper.IsBusy)
                {
                    dumper.RunWorkerAsync();
                }
            }
        }

        private void busOff_Button_Click(object sender, EventArgs e)
        {
            Canlib.canStatus status = Canlib.canBusOff(handle);
            CheckStatus("Bus off", status);
            onBus = false;
        }

        private void closeChannel_Button_Click(object sender, EventArgs e)
        {
            Canlib.canStatus status = Canlib.canClose(handle);
            CheckStatus("Closing channel", status);
            handle = -1;
        }

        //Reads message data from user input and writes a message to the channel
        private void sendMessage_Button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idBox.Text);

            TextBox[] textBoxes = {dataBox0, dataBox1, dataBox2, dataBox3, dataBox4,
                                      dataBox5, dataBox6, dataBox7};
            byte[] data = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                data[i] = textBoxes[i].Text == "" ? (byte)0 : Convert.ToByte(textBoxes[i].Text);
            }

            int flags = Convert.ToInt32(flagsBox.Text);

            int dlc = Convert.ToInt32(DLCBox.Text);

            string msg = String.Format("{0}  {1}  {2:x2} {3:x2} {4:x2} {5:x2} {6:x2} {7:x2} {8:x2} {9:x2}   to handle {10}",
                                             id, dlc, data[0], data[1], data[2], data[3], data[4],
                                             data[5], data[6], data[7], handle);
            Canlib.canStatus status = Canlib.canWrite(handle, id, data, dlc, flags);
            CheckStatus("Writing message " + msg, status);
        }

        /*
         * Looks for messages and sends them to the output box. 
         */
        private void DumpMessageLoop(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Canlib.canStatus status;
            int id;
            byte[] data = new byte[8];
            int dlc;
            int flags;
            long time;
            bool noError = true;
            var msg = "";

            //Open up a new handle for reading
            readHandle = Canlib.canOpenChannel(channel, Canlib.canOPEN_ACCEPT_VIRTUAL);

            status = Canlib.canBusOn(readHandle);

            while (noError && onBus && readHandle >= 0)
            {
                status = Canlib.canReadWait(readHandle, out id, data, out dlc, out flags, out time, 50);

                if (status == Canlib.canStatus.canOK)
                {
                    if ((flags & Canlib.canMSG_ERROR_FRAME) == Canlib.canMSG_ERROR_FRAME)
                    {
                        //msg = "***ERROR FRAME RECEIVED***" + Environment.NewLine;
                    }
                    else
                    {
                        msg = String.Format("{0}  {1}  {2:x2} {3:x2} {4:x2} {5:x2} {6:x2} {7:x2} {8:x2} {9:x2}   {10}\r" + Environment.NewLine,
                                                 id, dlc, data[0], data[1], data[2], data[3], data[4],
                                                 data[5], data[6], data[7], time);
                    }
                    //Sends the message to the ProcessMessage method
                    worker.ReportProgress(0, msg);
                }

                else if (status != Canlib.canStatus.canERR_NOMSG)
                {
                    //Sends the error status to the ProcessMessage method and breaks the loop
                    worker.ReportProgress(100, status);
                    noError = false;
                }
            }
            Canlib.canBusOff(readHandle);
        }

        /*
         * Adds the messages to the output box
         */
        private void ProcessMessage(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                string output = (string)e.UserState;
                outputBox.AppendText(output);
                //outputBox.ScrollToEnd();
            }
            else
            {
                CheckStatus("Reading", (Canlib.canStatus)e.UserState);
            }
        }

        /*
         * Updates the status bar, prints error message if something goes wrong
         */
        private void CheckStatus(String action, Canlib.canStatus status)
        {
            if (status != Canlib.canStatus.canOK)
            {
                String errorText = "";
                Canlib.canGetErrorText(status, out errorText);
                statusText.Text = action + " failed: " + errorText;
            }
            else
                statusText.Text = action + " succeeded";
        }

    }
}
