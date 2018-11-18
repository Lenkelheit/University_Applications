using System;
using System.Numerics;

namespace DiffieHellmanKeyExchange
{
    public class DiffieHellmansProtocol
    {
        // FIELDS
        private static Random rand;

        // PROPERTIES
        public int P { get; private set; }
        public int A { get; private set; }
        public BigInteger X { get; private set; }
        public BigInteger Key { get; private set; }
        public int RandomX { get; private set; }

        // CONSTRUCTORS
        public DiffieHellmansProtocol(int p, int a)
        {
            P = p;
            A = a;
            RandomX = GetRandomX();
            X = BigInteger.ModPow(a, RandomX, p);
            Key = 0;
        }

        static DiffieHellmansProtocol()
        {
            rand = new Random();
        }

        // METHODS
        private int GetRandomX()
        {
            return rand.Next(2, 5000);
        }

        public void ConnectTo(DiffieHellmansProtocol userB)
        {
            BigInteger x = this.X;
            this.X = userB.X;
            userB.X = x;
            this.Key = this.CalculateKey();
            userB.Key = userB.CalculateKey();
        }

        private BigInteger CalculateKey()
        {
            return BigInteger.ModPow(X, RandomX, P);
        }
    }
}
