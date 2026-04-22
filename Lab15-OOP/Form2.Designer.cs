namespace Lab15_OOP
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSettingsHost = new System.Windows.Forms.TextBox();
            this.txtSettingsUser = new System.Windows.Forms.TextBox();
            this.txtSettingsPass = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FTP Хост:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Користувач:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // txtSettingsHost
            // 
            this.txtSettingsHost.Location = new System.Drawing.Point(157, 24);
            this.txtSettingsHost.Name = "txtSettingsHost";
            this.txtSettingsHost.Size = new System.Drawing.Size(244, 22);
            this.txtSettingsHost.TabIndex = 3;
            // 
            // txtSettingsUser
            // 
            this.txtSettingsUser.Location = new System.Drawing.Point(157, 66);
            this.txtSettingsUser.Name = "txtSettingsUser";
            this.txtSettingsUser.Size = new System.Drawing.Size(244, 22);
            this.txtSettingsUser.TabIndex = 4;
            // 
            // txtSettingsPass
            // 
            this.txtSettingsPass.Location = new System.Drawing.Point(157, 112);
            this.txtSettingsPass.Name = "txtSettingsPass";
            this.txtSettingsPass.PasswordChar = '*';
            this.txtSettingsPass.Size = new System.Drawing.Size(244, 22);
            this.txtSettingsPass.TabIndex = 5;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(30, 159);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(371, 23);
            this.btnSaveSettings.TabIndex = 6;
            this.btnSaveSettings.Text = "Зберегти налаштування";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 243);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.txtSettingsPass);
            this.Controls.Add(this.txtSettingsUser);
            this.Controls.Add(this.txtSettingsHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSettingsHost;
        private System.Windows.Forms.TextBox txtSettingsUser;
        private System.Windows.Forms.TextBox txtSettingsPass;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}