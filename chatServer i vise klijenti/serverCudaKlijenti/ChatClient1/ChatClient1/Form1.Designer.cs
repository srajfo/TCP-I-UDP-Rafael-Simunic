namespace ChatClient1
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
            this.tB_poruka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bT_send = new System.Windows.Forms.Button();
            this.lB_poruke = new System.Windows.Forms.ListBox();
            this.tB_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bT_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_poruka
            // 
            this.tB_poruka.Location = new System.Drawing.Point(162, 84);
            this.tB_poruka.Name = "tB_poruka";
            this.tB_poruka.Size = new System.Drawing.Size(261, 20);
            this.tB_poruka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Poruka";
            // 
            // bT_send
            // 
            this.bT_send.Location = new System.Drawing.Point(162, 110);
            this.bT_send.Name = "bT_send";
            this.bT_send.Size = new System.Drawing.Size(261, 23);
            this.bT_send.TabIndex = 2;
            this.bT_send.Text = "salji";
            this.bT_send.UseVisualStyleBackColor = true;
            this.bT_send.Click += new System.EventHandler(this.bT_send_Click);
            // 
            // lB_poruke
            // 
            this.lB_poruke.FormattingEnabled = true;
            this.lB_poruke.Location = new System.Drawing.Point(162, 326);
            this.lB_poruke.Name = "lB_poruke";
            this.lB_poruke.Size = new System.Drawing.Size(735, 225);
            this.lB_poruke.TabIndex = 3;
            // 
            // tB_port
            // 
            this.tB_port.Location = new System.Drawing.Point(574, 84);
            this.tB_port.Name = "tB_port";
            this.tB_port.Size = new System.Drawing.Size(261, 20);
            this.tB_port.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // bT_connect
            // 
            this.bT_connect.Location = new System.Drawing.Point(574, 110);
            this.bT_connect.Name = "bT_connect";
            this.bT_connect.Size = new System.Drawing.Size(261, 23);
            this.bT_connect.TabIndex = 6;
            this.bT_connect.Text = "connect";
            this.bT_connect.UseVisualStyleBackColor = true;
            this.bT_connect.Click += new System.EventHandler(this.bT_connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 629);
            this.Controls.Add(this.bT_connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_port);
            this.Controls.Add(this.lB_poruke);
            this.Controls.Add(this.bT_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_poruka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_poruka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bT_send;
        private System.Windows.Forms.ListBox lB_poruke;
        private System.Windows.Forms.TextBox tB_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bT_connect;
    }
}

