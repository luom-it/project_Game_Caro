namespace project_Game_Caro
{
    partial class GameMain
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
            components = new System.ComponentModel.Container();
            panel3 = new Panel();
            btnLAN = new Button();
            txbIP1 = new TextBox();
            pctbMark1 = new PictureBox();
            prcbCoolDown1 = new ProgressBar();
            txbPlayerName1 = new TextBox();
            tmCoolDown1 = new System.Windows.Forms.Timer(components);
            tmCoolDown2 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pnlChessBoard = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            txbIP2 = new TextBox();
            pctbMark2 = new PictureBox();
            prcbCoolDown2 = new ProgressBar();
            txbPlayerName2 = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(btnLAN);
            panel3.Controls.Add(txbIP1);
            panel3.Controls.Add(pctbMark1);
            panel3.Controls.Add(prcbCoolDown1);
            panel3.Controls.Add(txbPlayerName1);
            panel3.Location = new Point(1010, 80);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 436);
            panel3.TabIndex = 2;
            // 
            // btnLAN
            // 
            btnLAN.Location = new Point(89, 169);
            btnLAN.Margin = new Padding(4, 5, 4, 5);
            btnLAN.Name = "btnLAN";
            btnLAN.Size = new Size(156, 35);
            btnLAN.TabIndex = 4;
            btnLAN.Text = "LAN";
            btnLAN.UseVisualStyleBackColor = true;
            // 
            // txbIP1
            // 
            txbIP1.Location = new Point(48, 132);
            txbIP1.Margin = new Padding(4, 5, 4, 5);
            txbIP1.Name = "txbIP1";
            txbIP1.Size = new Size(250, 27);
            txbIP1.TabIndex = 3;
            txbIP1.Text = "127.0.0.1";
            // 
            // pctbMark1
            // 
            pctbMark1.BackColor = SystemColors.Control;
            pctbMark1.Location = new Point(89, 239);
            pctbMark1.Margin = new Padding(4, 5, 4, 5);
            pctbMark1.Name = "pctbMark1";
            pctbMark1.Size = new Size(156, 160);
            pctbMark1.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark1.TabIndex = 2;
            pctbMark1.TabStop = false;
            // 
            // prcbCoolDown1
            // 
            prcbCoolDown1.Location = new Point(48, 75);
            prcbCoolDown1.Margin = new Padding(4, 5, 4, 5);
            prcbCoolDown1.Name = "prcbCoolDown1";
            prcbCoolDown1.Size = new Size(250, 35);
            prcbCoolDown1.TabIndex = 1;
            // 
            // txbPlayerName1
            // 
            txbPlayerName1.Location = new Point(48, 29);
            txbPlayerName1.Margin = new Padding(4, 5, 4, 5);
            txbPlayerName1.Name = "txbPlayerName1";
            txbPlayerName1.ReadOnly = true;
            txbPlayerName1.Size = new Size(250, 27);
            txbPlayerName1.TabIndex = 0;
            // 
            // tmCoolDown
            // 
            tmCoolDown1.Tick += tmCoolDown1_Tick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pnlChessBoard);
            panel1.Location = new Point(351, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 653);
            panel1.TabIndex = 3;
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChessBoard.Location = new Point(27, 29);
            pnlChessBoard.Margin = new Padding(5);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(598, 597);
            pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txbIP2);
            panel2.Controls.Add(pctbMark2);
            panel2.Controls.Add(prcbCoolDown2);
            panel2.Controls.Add(txbPlayerName2);
            panel2.Location = new Point(9, 80);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 436);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(89, 169);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(156, 35);
            button1.TabIndex = 4;
            button1.Text = "LAN";
            button1.UseVisualStyleBackColor = true;
            // 
            // txbIP2
            // 
            txbIP2.Location = new Point(48, 132);
            txbIP2.Margin = new Padding(4, 5, 4, 5);
            txbIP2.Name = "txbIP2";
            txbIP2.Size = new Size(250, 27);
            txbIP2.TabIndex = 3;
            txbIP2.Text = "127.0.0.1";
            // 
            // pctbMark2
            // 
            pctbMark2.BackColor = SystemColors.Control;
            pctbMark2.Location = new Point(89, 239);
            pctbMark2.Margin = new Padding(4, 5, 4, 5);
            pctbMark2.Name = "pctbMark2";
            pctbMark2.Size = new Size(156, 160);
            pctbMark2.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark2.TabIndex = 2;
            pctbMark2.TabStop = false;
            // 
            // prcbCoolDown2
            // 
            prcbCoolDown2.Location = new Point(48, 75);
            prcbCoolDown2.Margin = new Padding(4, 5, 4, 5);
            prcbCoolDown2.Name = "prcbCoolDown2";
            prcbCoolDown2.Size = new Size(250, 35);
            prcbCoolDown2.TabIndex = 1;
            // 
            // txbPlayerName2
            // 
            txbPlayerName2.Location = new Point(48, 29);
            txbPlayerName2.Margin = new Padding(4, 5, 4, 5);
            txbPlayerName2.Name = "txbPlayerName2";
            txbPlayerName2.ReadOnly = true;
            txbPlayerName2.Size = new Size(250, 27);
            txbPlayerName2.TabIndex = 0;
            // 
            //
            //
            tmCoolDown2.Tick += tmCoolDown2_Tick;


            // GameMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 767);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GameMain";
            Text = "Game Caro LAN";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP1;
        private System.Windows.Forms.PictureBox pctbMark1;
        private System.Windows.Forms.ProgressBar prcbCoolDown1;
        private System.Windows.Forms.TextBox txbPlayerName1;
        private System.Windows.Forms.Timer tmCoolDown1;
        private System.Windows.Forms.Timer tmCoolDown2;
        private Panel panel1;
        private Panel pnlChessBoard;
        private Panel panel2;
        private Button button1;
        private TextBox txbIP2;
        private PictureBox pctbMark2;
        private ProgressBar prcbCoolDown2;
        private TextBox txbPlayerName2;
    }
}

