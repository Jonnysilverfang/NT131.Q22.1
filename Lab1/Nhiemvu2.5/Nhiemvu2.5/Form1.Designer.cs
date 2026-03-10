namespace Nhiemvu2._5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblKey;
        private TextBox txtKey;
        private Label lblPlain;
        private RichTextBox rtbPlainText;
        private Label lblCipher;
        private RichTextBox rtbCipherText;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnClear;

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
        ///  Required method for Designer support
        /// </summary>
        private void InitializeComponent()
        {
            lblKey = new Label();
            txtKey = new TextBox();
            lblPlain = new Label();
            rtbPlainText = new RichTextBox();
            lblCipher = new Label();
            rtbCipherText = new RichTextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.BackColor = Color.White;
            lblKey.FlatStyle = FlatStyle.Flat;
            lblKey.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblKey.Location = new Point(483, 32);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(56, 25);
            lblKey.TabIndex = 0;
            lblKey.Text = "Khóa";
            // 
            // txtKey
            // 
            txtKey.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txtKey.Location = new Point(577, 25);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(250, 31);
            txtKey.TabIndex = 1;
            // 
            // lblPlain
            // 
            lblPlain.AutoSize = true;
            lblPlain.BackColor = Color.White;
            lblPlain.FlatStyle = FlatStyle.Flat;
            lblPlain.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblPlain.Location = new Point(288, 53);
            lblPlain.Name = "lblPlain";
            lblPlain.Size = new Size(68, 25);
            lblPlain.TabIndex = 2;
            lblPlain.Text = "Bản rõ";
            // 
            // rtbPlainText
            // 
            rtbPlainText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            rtbPlainText.Location = new Point(30, 100);
            rtbPlainText.Name = "rtbPlainText";
            rtbPlainText.Size = new Size(593, 356);
            rtbPlainText.TabIndex = 3;
            rtbPlainText.Text = "";
            rtbPlainText.TextChanged += rtbPlainText_TextChanged;
            // 
            // lblCipher
            // 
            lblCipher.AutoSize = true;
            lblCipher.BackColor = Color.White;
            lblCipher.FlatStyle = FlatStyle.Flat;
            lblCipher.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblCipher.Location = new Point(991, 53);
            lblCipher.Name = "lblCipher";
            lblCipher.Size = new Size(76, 25);
            lblCipher.TabIndex = 4;
            lblCipher.Text = "Bản mã";
            // 
            // rtbCipherText
            // 
            rtbCipherText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            rtbCipherText.Location = new Point(767, 100);
            rtbCipherText.Name = "rtbCipherText";
            rtbCipherText.Size = new Size(509, 356);
            rtbCipherText.TabIndex = 5;
            rtbCipherText.Text = "";
            rtbCipherText.TextChanged += rtbCipherText_TextChanged;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.White;
            btnEncrypt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnEncrypt.ForeColor = Color.FromArgb(0, 192, 192);
            btnEncrypt.Location = new Point(174, 484);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(100, 40);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "Mã hóa";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.White;
            btnDecrypt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDecrypt.ForeColor = Color.FromArgb(0, 192, 192);
            btnDecrypt.Location = new Point(616, 484);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(100, 40);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "Giải mã";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(0, 192, 192);
            btnClear.Location = new Point(991, 484);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 8;
            btnClear.Text = "Xóa";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1342, 569);
            Controls.Add(btnClear);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(rtbCipherText);
            Controls.Add(lblCipher);
            Controls.Add(rtbPlainText);
            Controls.Add(lblPlain);
            Controls.Add(txtKey);
            Controls.Add(lblKey);
            ForeColor = Color.FromArgb(0, 192, 192);
            Name = "Form1";
            Text = "Vigenere Cipher - WinForms";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}