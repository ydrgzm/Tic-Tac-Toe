using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Classes;

namespace TicTacToe
{
    public partial class MainForm : MaterialForm
    {
        private int HighScore = 0;
        private int Turn = 0;
        private int[,] matrix = new int[3, 3];

        public MainForm()
        {
            InitializeComponent();
            MaterialInit();
            ChangeTurn();
        }
        private void MaterialInit()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            ColorScheme colorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.ColorScheme = colorScheme;
        }

        private void highScoreBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, $"Highest Score is {HighScore}.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            playControl.SelectedTab = playPage;
            Reset();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            playControl.SelectedTab = startPage;
        }

        private void cell1_Click(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Image != null)
                return;
            if (Turn == 0)
            {
                (sender as PictureBox).Image = Properties.Resources.icons8_circle_72px;
                FillMatrix(sender);
                Turn = 1;
            }
            else if (Turn == 1)
            {
                (sender as PictureBox).Image = Properties.Resources.icons8_cross_mark_72px;
                FillMatrix(sender);
                Turn = 0;
            }
            if (IsGameOver())
            {
                Reset();
                playControl.SelectedTab = startPage;
            }

            ChangeTurn();
        }

        private void ChangeTurn()
        {
            if (Turn == 0)
            {
                p1Lbl.BackColor = Color.Green;
                p2Lbl.BackColor = Color.White;
            }
            else
            {
                p2Lbl.BackColor = Color.Green;
                p1Lbl.BackColor = Color.White;
            }
        }
        private void FillMatrix(Object sender)
        {
            int row = Convert.ToInt32((sender as PictureBox).Name[4].ToString()) ;
            int col = Convert.ToInt32((sender as PictureBox).Name[5].ToString()) ;
            matrix[row, col] = Turn + 1;
        }
        private bool HorizontalCheck(int player)
        {
            bool p1 = true;
            for (int r = 0; r < 3; r++)
            {
                p1 = true;
                for (int c = 0; c < 3; c++)
                {
                    if (matrix[r, c] == player)
                    {
                        p1 = p1 && true;
                    }
                    else
                    {
                        p1 = p1 && false;
                    }
                }
                if (p1)
                {
                    return true;
                }
            }
            return p1;
        }
        private bool VerticalCheck(int player)
        {
            bool p1 = true;
            for (int r = 0; r < 3; r++)
            {
                p1 = true;
                for (int c = 0; c < 3; c++)
                {
                    if (matrix[c, r] == player)
                    {
                        p1 = p1 && true;
                    }
                    else
                    {
                        p1 = p1 && false;
                    }
                }
                if (p1)
                {
                    return true;
                }
            }
            return p1;
        }
        private bool DiagonalCheck(int player)
        {
            bool p1 = true;
            for (int r = 0; r < 3; r++)
            {
                if (matrix[r, r] == player)
                {
                    p1 = p1 && true;
                }
                else
                {
                    p1 = p1 && false;
                }
            }
            if (p1)
            {
                return p1;
            }
            for (int r = 0; r < 3; r++)
            {
                if (matrix[r, 2 -r] == player)
                {
                    p1 = p1 && true;
                }
                else
                {
                    p1 = p1 && false;
                }
            }
            return p1;
        }
        private bool IsGameOver()
        {
            // For Player 1
            if (HorizontalCheck(1))
            {
                MessageBox.Show("Player 1 Wins!");
                return true;
            }
            if (VerticalCheck(1))
            {
                MessageBox.Show("Player 1 Wins!");
                return true;
            }
            if (DiagonalCheck(1))
            {
                MessageBox.Show("Player 1 Wins!");
                return true;
            }
            // For Player 2
            if (HorizontalCheck(2))
            {
                MessageBox.Show("Player 2 Wins!");
                return true;
            }
            if (VerticalCheck(2))
            {
                MessageBox.Show("Player 2 Wins!");
                return true;
            }
            if (DiagonalCheck(2))
            {
                MessageBox.Show("Player 2 Wins!");
                return true;
            }
            return false;
        }
        private void Reset()
        {
            matrix = new int[3, 3];
            foreach (Control item in panel2.Controls)
            {
                if (item.Name.Contains("cell"))
                {
                    (item as PictureBox).Image = null;
                }
            }
        }
    }
    
}
