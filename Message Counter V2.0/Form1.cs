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
            GetMessageGroups(folderBrowserDialog1.SelectedPath + "\\messages\\inbox");
        }

        private void GetMessageGroups(string path)
        {
            messageGroups = Directory.GetDirectories(path);
            foreach (var item in messageGroups)
            {
                dataGridView1.Rows.Add((item.Split('\\').Last()).Split('_').First());
            }
            if (messageGroups.Count() != 0 && backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var conversation in messageGroups)
            {
                CountMessages(Directory.GetFiles(conversation));
            }
        }

        private void CountMessages(string[] parts)
        {

        }

        private void GetName() { 
        
        }

        private void GetCount() { 
        
        }
    }
}
