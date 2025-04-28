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
            this.bt_serverStart = new System.Windows.Forms.Button();
            this.lb_startServer = new System.Windows.Forms.Label();
            this.lB_serverInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.listBox1.Location = new System.Drawing.Point(106, 209);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 342);
            this.listBox1.TabIndex = 1;
            // 
            // tB_poruka
            // 
            this.tB_poruka.Location = new System.Drawing.Point(270, 168);
            this.tB_poruka.Name = "tB_poruka";
            this.tB_poruka.Size = new System.Drawing.Size(82, 20);
            this.tB_poruka.TabIndex = 2;
            this.tB_poruka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_serverStart
            // 
            this.bt_serverStart.Location = new System.Drawing.Point(1016, 31);
            this.bt_serverStart.Name = "bt_serverStart";
            this.bt_serverStart.Size = new System.Drawing.Size(107, 34);
            this.bt_serverStart.TabIndex = 3;
            this.bt_serverStart.Text = "start server";
            this.bt_serverStart.UseVisualStyleBackColor = true;
            this.bt_serverStart.Click += new System.EventHandler(this.bt_serverStart_Click);
            // 
            // lb_startServer
            // 
            this.lb_startServer.AutoSize = true;
            this.lb_startServer.Location = new System.Drawing.Point(1045, 78);
            this.lb_startServer.Name = "lb_startServer";
            this.lb_startServer.Size = new System.Drawing.Size(43, 13);
            this.lb_startServer.TabIndex = 4;
            this.lb_startServer.Text = "ne runa";
            // 
            // lB_serverInfo
            // 
            this.lB_serverInfo.FormattingEnabled = true;
            this.lB_serverInfo.Location = new System.Drawing.Point(946, 138);
            this.lB_serverInfo.Name = "lB_serverInfo";
            this.lB_serverInfo.Size = new System.Drawing.Size(336, 420);
            this.lB_serverInfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(585, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "prvi korisnik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lB_serverInfo);
            this.Controls.Add(this.lb_startServer);
            this.Controls.Add(this.bt_serverStart);
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
        private System.Windows.Forms.Button bt_serverStart;
        private System.Windows.Forms.Label lb_startServer;
        private System.Windows.Forms.ListBox lB_serverInfo;
        private System.Windows.Forms.Label label1;
    }
}

