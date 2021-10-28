using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    static class Interaction
    {
        static public void PrintMenu(string[] moves)
        {
            for (int i = 0; i < moves.Length; i++)
                Console.WriteLine("{0})" + moves[i], i + 1);
            Console.WriteLine("0) - exit ");
            Console.WriteLine("?) - help ");
        }

        static public string GetPlauerChoice(string mo)
    }
}
