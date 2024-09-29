using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Game_Caro
{
    internal class Cons
    {
        private static int chessWidth = 60;
        private static int chessHeight = 60;
        private static int chessBoardWidth=10;
        private static int chessBoardHeight=10;

        public static int ChessWidth { get => chessWidth; set => chessWidth = value; }
        public static int ChessHeight { get => chessHeight; set => chessHeight = value; }

        public static int ChessBoardWidth
        {
            get { return chessBoardWidth; }
            set { chessBoardWidth = value; }
        }
        public static int ChessBoardHeight
        {
            get { return chessBoardHeight; }
            set { chessBoardHeight = value; }
        }
    }
}
