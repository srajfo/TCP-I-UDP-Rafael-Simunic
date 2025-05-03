namespace ChatServer
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
            this.lB_logs = new System.Windows.Forms.ListBox();
            this.bT_start = new System.Windows.Forms.Button();
            this.tB_ports = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lB_logs
            // 
            this.lB_logs.FormattingEnabled = true;
            this.lB_logs.Location = new System.Drawing.Point(139, 309);
            this.lB_logs.Name = "lB_logs";
            this.lB_logs.Size = new System.Drawing.Size(731, 264);
            this.lB_logs.TabIndex = 0;
            // 
            // bT_start
            // 
            this.bT_start.Location = new System.Drawing.Point(139, 280);
            this.bT_start.Name = "bT_start";
            this.bT_start.Size = new System.Drawing.Size(183, 23);
            this.bT_start.TabIndex = 1;
            this.bT_start.Text = "start";
            this.bT_start.UseVisualStyleBackColor = true;
            this.bT_start.Click += new System.EventHandler(this.bT_start_Click);
            // 
            // tB_ports
            // 
            this.tB_ports.Location = new System.Drawing.Point(139, 51);
            this.tB_ports.Multiline = true;
            this.tB_ports.Name = "tB_ports";
            this.tB_ports.Size = new System.Drawing.Size(731, 192);
            this.tB_ports.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_ports);
            this.Controls.Add(this.bT_start);
            this.Controls.Add(this.lB_logs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lB_logs;
        private System.Windows.Forms.Button bT_start;
        private System.Windows.Forms.TextBox tB_ports;
        private System.Windows.Forms.Label label1;
    }
}

