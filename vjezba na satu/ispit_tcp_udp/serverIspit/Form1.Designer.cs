namespace serverIspit
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
            this.bt_start_udp = new System.Windows.Forms.Button();
            this.bt_start_tcp = new System.Windows.Forms.Button();
            this.lB_udp = new System.Windows.Forms.ListBox();
            this.lB_tcp = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_nmap_start = new System.Windows.Forms.Button();
            this.lb_nmap_ispis = new System.Windows.Forms.ListBox();
            this.tB_ip_start = new System.Windows.Forms.TextBox();
            this.tB_ip_end = new System.Windows.Forms.TextBox();
            this.tB_port_start = new System.Windows.Forms.TextBox();
            this.tB_port_end = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_portovi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_start_udp
            // 
            this.bt_start_udp.Location = new System.Drawing.Point(12, 76);
            this.bt_start_udp.Name = "bt_start_udp";
            this.bt_start_udp.Size = new System.Drawing.Size(75, 23);
            this.bt_start_udp.TabIndex = 0;
            this.bt_start_udp.Text = "UDP";
            this.bt_start_udp.UseVisualStyleBackColor = true;
            this.bt_start_udp.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_start_tcp
            // 
            this.bt_start_tcp.Location = new System.Drawing.Point(252, 76);
            this.bt_start_tcp.Name = "bt_start_tcp";
            this.bt_start_tcp.Size = new System.Drawing.Size(75, 23);
            this.bt_start_tcp.TabIndex = 1;
            this.bt_start_tcp.Text = "TCP";
            this.bt_start_tcp.UseVisualStyleBackColor = true;
            this.bt_start_tcp.Click += new System.EventHandler(this.bt_start_tcp_Click);
            // 
            // lB_udp
            // 
            this.lB_udp.FormattingEnabled = true;
            this.lB_udp.Location = new System.Drawing.Point(12, 105);
            this.lB_udp.Name = "lB_udp";
            this.lB_udp.Size = new System.Drawing.Size(161, 498);
            this.lB_udp.TabIndex = 2;
            // 
            // lB_tcp
            // 
            this.lB_tcp.FormattingEnabled = true;
            this.lB_tcp.Location = new System.Drawing.Point(252, 105);
            this.lB_tcp.Name = "lB_tcp";
            this.lB_tcp.Size = new System.Drawing.Size(161, 498);
            this.lB_tcp.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // bt_nmap_start
            // 
            this.bt_nmap_start.Location = new System.Drawing.Point(487, 76);
            this.bt_nmap_start.Name = "bt_nmap_start";
            this.bt_nmap_start.Size = new System.Drawing.Size(75, 23);
            this.bt_nmap_start.TabIndex = 5;
            this.bt_nmap_start.Text = "nmap";
            this.bt_nmap_start.UseVisualStyleBackColor = true;
            this.bt_nmap_start.Click += new System.EventHandler(this.bt_nmap_start_Click);
            // 
            // lb_nmap_ispis
            // 
            this.lb_nmap_ispis.FormattingEnabled = true;
            this.lb_nmap_ispis.Location = new System.Drawing.Point(487, 105);
            this.lb_nmap_ispis.Name = "lb_nmap_ispis";
            this.lb_nmap_ispis.Size = new System.Drawing.Size(252, 498);
            this.lb_nmap_ispis.TabIndex = 6;
            // 
            // tB_ip_start
            // 
            this.tB_ip_start.Location = new System.Drawing.Point(766, 105);
            this.tB_ip_start.Name = "tB_ip_start";
            this.tB_ip_start.Size = new System.Drawing.Size(100, 20);
            this.tB_ip_start.TabIndex = 7;
            // 
            // tB_ip_end
            // 
            this.tB_ip_end.Location = new System.Drawing.Point(930, 105);
            this.tB_ip_end.Name = "tB_ip_end";
            this.tB_ip_end.Size = new System.Drawing.Size(100, 20);
            this.tB_ip_end.TabIndex = 8;
            // 
            // tB_port_start
            // 
            this.tB_port_start.Location = new System.Drawing.Point(766, 190);
            this.tB_port_start.Name = "tB_port_start";
            this.tB_port_start.Size = new System.Drawing.Size(100, 20);
            this.tB_port_start.TabIndex = 9;
            // 
            // tB_port_end
            // 
            this.tB_port_end.Location = new System.Drawing.Point(930, 190);
            this.tB_port_end.Name = "tB_port_end";
            this.tB_port_end.Size = new System.Drawing.Size(100, 20);
            this.tB_port_end.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(763, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PORTS";
            // 
            // tB_portovi
            // 
            this.tB_portovi.Location = new System.Drawing.Point(766, 336);
            this.tB_portovi.Multiline = true;
            this.tB_portovi.Name = "tB_portovi";
            this.tB_portovi.Size = new System.Drawing.Size(405, 267);
            this.tB_portovi.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 648);
            this.Controls.Add(this.tB_portovi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_port_end);
            this.Controls.Add(this.tB_port_start);
            this.Controls.Add(this.tB_ip_end);
            this.Controls.Add(this.tB_ip_start);
            this.Controls.Add(this.lb_nmap_ispis);
            this.Controls.Add(this.bt_nmap_start);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lB_tcp);
            this.Controls.Add(this.lB_udp);
            this.Controls.Add(this.bt_start_tcp);
            this.Controls.Add(this.bt_start_udp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_start_udp;
        private System.Windows.Forms.Button bt_start_tcp;
        private System.Windows.Forms.ListBox lB_udp;
        private System.Windows.Forms.ListBox lB_tcp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_nmap_start;
        private System.Windows.Forms.ListBox lb_nmap_ispis;
        private System.Windows.Forms.TextBox tB_ip_start;
        private System.Windows.Forms.TextBox tB_ip_end;
        private System.Windows.Forms.TextBox tB_port_start;
        private System.Windows.Forms.TextBox tB_port_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_portovi;
    }
}

