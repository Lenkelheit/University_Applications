using System;
using DiffieHellmanKeyExchange;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = GeneratorPrimeNumberAndPrimitiveRoot.GetRandomPrimeP();
            int a = GeneratorPrimeNumberAndPrimitiveRoot.GetPrimitiveRoot(p);
            Console.WriteLine($"p: {p}");
            Console.WriteLine($"a: {a}\n");

            DiffieHellmansProtocol userA = new DiffieHellmansProtocol(p, a);
            Console.WriteLine($"X by user A: {userA.X}");

            DiffieHellmansProtocol userB = new DiffieHellmansProtocol(p, a);
            Console.WriteLine($"X by user B: {userB.X}\n");

            Console.WriteLine($"Random x by user A: {userA.RandomX}");
            Console.WriteLine($"Random x by user B: {userB.RandomX}\n");

            userA.ConnectTo(userB);

            Console.WriteLine($"Key by user A: {userA.Key}");
            Console.WriteLine($"Key by user B: {userB.Key}");

            Console.ReadLine();
        }
    }
}
