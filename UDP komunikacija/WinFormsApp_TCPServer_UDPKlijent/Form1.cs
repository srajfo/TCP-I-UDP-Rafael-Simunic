using System.Net.Sockets;
using System.Net;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Text;

namespace WinFormsApp_TCPServer_UDPKlijent
{
    public partial class Form1 : Form
    {
        bool serverIsRunning = false;
        int UdpListenPort;
        string localIP;

        List<String> listOfClients = new List<string>();
        List<String> clientIds = new List<string>();
        int rollingClientId = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Not running";
            label3.ForeColor = Color.Red;
            try
            {
                UdpListenPort = 11000;
            }
            catch(Exception)
            {

            }


            localIP = "127.0.0.1";
            tB_ip_UDP.Text = localIP;
        }

        private void bt_send_UDP_Click(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();

            serverIsRunning = true;
            label3.Text = "Running";
            label3.ForeColor = Color.Green;
            bt_send_UDP.Enabled = false;
            tB_port_UDP.Enabled = false;
            tB_ip_UDP.Enabled = false;
            listBox1.Items.Add("Server started on " + localIP + ", using port " + UdpListenPort);
        }
        public void serverThread()
        {
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), UdpListenPort);
            UdpClient udpServer = new UdpClient(localEndPoint);
            while (true)
            {
                var remoteEP = new IPEndPoint(IPAddress.Any, UdpListenPort);
                try
                {
                    var data = udpServer.Receive(ref remoteEP);  // Receive data from client
                    string clientIP = remoteEP.Address.ToString();
                    string stringReceived = Encoding.UTF8.GetString(data);

                    // Add message to ListBox on the UI thread
                    Invoke((MethodInvoker)(() => listBox1.Items.Add("Received data from: " + clientIP)));
                    Invoke((MethodInvoker)(() => listBox1.Items.Add("Received: " + stringReceived)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error receiving data: " + ex.Message);
                }
            }
        }
    }
    }
    

