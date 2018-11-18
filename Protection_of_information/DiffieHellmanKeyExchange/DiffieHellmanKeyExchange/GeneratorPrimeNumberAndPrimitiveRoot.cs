using System;
using System.Collections.Generic;

namespace DiffieHellmanKeyExchange
{
    public class GeneratorPrimeNumberAndPrimitiveRoot
    {
        // METHODS
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

        public static int GetRandomPrimeP()
        {
            Random rand = new Random();
            int randNumber = 4000;
            while (!IsPrime(randNumber))
            {
                randNumber = rand.Next(4000, 5000);
            }
            return randNumber;
        }

        private static bool IsPrimitiveRoot(int p, int a)
        {
            HashSet<int> elements = new HashSet<int>();
            int last = 1;
            for (int i = 1; i <= p - 1; ++i) 
            {
                last = (last * a) % p;
                if (elements.Contains(last)) 
                {
                    return false;
                }
                elements.Add(last);
            }
            return true;
        }

        public static int GetPrimitiveRoot(int p)
        {
            for (int i = 2; i < p; ++i) 
            {
                if (IsPrimitiveRoot(p, i))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
