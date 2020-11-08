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
            folderBrowserDialog1.ShowDialog();
            messageGroups = Directory.GetDirectories(folderBrowserDialog1.SelectedPath + "\\messages\\inbox");
            if (messageGroups.Count() != 0 && backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var conversation in messageGroups)
            {
                MessageHandler messageHandler = new MessageHandler();
                AddConversationsToTable(messageHandler.ProcessMessages(Directory.GetFiles(conversation)));
            }
        }

        private void AddConversationsToTable(Conversation conv)
        {
            this.Invoke((MethodInvoker)delegate {
                dataGridView1.Rows.Add(conv.name, conv.firstMessage, conv.lastMessage, conv.messages);
            });
        }
    }
}
