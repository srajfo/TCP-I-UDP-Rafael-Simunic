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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
           
        private void bt_nmap_start_Click(object sender, EventArgs e)
        {
            int portStart = int.Parse(tB_port_start.Text);
            int portEnd = int.Parse(tB_port_end.Text);
            string IPStart = tB_IP_start.Text;
            string IPEnd = tB_IP_end.Text;
            
            bt_nmap_start.Enabled = false;
            
            lB_nmap_ispis.Items.Clear();
            
            Task.Run(() => ScanPorts(IPStart, IPEnd, portStart, portEnd));

            bt_nmap_start.Enabled = true;

        }
        private List<string> GetIPRange(string startIP, string endIP)
        {
            List<string> ipList = new List<string>();

            try
            {
                var startAddr = IPAddress.Parse(startIP);
                var endAddr = IPAddress.Parse(endIP);

                byte[] startBytes = startAddr.GetAddressBytes();
                byte[] endBytes = endAddr.GetAddressBytes();

                if (startBytes.Take(3).SequenceEqual(endBytes.Take(3)))
                {
                    for (int i = startBytes[3]; i <= endBytes[3]; i++)
                    {
                        byte[] newIP = new byte[4];
                        Array.Copy(startBytes, newIP, 3);
                        newIP[3] = (byte)i;
                        ipList.Add(new IPAddress(newIP).ToString());
                    }
                }
                else
                {
                    Log("Invalid IP range. The IPs must be in the same network.");
                }
            }
            catch
            {
                Log("Invalid IP format.");
            }

            return ipList;
        }
        private void ScanPorts(string startIP, string endIP, int startPort, int endPort)
        {
            var ipRange = GetIPRange(startIP, endIP);

            foreach (var ip in ipRange)
            {
                for (int port = startPort; port <= endPort; port++)
                {
                    TcpClient tcpClient = new TcpClient();
                    try
                    {
                        var result=tcpClient.BeginConnect(ip, port,null,null);
                        bool succes=result.AsyncWaitHandle.WaitOne(300);
                        if(succes)
                        Log2($"Port {port} on IP {ip} is OPEN.");
                        else
                            Log2($"Port {port} on IP {ip} is CLOSED.");
                        //lB_nmap_ispis.Items.Add($"Port {port} on IP {ip} is OPEN.");
                    }
                    catch(Exception ex)
                    {
                        //Log2($"Port {port} on IP {ip} is CLOSED.");
                    }
                    finally
                    {
                        tcpClient.Close();
                    }
                }
            }
        }
        private void Log2(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Log2(message)));
                return;
            }
            lB_nmap_ispis.Items.Add(message);
        }
    }
}

