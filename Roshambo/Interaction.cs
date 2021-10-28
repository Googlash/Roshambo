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
            foreach (string move in moves)
                Console.WriteLine(move);
            Console.WriteLine("0 - exit ");
            Console.WriteLine("? - help ");
        }

        static public void PrintInvalidInputWarning() =>
            Console.WriteLine("Enter odd number of moves ...");

        static public void PrintUnknownMoveWorning() =>
            Console.WriteLine("This move is not definded !");

        //Return null if move is not definded
        static public string GetPlayerMove(Moves moves)
        {
            Console.WriteLine("Enter your move ...");
            string move = Console.ReadLine();
            if (moves.CheckValidateMove(move) || move == "?" || move == "0")
                return move;
            else
                return null;
        }
    }
}
