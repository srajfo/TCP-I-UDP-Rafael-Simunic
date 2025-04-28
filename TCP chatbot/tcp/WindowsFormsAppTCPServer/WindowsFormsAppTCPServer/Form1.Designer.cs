namespace WindowsFormsAppTCPServer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bTStartServer = new System.Windows.Forms.Button();
            this.bt_saljiPoruku = new System.Windows.Forms.Button();
            this.tB_poruka = new System.Windows.Forms.TextBox();
            this.lB_poruke = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(149, 284);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 212);
            this.listBox1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(319, 257);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "stoped";
            // 
            // bTStartServer
            // 
            this.bTStartServer.Location = new System.Drawing.Point(275, 212);
            this.bTStartServer.Name = "bTStartServer";
            this.bTStartServer.Size = new System.Drawing.Size(120, 27);
            this.bTStartServer.TabIndex = 2;
            this.bTStartServer.Text = "start server";
            this.bTStartServer.UseVisualStyleBackColor = true;
            this.bTStartServer.Click += new System.EventHandler(this.bTStartServer_Click);
            // 
            // bt_saljiPoruku
            // 
            this.bt_saljiPoruku.Location = new System.Drawing.Point(886, 167);
            this.bt_saljiPoruku.Name = "bt_saljiPoruku";
            this.bt_saljiPoruku.Size = new System.Drawing.Size(122, 72);
            this.bt_saljiPoruku.TabIndex = 3;
            this.bt_saljiPoruku.Text = "salji";
            this.bt_saljiPoruku.UseVisualStyleBackColor = true;
            this.bt_saljiPoruku.Click += new System.EventHandler(this.bt_saljiPoruku_Click);
            // 
            // tB_poruka
            // 
            this.tB_poruka.Location = new System.Drawing.Point(1028, 219);
            this.tB_poruka.Name = "tB_poruka";
            this.tB_poruka.Size = new System.Drawing.Size(163, 20);
            this.tB_poruka.TabIndex = 4;
            // 
            // lB_poruke
            // 
            this.lB_poruke.FormattingEnabled = true;
            this.lB_poruke.Location = new System.Drawing.Point(886, 284);
            this.lB_poruke.Name = "lB_poruke";
            this.lB_poruke.Size = new System.Drawing.Size(305, 225);
            this.lB_poruke.TabIndex = 5;
            this.lB_poruke.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(595, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "drugi korisnik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lB_poruke);
            this.Controls.Add(this.tB_poruka);
            this.Controls.Add(this.bt_saljiPoruku);
            this.Controls.Add(this.bTStartServer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button bTStartServer;
        private System.Windows.Forms.Button bt_saljiPoruku;
        private System.Windows.Forms.TextBox tB_poruka;
        private System.Windows.Forms.ListBox lB_poruke;
        private System.Windows.Forms.Label label1;
    }
}

