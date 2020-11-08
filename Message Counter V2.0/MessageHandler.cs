using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Message_Counter_V2._0
{
    class MessageHandler
    {
        Conversation conversation = new Conversation();
        public Conversation ProcessMessages(string[] docPaths)
        {
            Array.Sort(docPaths, (a, b) => int.Parse(Regex.Replace(a, "[^0-9]", "")) - int.Parse(Regex.Replace(b, "[^0-9]", "")));
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(docPaths.First());
            conversation.name = GetName(doc);
            conversation.lastMessage = GetLastDate(doc);
            conversation.messages = GetCount(docPaths);
            doc.Load(docPaths.Last());
            conversation.firstMessage = GetFirstDate(doc);

            return conversation;
        }

        private string GetName(HtmlDocument doc)
        {
                string name= doc.DocumentNode.SelectSingleNode("//head/title").InnerText;
                byte[] bytes = Encoding.Default.GetBytes(name);
                return Encoding.UTF8.GetString(bytes);
        }

        private string GetLastDate(HtmlDocument doc)
        {
            if (doc.DocumentNode.SelectSingleNode("//div[@class='_2lek']") is null)
            {
                return doc.DocumentNode.SelectNodes("//div[@class='_3-94 _2lem']").First().InnerText;
            }
                return doc.DocumentNode.SelectNodes("//div[@class='_3-94 _2lem']").ElementAt(1).InnerText;
        }

        private string GetFirstDate(HtmlDocument doc)
        {
            return doc.DocumentNode.SelectNodes("//div[@class='_3-94 _2lem']").Last().InnerText;
        }

        private int GetCount(string[] docPaths)
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            int messages = 0;
            foreach (var path in docPaths)
            {
                doc.Load(path);
                messages += doc.DocumentNode.SelectNodes("//div[@class='_3-96 _2let']").Count;
            }
            return messages;
        }

        private string GetParticipants(HtmlDocument doc)
        {
            if (doc.DocumentNode.SelectSingleNode("//div[@class='_2lek']") is null)
            {
                return "";
            }
            return doc.DocumentNode.SelectSingleNode("//div[@class='_2lek']").InnerText;
        }

        private Conversation GetConversation()
        {
            return conversation;
        }
    }
}
