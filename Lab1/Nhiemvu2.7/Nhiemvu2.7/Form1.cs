using System.Security.Cryptography;
using System.Text;

namespace Nhiemvu2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Hàm xử lý mã hóa Caesar
        private string CaesarEncrypt(string text, int k)
        {
            string result = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    // Công thức: (vị trí + k) chia lấy dư 26
                    result += (char)((((c + k) - offset) % 26 + 26) % 26 + offset);
                }
                else
                {
                    result += c; // Giữ nguyên dấu cách, số, ký tự đặc biệt
                }
            }
            return result;
        }

        // Hàm giải mã Caesar (chỉ là mã hóa ngược lại với -k)
        private string CaesarDecrypt(string text, int k)
        {
            return CaesarEncrypt(text, -k);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int k))
            {
                richTextBox1.Text = CaesarDecrypt(richTextBox2.Text, k);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập khóa k là một số nguyên!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int k))
            {
                richTextBox2.Text = CaesarEncrypt(richTextBox1.Text, k);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập khóa k là một số nguyên!");
            }
        }
    }
}
