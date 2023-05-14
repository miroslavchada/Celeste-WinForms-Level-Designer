namespace Level_Designer
{
    partial class Pallette
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            stawberry1 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stawberry1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 160, 102);
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "collision dirt";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(155, 173, 183);
            pictureBox2.Location = new Point(70, 20);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "collision metal";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(99, 155, 255);
            pictureBox3.Location = new Point(120, 20);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.TabIndex = 65;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "collision ice";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(99, 155, 255);
            pictureBox4.Location = new Point(20, 127);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 120);
            pictureBox4.TabIndex = 66;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "collision falling ice";
            // 
            // stawberry1
            // 
            stawberry1.BackColor = Color.FromArgb(255, 128, 128);
            stawberry1.Location = new Point(352, 127);
            stawberry1.Margin = new Padding(0);
            stawberry1.Name = "stawberry1";
            stawberry1.Size = new Size(48, 62);
            stawberry1.TabIndex = 67;
            stawberry1.TabStop = false;
            stawberry1.Tag = "";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Silver;
            pictureBox5.Location = new Point(130, 127);
            pictureBox5.Margin = new Padding(0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(200, 140);
            pictureBox5.TabIndex = 68;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "collision elevator metal";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Location = new Point(191, 30);
            pictureBox6.Margin = new Padding(0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 30);
            pictureBox6.TabIndex = 69;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "collision spikes";
            // 
            // Pallette
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(21, 23, 45);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(stawberry1);
            Margin = new Padding(0);
            Name = "Pallette";
            Size = new Size(1536, 864);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)stawberry1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox stawberry1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}
