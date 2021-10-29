using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    static class Validations
    {
        static public bool CheckBasicValidity(string[] moves)
        {
            return moves != null && moves.Length % 2 != 0 && moves.Length != 1 && moves.Distinct().Count() == moves.Length;
        }
        static public bool CheckValidateMove(LinkedList<string> moves, string move)
        {
            return moves.Contains(move) || move == "?" || move == "0";
        }
    }
}
