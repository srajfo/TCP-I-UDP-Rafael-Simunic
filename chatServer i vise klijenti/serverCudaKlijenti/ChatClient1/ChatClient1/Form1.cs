using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient1
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
        }

        private void bT_send_Click(object sender, EventArgs e)
        {
            if (stream == null) return;

            string message = tB_poruka.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                Log("poslana poruka:" + message);
                tB_poruka.Clear();
            }
        }

        private void bT_connect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", int.Parse(tB_port.Text));
                stream = client.GetStream();

                Thread t = new Thread(ListenForMessages);
                t.IsBackground = true;
                t.Start();

                Log("spojeno na server.");
            }
            catch (Exception ex)
            {
                Log("spajanje failed: " + ex.Message);
            }
        }
        private void ListenForMessages()
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                try
                {
                    int read = stream.Read(buffer, 0, buffer.Length);
                    if (read == 0) break;

                    string msg = Encoding.UTF8.GetString(buffer, 0, read);
                    Log("dobiveno: " + msg);
                }
                catch
                {
                    break;
                }
            }

            Log("odspojeno s servera");
        }
        private void Log(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Log(message)));
                return;
            }
            lB_poruke.Items.Add(message);
        }
    }
}
