using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    class Moves
    {
        private LinkedList<string> moves;

        public Moves(string[] moves) =>
            this.moves = new LinkedList<string>(moves);

        public string DetermineWinner(string firstMove, string secondMove)
        {
            LinkedListNode<string> node = moves.Find(firstMove).Next;

            if (firstMove == secondMove)
                return "Draw !";

            for (int i = 0; i < moves.Count / 2; i++, node = node.Next ?? moves.First)
                if (node.Value.Equals(secondMove))
                    return firstMove;

            return secondMove;
        }

        public bool CheckValidateInput(string firstMove, string secondMove)
        {
            return moves.Contains(firstMove) && moves.Contains(secondMove);
        }
    }
}
