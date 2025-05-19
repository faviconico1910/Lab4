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
using System.Net;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = tbUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Không được để trống ô URL");
                return;
            } 
            else
            {
                if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult) || (uriResult.Scheme != Uri.UriSchemeHttp && uriResult.Scheme != Uri.UriSchemeHttps))
                {
                    MessageBox.Show("URL không hợp lệ");
                    return;
                }
            }

                
            string filePath = tbDownloadUrl.Text.Trim();
            if (string.IsNullOrEmpty (filePath) )
            {
                MessageBox.Show("Vui lòng nhập đường dẫn để tải về!");
                return;
            }
            
            try
            {
                using (WebClient client = new WebClient())
                using (Stream res = client.OpenRead(url))
                using (StreamReader reader = new StreamReader(res))
                {
                    string html = reader.ReadToEnd();

                    File.WriteAllText(filePath, html);

                    tbContent.Text = html;

                    MessageBox.Show($"Đã tải nội dung trang web về {filePath}");
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
