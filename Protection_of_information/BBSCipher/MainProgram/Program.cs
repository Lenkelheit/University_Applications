using System;
using BBSCipher;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"..\..\TextFiles\Text.txt";
            string encryptedTextFilePath = @"..\..\TextFiles\Encrypted Text.txt";
            string decryptedTextFilePath = @"..\..\TextFiles\Decrypted Text.txt";

            int p = 0, q = 0;
            while (!GeneratorBBSCipher.CheckIsGoodConditionsForBBSCipher(p, q)) 
            {
                Console.Write("Input p: ");
                p = int.Parse(Console.ReadLine());

                Console.Write("Input q: ");
                q = int.Parse(Console.ReadLine());
            }

            GeneratorBBSCipher BBSCipher = new GeneratorBBSCipher(p, q);
            Console.WriteLine($"n: {BBSCipher.N}");
            Console.WriteLine($"x: {BBSCipher.X}");

            string text;
            string encryptedText = BBSCipher.EncryptFile(textFilePath, encryptedTextFilePath, out text);
            Console.WriteLine($"Original text:\n{text}\n");
            Console.WriteLine($"Encrypted text:\n{encryptedText}\n");

            string decryptedText = BBSCipher.DecryptFile(encryptedTextFilePath, decryptedTextFilePath);

            Console.WriteLine($"Decrypted text:\n{decryptedText}");

            Console.ReadLine();
        }
    }
}
