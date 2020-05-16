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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(Desk desk, DeskQuote quote)

        {

            InitializeComponent();

            lblName.Text = "Name: " + quote.CustomerName;

            lblWidth.Text = "Desk Width: " + desk.Width.ToString() + " inches";

            lblDepth.Text = "Desk Depth: " + desk.Depth.ToString() + " inches";

            lblDrawerCount.Text = "Number of Drawers: " + desk.Drawers.ToString();

            lblSurfaceMaterial.Text = "Surface Material: " + desk.Material.ToString();
            //=====TT??? The desk.Rush is not being set anywhere
            lbldeliveryTime.Text = "Deliver in: " + desk.Rush.ToString() + " Days";
            DateTime quoteDate = quote.QuoteDate;
            lblDeliveryDate.Text = "Delivery Date: "; //+ DateTime.quoteDate.AddDays(desk.Rush).ToString("dd MMMM yyyy");

            lblBaseCost.Text = "Base Cost: $" + DeskQuote.BASEPRICE;


            lblAreaCost.Text = "Additional Cost of Size: $" + quote.SurfaceAreaCost.ToString();

            lblMaterialCost.Text = "Cost for Surface Material: $" + quote.MaterialCost.ToString();

            lblRushCost.Text = "Cost for Rush Delivery: $" + quote.RushCost.ToString();

            lblDrawerCost.Text = "Cost for Drawers: $" + quote.DrawerCost.ToString();

            lblTotalCost.Text = "Total Cost: $" + quote.QuoteTotal.ToString();

            lblQuoteDate.Text = "Order Date: " + quote.QuoteDate.ToString("dd MMMM yyyy");



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }
    }
}
