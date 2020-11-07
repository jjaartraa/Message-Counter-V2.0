using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Counter_V2._0
{
    class MessageHandler
    {
        Conversation conversation = new Conversation();
        public void ProcessMessages(string[] messages)
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(messages.First());
            conversation.name = GetName(doc);
            conversation.lastMessage = GetLastDate(doc);

        }

        private string GetName(HtmlDocument doc)
        {
                string name= doc.DocumentNode.SelectSingleNode("//head/title").InnerText;
                byte[] bytes = Encoding.Default.GetBytes(name);
                return Encoding.UTF8.GetString(bytes);
        }

        private string GetLastDate(HtmlDocument doc)
        {
            /* get name & first message from first path
                ConvName = doc.DocumentNode.SelectSingleNode("//head/title").InnerText;
                byte[] bytes = Encoding.Default.GetBytes(ConvName);
                ConvName = Encoding.UTF8.GetString(bytes);
             */

            return "";
        }

        private int GetCount(HtmlDocument[] documents)
        {
            foreach (var doc in documents)
            {
                conversation.messages += 0;
                //var CountNode = doc.DocumentNode.SelectNodes();
            }
            return 0;
        }

        private Conversation GetConversation()
        {
            return conversation;
        }
    }
}
