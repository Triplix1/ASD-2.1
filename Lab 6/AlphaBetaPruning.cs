using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public enum Level
    {
        Easy = 1,
        Normal,
        Hard
    }
    public class AlphaBetaPruning
    {
        static int MAX = int.MaxValue;
        static int MIN = int.MinValue;
        readonly int rows;
        readonly int columns;

        public AlphaBetaPruning(int rows, int cols)
        {
            this.rows = rows;
            this.columns = cols;
        }
        
        public Node GetStep(Map current, int oponentPoints, int points, Level level)
        {
            var (tmp, board) = MiniMax(1, new Node(oponentPoints, points, current), true, int.MinValue, int.MaxValue, level);
            return board;
        }

        (int, Node) MiniMax(int depth, Node node, bool maximizingPlayer, int alpha, int beta, Level level)
        {
            int computeDepth = (int)((int)level * 1.6);

            if (depth == computeDepth)
            {
                if (level == Level.Hard)
                {
                    return (node.Points - node.OponentPoints + NumberNonEmpty(node), node);
                }
                else
                {
                    return (node.Points - node.OponentPoints, node);
                }
            }                

            if (maximizingPlayer)
            {
                int best = MIN;

                Node bestBoard = null;

                var successors = GetComputerSuccessors(node);
                for (int i = 0; i < successors.Count; i++)
                {
                    var (val,tmp) = MiniMax(depth + 1, successors[i],
                                    false, alpha, beta, level);
                    (best, bestBoard) = best > val ? (best, bestBoard) : (val,successors[i]);
                    alpha = Math.Max(alpha, best);

                    if (beta <= alpha)
                        break;
                }
                return (best, bestBoard);
            }
            else
            {
                int best = MAX;

                Node bestBoard = null;

                var successors = GetOponentSuccessors(node);

                for (int i = 0; i < successors.Count; i++)
                {

                    var (val, tmp) = MiniMax(depth + 1, successors[i],
                                    true, alpha, beta, level);
                    (best, bestBoard) = best < val ? (best, bestBoard) : (val, successors[i]);
                    beta = Math.Min(beta, best);

                    if (beta <= alpha)
                        break;
                }
                return (best,bestBoard);
            }
        }
        List<Node> GetComputerSuccessors(Node node)
        {
            List<Node> successors = new List<Node>();
            for (int i = 0; i < columns; i++)
            {
                var tmp = (Node)node.Clone();
                if (node.Board[0,i] != 0)
                {
                    var pointChange = tmp.Board.Step(0, i);
                    tmp.Points += pointChange;
                    successors.Add(tmp);
                }               
            }
            return successors;
        }
        List<Node> GetOponentSuccessors(Node node)
        {
            List<Node> successors = new List<Node>();
            for (int i = 1; i < columns; i++)
            {
                var tmp = (Node)node.Clone();
                try
                {
                    var pointChange = tmp.Board.Step(0, i);
                    tmp.Points += pointChange;
                    successors.Add(tmp);
                }
                catch { }
            }
            return successors;
        }
        int NumberNonEmpty(Node node)
        {
            int result = 0;
            for (int i = 1; i < columns; i++)
            {
                if (node.Board[0, i] != 0)
                {
                    result++;
                }
                if (node.Board[1,i] != 0)
                {
                    result--;
                }
            }
            return result;
        }
    }
}
