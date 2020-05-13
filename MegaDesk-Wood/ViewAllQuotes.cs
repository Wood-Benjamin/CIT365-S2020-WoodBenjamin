using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Customer Name",typeof(string));
            table.Columns.Add("Quote Date", typeof(DateTime));
            table.Columns.Add("Desk Material", typeof(string));
            table.Columns.Add("Width", typeof(int));
            table.Columns.Add("Depth", typeof(int));
            table.Columns.Add("Drawers", typeof(int));
            table.Columns.Add("Rush Order", typeof(string));
            table.Columns.Add("Sub Total", typeof(int));

            table.Rows.Add("Ben Wood", "13 May 2020", "Laminate", 30, 30, 5, "5 Days", 590);

            dataGridViewAllQuotes.DataSource = table;
        }
    }
}
