using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Roshambo
{
    class HmacGenerator
    {
        string hmacHex = "";

        public HmacGenerator(string key, string move)
        {
            HMACSHA256 hmac = new HMACSHA256(Encoding.Default.GetBytes(key));

            hmac.ComputeHash(Encoding.Default.GetBytes(move));

            foreach (byte item in hmac.Hash)
                hmacHex += item.ToString("X");
        }

        public string HmacHex
        { get => hmacHex; }
    }
}
