namespace WindowsFormsAppTCPKlijent
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
            this.bTSend = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tB_poruka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bTSend
            // 
            this.bTSend.Location = new System.Drawing.Point(106, 99);
            this.bTSend.Name = "bTSend";
            this.bTSend.Size = new System.Drawing.Size(148, 89);
            this.bTSend.TabIndex = 0;
            this.bTSend.Text = "salji";
            this.bTSend.UseVisualStyleBackColor = true;
            this.bTSend.Click += new System.EventHandler(this.bTSend_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(106, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(598, 264);
            this.listBox1.TabIndex = 1;
            // 
            // tB_poruka
            // 
            this.tB_poruka.Location = new System.Drawing.Point(270, 168);
            this.tB_poruka.Name = "tB_poruka";
            this.tB_poruka.Size = new System.Drawing.Size(289, 20);
            this.tB_poruka.TabIndex = 2;
            this.tB_poruka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 597);
            this.Controls.Add(this.tB_poruka);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bTSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTSend;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tB_poruka;
    }
}

