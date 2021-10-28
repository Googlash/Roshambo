using System;
using System.Collections.Generic;

namespace Roshambo
{
    class Program
    {
        static int Main(string[] args)
        {
            Moves moves = new Moves(args);
            KeyGenerator key = new KeyGenerator();
            TableGenerator newGenerator = new TableGenerator(args);

            Console.WriteLine("New game !");

            string pcMove = key.GetRandomMove(args), userMove = "";
            key.GetHashCode();
            HmacGenerator hmac = new HmacGenerator(key.Key, pcMove);

            Console.WriteLine("HMAC - {0}", hmac.HmacHex);
            Console.WriteLine("Available move: ");

            Interaction.PrintMenu(args);
            Console.WriteLine("Enter your move ...");

            string choice = Console.ReadLine();

            if (choice == "?")
            {
                newGenerator.printTable();
                return 0;
            }
            else if (choice == "0")
                return 0;

            userMove = args[int.Parse(choice)];



            Console.WriteLine("Your move - {0} ", userMove);
            Console.WriteLine("PC move - {0} ", pcMove);

            if (moves.DetermineWinner(userMove, pcMove) == userMove)
                Console.WriteLine("You won !!!");
            else
                Console.WriteLine("PC won ");


            Console.WriteLine("HMAC key = {0}", key.Key);

            return 0;
        }
    }
}
