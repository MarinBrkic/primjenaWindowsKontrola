using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace primjenaWindowsKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            if(cmbBoxProgram.SelectedIndex == 0)
            {
                Process.Start("Notepad.exe");
            }
            else if(cmbBoxProgram.SelectedIndex == 1)
            {
                Process.Start("Paint.exe");
            }
        }

        private void checkBoxShowProgram_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowProgram.Checked == true)
            {
                groupBoxRunProgram.Show();
            }
            else
            {
                groupBoxRunProgram.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProgramName.Clear();
            txtProgramDescription.Clear();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberi neko dugme", "Obavijest",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText frm = new FormaText(this);
            DialogResult = frm.ShowDialog();
        }
        public void UpdateTextBoxes(string text1, string text2)
        {
            txtProgramName.Text = text1;
            txtProgramDescription.Text = text2;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da li ste sigurni da želite zatvoriti aplikaciju?", "Potvrda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
