using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        double orchids;
        double tulips;
        double chrysanthemums;
        double subtotal;
        double tax;
        double taxamount = 0.13;
        double total;
        double change;
        double tendered;
        double orchidPrice = 8.25;
        double tulipPrice = 6.50;
        double chrysanthemumPrice = 4.75;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //inputs
                orchids = Convert.ToDouble(orchidInput.Text);
                tulips = Convert.ToDouble(tulipInput.Text);
                chrysanthemums = Convert.ToDouble(chrysanthemumInput.Text);


                //values
                subtotal = (orchids * orchidPrice) + (tulips * tulipPrice) + (chrysanthemums * chrysanthemumPrice);
                tax = subtotal * taxamount;
                total = subtotal + tax;


                //outputs
                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                taxOutput.Text = $"{tax.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";

            }
            catch
            {
                subtotalOutput.Text = $"ERROR";
                taxOutput.Text = $"ERROR";
                totalOutput.Text = $"ERROR";
                changeOutput.Text = $"ERROR";
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
         try 
          { 
            //inputs
            tendered = Convert.ToDouble(tenderedInput.Text);

            //values
            change = tendered - total;

            //outputs
            changeOutput.Text = $"{change.ToString("C")}";
        }
        catch
        {
                subtotalOutput.Text = $"ERROR";
                taxOutput.Text = $"ERROR";
                totalOutput.Text = $"ERROR";
                changeOutput.Text = $"ERROR";

            }
        }
        private void recieptButton_Click(object sender, EventArgs e)
        {

            recieptOutput.Text = $"Bill of Sale";
            Refresh();
            Thread.Sleep(1000);
            recieptOutput.Text += $"\n\nOrchids:        {orchids} @ {orchidPrice}";
            Refresh();
            Thread.Sleep(1000);
            recieptOutput.Text += $"\nTulips:         {tulips} @ {tulipPrice}";
            Refresh();
            Thread.Sleep(1000);
            recieptOutput.Text += $"\nChrysanthemums: {chrysanthemums} @ {chrysanthemumPrice}";
            Refresh();
            Thread.Sleep(1000);
            recieptOutput.Text += $"\n\nSubtotal:       {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            recieptOutput.Text += $"\n13% Tax:        {tax.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            recieptOutput.Text += $"\nTotal:          {total.ToString("C")}";
            Refresh();
            Thread.Sleep(1000);
            recieptOutput.Text += $"\nTendered:       {tendered}";
            Refresh();
            Thread.Sleep(1000);
            recieptOutput.Text += $"\nChange:         {change.ToString("C")}";
            Refresh();
            Thread.Sleep(1500);
            recieptOutput.Text += $"\n\nThank You!";
        }
    }
}