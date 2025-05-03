using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        List<TcpClient> clients = new List<TcpClient>();
        List<TcpListener> listeners = new List<TcpListener>();
        bool isRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bT_start_Click(object sender, EventArgs e)
        {
            if (isRunning) return;

            string[] portStrings = tB_ports.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string portStr in portStrings)
            {
                if (int.TryParse(portStr, out int port))
                {
                    TcpListener listener = new TcpListener(IPAddress.Loopback, port);
                    listener.Start();
                    listeners.Add(listener);

                    Thread t = new Thread(() => AcceptClients(listener));
                    t.IsBackground = true;
                    t.Start();

                    Log($"listening na portu: {port}");
                }
                else
                {
                    Log($"nevaljani port: {portStr}");
                }
            }

            isRunning = true;
            bT_start.Enabled = false;
            bT_start.Text = "runa";
        }
        private void AcceptClients(TcpListener listener)
        {
            while (true)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    lock (clients)
                    {
                        clients.Add(client);
                    }
                    Thread t = new Thread(() => HandleClient(client));
                    t.IsBackground = true;
                    t.Start();

                    Log("klijent spojen");
                }
                catch
                {
                    break;
                }
            }
        }
        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            try
            {
                while (true)
                {
                    int read = stream.Read(buffer, 0, buffer.Length);
                    if (read == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, read);
                    Log("dobivena poruka: " + message);
                    Broadcast(message, client);
                }
            }
            catch { }

            lock (clients)
            {
                clients.Remove(client);
            }

            client.Close();
            Log("Klijent odspojen");
        }

        private void Broadcast(string message, TcpClient sender)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            lock (clients)
            {
                foreach (var client in clients)
                {
                    if (client != sender)
                    {
                        try
                        {
                            client.GetStream().Write(data, 0, data.Length);
                        }
                        catch { }
                    }
                }
            }
        }

        private void Log(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Log(message)));
                return;
            }
            lB_logs.Items.Add(message);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

