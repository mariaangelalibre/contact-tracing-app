
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.closebtn = new System.Windows.Forms.Button();
            this.fillagainbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewbtn
            // 
            this.viewbtn.Location = new System.Drawing.Point(91, 19);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(237, 23);
            this.viewbtn.TabIndex = 0;
            this.viewbtn.Text = "VIEW USER\'S INFORMATION";
            this.viewbtn.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(45, 48);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(323, 225);
            this.listBox.TabIndex = 1;
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(281, 279);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(75, 23);
            this.closebtn.TabIndex = 2;
            this.closebtn.Text = "CLOSE";
            this.closebtn.UseVisualStyleBackColor = true;
            // 
            // fillagainbtn
            // 
            this.fillagainbtn.Location = new System.Drawing.Point(109, 279);
            this.fillagainbtn.Name = "fillagainbtn";
            this.fillagainbtn.Size = new System.Drawing.Size(153, 23);
            this.fillagainbtn.TabIndex = 3;
            this.fillagainbtn.Text = "FILL UP ANOTHER FORM";
            this.fillagainbtn.UseVisualStyleBackColor = true;
            this.fillagainbtn.Click += new System.EventHandler(this.fillagainbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 321);
            this.Controls.Add(this.fillagainbtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.viewbtn);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button fillagainbtn;
    }
}