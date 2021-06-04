using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fillbtn_Click(object sender, EventArgs e)
        {
            contactlbl.Visible = true;
            firstlbl.Visible = true;
            firsttxtbx.Visible = true;
            lastlbl.Visible = true;
            lasttextbx.Visible = true;
            agelbl.Visible = true;
            agetxtbx.Visible = true;
            genderlbl.Visible = true;
            malechk.Visible = true;
            femalechk.Visible = true;
            otherchk.Visible = true;
            gendertxtbx.Visible = true;
            addresslbl.Visible = true;
            addresstxtbx.Visible = true;
            phonelbl.Visible = true;
            phonetxtbx.Visible = true;
            emailtxtbx.Visible = true;
            emaillbl.Visible = true;
            pic.Visible = false;
            fillbtn.Visible = false;
            donebtn.Visible = true;

        }

        private void firsttxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult a = MessageBox.Show("Invalid input. Please try again.");
            }
        }

        private void lasttextbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult a = MessageBox.Show("Invalid input. Please try again.");
            }
        }

        private void agetxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult a = MessageBox.Show("Invalid input. Please try again.");
            }
        }

        private void gendertxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult a = MessageBox.Show("Invalid input. Please try again.");
            }
        }

        private void phonetxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DialogResult a = MessageBox.Show("Invalid input. Please try again.");
            }
        }

        private void malechk_CheckedChanged(object sender, EventArgs e)
        {
            femalechk.Enabled = false;
            otherchk.Enabled = false;
            if (malechk.CheckState == CheckState.Unchecked)
            {
                femalechk.Enabled = true;
                otherchk.Enabled = true;
            }
        }

        private void femalechk_CheckedChanged(object sender, EventArgs e)
        {
            malechk.Enabled = false;
            otherchk.Enabled = false;
            if (femalechk.CheckState == CheckState.Unchecked)
            {
                malechk.Enabled = true;
                otherchk.Enabled = true;
            }
        }

        private void otherchk_CheckedChanged(object sender, EventArgs e)
        {
            malechk.Enabled = false;
            femalechk.Enabled = false;
            gendertxtbx.Enabled = true;
            if (otherchk.CheckState == CheckState.Unchecked)
            {
                femalechk.Enabled = true;
                malechk.Enabled = true;
                gendertxtbx.Enabled = false;
            }
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText("ContactTracing.txt");
            outputFile.WriteLine("");
            outputFile.WriteLine(DateTime.Now.ToLongDateString());
            outputFile.WriteLine(DateTime.Now.ToLongTimeString());
            outputFile.WriteLine("");
            outputFile.WriteLine("FIRST NAME: " + firsttxtbx.Text);
            outputFile.WriteLine("LAST NAME: " + lasttextbx.Text);
            outputFile.WriteLine("AGE: " + agetxtbx.Text);
            if (malechk.CheckState == CheckState.Checked)
            {
                outputFile.WriteLine("GENDER: MALE");
            }
            else if (femalechk.CheckState == CheckState.Checked)
            {
                outputFile.WriteLine("GENDER: FEMALE");
            }
            else if (otherchk.CheckState == CheckState.Checked)
            {
                outputFile.WriteLine("GENDER: " + gendertxtbx.Text);
            }
            outputFile.WriteLine("ADDRESS: " + addresstxtbx.Text);
            outputFile.WriteLine("PHONE NUMBER: " + phonetxtbx.Text);
            outputFile.WriteLine("EMAIL ADDRESS: " + emailtxtbx.Text);
            outputFile.Close();
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}