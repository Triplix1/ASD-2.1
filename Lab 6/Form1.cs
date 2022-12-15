namespace Lab_6
{
    public partial class Form1 : Form
    {
        const int GAMERROW = 1;
        const int ROWS = 2;
        const int COLUMNS = 6;

        int playerPoints = 0;
        int computerPoints = 0;

        GameInterface game;

        AlphaBetaPruning algorithm;

        Level level = Level.Normal;

        bool playerStep = true;

        public Form1()
        {
            InitializeComponent();
            game = new GameInterface();
            algorithm = new AlphaBetaPruning(ROWS,COLUMNS);
        }

        private void buttonPoints_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int row = int.Parse(button.Name.Substring(1, 1));
            int column = int.Parse(button.Name.Substring(2, 1));
            if (row == GAMERROW && playerStep)
            {
                try
                {
                    var result = game.Step(row, column);
                    playerPoints += result;
                    l1.Text = playerPoints.ToString();
                    playerStep = false;
                    ShowBoard();                    
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            CheckEndGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!playerStep)
            {
                var node = ComputerStep();
                computerPoints = node.Points;
                l0.Text = computerPoints.ToString();
                game.Board = node.Board;
                ShowBoard();
                playerStep = true;                
            }
            CheckEndGame();
        }

        void CheckEndGame()
        {
            string message = string.Empty;
            if (game.CheckForEnd(playerPoints, computerPoints))
            {
                EndGame();
                message = playerPoints > computerPoints ? " You win!" : "You lose :(";
                
            }
            if (playerPoints == 24 && playerPoints == computerPoints)
            {
                message = "Draw!";
            }
            MessageBox.Show(message);
        }

        void EndGame()
        {
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    if (game.Board[i, j] != 0)
                    {
                        if (i == 0)
                        {
                            computerPoints += game.Board[i, j];
                        }
                        else
                        {
                            playerPoints += game.Board[i, j];
                        }
                        game.Board[i, j] = 0;
                    }
                }
            }
            l0.Text = computerPoints.ToString();
            l1.Text = playerPoints.ToString();
            ShowBoard();
        }

        Node ComputerStep()
        {
            return algorithm.GetStep(game.Board, playerPoints, computerPoints, level);
        }

        void ShowBoard()
        {
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    Button button = (Button)Controls["b" + i + j];
                    button.Text = game.Board[i,j].ToString();
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            game.Board = new Map(new int[ROWS,COLUMNS]);
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    game.Board[i, j] = 4;
                }
            }
            playerPoints = 0;
            computerPoints = 0;
            l0.Text = computerPoints.ToString();
            l1.Text = playerPoints.ToString();
            playerStep = true;
            ShowBoard();
        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            level = (Level)int.Parse(radio.Name.Substring(1,1));            
        }
    }
}