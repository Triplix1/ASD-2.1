using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Map : ICloneable
    {
        const int ROWS = 2;
        const int COLUMNS = 6;
        const int DEFAULTVALUE = 4;

        int[,] Board { get; set; }
        public Map()
        {
            Board = new int[ROWS, COLUMNS];
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    Board[i, j] = DEFAULTVALUE;
                }
            }
        }
        public Map(int[,] board)
        {
            Board = board;
        }
        public int this[int row, int column]
        {
            get
            {
                return Board[row, column];
            }
            set
            {
                Board[row, column] = value;
            }
        }
        public int Step(int row, int column)
        {
            if (row < 0 || column < 0
                || row >= Board.GetLength(0)
                || column >= Board.GetLength(1))
            {
                throw new ArgumentException("Unexepted arguments!");
            }
            if (Board[row, column] == 0)
            {
                throw new ArgumentException("This box is empty!");
            }

            int rowTmp = row;
            int columnTmp = column;
            int count = 0;

            if (row == 0)
            {
                while (count < Board[row, column])
                {
                    for (columnTmp = columnTmp - 1; columnTmp >= 0 && count < Board[row, column]; columnTmp--)
                    {
                        if (columnTmp != column)
                        {
                            Board[0, columnTmp]++;
                            count++;
                        }
                        rowTmp = 0;
                    }
                    for (columnTmp = columnTmp + 1; columnTmp < Board.GetLength(1) && count < Board[row, column]; columnTmp++)
                    {
                        Board[1, columnTmp]++;
                        count++;
                        rowTmp = 1;
                    }
                }
            }
            else
            {
                while (count < Board[row, column])
                {
                    for (columnTmp = columnTmp + 1; columnTmp < Board.GetLength(1) && count < Board[row, column]; columnTmp++)
                    {
                        if (columnTmp != column)
                        {
                            Board[1, columnTmp]++;
                            count++;
                        }
                        rowTmp = 1;
                    }

                    for (columnTmp = columnTmp - 1; columnTmp >= 0 && count < Board[row, column]; columnTmp--)
                    {
                        Board[0, columnTmp]++;
                        count++;
                        rowTmp = 0;
                    }
                }
            }
            Board[row, column] = 0;
            return GetPoints(row, column, rowTmp, columnTmp);

        }

        int GetPoints(int inputRow, int inputColumn, int currentRow, int currentColumn)
        {
            int result = 0;
            if (currentRow != inputRow)
            {
                if (currentRow == 1)
                {
                    for (currentColumn = currentColumn - 1; currentColumn >= 0; currentColumn--)
                    {
                        if (Board[1, currentColumn] == 2 || Board[1, currentColumn] == 3)
                        {
                            result += Board[1, currentColumn];
                            Board[1, currentColumn] = 0;
                        }
                        else
                        {
                            return result;
                        }
                    }
                }
                else
                {
                    for (currentColumn = currentColumn + 1; currentColumn < Board.GetLength(1); currentColumn++)
                    {
                        if (Board[0, currentColumn] == 2 || Board[0, currentColumn] == 3)
                        {
                            result += Board[0, currentColumn];
                            Board[0, currentColumn] = 0;
                        }
                        else
                        {
                            return result;
                        }
                    }
                }
            }
            return result;
        }

        public object Clone()
        {
            return new Map((int[,])Board.Clone());
        }
    }
}
