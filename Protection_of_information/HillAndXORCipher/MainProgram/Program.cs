using System;
using HillAndXORCipher;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePathText = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TextFiles\Text.txt";
                string filePathEncryptedTextHillCipher = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TextFiles\Hill Cipher Encrypted Text.txt";
                string filePathDecryptedTextHillCipher = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TextFiles\Hill Cipher Decrypted Text.txt";
                string filePathEncryptedTextXorCipher = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TextFiles\Xor Cipher Encrypted Text.txt";
                string filePathDecryptedTextXorCipher = AppDomain.CurrentDomain.BaseDirectory + @"..\..\TextFiles\Xor Cipher Decrypted Text.txt";

                int minimumKeywordLength = 9;

                string keyWord = "goodplace";
                while (keyWord.Length < minimumKeywordLength || Math.Sqrt(keyWord.Length) % 1 != 0)
                {
                    Console.Write("Input keyword with quantity of letters 9 and more and this quantity must be a square of integer: ");
                    keyWord = Console.ReadLine();
                }

                HillCipher hillCipher = new HillCipher();
                foreach (var elem in hillCipher.Cipher)
                {
                    Console.WriteLine($"\"{elem.Key}\" - {elem.Value}");
                }
                hillCipher.EncryptFile(filePathText, filePathEncryptedTextHillCipher, keyWord); 

                keyWord = "goodplace";
                while (keyWord.Length < minimumKeywordLength || Math.Sqrt(keyWord.Length) % 1 != 0)
                {
                    Console.Write("Input keyword with quantity of letters 9 and more and this quantity must be a square of integer: ");
                    keyWord = Console.ReadLine();
                }

                string decryptedTextHillCipher = hillCipher.DecryptFile(filePathEncryptedTextHillCipher, filePathDecryptedTextHillCipher, keyWord);
                Console.WriteLine($"Decrypted text by hill cipher:\n{decryptedTextHillCipher}\n");


                XORCipher xorCipher = new XORCipher();
                foreach (var elem in xorCipher.Cipher)
                {
                    Console.WriteLine($"\"{elem.Key}\" - {elem.Value}");
                }

                int keys = 3;
                Console.WriteLine($"Input secret key with 3 numbers from 0 to {xorCipher.Cipher.Count - 1}:");
                int[] arrKeys = new int[keys];
                int i = 0;
                while (i != keys)
                {
                    Console.WriteLine("Input number: ");
                    int item = int.Parse(Console.ReadLine());
                    if (item >= 0 && item < xorCipher.Cipher.Count)
                    {
                        arrKeys[i] = item;
                        ++i;
                    }
                    else
                    {
                        Console.WriteLine($"Number isn`t beetwen 0 and {xorCipher.Cipher.Count - 1}.");
                    }
                }
                Console.WriteLine("Keys: ");
                foreach (int elem in arrKeys) 
                {
                    Console.Write($"{elem} ");
                }
                xorCipher.EncryptFile(filePathText, filePathEncryptedTextXorCipher, arrKeys);

                string decryptedTextXorCipher = xorCipher.DecryptFile(filePathEncryptedTextXorCipher, filePathDecryptedTextXorCipher, arrKeys);
                Console.WriteLine($"\nDecrypted text by xor cipher:\n{decryptedTextXorCipher}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}
