using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Wood
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
/*
            DataTable table = new DataTable();
            table.Columns.Add("Customer Name", typeof(string));
            table.Columns.Add("Quote Date", typeof(DateTime));
            table.Columns.Add("Desk Material", typeof(string));
            table.Columns.Add("Width", typeof(int));
            table.Columns.Add("Depth", typeof(int));
            table.Columns.Add("Drawers", typeof(int));
            table.Columns.Add("Rush Order", typeof(string));
            table.Columns.Add("Sub Total", typeof(int));

            try
            {
                StreamReader jsonFile = new StreamReader(@"../../docs/quotes.json");
                while (!jsonFile.EndOfStream)
                {
                    string[] col = jsonFile.ReadLine().Split(',');
                    table.Rows.Add(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7]);
                }
                dataGridViewAllQuotes.DataSource = table;
                jsonFile.Close();
            }
            catch (Exception ea)
            {
                MessageBox.Show("Error: " + ea.Message);
                Close();
            }


*/





            /* DataTable table = new DataTable();

             table.Columns.Add("Customer Name");
             table.Columns.Add("Quote Date");
             table.Columns.Add("Desk Material");
             table.Columns.Add("Width");
             table.Columns.Add("Depth");
             table.Columns.Add("Drawers");
             table.Columns.Add("Rush Order");
             table.Columns.Add("Sub Total");

             try
             {
                 List<NewQuote> newQuote = new List<NewQuote>();
                 using (StreamReader jsonFile = File.OpenText(@"../../docs/quotes.json"))
                 {
                     JsonSerializer serializer = new JsonSerializer();
                     newQuote = serializer.Deserialize(jsonFile, typeof(NewQuote));
                     while (!jsonFile.EndOfStream)
                     {

                         //col = JsonConvert.DeserializeObject(jsonFile.ReadLine());
                         //newQuote.AddRange(JsonConvert.DeserializeObject<List<NewQuote>>(jsonFile.ReadToEnd()));
                     }

                      //   string[] col = jsonFile.ReadLine().Split(',').ToArray();
                       //  table.Rows.Add(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7]);
                    // }
                     dataGridViewAllQuotes.DataSource = jsonFile.ReadLine().Split(',');
                     jsonFile.Close();
                 }
             }
             catch (Exception ea)
             {
                 MessageBox.Show("Error: " + ea.Message);
                 Close();
             }
             */
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }
    }
}
