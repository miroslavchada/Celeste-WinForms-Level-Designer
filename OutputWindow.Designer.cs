namespace Level_Designer {
    partial class OuputWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            gameScreen = new Panel();
            teleport1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            player = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox110 = new PictureBox();
            pictureBox4 = new PictureBox();
            gameScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teleport1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox110).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // gameScreen
            // 
            gameScreen.BackColor = Color.FromArgb(21, 23, 45);
            gameScreen.Controls.Add(teleport1);
            gameScreen.Controls.Add(pictureBox3);
            gameScreen.Controls.Add(pictureBox2);
            gameScreen.Controls.Add(player);
            gameScreen.Controls.Add(pictureBox1);
            gameScreen.Controls.Add(pictureBox110);
            gameScreen.Controls.Add(pictureBox4);
            gameScreen.Dock = DockStyle.Fill;
            gameScreen.Location = new Point(0, 0);
            gameScreen.Margin = new Padding(0);
            gameScreen.Name = "gameScreen";
            gameScreen.Size = new Size(1536, 864);
            gameScreen.TabIndex = 369;
            // 
            // teleport1
            // 
            teleport1.BackColor = Color.FromArgb(181, 230, 29);
            teleport1.Image = Properties.Resources.ben_door;
            teleport1.Location = new Point(1270, 495);
            teleport1.Margin = new Padding(0);
            teleport1.Name = "teleport1";
            teleport1.Size = new Size(177, 250);
            teleport1.SizeMode = PictureBoxSizeMode.StretchImage;
            teleport1.TabIndex = 371;
            teleport1.TabStop = false;
            teleport1.Tag = "level5";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(113, 9, 14);
            pictureBox3.Image = Properties.Resources.ben_table;
            pictureBox3.Location = new Point(559, 649);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(240, 147);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 370;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(113, 9, 14);
            pictureBox2.Image = Properties.Resources.ben_front;
            pictureBox2.Location = new Point(265, 480);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 280);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 369;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "";
            // 
            // player
            // 
            player.BackColor = Color.FromArgb(255, 255, 192);
            player.Location = new Point(1140, 659);
            player.Name = "player";
            player.Size = new Size(51, 67);
            player.TabIndex = 139;
            player.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.GreenYellow;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.ben_background;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1536, 864);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 368;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "";
            // 
            // pictureBox110
            // 
            pictureBox110.BackColor = Color.FromArgb(113, 9, 14);
            pictureBox110.Location = new Point(0, 729);
            pictureBox110.Margin = new Padding(0);
            pictureBox110.Name = "pictureBox110";
            pictureBox110.Size = new Size(1536, 135);
            pictureBox110.TabIndex = 367;
            pictureBox110.TabStop = false;
            pictureBox110.Tag = "collision wood";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(113, 9, 14);
            pictureBox4.Location = new Point(-100, 0);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 864);
            pictureBox4.TabIndex = 372;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "collision wood";
            // 
            // OuputWindow
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(21, 23, 45);
            ClientSize = new Size(1536, 864);
            Controls.Add(gameScreen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OuputWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Celeste: WinForms Remake - Level Designer";
            KeyDown += OuputWindow_KeyDown;
            gameScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teleport1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox110).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel gameScreen;
        private PictureBox teleport1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox player;
        private PictureBox pictureBox1;
        private PictureBox pictureBox110;
        private PictureBox pictureBox4;
    }
}