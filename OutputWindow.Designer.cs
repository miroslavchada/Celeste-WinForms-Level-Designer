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
            SuspendLayout();
            // 
            // OuputWindow
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(21, 23, 45);
            ClientSize = new Size(1536, 864);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OuputWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Celeste: WinForms Remake - Level Designer";
            ResumeLayout(false);
        }

        #endregion
    }
}