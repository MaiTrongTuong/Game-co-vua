using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoVuaGame
{
    class Queen
    {
        public void CanMove(List<List<Button>> Matrix, Point point)
        {
            if (Matrix[point.X][point.Y].Name == "B_Q" || Matrix[point.X][point.Y].Name == "W_Q")
            {
                    if (point.X - 1 >= 0)
                    {
                        for (int i = point.X - 1; i >= point.X - 1; i--)//tren
                        {
                            if (Matrix[i][point.Y].Name == "NULL")
                            {
                                Manager.stackButton.Push(Matrix[i][point.Y], i, point.Y);

                                Matrix[i][point.Y].BackColor = Color.LightBlue;
                                Matrix[i][point.Y].Name = "A";
                            }
                            if (Matrix[i][point.Y - 1].Name == "NULL")
                            {
                                Manager.stackButton.Push(Matrix[i][point.Y - 1], i, point.Y - 1);

                                Matrix[i][point.Y - 1].BackColor = Color.LightBlue;
                                Matrix[i][point.Y - 1].Name = "A";
                            }
                            if (Matrix[i][point.Y + 1].Name == "NULL")
                            {
                                Manager.stackButton.Push(Matrix[i][point.Y + 1], i, point.Y + 1);

                                Matrix[i][point.Y + 1].BackColor = Color.LightBlue;
                                Matrix[i][point.Y + 1].Name = "A";
                            }
                        }
                    }
                    if (Matrix[point.X][point.Y - 1].Name == "NULL")
                    {
                        Manager.stackButton.Push(Matrix[point.X][point.Y - 1], point.X, point.Y - 1);

                        Matrix[point.X][point.Y - 1].BackColor = Color.LightBlue;
                        Matrix[point.X][point.Y - 1].Name = "A";
                    }
                    if (Matrix[point.X][point.Y + 1].Name == "NULL")
                    {
                        Manager.stackButton.Push(Matrix[point.X][point.Y + 1], point.X, point.Y + 1);

                        Matrix[point.X][point.Y + 1].BackColor = Color.LightBlue;
                        Matrix[point.X][point.Y + 1].Name = "A";
                    }
                    if (point.X + 1 <= 7)
                    {
                        for (int i = point.X + 1; i <= point.X + 1; i++)//tren
                        {
                            if (Matrix[i][point.Y].Name == "NULL")
                            {
                                Manager.stackButton.Push(Matrix[i][point.Y], i, point.Y);

                                Matrix[i][point.Y].BackColor = Color.LightBlue;
                                Matrix[i][point.Y].Name = "A";
                            }
                            if (Matrix[i][point.Y - 1].Name == "NULL")
                            {
                                Manager.stackButton.Push(Matrix[i][point.Y - 1], i, point.Y - 1);

                                Matrix[i][point.Y - 1].BackColor = Color.LightBlue;
                                Matrix[i][point.Y - 1].Name = "A";
                            }
                            if (Matrix[i][point.Y + 1].Name == "NULL")
                            {
                                Manager.stackButton.Push(Matrix[i][point.Y + 1], i, point.Y + 1);

                                Matrix[i][point.Y + 1].BackColor = Color.LightBlue;
                                Matrix[i][point.Y + 1].Name = "A";
                            }
                        }
                    }
                }
        }
        }
}
