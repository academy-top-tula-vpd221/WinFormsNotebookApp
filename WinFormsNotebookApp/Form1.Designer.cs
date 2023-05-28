namespace WinFormsNotebookApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            editTextBox = new TextBox();
            contextMenuEditTextBox = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            fileOpenButton = new Button();
            openFileDialog = new OpenFileDialog();
            fileSaveButton = new Button();
            saveFileDialog = new SaveFileDialog();
            fontDialog = new FontDialog();
            fontButton = new Button();
            colorDialog = new ColorDialog();
            bgColorButton = new Button();
            menuMain = new MenuStrip();
            menuMainFile = new ToolStripMenuItem();
            menuMainFileNew = new ToolStripMenuItem();
            menuMainFileOpen = new ToolStripMenuItem();
            menuMainFileSave = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuMainExit = new ToolStripMenuItem();
            toolBarMain = new ToolStrip();
            toolBarFileNew = new ToolStripButton();
            toolBarFileOpen = new ToolStripButton();
            toolBarFileSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolBarFontColor = new ToolStripComboBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusColumn = new ToolStripStatusLabel();
            toolStripStatusRow = new ToolStripStatusLabel();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            contextMenuEditTextBox.SuspendLayout();
            menuMain.SuspendLayout();
            toolBarMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // editTextBox
            // 
            editTextBox.ContextMenuStrip = contextMenuEditTextBox;
            editTextBox.Location = new Point(0, 71);
            editTextBox.Multiline = true;
            editTextBox.Name = "editTextBox";
            editTextBox.Size = new Size(803, 382);
            editTextBox.TabIndex = 0;
            editTextBox.TextChanged += editTextBox_TextChanged;
            // 
            // contextMenuEditTextBox
            // 
            contextMenuEditTextBox.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, toolStripMenuItem2, copyToolStripMenuItem, cutToolStripMenuItem, pasteToolStripMenuItem });
            contextMenuEditTextBox.Name = "contextMenuEditTextBox";
            contextMenuEditTextBox.Size = new Size(147, 142);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(146, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(146, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(146, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // fileOpenButton
            // 
            fileOpenButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            fileOpenButton.Location = new Point(21, 473);
            fileOpenButton.Name = "fileOpenButton";
            fileOpenButton.Size = new Size(128, 36);
            fileOpenButton.TabIndex = 1;
            fileOpenButton.Text = "Open File";
            fileOpenButton.UseVisualStyleBackColor = true;
            fileOpenButton.Click += fileOpenButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // fileSaveButton
            // 
            fileSaveButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            fileSaveButton.Location = new Point(187, 473);
            fileSaveButton.Name = "fileSaveButton";
            fileSaveButton.Size = new Size(128, 36);
            fileSaveButton.TabIndex = 1;
            fileSaveButton.Text = "Save File";
            fileSaveButton.UseVisualStyleBackColor = true;
            fileSaveButton.Click += fileSaveButton_Click;
            // 
            // fontButton
            // 
            fontButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            fontButton.Location = new Point(364, 473);
            fontButton.Name = "fontButton";
            fontButton.Size = new Size(128, 36);
            fontButton.TabIndex = 1;
            fontButton.Text = "Font";
            fontButton.UseVisualStyleBackColor = true;
            fontButton.Click += fontButton_Click;
            // 
            // bgColorButton
            // 
            bgColorButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            bgColorButton.Location = new Point(540, 473);
            bgColorButton.Name = "bgColorButton";
            bgColorButton.Size = new Size(128, 36);
            bgColorButton.TabIndex = 1;
            bgColorButton.Text = "Back Color";
            bgColorButton.UseVisualStyleBackColor = true;
            bgColorButton.Click += bgColorButton_Click;
            // 
            // menuMain
            // 
            menuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuMain.Items.AddRange(new ToolStripItem[] { menuMainFile });
            menuMain.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(803, 29);
            menuMain.TabIndex = 2;
            menuMain.Text = "menuStrip1";
            // 
            // menuMainFile
            // 
            menuMainFile.DropDownItems.AddRange(new ToolStripItem[] { menuMainFileNew, menuMainFileOpen, menuMainFileSave, toolStripMenuItem1, menuMainExit });
            menuMainFile.Name = "menuMainFile";
            menuMainFile.Size = new Size(46, 25);
            menuMainFile.Text = "File";
            // 
            // menuMainFileNew
            // 
            menuMainFileNew.Image = (Image)resources.GetObject("menuMainFileNew.Image");
            menuMainFileNew.Name = "menuMainFileNew";
            menuMainFileNew.ShortcutKeys = Keys.Control | Keys.N;
            menuMainFileNew.Size = new Size(180, 26);
            menuMainFileNew.Text = "New";
            // 
            // menuMainFileOpen
            // 
            menuMainFileOpen.Image = (Image)resources.GetObject("menuMainFileOpen.Image");
            menuMainFileOpen.Name = "menuMainFileOpen";
            menuMainFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            menuMainFileOpen.Size = new Size(180, 26);
            menuMainFileOpen.Text = "Open";
            menuMainFileOpen.Click += menuMainFileOpen_Click;
            // 
            // menuMainFileSave
            // 
            menuMainFileSave.Image = (Image)resources.GetObject("menuMainFileSave.Image");
            menuMainFileSave.Name = "menuMainFileSave";
            menuMainFileSave.Size = new Size(180, 26);
            menuMainFileSave.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // menuMainExit
            // 
            menuMainExit.Name = "menuMainExit";
            menuMainExit.Size = new Size(180, 26);
            menuMainExit.Text = "Exit";
            // 
            // toolBarMain
            // 
            toolBarMain.Items.AddRange(new ToolStripItem[] { toolBarFileNew, toolBarFileOpen, toolBarFileSave, toolStripSeparator1, toolBarFontColor });
            toolBarMain.Location = new Point(0, 29);
            toolBarMain.Name = "toolBarMain";
            toolBarMain.Size = new Size(803, 25);
            toolBarMain.TabIndex = 3;
            toolBarMain.Text = "toolStrip1";
            // 
            // toolBarFileNew
            // 
            toolBarFileNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarFileNew.Image = (Image)resources.GetObject("toolBarFileNew.Image");
            toolBarFileNew.ImageTransparentColor = Color.Magenta;
            toolBarFileNew.Name = "toolBarFileNew";
            toolBarFileNew.Size = new Size(23, 22);
            toolBarFileNew.Text = "toolStripButton1";
            toolBarFileNew.Click += toolBarFileNew_Click;
            // 
            // toolBarFileOpen
            // 
            toolBarFileOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarFileOpen.Image = (Image)resources.GetObject("toolBarFileOpen.Image");
            toolBarFileOpen.ImageTransparentColor = Color.Magenta;
            toolBarFileOpen.Name = "toolBarFileOpen";
            toolBarFileOpen.Size = new Size(23, 22);
            toolBarFileOpen.Text = "toolStripButton1";
            toolBarFileOpen.Click += toolBarFileOpen_Click;
            // 
            // toolBarFileSave
            // 
            toolBarFileSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolBarFileSave.Image = (Image)resources.GetObject("toolBarFileSave.Image");
            toolBarFileSave.ImageTransparentColor = Color.Magenta;
            toolBarFileSave.Name = "toolBarFileSave";
            toolBarFileSave.Size = new Size(23, 22);
            toolBarFileSave.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolBarFontColor
            // 
            toolBarFontColor.Items.AddRange(new object[] { "Red", "Blue", "Green" });
            toolBarFontColor.Name = "toolBarFontColor";
            toolBarFontColor.Size = new Size(121, 25);
            toolBarFontColor.SelectedIndexChanged += toolBarFontColor_SelectedIndexChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusColumn, toolStripStatusRow });
            statusStrip1.Location = new Point(0, 524);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(803, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusColumn
            // 
            toolStripStatusColumn.Name = "toolStripStatusColumn";
            toolStripStatusColumn.Size = new Size(13, 17);
            toolStripStatusColumn.Text = "0";
            // 
            // toolStripStatusRow
            // 
            toolStripStatusRow.Name = "toolStripStatusRow";
            toolStripStatusRow.Size = new Size(13, 17);
            toolStripStatusRow.Text = "0";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(146, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(143, 6);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 546);
            Controls.Add(statusStrip1);
            Controls.Add(toolBarMain);
            Controls.Add(bgColorButton);
            Controls.Add(fontButton);
            Controls.Add(fileSaveButton);
            Controls.Add(fileOpenButton);
            Controls.Add(editTextBox);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "Form1";
            Text = "Form1";
            contextMenuEditTextBox.ResumeLayout(false);
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            toolBarMain.ResumeLayout(false);
            toolBarMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox editTextBox;
        private Button fileOpenButton;
        private OpenFileDialog openFileDialog;
        private Button fileSaveButton;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        private Button fontButton;
        private ColorDialog colorDialog;
        private Button bgColorButton;
        private MenuStrip menuMain;
        private ToolStripMenuItem menuMainFile;
        private ToolStripMenuItem menuMainFileNew;
        private ToolStripMenuItem menuMainFileOpen;
        private ToolStripMenuItem menuMainFileSave;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuMainExit;
        private ToolStrip toolBarMain;
        private ToolStripButton toolBarFileNew;
        private ToolStripButton toolBarFileOpen;
        private ToolStripButton toolBarFileSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox toolBarFontColor;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusColumn;
        private ToolStripStatusLabel toolStripStatusRow;
        private ContextMenuStrip contextMenuEditTextBox;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
    }
}