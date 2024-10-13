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
    public partial class Start : Form
    {
       
        public Start()
        {
            InitializeComponent();
            LoadGif();
            
            this.DoubleBuffered = true;
            panel2.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(panel2, true, null);
            cstbtnPlay.MouseEnter += cstbtnStart_MouseEnter;
            cstbtnPlay2.MouseEnter += cstbtnStart_MouseEnter;
            cstbtnExit.MouseEnter += cstbtnStart_MouseEnter;
            cstbtnPlay.MouseLeave += cstbtnStart_MouseLeave;
            cstbtnPlay2.MouseLeave += cstbtnStart_MouseLeave;
            cstbtnExit.MouseLeave += cstbtnStart_MouseLeave;

            cstbtnPlay.Click += CstbtnPlay_Click;
            cstbtnPlay2.Click += CstbtnPlay2_Click;
            cstbtnExit.Click += CstbtnExit_Click;

        }

        private void CstbtnExit_Click(object? sender, EventArgs e)
        {
            this.Close();
            throw new NotImplementedException();
        }

        private void CstbtnPlay2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameCaro gameCaro = new GameCaro(2);
            DialogResult result = gameCaro.ShowDialog();  // Wait until GameCaro form is closed
            this.Show();  // Show the main form after GameCaro is closed
        }

        private void CstbtnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameCaro gameCaro = new GameCaro(1);
            DialogResult result = gameCaro.ShowDialog();  // Wait until GameCaro form is closed
            this.Show();  // Show the main form after GameCaro is closed
        }


        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //}
        private void cstbtnStart_MouseEnter(object sender, EventArgs e)
        {
            Button leavedButton = sender as Button;
            if (leavedButton != null)
            {
                leavedButton.ForeColor = Color.DodgerBlue; // Màu khi hover
            }
        }
        private void cstbtnStart_MouseLeave(object sender, EventArgs e)
        {
            Button leavedButton = sender as Button;
            if (leavedButton != null)
            {
                leavedButton.ForeColor = Color.SkyBlue; // Màu khi hover
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void LoadGif()
        {
            // Tải file GIF từ Resources
            pictureBox4.Image = Properties.Resources.cat3;
            pictureBox2.Image = Properties.Resources._6ee8071fdcbbc3f6a0190808013aaa47; // Thay 'YourGifFileName' bằng tên file GIF bạn đã thêm vào Resources
        }
        
    }


}
