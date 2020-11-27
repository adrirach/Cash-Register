using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        double fries = 5.00;
        double burger = 15.00;
        double drink = 1.00;
        double tax = 0.13;
        double drinks;
        double burgers;
        double frenchfries;
        double taxamount;
        double subtotal;
        double total;
        double tender ;
        double changes;
        double burgercost;
        double friescost;
        double drinkcost;
       




        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Caculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                burgers = Convert.ToInt32(burgertext.Text);
                drinks = Convert.ToInt32(drinktext.Text);
                frenchfries = Convert.ToInt32(friestext.Text);
                subtotal = burger * burgers + fries* frenchfries + drink *drinks;
                subtotals.Text = subtotal.ToString("$.00");

                taxamount = subtotal * tax;
                taxtotals.Text = taxamount.ToString("$.00");

                total = subtotal + taxamount;
                totaltext.Text = total.ToString("$.00");
                


                
            }
            catch
            
            {
                subtotals.Text = "Please Enter a Number";
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tender = Convert.ToDouble(tenderdtext.Text);
            changes = tender - total;
            changetext.Text = $"{changes.ToString("C")}";
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SoundPlayer receipt = new SoundPlayer(Properties.Resources.receipt);
            bill.Visible = true;
                Refresh();
            Thread.Sleep(300);
            receipt.Play();
            order.Visible = true;
                Refresh();
            Thread.Sleep(300);
            receipt.Play();
            date.Visible = true;
                Refresh();
            Thread.Sleep(300);
            receipt.Play();
            burgercost = burgers * burger;
            friescost = frenchfries * fries;
            drinkcost = drinks * drink;

            foodbox.Visible = true;
            numberbox.Visible = true;

            foodbox.Text = $"\nBurger:";
            numberbox.Text = $"\n{burgercost.ToString("C")}";
            Refresh();
            Thread.Sleep(300);
            receipt.Play();

            foodbox.Text += $"\nDrink:";
            numberbox.Text += $"\n{drinkcost.ToString("C")}";
            Refresh();
            Thread.Sleep(300);
            receipt.Play();

            foodbox.Text += $"\nFries:";
            numberbox.Text += $"\n{friescost.ToString("C")}";
            Refresh();
            Thread.Sleep(300);
            receipt.Play();

            foodbox.Text += $" \n\nSubtotal:";
            numberbox.Text += $"\n\n{subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(300);
            receipt.Play();

            foodbox.Text += $"\nTaxtotal:"; 
            numberbox.Text += $"\n{taxamount.ToString("C")}";
            Refresh();                                                                                                                                     
            Thread.Sleep(300);
            receipt.Play();

            foodbox.Text += $" \n Total:";
            numberbox.Text += $"\n{total.ToString("C")}";
            Refresh();
            Thread.Sleep(300);
            receipt.Play();

            foodbox.Text += $" \n\n Tendered:";
            numberbox.Text += $"\n\n{tender.ToString("C")}";
            Refresh();
            Thread.Sleep(300);
            receipt.Play();

            foodbox.Text += $" \n\n Change:";
            numberbox.Text += $"\n\n{changes.ToString("C")}";
            Refresh();
            Thread.Sleep(300);
            receipt.Play();

            foodbox.Text += $" \n  Enjoy!";
            Refresh();
            Thread.Sleep(300);
            receipt.Play();









        }

        private void Changetext_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click_1(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
