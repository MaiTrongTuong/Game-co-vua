using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    class Trooper
    {
        public int isFirstMove = 2;
        public Trooper()
        {
           
        }
        private Point GetChess(List<List<Button>> Matrix, Button button)
        {
            int row = Convert.ToInt32(button.Tag);
            int col = Matrix[row].IndexOf(button);

            Point point = new Point(row, col);
            return point;
        }
        public void CanMove(List<List<Button>> Matrix, Button button)
        {
            Point point = GetChess(Matrix,button);

            if(Matrix[point.X][point.Y].Name=="T_W")
            {
                for (int i = point.X; i >=point.X- isFirstMove; i--)
                {
                    if (Matrix[i][point.Y].Name == "NULL")
                    {
                        Matrix[i][point.Y].BackColor = Color.LightBlue;
                        Matrix[i][point.Y].Name = "A";
                    }
                }
            }
            else if(Matrix[point.X][point.Y].Name == "T_B")
            {
                for (int i = point.X; i <= point.X+isFirstMove ; i++)
                {
                    if (Matrix[i][point.Y].Name == "NULL")
                    {
                        Matrix[i][point.Y].BackColor = Color.LightBlue;
                        Matrix[i][point.Y].Name = "A";
                    }
                }
            }
            isFirstMove = 1;
        }
        public void Move(List<List<Button>> Matrix, Button source, Button Desnitation)
        {
            Point pointSource = GetChess(Matrix, source);
            Point pointDesnitation = GetChess(Matrix, Desnitation);

            Matrix[pointDesnitation.X][pointDesnitation.Y].BackgroundImage = Matrix[pointSource.X][pointSource.Y].BackgroundImage;
            Matrix[pointDesnitation.X][pointDesnitation.Y].Name = Matrix[pointSource.X][pointSource.Y].Name;

            Matrix[pointSource.X][pointSource.Y].BackgroundImage = null;

            Matrix[pointSource.X][pointSource.Y].Name = "NULL";
        }

    }
}
