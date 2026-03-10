using System;
using System.Text;
using System.Windows.Forms;

namespace Nhiemvu2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string NormalizeKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return string.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (char c in key)
            {
                if (char.IsLetter(c))
                {
                    sb.Append(char.ToUpper(c));
                }
            }

            return sb.ToString();
        }

        // Mã hóa Vigenere
        private string EncryptVigenere(string plainText, string key)
        {
            key = NormalizeKey(key);

            if (string.IsNullOrEmpty(key))
                throw new Exception("Khóa không hợp lệ. Vui lòng nhập ít nhất một chữ cái.");

            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char ch in plainText)
            {
                if (char.IsLetter(ch))
                {
                    bool isLower = char.IsLower(ch);
                    char upperChar = char.ToUpper(ch);

                    int p = upperChar - 'A';
                    int k = key[keyIndex % key.Length] - 'A';
                    int c = (p + k) % 26;

                    char encryptedChar = (char)(c + 'A');

                    if (isLower)
                        encryptedChar = char.ToLower(encryptedChar);

                    result.Append(encryptedChar);
                    keyIndex++;
                }
                else
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }

        // Giải mã Vigenere
        private string DecryptVigenere(string cipherText, string key)
        {
            key = NormalizeKey(key);

            if (string.IsNullOrEmpty(key))
                throw new Exception("Khóa không hợp lệ. Vui lòng nhập ít nhất một chữ cái.");

            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char ch in cipherText)
            {
                if (char.IsLetter(ch))
                {
                    bool isLower = char.IsLower(ch);
                    char upperChar = char.ToUpper(ch);

                    int c = upperChar - 'A';
                    int k = key[keyIndex % key.Length] - 'A';
                    int p = (c - k + 26) % 26;

                    char decryptedChar = (char)(p + 'A');

                    if (isLower)
                        decryptedChar = char.ToLower(decryptedChar);

                    result.Append(decryptedChar);
                    keyIndex++;
                }
                else
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtKey.Text;
                string plainText = rtbPlainText.Text;

                if (string.IsNullOrWhiteSpace(plainText))
                {
                    MessageBox.Show("Vui lòng nhập bản rõ để mã hóa.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rtbCipherText.Text = EncryptVigenere(plainText, key);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtKey.Text;
                string cipherText = rtbCipherText.Text;

                if (string.IsNullOrWhiteSpace(cipherText))
                {
                    MessageBox.Show("Vui lòng nhập bản mã để giải mã.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rtbPlainText.Text = DecryptVigenere(cipherText, key);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKey.Clear();
            rtbPlainText.Clear();
            rtbCipherText.Clear();
            txtKey.Focus();
        }

        private void rtbCipherText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rtbPlainText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}