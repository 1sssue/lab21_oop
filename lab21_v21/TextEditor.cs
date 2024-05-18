using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab21_v21
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            FileStream filestream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            if (filestream != null)
            {
                StreamReader streamreader = new StreamReader(filestream);
                txtBox.Text = streamreader.ReadToEnd();
                filestream.Close();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.ShowDialog();
                string fileName = saveFileDialog1.FileName;
                FileStream filestream = File.Open(fileName, FileMode.Create, FileAccess.Write);
                if (filestream != null)
                {
                    StreamWriter streamwriter = new StreamWriter(filestream);
                    streamwriter.Write(txtBox.Text);
                    streamwriter.Flush();
                    filestream.Close();
                }
            }
        }
        


    }
}
