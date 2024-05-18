namespace lab21_v21
{
    partial class frmmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aboutProgrammToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            toolBarMain = new ToolStrip();
            tbNew = new ToolStripButton();
            tbOpen = new ToolStripButton();
            tbSave = new ToolStripButton();
            tbCut = new ToolStripButton();
            tbCopy = new ToolStripButton();
            tbPaste = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            tbFont = new ToolStripButton();
            tbColor = new ToolStripButton();
            toolStripButton9 = new ToolStripButton();
            tbALeft = new ToolStripButton();
            tbACenter = new ToolStripButton();
            tbARight = new ToolStripButton();
            tbAJustify = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            UKRButton = new ToolStripButton();
            USAButton = new ToolStripButton();
            imageList1 = new ImageList(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            toolBarMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, windowToolStripMenuItem, findToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(184, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(184, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(184, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(184, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(184, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator2, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(164, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(164, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(164, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteToolStripMenuItem.Size = new Size(164, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(164, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(112, 22);
            fontToolStripMenuItem.Text = "Font...";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(112, 22);
            colorToolStripMenuItem.Text = "Color...";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrangeIconsToolStripMenuItem, cascadeToolStripMenuItem, tileHorizontalToolStripMenuItem, tileVerticalToolStripMenuItem });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(63, 20);
            windowToolStripMenuItem.Text = "Window";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            arrangeIconsToolStripMenuItem.Size = new Size(150, 22);
            arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            arrangeIconsToolStripMenuItem.Click += arrangeIconsToolStripMenuItem_Click;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(150, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(150, 22);
            tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(150, 22);
            tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            tileVerticalToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(42, 20);
            findToolStripMenuItem.Text = "Find";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutProgrammToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(24, 20);
            toolStripMenuItem1.Text = "?";
            // 
            // aboutProgrammToolStripMenuItem
            // 
            aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            aboutProgrammToolStripMenuItem.Size = new Size(167, 22);
            aboutProgrammToolStripMenuItem.Text = "About Programm";
            aboutProgrammToolStripMenuItem.Click += aboutProgrammToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "Текстові файли";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files(*.rtf*)| .rtf|All Files(*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "Текстовий документ";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|RTF Files(*.rtf*)| .rtf|All Files(*.*)|*.*";
            // 
            // toolBarMain
            // 
            toolBarMain.ImageScalingSize = new Size(28, 28);
            toolBarMain.Items.AddRange(new ToolStripItem[] { tbNew, tbOpen, tbSave, tbCut, tbCopy, tbPaste, toolStripButton1, tbFont, tbColor, toolStripButton9, tbALeft, tbACenter, tbARight, tbAJustify, toolStripButton6, UKRButton, USAButton });
            toolBarMain.Location = new Point(0, 24);
            toolBarMain.Name = "toolBarMain";
            toolBarMain.Size = new Size(800, 35);
            toolBarMain.TabIndex = 2;
            toolBarMain.Text = "toolStrip1";
            toolBarMain.ItemClicked += toolBarMain_ItemClicked;
            // 
            // tbNew
            // 
            tbNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbNew.Image = (Image)resources.GetObject("tbNew.Image");
            tbNew.ImageTransparentColor = Color.Magenta;
            tbNew.Name = "tbNew";
            tbNew.Size = new Size(32, 32);
            tbNew.Text = "toolStripButton1";
            tbNew.ToolTipText = "Create New";
            tbNew.Click += tbNew_Click;
            // 
            // tbOpen
            // 
            tbOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbOpen.Image = (Image)resources.GetObject("tbOpen.Image");
            tbOpen.ImageTransparentColor = Color.Magenta;
            tbOpen.Name = "tbOpen";
            tbOpen.Size = new Size(32, 32);
            tbOpen.Text = "toolStripButton1";
            tbOpen.ToolTipText = "Open";
            tbOpen.Click += tbOpen_Click;
            // 
            // tbSave
            // 
            tbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbSave.Image = (Image)resources.GetObject("tbSave.Image");
            tbSave.ImageTransparentColor = Color.Magenta;
            tbSave.Name = "tbSave";
            tbSave.Size = new Size(32, 32);
            tbSave.Text = "toolStripButton1";
            tbSave.ToolTipText = "Save";
            tbSave.Click += tbSave_Click;
            // 
            // tbCut
            // 
            tbCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbCut.Image = (Image)resources.GetObject("tbCut.Image");
            tbCut.ImageTransparentColor = Color.Magenta;
            tbCut.Name = "tbCut";
            tbCut.Size = new Size(32, 32);
            tbCut.Text = "toolStripButton1";
            tbCut.ToolTipText = "Cut";
            tbCut.Click += tbCut_Click;
            // 
            // tbCopy
            // 
            tbCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbCopy.Image = (Image)resources.GetObject("tbCopy.Image");
            tbCopy.ImageTransparentColor = Color.Magenta;
            tbCopy.Name = "tbCopy";
            tbCopy.Size = new Size(32, 32);
            tbCopy.Text = "toolStripButton1";
            tbCopy.ToolTipText = "Copy";
            tbCopy.Click += tbCopy_Click;
            // 
            // tbPaste
            // 
            tbPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbPaste.Image = (Image)resources.GetObject("tbPaste.Image");
            tbPaste.ImageTransparentColor = Color.Magenta;
            tbPaste.Name = "tbPaste";
            tbPaste.Size = new Size(32, 32);
            tbPaste.Text = "toolStripButton1";
            tbPaste.ToolTipText = "Paste";
            tbPaste.Click += tbPaste_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 32);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // tbFont
            // 
            tbFont.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbFont.Image = (Image)resources.GetObject("tbFont.Image");
            tbFont.ImageTransparentColor = Color.Magenta;
            tbFont.Name = "tbFont";
            tbFont.Size = new Size(32, 32);
            tbFont.Text = "toolStripButton7";
            tbFont.ToolTipText = "Font";
            tbFont.Click += toolStripButton7_Click;
            // 
            // tbColor
            // 
            tbColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbColor.Image = (Image)resources.GetObject("tbColor.Image");
            tbColor.ImageTransparentColor = Color.Magenta;
            tbColor.Name = "tbColor";
            tbColor.Size = new Size(32, 32);
            tbColor.Text = "toolStripButton8";
            tbColor.ToolTipText = "Color";
            tbColor.Click += toolStripButton8_Click;
            // 
            // toolStripButton9
            // 
            toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton9.ImageTransparentColor = Color.Magenta;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Size = new Size(23, 32);
            toolStripButton9.Text = "toolStripButton9";
            // 
            // tbALeft
            // 
            tbALeft.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbALeft.Image = (Image)resources.GetObject("tbALeft.Image");
            tbALeft.ImageTransparentColor = Color.Magenta;
            tbALeft.Name = "tbALeft";
            tbALeft.Size = new Size(32, 32);
            tbALeft.Text = "toolStripButton2";
            tbALeft.ToolTipText = "Alignment Left";
            tbALeft.Click += toolStripButton2_Click;
            // 
            // tbACenter
            // 
            tbACenter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbACenter.Image = (Image)resources.GetObject("tbACenter.Image");
            tbACenter.ImageTransparentColor = Color.Magenta;
            tbACenter.Name = "tbACenter";
            tbACenter.Size = new Size(32, 32);
            tbACenter.Text = "toolStripButton3";
            tbACenter.ToolTipText = "Alignment Center";
            tbACenter.Click += toolStripButton3_Click;
            // 
            // tbARight
            // 
            tbARight.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbARight.Image = (Image)resources.GetObject("tbARight.Image");
            tbARight.ImageTransparentColor = Color.Magenta;
            tbARight.Name = "tbARight";
            tbARight.Size = new Size(32, 32);
            tbARight.Text = "toolStripButton4";
            tbARight.ToolTipText = "Alignment Right";
            tbARight.Click += toolStripButton4_Click;
            // 
            // tbAJustify
            // 
            tbAJustify.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbAJustify.Image = (Image)resources.GetObject("tbAJustify.Image");
            tbAJustify.ImageTransparentColor = Color.Magenta;
            tbAJustify.Name = "tbAJustify";
            tbAJustify.Size = new Size(32, 32);
            tbAJustify.Text = "toolStripButton5";
            tbAJustify.ToolTipText = "Alignment Justify";
            tbAJustify.Click += toolStripButton5_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(23, 32);
            toolStripButton6.Text = "toolStripButton6";
            // 
            // UKRButton
            // 
            UKRButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            UKRButton.Image = (Image)resources.GetObject("UKRButton.Image");
            UKRButton.ImageTransparentColor = Color.Magenta;
            UKRButton.Name = "UKRButton";
            UKRButton.Size = new Size(32, 32);
            UKRButton.Text = "toolStripButton2";
            UKRButton.ToolTipText = "Українська Мова";
            UKRButton.Click += UKRButton_Click;
            // 
            // USAButton
            // 
            USAButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            USAButton.Image = (Image)resources.GetObject("USAButton.Image");
            USAButton.ImageTransparentColor = Color.Magenta;
            USAButton.Name = "USAButton";
            USAButton.Size = new Size(32, 32);
            USAButton.Text = "toolStripButton3";
            USAButton.ToolTipText = "English Language";
            USAButton.Click += USAButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-paste-32.png");
            imageList1.Images.SetKeyName(1, "icons8-copy-32.png");
            imageList1.Images.SetKeyName(2, "icons8-cut-32.png");
            imageList1.Images.SetKeyName(3, "icons8-save-32.png");
            imageList1.Images.SetKeyName(4, "icons8-open-file-32.png");
            imageList1.Images.SetKeyName(5, "icons8-new-file-32.png");
            imageList1.Images.SetKeyName(6, "icons8-align-justify-32.png");
            imageList1.Images.SetKeyName(7, "icons8-align-left-32.png");
            imageList1.Images.SetKeyName(8, "icons8-align-right-32.png");
            imageList1.Images.SetKeyName(9, "icons8-align-center-32.png");
            imageList1.Images.SetKeyName(10, "icons8-fill-drip-32.png");
            imageList1.Images.SetKeyName(11, "icons8-underline-32.png");
            imageList1.Images.SetKeyName(12, "icons8-italic-32.png");
            // 
            // frmmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolBarMain);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmmain";
            Text = "Notepad C#";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolBarMain.ResumeLayout(false);
            toolBarMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        public FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStrip toolBarMain;
        private ToolStripButton tbNew;
        private ToolStripButton tbOpen;
        private ToolStripButton tbSave;
        private ToolStripButton tbCut;
        private ToolStripButton tbCopy;
        private ToolStripButton tbPaste;
        public ImageList imageList1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton UKRButton;
        private ToolStripButton USAButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripButton tbALeft;
        private ToolStripButton tbFont;
        private ToolStripButton tbACenter;
        private ToolStripButton tbARight;
        private ToolStripButton tbAJustify;
        private ToolStripButton toolStripButton6;
        private ToolStripButton tbColor;
        private ToolStripButton toolStripButton9;
    }
}