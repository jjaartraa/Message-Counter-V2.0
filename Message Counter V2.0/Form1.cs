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

        private void GetMessageGroups(string path) {
            messageGroups = Directory.GetDirectories(path);
            if (messageGroups.Count() != 0 && backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
