using project_Game_Caro.Layout;
namespace project_Game_Caro
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlChessBoard = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            cstbtnHome = new CustomButton();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChessBoard.BackColor = Color.Transparent;
            pnlChessBoard.BackgroundImage = Properties.Resources.blur;
            pnlChessBoard.BackgroundImageLayout = ImageLayout.Stretch;
            pnlChessBoard.Location = new Point(317, 60);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(650, 650);
            pnlChessBoard.TabIndex = 0;
            pnlChessBoard.Paint += pnlChessBoard_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.wooden;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(967, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 331);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.wooden;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(1, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 331);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // cstbtnHome
            // 
            cstbtnHome.BackColor = Color.Transparent;
            cstbtnHome.BackgroundImage = Properties.Resources.home;
            cstbtnHome.BackgroundImageLayout = ImageLayout.Stretch;
            cstbtnHome.Cursor = Cursors.Hand;
            cstbtnHome.FlatAppearance.BorderColor = Color.FromArgb(80, 192, 255, 255);
            cstbtnHome.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cstbtnHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cstbtnHome.FlatStyle = FlatStyle.Flat;
            cstbtnHome.Location = new Point(371, 4);
            cstbtnHome.Name = "cstbtnHome";
            cstbtnHome.Size = new Size(50, 50);
            cstbtnHome.TabIndex = 3;
            cstbtnHome.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = Properties.Resources.screen_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1282, 748);
            Controls.Add(cstbtnHome);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlChessBoard);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChessBoard;
        private Panel panel2;
        private Panel panel3;
        private CustomButton cstbtnHome;
    }
}