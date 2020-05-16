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

namespace MegaDesk_Wood
{
    public partial class SearchQuotes : Form
    {
        public List<string> listMaterial = new List<string>();
        public SearchQuotes()
        {
            InitializeComponent();

            //enum and combobox
            listMaterial.Insert(0, "Select");
            foreach (var name in Enum.GetNames(typeof(DeskMaterial)))
            {
                listMaterial.Add(name);
                cmbSearchMaterial.Items.Add(name);
            }
        }

 

        private void cmbSearchMaterial_SelectedIndexChanged(object sender, EventArgs e)
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

                    if (col[2] == cmbSearchMaterial.Text)
                    {
                        table.Rows.Add(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7]);
                    }
                }
                dataGridSearchQuotes.DataSource = table;
                jsonFile.Close();
            }
            catch (Exception ea)
            {
                MessageBox.Show("Error: " + ea.Message);
                Close();
            }
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            Hide();
        }
    }
}
