using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    class Moves
    {
        public readonly LinkedList<string> moves;

        public Moves(string[] moves) =>
            this.moves = new LinkedList<string>(moves);

        public string DetermineWinner(string firstMove, string secondMove)
        {
            LinkedListNode<string> node = moves.Find(firstMove).Next;
            if (firstMove == secondMove)
                return "Frendship ";
            for (int i = 0; i < moves.Count / 2; i++, node = node.Next ?? moves.First)
                if (node.Value.Equals(secondMove))
                    return "You ";
            return "PC ";
        }
    }
}
