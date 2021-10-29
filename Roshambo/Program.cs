using System;
using System.Collections.Generic;


namespace Roshambo
{
    class Program
    {
        static int Main(string[] args)
        {
            if (Validations.CheckBasicValidity(args))
            {
                Game newGame = new Game(args);
                newGame.StartGame();
            }
            else
                Interaction.PrintInvalidInputWarning();

            return 0;
        }
    }
}
