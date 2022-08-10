/*
 * File: AudioBooksForm.cs
 * Author: Miguel Duran 841-17-1372
 * Course: COTI 4150-KJ1 Prof. Antonio F. Huertas
 * Date: 03/27/2021
 * Purpose: This form shows the audio books available 
 *          and lets you add them to cart.
 */

using System;
using System.Windows.Forms;

namespace ShoppingCartApp
{
    public partial class AudioBooksForm : Form
    {
        // Initializes form.
        public AudioBooksForm()
        {
            InitializeComponent();
        }

        // Event handler when ADD CART button is clicked.
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
                this.DialogResult = DialogResult.OK;
            }
        }

        // Determines whether this form has valid data.
        private bool IsValidData()
        {
            if (lbAudio.SelectedIndex == -1)
            {
                MessageBox.Show("You must chose one of the audio books.",
                   "Entry Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbAudio.Focus();
                return false;
            }
            return true;
        }

        // "Saves" the data and sets the tag.
        private void SaveData()
        {
            String message = null;

            if (lbAudio.SelectedIndex >= 0)
                message = lbAudio.Text;
            else
                message += "No books selected.";
            this.Tag = message;
        }

        // Even handler when CLOSE button is clicked.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
