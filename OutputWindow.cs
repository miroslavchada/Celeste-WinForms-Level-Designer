using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Level_Designer;

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

    List<string> output = new List<string>();
    string terrainArray = "terrainArray = new Terrain[] { ";
    string strawberryArray = "strawberryArray = new Strawberry[] { ";

    private void Export(object sender, EventArgs e)
    {
        output.Add($"gameScreen.Height = {gameScreen.Height};\r\n");

        foreach (PictureBox block in gameScreen.Controls.OfType<PictureBox>())
        {
            if (block.Name != "player")
            {
                output.Insert(1,
                    $"Terrain {block.Name} = new(" +
                    $"{block.Left}, {block.Top}, " +
                    $"{block.Width}, {block.Height}, " +
                    $"0, 0, " +
                    $"\"{block.Tag}\", " +
                    $"Color.FromArgb({block.BackColor.R}, {block.BackColor.G}, {block.BackColor.B}), " +
                    $"{(block.Image == null ? "null" : block.ImageLocation)}, " +
                    $"{block.Parent.Name});");


                if (block.Name.Contains("strawberry"))
                {
                    if (strawberryArray == "strawberryArray = new Strawberry[] { ")
                    {
                        terrainArray += $"{block.Name}";
                    }

                    terrainArray += $", {block.Name}";
                } else
                {
                    if (terrainArray == "terrainArray = new Terrain[] { ")
                    {
                        terrainArray += $"{block.Name}";
                    }

                    terrainArray += $", {block.Name}";
                }
            }
        }

        terrainArray += " };";
        strawberryArray += " };";

        output.Add($"\r\n{terrainArray}\r\n{strawberryArray}\r\n\r\nplayer.Left = {player.Left};\r\nplayer.Top = {player.Top};\r\n\r\nCameraFocus(\"\");");

        // Ulo�en� v�sledn�ho textu do souboru STX nebo TXT
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "Ulo�te textov� soubor";
        saveFileDialog.FileName = $"Level{gameScreen.Tag}";
        saveFileDialog.Filter = "Textov� soubor|*.txt";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            // Ulo�en� souboru do zvolen� slo�ky
            File.WriteAllLines(saveFileDialog.FileName, output);

            // Otev�en� souboru
            System.Diagnostics.Process.Start("notepad.exe", saveFileDialog.FileName);
        }
    }
}