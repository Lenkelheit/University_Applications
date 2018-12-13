using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CaesarSystemAndVigenereCipher
{
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
}
