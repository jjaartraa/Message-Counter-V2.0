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
            Array.Sort(docPaths, (a, b) => int.Parse(Regex.Replace(a, "[^0-9]", "")) - int.Parse(Regex.Replace(b, "[^0-9]", "")));  // Sort message files from 1,11,2,21 to 1,2,11,21
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(docPaths.First()); // Load first document (the most recent messages since Facebook sorts messages from most recent as file_0 to the oldest as file_xx)
            conversation.name = GetName(doc); // Get name of conversation from first document
            conversation.lastMessage = GetLastDate(doc); // Get name of Conversation from first document
            conversation.messages = GetCount(docPaths); // Count messages from all the message files
            doc.Load(docPaths.Last()); // Load last document (the odlest messages)
            conversation.firstMessage = GetFirstDate(doc); // Get the first (oldest) message from the oldest message file

            return conversation;
        }

        private string GetName(HtmlDocument doc) // Find the div containing the conversation name in the conversation file, by its path.
        {
                string name= doc.DocumentNode.SelectSingleNode("//head/title").InnerText;
                byte[] bytes = Encoding.Default.GetBytes(name); // Little trick to get the correct name in case of special characters in name.
                return Encoding.UTF8.GetString(bytes);
        }

        private string GetLastDate(HtmlDocument doc) // Get date of most recent message
        {
            if (doc.DocumentNode.SelectSingleNode("//div[@class='_2lek']") is null) // If there are no messages (recently added people you never spoke to) the first div has different structure.
            {
                return doc.DocumentNode.SelectNodes("//div[@class='_3-94 _2lem']").First().InnerText;
            }
                return doc.DocumentNode.SelectNodes("//div[@class='_3-94 _2lem']").ElementAt(1).InnerText;
        }

        private string GetFirstDate(HtmlDocument doc) // Get date of the first (oldest) message
        {
            return doc.DocumentNode.SelectNodes("//div[@class='_3-94 _2lem']").Last().InnerText;
        }

        private int GetCount(string[] docPaths) // Count messages from all the message files
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

        private string GetParticipants(HtmlDocument doc) // If the conversation has more participants, get all names
        {
            if (doc.DocumentNode.SelectSingleNode("//div[@class='_2lek']") is null)
            {
                return "";
            }
            return doc.DocumentNode.SelectSingleNode("//div[@class='_2lek']").InnerText;
        }
    }
}
