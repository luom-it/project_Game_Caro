using project_Game_Caro.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Game_Caro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            drawChessBoard();
            cstbtnHome.MouseClick += backHome;
        }

        private void drawChessBoard()
        {
            

            CustomButton oldCustomButton = new CustomButton()
            {
                Width = 0,
                Height = 0,
                Location = new Point(25, 25),
            };
            for (int i = 0; i < Cons.ChessBoardHeight; i++)
            {
                for (int j = 0; j <= Cons.ChessBoardWidth; j++)
                {
                    CustomButton customButton = new CustomButton()
                    {

                        Width = Cons.ChessWidth,
                        Height = Cons.ChessHeight,
                        Location = new Point(oldCustomButton.Width + oldCustomButton.Location.X, oldCustomButton.Location.Y),
                        Margin = new Padding(0),

                    };
                        customButton.FlatAppearance.BorderColor = Color.FromArgb(150, 255, 255, 255);
                        pnlChessBoard.Controls.Add(customButton);
                        oldCustomButton= customButton;
                    
                }
                oldCustomButton.Location = new Point(25,oldCustomButton.Location.Y+Cons.ChessHeight);
                oldCustomButton.Width = 0;
                oldCustomButton.Height = 0;
            }


        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {

        }
        private void backHome(object sender, EventArgs e)
        {           
            this.Hide();
            Start home= new Start();
            home.Show();
        }
    }
}
