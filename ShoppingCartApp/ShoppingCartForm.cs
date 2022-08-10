/*
 * File: ShoppingCartForm.cs
 * Author: Miguel Duran 841-17-1372
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 03/27/2021
 * Purpose: Main for of the shopping cart app where 
 *          everu print book and audio book will join 
 *          reating the whole shopping cart.
 */

using System;
using System.Windows.Forms;

namespace ShoppingCartApp
{
    public partial class ShoppingCartForm : Form
    {
        // Declare instance variables for the subtotal, tax, shipping and total.
        private double subtotal = 0;
        private double tax;
        private double shipping;
        private double total;

        // Initializes form.
        public ShoppingCartForm()
        {
            InitializeComponent();
        }

        // Event handler when PRODUCTS > PRINT BOOK menu item is clicked.
        private void tsmiPrint_Click(object sender, EventArgs e)
        {
            PrintBooksForm frmPrintBook = new PrintBooksForm();
            DialogResult button = frmPrintBook.ShowDialog();

            if (button == DialogResult.OK)
            {
                lbBooks.Items.Add(frmPrintBook.Tag);

                Subtotal1();

                txtSubtotal.Text = subtotal.ToString("c");
                tax = subtotal * 0.115;
                txtTax.Text = tax.ToString("c");
                int counter = lbBooks.Items.Count;
                shipping = counter * 2;
                txtShipping.Text = shipping.ToString("c");
                total = subtotal + tax + shipping;
                txtTotal.Text = total.ToString("c");
            }
        }

        // Event handler when PRODUCTS > AUDIO BOOK menu item is clicked.
        private void tsmiAudio_Click(object sender, EventArgs e)
        {
            AudioBooksForm frmAudioBook = new AudioBooksForm();
            DialogResult button = frmAudioBook.ShowDialog();

            if (button == DialogResult.OK)
            {
                lbBooks.Items.Add(frmAudioBook.Tag);

                Subtotal();

                txtSubtotal.Text = subtotal.ToString("c");
                tax = subtotal * 0.115;
                txtTax.Text = tax.ToString("c");
                int counter = lbBooks.Items.Count;
                shipping = counter * 2;
                txtShipping.Text = shipping.ToString("c");
                total = subtotal + tax + shipping;
                txtTotal.Text = total.ToString("c");
            }
        }

        private double Subtotal1()
        {
            if (lbBooks.Items.Contains("The History of Computers - $14.50"))
            {
                subtotal = subtotal + 14.50;
            }
            else if (lbBooks.Items.Contains("Learn Calculus in One Day - $29.95"))
            {
                subtotal = subtotal + 29.95;
            }
            else if (lbBooks.Items.Contains("Feel the Stress - $18.50"))
            {
                subtotal = subtotal + 18.50;
            }
            else if (lbBooks.Items.Contains("C# Programming Made Easy - $11.95"))
            {
                subtotal = subtotal + 11.95;
            }
            return subtotal;
        }

        private double Subtotal ()
        {
            if (lbBooks.Items.Contains("You Can Program Too! - $25.50"))
            {
                subtotal = subtotal + 25.50;
            }
            else if (lbBooks.Items.Contains("Relaxation Techniques - $11.50"))
            {
                subtotal = subtotal + 11.50;
            }
            else if (lbBooks.Items.Contains("Indiscrete Math - $19.95"))
            {
                subtotal = subtotal + 19.95;
            }
            else if (lbBooks.Items.Contains("Developing People Skills - $12.95"))
            {
                subtotal = subtotal + 12.95;
            }
            return subtotal;
        }

        // Event handler when HELP > ABOUT menu item is clicked.
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ShoppingCart © 2020 Miguel Duran. All Rights Reserved \n\n This app lets you choose between" +
                " audio books or physical books and gives you how much will it cost. It simulates a shopping cart.",
                "About Shopping Cart App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler when REMOVE button is clicked.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedIndex >= 0)
            {
                lbBooks.Items.RemoveAt(lbBooks.SelectedIndex);
                shipping = shipping - 2;
                txtShipping.Text = shipping.ToString("c");

                if (lbBooks.Items.Count == 0)
                {
                    txtShipping.Clear();
                    txtTax.Clear();
                }
            }
        }

        // Event handler when FILE > RESET menu item is clicked.
        private void tsmiReset_Click(object sender, EventArgs e)
        {
            lbBooks.Items.Clear();
            txtSubtotal.Clear();
            subtotal = 0;
            txtTax.Clear();
            tax = 0;
            txtShipping.Clear();
            shipping = 0;
            txtTotal.Clear();
            total = 0;
        }

        // Event handler when FILE > EXIT menu item is clicked.
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
