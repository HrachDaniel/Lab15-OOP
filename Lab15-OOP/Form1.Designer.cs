namespace Lab15_OOP
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.tbOldName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.tbDownload = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.tbUpload = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbNewDir = new System.Windows.Forms.TextBox();
            this.tbDelFile = new System.Windows.Forms.TextBox();
            this.tbDelDir = new System.Windows.Forms.TextBox();
            this.tbFileSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnDeleteDir = new System.Windows.Forms.Button();
            this.tbnCreate = new System.Windows.Forms.Button();
            this.btnFileSize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.FadList = new System.Windows.Forms.ListBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNewName);
            this.groupBox1.Controls.Add(this.tbOldName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnRename);
            this.groupBox1.Controls.Add(this.tbDownload);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnDownload);
            this.groupBox1.Controls.Add(this.tbUpload);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.tbNewDir);
            this.groupBox1.Controls.Add(this.tbDelFile);
            this.groupBox1.Controls.Add(this.tbDelDir);
            this.groupBox1.Controls.Add(this.tbFileSize);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnDeleteFile);
            this.groupBox1.Controls.Add(this.btnDeleteDir);
            this.groupBox1.Controls.Add(this.tbnCreate);
            this.groupBox1.Controls.Add(this.btnFileSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операції з FTP";
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(311, 298);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(167, 22);
            this.tbNewName.TabIndex = 22;
            // 
            // tbOldName
            // 
            this.tbOldName.Location = new System.Drawing.Point(311, 270);
            this.tbOldName.Name = "tbOldName";
            this.tbOldName.Size = new System.Drawing.Size(167, 22);
            this.tbOldName.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Нове:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Старе:";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(6, 270);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(220, 23);
            this.btnRename.TabIndex = 18;
            this.btnRename.Text = "Перейменувати";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // tbDownload
            // 
            this.tbDownload.Location = new System.Drawing.Point(311, 230);
            this.tbDownload.Name = "tbDownload";
            this.tbDownload.Size = new System.Drawing.Size(167, 22);
            this.tbDownload.TabIndex = 17;
            this.tbDownload.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Каталог:";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(6, 230);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(220, 23);
            this.btnDownload.TabIndex = 15;
            this.btnDownload.Text = "Завантажити З сервера";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tbUpload
            // 
            this.tbUpload.Location = new System.Drawing.Point(311, 189);
            this.tbUpload.Name = "tbUpload";
            this.tbUpload.Size = new System.Drawing.Size(167, 22);
            this.tbUpload.TabIndex = 14;
            this.tbUpload.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Каталог:";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(6, 189);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(220, 23);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Завантажити НА сервер";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbNewDir
            // 
            this.tbNewDir.Location = new System.Drawing.Point(311, 70);
            this.tbNewDir.Name = "tbNewDir";
            this.tbNewDir.Size = new System.Drawing.Size(167, 22);
            this.tbNewDir.TabIndex = 11;
            // 
            // tbDelFile
            // 
            this.tbDelFile.Location = new System.Drawing.Point(311, 151);
            this.tbDelFile.Name = "tbDelFile";
            this.tbDelFile.Size = new System.Drawing.Size(167, 22);
            this.tbDelFile.TabIndex = 10;
            // 
            // tbDelDir
            // 
            this.tbDelDir.Location = new System.Drawing.Point(311, 110);
            this.tbDelDir.Name = "tbDelDir";
            this.tbDelDir.Size = new System.Drawing.Size(167, 22);
            this.tbDelDir.TabIndex = 9;
            // 
            // tbFileSize
            // 
            this.tbFileSize.Location = new System.Drawing.Point(311, 31);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.Size = new System.Drawing.Size(167, 22);
            this.tbFileSize.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Файл:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Папка:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Папка:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Файл:";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(6, 151);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(220, 23);
            this.btnDeleteFile.TabIndex = 3;
            this.btnDeleteFile.Text = "Видалити файл";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnDeleteDir
            // 
            this.btnDeleteDir.Location = new System.Drawing.Point(6, 110);
            this.btnDeleteDir.Name = "btnDeleteDir";
            this.btnDeleteDir.Size = new System.Drawing.Size(220, 23);
            this.btnDeleteDir.TabIndex = 2;
            this.btnDeleteDir.Text = "Видалити папку";
            this.btnDeleteDir.UseVisualStyleBackColor = true;
            this.btnDeleteDir.Click += new System.EventHandler(this.btnDeleteDir_Click);
            // 
            // tbnCreate
            // 
            this.tbnCreate.Location = new System.Drawing.Point(6, 70);
            this.tbnCreate.Name = "tbnCreate";
            this.tbnCreate.Size = new System.Drawing.Size(220, 23);
            this.tbnCreate.TabIndex = 1;
            this.tbnCreate.Text = "Створити папку";
            this.tbnCreate.UseVisualStyleBackColor = true;
            this.tbnCreate.Click += new System.EventHandler(this.tbnCreate_Click);
            // 
            // btnFileSize
            // 
            this.btnFileSize.Location = new System.Drawing.Point(6, 31);
            this.btnFileSize.Name = "btnFileSize";
            this.btnFileSize.Size = new System.Drawing.Size(220, 23);
            this.btnFileSize.TabIndex = 0;
            this.btnFileSize.Text = "Розмір файлу";
            this.btnFileSize.UseVisualStyleBackColor = true;
            this.btnFileSize.Click += new System.EventHandler(this.btnFileSize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Хост:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логін:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль:";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(106, 6);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(223, 22);
            this.tbHost.TabIndex = 4;
            this.tbHost.Text = "ftp://";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(106, 36);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(223, 22);
            this.tbUser.TabIndex = 5;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(106, 64);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(223, 22);
            this.tbPass.TabIndex = 6;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(352, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(138, 71);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Підключитися";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(723, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(135, 23);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Налаштування";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // FadList
            // 
            this.FadList.FormattingEnabled = true;
            this.FadList.ItemHeight = 16;
            this.FadList.Location = new System.Drawing.Point(508, 58);
            this.FadList.Name = "FadList";
            this.FadList.Size = new System.Drawing.Size(495, 404);
            this.FadList.TabIndex = 9;
            this.FadList.Tag = "";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(18, 477);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(180, 22);
            this.textBox10.TabIndex = 10;
            this.textBox10.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 511);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.FadList);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ListBox FadList;
        private System.Windows.Forms.TextBox tbNewDir;
        private System.Windows.Forms.TextBox tbDelFile;
        private System.Windows.Forms.TextBox tbDelDir;
        private System.Windows.Forms.TextBox tbFileSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnDeleteDir;
        private System.Windows.Forms.Button tbnCreate;
        private System.Windows.Forms.Button btnFileSize;
        private System.Windows.Forms.TextBox tbUpload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox tbDownload;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.TextBox tbOldName;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

