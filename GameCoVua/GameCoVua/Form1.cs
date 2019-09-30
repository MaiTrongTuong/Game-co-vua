using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        Manager ChessBoard;

        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new Manager(PanelChessBoard);
            ChessBoard.SizePanel();
            ChessBoard.LocationPanel();
            ChessBoard.DrawPanelChessBoard();

        }
    }
}
