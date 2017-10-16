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
using System.Media;
namespace SAMMYS_SEAFOOD_SHACK
{
    public partial class sammysSeafoodShack : Form
    {
        const double LOBSTER = 2.49; //constant variables
        const double MUSSELS = 1.89;
        const double SALTY_WATER = 0.99;
        const double FIND_TAX = 0.13;
        const double ADD_TAX = 1.13;

        int lobster; //global variables
        int mussels;
        int saltywater;
        double totalCost;
        double tax;
        double totalWithTax;
        double tendered;
        double change;

        public sammysSeafoodShack()
        {
            InitializeComponent(); //set boxes to 0
            lobsterInput.Text = "0";
            musselsInput.Text = "0";
            saltywaterInput.Text = "0";
            tenderedInput.Text = "0";
        }

        private void calcTotalButton_Click(object sender, EventArgs e)
        { try
            {
                lobster = Convert.ToInt16(lobsterInput.Text);//Price calculations
                mussels = Convert.ToInt16(musselsInput.Text);
                saltywater = Convert.ToInt16(saltywaterInput.Text);
                totalCost = lobster * LOBSTER + mussels * MUSSELS + saltywater * SALTY_WATER;
                tax = totalCost * FIND_TAX;
                totalWithTax = totalCost * ADD_TAX;
                subtotalOutput.Text = totalCost.ToString("C");
                taxOutput.Text = tax.ToString("C");
                totalOutput.Text = totalWithTax.ToString("C");
            }
            catch
            {
                subtotalOutput.Text = "Error"; //Error messages
                taxOutput.Text = "Error";
                totalOutput.Text = "Error";
            }

        }

        private void calcChange_Click(object sender, EventArgs e)

        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);//Calculate change 
                change = tendered - totalWithTax;
                changeOutput.Text = change.ToString("C");               
            }

            catch
            {
                changeOutput.Text = "Error";
            }
        }              

        private void printreceiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                lobster = Convert.ToInt16(lobsterInput.Text);//Calculations for variables
                mussels = Convert.ToInt16(musselsInput.Text);
                saltywater = Convert.ToInt16(saltywaterInput.Text);
                totalCost = lobster * LOBSTER + mussels * MUSSELS + saltywater * SALTY_WATER;
                tax = totalCost * FIND_TAX;
                totalWithTax = totalCost * ADD_TAX;
                subtotalOutput.Text = totalCost.ToString("C");
                taxOutput.Text = tax.ToString("C");
                totalOutput.Text = totalWithTax.ToString("C");

                Graphics formGraphics = this.CreateGraphics();//set formgraphics
                Pen drawPen = new Pen(Color.SeaGreen, 10);
                SolidBrush drawBrush = new SolidBrush(Color.SeaGreen);
                formGraphics.FillRectangle(drawBrush, 296, 16, 465, 304);
                Font drawFont = new Font("Arial", 8, FontStyle.Bold);
                drawBrush.Color = Color.Black;

                SoundPlayer player = new SoundPlayer(Properties.Resources.printerSound);
                player.Play();

                //print receipt
                formGraphics.DrawString("Sammys Seafood Shack", drawFont, drawBrush, 360, 40);
                Thread.Sleep(650);
                formGraphics.DrawString("Order Number 1076", drawFont, drawBrush, 320, 60);
                Thread.Sleep(650);
                formGraphics.DrawString("September 12, 2012", drawFont, drawBrush, 320, 70);
                Thread.Sleep(650);
                formGraphics.DrawString("Lobsters           x" + lobster + " @ " + LOBSTER,
                    drawFont, drawBrush, 320, 90);
                Thread.Sleep(650);
                formGraphics.DrawString("Mussels            x" + mussels + " @ " + MUSSELS,
                    drawFont, drawBrush, 320, 100);
                Thread.Sleep(650);
                formGraphics.DrawString("Salty Water       x" + saltywater + " @ "
                    + SALTY_WATER, drawFont, drawBrush, 320, 110);
                Thread.Sleep(650);
                formGraphics.DrawString("Subtotal                    "
                    + totalCost.ToString("C"), drawFont, drawBrush, 320, 130);
                Thread.Sleep(650);
                formGraphics.DrawString("Tax                             "
                    + tax.ToString("C"), drawFont, drawBrush, 320, 150);
                Thread.Sleep(650);
                formGraphics.DrawString("Total                          "
                    + totalWithTax.ToString("C"), drawFont, drawBrush, 320, 170);
                Thread.Sleep(650);
                formGraphics.DrawString("Tendered                   "
                    + tendered.ToString("C"), drawFont, drawBrush, 320, 190);
                Thread.Sleep(650);
                formGraphics.DrawString("Change                      "
                    + change.ToString("C"), drawFont, drawBrush, 320, 210);
                Thread.Sleep(650);
                formGraphics.DrawString("Have a nice day!", drawFont, drawBrush, 320, 250);
                Thread.Sleep(650);
                player.Stop(); //stops sounds
            }
            catch
            {
                printreceiptButton.Text = "ERROR"; //catch errors in reciept
            }
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            lobsterInput.Text = "0";
            musselsInput.Text = "0";
            saltywaterInput.Text = "0";
            tenderedInput.Text = "0";
            subtotalOutput.Text = "0";
            taxOutput.Text = "0";
            totalOutput.Text = "0";
            changeOutput.Text = "0";

            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.Turquoise);
        }
    }
}
