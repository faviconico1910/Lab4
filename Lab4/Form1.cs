using System.Net;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtWebName.Text))
                {
                    MessageBox.Show("Vui lòng nhập trên trang web");
                    return;
                }
                string content = getHTML(txtWebName.Text);
                txtContent.AppendText(content);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            } 
            


        }
        private string getHTML(string szUrl)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(szUrl);
            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                    "(KHTML, like Gecko) Chrome/90.0.4430.93 Safari/537.36";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string html = "";
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                html = sr.ReadToEnd();
            } 
                
            return html;
        }
    }
}
