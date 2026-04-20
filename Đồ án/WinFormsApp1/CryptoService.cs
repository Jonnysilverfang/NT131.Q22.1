using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1;

internal static class CryptoService
{
    public static string PlayfairEncrypt(string plainText, string key)
    {
        char[,] matrix = BuildPlayfairMatrix(key);
        string prepared = PreparePlayfairPlainText(plainText);
        return TransformPlayfair(prepared, matrix, encrypt: true);
    }

    public static string PlayfairDecrypt(string cipherText, string key)
    {
        char[,] matrix = BuildPlayfairMatrix(key);
        string prepared = NormalizeLetters(cipherText);
        if (prepared.Length == 0 || prepared.Length % 2 != 0)
        {
            throw new InvalidOperationException("Bản mã PlayFair phải chỉ gồm chữ cái và có độ dài chẵn.");
        }

        string decrypted = TransformPlayfair(prepared, matrix, encrypt: false);
        return CleanupPlayfairPlainText(decrypted);
    }

    public static string RsaEncrypt(string plainText, string publicKeyPem)
    {
        if (string.IsNullOrWhiteSpace(plainText))
        {
            throw new InvalidOperationException("Nhập nội dung cần mã hóa.");
        }

        if (string.IsNullOrWhiteSpace(publicKeyPem))
        {
            throw new InvalidOperationException("Nhập khóa công khai RSA.");
        }

        using RSA rsa = RSA.Create();
        rsa.ImportFromPem(publicKeyPem);

        byte[] source = Encoding.UTF8.GetBytes(plainText);
        byte[] encrypted = rsa.Encrypt(source, RSAEncryptionPadding.OaepSHA256);
        return Convert.ToBase64String(encrypted);
    }

    public static string RsaDecrypt(string cipherTextBase64, string privateKeyPem)
    {
        if (string.IsNullOrWhiteSpace(cipherTextBase64))
        {
            throw new InvalidOperationException("Nhập bản mã Base64 cần giải mã.");
        }

        if (string.IsNullOrWhiteSpace(privateKeyPem))
        {
            throw new InvalidOperationException("Nhập khóa bí mật RSA.");
        }

        using RSA rsa = RSA.Create();
        rsa.ImportFromPem(privateKeyPem);

        byte[] cipherBytes = Convert.FromBase64String(cipherTextBase64.Trim());
        byte[] decrypted = rsa.Decrypt(cipherBytes, RSAEncryptionPadding.OaepSHA256);
        return Encoding.UTF8.GetString(decrypted);
    }

    private static string TransformPlayfair(string input, char[,] matrix, bool encrypt)
    {
        Dictionary<char, (int Row, int Col)> positions = BuildPositionMap(matrix);
        StringBuilder builder = new();
        int step = encrypt ? 1 : -1;

        for (int i = 0; i < input.Length; i += 2)
        {
            char first = input[i];
            char second = input[i + 1];
            (int row, int col) pos1 = positions[first];
            (int row, int col) pos2 = positions[second];

            if (pos1.row == pos2.row)
            {
                builder.Append(matrix[pos1.row, Mod5(pos1.col + step)]);
                builder.Append(matrix[pos2.row, Mod5(pos2.col + step)]);
            }
            else if (pos1.col == pos2.col)
            {
                builder.Append(matrix[Mod5(pos1.row + step), pos1.col]);
                builder.Append(matrix[Mod5(pos2.row + step), pos2.col]);
            }
            else
            {
                builder.Append(matrix[pos1.row, pos2.col]);
                builder.Append(matrix[pos2.row, pos1.col]);
            }
        }

        return builder.ToString();
    }

    private static string PreparePlayfairPlainText(string input)
    {
        string normalized = NormalizeLetters(input);
        if (normalized.Length == 0)
        {
            throw new InvalidOperationException("Nhập văn bản cần mã hóa PlayFair.");
        }

        StringBuilder builder = new();
        int index = 0;

        while (index < normalized.Length)
        {
            char first = normalized[index];
            char second = index + 1 < normalized.Length ? normalized[index + 1] : 'X';

            if (first == second)
            {
                builder.Append(first);
                builder.Append(first == 'X' ? 'Q' : 'X');
                index++;
            }
            else
            {
                builder.Append(first);
                builder.Append(second);
                index += 2;
            }
        }

        if (builder.Length % 2 != 0)
        {
            builder.Append('X');
        }

        return builder.ToString();
    }

    private static char[,] BuildPlayfairMatrix(string key)
    {
        string normalizedKey = NormalizeLetters(key);
        if (normalizedKey.Length == 0)
        {
            throw new InvalidOperationException("Nhập khóa PlayFair.");
        }

        StringBuilder uniqueChars = new();
        HashSet<char> seen = [];

        foreach (char ch in normalizedKey + "ABCDEFGHIKLMNOPQRSTUVWXYZ")
        {
            if (seen.Add(ch))
            {
                uniqueChars.Append(ch);
            }
        }

        char[,] matrix = new char[5, 5];
        for (int i = 0; i < 25; i++)
        {
            matrix[i / 5, i % 5] = uniqueChars[i];
        }

        return matrix;
    }

    private static Dictionary<char, (int Row, int Col)> BuildPositionMap(char[,] matrix)
    {
        Dictionary<char, (int Row, int Col)> positions = [];

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                positions[matrix[row, col]] = (row, col);
            }
        }

        return positions;
    }

    private static string NormalizeLetters(string value)
    {
        StringBuilder builder = new();

        foreach (char rawChar in value.ToUpperInvariant())
        {
            if (rawChar is >= 'A' and <= 'Z')
            {
                builder.Append(rawChar == 'J' ? 'I' : rawChar);
            }
        }

        return builder.ToString();
    }

    private static string CleanupPlayfairPlainText(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return value;
        }

        StringBuilder builder = new();

        for (int i = 0; i < value.Length; i++)
        {
            char current = value[i];
            bool isInsertedMiddlePadding =
                i > 0 &&
                i < value.Length - 1 &&
                (current == 'X' || current == 'Q') &&
                value[i - 1] == value[i + 1];

            bool isTrailingPadding =
                i == value.Length - 1 &&
                (current == 'X' || current == 'Q');

            if (!isInsertedMiddlePadding && !isTrailingPadding)
            {
                builder.Append(current);
            }
        }

        return builder.ToString();
    }

    private static int Mod5(int value)
    {
        return (value % 5 + 5) % 5;
    }
}
