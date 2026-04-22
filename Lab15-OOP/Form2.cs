using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab15_OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        // Завантажуємо поточні налаштування при відкритті вікна
        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists("ftp_settings.txt"))
            {
                string[] settings = File.ReadAllLines("ftp_settings.txt");
                if (settings.Length >= 3)
                {
                    txtSettingsHost.Text = settings[0];
                    txtSettingsUser.Text = settings[1];
                    txtSettingsPass.Text = settings[2];
                }
            }
        }

        // Зберігаємо у текстовий файл
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                string[] settingsToSave = {
                    txtSettingsHost.Text,
                    txtSettingsUser.Text,
                    txtSettingsPass.Text
                };

                File.WriteAllLines("ftp_settings.txt", settingsToSave);
                MessageBox.Show("Налаштування успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Закриваємо вікно налаштувань
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження: " + ex.Message);
            }
        }
    }
}