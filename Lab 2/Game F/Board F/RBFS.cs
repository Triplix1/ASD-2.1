using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Board_F
{
    public class RBFS
    {
        public static List<Map> Search(Game game, ref int iterations, ref int areas, ref int check, ref int sucs)
        {
            Node current = new Node(game.Map, null);
            var close = new List<Node>();
            int infinity = int.MaxValue;
            close.Add(current);
            var result = rbfs(current, infinity, out int tmp, ref iterations, ref areas, ref check, ref sucs);
            return Rules.GetPath(result);
        }
        static Node rbfs(Node node, int flimit, out int newlimit, ref int iterations, ref int areas, ref int check, ref int sucs)
        {
            newlimit = node.F;
            iterations++;
            if (Rules.Complete(node))
            {
                return node;
            }
            List<Node> successors;
            successors = Rules.GetNeigh(node, Rules.GetPath(node));
            if (successors.Count == 0)
            {
                areas++;
                newlimit = int.MaxValue;
                return null;
            }
            int countSucs = successors.Count;
            sucs += countSucs;            
            for (int i = 0; i < successors.Count; i++)
            {
                successors[i].F = Math.Max(successors[i].F, node.F);
            }
            Sort(successors);
            while (successors.Count > 0)
            {
                check++;
                var best = successors[0];
                successors.RemoveAt(0);
                sucs--;
                if (flimit < best.F)
                {
                    sucs -= successors.Count;                 
                    newlimit = best.F;
                    return null;
                }
                int alternative = successors.Count > 0 ? successors[0].F : flimit;// Алтернативний ліміт

                Node current; //Знайдена дошка

                int change;// Новий ліміт для поточної дшки

                if (alternative < flimit)
                {
                    current = rbfs(best, alternative, out change, ref iterations, ref areas, ref check, ref sucs);
                }
                else
                {
                    current = rbfs(best, flimit, out change, ref iterations, ref areas, ref check, ref sucs);
                }

                best.F = change;

                if (current != null) return current;
                if (best.F < int.MaxValue)
                {
                    WorkWithList.Add(successors, best);
                    sucs++;
                }
            }
            newlimit = int.MaxValue;
            return null;
        }
        static void Sort(List<Node> successors)// Сортує список
        {
            for (int i = 0; i < successors.Count - 1; i++)
            {
                for (int j = i + 1; j < successors.Count; j++)
                {
                    if (successors[i].F > successors[j].F)
                    {
                        var tmp = successors[i];
                        successors[i] = successors[j];
                        successors[j] = tmp;
                    }
                }
            }
        }
    }
}
