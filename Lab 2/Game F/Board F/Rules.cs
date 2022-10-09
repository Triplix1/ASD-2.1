using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_F
{
    internal static class Rules
    {
        public static List<Map> GetPath(Node current)//Повернення шляху до поточного стану грального поля
        {
            List<Map> boards = new List<Map>();
            while (current.Parent != null)
            {
                boards.Add(current.Map);
                current = current.Parent;
            }
            boards.Reverse();
            return boards;
        }
        public static List<Node> GetNeigh<T>(Node current, T close) where T : ICollection<Map>
        {
            List<Node> list = new List<Node>();
            int size = current.Map.Size;
            Map map = (Map)current.Map.Clone();
            int[] space = new int[2];
            Node tmp;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (current.Map[i, j] == Math.Pow(size, 2))
                    {
                        space[0] = i;
                        space[1] = j;
                        break;
                    }
                }
            }
            if (space[0] < size - 1)
            {
                map[space[0], space[1]] = map[space[0] + 1, space[1]];
                map[space[0] + 1, space[1]] = size * size;
                tmp = new Node(map, current);
                if (!close.Contains(map))
                {
                    list.Add(tmp);
                }
                map = (Map)current.Map.Clone();
            }
            if (space[0] > 0)
            {
                map[space[0], space[1]] = map[space[0] - 1, space[1]];
                map[space[0] - 1, space[1]] = size * size;
                tmp = new Node(map, current);
                if (!close.Contains(map))
                {
                    list.Add(tmp);
                }
                map = (Map)current.Map.Clone();
            }
            if (space[1] < size - 1)
            {
                map[space[0], space[1]] = map[space[0], space[1] + 1];
                map[space[0], space[1] + 1] = size * size;
                tmp = new Node(map, current);
                if (!close.Contains(map))
                {
                    list.Add(tmp);
                }
                map = (Map)current.Map.Clone();
            }
            if (space[1] > 0)
            {
                map[space[0], space[1]] = map[space[0], space[1] - 1];
                map[space[0], space[1] - 1] = size * size;
                tmp = new Node(map, current);
                if (!close.Contains(map))
                {
                    list.Add(tmp);
                }
                map = (Map)current.Map.Clone();
            }
            return list;
        }
        
        public static int GetH(Map map)
        {
            int result = 0;
            for (int i = 0; i < map.Size; i++)
            {
                for (int j = 0; j < map.Size; j++)
                {
                    if (map[i, j] != i * map.Size + j + 1 && map[i, j] != map.Size * map.Size)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
        public static int GetG(Node map)
        {
            if (map == null)
            {
                return 0;
            }
            return 1 + map.G;
        }
        public static int GetF(int h, int g)
        {
            return h + g;
        }
        public static bool Complete(Node node)
        {
            return node.H == 0;
        }
    }
}
