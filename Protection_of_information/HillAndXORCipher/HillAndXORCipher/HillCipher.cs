using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HillAndXORCipher
{
    public class HillCipher
    {
        // CONST
        private const char FIRST_LETTER_OF_ALPHABET = 'A';
        private const char LAST_LETTER_OF_ALPHABET = 'Z';

        // PROPERTIES
        public Dictionary<char, int> Cipher { get; private set; }

        // CONSTRUCTORS
        public HillCipher()
        {
            Cipher = new Dictionary<char, int>();
            int j = 0;
            for (char i = FIRST_LETTER_OF_ALPHABET; i <= LAST_LETTER_OF_ALPHABET; ++i) 
            {
                Cipher.Add(i, j++);
            }
            Cipher.Add(' ', j++);
            Cipher.Add('\'', j++);
            Cipher.Add('.', j++);
        }

        // METHODS
        public static int ExtendedEuclideanAlgorithm(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int prevX, prevY;
            int d = ExtendedEuclideanAlgorithm(b % a, a, out prevX, out prevY);
            x = prevY - (b / a) * prevX;
            y = prevX;

            return d;
        }
        private void SplitTextIntoBlocks(Matrix matrix, string text)
        {
            text = text.ToUpper();
            for (int i = 0; i < matrix.Rows; ++i)
            {
                for (int j = 0; j < matrix.Columns; ++j)
                {
                    int index = i * matrix.Columns + j;
                    if (Cipher.ContainsKey(text[index]))
                    {
                        matrix[i, j] = Cipher[text[index]];
                    }
                }
            }
        }
        public void EncryptFile(string fromFilePath, string toFilePath, string keyWord)
        {
            if (!File.Exists(fromFilePath)) 
            {
                throw new FileNotFoundException($"File {fromFilePath} isn`t found.");
            }
            int columns = (int)Math.Sqrt(keyWord.Length);
            Matrix keyCipherMatrix = new Matrix(columns, columns);
            SplitTextIntoBlocks(keyCipherMatrix, keyWord);

            string text = "";
            using (StreamReader streamReader = new StreamReader(fromFilePath))
            {
                text = streamReader.ReadToEnd();
            }

            text = text.ToUpper();
            StringBuilder newText = new StringBuilder();
            for (int i = 0; i < text.Length; ++i) 
            {
                if (Cipher.ContainsKey(text[i]))
                {
                    newText.Append(text[i]);
                }
            }
            int rows = (int)Math.Ceiling((double)newText.Length / columns);
            while (newText.Length != rows * columns) 
            {
                newText.Append(' ');
            }
            Matrix textCipherMatrix = new Matrix(rows, columns);
            SplitTextIntoBlocks(textCipherMatrix, newText.ToString());

            Matrix cipherMatrix = textCipherMatrix.MultiplyWithMod(keyCipherMatrix, Cipher.Count);

            using (StreamWriter streamWriter = new StreamWriter(toFilePath))
            {
                for (int i = 0; i < cipherMatrix.Rows; ++i)
                {
                    for (int j = 0; j < cipherMatrix.Columns; ++j) 
                    {
                        char elem = Cipher.First(x => x.Value == cipherMatrix[i, j]).Key;
                        streamWriter.Write(elem);
                    }
                }
            }
        }
        public string DecryptFile(string fromFilePath, string toFilePath, string keyWord)
        {
            if (!File.Exists(fromFilePath))
            {
                throw new FileNotFoundException($"File {fromFilePath} isn`t found.");
            }
            int columns = (int)Math.Sqrt(keyWord.Length);
            Matrix keyCipherMatrix = new Matrix(columns, columns);
            SplitTextIntoBlocks(keyCipherMatrix, keyWord);

            int determinant = keyCipherMatrix.GetDeterminant();
            int x1, y1;
            if ((determinant == 0) || (ExtendedEuclideanAlgorithm(determinant, Cipher.Count, out x1, out y1) != 1)) 
            {
                throw new Exception("Determinant equals 0 or it and alphabet length aren`t mutually simple.");
            }
            string encryptedText = "";
            using (StreamReader streamReader = new StreamReader(fromFilePath))
            {
                encryptedText = streamReader.ReadToEnd();
            }

            int rows = (int)Math.Ceiling((double)encryptedText.Length / columns);
            Matrix encryptedTextCipherMatrix = new Matrix(rows, columns);
            SplitTextIntoBlocks(encryptedTextCipherMatrix, encryptedText);

            Matrix invertibleKeyCipherMatrix = keyCipherMatrix.GetInvertibleMatrixWithMod(Cipher.Count);

            Matrix cipherMatrix = encryptedTextCipherMatrix.MultiplyWithMod(invertibleKeyCipherMatrix, Cipher.Count);

            StringBuilder decryptedText = new StringBuilder();
            using (StreamWriter streamWriter = new StreamWriter(toFilePath))
            {
                for (int i = 0; i < cipherMatrix.Rows; ++i)
                {
                    for (int j = 0; j < cipherMatrix.Columns; ++j)
                    {
                        char elem = Cipher.First(x => x.Value == cipherMatrix[i, j]).Key;
                        decryptedText.Append(elem);
                        streamWriter.Write(elem);
                    }
                }
            }
            return decryptedText.ToString();
        }
    }
}
