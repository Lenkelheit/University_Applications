using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CaesarSystemAndVigenereCipher
{
    public class VigenereCipher
    {
        // CONST
        private const char FIRST_LETTER_OF_ALPHABET = 'A';
        private const char LAST_LETTER_OF_ALPHABET = 'Z';

        // PROPERTIES
        public Dictionary<char, int> Cipher { get; private set; }

        // CONSTRUCTORS
        public VigenereCipher()
        {
            Cipher = new Dictionary<char, int>();
            int j = 0;
            for (char i = FIRST_LETTER_OF_ALPHABET; i <= LAST_LETTER_OF_ALPHABET; ++i)
            {
                Cipher.Add(i, j++);
            }
        }

        // METHODS
        public void EncryptFile(string filePathFrom, string filePathTo, string keyWord)
        {
            if (!File.Exists(filePathFrom))
            {
                throw new FileNotFoundException($"File {filePathFrom} isn`t found.");
            }
            string text = "";
            using (StreamReader streamReader = new StreamReader(filePathFrom))
            {
                text = streamReader.ReadToEnd();
            }
            using (StreamWriter streamWriter = new StreamWriter(filePathTo))
            {
                text = text.ToUpper();
                keyWord = keyWord.ToUpper();
                int j = 0;
                char elem = ' ';
                for (int i = 0; i < text.Length; ++i)
                {
                    if (Cipher.ContainsKey(text[i]))
                    {
                        // cyclically shifts keyWord
                        j %= keyWord.Length;
                        elem = (char)(FIRST_LETTER_OF_ALPHABET + ((Cipher[text[i]] + Cipher[keyWord[j]]) % Cipher.Count));

                        streamWriter.Write(elem);
                        ++j;
                    }
                    else if (text[i] == ' ')
                    {
                        streamWriter.Write(text[i]);
                    }
                }
            }
        }

        public string DecryptFile(string filePathFrom, string keyWord)
        {
            if (!File.Exists(filePathFrom))
            {
                throw new FileNotFoundException($"File {filePathFrom} isn`t found.");
            }
            string text = "";
            using (StreamReader streamReader = new StreamReader(filePathFrom))
            {
                text = streamReader.ReadToEnd();
            }
            StringBuilder decryptedText = new StringBuilder();
            text = text.ToUpper();
            keyWord = keyWord.ToUpper();
            int j = 0;
            char elem = ' ';
            for (int i = 0; i < text.Length; ++i)
            {
                if (Cipher.ContainsKey(text[i]))
                {
                    // cyclically shifts keyWord
                    j %= keyWord.Length;
                    elem = (char)(FIRST_LETTER_OF_ALPHABET + ((Cipher[text[i]] + Cipher.Count - Cipher[keyWord[j]]) % Cipher.Count));

                    decryptedText.Append(elem);
                    ++j;
                }
                else if (text[i] == ' ')
                {
                    decryptedText.Append(text[i]);
                }
            }
            return decryptedText.ToString();
        }
    }
}
