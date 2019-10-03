using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    public class Manager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }


        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private int panelWidth;
        public int PanelWidth
        {
            set { panelWidth = value; }
            get { return panelWidth; }
        }

        private int panelHeight;
        public int PanelHeight
        {
            set { panelHeight = value; }
            get { return panelHeight; }
        }

        public int buttonColor = 1;

        #endregion

        #region Initialize
        public Manager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }
        public Button sourceButton;
        public Button desnitationButton;
        #endregion

        #region Methods
        public void DrawPanelChessBoard()
        {
            ChessBoard.Controls.Clear();

            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < 8; i++)
            {
                buttonColor = (buttonColor == 0) ? 1 : 0;
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= 8; j++)
                {
                    Button button = new Button()
                    {
                        Width = 80,
                        Height = 80,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    SetImage(button, i, j);

                    if (buttonColor == 1)
                    {
                        button.BackColor = Color.BurlyWood;
                    }

                    buttonColor = (buttonColor == 0) ? 1 : 0;

                    button.Click += button_Click;

                    ChessBoard.Controls.Add(button);

                    Matrix[i].Add(button);

                    oldButton = button;
                }
                buttonColor = (buttonColor == 0) ? 1 : 0;
                oldButton.Location = new Point(0, oldButton.Location.Y + 70);
                oldButton.Width = 0;
                oldButton.Height = 0;


            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            Trooper t = new Trooper();

            if (button.Name != "NULL" && button.Name != "A")
            {
                sourceButton = button;
              
                t.CanMove(Matrix, button);
            }
            if(button.Name=="A")
            {
                desnitationButton = button;
                t.Move(Matrix, sourceButton, desnitationButton);
            }


        }

        public void SizePanel()
        {
            PanelHeight = 8 * 70;
            PanelWidth = 8 * 70;

            ChessBoard.Size = new System.Drawing.Size(PanelWidth, PanelHeight);
        }

        public void LocationPanel()
        {
            ChessBoard.Location = new Point(100, 20);
        }


        public void SetImage(Button button, int i, int j)
        {
            if (i == 0)
            {
                switch (j)
                {
                    case 0:
                        button.BackgroundImage = Properties.Resources.Rook;
                        button.Name = "R_B";
                        break;
                    case 1:
                        button.BackgroundImage = Properties.Resources.Knight;
                        button.Name = "N_B";
                        break;
                    case 2:
                        button.BackgroundImage = Properties.Resources.Bishop;
                        button.Name = "B_B";
                        break;
                    case 3:
                        button.BackgroundImage = Properties.Resources.Queen;
                        button.Name = "Q_B";
                        break;
                    case 4:
                        button.BackgroundImage = Properties.Resources.King;
                        button.Name = "K_B";
                        break;
                    case 5:
                        button.BackgroundImage = Properties.Resources.Bishop;
                        button.Name = "B_B";
                        break;
                    case 6:
                        button.BackgroundImage = Properties.Resources.Knight;
                        button.Name = "N_B";
                        break;

                    case 7:
                        button.BackgroundImage = Properties.Resources.Rook;
                        button.Name = "R_B";
                        break;
                }
            }
            else if (i == 7)
            {
                switch (j)
                {
                    case 0:
                        button.BackgroundImage = Properties.Resources.RookWhite;
                        button.Name = "R_W";
                        break;
                    case 1:
                        button.BackgroundImage = Properties.Resources.KnightWhite;
                        button.Name = "N_W";
                        break;
                    case 2:
                        button.BackgroundImage = Properties.Resources.BishopWhite;
                        button.Name = "B_W";
                        break;
                    case 3:
                        button.BackgroundImage = Properties.Resources.QueenWhite;
                        button.Name = "Q_W";
                        break;
                    case 4:
                        button.BackgroundImage = Properties.Resources.KingWhite;
                        button.Name = "K_W";
                        break;
                    case 5:
                        button.BackgroundImage = Properties.Resources.BishopWhite;
                        button.Name = "B_W";
                        break;
                    case 6:
                        button.BackgroundImage = Properties.Resources.KnightWhite;
                        button.Name = "N_W";
                        break;

                    case 7:
                        button.BackgroundImage = Properties.Resources.RookWhite;
                        button.Name = "R_W";
                        break;
                }
            }
            else if(i==1)
            {
                button.BackgroundImage = Properties.Resources.Trooper;
                button.Name = "T_B";
            }
            else if(i==6)
            {
                button.BackgroundImage = Properties.Resources.TrooperWhite;
                button.Name = "T_W";
            }
            else
            {
                button.Name = "NULL";
            }
        }
            #endregion
    }
}
