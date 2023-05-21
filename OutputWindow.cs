namespace Level_Designer;

public partial class OuputWindow : Form {
    public OuputWindow() {
        InitializeComponent();
    }

    private void OuputWindow_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
            Export();
        }
    }

    private void Export() {
        List<string> output = new List<string>();
        string terrainArray = "terrainArray = new Terrain[] { ";
        string strawberryArray = "strawberryArray = new Strawberry[] { ";

        output.Add($"gameScreen.Height = {gameScreen.Height};\r\n");

        foreach (PictureBox block in gameScreen.Controls.OfType<PictureBox>()) {
            if (block.Name != "player") {
                output.Insert(1,
                    $"Terrain {block.Name} = new(" +
                    $"{block.Left}, {block.Top}, " +
                    $"{block.Width}, {block.Height}, " +
                    $"0, 0, " +
                    $"\"{block.Tag}\", " +
                    $"Color.FromArgb({block.BackColor.R}, {block.BackColor.G}, {block.BackColor.B}), " +
                    $"{(block.BackgroundImage == null ? "null" : "TEXTURA")}, " +
                    $"{block.Parent.Name});");

                if (block.Name.Contains("strawberry")) {
                    if (strawberryArray == "strawberryArray = new Strawberry[] { ") {
                        strawberryArray += $"{block.Name}";
                    } else {
                        strawberryArray += $", {block.Name}";
                    }
                } else {
                    if (terrainArray == "terrainArray = new Terrain[] { ") {
                        terrainArray += $"{block.Name}";
                    } else {
                        terrainArray += $", {block.Name}";
                    }
                }
            }
        }

        terrainArray += " };";
        strawberryArray += " };";

        output.Add($"\r\n{terrainArray}\r\n{strawberryArray}\r\n\r\nplayer.Left = {player.Left};\r\nplayer.Top = {player.Top};\r\n\r\nCameraFocus(\"\");");

        // Uložení výsledného textu do souboru STX nebo TXT
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "Uložte textový soubor";
        saveFileDialog.FileName = $"Level{gameScreen.Tag}";
        saveFileDialog.Filter = "Textový soubor|*.txt";
        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
            // Uložení souboru do zvolené složky
            File.WriteAllLines(saveFileDialog.FileName, output);

            // Otevøení souboru
            System.Diagnostics.Process.Start("notepad.exe", saveFileDialog.FileName);
        }
    }
}