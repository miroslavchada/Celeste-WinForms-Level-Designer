using System.Resources;
using System.Windows.Forms;

namespace Level_Designer
{
    public partial class OuputWindow : Form
    {
        public OuputWindow()
        {
            InitializeComponent();

            Button export = new()
            {
                Width = 190,
                Height = 70,
                Left = (gameScreen.Width / 2) - (190 / 2),
                Top = (gameScreen.Height / 2) - (70 / 2),
                BackColor = Color.White,
                Font = new Font("Segoe UI", 13f),
                Text = "Exportovat"
            };

            export.Click += Export;
            gameScreen.Controls.Add(export);
            export.BringToFront();
        }

        private void Export(object sender, EventArgs e)
        {
            Close();
        }
    }
}