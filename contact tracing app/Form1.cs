using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                e.Handled = true;
                DialogResult a = MessageBox.Show("Invalid input. Please try again.");
            }
    }
}