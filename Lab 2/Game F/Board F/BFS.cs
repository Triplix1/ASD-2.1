using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Board_F
{
    public static class BFS
    {
        public static List<Map> Search(Map map, out int iterations, out int angles, out int sucs)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(map, null));
            iterations = 0;
            angles = 0;
            sucs = 0;
            List<Node> successors;

            HashSet<Map> close = new HashSet<Map>();
            while (queue.Count > 0 )
            {
                iterations++;
                var current = queue.Dequeue();
                if (Rules.Complete(current))
                {
                    sucs = close.Count + queue.Count;
                    return Rules.GetPath(current);
                }
                successors = Rules.GetNeigh(current, close);
                if (successors.Count == 0)
                {
                    angles++;
                }
                for (int i = 0; i < successors.Count; i++)
                {
                    queue.Enqueue(successors[i]);
                    close.Add(successors[i].Map);
                }                
            }
            return null;
        }
    }
}
