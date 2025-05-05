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
            this.label2 = new System.Windows.Forms.Label();
            this.tB_IP_start = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_IP_end = new System.Windows.Forms.TextBox();
            this.tB_port_end = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_port_start = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_nmap_start = new System.Windows.Forms.Button();
            this.lB_nmap_ispis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lB_logs
            // 
            this.lB_logs.FormattingEnabled = true;
            this.lB_logs.Location = new System.Drawing.Point(15, 275);
            this.lB_logs.Name = "lB_logs";
            this.lB_logs.Size = new System.Drawing.Size(466, 264);
            this.lB_logs.TabIndex = 0;
            // 
            // bT_start
            // 
            this.bT_start.Location = new System.Drawing.Point(15, 246);
            this.bT_start.Name = "bT_start";
            this.bT_start.Size = new System.Drawing.Size(183, 23);
            this.bT_start.TabIndex = 1;
            this.bT_start.Text = "start";
            this.bT_start.UseVisualStyleBackColor = true;
            this.bT_start.Click += new System.EventHandler(this.bT_start_Click);
            // 
            // tB_ports
            // 
            this.tB_ports.Location = new System.Drawing.Point(15, 48);
            this.tB_ports.Multiline = true;
            this.tB_ports.Name = "tB_ports";
            this.tB_ports.Size = new System.Drawing.Size(466, 192);
            this.tB_ports.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "IP range";
            // 
            // tB_IP_start
            // 
            this.tB_IP_start.Location = new System.Drawing.Point(546, 96);
            this.tB_IP_start.Name = "tB_IP_start";
            this.tB_IP_start.Size = new System.Drawing.Size(149, 20);
            this.tB_IP_start.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // tB_IP_end
            // 
            this.tB_IP_end.Location = new System.Drawing.Point(717, 96);
            this.tB_IP_end.Name = "tB_IP_end";
            this.tB_IP_end.Size = new System.Drawing.Size(149, 20);
            this.tB_IP_end.TabIndex = 7;
            // 
            // tB_port_end
            // 
            this.tB_port_end.Location = new System.Drawing.Point(717, 203);
            this.tB_port_end.Name = "tB_port_end";
            this.tB_port_end.Size = new System.Drawing.Size(149, 20);
            this.tB_port_end.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            // 
            // tB_port_start
            // 
            this.tB_port_start.Location = new System.Drawing.Point(546, 203);
            this.tB_port_start.Name = "tB_port_start";
            this.tB_port_start.Size = new System.Drawing.Size(149, 20);
            this.tB_port_start.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port range";
            // 
            // bt_nmap_start
            // 
            this.bt_nmap_start.Location = new System.Drawing.Point(541, 246);
            this.bt_nmap_start.Name = "bt_nmap_start";
            this.bt_nmap_start.Size = new System.Drawing.Size(183, 23);
            this.bt_nmap_start.TabIndex = 12;
            this.bt_nmap_start.Text = "start";
            this.bt_nmap_start.UseVisualStyleBackColor = true;
            this.bt_nmap_start.Click += new System.EventHandler(this.bt_nmap_start_Click);
            // 
            // lB_nmap_ispis
            // 
            this.lB_nmap_ispis.FormattingEnabled = true;
            this.lB_nmap_ispis.Location = new System.Drawing.Point(541, 275);
            this.lB_nmap_ispis.Name = "lB_nmap_ispis";
            this.lB_nmap_ispis.Size = new System.Drawing.Size(466, 264);
            this.lB_nmap_ispis.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 625);
            this.Controls.Add(this.lB_nmap_ispis);
            this.Controls.Add(this.bt_nmap_start);
            this.Controls.Add(this.tB_port_end);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_port_start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tB_IP_end);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_IP_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_ports);
            this.Controls.Add(this.bT_start);
            this.Controls.Add(this.lB_logs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lB_logs;
        private System.Windows.Forms.Button bT_start;
        private System.Windows.Forms.TextBox tB_ports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_IP_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_IP_end;
        private System.Windows.Forms.TextBox tB_port_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_port_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_nmap_start;
        private System.Windows.Forms.ListBox lB_nmap_ispis;
    }
}

