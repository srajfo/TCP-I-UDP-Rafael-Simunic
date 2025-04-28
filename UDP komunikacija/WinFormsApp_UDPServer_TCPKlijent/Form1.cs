using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp_UDPServer_TCPKlijent
{
    public partial class Form1 : Form
    {
        string udpServerIP;
        int udpServerPort;
        string Poruka;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void bt_send_udp_Click(object sender, EventArgs e)
        {
            udpServerIP = tB_IP_UDP.Text;
            udpServerPort = 11000;  // Use port 11000
            int count = 1; // Start with the number 1

            var udpClient = new UdpClient();
            udpClient.Client.SendTimeout = 2000;
            udpClient.Client.ReceiveTimeout = 2000;

            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(udpServerIP), udpServerPort);

            try
            {
                udpClient.Connect(ep);

                // Loop to send numbers
                for (int i = 0; i < 10; i++)  // Sends numbers 1 to 10 (you can adjust the range)
                {
                    string message = count.ToString();
                    Byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                    udpClient.Send(sendBytes, sendBytes.Length);

                    lB_poruke_UDP.Items.Add("Sent: " + message); // Display sent message

                    // Increment the number
                    count++;

                    await Task.Delay(1000);  // Wait for 1 second
                }
            }
            catch (SocketException ex)
            {
                lB_poruke_UDP.Items.Add("Error: " + ex.Message);
            }
            finally
            {
                udpClient.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
