using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CaesarSystem
{
    public class CaesarSystemAndVigenereCipher
    {
        // CONST
        private const char FIRST_LETTER_OF_ALPHABET = 'A';
        private const char LAST_LETTER_OF_ALPHABET = 'Z';

        // PROPERTIES
        public Dictionary<char, char> Cipher { get; private set; }

        // CONSTRUCTORS
        public CaesarSystemAndVigenereCipher()
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
    public class FrequencyAnalysis
    {
        // CONST
        private const char FIRST_LETTER_OF_ALPHABET = 'A';
        private const char LAST_LETTER_OF_ALPHABET = 'Z';

        // PROPERTIES
        public Dictionary<char, int> StandartFrequencyDictionary { get; private set; }
        public Dictionary<char, int> EncryptedFrequencyDictionary { get; private set; }

        // CONSTRUCTORS
        public FrequencyAnalysis()
        {
            StandartFrequencyDictionary = new Dictionary<char, int>();
            EncryptedFrequencyDictionary = new Dictionary<char, int>();
            for (char i = FIRST_LETTER_OF_ALPHABET; i <= LAST_LETTER_OF_ALPHABET; ++i)
            {
                StandartFrequencyDictionary.Add(i, 0);
                EncryptedFrequencyDictionary.Add(i, 0);
            }
        }

        // METHODS
        public string CreateFrequencyDictionary(string filePathFrom, bool isStandartDictionary = true)
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
            text = text.ToUpper();

            IDictionary<char, int> dictionary;
            if (isStandartDictionary) 
            {
                dictionary = StandartFrequencyDictionary;
            }
            else
            {
                dictionary = EncryptedFrequencyDictionary;
            }
            for (int i = 0; i < text.Length; ++i) 
            {
                if (dictionary.ContainsKey(text[i]))
                {
                    dictionary[text[i]]++;
                }
            }
            return text;
        }
        public string DecryptFile(string filePathFrom)
        {
            string text = CreateFrequencyDictionary(filePathFrom, false);

            var standartDic = StandartFrequencyDictionary.ToList();
            standartDic.Sort((first, second) => first.Value.CompareTo(second.Value));
            var encryptedDic = EncryptedFrequencyDictionary.ToList();
            encryptedDic.Sort((first, second) => first.Value.CompareTo(second.Value));

            int index = 0;
            StringBuilder decryptedText = new StringBuilder();
            for (int i = 0; i < text.Length; ++i) 
            {
                if (EncryptedFrequencyDictionary.ContainsKey(text[i]))
                {
                    index = encryptedDic.FindIndex(pair => pair.Key == text[i]);
                    decryptedText.Append(standartDic[index].Key);
                }
                else
                {
                    decryptedText.Append(text[i]);
                }
            }
            return decryptedText.ToString();
        }
    }
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
