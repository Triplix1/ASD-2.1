using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board_F
{
    internal class Node
    {
        public Map Map { get; set; }
        Node parent = null;
        int h;
        int f;
        int g;
        public int H { get => h; }
        public int F { get => f; set { f = value; } }
        public int G { get => g; }
        public Node Parent { get => parent; }
        public Node(Map map, Node parent)
        {
            this.Map = map;
            this.parent = parent;
            h = Rules.GetH(map);
            g = Rules.GetG(parent);
            f = Rules.GetF(h,g);
        }
    }
}
