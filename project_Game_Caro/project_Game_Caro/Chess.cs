using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Game_Caro
{
    public class Chess
    {
        
            public Label lb;
            public int X;
            public int Y;
            public Chess()
            {
                lb = new Label();
            }
            public Chess(Label _lb, int x, int y)
            {
                lb = new Label();
                lb = _lb;
                X = x;
                Y = y;
            }
        
    }
}
