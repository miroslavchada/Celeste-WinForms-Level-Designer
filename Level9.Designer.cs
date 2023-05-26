namespace Level_Designer;

partial class Level9 {
    /// <summary> 
    /// Vyžaduje se proměnná návrháře.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Uvolněte všechny používané prostředky.
    /// </summary>
    /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Kód vygenerovaný pomocí Návrháře komponent

    /// <summary> 
    /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
    /// obsah této metody v editoru kódu.
    /// </summary>
    private void InitializeComponent() {
        pictureBox110 = new PictureBox();
        gameScreen = new Panel();
        player = new PictureBox();
        pictureBox1 = new PictureBox();
        pictureBox2 = new PictureBox();
        pictureBox3 = new PictureBox();
        teleport1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox110).BeginInit();
        gameScreen.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)player).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)teleport1).BeginInit();
        SuspendLayout();
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
        // gameScreen
        // 
        gameScreen.BackColor = Color.FromArgb(21, 23, 45);
        gameScreen.Controls.Add(teleport1);
        gameScreen.Controls.Add(pictureBox3);
        gameScreen.Controls.Add(pictureBox2);
        gameScreen.Controls.Add(player);
        gameScreen.Controls.Add(pictureBox1);
        gameScreen.Controls.Add(pictureBox110);
        gameScreen.Dock = DockStyle.Fill;
        gameScreen.Location = new Point(0, 0);
        gameScreen.Margin = new Padding(0);
        gameScreen.Name = "gameScreen";
        gameScreen.Size = new Size(1536, 864);
        gameScreen.TabIndex = 368;
        // 
        // player
        // 
        player.BackColor = Color.FromArgb(255, 255, 192);
        player.Location = new Point(1059, 659);
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
        // Level9
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.GreenYellow;
        Controls.Add(gameScreen);
        Name = "Level9";
        Size = new Size(1536, 864);
        ((System.ComponentModel.ISupportInitialize)pictureBox110).EndInit();
        gameScreen.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)player).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)teleport1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox110;
    private Panel gameScreen;
    private PictureBox player;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private PictureBox teleport1;
    private PictureBox pictureBox3;
}
