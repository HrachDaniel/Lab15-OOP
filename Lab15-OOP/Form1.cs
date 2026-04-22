using Lab15_OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab15_OOP
{
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
                this.Load += Form1_Load;
            }

            // ========================================================
            // МЕТОД-ЗАХИСНИК: БЕЗПЕЧНЕ ФОРМУВАННЯ АДРЕСИ
            // ========================================================
            // Цей метод гарантує, що адреса завжди буде правильною (без зайвих пробілів і з правильними слешами)
            private string GetSafeUri(string inputName)
            {
                string hostUrl = tbHost.Text.Trim().TrimEnd('/');
                string safeName = inputName.Trim().TrimStart('/');
                return hostUrl + "/" + safeName;
            }

            // ========================================================
            // ЗАВАНТАЖЕННЯ НАЛАШТУВАНЬ (На 90-100 балів)
            // ========================================================
            private void Form1_Load(object sender, EventArgs e)
            {
                if (File.Exists("ftp_settings.txt"))
                {
                    string[] settings = File.ReadAllLines("ftp_settings.txt");
                    if (settings.Length >= 3)
                    {
                        tbHost.Text = settings[0];
                        tbUser.Text = settings[1];
                        tbPass.Text = settings[2];
                    }
                }
            }

            private void btnSettings_Click(object sender, EventArgs e)
            {
                Form2 settingsForm = new Form2();
                settingsForm.ShowDialog();
                Form1_Load(null, null); // Оновлюємо дані після закриття вікна налаштувань
            }

            // ========================================================
            // 1. ПІДКЛЮЧЕННЯ ТА СПИСОК ФАЙЛІВ (LIST)
            // ========================================================
            private void btnConnect_Click(object sender, EventArgs e)
            {
                try
                {
                    FadList.Items.Clear();
                    string hostUrl = tbHost.Text.Trim().TrimEnd('/');
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(hostUrl);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                    request.KeepAlive = false;
                    request.UsePassive = false; // Вимкнено пасивний режим для Xlight

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    using (Stream responseStream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            FadList.Items.Add(reader.ReadLine());
                        }
                        MessageBox.Show("Підключено успішно!\n" + response.WelcomeMessage, "Успіх");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Помилка підключення: " + ex.Message); }
            }

            // ========================================================
            // 2. ЗАВАНТАЖЕННЯ НА СЕРВЕР (STOR)
            // ========================================================
            private void btnUpload_Click(object sender, EventArgs e)
            {
                openFileDialog1.Filter = "Всі файли|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        textBox10.Text = openFileDialog1.FileName;

                        // Формуємо безпечну адресу для завантаження у конкретну папку
                        string folder = tbUpload.Text.Trim().Trim('/');
                        string safeName = openFileDialog1.SafeFileName;
                        string url = tbHost.Text.Trim().TrimEnd('/') + "/";
                        if (!string.IsNullOrEmpty(folder)) url += folder + "/";
                        url += safeName;

                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                        request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        request.KeepAlive = false;
                        request.UsePassive = false;
                        request.UseBinary = true; // Важливо для файлів

                        byte[] file = File.ReadAllBytes(textBox10.Text);
                        using (Stream strz = request.GetRequestStream())
                        {
                            strz.Write(file, 0, file.Length);
                        }
                        MessageBox.Show(safeName + " завантажено на FTP!");
                        btnConnect_Click(null, null); // Оновлюємо список
                    }
                    catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
                }
            }

            // ========================================================
            // 3. СТВОРЕННЯ КАТАЛОГУ (MKD)
            // ========================================================
            private void tbnCreate_Click(object sender, EventArgs e)
            {
                try
                {
                    string url = GetSafeUri(tbNewDir.Text);
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.MakeDirectory;
                    request.KeepAlive = false;
                    request.UsePassive = false;

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        MessageBox.Show("Каталог '" + tbNewDir.Text.Trim() + "' створено!");
                        btnConnect_Click(null, null);
                    }
                }
                // Детальна обробка помилок (наприклад, 550 Permission Denied)
                catch (WebException ex)
                {
                    if (ex.Response != null)
                    {
                        FtpWebResponse response = (FtpWebResponse)ex.Response;
                        MessageBox.Show($"Помилка сервера: {response.StatusCode} - {response.StatusDescription}");
                    }
                    else { MessageBox.Show("Помилка: " + ex.Message); }
                }
                catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
            }

            // ========================================================
            // 4. РОЗМІР ФАЙЛУ (SIZE)
            // ========================================================
            private void btnFileSize_Click(object sender, EventArgs e)
            {
                try
                {
                    string url = GetSafeUri(tbFileSize.Text);
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.GetFileSize;
                    request.KeepAlive = false;
                    request.UsePassive = false;

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        MessageBox.Show($"Розмір файлу: {response.ContentLength} байт", "Інформація");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
            }

            // ========================================================
            // 5. ВИДАЛЕННЯ КАТАЛОГУ (RMD)
            // ========================================================
            private void btnDeleteDir_Click(object sender, EventArgs e)
            {
                try
                {
                    string url = GetSafeUri(tbDelDir.Text);
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.RemoveDirectory;
                    request.KeepAlive = false;
                    request.UsePassive = false;

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        MessageBox.Show("Каталог видалено!");
                        btnConnect_Click(null, null);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Помилка (каталог має бути порожнім): " + ex.Message); }
            }

            // ========================================================
            // 6. ВИДАЛЕННЯ ФАЙЛУ (DELE)
            // ========================================================
            private void btnDeleteFile_Click(object sender, EventArgs e)
            {
                try
                {
                    string url = GetSafeUri(tbDelFile.Text);
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                    request.KeepAlive = false;
                    request.UsePassive = false;

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        MessageBox.Show("Файл видалено!");
                        btnConnect_Click(null, null);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
            }

            // ========================================================
            // 7. ЗАВАНТАЖЕННЯ З СЕРВЕРА НА ПК (RETR)
            // ========================================================
            private void btnDownload_Click(object sender, EventArgs e)
            {
                try
                {
                    string url = GetSafeUri(tbDownload.Text);
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    request.KeepAlive = false;
                    request.UsePassive = false;
                    request.UseBinary = true;

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.FileName = Path.GetFileName(tbDownload.Text.Trim().Trim('/'));

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                responseStream.CopyTo(fs);
                            }
                            MessageBox.Show("Файл успішно збережено на комп'ютер!");
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
            }

            // ========================================================
            // 8. ПЕРЕЙМЕНУВАННЯ (RENAME)
            // ========================================================
            private void btnRename_Click(object sender, EventArgs e)
            {
                try
                {
                    string url = GetSafeUri(tbOldName.Text);
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
                    request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                    request.Method = WebRequestMethods.Ftp.Rename;
                    request.KeepAlive = false;
                    request.UsePassive = false;

                    // Для нового імені вказуємо тільки назву, без шляху ftp://
                    request.RenameTo = tbNewName.Text.Trim().Trim('/');

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        MessageBox.Show("Перейменовано успішно!");
                        btnConnect_Click(null, null);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Помилка: " + ex.Message); }
            }
        }
    }