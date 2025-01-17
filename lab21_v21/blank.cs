﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Runtime.InteropServices;

namespace lab21_v21
{
    public partial class blank : Form
    {
        public blank()
        {
            InitializeComponent();
            sbTime.Text = Convert.ToString(System.DateTime.Now.ToLongTimeString());
            sbTime.ToolTipText = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }
        public string DocName = "";
        private string BufferText = "";

        public void Cut()
        {
            this.BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }

        public void Copy()
        {
            this.BufferText = richTextBox1.SelectedText;
        }

        public void Paste()
        {
            richTextBox1.SelectedText = this.BufferText;
        }

        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }

        public void Delete()
        {
            richTextBox1.SelectedText = "";
            this.BufferText = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }
        public void Open(string OpenFileName)
        {
            if (OpenFileName == "")
            {
                return;
            }
            else
            {
                StreamReader sr = new StreamReader(OpenFileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                DocName = OpenFileName;
            }
        }
        public void Save(string SaveFileName)
        {
            if (SaveFileName == "")
            {
                return;
            }
            else
            {
                StreamWriter sw = new StreamWriter(SaveFileName);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                DocName = SaveFileName;
            }
        }

        public bool IsSaved = false;

        private void blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsSaved == false)
            {
                if (MessageBox.Show("Do you want save changes in " + this.DocName + "?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Save(this.DocName);
                }
            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            sbAmount.Text = "Аmount of symvols " + richTextBox1.Text.Length.ToString();
        }

        private void blank_Load(object sender, EventArgs e)
        {

        }
        public class RichTextBoxNativeMethods
        {
            public const int WM_USER = 0x0400;
            public const int EM_SETTABSTOPS = WM_USER + 203;
            public const int EM_SETPARAFORMAT = WM_USER + 71;

            public const int PFM_ALIGNMENT = 0x0008;

            [StructLayout(LayoutKind.Sequential)]
            public class PARAFORMAT
            {
                public int cbSize = Marshal.SizeOf(typeof(PARAFORMAT));
                public int dwMask;
                public short wNumbering;
                public short wReserved;
                public int dxStartIndent;
                public int dxRightIndent;
                public int dxOffset;
                public short wAlignment;
                public short cTabCount;
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
                public int[] rgxTabs;
            }

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, ref PARAFORMAT lParam);
        }
    }
}