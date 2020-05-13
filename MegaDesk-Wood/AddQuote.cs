﻿using MegaDesk_Wood;
using System;
using System.CodeDom;
using System.Collections;
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
    public partial class AddQuote : Form
    {
        DeskQuote quote = new DeskQuote();
        Desk desk = new Desk();
        public List<string> listMaterial = new List<string>();
        int rushOrder;
        public AddQuote()
        {
            InitializeComponent();
            CurrentDate();
            txtCustName.Select();

            //enum and combobox
            listMaterial.Insert(0, "Select");
            foreach (var name in Enum.GetNames(typeof(DeskMaterial)))
            {
                listMaterial.Add(name);
                cmbDeskMaterial.Items.Add(name);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        public void CurrentDate()
        {
            // set and display current date
            DateTime now = DateTime.Now;
            lblQuoteDate.Text = now.ToString("dd MMMM yyyy");
        }

        private void cmbDeskMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewDesk();
            CalMaterialCost();
            QuoteRefresh();
        }

        private void numWidth_TextChanged(object sender, EventArgs e)
        {
            CalSurfaceAreaCost();
            NewDesk();
            QuoteRefresh();
        }

        private void numDepth_TextChanged(object sender, EventArgs e)
        {
            CalSurfaceAreaCost();
            NewDesk();
            QuoteRefresh();
        }

        private void numDrawers_TextChanged(object sender, EventArgs e)
        {
            CalDrawerCost();
            NewDesk();
            QuoteRefresh();
        }
        public Desk NewDesk()
        {
            int.TryParse(numWidth.Text, out int width);
            int.TryParse(numDepth.Text, out int depth);
            int.TryParse(numDrawers.Text, out int drawers);

            desk.Width = width;
            desk.Depth = depth;
            desk.Drawers = drawers;
            desk.Rush = rushOrder;
            desk.Material = cmbDeskMaterial.Text;

            return desk;
        }
        public DeskQuote QuoteRefresh()
        {
            quote.QuoteDate = DateTime.Parse(lblQuoteDate.Text);
            quote.CustomerName = txtCustName.Text;
            quote.desk = desk;
            quote.MaterialCost = CalMaterialCost();
            quote.SurfaceAreaCost = CalSurfaceAreaCost();
            quote.DrawerCost = CalDrawerCost();
            quote.RushCost = CalRushOrderCost();
            quote.QuoteTotal = CalQuoteTotal();

            label31.Text = ($"${DeskQuote.BASEPRICE.ToString()}");
            label32.Text = ($"${CalSurfaceAreaCost().ToString()}");
            label33.Text = ($"${CalMaterialCost().ToString()}");
            label34.Text = ($"${CalDrawerCost().ToString()}");
            label35.Text = ($"${CalRushOrderCost().ToString()}");
            label36.Text = ($"${CalQuoteTotal().ToString()}");
            lblSurfaceArea.Text = desk.SurfaceArea.ToString();
            return quote;
        }
        public int CalMaterialCost()
        {
            switch (cmbDeskMaterial.Text.ToString().Trim())
            {
                case "Laminate":
                    return 100;
                case "Oak":
                    return 200;
                case "Pine":
                    return 50;
                case "Rosewood":
                    return 300;
                case "Veneer":
                    return 125;
                default:
                    return 0;
            }
        }
        public int CalSurfaceAreaCost()
        {
            if (desk.SurfaceArea > DeskQuote.BASESURFACE)
            {
                return (desk.SurfaceArea - DeskQuote.BASESURFACE) * DeskQuote.OVERSURFACE;
            }
            else
            {
                return 0;
            }
        }
        public int CalDrawerCost()
        {
            if (desk.Drawers > 0)
            {
                return (desk.Drawers * 50);
            }
            else
            {
                return 0;
            }
        }
        public int CalRushOrderCost()
        {
            if (rushOrder == 0)
            {
                return 0;
            }
            else if (rushOrder == 3)
            {
                if (desk.SurfaceArea < DeskQuote.BASESURFACE)
                {
                    return 60;
                }
                else if (desk.SurfaceArea >= DeskQuote.BASESURFACE && desk.SurfaceArea <= DeskQuote.LARGESURFACE)
                {
                    return 70;
                }
                else
                {
                    return 80;
                }
            }
            else if (rushOrder == 5)
            {
                if (desk.SurfaceArea < DeskQuote.BASESURFACE)
                {
                    return 40;
                }
                else if (desk.SurfaceArea >= DeskQuote.BASESURFACE && desk.SurfaceArea <= DeskQuote.LARGESURFACE)
                {
                    return 50;
                }
                else
                {
                    return 60;
                }
            }
            else if (rushOrder == 7)
            {
                if (desk.SurfaceArea < DeskQuote.BASESURFACE)
                {
                    return 30;
                }
                else if (desk.SurfaceArea >= DeskQuote.BASESURFACE && desk.SurfaceArea <= DeskQuote.LARGESURFACE)
                {
                    return 35;
                }
                else
                {
                    return 40;
                }
            }
            else
            {
                return 1;
            }
        }
        public int CalQuoteTotal()
        {
            try
            {
                int QuoteTotal = DeskQuote.BASEPRICE + quote.SurfaceAreaCost + quote.DrawerCost + quote.MaterialCost + quote.RushCost;
                return QuoteTotal;
            }
            catch (FormatException e)
            {
                MessageBox.Show($"Sorry, something has gone wrong.\n\n{e.Message}");
                return 0;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void numWidth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(numWidth.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    //message
                    MessageBox.Show($"Oops, Check your Width.\n\n\nRound to the nearest Inch between {Desk.MINWIDTH} and {Desk.MAXWIDTH} inches.");
                    numWidth.Text = String.Empty;
                    answer_Enter(this, EventArgs.Empty);
                    numWidth.BackColor = Color.Red;
                    numWidth.Focus();
                }
                else
                {
                    numWidth.BackColor = default(Color);
                    QuoteRefresh();
                }
            }
        }

        private void numWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                //message
                MessageBox.Show("Only Numbers are allowed, please try again.");
                e.Handled = true;
                numWidth.BackColor = Color.Red;
                numWidth.Focus();
            }
            else
            {
                numWidth.BackColor = default(Color);
                QuoteRefresh();
            }
        }

        private void numDepth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(numDepth.Text, out int DepthInput) == true)
            {
                if (DepthInput < Desk.MINDEPTH || DepthInput > Desk.MAXDEPTH)
                {
                    //message
                    MessageBox.Show($"Oops, Check your Depth.\n\n\nRound to the nearest Inch between {Desk.MINDEPTH} and {Desk.MAXDEPTH} inches.");
                    numDepth.Text = String.Empty;
                    answer_Enter(this, EventArgs.Empty);
                    numDepth.BackColor = Color.Red;
                    numDepth.Focus();
                }
                else
                {
                    numDepth.BackColor = default(Color);
                    QuoteRefresh();
                }
            }
        }

        private void numDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                //message
                MessageBox.Show("Only Numbers are allowed, please try again.");
                e.Handled = true;
                numDepth.BackColor = Color.Red;
                numDepth.Focus();
            }
            else
            {
                numDepth.BackColor = default(Color);
                QuoteRefresh();
            }
        }

        private void numDrawers_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(numDrawers.Text, out int DrawersInput) == true)
            {
                if (DrawersInput < Desk.MINDRAWERS || DrawersInput > Desk.MAXDRAWERS)
                {
                    //message
                    MessageBox.Show($"Oops, Check your Number of Drawers.\n\n\nSelect between {Desk.MINDRAWERS} and {Desk.MAXDRAWERS} drawers.");
                    numDrawers.Text = String.Empty;
                    answer_Enter(this, EventArgs.Empty);
                    numDrawers.BackColor = Color.Red;
                    numDrawers.Focus();
                }
                else
                {
                    numDrawers.BackColor = default(Color);
                    QuoteRefresh();
                }
            }
        }

        private void numDrawers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                //message
                MessageBox.Show("Only Numbers are allowed, please try again.");
                e.Handled = true;
                numDrawers.BackColor = Color.Red;
                numDrawers.Focus();
            }
            else
            {
                numDrawers.BackColor = default(Color);
                QuoteRefresh();
            }
        }
        
        private void rd14Days_CheckedChanged(object sender, EventArgs e)
        {
            rushOrder = 0;
            QuoteRefresh();
        }

        private void rd7Days_CheckedChanged(object sender, EventArgs e)
        {
            rushOrder = 7;
            QuoteRefresh();
        }

        private void rd5Days_CheckedChanged(object sender, EventArgs e)
        {
            rushOrder = 5;
            QuoteRefresh();
        }

        private void rd3Days_CheckedChanged(object sender, EventArgs e)
        {
            rushOrder = 3;
            QuoteRefresh();
        }

        private void lblQuoteDate_TextChanged(object sender, EventArgs e)
        {
            QuoteRefresh();
        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            QuoteRefresh();
        }
    }
}