using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HtmlAgilityPack;
using System.Net.Http;

namespace HTTP_pristup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = "https://tsck.eu/hacktracker/";
            listBox1.Items.Clear();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string html = await response.Content.ReadAsStringAsync();
                        var doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(html);

                        var table = doc.DocumentNode.SelectSingleNode("//table");
                        if (table != null)
                        {
                            
                            var rows = table.SelectNodes(".//tr");
                            if (rows != null && rows.Count>0)
                            {
                                for(int i = 0;i<2;i++)
                                { 
                                var firstRow = rows[i];
                                var cells = firstRow.SelectNodes(".//td|.//th");
                                if(cells !=null)
                                {
                                    string line = "";
                                    foreach (var cell in cells)
                                    {
                                        line += cell.InnerText.Trim()+" | ";
                                    }
                                    listBox1.Items.Add(line.TrimEnd(' ', '|'));
                                }
                                }
                            }
                            else
                            {
                                listBox1.Items.Add("Nema redova u tablici.");
                            }
                        }
                        else
                        {
                            listBox1.Items.Add("Tablica nije pronađena.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Neuspješno preuzimanje stranice.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
