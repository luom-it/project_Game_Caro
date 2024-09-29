using System;
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
            this.DoubleBuffered = true; // Kích hoạt Double Buffering cho Form
            //CreateBlurOverlay();
            cstbtnPlay.MouseHover += customButton_MouseHover;
            cstbtnPlayWithFiriend.MouseHover += customButton_MouseHover;
            cstbtnExit.MouseHover += customButton_MouseHover;

            cstbtnPlay.MouseLeave += customButton_MouseLeave;
            cstbtnPlayWithFiriend.MouseLeave += customButton_MouseLeave;
            cstbtnExit.MouseLeave += customButton_MouseLeave;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();

        }
        
        private void customButton_MouseHover(object sender, EventArgs e)
        {
            Button hoveredButton = sender as Button;
            if (hoveredButton != null)
            {
                hoveredButton.ForeColor = Color.FromArgb(0, 130, 62, 62); // Màu khi hover
            }
        }
        private void customButton_MouseLeave(object sender, EventArgs e) 
        {
            Button leavedButton = sender as Button;
            if (leavedButton != null)
            {
                leavedButton.ForeColor = Color.FromArgb(160, 125, 125); // Màu khi hover
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }
        private void customButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Start_Load(object sender, EventArgs e)
        {

        }

        

        
    }
}
