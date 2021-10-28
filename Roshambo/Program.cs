using System;
using System.Collections.Generic;

namespace Roshambo
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args == null || args.Length % 2 == 0)
                Interaction.PrintInvalidInputWarning();
            else 
            {
                Game newGame = new Game(args);
                newGame.StartGame(args);
            }

            return 0;
        }
    }
}
