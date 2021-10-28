using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    class Game
    {
        private Moves moves;
        private KeyGenerator key;
        private TableGenerator newGenerator;
        private HmacGenerator hmac;
        private string pcMove;
        private string userMove;

        public Game(string[] moves)
        {
                this.moves = new Moves(moves);
                newGenerator = new TableGenerator(moves);
                key = new KeyGenerator();
                pcMove = key.GetRandomMove(moves);
                hmac = new HmacGenerator(key.Key, pcMove);
        }

        public void StartGame(string[] moves)
        {
            Console.WriteLine("New game !");
            Console.WriteLine("HMAC - {0}", hmac.HmacHex);
            Console.WriteLine("Available move: ");
            Interaction.PrintMenu(moves);
            userMove = Interaction.GetPlayerMove(this.moves);
            if (userMove != null)
            {
                if (userMove == "?")
                    newGenerator.printTable();
                else if (userMove == "0")
                { }
                else
                {
                    Console.WriteLine("Your move - {0} ", userMove);
                    Console.WriteLine("PC move - {0} ", pcMove);
                    if (userMove == pcMove)
                        Console.WriteLine("Draw !");
                    else if (this.moves.DetermineWinner(userMove, pcMove) == userMove)
                        Console.WriteLine("You won !!!");
                    else 
                        Console.WriteLine("PC won ");
                    Console.WriteLine("HMAC key = {0}", key.Key);
                }
            }
            else
                Interaction.PrintUnknownMoveWorning();
        }
    }
}
