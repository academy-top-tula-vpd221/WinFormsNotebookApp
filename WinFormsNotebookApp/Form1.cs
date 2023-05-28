namespace WinFormsNotebookApp
{
    public partial class Form1 : Form
    {
        string filterStr = "All files|*.*|Text files (*.txt)|*.txt|Cpp files (*.cpp)|*.cpp";
        string filePath = @"D:\";
        public Form1()
        {
            InitializeComponent();

            ToolStripMenuItem menuMainEdit = new ToolStripMenuItem("Edit");

            menuMain.Items.Add(menuMainEdit);
            ToolStripMenuItem menuMainEditCopy = new ToolStripMenuItem("Copy");
            ToolStripMenuItem menuMainEditCut = new ToolStripMenuItem("Cut");
            ToolStripMenuItem menuMainEditPaste = new ToolStripMenuItem("Paste");
            menuMainEdit.DropDownItems.AddRange(new[] {menuMainEditCopy,
                                                       menuMainEditPaste,
                                                       menuMainEditCut});
            toolBarFontColor.SelectedIndex = 0;
        }

        private void fileOpenButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = filterStr;
            openFileDialog.InitialDirectory = filePath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string fileText = File.ReadAllText(fileName);
                editTextBox.Text = fileText;
            }
        }

        private void fileSaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = filterStr;
            saveFileDialog.InitialDirectory = filePath;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, editTextBox.Text);
            }
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                editTextBox.Font = fontDialog.Font;
                editTextBox.ForeColor = fontDialog.Color;
            }
        }

        private void bgColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.FullOpen = true;
            colorDialog.Color = editTextBox.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editTextBox.BackColor = colorDialog.Color;
            }
        }

        private void menuMainFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = filterStr;
            openFileDialog.InitialDirectory = filePath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string fileText = File.ReadAllText(fileName);
                editTextBox.Text = fileText;
            }
        }

        private void toolBarFileNew_Click(object sender, EventArgs e)
        {

        }

        private void toolBarFileOpen_Click(object sender, EventArgs e)
        {
            menuMainFileOpen_Click(sender, e);
        }

        private void toolBarFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = toolBarFontColor.SelectedIndex;
            switch (color)
            {
                case 0: editTextBox.ForeColor = Color.Red; break;
                case 1: editTextBox.ForeColor = Color.Blue; break;
                case 2: editTextBox.ForeColor = Color.Green; break;
            }
        }

        private void editTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusColumn.Text = editTextBox.SelectionStart.ToString();
        }
    }
}