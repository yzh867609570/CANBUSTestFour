using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CANBUSTestFour
{
    class DumpMessage
    {
        public DumpMessage()
        {
        }

        public DumpMessage(int id, string idStr, byte[] data, int dlc, int flags, long time)
        {
            this.id = id;
            this.idStr = idStr;
            this.data = data;
            this.dlc = dlc;
            this.flags = flags;
            this.time = time;
        }

        public int id { get; set; }
        public string idStr { get; set; }
        public byte[] data { get; set; }
        public int dlc { get; set; }
        public int flags { get; set; }
        public long time { get; set; }
    }
}
