namespace CANBUSTestFour
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.init_Button = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.channelText = new System.Windows.Forms.TextBox();
            this.openChannel = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.bitrateText = new System.Windows.Forms.ComboBox();
            this.setBitrate_Button = new System.Windows.Forms.Button();
            this.busOn_Button = new System.Windows.Forms.Button();
            this.busOff_Button = new System.Windows.Forms.Button();
            this.closeChannel_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.DLCBox = new System.Windows.Forms.TextBox();
            this.dataBox0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBox1 = new System.Windows.Forms.TextBox();
            this.dataBox3 = new System.Windows.Forms.TextBox();
            this.dataBox2 = new System.Windows.Forms.TextBox();
            this.dataBox7 = new System.Windows.Forms.TextBox();
            this.dataBox6 = new System.Windows.Forms.TextBox();
            this.dataBox5 = new System.Windows.Forms.TextBox();
            this.dataBox4 = new System.Windows.Forms.TextBox();
            this.flagsBox = new System.Windows.Forms.TextBox();
            this.sendMessage_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // init_Button
            // 
            this.init_Button.Location = new System.Drawing.Point(26, 36);
            this.init_Button.Name = "init_Button";
            this.init_Button.Size = new System.Drawing.Size(101, 24);
            this.init_Button.TabIndex = 0;
            this.init_Button.Text = "Initialize";
            this.init_Button.UseVisualStyleBackColor = true;
            this.init_Button.Click += new System.EventHandler(this.init_Button_Click);
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(12, 626);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(35, 12);
            this.statusText.TabIndex = 1;
            this.statusText.Text = "Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Channel";
            // 
            // channelText
            // 
            this.channelText.Location = new System.Drawing.Point(79, 64);
            this.channelText.Name = "channelText";
            this.channelText.Size = new System.Drawing.Size(48, 21);
            this.channelText.TabIndex = 3;
            this.channelText.Text = "0";
            // 
            // openChannel
            // 
            this.openChannel.Location = new System.Drawing.Point(26, 91);
            this.openChannel.Name = "openChannel";
            this.openChannel.Size = new System.Drawing.Size(101, 24);
            this.openChannel.TabIndex = 4;
            this.openChannel.Text = "Open Channel";
            this.openChannel.UseVisualStyleBackColor = true;
            this.openChannel.Click += new System.EventHandler(this.openChannel_Click);
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(26, 350);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(615, 264);
            this.outputBox.TabIndex = 6;
            this.outputBox.WordWrap = false;
            // 
            // bitrateText
            // 
            this.bitrateText.FormattingEnabled = true;
            this.bitrateText.Items.AddRange(new object[] {
            "125 kb/s",
            "250 kb/s",
            "500 kb/s",
            "1 Mb/s"});
            this.bitrateText.Location = new System.Drawing.Point(26, 121);
            this.bitrateText.Name = "bitrateText";
            this.bitrateText.Size = new System.Drawing.Size(101, 20);
            this.bitrateText.TabIndex = 7;
            // 
            // setBitrate_Button
            // 
            this.setBitrate_Button.Location = new System.Drawing.Point(26, 147);
            this.setBitrate_Button.Name = "setBitrate_Button";
            this.setBitrate_Button.Size = new System.Drawing.Size(101, 24);
            this.setBitrate_Button.TabIndex = 8;
            this.setBitrate_Button.Text = "Set Bitrate";
            this.setBitrate_Button.UseVisualStyleBackColor = true;
            this.setBitrate_Button.Click += new System.EventHandler(this.setBitrate_Button_Click);
            // 
            // busOn_Button
            // 
            this.busOn_Button.Location = new System.Drawing.Point(26, 186);
            this.busOn_Button.Name = "busOn_Button";
            this.busOn_Button.Size = new System.Drawing.Size(101, 24);
            this.busOn_Button.TabIndex = 9;
            this.busOn_Button.Text = "Bus On";
            this.busOn_Button.UseVisualStyleBackColor = true;
            this.busOn_Button.Click += new System.EventHandler(this.busOn_Button_Click);
            // 
            // busOff_Button
            // 
            this.busOff_Button.Location = new System.Drawing.Point(26, 225);
            this.busOff_Button.Name = "busOff_Button";
            this.busOff_Button.Size = new System.Drawing.Size(101, 24);
            this.busOff_Button.TabIndex = 10;
            this.busOff_Button.Text = "Bus Off";
            this.busOff_Button.UseVisualStyleBackColor = true;
            this.busOff_Button.Click += new System.EventHandler(this.busOff_Button_Click);
            // 
            // closeChannel_Button
            // 
            this.closeChannel_Button.Location = new System.Drawing.Point(26, 264);
            this.closeChannel_Button.Name = "closeChannel_Button";
            this.closeChannel_Button.Size = new System.Drawing.Size(101, 24);
            this.closeChannel_Button.TabIndex = 11;
            this.closeChannel_Button.Text = "Close Channel";
            this.closeChannel_Button.UseVisualStyleBackColor = true;
            this.closeChannel_Button.Click += new System.EventHandler(this.closeChannel_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Flags:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(215, 44);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(48, 21);
            this.idBox.TabIndex = 15;
            this.idBox.Text = "0";
            // 
            // DLCBox
            // 
            this.DLCBox.Location = new System.Drawing.Point(377, 44);
            this.DLCBox.Name = "DLCBox";
            this.DLCBox.Size = new System.Drawing.Size(48, 21);
            this.DLCBox.TabIndex = 16;
            this.DLCBox.Text = "0";
            // 
            // dataBox0
            // 
            this.dataBox0.Location = new System.Drawing.Point(215, 99);
            this.dataBox0.Name = "dataBox0";
            this.dataBox0.Size = new System.Drawing.Size(48, 21);
            this.dataBox0.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "DLC:";
            // 
            // dataBox1
            // 
            this.dataBox1.Location = new System.Drawing.Point(269, 99);
            this.dataBox1.Name = "dataBox1";
            this.dataBox1.Size = new System.Drawing.Size(48, 21);
            this.dataBox1.TabIndex = 19;
            // 
            // dataBox3
            // 
            this.dataBox3.Location = new System.Drawing.Point(377, 99);
            this.dataBox3.Name = "dataBox3";
            this.dataBox3.Size = new System.Drawing.Size(48, 21);
            this.dataBox3.TabIndex = 21;
            // 
            // dataBox2
            // 
            this.dataBox2.Location = new System.Drawing.Point(323, 99);
            this.dataBox2.Name = "dataBox2";
            this.dataBox2.Size = new System.Drawing.Size(48, 21);
            this.dataBox2.TabIndex = 20;
            // 
            // dataBox7
            // 
            this.dataBox7.Location = new System.Drawing.Point(593, 99);
            this.dataBox7.Name = "dataBox7";
            this.dataBox7.Size = new System.Drawing.Size(48, 21);
            this.dataBox7.TabIndex = 25;
            // 
            // dataBox6
            // 
            this.dataBox6.Location = new System.Drawing.Point(539, 99);
            this.dataBox6.Name = "dataBox6";
            this.dataBox6.Size = new System.Drawing.Size(48, 21);
            this.dataBox6.TabIndex = 24;
            // 
            // dataBox5
            // 
            this.dataBox5.Location = new System.Drawing.Point(485, 99);
            this.dataBox5.Name = "dataBox5";
            this.dataBox5.Size = new System.Drawing.Size(48, 21);
            this.dataBox5.TabIndex = 23;
            // 
            // dataBox4
            // 
            this.dataBox4.Location = new System.Drawing.Point(431, 99);
            this.dataBox4.Name = "dataBox4";
            this.dataBox4.Size = new System.Drawing.Size(48, 21);
            this.dataBox4.TabIndex = 22;
            // 
            // flagsBox
            // 
            this.flagsBox.Location = new System.Drawing.Point(215, 155);
            this.flagsBox.Name = "flagsBox";
            this.flagsBox.Size = new System.Drawing.Size(102, 21);
            this.flagsBox.TabIndex = 26;
            // 
            // sendMessage_Button
            // 
            this.sendMessage_Button.Location = new System.Drawing.Point(215, 225);
            this.sendMessage_Button.Name = "sendMessage_Button";
            this.sendMessage_Button.Size = new System.Drawing.Size(102, 24);
            this.sendMessage_Button.TabIndex = 27;
            this.sendMessage_Button.Text = "Send Message";
            this.sendMessage_Button.UseVisualStyleBackColor = true;
            this.sendMessage_Button.Click += new System.EventHandler(this.sendMessage_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "Received messages:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 647);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sendMessage_Button);
            this.Controls.Add(this.flagsBox);
            this.Controls.Add(this.dataBox7);
            this.Controls.Add(this.dataBox6);
            this.Controls.Add(this.dataBox5);
            this.Controls.Add(this.dataBox4);
            this.Controls.Add(this.dataBox3);
            this.Controls.Add(this.dataBox2);
            this.Controls.Add(this.dataBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataBox0);
            this.Controls.Add(this.DLCBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeChannel_Button);
            this.Controls.Add(this.busOff_Button);
            this.Controls.Add(this.busOn_Button);
            this.Controls.Add(this.setBitrate_Button);
            this.Controls.Add(this.bitrateText);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.openChannel);
            this.Controls.Add(this.channelText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.init_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button init_Button;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox channelText;
        private System.Windows.Forms.Button openChannel;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.ComboBox bitrateText;
        private System.Windows.Forms.Button setBitrate_Button;
        private System.Windows.Forms.Button busOn_Button;
        private System.Windows.Forms.Button busOff_Button;
        private System.Windows.Forms.Button closeChannel_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox DLCBox;
        private System.Windows.Forms.TextBox dataBox0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dataBox1;
        private System.Windows.Forms.TextBox dataBox3;
        private System.Windows.Forms.TextBox dataBox2;
        private System.Windows.Forms.TextBox dataBox7;
        private System.Windows.Forms.TextBox dataBox6;
        private System.Windows.Forms.TextBox dataBox5;
        private System.Windows.Forms.TextBox dataBox4;
        private System.Windows.Forms.TextBox flagsBox;
        private System.Windows.Forms.Button sendMessage_Button;
        private System.Windows.Forms.Label label6;
    }
}

