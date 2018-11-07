using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HillAndXORCipher
{
    // gamma cipher
    public class XORCipher
    {
        // CONST
        private const char FIRST_LETTER_OF_ALPHABET = 'A';
        private const char LAST_LETTER_OF_ALPHABET = 'Z';

        // PROPERTIES
        public Dictionary<char, int> Cipher { get; private set; }

        // CONSTRUCTORS
        public XORCipher()
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
        private int[] GetGamma(int[] key, int sequenceLength)
        {
            int[] arrY = new int[sequenceLength + 1];
            for (int i = 0; i < key.Length; ++i)
            {
                arrY[i] = key[i];
            }
            for (int i = key.Length; i < arrY.Length; ++i) 
            {
                arrY[i] = (arrY[i - 1] + arrY[i - key.Length]) % Cipher.Count;
            }
            int[] arrZ = new int[arrY.Length - 1];
            for (int i = 0; i < arrZ.Length; ++i)
            {
                arrZ[i] = (arrY[i] + arrY[i + 1]) % Cipher.Count;
            }
            return arrZ;
        }
        public void EncryptFile(string fromFilePath, string toFilePath, int[] key)
        {
            if (!File.Exists(fromFilePath))
            {
                throw new FileNotFoundException($"File {fromFilePath} isn`t found.");
            }

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

            int[] gamma = GetGamma(key, newText.Length);

            using (StreamWriter streamWriter = new StreamWriter(toFilePath))
            {
                for (int i = 0; i < newText.Length; ++i)
                {
                    int elem = (Cipher[newText[i]] + gamma[i]) % Cipher.Count;
                    streamWriter.Write((elem < 10 ? "0" + elem : elem.ToString()) + " ");
                }
            }
        }
        public string DecryptFile(string fromFilePath, string toFilePath, int[] key)
        {
            if (!File.Exists(fromFilePath))
            {
                throw new FileNotFoundException($"File {fromFilePath} isn`t found.");
            }

            string encryptedText = "";
            using (StreamReader streamReader = new StreamReader(fromFilePath))
            {
                encryptedText = streamReader.ReadToEnd();
            }

            int textLength = encryptedText.Trim().Split().Length;

            int[] gamma = GetGamma(key, textLength);

            StringBuilder decryptedText = new StringBuilder();
            using (StreamWriter streamWriter = new StreamWriter(toFilePath))
            {
                string[] encryptedNumbers = encryptedText.Trim().Split();
                for (int i = 0; i < encryptedNumbers.Length; ++i)
                {
                    int numberFromFile = int.Parse(encryptedNumbers[i]);
                    numberFromFile = (numberFromFile + Cipher.Count - gamma[i]) % Cipher.Count;
                    char letter = Cipher.First(x => x.Value == numberFromFile).Key;
                    decryptedText.Append(letter);
                    streamWriter.Write(letter);
                }
            }
            return decryptedText.ToString();
        }
    }
}
