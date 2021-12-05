namespace HttpDownloaderDemo
{
    partial class HttpFileDownloaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used. 
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HttpFileDownloaderForm));
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_progress = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_stat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_time_left = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_speed = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.httpDownloader1 = new DotNetRemoting.HttpDownloaderCtl();
            this.textBox_loc_folder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_browse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Location = new System.Drawing.Point(412, 116);
            this.button_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 28);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_url
            // 
            this.textBox_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_url.Location = new System.Drawing.Point(115, 22);
            this.textBox_url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(396, 22);
            this.textBox_url.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(16, 162);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(496, 16);
            this.progressBar1.TabIndex = 3;
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Location = new System.Drawing.Point(125, 128);
            this.label_progress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(87, 17);
            this.label_progress.TabIndex = 4;
            this.label_progress.Text = "отсутствует";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_stat,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_time_left,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel_speed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 182);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(528, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusLabel1.Text = "Статус : ";
            // 
            // toolStripStatusLabel_stat
            // 
            this.toolStripStatusLabel_stat.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel_stat.Name = "toolStripStatusLabel_stat";
            this.toolStripStatusLabel_stat.Size = new System.Drawing.Size(48, 20);
            this.toolStripStatusLabel_stat.Text = "Готов";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(91, 20);
            this.toolStripStatusLabel2.Text = "Время ост :";
            // 
            // toolStripStatusLabel_time_left
            // 
            this.toolStripStatusLabel_time_left.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel_time_left.Name = "toolStripStatusLabel_time_left";
            this.toolStripStatusLabel_time_left.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabel_time_left.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel3.Text = "Скор : ";
            // 
            // toolStripStatusLabel_speed
            // 
            this.toolStripStatusLabel_speed.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel_speed.Name = "toolStripStatusLabel_speed";
            this.toolStripStatusLabel_speed.Size = new System.Drawing.Size(28, 20);
            this.toolStripStatusLabel_speed.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL-адрес";
            // 
            // httpDownloader1
            // 
            this.httpDownloader1.BackColor = System.Drawing.SystemColors.Info;
            this.httpDownloader1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.httpDownloader1.FtpToolStripProgressBar = null;
            this.httpDownloader1.Location = new System.Drawing.Point(200, 15);
            this.httpDownloader1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.httpDownloader1.Name = "httpDownloader1";
            this.httpDownloader1.ProgrBar = this.progressBar1;
            this.httpDownloader1.ProgressLabel = this.label_progress;
            this.httpDownloader1.ProxyToUse = DotNetRemoting.UseProxy.NotProxy;
            this.httpDownloader1.Size = new System.Drawing.Size(154, 39);
            this.httpDownloader1.TabIndex = 0;
            this.httpDownloader1.TimeOut = 5000;
            this.httpDownloader1.URLDownload = null;
            this.httpDownloader1.Visible = false;
            this.httpDownloader1.StatusUpdateEvent += new DotNetRemoting.UpdateDelegate(this.httpDownloader1_StatusUpdateEvent);
            // 
            // textBox_loc_folder
            // 
            this.textBox_loc_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_loc_folder.Location = new System.Drawing.Point(150, 73);
            this.textBox_loc_folder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_loc_folder.Name = "textBox_loc_folder";
            this.textBox_loc_folder.Size = new System.Drawing.Size(297, 22);
            this.textBox_loc_folder.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Локальная папка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Загрузка";
            // 
            // button_browse
            // 
            this.button_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browse.Location = new System.Drawing.Point(461, 70);
            this.button_browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(51, 28);
            this.button_browse.TabIndex = 10;
            this.button_browse.Text = "...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // HttpFileDownloaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 207);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_loc_folder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label_progress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.httpDownloader1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(1327, 254);
            this.MinimumSize = new System.Drawing.Size(394, 254);
            this.Name = "HttpFileDownloaderForm";
            this.Text = "Загрузчик Http";
            this.Load += new System.EventHandler(this.HttpFileDownloaderForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotNetRemoting.HttpDownloaderCtl httpDownloader1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_stat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_time_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_loc_folder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_speed;
    }
}

