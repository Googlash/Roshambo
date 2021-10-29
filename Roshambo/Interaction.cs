using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    static class Interaction
    {
        static public void PrintMenu(LinkedList<string> moves)
        {
            foreach (string move in moves)
                Console.WriteLine(move);
            Console.WriteLine("0 - exit\n? - help");
        }

        static public void PrintInvalidInputWarning() =>
            Console.WriteLine("number of moves must be odd, greater than or equal to three and each move must be unique...");

        static public void PrintUnknownMoveWorning() =>
            Console.WriteLine("This move is not definded !");

        static public void PrintMessage(string message) =>
            Console.WriteLine(message);

        static public string GetPlayerMove(Moves moves)
        {
            Console.WriteLine("Enter your move ...");
            string move = Console.ReadLine();
            if (Validations.CheckValidateMove(moves.moves, move))
                return move;
            else
                return null;
        }
    }
}
