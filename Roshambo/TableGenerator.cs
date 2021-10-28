using ConsoleTables;
using System.Collections.Generic;
using System;

namespace Roshambo
{
    class TableGenerator
    {
        private ConsoleTable winnersTable;

        public TableGenerator(string[] moves)
        {
            string[] firstRow = new string[moves.Length + 1];
            LinkedList<string> results = new LinkedList<string>();

            firstRow[0] = "PC // USER";
            moves.CopyTo(firstRow, 1);

            results.AddLast("DRAW");
            for (int i = 0; i < moves.Length / 2; i++)
            {
                results.AddLast("LOSE");
            }
            for (int i = 0; i < moves.Length / 2; i++)
            {
                results.AddLast("WIN");
            }

            winnersTable = new ConsoleTable(firstRow);


            LinkedListNode<string> node = results.First;
            for (int i = 0; i < moves.Length; i++)
            {
                string[] resultRow = new string[moves.Length + 1];
                resultRow[0] = moves[i];
                for (int j = 1; j < moves.Length + 1; j++, node = node.Next ?? results.First)
                {
                    resultRow[j] = node.Value;
                }
                winnersTable.AddRow(resultRow);
                node = node.Previous ?? results.Last;
            }
        }

        public void printTable() =>
            winnersTable.Write(Format.Alternative);
    }
}
