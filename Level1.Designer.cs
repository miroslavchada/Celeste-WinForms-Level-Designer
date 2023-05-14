namespace Level_Designer
{
    partial class Level1
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
            gameScreen = new Panel();
            SuspendLayout();
            // 
            // gameScreen
            // 
            gameScreen.Location = new Point(0, 0);
            gameScreen.Margin = new Padding(0);
            gameScreen.Name = "gameScreen";
            gameScreen.Size = new Size(1536, 864);
            gameScreen.TabIndex = 63;
            // 
            // Level1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(21, 23, 45);
            Controls.Add(gameScreen);
            Name = "Level1";
            Size = new Size(1536, 864);
            ResumeLayout(false);
        }

        #endregion
        private Panel gameScreen;
    }
}
