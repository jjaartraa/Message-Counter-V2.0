using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_Counter_V2._0
{
    class Conversation
    {
        public string name { get; set; } // path -> "//head/title"
        public string[] participants { get; set; } // div with attribute -> class="_2lek"
        public string firstMessage { get; set; } // div with attribute -> class="_3-94 _2lem"
        public string lastMessage { get; set; }
        public int messages { get; set; } // div with attribute -> class="_3-96 _2let"
    }
}
