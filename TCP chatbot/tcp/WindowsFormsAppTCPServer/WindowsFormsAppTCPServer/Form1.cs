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

namespace WindowsFormsAppTCPServer
{
    public partial class Form1 : Form
    {
        TcpListener server;
        Thread serverThread;
        bool isServerRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bTStartServer_Click(object sender, EventArgs e)
        {
            if (!isServerRunning)
            {
                serverThread = new Thread(StartServer);
                serverThread.IsBackground = true;
                serverThread.Start();
                isServerRunning = true;

                lblStatus.Text = "Running";
                lblStatus.ForeColor = Color.LimeGreen;
                bTStartServer.Enabled = false;
            }
        }
        private void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Parse("127.0.0.1"), 11000);
                server.Start();
                Invoke(new Action(() => listBox1.Items.Add("startani server ")));

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Invoke(new Action(() => listBox1.Items.Add(message)));

                   
                   // byte[] response = Encoding.UTF8.GetBytes("dobivena poruka");
                  // stream.Write(response, 0, response.Length);

                    client.Close();
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => MessageBox.Show(ex.Message)));
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_saljiPoruku_Click(object sender, EventArgs e)
        {
            Thread clientThread = new Thread(SendNumbers);
            clientThread.IsBackground = true;
            clientThread.Start();
        }
        private void SendNumbers()
        {
            try
            {
                int startNumber = 0;


                Invoke(new Action(() =>
                {
                    if (!int.TryParse(tB_poruka.Text, out startNumber))
                    {
                        startNumber = 1;
                    }
                }));

                
                    using (TcpClient client = new TcpClient())
                    {
                        client.Connect("127.0.0.1", 22000);
                        NetworkStream stream = client.GetStream();

                        string message = tB_poruka.Text;
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        stream.Write(data, 0, data.Length);

                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        // Invoke(new Action(() => listBox1.Items.Add($"Poslano {i}, Server: {response}")));

                        stream.Close();
                        client.Close();
                    }

                   // Thread.Sleep(500);
                
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => MessageBox.Show(ex.Message)));
            }
        }
    }
}
