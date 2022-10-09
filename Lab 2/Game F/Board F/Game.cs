using System;

namespace Board_F
{
    public class Game
    {
        int size;
        public int Moves { get; set; }
        Map map;
        int[] space;
        public int[] Space { get => space; set => space = value; }
        public Map Map 
        { 
            get => map;
            set 
            {
                map = value;
                FindSpace(); 
            } 
        }
        public Game(int size)
        {
            this.size = size;
            map = new Map(size);
        }

        public void Start(int seed = 0)
        {
            int digit = 0;
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    map[y, x] = ++digit;
                }
            }

            space = new int[2] { size-1, size-1};

            if (seed > 0)
            {
                Shufle(seed);
            }

            Moves = 0;
        }

        void Shufle(int seed)
        {
            Random rand = new Random(seed);
            for (int i = 0; i < seed; i++)
            {
                PressAt(rand.Next(size), rand.Next(size));
            }
        }

        public int PressAt(int x, int y)
        {
            if ((Math.Abs(x - space[0]) == 1 && y == space[1]) || (Math.Abs(y - space[1]) == 1 && x == space[0]))
            {
                Shift(x, y);
                Moves++;
                return 1;
            }
            return 0;
        }

        void Shift(int x, int y)
        {
            map[space[0], space[1]] = map[x, y];
            map[x, y] = size*size;
            space[0] = x;
            space[1] = y;
        } 
        public int GetDigitAt(int x, int y)
        {
            return map[x,y];
        }
        public bool Solved()
        {
            if (space[0] != size-1 || space[1] != size -1)
            {
                return false;
            }
            int digit = 0;
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (map[x,y] != ++digit)
                    {
                        return false;
                    }                    
                }
            }
            return true;
        }   
        void FindSpace()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (map[i,j] == size*size)
                    {
                        space[0] = i;
                        space[1] = j;
                        return;
                    }
                }
            }
        }
    }
}
