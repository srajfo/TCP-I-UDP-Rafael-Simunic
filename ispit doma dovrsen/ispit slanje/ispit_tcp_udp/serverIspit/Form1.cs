using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace serverIspit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String primaj = "x";
        String salji = "y";
        private  void bt_nmap_start_Click(object sender, EventArgs e)
        {
            int portStart = int.Parse(tB_port_start.Text);
            int portEnd = int.Parse(tB_port_end.Text);
            string IP = tB_ip_start.Text;

            bt_nmap_start.Enabled = false;

            lb_nmap_ispis.Items.Clear();
            lb_poruke.Items.Clear();

            if(cB_odabir.Text=="TCP")
                Task.Run(() => ScanPortsTCP(IP, portStart, portEnd));
            else if(cB_odabir.Text=="UDP")
                Task.Run(() => ScanPortsUDP(IP, portStart, portEnd));
            bt_nmap_start.Enabled = true;

        }

        private void ScanPortsTCP(string ipAddress, int startPort, int endPort)
        {
            try
            {
                var ip = IPAddress.Parse(ipAddress); 

                for (int port = startPort; port <= endPort; port++)
                {
                    TcpClient tcpClient = new TcpClient();
                    try
                    {
                        var result = tcpClient.BeginConnect(ipAddress, port, null, null);
                        bool success = result.AsyncWaitHandle.WaitOne(300); 

                        if (success)
                        { 
                            Log2($"Port {port} on IP {ipAddress} is OPEN.");
                            saljiyTCP(ipAddress, port);
                        }
                        else
                            Log2($"Port {port} on IP {ipAddress} is CLOSED.");
                    }
                    catch (Exception)
                    {
                        Log2($"Port {port} on IP {ipAddress} is CLOSED.");
                    }
                    finally
                    {
                        tcpClient.Close();
                    }
                }
            }
            catch
            {
                Log2("Invalid IP format.");
            }
        }
        private void saljiyTCP(string ipAddress, int port)
        {
            try
            {
                using (TcpClient client = new TcpClient(ipAddress, port))
                {
                    NetworkStream stream = client.GetStream();
                    byte[] dataToSend = Encoding.ASCII.GetBytes("y");
                    stream.Write(dataToSend, 0, dataToSend.Length);
                    Log3($"poslan 'y' na port: {port}");
                    byte[] receivedData = new byte[256];
                    int bytesRead = stream.Read(receivedData, 0, receivedData.Length);
                    string response = Encoding.ASCII.GetString(receivedData, 0, bytesRead).Trim();

                    if (response == "x")
                    {
                        Log3($"'x' poslan nazad");
                    }
                    else
                    {
                        Log3($"'x' nije poslan nazad");
                    }
                }
            }
            catch (Exception ex)
            {
                Log3($"error na portu {port}: {ex.Message}");
            }
        }
        private void ScanPortsUDP(string ipAddress, int startPort, int endPort)
        {
            for (int port = startPort; port <= endPort; port++)
            {
                try
                {
                    using (UdpClient sender = new UdpClient())
                    using (UdpClient receiver = new UdpClient(port + 1))
                    {
                        receiver.Client.ReceiveTimeout = 2000;

                        IPEndPoint target = new IPEndPoint(IPAddress.Parse(ipAddress), port);
                        byte[] data = Encoding.ASCII.GetBytes(salji);
                        sender.Send(data, data.Length, target);

                        IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                        byte[] response = receiver.Receive(ref remoteEP);
                        string responseStr = Encoding.ASCII.GetString(response);

                        if (responseStr.Trim() == primaj)
                        {
                            Invoke(new Action(() =>{Log3($"na {ipAddress} na port: {port} poslan {salji} i uzvracen {primaj}");}));
                        }
                        else
                        {
                            Invoke(new Action(() => { Log2($"zatvoren port:{port} na {ipAddress}"); }));
                        }
                    }
                }
                catch  
                {
                    
                }
                //Thread.Sleep(400);
            }
                        
        }


        private void saljiyUDP(string ipAddress, int port)
        {
            try
            {
                using (UdpClient udpClient = new UdpClient(0))
                {
                    udpClient.Connect(ipAddress, port);
                    byte[] dataToSend = Encoding.ASCII.GetBytes("y");
                    udpClient.Send(dataToSend, dataToSend.Length);
                    Log3($"poslan 'y' na port: {port}");

                    udpClient.Client.ReceiveTimeout = 1000;

                    IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                    var receivedData = udpClient.Receive(ref endPoint);
                    string response = Encoding.ASCII.GetString(receivedData).Trim();

                    if (response == "x")
                    {
                        Log3($"'x' poslan nazad");
                    }
                    else
                    {
                        Log3($"'x' nije poslan nazad");
                    }
                }
            }
            catch (SocketException)
            {
                Log3($"Nema odgovora na portu {port}");
            }
            catch (Exception ex)
            {
                Log3($"Greška na portu {port}: {ex.Message}");
            }
        }

        private void Log2(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Log2(message)));
                return;
            }
            lb_nmap_ispis.Items.Add(message);
        }
        private void Log3(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Log3(message)));
                return;
            }
            lb_poruke.Items.Add(message);
        }
    }
}
