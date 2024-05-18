using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab21_v21.blank;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace lab21_v21
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
        }
        private int openDocuments = 0;

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();

        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.SelectAll();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Save(frm.DocName);

                frm.IsSaved = true;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                saveToolStripMenuItem.Enabled = true;

                frm.IsSaved = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            fontDialog1.ShowColor = true;
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            frm.Show();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm frm = new FindForm();
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            blank form = (blank)this.ActiveMdiChild;
            form.MdiParent = this;
            int start = form.richTextBox1.SelectionStart;
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);

        }

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.ShowDialog();
        }

        private void tbPaste_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(this, new EventArgs());
        }

        private void toolBarMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tbNew_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(this, new EventArgs());
        }

        private void tbCopy_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(this, new EventArgs());
        }

        private void tbOpen_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(this, new EventArgs());
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(this, new EventArgs());
        }

        private void tbCut_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(this, new EventArgs());
        }

        private void UKRButton_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "Файл";
            newToolStripMenuItem.Text = "Новий файл";
            openToolStripMenuItem.Text = "Відкрити файл";
            saveToolStripMenuItem.Text = "Зберегти";
            saveAsToolStripMenuItem.Text = "Зберегти як";
            exitToolStripMenuItem.Text = "Вихід";

            editToolStripMenuItem.Text = "Редагувати";
            cutToolStripMenuItem.Text = "Вирізати";
            copyToolStripMenuItem.Text = "Копіювати";
            pasteToolStripMenuItem.Text = "Вставити";
            deleteToolStripMenuItem.Text = "Видалити";
            selectAllToolStripMenuItem.Text = "Виділити все";

            formatToolStripMenuItem.Text = "Формат";
            fontToolStripMenuItem.Text = "Шрифт...";
            colorToolStripMenuItem.Text = "Колір...";

            windowToolStripMenuItem.Text = "Вікно";
            arrangeIconsToolStripMenuItem.Text = "Упорядкувати";
            cascadeToolStripMenuItem.Text = "Каскадом";
            tileHorizontalToolStripMenuItem.Text = "Горизонтально";
            tileVerticalToolStripMenuItem.Text = "Вертикально";

            findToolStripMenuItem.Text = "Знайти";

            aboutProgrammToolStripMenuItem.Text = "Про програму";

            tbNew.ToolTipText = "Створити новий файл";
            tbOpen.ToolTipText = "Відкрити файл";
            tbSave.ToolTipText = "Зберегти";
            tbCut.ToolTipText = "Вирізати";
            tbCopy.ToolTipText = "Скопіювати";
            tbPaste.ToolTipText = "Вставити";

            tbFont.ToolTipText = "Шрифт";
            tbColor.ToolTipText = "Колір";

            tbALeft.ToolTipText = "Вирівнювання ліворуч";
            tbACenter.ToolTipText = "Вирівнювання по центру";
            tbARight.ToolTipText = "Вирівнювання праворуч";
            tbAJustify.ToolTipText = "Вирівнювання по ширині";
        }

        private void USAButton_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Text = "File";
            newToolStripMenuItem.Text = "Copy";
            openToolStripMenuItem.Text = "Open";
            saveToolStripMenuItem.Text = "Save";
            saveAsToolStripMenuItem.Text = "Save as";
            exitToolStripMenuItem.Text = "Exit";

            editToolStripMenuItem.Text = "Edit";
            cutToolStripMenuItem.Text = "Cut";
            copyToolStripMenuItem.Text = "Copy";
            pasteToolStripMenuItem.Text = "Paste";
            deleteToolStripMenuItem.Text = "Delete";
            selectAllToolStripMenuItem.Text = "Select All";

            formatToolStripMenuItem.Text = "Format";
            fontToolStripMenuItem.Text = "Font";
            colorToolStripMenuItem.Text = "Color";

            windowToolStripMenuItem.Text = "Window";
            arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            cascadeToolStripMenuItem.Text = "Cascade";
            tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            tileVerticalToolStripMenuItem.Text = "Tile Vertical";

            findToolStripMenuItem.Text = "Find";

            aboutProgrammToolStripMenuItem.Text = "About Programm";

            tbNew.ToolTipText = "Create New File";
            tbOpen.ToolTipText = "Open FIle";
            tbSave.ToolTipText = "Save";
            tbCut.ToolTipText = "Cut";
            tbCopy.ToolTipText = "Copy";
            tbPaste.ToolTipText = "Paste";

            tbFont.ToolTipText = "Font";
            tbColor.ToolTipText = "Color";

            tbALeft.ToolTipText = "Alight Left";
            tbACenter.ToolTipText = "Alight Center";
            tbARight.ToolTipText = "Alight Right";
            tbAJustify.ToolTipText = "Alight Justify";
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            fontToolStripMenuItem_Click(this, new EventArgs());
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            colorToolStripMenuItem_Click(this, new EventArgs());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            SetAlignment(frm.richTextBox1.Handle, 4);
        }
        public static void SetAlignment(IntPtr handle, int alignment)
        {
            RichTextBoxNativeMethods.PARAFORMAT format = new RichTextBoxNativeMethods.PARAFORMAT();
            format.cbSize = Marshal.SizeOf(format);
            format.dwMask = RichTextBoxNativeMethods.PFM_ALIGNMENT;
            format.wAlignment = (short)alignment;

            RichTextBoxNativeMethods.SendMessage(handle, RichTextBoxNativeMethods.EM_SETPARAFORMAT, 0, ref format);
        }
    }
}
