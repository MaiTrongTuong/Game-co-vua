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
    public class Bishop : GeneralMethods
    {
        public void CanMove(List<List<Button>> Matrix, Point point)
        {
            int i=1;
            //cheo chinh
            while (i<=7)// sang trai tren
            {
                if (point.X + i <= 7 && point.Y + i <= 7)
                {
                    if (Matrix[point.X + i][point.Y + i].Name == "NULL")
                    {
                        //Manager.stackButton.Push(Matrix[point.X + i][point.Y + i], point.X + i, point.Y + i);

                        Matrix[point.X + i][point.Y + i].BackColor = Color.LightBlue;
                        Matrix[point.X + i][point.Y + i].Name = "A";
          
                    }
                }
                if (point.X - i >= 0 && point.Y - i >= 0)
                {
                    if (Matrix[point.X - i][point.Y - i].Name == "NULL")
                    {
                        //Manager.stackButton.Push(Matrix[point.X - i][point.Y - i], point.X - i, point.Y - i);

                        Matrix[point.X - i][point.Y - i].BackColor = Color.LightBlue;
                        Matrix[point.X - i][point.Y - i].Name = "A";
              
                    }
                }
                if (point.X + i <= 7 && point.Y - i >= 0)
                {
                    if (Matrix[point.X + i][point.Y - i].Name == "NULL")
                    {
                        //Manager.stackButton.Push(Matrix[point.X + i][point.Y - i], point.X + i, point.Y - i);

                        Matrix[point.X + i][point.Y - i].BackColor = Color.LightBlue;
                        Matrix[point.X + i][point.Y - i].Name = "A";
                    }
                }
                if (point.X - i >= 0 && point.Y + i <= 7)
                {
                    if (Matrix[point.X - i][point.Y + i].Name == "NULL")
                    {
                        //Manager.stackButton.Push(Matrix[point.X - i][point.Y + i], point.X - i, point.Y + i);

                        Matrix[point.X - i][point.Y + i].BackColor = Color.LightBlue;
                        Matrix[point.X - i][point.Y + i].Name = "A";
                    }
                }
                i++;
            }
        }
    }
}
