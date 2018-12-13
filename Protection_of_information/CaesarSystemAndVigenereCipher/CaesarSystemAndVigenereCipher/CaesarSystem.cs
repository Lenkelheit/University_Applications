using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CaesarSystemAndVigenereCipher
{
    public class CaesarSystem
    {
        // CONST
        private const char FIRST_LETTER_OF_ALPHABET = 'A';
        private const char LAST_LETTER_OF_ALPHABET = 'Z';

        // PROPERTIES
        public Dictionary<char, char> Cipher { get; private set; }

        // CONSTRUCTORS
        public CaesarSystem()
        {
            Cipher = new Dictionary<char, char>();
            for (char i = FIRST_LETTER_OF_ALPHABET; i <= LAST_LETTER_OF_ALPHABET; ++i)
            {
                Cipher.Add(i, i);
            }
        }

        // METHODS
        private void CreateCode(string keyWord, int key)
        {
            string upperCaseKey = keyWord.ToUpper();
            int indexBeginOfKeyword = key;
            for (int i = 0; i < upperCaseKey.Length; ++i)
            {
                // insert keyword by key index
                int k = (indexBeginOfKeyword + i) % Cipher.Count;
                Cipher[Cipher.ElementAt(k).Key] = upperCaseKey[i];
            }
            // shift index
            int j = 0;
            for (int i = 0; i < Cipher.Count; ++i)
            {
                if (!upperCaseKey.Contains(Cipher.ElementAt(i).Key))
                {
                    // cyclically fill in
                    int k = (indexBeginOfKeyword + upperCaseKey.Length + j) % Cipher.Count;
                    Cipher[Cipher.ElementAt(k).Key] = Cipher.ElementAt(i).Key;
                    ++j;
                }
            }
        }

        public void EncryptFileWithKey(string filePathFrom, string filePathTo, string keyWord, int key)
        {
            if (!File.Exists(filePathFrom))
            {
                throw new FileNotFoundException($"File {filePathFrom} isn`t found.");
            }
            CreateCode(keyWord, key);
            string text = "";
            using (StreamReader streamReader = new StreamReader(filePathFrom))
            {
                text = streamReader.ReadToEnd();
            }
            using (StreamWriter streamWriter = new StreamWriter(filePathTo))
            {
                text = text.ToUpper();
                foreach (char elem in text)
                {
                    if (Cipher.ContainsKey(elem))
                    {
                        streamWriter.Write(Cipher[elem]);
                    }
                    else if (elem == ' ')
                    {
                        streamWriter.Write(elem);
                    }
                }
            }
        }

        public string DecryptFileWithKey(string filePathFrom)
        {
            if (!File.Exists(filePathFrom))
            {
                throw new FileNotFoundException($"File {filePathFrom} isn`t found.");
            }
            StringBuilder decryptedText = new StringBuilder();
            string encryptedText = "";
            using (StreamReader streamReader = new StreamReader(filePathFrom))
            {
                encryptedText = streamReader.ReadToEnd();
            }
            encryptedText = encryptedText.ToUpper();
            foreach (char elem in encryptedText)
            {
                if (Cipher.ContainsValue(elem))
                {
                    decryptedText.Append(Cipher.Where(pair => pair.Value == elem).First().Key);
                }
                else
                {
                    decryptedText.Append(elem);
                }
            }
            return decryptedText.ToString();
        }
    }
}
