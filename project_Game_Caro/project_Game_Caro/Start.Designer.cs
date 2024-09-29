
using project_Game_Caro.Layout;

namespace project_Game_Caro
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            cstbtnPlayWithFiriend = new CustomButton();
            cstbtnPlay = new CustomButton();
            label1 = new Label();
            cstbtnExit = new CustomButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cstbtnPlayWithFiriend
            // 
            cstbtnPlayWithFiriend.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cstbtnPlayWithFiriend.BackColor = Color.Transparent;
            cstbtnPlayWithFiriend.BackgroundImageLayout = ImageLayout.Stretch;
            cstbtnPlayWithFiriend.Cursor = Cursors.Hand;
            cstbtnPlayWithFiriend.FlatAppearance.BorderSize = 0;
            cstbtnPlayWithFiriend.FlatStyle = FlatStyle.Flat;
            cstbtnPlayWithFiriend.Font = new Font("Cooper Black", 18F);
            cstbtnPlayWithFiriend.ForeColor = Color.FromArgb(160, 125, 125);
            cstbtnPlayWithFiriend.Location = new Point(312, 285);
            cstbtnPlayWithFiriend.Margin = new Padding(0);
            cstbtnPlayWithFiriend.Name = "cstbtnPlayWithFiriend";
            cstbtnPlayWithFiriend.Size = new Size(341, 50);
            cstbtnPlayWithFiriend.TabIndex = 2;
            cstbtnPlayWithFiriend.Text = "PLAY WITH FRIEND";
            cstbtnPlayWithFiriend.UseVisualStyleBackColor = false;
            cstbtnPlayWithFiriend.Click += customButton2_Click;
            cstbtnPlayWithFiriend.MouseLeave += customButton_MouseLeave;
            cstbtnPlayWithFiriend.MouseHover += customButton_MouseHover;
            // 
            // cstbtnPlay
            // 
            cstbtnPlay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cstbtnPlay.BackColor = Color.Transparent;
            cstbtnPlay.BackgroundImageLayout = ImageLayout.Stretch;
            cstbtnPlay.Cursor = Cursors.Hand;
            cstbtnPlay.FlatAppearance.BorderSize = 0;
            cstbtnPlay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cstbtnPlay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cstbtnPlay.FlatStyle = FlatStyle.Flat;
            cstbtnPlay.Font = new Font("Cooper Black", 18F);
            cstbtnPlay.ForeColor = Color.FromArgb(160, 125, 125);
            cstbtnPlay.Location = new Point(425, 235);
            cstbtnPlay.Margin = new Padding(0);
            cstbtnPlay.Name = "cstbtnPlay";
            cstbtnPlay.Size = new Size(115, 50);
            cstbtnPlay.TabIndex = 1;
            cstbtnPlay.Text = "PLAY";
            cstbtnPlay.UseVisualStyleBackColor = false;
            cstbtnPlay.Click += customButton1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 38F);
            label1.ForeColor = Color.FromArgb(160, 125, 125);
            label1.Location = new Point(255, 140);
            label1.Name = "label1";
            label1.Size = new Size(460, 70);
            label1.TabIndex = 4;
            label1.Text = "GAME CARO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cstbtnExit
            // 
            cstbtnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cstbtnExit.BackColor = Color.Transparent;
            cstbtnExit.BackgroundImageLayout = ImageLayout.Stretch;
            cstbtnExit.Cursor = Cursors.Hand;
            cstbtnExit.FlatAppearance.BorderSize = 0;
            cstbtnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cstbtnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cstbtnExit.FlatStyle = FlatStyle.Flat;
            cstbtnExit.Font = new Font("Cooper Black", 18F);
            cstbtnExit.ForeColor = Color.FromArgb(160, 125, 125);
            cstbtnExit.Location = new Point(425, 335);
            cstbtnExit.Margin = new Padding(0);
            cstbtnExit.Name = "cstbtnExit";
            cstbtnExit.Size = new Size(115, 50);
            cstbtnExit.TabIndex = 3;
            cstbtnExit.Text = "EXIT";
            cstbtnExit.UseVisualStyleBackColor = false;
            cstbtnExit.Click += customButton3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.blur;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(cstbtnExit);
            panel1.Controls.Add(cstbtnPlayWithFiriend);
            panel1.Controls.Add(cstbtnPlay);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 553);
            panel1.TabIndex = 5;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.screen_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 553);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Start";
            Text = "Cờ Caro";
            Load += Start_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }




        #endregion

        private CustomButton cstbtnPlayWithFiriend;
        private CustomButton cstbtnPlay;
        private Label label1;
        private CustomButton cstbtnExit;
        private Panel panel1;
    }
}
