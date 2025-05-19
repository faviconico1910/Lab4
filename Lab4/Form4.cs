using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Navigate(txtBoxUrl.Text.Trim());
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {


                    string url = txtBoxUrl.Text.Trim();
                    string html = await client.GetStringAsync(url);

                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                    saveDialog.FileName = "download_page.html";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveDialog.FileName;
                        File.WriteAllText(filePath, html, Encoding.UTF8);
                        MessageBox.Show($"Đã tải nội dung trang web về {filePath}");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi tải trang web. Vui lòng kiểm tra lại URL.");
                }

            }
        }

        private async void btnViewsource_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = txtBoxUrl.Text.Trim();
                    string html = await client.GetStringAsync(url);

                    ViewSourceForm frm = new ViewSourceForm(html);
                    frm.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
