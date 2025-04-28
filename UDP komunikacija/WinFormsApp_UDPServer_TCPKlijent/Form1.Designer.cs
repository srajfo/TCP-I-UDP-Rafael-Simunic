namespace WinFormsApp_UDPServer_TCPKlijent
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
            components = new System.ComponentModel.Container();
            Label label1;
            Label label3;
            label2 = new Label();
            tB_IP_UDP = new TextBox();
            tB_PORT_UDP = new TextBox();
            bt_send_udp = new Button();
            label4 = new Label();
            tB_poruka_UDP = new TextBox();
            lB_poruke_UDP = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 55);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 9);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "UDP KLIJENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 118);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Port:";
            // 
            // tB_IP_UDP
            // 
            tB_IP_UDP.Location = new Point(162, 52);
            tB_IP_UDP.Name = "tB_IP_UDP";
            tB_IP_UDP.Size = new Size(100, 23);
            tB_IP_UDP.TabIndex = 2;
            // 
            // tB_PORT_UDP
            // 
            tB_PORT_UDP.Location = new Point(162, 118);
            tB_PORT_UDP.Name = "tB_PORT_UDP";
            tB_PORT_UDP.Size = new Size(100, 23);
            tB_PORT_UDP.TabIndex = 3;
            // 
            // bt_send_udp
            // 
            bt_send_udp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_send_udp.Location = new Point(162, 239);
            bt_send_udp.Name = "bt_send_udp";
            bt_send_udp.Size = new Size(101, 23);
            bt_send_udp.TabIndex = 5;
            bt_send_udp.Text = "send";
            bt_send_udp.UseVisualStyleBackColor = true;
            bt_send_udp.Click += bt_send_udp_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 188);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Broj:";
            // 
            // tB_poruka_UDP
            // 
            tB_poruka_UDP.Location = new Point(162, 188);
            tB_poruka_UDP.Name = "tB_poruka_UDP";
            tB_poruka_UDP.Size = new Size(100, 23);
            tB_poruka_UDP.TabIndex = 7;
            // 
            // lB_poruke_UDP
            // 
            lB_poruke_UDP.FormattingEnabled = true;
            lB_poruke_UDP.ItemHeight = 15;
            lB_poruke_UDP.Location = new Point(65, 326);
            lB_poruke_UDP.Name = "lB_poruke_UDP";
            lB_poruke_UDP.Size = new Size(1177, 214);
            lB_poruke_UDP.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 627);
            Controls.Add(lB_poruke_UDP);
            Controls.Add(tB_poruka_UDP);
            Controls.Add(label4);
            Controls.Add(bt_send_udp);
            Controls.Add(label3);
            Controls.Add(tB_PORT_UDP);
            Controls.Add(tB_IP_UDP);
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
        private TextBox tB_IP_UDP;
        private TextBox tB_PORT_UDP;
        private Button bt_send_udp;
        private Label label4;
        private TextBox tB_poruka_UDP;
        private ListBox lB_poruke_UDP;
        private System.Windows.Forms.Timer timer1;
    }
}
