using System;
using System.Windows.Forms;

namespace ShoppingCartApp
{
    public partial class PrintBooksForm : Form
    {
        // Initializes form.
        public PrintBooksForm()
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
            if (lbPrint.SelectedIndex == -1)
            {
              MessageBox.Show("You must chose one of the print books.",
                 "Entry Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
               lbPrint.Focus();
               return false;
            }
            return true;
        }

        // "Saves" the data and sets the tag.
        private void SaveData()
        {
            String message = null;

            if (lbPrint.SelectedIndex >= 0)
                message =  lbPrint.Text;
            else
                message += "No books selected.";
            this.Tag = message;
        }

        // Event handler when CLOSE button is clicked.
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintBooksForm_Load(object sender, EventArgs e)
        {

        }

        private void lbPrint_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
