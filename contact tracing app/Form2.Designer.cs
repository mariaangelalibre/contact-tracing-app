
namespace contact_tracing_app
{
    partial class Form2
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
            this.viewbtn = new System.Windows.Forms.Button();
            this.infolist = new System.Windows.Forms.ListBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.fillbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // viewbtn
            // 
            this.viewbtn.Location = new System.Drawing.Point(118, 230);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(237, 23);
            this.viewbtn.TabIndex = 0;
            this.viewbtn.Text = "VIEW USER\'S INFORMATION";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // infolist
            // 
            this.infolist.FormattingEnabled = true;
            this.infolist.Location = new System.Drawing.Point(44, 12);
            this.infolist.Name = "infolist";
            this.infolist.Size = new System.Drawing.Size(380, 212);
            this.infolist.TabIndex = 1;
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(349, 266);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // fillbtn
            // 
            this.fillbtn.Location = new System.Drawing.Point(44, 266);
            this.fillbtn.Name = "fillbtn";
            this.fillbtn.Size = new System.Drawing.Size(152, 23);
            this.fillbtn.TabIndex = 3;
            this.fillbtn.Text = "FILL UP ANOTHER FROM";
            this.fillbtn.UseVisualStyleBackColor = true;
            this.fillbtn.Click += new System.EventHandler(this.fillbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 321);
            this.Controls.Add(this.fillbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.infolist);
            this.Controls.Add(this.viewbtn);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.ListBox infolist;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button fillbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}