namespace Lab4
{
    partial class Bai3
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
            tbContent = new RichTextBox();
            tbUrl = new TextBox();
            tbDownloadUrl = new TextBox();
            btnDownload = new Button();
            SuspendLayout();
            // 
            // tbContent
            // 
            tbContent.Location = new Point(36, 137);
            tbContent.Name = "tbContent";
            tbContent.Size = new Size(711, 301);
            tbContent.TabIndex = 0;
            tbContent.Text = "";
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(36, 25);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(536, 27);
            tbUrl.TabIndex = 1;
            // 
            // tbDownloadUrl
            // 
            tbDownloadUrl.Location = new Point(36, 72);
            tbDownloadUrl.Name = "tbDownloadUrl";
            tbDownloadUrl.Size = new Size(536, 27);
            tbDownloadUrl.TabIndex = 2;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(653, 25);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(94, 29);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDownload);
            Controls.Add(tbDownloadUrl);
            Controls.Add(tbUrl);
            Controls.Add(tbContent);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox tbContent;
        private TextBox tbUrl;
        private TextBox tbDownloadUrl;
        private Button btnDownload;
    }
}