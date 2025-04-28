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

namespace WindowsFormsAppTCPKlijent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bTSend_Click(object sender, EventArgs e)
        {
            Thread clientThread = new Thread(SendNumbers);
            clientThread.IsBackground = true;
            clientThread.Start();
        }
        private void SendNumbers()
        {
            try
            {
                int startNumber=0;


                Invoke(new Action(() =>
                {
                    if (!int.TryParse(tB_poruka.Text, out startNumber))
                    {
                        startNumber = 1; 
                    }
                }));

                for (int i = startNumber; i <= startNumber + 10; i++)
                {
                    using (TcpClient client = new TcpClient())
                    {
                        client.Connect("127.0.0.1", 11000);
                        NetworkStream stream = client.GetStream();

                        string message = i.ToString();
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        stream.Write(data, 0, data.Length);

                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        Invoke(new Action(() => listBox1.Items.Add($"Poslano {i}, Server: {response}")));

                        stream.Close();
                        client.Close();
                    }

                    Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => MessageBox.Show(ex.Message)));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
