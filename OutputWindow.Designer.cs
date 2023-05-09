namespace Level_Designer
{
    partial class OuputWindow
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
            gameScreen = new Panel();
            SuspendLayout();
            // 
            // gameScreen
            // 
            gameScreen.Dock = DockStyle.Fill;
            gameScreen.Location = new Point(0, 0);
            gameScreen.Name = "gameScreen";
            gameScreen.Size = new Size(1536, 864);
            gameScreen.TabIndex = 0;
            // 
            // OuputWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 23, 45);
            ClientSize = new Size(1536, 864);
            Controls.Add(gameScreen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OuputWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Celeste: WinForms Remake - Level Designer";
            ResumeLayout(false);
        }

        #endregion

        private Panel gameScreen;
    }
}