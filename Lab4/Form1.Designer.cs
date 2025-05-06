namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtWebName = new TextBox();
            btnGet = new Button();
            txtContent = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên trang web";
            // 
            // txtWebName
            // 
            txtWebName.Location = new Point(12, 32);
            txtWebName.Name = "txtWebName";
            txtWebName.Size = new Size(558, 27);
            txtWebName.TabIndex = 1;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(675, 12);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(126, 81);
            btnGet.TabIndex = 2;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 102);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(1188, 555);
            txtContent.TabIndex = 3;
            txtContent.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 669);
            Controls.Add(txtContent);
            Controls.Add(btnGet);
            Controls.Add(txtWebName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWebName;
        private Button btnGet;
        private RichTextBox txtContent;
    }
}
