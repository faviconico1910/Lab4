namespace Lab4
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            toolStrip1 = new ToolStrip();
            txtBoxUrl = new ToolStripTextBox();
            btnGo = new ToolStripButton();
            btnDownload = new ToolStripButton();
            btnViewsource = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtBoxUrl, btnGo, btnDownload, btnViewsource });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(755, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // txtBoxUrl
            // 
            txtBoxUrl.Name = "txtBoxUrl";
            txtBoxUrl.Size = new Size(630, 27);
            // 
            // btnGo
            // 
            btnGo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGo.Image = (Image)resources.GetObject("btnGo.Image");
            btnGo.ImageTransparentColor = Color.Magenta;
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(29, 24);
            btnGo.Text = "toolStripButton1";
            btnGo.Click += btnGo_Click;
            // 
            // btnDownload
            // 
            btnDownload.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDownload.Image = (Image)resources.GetObject("btnDownload.Image");
            btnDownload.ImageTransparentColor = Color.Magenta;
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(29, 24);
            btnDownload.Text = "toolStripButton2";
            btnDownload.Click += btnDownload_Click;
            // 
            // btnViewsource
            // 
            btnViewsource.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnViewsource.Image = (Image)resources.GetObject("btnViewsource.Image");
            btnViewsource.ImageTransparentColor = Color.Magenta;
            btnViewsource.Name = "btnViewsource";
            btnViewsource.Size = new Size(29, 24);
            btnViewsource.Text = "toolStripButton3";
            btnViewsource.Click += btnViewsource_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 450);
            Controls.Add(toolStrip1);
            Name = "Form4";
            Text = "Form4";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripTextBox txtBoxUrl;
        private ToolStripButton btnGo;
        private ToolStripButton btnDownload;
        private ToolStripButton btnViewsource;
    }
}