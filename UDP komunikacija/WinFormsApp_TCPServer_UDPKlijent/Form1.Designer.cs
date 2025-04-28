namespace WinFormsApp_TCPServer_UDPKlijent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            bt_send_UDP = new Button();
            tB_ip_UDP = new TextBox();
            tB_port_UDP = new TextBox();
            listBox1 = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(120, 82);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // label2
            // 
            label2.Location = new Point(120, 121);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 1;
            label2.Text = "PORT:";
            // 
            // bt_send_UDP
            // 
            bt_send_UDP.Location = new Point(130, 184);
            bt_send_UDP.Name = "bt_send_UDP";
            bt_send_UDP.Size = new Size(75, 23);
            bt_send_UDP.TabIndex = 2;
            bt_send_UDP.Text = "salji";
            bt_send_UDP.UseVisualStyleBackColor = true;
            bt_send_UDP.Click += bt_send_UDP_Click;
            // 
            // tB_ip_UDP
            // 
            tB_ip_UDP.Location = new Point(197, 79);
            tB_ip_UDP.Name = "tB_ip_UDP";
            tB_ip_UDP.Size = new Size(100, 23);
            tB_ip_UDP.TabIndex = 3;
            // 
            // tB_port_UDP
            // 
            tB_port_UDP.Location = new Point(197, 121);
            tB_port_UDP.Name = "tB_port_UDP";
            tB_port_UDP.Size = new Size(100, 23);
            tB_port_UDP.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(197, 243);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(603, 184);
            listBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 184);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 654);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(tB_port_UDP);
            Controls.Add(tB_ip_UDP);
            Controls.Add(bt_send_UDP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bt_send_UDP;
        private TextBox tB_ip_UDP;
        private TextBox tB_port_UDP;
        private ListBox listBox1;
        private Label label3;
    }
}
