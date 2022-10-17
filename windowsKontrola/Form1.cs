using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnRun.Enabled = chkShow.Checked;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(cmbProgram.Text == "Notepad")
            {
                System.Diagnostics.Process.Start("Notepad.exe");
            }

            if(cmbProgram.Text == "Paint")
            {
                System.Diagnostics.Process.Start("mspaint.exe");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            rtbDesc.Text = "";
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Odaberite neko dugme","Obavještenje",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Text = new Form2();
            Text.Show();
        }
    }
}
