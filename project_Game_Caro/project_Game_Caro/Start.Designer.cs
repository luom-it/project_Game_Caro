namespace project_Game_Caro
{
    partial class Start
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            cstbtnExit = new Layout.CustomButton();
            cstbtnPlay2 = new Layout.CustomButton();
            cstbtnPlay = new Layout.CustomButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.BackgroundImage = Properties.Resources.co;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 501);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Snap ITC", 36F, FontStyle.Bold);
            label1.ForeColor = Color.SkyBlue;
            label1.Location = new Point(178, 64);
            label1.Name = "label1";
            label1.Size = new Size(484, 77);
            label1.TabIndex = 7;
            label1.Text = "GAME CARO";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(66, 322);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(cstbtnExit);
            panel2.Controls.Add(cstbtnPlay2);
            panel2.Controls.Add(cstbtnPlay);
            panel2.Location = new Point(189, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 225);
            panel2.TabIndex = 1;
            // 
            // cstbtnExit
            // 
            cstbtnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cstbtnExit.BackColor = Color.Transparent;
            cstbtnExit.Cursor = Cursors.Hand;
            cstbtnExit.FlatAppearance.BorderColor = Color.FromArgb(80, 192, 255, 255);
            cstbtnExit.FlatAppearance.BorderSize = 0;
            cstbtnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cstbtnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cstbtnExit.FlatStyle = FlatStyle.Flat;
            cstbtnExit.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cstbtnExit.ForeColor = Color.SkyBlue;
            cstbtnExit.Location = new Point(159, 150);
            cstbtnExit.Name = "cstbtnExit";
            cstbtnExit.Size = new Size(130, 50);
            cstbtnExit.TabIndex = 2;
            cstbtnExit.Text = "Exit";
            cstbtnExit.UseVisualStyleBackColor = false;
            // 
            // cstbtnPlay2
            // 
            cstbtnPlay2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cstbtnPlay2.BackColor = Color.Transparent;
            cstbtnPlay2.Cursor = Cursors.Hand;
            cstbtnPlay2.FlatAppearance.BorderColor = Color.FromArgb(80, 192, 255, 255);
            cstbtnPlay2.FlatAppearance.BorderSize = 0;
            cstbtnPlay2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cstbtnPlay2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cstbtnPlay2.FlatStyle = FlatStyle.Flat;
            cstbtnPlay2.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cstbtnPlay2.ForeColor = Color.SkyBlue;
            cstbtnPlay2.Location = new Point(34, 79);
            cstbtnPlay2.Name = "cstbtnPlay2";
            cstbtnPlay2.Size = new Size(403, 65);
            cstbtnPlay2.TabIndex = 1;
            cstbtnPlay2.Text = "2 Player";
            cstbtnPlay2.UseVisualStyleBackColor = false;
            // 
            // cstbtnPlay
            // 
            cstbtnPlay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cstbtnPlay.BackColor = Color.Transparent;
            cstbtnPlay.Cursor = Cursors.Hand;
            cstbtnPlay.FlatAppearance.BorderColor = Color.FromArgb(80, 192, 255, 255);
            cstbtnPlay.FlatAppearance.BorderSize = 0;
            cstbtnPlay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cstbtnPlay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cstbtnPlay.FlatStyle = FlatStyle.Flat;
            cstbtnPlay.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cstbtnPlay.ForeColor = Color.SkyBlue;
            cstbtnPlay.Location = new Point(123, 18);
            cstbtnPlay.Name = "cstbtnPlay";
            cstbtnPlay.Size = new Size(232, 55);
            cstbtnPlay.TabIndex = 0;
            cstbtnPlay.Text = "1 Player";
            cstbtnPlay.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(658, 204);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 218);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.cat5;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-34, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 132);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 501);
            Controls.Add(panel1);
            Name = "Start";
            Text = "Start";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Layout.CustomButton cstbtnExit;
        private Layout.CustomButton cstbtnPlay2;
        private Layout.CustomButton cstbtnPlay;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
    }
}