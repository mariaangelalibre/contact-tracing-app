
namespace contact_tracing_app
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firsttxtbx = new System.Windows.Forms.TextBox();
            this.firstlbl = new System.Windows.Forms.Label();
            this.lasttextbx = new System.Windows.Forms.TextBox();
            this.lastlbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.agetxtbx = new System.Windows.Forms.TextBox();
            this.phonetxtbx = new System.Windows.Forms.TextBox();
            this.genderlbl = new System.Windows.Forms.Label();
            this.contactlbl = new System.Windows.Forms.Label();
            this.malechk = new System.Windows.Forms.CheckBox();
            this.otherchk = new System.Windows.Forms.CheckBox();
            this.femalechk = new System.Windows.Forms.CheckBox();
            this.gendertxtbx = new System.Windows.Forms.TextBox();
            this.addresstxtbx = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.emailtxtbx = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.fillbtn = new System.Windows.Forms.Button();
            this.donebtn = new System.Windows.Forms.Button();
            this.datelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // firsttxtbx
            // 
            this.firsttxtbx.Location = new System.Drawing.Point(113, 43);
            this.firsttxtbx.Name = "firsttxtbx";
            this.firsttxtbx.Size = new System.Drawing.Size(280, 20);
            this.firsttxtbx.TabIndex = 0;
            this.firsttxtbx.Visible = false;
            this.firsttxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firsttxtbx_KeyPress);
            // 
            // firstlbl
            // 
            this.firstlbl.AutoSize = true;
            this.firstlbl.Location = new System.Drawing.Point(12, 46);
            this.firstlbl.Name = "firstlbl";
            this.firstlbl.Size = new System.Drawing.Size(72, 13);
            this.firstlbl.TabIndex = 1;
            this.firstlbl.Text = "FIRST NAME";
            this.firstlbl.Visible = false;
            // 
            // lasttextbx
            // 
            this.lasttextbx.Location = new System.Drawing.Point(113, 83);
            this.lasttextbx.Name = "lasttextbx";
            this.lasttextbx.Size = new System.Drawing.Size(280, 20);
            this.lasttextbx.TabIndex = 2;
            this.lasttextbx.Visible = false;
            this.lasttextbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lasttextbx_KeyPress);
            // 
            // lastlbl
            // 
            this.lastlbl.AutoSize = true;
            this.lastlbl.Location = new System.Drawing.Point(12, 85);
            this.lastlbl.Name = "lastlbl";
            this.lastlbl.Size = new System.Drawing.Size(68, 13);
            this.lastlbl.TabIndex = 3;
            this.lastlbl.Text = "LAST NAME";
            this.lastlbl.Visible = false;
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Location = new System.Drawing.Point(12, 263);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(59, 13);
            this.addresslbl.TabIndex = 4;
            this.addresslbl.Text = "ADDRESS";
            this.addresslbl.Visible = false;
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(12, 295);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(95, 13);
            this.phonelbl.TabIndex = 5;
            this.phonelbl.Text = "PHONE NUMBER";
            this.phonelbl.Visible = false;
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Location = new System.Drawing.Point(12, 127);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(29, 13);
            this.agelbl.TabIndex = 6;
            this.agelbl.Text = "AGE";
            this.agelbl.Visible = false;
            // 
            // agetxtbx
            // 
            this.agetxtbx.Location = new System.Drawing.Point(113, 123);
            this.agetxtbx.Name = "agetxtbx";
            this.agetxtbx.Size = new System.Drawing.Size(280, 20);
            this.agetxtbx.TabIndex = 7;
            this.agetxtbx.Visible = false;
            this.agetxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.agetxtbx_KeyPress);
            // 
            // phonetxtbx
            // 
            this.phonetxtbx.Location = new System.Drawing.Point(113, 292);
            this.phonetxtbx.Name = "phonetxtbx";
            this.phonetxtbx.Size = new System.Drawing.Size(280, 20);
            this.phonetxtbx.TabIndex = 8;
            this.phonetxtbx.Visible = false;
            this.phonetxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonetxtbx_KeyPress);
            // 
            // genderlbl
            // 
            this.genderlbl.AutoSize = true;
            this.genderlbl.Location = new System.Drawing.Point(12, 170);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Size = new System.Drawing.Size(53, 13);
            this.genderlbl.TabIndex = 10;
            this.genderlbl.Text = "GENDER";
            this.genderlbl.Visible = false;
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Location = new System.Drawing.Point(12, 9);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(109, 13);
            this.contactlbl.TabIndex = 11;
            this.contactlbl.Text = "CONTACT TRACING";
            this.contactlbl.Visible = false;
            // 
            // malechk
            // 
            this.malechk.AutoSize = true;
            this.malechk.Location = new System.Drawing.Point(113, 170);
            this.malechk.Name = "malechk";
            this.malechk.Size = new System.Drawing.Size(55, 17);
            this.malechk.TabIndex = 12;
            this.malechk.Text = "MALE";
            this.malechk.UseVisualStyleBackColor = true;
            this.malechk.Visible = false;
            this.malechk.CheckedChanged += new System.EventHandler(this.malechk_CheckedChanged);
            // 
            // otherchk
            // 
            this.otherchk.AutoSize = true;
            this.otherchk.Location = new System.Drawing.Point(113, 197);
            this.otherchk.Name = "otherchk";
            this.otherchk.Size = new System.Drawing.Size(140, 17);
            this.otherchk.TabIndex = 13;
            this.otherchk.Text = "OTHER (please specify)";
            this.otherchk.UseVisualStyleBackColor = true;
            this.otherchk.Visible = false;
            this.otherchk.CheckedChanged += new System.EventHandler(this.otherchk_CheckedChanged);
            // 
            // femalechk
            // 
            this.femalechk.AutoSize = true;
            this.femalechk.Location = new System.Drawing.Point(192, 170);
            this.femalechk.Name = "femalechk";
            this.femalechk.Size = new System.Drawing.Size(68, 17);
            this.femalechk.TabIndex = 14;
            this.femalechk.Text = "FEMALE";
            this.femalechk.UseVisualStyleBackColor = true;
            this.femalechk.Visible = false;
            this.femalechk.CheckedChanged += new System.EventHandler(this.femalechk_CheckedChanged);
            // 
            // gendertxtbx
            // 
            this.gendertxtbx.Enabled = false;
            this.gendertxtbx.Location = new System.Drawing.Point(113, 220);
            this.gendertxtbx.Name = "gendertxtbx";
            this.gendertxtbx.Size = new System.Drawing.Size(280, 20);
            this.gendertxtbx.TabIndex = 8;
            this.gendertxtbx.Visible = false;
            this.gendertxtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gendertxtbx_KeyPress);
            // 
            // addresstxtbx
            // 
            this.addresstxtbx.Location = new System.Drawing.Point(113, 256);
            this.addresstxtbx.Name = "addresstxtbx";
            this.addresstxtbx.Size = new System.Drawing.Size(280, 20);
            this.addresstxtbx.TabIndex = 9;
            this.addresstxtbx.Visible = false;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(12, 331);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(94, 13);
            this.emaillbl.TabIndex = 15;
            this.emaillbl.Text = "EMAIL ADDRESS";
            this.emaillbl.Visible = false;
            // 
            // emailtxtbx
            // 
            this.emailtxtbx.Location = new System.Drawing.Point(113, 328);
            this.emailtxtbx.Name = "emailtxtbx";
            this.emailtxtbx.Size = new System.Drawing.Size(280, 20);
            this.emailtxtbx.TabIndex = 16;
            this.emailtxtbx.Visible = false;
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(16, 46);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(380, 246);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 17;
            this.pic.TabStop = false;
            // 
            // fillbtn
            // 
            this.fillbtn.Location = new System.Drawing.Point(140, 246);
            this.fillbtn.Name = "fillbtn";
            this.fillbtn.Size = new System.Drawing.Size(132, 40);
            this.fillbtn.TabIndex = 19;
            this.fillbtn.Text = "FILL UP";
            this.fillbtn.UseVisualStyleBackColor = true;
            this.fillbtn.Click += new System.EventHandler(this.fillbtn_Click);
            // 
            // donebtn
            // 
            this.donebtn.Location = new System.Drawing.Point(314, 357);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(79, 30);
            this.donebtn.TabIndex = 20;
            this.donebtn.Text = "DONE";
            this.donebtn.UseVisualStyleBackColor = true;
            this.donebtn.Visible = false;
            this.donebtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(345, 8);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(0, 13);
            this.datelbl.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(412, 396);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.fillbtn);
            this.Controls.Add(this.emailtxtbx);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.femalechk);
            this.Controls.Add(this.otherchk);
            this.Controls.Add(this.malechk);
            this.Controls.Add(this.contactlbl);
            this.Controls.Add(this.genderlbl);
            this.Controls.Add(this.addresstxtbx);
            this.Controls.Add(this.phonetxtbx);
            this.Controls.Add(this.gendertxtbx);
            this.Controls.Add(this.agetxtbx);
            this.Controls.Add(this.agelbl);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.lastlbl);
            this.Controls.Add(this.lasttextbx);
            this.Controls.Add(this.firstlbl);
            this.Controls.Add(this.firsttxtbx);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firsttxtbx;
        private System.Windows.Forms.Label firstlbl;
        private System.Windows.Forms.TextBox lasttextbx;
        private System.Windows.Forms.Label lastlbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.TextBox agetxtbx;
        private System.Windows.Forms.TextBox phonetxtbx;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.CheckBox malechk;
        private System.Windows.Forms.CheckBox otherchk;
        private System.Windows.Forms.CheckBox femalechk;
        private System.Windows.Forms.TextBox gendertxtbx;
        private System.Windows.Forms.TextBox addresstxtbx;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox emailtxtbx;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button fillbtn;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Label datelbl;
    }
}

