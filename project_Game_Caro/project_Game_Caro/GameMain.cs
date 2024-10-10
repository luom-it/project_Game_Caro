using project_Game_Caro;
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
    public partial class GameMain : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        
        #endregion
        public GameMain(bool gamemode = true)
        {
            InitializeComponent();

            this.Resize += Form1_Resize; // Thêm sự kiện Resize cho form
            ChessBoard = new ChessBoardManager(pnlChessBoard, txbPlayerName1, pctbMark1, txbPlayerName2, pctbMark2, gamemode);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked1 += ChessBoard_PlayerMarked1;
            if (!gamemode)
            {
   
                ChessBoard.PlayerMarked2 += ChessBoard_PlayerMarked2;
            }

            prcbCoolDown1.Step = Cons.COOL_DOWN_STEP;
            prcbCoolDown1.Maximum = Cons.COOL_DOWN_TIME;
            prcbCoolDown1.Value = 0;
            
            prcbCoolDown2.Step = Cons.COOL_DOWN_STEP;
            prcbCoolDown2.Maximum = Cons.COOL_DOWN_TIME;
            prcbCoolDown2.Value = 0;

            tmCoolDown1.Interval = Cons.COOL_DOWN_INTERVAL;
            tmCoolDown2.Interval = Cons.COOL_DOWN_INTERVAL;

            ChessBoard.DrawChessBoard();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            ChessBoard.UpdateButtonVisibility(); // Cập nhật trạng thái hiển thị cho các nút
        }


        void EndGame()
        {
            tmCoolDown1.Stop();
            tmCoolDown2.Stop();
            pnlChessBoard.Enabled = false;
            MessageBox.Show("Kết thúc");
        }

        void ChessBoard_PlayerMarked1(object sender, EventArgs e)
        {
            tmCoolDown2.Stop();
            prcbCoolDown2.Value = 0;
            prcbCoolDown2.Step = Cons.COOL_DOWN_STEP;
            prcbCoolDown2.Maximum = Cons.COOL_DOWN_TIME;
            
            prcbCoolDown1.Value = 0;
            tmCoolDown1.Start();

        }
        void ChessBoard_PlayerMarked2(object sender, EventArgs e)
        {
            tmCoolDown1.Stop();
            prcbCoolDown1.Value = 0;
            prcbCoolDown1.Step = Cons.COOL_DOWN_STEP;
            prcbCoolDown1.Maximum = Cons.COOL_DOWN_TIME;
            
            prcbCoolDown2.Value = 0;
            tmCoolDown2.Start();

        }

        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void tmCoolDown1_Tick(object sender, EventArgs e)
        {
            // Giảm bước tiến khi gần tới giá trị Maximum
            if (prcbCoolDown1.Value >= prcbCoolDown1.Maximum - 500) // Khi còn 10 bước cuối
            {
                prcbCoolDown1.Step = 20; // Giảm bước tiến xuống 1
            }

            prcbCoolDown1.PerformStep();

            // Kết thúc game nếu vượt quá Maximum
            if (prcbCoolDown1.Value >= prcbCoolDown1.Maximum)
            {
                EndGame();
            }

        }
        private void tmCoolDown2_Tick(object sender, EventArgs e)
        {

            // Giảm bước tiến khi gần tới giá trị Maximum
            if (prcbCoolDown2.Value >= prcbCoolDown2.Maximum - 500) // Khi còn 10 bước cuối
            {
                prcbCoolDown2.Step = 20; // Giảm bước tiến xuống 1
            }

            prcbCoolDown2.PerformStep();

            // Kết thúc game nếu vượt quá Maximum
            if (prcbCoolDown2.Value >= prcbCoolDown2.Maximum)
            {
                EndGame();
            }
        }


    }
}
