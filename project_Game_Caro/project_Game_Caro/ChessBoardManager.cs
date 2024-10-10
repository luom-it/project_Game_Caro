using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using project_Game_Caro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace project_Game_Caro
{
    public class ChessBoardManager
    {

        #region Properties
        private Dictionary<(int, int), int> cellStatus; // Trạng thái ô
        public Dictionary<(int, int), int> CellStatus
        {
            get { return cellStatus; }
            set { cellStatus = value; }
        }

        private int[,] matrixTest;
        public int[,] MatrixTest
        {
            get { return matrixTest; }
            set { matrixTest = value; }
        }

        private Panel chessBoard;

        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        private List<Player> player;

        public List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }
        private bool vsComputer;
        
        private int currentPlayer;

        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }
        private bool gameMode;
        public bool GameMode
        {
            get { return gameMode; }
            set { gameMode = value; }
        }

        private TextBox playerName;

        public TextBox PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        private PictureBox playerMark;

        public PictureBox PlayerMark
        {
            get { return playerMark; }
            set { playerMark = value; }
        }

        private TextBox playerName1;

        public TextBox PlayerName1
        {
            get { return playerName1; }
            set { playerName1 = value; }
        }

        private PictureBox playerMark1;

        public PictureBox PlayerMark1
        {
            get { return playerMark1; }
            set { playerMark1 = value; }
        }

        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private event EventHandler playerMarked1;
        public event EventHandler PlayerMarked1
        {
            add
            {
                playerMarked1 += value;
            }
            remove
            {
                playerMarked1 -= value;
            }
        }

        private event EventHandler playerMarked2;
        public event EventHandler PlayerMarked2
        {
            add
            {
                playerMarked2 += value;
            }
            remove
            {
                playerMarked2 -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }


        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark, TextBox playerName1, PictureBox mark1, bool gameMode)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = mark;
            this.PlayerName1 = playerName1;
            this.PlayerMark1 = mark1;
            this.GameMode = gameMode;
            this.Player = new List<Player>()
            {
                new Player("HowKteam", Image.FromFile(@"C:\Users\NhiNguyen\Source\Repos\project_Game_Caro\project_Game_Caro\project_Game_Caro\src\black.png")),
                new Player("Education", Image.FromFile(@"C:\Users\NhiNguyen\Source\Repos\project_Game_Caro\project_Game_Caro\project_Game_Caro\src\white.png"))
            };


            PlayerName.Text = Player[0].Name;

            PlayerMark.Image = Player[0].Mark;

            PlayerName1.Text = Player[1].Name;

            PlayerMark1.Image = Player[1].Mark;

            CurrentPlayer = 0;
            
        }
        #endregion

        #region Methods        
        public void DrawChessBoard()
        {
            ChessBoard.Enabled = true;
            //ChessBoard.AutoScroll = true;

            Matrix = new List<List<Button>>();

            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
            UpdateButtonVisibility();
        }
        public void UpdateButtonVisibility()
        {
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = Matrix[i][j]; // Lấy nút từ ma trận

                    // Kiểm tra xem nút có nằm trong kích thước panel không
                    if (btn.Location.X + Cons.CHESS_WIDTH <= ChessBoard.Width +2 &&
                        btn.Location.Y + Cons.CHESS_HEIGHT <= ChessBoard.Height +5 )
                    {
                        btn.Visible = true; // Hiển thị nút
                    }
                    else
                    {
                        btn.Visible = false; // Ẩn nút
                    }
                }
            }
        }


        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;

            Mark(btn);
            
            if (GameMode==true )
            {
                PlayAI();
                if (playerMarked1 != null && CurrentPlayer == 0)
                {
                    playerMarked1(this, new EventArgs());
                }              
                
            }
            else if (GameMode != false)
            {
                if (playerMarked1 != null && CurrentPlayer == 0)
                {
                    playerMarked1(this, new EventArgs());
                }

                if (playerMarked2 != null && CurrentPlayer == 1)
                    playerMarked2(this, new EventArgs());

            }
            if (isEndGame(btn))
            {
                EndGame();
            }
            
        }







        public void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int count = 1;  // Bắt đầu từ chính ô hiện tại

            // Đếm sang trái
            for (int i = point.X - 1; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                    break;
            }

            // Đếm sang phải
            for (int i = point.X + 1; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                    break;
            }

            return count >= 5;  // Chỉ thắng khi đếm đủ 5 quân liên tiếp
        }

        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int count = 1;  // Bắt đầu từ chính ô hiện tại

            // Đếm lên trên
            for (int i = point.Y - 1; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                    break;
            }

            // Đếm xuống dưới
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                    break;
            }

            return count >= 5;  // Chỉ thắng khi đếm đủ 5 quân liên tiếp
        }

        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int count = 1;  // Bắt đầu từ chính ô hiện tại

            // Đếm chéo từ trên xuống dưới theo hướng trái
            for (int i = 1; i <= Math.Min(point.X, point.Y); i++)
            {
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                    break;
            }

            // Đếm chéo từ dưới lên trên theo hướng phải
            for (int i = 1; i < Math.Min(Cons.CHESS_BOARD_WIDTH - point.X, Cons.CHESS_BOARD_HEIGHT - point.Y); i++)
            {
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                    break;
            }

            return count >= 5;  // Chỉ thắng khi đếm đủ 5 quân liên tiếp
        }

        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int count = 1;  // Bắt đầu từ chính ô hiện tại

            // Đếm chéo từ trên xuống dưới theo hướng phải
            for (int i = 1; i <= Math.Min(Cons.CHESS_BOARD_WIDTH - point.X - 1, point.Y); i++)
            {
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                    break;
            }

            // Đếm chéo từ dưới lên trên theo hướng trái
            for (int i = 1; i <= Math.Min(point.X, Cons.CHESS_BOARD_HEIGHT - point.Y - 1); i++)
            {
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    count++;
                }
                else
                    break;
            }

            return count >= 5;  // Chỉ thắng khi đếm đủ 5 quân liên tiếp
        }



        //public void PlayAI()
        //{
        //    Point? bestMove = null;
        //    int bestScore = int.MinValue;

        //    for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
        //    {
        //        for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
        //        {
        //            if (Matrix[i][j].BackgroundImage == null) // Kiểm tra ô trống
        //            {
        //                // Tính điểm cho nước đi của máy (Player[1])
        //                int attackScore = EvaluateBoard(i, j, Player[1].Mark);

        //                // Tính điểm phòng thủ cho nước đi của đối thủ (Player[0])
        //                int defenseScore = EvaluateBoard(i, j, Player[0].Mark);

        //                // Kiểm tra nếu đối thủ có 3 quân liên tiếp không bị chặn
        //                if (IsThreateningMove(i, j, Player[0].Mark))
        //                {
        //                    bestMove = new Point(j, i);
        //                    Mark(Matrix[bestMove.Value.Y][bestMove.Value.X]);
        //                    return;
        //                }

        //                // Kiểm tra nếu đây là nước đi có thể thắng ngay lập tức
        //                if (attackScore >= 10000)  // Điểm cực cao khi có thể thắng
        //                {
        //                    bestMove = new Point(j, i);
        //                    Mark(Matrix[bestMove.Value.Y][bestMove.Value.X]);
        //                    return;
        //                }

        //                // Kiểm tra nếu đối thủ có thể thắng ngay, chúng ta phải chặn ngay lập tức
        //                if (defenseScore >= 10000)
        //                {
        //                    bestMove = new Point(j, i);
        //                    Mark(Matrix[bestMove.Value.Y][bestMove.Value.X]);
        //                    return;
        //                }

        //                // Tính điểm ưu tiên nước đi tốt nhất giữa tấn công và phòng thủ
        //                int moveScore = Math.Max(attackScore, defenseScore);

        //                // Chọn nước đi có điểm cao nhất
        //                if (moveScore > bestScore)
        //                {
        //                    bestScore = moveScore;
        //                    bestMove = new Point(j, i);
        //                }
        //            }
        //        }
        //    }

        //    if (bestMove.HasValue)
        //    {
        //        // Đánh dấu nước đi của máy tại vị trí tốt nhất
        //        Mark(Matrix[bestMove.Value.Y][bestMove.Value.X]);
        //    }
        //}


        
        //private int EvaluateBoard(int row, int col, Image mark)
        //{
        //    int score = 0;

        //    // Đánh giá tất cả các hướng (ngang, dọc, chéo chính, chéo phụ)
        //    score += EvaluateDirection(row, col, 1, 0, mark);  // Ngang
        //    score += EvaluateDirection(row, col, 0, 1, mark);  // Dọc
        //    score += EvaluateDirection(row, col, 1, 1, mark);  // Chéo chính
        //    score += EvaluateDirection(row, col, 1, -1, mark); // Chéo phụ

        //    // Cộng thêm điểm nếu đây là nước đi gần các quân cờ của AI (tấn công)
        //    score += CalculateProximityBonus(row, col, mark);

        //    return score;
        //}

        //// Hàm tính điểm cộng cho nước đi gần các quân cờ của AI
        //private int CalculateProximityBonus(int row, int col, Image mark)
        //{
        //    int bonus = 0;

        //    for (int i = -1; i <= 1; i++)
        //    {
        //        for (int j = -1; j <= 1; j++)
        //        {
        //            if (i == 0 && j == 0) continue; // Bỏ qua ô hiện tại

        //            int newRow = row + i;
        //            int newCol = col + j;

        //            if (newRow >= 0 && newRow < Cons.CHESS_BOARD_HEIGHT && newCol >= 0 && newCol < Cons.CHESS_BOARD_WIDTH)
        //            {
        //                if (Matrix[newRow][newCol].BackgroundImage == mark)
        //                {
        //                    bonus += 5; // Điểm cộng nếu ô gần đó có quân của AI
        //                }
        //            }
        //        }
        //    }

        //    return bonus;
        //}


        //private int EvaluateDirection(int row, int col, int deltaX, int deltaY, Image mark)
        //{
        //    int count = 0;
        //    int block = 0;

        //    // Đếm quân cờ trong hướng xuôi
        //    for (int i = 1; i < 5; i++)
        //    {
        //        int newRow = row + i * deltaX;
        //        int newCol = col + i * deltaY;

        //        if (newRow < 0 || newRow >= Cons.CHESS_BOARD_HEIGHT || newCol < 0 || newCol >= Cons.CHESS_BOARD_WIDTH)
        //        {
        //            block++;
        //            break;
        //        }

        //        if (Matrix[newRow][newCol].BackgroundImage == mark)
        //        {
        //            count++;
        //        }
        //        else if (Matrix[newRow][newCol].BackgroundImage != null)
        //        {
        //            block++;
        //            break;
        //        }
        //    }

        //    // Đếm quân cờ trong hướng ngược lại
        //    for (int i = 1; i < 5; i++)
        //    {
        //        int newRow = row - i * deltaX;
        //        int newCol = col - i * deltaY;

        //        if (newRow < 0 || newRow >= Cons.CHESS_BOARD_HEIGHT || newCol < 0 || newCol >= Cons.CHESS_BOARD_WIDTH)
        //        {
        //            block++;
        //            break;
        //        }

        //        if (Matrix[newRow][newCol].BackgroundImage == mark)
        //        {
        //            count++;
        //        }
        //        else if (Matrix[newRow][newCol].BackgroundImage != null)
        //        {
        //            block++;
        //            break;
        //        }
        //    }

        //    // Ưu tiên chiến thắng
        //    if (count == 4 && block == 0) return 10000;  // Ưu tiên thắng nếu có 4 quân và không bị chặn

        //    // Tính toán điểm số dựa trên số lượng quân cờ liên tiếp và số lần bị chặn
        //    if (block == 2) return 0;  // Bị chặn cả hai đầu, nước đi này không có giá trị
        //    if (block == 1) return count * 2;  // Bị chặn một đầu
        //    return count * 5;  // Không bị chặn
        //}
        //// Hàm kiểm tra xem có nước đi nào của đối thủ tạo thành 3 quân liên tiếp không bị chặn
        //private bool IsThreateningMove(int row, int col, Image mark)
        //{
        //    // Kiểm tra các hướng: ngang, dọc, chéo chính, chéo phụ
        //    return CheckDirection(row, col, 1, 0, mark) || // Ngang
        //           CheckDirection(row, col, 0, 1, mark) || // Dọc
        //           CheckDirection(row, col, 1, 1, mark) || // Chéo chính
        //           CheckDirection(row, col, 1, -1, mark);  // Chéo phụ
        //}

        //// Hàm kiểm tra hướng cụ thể xem có 3 quân liên tiếp không bị chặn
        //private bool CheckDirection(int row, int col, int deltaX, int deltaY, Image mark)
        //{
        //    int count = 0;
        //    int blockStart = 0;
        //    int blockEnd = 0;

        //    // Đếm quân cờ trong hướng xuôi
        //    for (int i = 0; i < 3; i++)
        //    {
        //        int newRow = row + i * deltaX;
        //        int newCol = col + i * deltaY;

        //        if (newRow < 0 || newRow >= Cons.CHESS_BOARD_HEIGHT || newCol < 0 || newCol >= Cons.CHESS_BOARD_WIDTH)
        //        {
        //            blockStart++;
        //            break;
        //        }

        //        if (Matrix[newRow][newCol].BackgroundImage == mark)
        //        {
        //            count++;
        //        }
        //        else if (Matrix[newRow][newCol].BackgroundImage != null)
        //        {
        //            blockStart++;
        //            break;
        //        }
        //    }

        //    // Đếm quân cờ trong hướng ngược lại
        //    for (int i = 1; i < 3; i++)
        //    {
        //        int newRow = row - i * deltaX;
        //        int newCol = col - i * deltaY;

        //        if (newRow < 0 || newRow >= Cons.CHESS_BOARD_HEIGHT || newCol < 0 || newCol >= Cons.CHESS_BOARD_WIDTH)
        //        {
        //            blockEnd++;
        //            break;
        //        }

        //        if (Matrix[newRow][newCol].BackgroundImage == mark)
        //        {
        //            count++;
        //        }
        //        else if (Matrix[newRow][newCol].BackgroundImage != null)
        //        {
        //            blockEnd++;
        //            break;
        //        }
        //    }

        //    // Kiểm tra nếu có 3 quân liên tiếp và 2 đầu không bị chặn
        //    return count == 2 && blockStart == 0 && blockEnd == 0;
        //}




        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }

        #endregion


        
        
    }
}

