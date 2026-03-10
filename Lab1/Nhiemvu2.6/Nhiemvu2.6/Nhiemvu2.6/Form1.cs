using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nhiemvu2._6
{
    public partial class Form1 : Form
    {
        // Tần suất chữ cái tiếng Anh
        private readonly double[] englishFreq =
        {
            8.167, 1.492, 2.782, 4.253, 12.702, 2.228, 2.015,
            6.094, 6.966, 0.153, 0.772, 4.025, 2.406, 6.749,
            7.507, 1.929, 0.095, 5.987, 6.327, 9.056, 2.758,
            0.978, 2.360, 0.150, 1.974, 0.074
        };

        public Form1()
        {
            InitializeComponent();
            txtMaxKeyLength.Text = "15";
        }

        // Chuẩn hóa ciphertext: chỉ giữ A-Z
        private string NormalizeText(string text)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    sb.Append(char.ToUpper(c));
                }
            }

            return sb.ToString();
        }

        // Tính IOC
        private double CalculateIC(string text)
        {
            if (text.Length < 2) return 0;

            int[] freq = new int[26];
            foreach (char c in text)
            {
                freq[c - 'A']++;
            }

            double numerator = 0;
            int n = text.Length;

            for (int i = 0; i < 26; i++)
            {
                numerator += freq[i] * (freq[i] - 1);
            }

            return numerator / (n * (n - 1.0));
        }

        // Tách ciphertext thành nhóm theo độ dài khóa
        private List<string> SplitIntoGroups(string text, int keyLength)
        {
            List<StringBuilder> groups = new List<StringBuilder>();

            for (int i = 0; i < keyLength; i++)
            {
                groups.Add(new StringBuilder());
            }

            for (int i = 0; i < text.Length; i++)
            {
                groups[i % keyLength].Append(text[i]);
            }

            return groups.Select(g => g.ToString()).ToList();
        }

        // Tính IOC trung bình cho một key length
        private double AverageICForKeyLength(string text, int keyLength)
        {
            List<string> groups = SplitIntoGroups(text, keyLength);
            double total = 0;

            foreach (string group in groups)
            {
                total += CalculateIC(group);
            }

            return total / keyLength;
        }

        // Dự đoán độ dài khóa tốt nhất
        private (int bestKeyLength, double bestIC, List<string> reportLines) GuessKeyLength(string text, int maxKeyLength)
        {
            int bestKeyLength = 1;
            double bestIC = 0;
            List<string> reportLines = new List<string>();

            for (int keyLen = 1; keyLen <= maxKeyLength; keyLen++)
            {
                double avgIC = AverageICForKeyLength(text, keyLen);
                reportLines.Add($"Key length = {keyLen}, Avg IC = {avgIC:F6}");

                // Ưu tiên IC lớn nhất, gần với tiếng Anh hơn
                if (avgIC > bestIC)
                {
                    bestIC = avgIC;
                    bestKeyLength = keyLen;
                }
            }

            return (bestKeyLength, bestIC, reportLines);
        }

        // Dịch Caesar một chuỗi với shift
        // shift = 0 nghĩa là không dịch
        private string CaesarDecrypt(string text, int shift)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in text)
            {
                int x = c - 'A';
                int p = (x - shift + 26) % 26;
                sb.Append((char)(p + 'A'));
            }

            return sb.ToString();
        }

        // Tính chi-square để đo độ giống tiếng Anh
        private double ChiSquareScore(string text)
        {
            if (text.Length == 0) return double.MaxValue;

            int[] freq = new int[26];
            foreach (char c in text)
            {
                freq[c - 'A']++;
            }

            double score = 0;
            int n = text.Length;

            for (int i = 0; i < 26; i++)
            {
                double expected = englishFreq[i] * n / 100.0;
                if (expected > 0)
                {
                    double diff = freq[i] - expected;
                    score += (diff * diff) / expected;
                }
            }

            return score;
        }

        // Tìm một ký tự khóa bằng cách xem nhóm đó như Caesar cipher
        private char FindBestKeyChar(string group)
        {
            double bestScore = double.MaxValue;
            int bestShift = 0;

            for (int shift = 0; shift < 26; shift++)
            {
                string decrypted = CaesarDecrypt(group, shift);
                double score = ChiSquareScore(decrypted);

                if (score < bestScore)
                {
                    bestScore = score;
                    bestShift = shift;
                }
            }

            return (char)(bestShift + 'A');
        }

        // Tìm toàn bộ khóa
        private string FindKey(string text, int keyLength)
        {
            List<string> groups = SplitIntoGroups(text, keyLength);
            StringBuilder key = new StringBuilder();

            foreach (string group in groups)
            {
                key.Append(FindBestKeyChar(group));
            }

            return key.ToString();
        }

        // Giải mã Vigenere trên chuỗi đã chuẩn hóa
        private string DecryptVigenereNormalized(string cipherText, string key)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < cipherText.Length; i++)
            {
                int c = cipherText[i] - 'A';
                int k = key[i % key.Length] - 'A';
                int p = (c - k + 26) % 26;
                result.Append((char)(p + 'A'));
            }

            return result.ToString();
        }

        // Giải mã Vigenere nhưng giữ lại dấu cách, dấu câu theo văn bản gốc
        private string DecryptVigenerePreserveFormat(string originalCipherText, string key)
        {
            StringBuilder result = new StringBuilder();
            int keyIndex = 0;

            foreach (char ch in originalCipherText)
            {
                if (char.IsLetter(ch))
                {
                    bool isLower = char.IsLower(ch);
                    char upperChar = char.ToUpper(ch);

                    int c = upperChar - 'A';
                    int k = key[keyIndex % key.Length] - 'A';
                    int p = (c - k + 26) % 26;

                    char plainChar = (char)(p + 'A');
                    if (isLower)
                        plainChar = char.ToLower(plainChar);

                    result.Append(plainChar);
                    keyIndex++;
                }
                else
                {
                    result.Append(ch);
                }
            }

            return result.ToString();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            try
            {
                string originalCipher = rtbCipherText.Text;

                if (string.IsNullOrWhiteSpace(originalCipher))
                {
                    MessageBox.Show("Vui lòng nhập ciphertext.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string normalized = NormalizeText(originalCipher);

                if (normalized.Length < 20)
                {
                    MessageBox.Show("Ciphertext quá ngắn để phân tích đáng tin cậy.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtMaxKeyLength.Text, out int maxKeyLength) || maxKeyLength < 1)
                {
                    MessageBox.Show("Max key length không hợp lệ.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (maxKeyLength > normalized.Length)
                {
                    maxKeyLength = normalized.Length;
                }

                var guessResult = GuessKeyLength(normalized, maxKeyLength);
                int bestKeyLength = guessResult.bestKeyLength;
                double bestIC = guessResult.bestIC;

                string key = FindKey(normalized, bestKeyLength);
                string plainText = DecryptVigenerePreserveFormat(originalCipher, key);

                lblKeyLength.Text = bestKeyLength.ToString();
                lblICInfo.Text = bestIC.ToString("F6");
                txtFoundKey.Text = key;
                rtbPlainText.Text = plainText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbCipherText.Clear();
            rtbPlainText.Clear();
            txtFoundKey.Clear();
            lblKeyLength.Text = "";
            lblICInfo.Text = "";
            txtMaxKeyLength.Text = "15";
            rtbCipherText.Focus();
        }
    }
}