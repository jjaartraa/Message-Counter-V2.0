using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Message_Counter_V2._0
{
    public partial class Form1 : Form
    {
        string[] messageGroups;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(); // After start show dialog to select Facebook data folder
            messageGroups = Directory.GetDirectories(folderBrowserDialog1.SelectedPath + "\\messages\\inbox"); // Save the path to the messages
            if (messageGroups.Count() != 0 && backgroundWorker1.IsBusy == false) // Run if there are any conversations
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("There are no conversations is this folder.");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MessageHandler messageHandler = new MessageHandler(); 
            foreach (var conversation in messageGroups) // Count messages in each conversation
            {
                AddConversationsToTable(messageHandler.ProcessMessages(Directory.GetFiles(conversation))); // Add counted messages to the table
            }
        }

        private void AddConversationsToTable(Conversation conv) // Function creating delegate to get data to different thread.
        {
            this.Invoke((MethodInvoker)delegate {
                dataGridView1.Rows.Add(conv.name, conv.firstMessage, conv.lastMessage, conv.messages);
            });
        }
    }
}
