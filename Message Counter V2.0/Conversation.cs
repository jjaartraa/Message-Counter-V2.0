using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Counter_V2._0
{
    class Conversation
    {
        string name;
        string[] participants;
        DateTime firstMessage;
        DateTime lastMessage;
        int messages;

        public Conversation(string name, string[] participants, DateTime firstMessage, DateTime lastMessage, int messages)
        {
            this.name = name;
            this.participants = participants;
            this.firstMessage = firstMessage;
            this.lastMessage = lastMessage;
            this.messages = messages;
        }
    }
}
