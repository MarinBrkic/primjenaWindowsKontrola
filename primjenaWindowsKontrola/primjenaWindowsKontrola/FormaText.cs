using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primjenaWindowsKontrola
{
    public partial class FormaText : Form
    {
        private Form1 _form1;

        public FormaText(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string input1 = txtProgramName.Text;
            string input2 = txtProgramDescription.Text;
            _form1.UpdateTextBoxes(input1, input2);
            this.Close();
        }
    }
}
