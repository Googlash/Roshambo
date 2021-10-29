using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Roshambo
{
    class KeyGenerator
    {
        private string key = "";
        private const int keyLength = 128;

        public KeyGenerator()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] byteKey = new byte[keyLength / 8];
            rng.GetBytes(byteKey);
            foreach (byte item in byteKey)
                key += item.ToString("X");
        }

        public string GetRandomMove(string[] moves)
        {
            return moves[RandomNumberGenerator.GetInt32(moves.Length)];
        }

        public string Key 
        {get => key; }
    }
}
