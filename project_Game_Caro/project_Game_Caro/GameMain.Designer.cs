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
            txbIP = new TextBox();
            pctbMark = new PictureBox();
            prcbCoolDown = new ProgressBar();
            txbPlayerName = new TextBox();
            tmCoolDown = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pnlChessBoard = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            textBox2 = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(btnLAN);
            panel3.Controls.Add(txbIP);
            panel3.Controls.Add(pctbMark);
            panel3.Controls.Add(prcbCoolDown);
            panel3.Controls.Add(txbPlayerName);
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
            // txbIP
            // 
            txbIP.Location = new Point(48, 132);
            txbIP.Margin = new Padding(4, 5, 4, 5);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(250, 27);
            txbIP.TabIndex = 3;
            txbIP.Text = "127.0.0.1";
            // 
            // pctbMark
            // 
            pctbMark.BackColor = SystemColors.Control;
            pctbMark.Location = new Point(89, 239);
            pctbMark.Margin = new Padding(4, 5, 4, 5);
            pctbMark.Name = "pctbMark";
            pctbMark.Size = new Size(156, 160);
            pctbMark.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark.TabIndex = 2;
            pctbMark.TabStop = false;
            // 
            // prcbCoolDown
            // 
            prcbCoolDown.Location = new Point(48, 75);
            prcbCoolDown.Margin = new Padding(4, 5, 4, 5);
            prcbCoolDown.Name = "prcbCoolDown";
            prcbCoolDown.Size = new Size(250, 35);
            prcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            txbPlayerName.Location = new Point(48, 29);
            txbPlayerName.Margin = new Padding(4, 5, 4, 5);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.ReadOnly = true;
            txbPlayerName.Size = new Size(250, 27);
            txbPlayerName.TabIndex = 0;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
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
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(progressBar1);
            panel2.Controls.Add(textBox2);
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
            // textBox1
            // 
            textBox1.Location = new Point(48, 132);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 3;
            textBox1.Text = "127.0.0.1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(89, 239);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(48, 75);
            progressBar1.Margin = new Padding(4, 5, 4, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(250, 35);
            progressBar1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 29);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 0;
            // 
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
            ((System.ComponentModel.ISupportInitialize)pctbMark).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Timer tmCoolDown;
        private Panel panel1;
        private Panel pnlChessBoard;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private TextBox textBox2;
    }
}

