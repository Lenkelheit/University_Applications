using System;
using System.Text;
using System.IO;

namespace BBSCipher
{
    public class GeneratorBBSCipher
    {
        // PROPERTIES
        public int N { get; private set; }
        public int X { get; private set; }

        // CONSTRUCTOR
        public GeneratorBBSCipher(int p, int q)
        {
            N = p * q;
            X = GetRandomMutuallySimpleXWithN();
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

        private int GetRandomMutuallySimpleXWithN()
        {
            Random rand = new Random();
            int randNumber = 100;
            while (!IsPrime(randNumber) || ExtendedEuclideanAlgorithm(randNumber, N, out int x, out int y) != 1)
            {
                randNumber = rand.Next(100, 1000);
            }
            return randNumber;
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckIsGoodConditionsForBBSCipher(int p, int q)
        {
            return (IsPrime(p) && IsPrime(q) && p % 4 == 3 && q % 4 == 3);
        }

        private string EncryptLine(string line)
        {
            int prevX = X, newX = 0, s = 0;
            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < line.Length; ++i)
            {
                newX = (int)(Math.Pow(prevX, 2) % N);
                s = newX % 2;
                prevX = newX;
                encryptedText.Append((char)(s ^ line[i]));
            }
            return encryptedText.ToString();
        }

        public string EncryptFile(string fromFilePath, string toFilePath, out string text)
        {
            if (!File.Exists(fromFilePath))
            {
                throw new FileNotFoundException($"File {fromFilePath} isn`t found.");
            }

            text = "";
            using (StreamReader streamReader = new StreamReader(fromFilePath))
            {
                text = streamReader.ReadToEnd();
            }

            string encryptedText = EncryptLine(text);

            using (StreamWriter streamWriter = new StreamWriter(toFilePath))
            {
                streamWriter.Write(encryptedText);
            }
            return encryptedText;
        }

        public string DecryptFile(string fromFilePath, string toFilePath)
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

            string decryptedText = EncryptLine(encryptedText);

            using (StreamWriter streamWriter = new StreamWriter(toFilePath))
            {
                streamWriter.Write(decryptedText);
            }
            return decryptedText;
        }
    }
}
