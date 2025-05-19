namespace Lab4
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
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            btnPost = new Button();
            inputTextBox = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(570, 27);
            textBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(51, 95);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(570, 326);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btnPost
            // 
            btnPost.Location = new Point(643, 29);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(122, 27);
            btnPost.TabIndex = 2;
            btnPost.Text = "POST";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(51, 62);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(570, 27);
            inputTextBox.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputTextBox);
            Controls.Add(btnPost);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Button btnPost;
        private TextBox inputTextBox;
    }
}