using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Nhiemvu2._6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCipher;
        private RichTextBox rtbCipherText;
        private Label lblMaxKeyLen;
        private TextBox txtMaxKeyLength;
        private Button btnAnalyze;
        private Button btnClear;
        private Label lblKeyLenTitle;
        private Label lblKeyLength;
        private Label lblKeyTitle;
        private TextBox txtFoundKey;
        private Label lblICInfoTitle;
        private Label lblICInfo;
        private Label lblPlain;
        private RichTextBox rtbPlainText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCipher = new Label();
            rtbCipherText = new RichTextBox();
            lblMaxKeyLen = new Label();
            txtMaxKeyLength = new TextBox();
            btnAnalyze = new Button();
            btnClear = new Button();
            lblKeyLenTitle = new Label();
            lblKeyLength = new Label();
            lblKeyTitle = new Label();
            txtFoundKey = new TextBox();
            lblICInfoTitle = new Label();
            lblICInfo = new Label();
            lblPlain = new Label();
            rtbPlainText = new RichTextBox();
            SuspendLayout();
            // 
            // lblCipher
            // 
            lblCipher.AutoSize = true;
            lblCipher.Location = new System.Drawing.Point(24, 18);
            lblCipher.Name = "lblCipher";
            lblCipher.Size = new System.Drawing.Size(74, 20);
            lblCipher.TabIndex = 0;
            lblCipher.Text = "Ciphertext";
            // 
            // rtbCipherText
            // 
            rtbCipherText.Location = new System.Drawing.Point(24, 47);
            rtbCipherText.Name = "rtbCipherText";
            rtbCipherText.Size = new System.Drawing.Size(748, 180);
            rtbCipherText.TabIndex = 1;
            rtbCipherText.Text = "";
            // 
            // lblMaxKeyLen
            // 
            lblMaxKeyLen.AutoSize = true;
            lblMaxKeyLen.Location = new System.Drawing.Point(24, 243);
            lblMaxKeyLen.Name = "lblMaxKeyLen";
            lblMaxKeyLen.Size = new System.Drawing.Size(106, 20);
            lblMaxKeyLen.TabIndex = 2;
            lblMaxKeyLen.Text = "Max key length";
            // 
            // txtMaxKeyLength
            // 
            txtMaxKeyLength.Location = new System.Drawing.Point(145, 240);
            txtMaxKeyLength.Name = "txtMaxKeyLength";
            txtMaxKeyLength.Size = new System.Drawing.Size(90, 27);
            txtMaxKeyLength.TabIndex = 3;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new System.Drawing.Point(262, 236);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new System.Drawing.Size(100, 34);
            btnAnalyze.TabIndex = 4;
            btnAnalyze.Text = "Phân tích";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(378, 236);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(88, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "Xóa";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblKeyLenTitle
            // 
            lblKeyLenTitle.AutoSize = true;
            lblKeyLenTitle.Location = new System.Drawing.Point(24, 289);
            lblKeyLenTitle.Name = "lblKeyLenTitle";
            lblKeyLenTitle.Size = new System.Drawing.Size(140, 20);
            lblKeyLenTitle.TabIndex = 6;
            lblKeyLenTitle.Text = "Độ dài khóa đoán:";
            // 
            // lblKeyLength
            // 
            lblKeyLength.AutoSize = true;
            lblKeyLength.Location = new System.Drawing.Point(183, 289);
            lblKeyLength.Name = "lblKeyLength";
            lblKeyLength.Size = new System.Drawing.Size(0, 20);
            lblKeyLength.TabIndex = 7;
            // 
            // lblKeyTitle
            // 
            lblKeyTitle.AutoSize = true;
            lblKeyTitle.Location = new System.Drawing.Point(24, 323);
            lblKeyTitle.Name = "lblKeyTitle";
            lblKeyTitle.Size = new System.Drawing.Size(105, 20);
            lblKeyTitle.TabIndex = 8;
            lblKeyTitle.Text = "Khóa tìm được";
            // 
            // txtFoundKey
            // 
            txtFoundKey.Location = new System.Drawing.Point(145, 320);
            txtFoundKey.Name = "txtFoundKey";
            txtFoundKey.ReadOnly = true;
            txtFoundKey.Size = new System.Drawing.Size(240, 27);
            txtFoundKey.TabIndex = 9;
            // 
            // lblICInfoTitle
            // 
            lblICInfoTitle.AutoSize = true;
            lblICInfoTitle.Location = new System.Drawing.Point(24, 358);
            lblICInfoTitle.Name = "lblICInfoTitle";
            lblICInfoTitle.Size = new System.Drawing.Size(102, 20);
            lblICInfoTitle.TabIndex = 10;
            lblICInfoTitle.Text = "IOC trung bình";
            // 
            // lblICInfo
            // 
            lblICInfo.AutoSize = true;
            lblICInfo.Location = new System.Drawing.Point(145, 358);
            lblICInfo.Name = "lblICInfo";
            lblICInfo.Size = new System.Drawing.Size(0, 20);
            lblICInfo.TabIndex = 11;
            // 
            // lblPlain
            // 
            lblPlain.AutoSize = true;
            lblPlain.Location = new System.Drawing.Point(24, 392);
            lblPlain.Name = "lblPlain";
            lblPlain.Size = new System.Drawing.Size(111, 20);
            lblPlain.TabIndex = 12;
            lblPlain.Text = "Bản rõ dự đoán";
            // 
            // rtbPlainText
            // 
            rtbPlainText.Location = new System.Drawing.Point(24, 421);
            rtbPlainText.Name = "rtbPlainText";
            rtbPlainText.Size = new System.Drawing.Size(748, 180);
            rtbPlainText.TabIndex = 13;
            rtbPlainText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 620);
            Controls.Add(rtbPlainText);
            Controls.Add(lblPlain);
            Controls.Add(lblICInfo);
            Controls.Add(lblICInfoTitle);
            Controls.Add(txtFoundKey);
            Controls.Add(lblKeyTitle);
            Controls.Add(lblKeyLength);
            Controls.Add(lblKeyLenTitle);
            Controls.Add(btnClear);
            Controls.Add(btnAnalyze);
            Controls.Add(txtMaxKeyLength);
            Controls.Add(lblMaxKeyLen);
            Controls.Add(rtbCipherText);
            Controls.Add(lblCipher);
            Name = "Form1";
            Text = "Phá mã Vigenere";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}