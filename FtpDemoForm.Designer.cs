namespace FtpDemo
{
    partial class FtpDemoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FtpDemoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_user_id = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_serv_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Passive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ftpCtl1 = new DotNetRemoting.FTPClientCtl();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.checkBox_bin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_local_folder = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_dnld = new System.Windows.Forms.Button();
            this.button_mk_dir = new System.Windows.Forms.Button();
            this.button_flist = new System.Windows.Forms.Button();
            this.button_details = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_stat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_speed = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView_data = new System.Windows.Forms.ListView();
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_file_browse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_loc_file = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label_mess = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // textBox_user_id
            // 
            this.textBox_user_id.Location = new System.Drawing.Point(152, 88);
            this.textBox_user_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_user_id.Name = "textBox_user_id";
            this.textBox_user_id.Size = new System.Drawing.Size(159, 22);
            this.textBox_user_id.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(152, 123);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(159, 22);
            this.textBox_password.TabIndex = 3;
            // 
            // textBox_serv_ip
            // 
            this.textBox_serv_ip.Location = new System.Drawing.Point(109, 23);
            this.textBox_serv_ip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_serv_ip.Name = "textBox_serv_ip";
            this.textBox_serv_ip.Size = new System.Drawing.Size(444, 22);
            this.textBox_serv_ip.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "FTP-Сервер";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(109, 55);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(122, 22);
            this.textBox_port.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Порт";
            // 
            // checkBox_Passive
            // 
            this.checkBox_Passive.AutoSize = true;
            this.checkBox_Passive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_Passive.Location = new System.Drawing.Point(360, 53);
            this.checkBox_Passive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Passive.Name = "checkBox_Passive";
            this.checkBox_Passive.Size = new System.Drawing.Size(149, 21);
            this.checkBox_Passive.TabIndex = 8;
            this.checkBox_Passive.Text = "Пассивный режим";
            this.checkBox_Passive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ftpCtl1);
            this.groupBox1.Controls.Add(this.checkBox_bin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox_Passive);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_user_id);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.textBox_serv_ip);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(561, 164);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сервер";
            // 
            // ftpCtl1
            // 
            this.ftpCtl1.BackColor = System.Drawing.Color.Orange;
            this.ftpCtl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ftpCtl1.ControlPort = 21;
            this.ftpCtl1.FtpToolStripProgressBar = this.toolStripProgressBar1;
            this.ftpCtl1.Location = new System.Drawing.Point(365, 121);
            this.ftpCtl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ftpCtl1.Name = "ftpCtl1";
            this.ftpCtl1.ProgrBar = null;
            this.ftpCtl1.ProgressLabel = null;
            this.ftpCtl1.RemoteHost = null;
            this.ftpCtl1.Size = new System.Drawing.Size(139, 24);
            this.ftpCtl1.TabIndex = 10;
            this.ftpCtl1.Timeout = 120000;
            this.ftpCtl1.TimeOut = 20000;
            this.ftpCtl1.Visible = false;
            this.ftpCtl1.StatusUpdateEvent += new DotNetRemoting.UpdateDelegate(this.ftpCtl1_StatusUpdateEvent);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 20);
            // 
            // checkBox_bin
            // 
            this.checkBox_bin.AutoSize = true;
            this.checkBox_bin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_bin.Location = new System.Drawing.Point(360, 85);
            this.checkBox_bin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_bin.Name = "checkBox_bin";
            this.checkBox_bin.Size = new System.Drawing.Size(144, 21);
            this.checkBox_bin.TabIndex = 9;
            this.checkBox_bin.Text = "Двоичный режим";
            this.checkBox_bin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Локальная папка";
            // 
            // textBox_local_folder
            // 
            this.textBox_local_folder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_local_folder.Location = new System.Drawing.Point(155, 203);
            this.textBox_local_folder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_local_folder.Name = "textBox_local_folder";
            this.textBox_local_folder.Size = new System.Drawing.Size(328, 22);
            this.textBox_local_folder.TabIndex = 9;
            // 
            // button_browse
            // 
            this.button_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browse.Location = new System.Drawing.Point(507, 197);
            this.button_browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(52, 28);
            this.button_browse.TabIndex = 11;
            this.button_browse.Text = "...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_del
            // 
            this.button_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_del.Location = new System.Drawing.Point(2, 517);
            this.button_del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(139, 28);
            this.button_del.TabIndex = 13;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_upload
            // 
            this.button_upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_upload.Location = new System.Drawing.Point(151, 517);
            this.button_upload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(132, 28);
            this.button_upload.TabIndex = 14;
            this.button_upload.Text = "Загрузить";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_dnld
            // 
            this.button_dnld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_dnld.Location = new System.Drawing.Point(291, 517);
            this.button_dnld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_dnld.Name = "button_dnld";
            this.button_dnld.Size = new System.Drawing.Size(140, 28);
            this.button_dnld.TabIndex = 15;
            this.button_dnld.Text = "Скачать";
            this.button_dnld.UseVisualStyleBackColor = true;
            this.button_dnld.Click += new System.EventHandler(this.button_dnld_Click);
            // 
            // button_mk_dir
            // 
            this.button_mk_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_mk_dir.Location = new System.Drawing.Point(439, 517);
            this.button_mk_dir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_mk_dir.Name = "button_mk_dir";
            this.button_mk_dir.Size = new System.Drawing.Size(132, 28);
            this.button_mk_dir.TabIndex = 16;
            this.button_mk_dir.Text = "MKDir";
            this.button_mk_dir.UseVisualStyleBackColor = true;
            this.button_mk_dir.Click += new System.EventHandler(this.button_mk_dir_Click);
            // 
            // button_flist
            // 
            this.button_flist.Location = new System.Drawing.Point(23, 283);
            this.button_flist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_flist.Name = "button_flist";
            this.button_flist.Size = new System.Drawing.Size(248, 28);
            this.button_flist.TabIndex = 17;
            this.button_flist.Text = "Список файлов";
            this.button_flist.UseVisualStyleBackColor = true;
            this.button_flist.Click += new System.EventHandler(this.button_flist_Click);
            // 
            // button_details
            // 
            this.button_details.Location = new System.Drawing.Point(311, 283);
            this.button_details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_details.Name = "button_details";
            this.button_details.Size = new System.Drawing.Size(248, 28);
            this.button_details.TabIndex = 18;
            this.button_details.Text = "Подробности";
            this.button_details.UseVisualStyleBackColor = true;
            this.button_details.Click += new System.EventHandler(this.button_details_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_stat,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel_time,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel_speed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(584, 26);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 21);
            this.toolStripStatusLabel1.Text = "Статус:";
            // 
            // toolStripStatusLabel_stat
            // 
            this.toolStripStatusLabel_stat.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel_stat.Name = "toolStripStatusLabel_stat";
            this.toolStripStatusLabel_stat.Size = new System.Drawing.Size(57, 21);
            this.toolStripStatusLabel_stat.Text = "Готово";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(103, 21);
            this.toolStripStatusLabel2.Text = "Время (ост.)";
            // 
            // toolStripStatusLabel_time
            // 
            this.toolStripStatusLabel_time.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel_time.Name = "toolStripStatusLabel_time";
            this.toolStripStatusLabel_time.Size = new System.Drawing.Size(63, 21);
            this.toolStripStatusLabel_time.Text = "00:00:00";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(53, 21);
            this.toolStripStatusLabel3.Text = "Скор :";
            // 
            // toolStripStatusLabel_speed
            // 
            this.toolStripStatusLabel_speed.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel_speed.Name = "toolStripStatusLabel_speed";
            this.toolStripStatusLabel_speed.Size = new System.Drawing.Size(17, 21);
            this.toolStripStatusLabel_speed.Text = "0";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "File.ico");
            this.imageList1.Images.SetKeyName(1, "openfolder.ico");
            // 
            // listView_data
            // 
            this.listView_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_data.BackColor = System.Drawing.Color.Gainsboro;
            this.listView_data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_name,
            this.columnHeader_size});
            this.listView_data.FullRowSelect = true;
            this.listView_data.GridLines = true;
            this.listView_data.HideSelection = false;
            this.listView_data.LargeImageList = this.imageList1;
            this.listView_data.Location = new System.Drawing.Point(2, 332);
            this.listView_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_data.Name = "listView_data";
            this.listView_data.Size = new System.Drawing.Size(569, 177);
            this.listView_data.SmallImageList = this.imageList1;
            this.listView_data.TabIndex = 20;
            this.listView_data.UseCompatibleStateImageBehavior = false;
            this.listView_data.View = System.Windows.Forms.View.Details;
            this.listView_data.SelectedIndexChanged += new System.EventHandler(this.listView_data_SelectedIndexChanged);
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "Name";
            this.columnHeader_name.Width = 320;
            // 
            // columnHeader_size
            // 
            this.columnHeader_size.Text = "Size";
            this.columnHeader_size.Width = 111;
            // 
            // button_file_browse
            // 
            this.button_file_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_file_browse.Location = new System.Drawing.Point(507, 245);
            this.button_file_browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_file_browse.Name = "button_file_browse";
            this.button_file_browse.Size = new System.Drawing.Size(52, 28);
            this.button_file_browse.TabIndex = 23;
            this.button_file_browse.Text = "...";
            this.button_file_browse.UseVisualStyleBackColor = true;
            this.button_file_browse.Click += new System.EventHandler(this.button_file_browse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Локальный файл";
            // 
            // textBox_loc_file
            // 
            this.textBox_loc_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_loc_file.Location = new System.Drawing.Point(155, 247);
            this.textBox_loc_file.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_loc_file.Name = "textBox_loc_file";
            this.textBox_loc_file.Size = new System.Drawing.Size(328, 22);
            this.textBox_loc_file.TabIndex = 21;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(13, 550);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Сообщение:";
            // 
            // label_mess
            // 
            this.label_mess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_mess.AutoSize = true;
            this.label_mess.Location = new System.Drawing.Point(119, 551);
            this.label_mess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mess.Name = "label_mess";
            this.label_mess.Size = new System.Drawing.Size(51, 17);
            this.label_mess.TabIndex = 25;
            this.label_mess.Text = "готово";
            // 
            // FtpDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 607);
            this.Controls.Add(this.label_mess);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_file_browse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_loc_file);
            this.Controls.Add(this.listView_data);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_details);
            this.Controls.Add(this.button_flist);
            this.Controls.Add(this.button_mk_dir);
            this.Controls.Add(this.button_dnld);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_local_folder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(567, 549);
            this.Name = "FtpDemoForm";
            this.Text = "FTP-Клиент";
            this.Load += new System.EventHandler(this.FtpDemoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_user_id;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_serv_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Passive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_local_folder;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_dnld;
        private System.Windows.Forms.Button button_mk_dir;
        private System.Windows.Forms.Button button_flist;
        private System.Windows.Forms.Button button_details;
        private System.Windows.Forms.CheckBox checkBox_bin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_stat;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_time;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DotNetRemoting.FTPClientCtl ftpCtl1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView_data;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_size;
        private System.Windows.Forms.Button button_file_browse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_loc_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_mess;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_speed;
    }
}

