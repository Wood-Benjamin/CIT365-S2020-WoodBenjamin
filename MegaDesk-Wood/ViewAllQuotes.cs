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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }

        private void dataGridViewAllQuotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpViewAllQuotes_Enter(object sender, EventArgs e)
        {

        }
    }
}
