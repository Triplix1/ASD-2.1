using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class GameInterface
    {
        const int ROWS = 2;
        const int COLUMNS = 6;
        public Map Board { get; set; }

        public GameInterface()
        {
            Board = new Map();
        }

        public int Step(int row, int column)
        {
            return Board.Step(row, column);
        }

        public bool CheckForEnd(int playerPoints, int computerPoints)
        {
            if (playerPoints > 24 || computerPoints > 24)
            {
                return true;
            }

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    if (Board[i,j] != 0)
                    {
                        break;
                    }
                    if (j == COLUMNS - 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
