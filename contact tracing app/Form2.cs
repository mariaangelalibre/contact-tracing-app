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

    public partial class Form2 : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        string lines = "";
        public Form2()
        {
            InitializeComponent();
        }
        private void fillbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(openFile.FileName);
                while (lines != null)
                {
                    lines = r.ReadLine();
                    if(lines != null)
                    {
                        infolist.Items.Add(lines);
                    }
                }
                r.Close();
            }

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}