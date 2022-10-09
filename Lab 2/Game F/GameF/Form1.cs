using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Board_F;

namespace GameF
{
    
    public partial class Form1 : Form
    {
        List<Map> result = new List<Map>();
        int current;
        Game game;
        const int size = 3;
        public Form1()
        {
            InitializeComponent();
            game = new Game(size);
            HideButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (game.Solved())
            {
                return;
            }
            Button button = (Button)sender;
            int x = int.Parse(button.Name.Substring(1,1));
            int y = int.Parse(button.Name.Substring(2,1));
            game.PressAt(x, y);
            ShowButtons();
            if (game.Solved())
            {
                MessageBox.Show($"You end game in {game.Moves.ToString()} moves!");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            game.Start(rand.Next(10000,100000)); //(1000 + DateTime.Now.DayOfYear);
            ShowButtons();
        }

        void HideButtons()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    ShowDigitAt(0, i, j);
                }
            }
        }

        void ShowButtons()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    ShowDigitAt(game.GetDigitAt(i, j), i, j);
                }
            }
            labelMoves.Text = game.Moves.ToString();
        }

        void ShowDigitAt(int digit, int x, int y)
        {
            Button button = (Button)Controls["b" + x + y];
            button.Text = digit.ToString();
            button.Visible = digit != size*size;
        }

        private void rbfs_Click(object sender, EventArgs e)
        {
            int n = 0; int iterations = 0; int angles = 0; int sucs = 0; int check = 0;
            result = new List<Map> { game.Map};
            result.AddRange(RBFS.Search(game, ref iterations, ref angles, ref check, ref sucs));
            current = 0;
            game.Map = result.Count == 1 ? game.Map : result[result.Count - 1];
            game.Moves = result.Count == 1 ? 0 : result.Count - 1 ;
            game.Space = new int[2] { 2, 2 };
            Iter.Text = iterations.ToString();
            Angle.Text = angles.ToString();
            Checked.Text = check.ToString();
            Successors.Text = sucs.ToString();
            ShowButtons();
        }

        private void Step_Click(object sender, EventArgs e)
        {
            if (result != null)
            {
                game.Map = result[current % result.Count];
                current++;
                ShowButtons();
            }
        }

        private void bfs_Click(object sender, EventArgs e)
        {
            result = new List<Map> { game.Map };
            result.AddRange(BFS.Search(game.Map, out int iterations, out int angles, out int sucs));
            current = 0;
            game.Map = result.Count == 1 ? game.Map : result[result.Count - 1];
            game.Moves = result.Count == 1 ? 0 : result.Count - 1;
            game.Space = new int[2] { 2, 2 };
            Iter.Text = iterations.ToString();
            Angle.Text = angles.ToString();
            Checked.Text = iterations.ToString();
            Successors.Text = sucs.ToString();
            ShowButtons();
        }
    }
}
