namespace Message_Counter_V2._0
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.conversationsPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.conversationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.conversationsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.conversationsPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 566);
            this.tabControl1.TabIndex = 1;
            // 
            // conversationsPage
            // 
            this.conversationsPage.Controls.Add(this.dataGridView1);
            this.conversationsPage.Location = new System.Drawing.Point(4, 22);
            this.conversationsPage.Name = "conversationsPage";
            this.conversationsPage.Padding = new System.Windows.Forms.Padding(3);
            this.conversationsPage.Size = new System.Drawing.Size(792, 540);
            this.conversationsPage.TabIndex = 0;
            this.conversationsPage.Text = "Conversations";
            this.conversationsPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.conversationName,
            this.firstMessage,
            this.lastMessage,
            this.count});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 543);
            this.dataGridView1.TabIndex = 0;
            // 
            // conversationName
            // 
            this.conversationName.HeaderText = "Name";
            this.conversationName.MaxInputLength = 100;
            this.conversationName.Name = "conversationName";
            this.conversationName.Width = 200;
            // 
            // firstMessage
            // 
            this.firstMessage.HeaderText = "First message";
            this.firstMessage.MaxInputLength = 50;
            this.firstMessage.Name = "firstMessage";
            this.firstMessage.Width = 150;
            // 
            // lastMessage
            // 
            this.lastMessage.HeaderText = "Last message";
            this.lastMessage.MaxInputLength = 50;
            this.lastMessage.Name = "lastMessage";
            this.lastMessage.Width = 150;
            // 
            // count
            // 
            this.count.HeaderText = "Count";
            this.count.MaxInputLength = 50;
            this.count.Name = "count";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.conversationsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage conversationsPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn conversationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
    }
}

