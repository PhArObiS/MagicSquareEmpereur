using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquareEmpereur
{
    internal class MagicSquare
    {
        private int[,] square;

        public MagicSquare(int x)
        {
            if (x < 3 || x > 20)
            {
                throw new ArgumentException("Dimension non valide. La dimension doit être comprise entre 3 et 20.");
            }

            square = new int[x, x];

            int row = 0;
            int col = x / 2;
            int num = 1;

            while (num <= x * x)
            {
                square[row, col] = num;

                int nextRow = (row - 1 + x) % x;
                int nextCol = (col + 1) % x;

                if (square[nextRow, nextCol] == 0)
                {
                    row = nextRow;
                    col = nextCol;
                }
                else
                {
                    row = (row + 1) % x;
                }

                num++;
            }
        }

        public void Print()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("***************** Carré Magique ********************");
            Console.WriteLine("----------------------------------------------------");

            int squareDimension = square.GetLength(0);

            for (int i = 0; i < squareDimension; i++)
            {
                for (int j = 0; j < squareDimension; j++)
                {
                    Console.Write("{0,4}", square[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
