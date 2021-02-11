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

//Ria Das
//Cash register for an Indian sweets store
namespace SummativeCashReceipt
{
    public partial class Form1 : Form
    {

        double rasgulla = 20;
        double numberRasgulla;
        double peda = 15;
        double numberPeda;
        double jaelbi = 25;
        double numberJaelibi;

        double subtotal;
        double tax = 0.13;
        double taxAmount;
        double total;

        double tendered;
        double numberTendered;

        double change;

        SoundPlayer piano = new SoundPlayer(Properties.Resources.piano_music);
        public Form1()
        {
            InitializeComponent();
            receiptLabel.Hide();
            neworderButton.Hide();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //insert vallues 
                numberRasgulla = Convert.ToInt32(rasgullaBox.Text);
                numberPeda = Convert.ToInt32(pedaBox.Text);
                numberJaelibi = Convert.ToInt32(jalebiBox.Text);

                //calculations that leads to sub total
                subtotal = (rasgulla * numberRasgulla) + (peda * numberPeda) + (jaelbi * numberJaelibi);

                subtotalLabel.Text = $"\nSub Total                                    {subtotal.ToString("$.00")}";

                //calculations thet leads to tax 
                taxAmount = subtotal * tax;

                taxLabel.Text = $"\nTax                                                 {taxAmount.ToString("$.00")}";

                //calculations that leads to total
                total = subtotal + taxAmount;

                totalLabel.Text = $"\nTotal                                           {total.ToString("$.00")}";

            }
            catch
            {
                //message when you do not put a number
                signButton.Text = "Boxes only come in numbers!";
                signButton.BackColor = Color.White;
                Refresh();
                Thread.Sleep(5000);
                signButton.Text = "Indian Sweets Shop";
                signButton.BackColor = Color.IndianRed;
            }

            }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            { 
            //inserting tendred
            numberTendered = Convert.ToInt32(tenderedBox.Text);

            //calculating change 
            change = numberTendered - total;
            changeLabel.Text = $"Change                                         {change.ToString("$.00")}";

            }
            catch
            {
                //message when you do not put a number
                signButton.Text = "You can only pay with money!";
                signButton.BackColor = Color.White;
                Refresh();
                Thread.Sleep(5000);
                signButton.Text = "Indian Sweets Shop";
                signButton.BackColor = Color.IndianRed;
            }
        }

        private void rButton_Click(object sender, EventArgs e)
        {
            piano.Play();

            receiptLabel.Show();
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n";
            receiptLabel.Text += $"\n                            Ria's Indian Sweets Shop";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n";
            receiptLabel.Text += $"\nRasgulla Box[{numberRasgulla}]...............................................$20";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nPeda Box[{numberPeda}].....................................................$15";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nJalebi Box[{numberJaelibi}]...................................................$25";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n";
            receiptLabel.Text += $"\nSub Total........................................................{subtotal.ToString("$.00")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nTax..................................................................{taxAmount.ToString("$.00")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nTotal...............................................................{total.ToString("$.00")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n";
            receiptLabel.Text += $"\nTendered........................................................{numberTendered.ToString("$.00")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nChange...........................................................{change.ToString("$.00")}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\n";
            receiptLabel.Text += $"\nThank you for coming! We hope to take your money again soon!";
            Refresh();
            Thread.Sleep(1000);
            neworderButton.Show();
        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            //reset boxes to 0 
            rasgullaBox.Text = "0";
            pedaBox.Text = "0";
            jalebiBox.Text = "0";
            tenderedBox.Text = "0";

            //reset lables to 0
            subtotalLabel.Text = " ";
            taxLabel.Text = " ";
            totalLabel.Text = " ";
            changeLabel.Text = " ";
            receiptLabel.Text = " ";
            receiptLabel.Hide();

        }
    }
}
