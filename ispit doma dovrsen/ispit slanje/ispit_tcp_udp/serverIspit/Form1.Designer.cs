using System;

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
            this.bt_nmap_start = new System.Windows.Forms.Button();
            this.lb_nmap_ispis = new System.Windows.Forms.ListBox();
            this.tB_ip_start = new System.Windows.Forms.TextBox();
            this.tB_port_start = new System.Windows.Forms.TextBox();
            this.tB_port_end = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_poruke = new System.Windows.Forms.ListBox();
            this.cB_odabir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_nmap_start
            // 
            this.bt_nmap_start.Location = new System.Drawing.Point(576, 139);
            this.bt_nmap_start.Name = "bt_nmap_start";
            this.bt_nmap_start.Size = new System.Drawing.Size(75, 23);
            this.bt_nmap_start.TabIndex = 5;
            this.bt_nmap_start.Text = "search";
            this.bt_nmap_start.UseVisualStyleBackColor = true;
            this.bt_nmap_start.Click += new System.EventHandler(this.bt_nmap_start_Click);
            // 
            // lb_nmap_ispis
            // 
            this.lb_nmap_ispis.FormattingEnabled = true;
            this.lb_nmap_ispis.Location = new System.Drawing.Point(485, 231);
            this.lb_nmap_ispis.Name = "lb_nmap_ispis";
            this.lb_nmap_ispis.Size = new System.Drawing.Size(784, 342);
            this.lb_nmap_ispis.TabIndex = 6;
            // 
            // tB_ip_start
            // 
            this.tB_ip_start.Location = new System.Drawing.Point(576, 72);
            this.tB_ip_start.Name = "tB_ip_start";
            this.tB_ip_start.Size = new System.Drawing.Size(100, 20);
            this.tB_ip_start.TabIndex = 7;
            // 
            // tB_port_start
            // 
            this.tB_port_start.Location = new System.Drawing.Point(576, 26);
            this.tB_port_start.Name = "tB_port_start";
            this.tB_port_start.Size = new System.Drawing.Size(100, 20);
            this.tB_port_start.TabIndex = 9;
            // 
            // tB_port_end
            // 
            this.tB_port_end.Location = new System.Drawing.Point(715, 26);
            this.tB_port_end.Name = "tB_port_end";
            this.tB_port_end.Size = new System.Drawing.Size(100, 20);
            this.tB_port_end.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PORTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "IP";
            // 
            // lb_poruke
            // 
            this.lb_poruke.FormattingEnabled = true;
            this.lb_poruke.Location = new System.Drawing.Point(63, 231);
            this.lb_poruke.Name = "lb_poruke";
            this.lb_poruke.Size = new System.Drawing.Size(331, 342);
            this.lb_poruke.TabIndex = 14;
            // 
            // cB_odabir
            // 
            this.cB_odabir.FormattingEnabled = true;
            this.cB_odabir.Items.AddRange(new object[] {
            "UDP",
            "TCP"});
            this.cB_odabir.Location = new System.Drawing.Point(63, 64);
            this.cB_odabir.Name = "cB_odabir";
            this.cB_odabir.Size = new System.Drawing.Size(331, 21);
            this.cB_odabir.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 648);
            this.Controls.Add(this.cB_odabir);
            this.Controls.Add(this.lb_poruke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_port_end);
            this.Controls.Add(this.tB_port_start);
            this.Controls.Add(this.tB_ip_start);
            this.Controls.Add(this.lb_nmap_ispis);
            this.Controls.Add(this.bt_nmap_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button bt_nmap_start;
        private System.Windows.Forms.ListBox lb_nmap_ispis;
        private System.Windows.Forms.TextBox tB_ip_start;
        private System.Windows.Forms.TextBox tB_port_start;
        private System.Windows.Forms.TextBox tB_port_end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_poruke;
        private System.Windows.Forms.ComboBox cB_odabir;
    }
}

