using System;
using System.Linq;
using CaesarSystemAndVigenereCipher;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePathText = @"..\..\TextFiles\Text.txt";
                string filePathEncryptedTextCaesar = @"..\..\TextFiles\EncryptedTextCaesar.txt";
                string filePathStandartFrequency = @"..\..\TextFiles\Harry Potter.txt";
                string filePathEncryptedTextVigenere = @"..\..\TextFiles\EncryptedTextVigenere.txt";

                CaesarSystem caesarSystem = new CaesarSystem();

                Console.Write("Input keyword: ");
                string keyword = Console.ReadLine();
                Console.Write("Input key: ");
                int key = int.Parse(Console.ReadLine());

                caesarSystem.EncryptFileWithKey(filePathText, filePathEncryptedTextCaesar, keyword, key);

                foreach (var elem in caesarSystem.Cipher)
                {
                    Console.WriteLine($"\"{elem.Key}\" - \"{elem.Value}\"");
                }
                Console.WriteLine();

                string decryptedTextCaesar = caesarSystem.DecryptFileWithKey(filePathEncryptedTextCaesar);

                FrequencyAnalysis frequency = new FrequencyAnalysis();
                frequency.CreateFrequencyDictionary(filePathStandartFrequency);
                foreach (var elem in frequency.StandartFrequencyDictionary.OrderBy(pair => pair.Value))
                {
                    Console.WriteLine($"\"{elem.Key}\" - \"{elem.Value}\"");
                }

                Console.WriteLine();
                string decryptedTextFrequencyAnalysis = frequency.DecryptFile(filePathEncryptedTextCaesar);
                foreach (var elem in frequency.EncryptedFrequencyDictionary.OrderBy(pair => pair.Value))
                {
                    Console.WriteLine($"\"{elem.Key}\" - \"{elem.Value}\"");
                }

                Console.WriteLine($"Decrypted text by Caesar system with keyword and key:\n{decryptedTextCaesar}\n");
                Console.WriteLine($"Decrypted text by frequency analysis:\n{decryptedTextFrequencyAnalysis}\n");

                VigenereCipher vigenereCipher = new VigenereCipher();
                vigenereCipher.EncryptFile(filePathText, filePathEncryptedTextVigenere, keyword);

                string decryptedTextVigenereCipher = vigenereCipher.DecryptFile(filePathEncryptedTextVigenere, keyword);
                Console.WriteLine($"Decrypted text by Vigenere cipher:\n{decryptedTextVigenereCipher}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
