using ConsoleTables;
using System.Collections.Generic;
using System;

namespace Roshambo
{
    class TableGenerator
    {
        private readonly ConsoleTable winnersTable;

        public TableGenerator(string[] moves)
        {
            winnersTable = new ConsoleTable(CreateFirstRow(moves));
            LinkedList<string> results = CreateRowOfResult(moves);
            FillTable(results, moves);
        }

        private void FillTable(LinkedList<string> results, string[] moves)
        {
            LinkedListNode<string> node = results.First;
            for (int i = 0; i < moves.Length; i++)
            {
                string[] resultRow = new string[moves.Length + 1];
                resultRow[0] = moves[i];
                for (int j = 1; j < moves.Length + 1; j++, node = node.Next ?? results.First)
                    resultRow[j] = node.Value;
                winnersTable.AddRow(resultRow);
                node = node.Previous ?? results.Last;
            }
        }

        private string[] CreateFirstRow(string[] moves)
        {
            string[] firstRow = new string[moves.Length + 1];
            firstRow[0] = "PC // USER";
            moves.CopyTo(firstRow, 1);
            return firstRow;
        }

        private LinkedList<string> CreateRowOfResult(string[] moves)
        {
            LinkedList<string> results = new LinkedList<string>();
            for (int i = 0; i < moves.Length / 2; i++)
            {
                results.AddFirst("LOSE");
                results.AddLast("WIN");
            }
            results.AddFirst("DRAW");
            return results;
        }

        public void printTable() =>
            winnersTable.Write(Format.Alternative);
    }
}
