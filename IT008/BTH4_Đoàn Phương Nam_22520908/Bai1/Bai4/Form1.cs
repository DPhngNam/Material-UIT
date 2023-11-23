using System.Drawing.Text;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fontsize.SelectedItem = "14";

            InstalledFontCollection installedFonts = new InstalledFontCollection();


            foreach (FontFamily fontFamily in installedFonts.Families)
            {
                Fontfamil.Items.Add(fontFamily.Name);
            }
            Fontfamil.SelectedItem = "Tahoma";
        }
        private void clear()
        {
            rbt.Clear();
            fontsize.SelectedItem = "14";
            Fontfamil.SelectedItem = "Tahoma";
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

        }

        private void Bold_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rbt.SelectionFont.FontFamily.Name, rbt.SelectionFont.Size, FontStyle.Bold);
            rbt.SelectionFont = newFont;
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rbt.SelectionFont.FontFamily.Name, rbt.SelectionFont.Size, FontStyle.Italic);
            rbt.SelectionFont = newFont;
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(rbt.SelectionFont.FontFamily.Name, rbt.SelectionFont.Size, FontStyle.Underline);
            rbt.SelectionFont = newFont;
        }

        private void fontsize_Click(object sender, EventArgs e)
        {

        }

        private void fontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbt.SelectionFont != null)
            {
                string selectedFontName = rbt.SelectionFont.FontFamily.Name;
                float selectedFontSize = float.Parse(fontsize.SelectedItem.ToString()); // Assuming the fontsize combobox contains valid float values

                FontStyle selectedFontStyle = rbt.SelectionFont.Style;

                // Create a new font based on the selected font family, size, and style
                Font newFont = new Font(selectedFontName, selectedFontSize, selectedFontStyle);

                // Use the new font for the selected text or further operations
                rbt.SelectionFont = newFont;
            }
        }

        private void Fontfamil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbt.SelectionFont != null)
            {
                string selectedFontName = Fontfamil.SelectedItem.ToString();
                float selectedFontSize = (float)rbt.SelectionFont.Size; // Assuming the fontsize combobox contains valid float values

                FontStyle selectedFontStyle = rbt.SelectionFont.Style;

                // Create a new font based on the selected font family, size, and style
                Font newFont = new Font(selectedFontName, selectedFontSize, selectedFontStyle);

                // Use the new font for the selected text or further operations
                rbt.SelectionFont = newFont;
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter to only allow *.txt files
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            openFileDialog.Title = "Select a Text or Rich Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFile = openFileDialog.FileName;
                // Perform operations with the selected file
            }
            MessageBox.Show("Thanh cong");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set filter to save as *.txt or *.rtf files
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            saveFileDialog.Title = "Save File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file path where the user wants to save the file
                string filePath = saveFileDialog.FileName;

                // Perform file-saving operations based on your application's logic
                // For example, if you have a RichTextBox named rbt and want to save its content:
                if (filePath.EndsWith(".txt"))
                {
                    // Save as text file
                    System.IO.File.WriteAllText(filePath, rbt.Text);
                }
                else if (filePath.EndsWith(".rtf"))
                {
                    // Save as RTF file
                    rbt.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    // Handle unsupported file types or other scenarios
                }
            }
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void New_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
