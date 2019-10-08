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
    class Bishop : GeneralMethods
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
/*
                int i = 1;
                int j = 1;
                while (point.Y - j >= 0 && point.X - i >= 0)// sang trai tren
                {
                    if (Matrix[point.X - i][point.Y - j].Name == "NULL")
                    {
                        Manager.stackButton.Push(Matrix[point.X - i][point.Y - j], point.X - i, point.Y - j);
                        Matrix[point.X - i][point.Y - j].BackColor = Color.LightBlue;
                        Matrix[point.X - i][point.Y - j].Name = "A";
                    }
                    i++;
                    j++;
                }
                while (point.Y - j >= 0 && point.X + i <= 7)//trai duoi
                {
                    if (Matrix[point.X + i][point.Y - j].Name == "NULL")
                    {
                        Manager.stackButton.Push(Matrix[point.X + i][point.Y - j], point.X + i, point.Y - j);
                        Matrix[point.X + i][point.Y - j].BackColor = Color.LightBlue;
                        Matrix[point.X + i][point.Y - j].Name = "A";
                    }
                    i++;
                    j++;
                }
                
                while(point.Y+j<=7&&point.X-i>=0)//phai tren
                {
                    if (Matrix[point.X - i][point.Y + j].Name == "NULL")
                    {
                        Manager.stackButton.Push(Matrix[point.X - i][point.Y + j], point.X - i, point.Y + j);
                        Matrix[point.X - i][point.Y + j].BackColor = Color.LightBlue;
                        Matrix[point.X - i][point.Y + j].Name = "A";
                    }
                    i++;
                    j++;
                    
                }
                while(point.Y+j<=7&&point.X+i<=7)//phai duoi
                {
                    if (Matrix[point.X + i][point.Y + j].Name == "NULL")
                    {
                        Manager.stackButton.Push(Matrix[point.X + i][point.Y + j], point.X + i, point.Y + j);
                        Matrix[point.X + i][point.Y + j].BackColor = Color.LightBlue;
                        Matrix[point.X + i][point.Y + j].Name = "A";
                    }
                    i++;
                    j++;
                }*/
