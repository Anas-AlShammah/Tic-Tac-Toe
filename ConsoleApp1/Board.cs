using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Board
    {
        public string[,] GameBoard = new string[,]
        {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
        };
        public void DisplayBoard()
        {

            //TODO: Output the board to the console
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(GameBoard[i,j]+"|");
                }
                Console.Write(GameBoard[i, 2]);
                Console.WriteLine("-------");
                Console.WriteLine();
            }

        }
    }
}
