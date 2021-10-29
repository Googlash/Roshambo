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

        public void StartGame()
        {
            PrintBasicInterface();
            userMove = Interaction.GetPlayerMove(this.moves);
            if (userMove != null)
            {
                if (userMove == "?")
                    newGenerator.printTable();
                else if (userMove == "0")
                    Interaction.PrintMessage("Game was off!");
                else
                    PrintGameResult();
            }
            else
                Interaction.PrintUnknownMoveWorning();
        }

        private void PrintBasicInterface()
        {
            Interaction.PrintMessage("New game !\nHMAC - " + hmac.HmacHex + "\nAvailable move: ");
            Interaction.PrintMenu(moves.moves);
        }

        private void PrintGameResult()
        {
            Interaction.PrintMessage("Your move - " + userMove + "\nPC move - " + pcMove);
            Interaction.PrintMessage(this.moves.DetermineWinner(userMove, pcMove) + "won !");
            Interaction.PrintMessage("HMAC key = " + key.Key);
        }
    }
}
