using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Node : ICloneable
    {
        public int OponentPoints { get; set; }
        public int Points { get; set; }
        public Map Board { get; set; }
        public Node(int oponentPoints, int points, Map board)
        {
            OponentPoints = oponentPoints;
            Points = points;
            Board = board;
        }

        public object Clone()
        {
            return new Node(OponentPoints, Points, (Map)Board.Clone());
        }
    }
}
