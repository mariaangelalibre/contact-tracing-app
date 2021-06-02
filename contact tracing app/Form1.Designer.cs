
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstlbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lastlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 0;
            // 
            // firstlbl
            // 
            this.firstlbl.AutoSize = true;
            this.firstlbl.Location = new System.Drawing.Point(12, 19);
            this.firstlbl.Name = "firstlbl";
            this.firstlbl.Size = new System.Drawing.Size(72, 13);
            this.firstlbl.TabIndex = 1;
            this.firstlbl.Text = "FIRST NAME";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lastlbl
            // 
            this.lastlbl.AutoSize = true;
            this.lastlbl.Location = new System.Drawing.Point(12, 49);
            this.lastlbl.Name = "lastlbl";
            this.lastlbl.Size = new System.Drawing.Size(68, 13);
            this.lastlbl.TabIndex = 3;
            this.lastlbl.Text = "LAST NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Location = new System.Drawing.Point(12, 81);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(29, 13);
            this.agelbl.TabIndex = 6;
            this.agelbl.Text = "AGE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 310);
            this.Controls.Add(this.agelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastlbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.firstlbl);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label firstlbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lastlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label agelbl;
    }
}

