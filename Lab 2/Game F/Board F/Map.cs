using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_F
{
    public class Map : ICloneable, IEqualityComparer<Map>
    {
        int size;
        int[,] map;
        public Map(int size)
        {
            this.size = size;
            map = new int [size, size];
        }
        Map(int size, int[,] map)
        {
            this.size = size;
            this.map = map;
        }
        public int Size { get => size; }
        public int this[int x, int y]
        {
            get
            {
                if (OnBoard(x, y))
                {
                    return map[x, y];
                }
                return -1;
            }
            set
            {
                if (OnBoard(x, y))
                {
                    map[x, y] = value;
                }
            }
        }
        bool OnBoard(int x, int y)
        {
            if (x < 0 || x >= size) return false;
            if (y < 0 || y >= size) return false;
            return true;
        }

        public override bool Equals(object obj)
        {
            var other = (Map)obj;
            if (other.Size != Size) return false;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (other[i, j] != this[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public override int GetHashCode()
        {
            int result = 0;
            int h = Rules.GetH(this);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result += (map[i, j] + i + j + 2) * (i+1) * (j + 1) * map[i,j]*h*(h/2+1);
                }
            }
            return result;
        }
        public object Clone()        
        {
            return new Map(this.Size, (int[,])map.Clone());
        }

        public bool Equals(Map x, Map other)
        {
            if (other.Size != x.Size) return false;
            for (int i = 0; i < x.Size; i++)
            {
                for (int j = 0; j < x.Size; j++)
                {
                    if (other[i, j] != x[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int GetHashCode([DisallowNull] Map obj)
        {
            int result = 0;
            for (int i = 0; i < obj.size; i++)
            {
                for (int j = 0; j < obj.size; j++)
                {
                    result += obj[i, j] * i * obj.size * j + 1;
                }
            }
            return result;
        }
    }
}
