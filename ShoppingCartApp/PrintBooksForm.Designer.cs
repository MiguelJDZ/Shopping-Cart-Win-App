
namespace ShoppingCartApp
{
    partial class PrintBooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPrint = new System.Windows.Forms.GroupBox();
            this.lbPrint = new System.Windows.Forms.ListBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPrint
            // 
            this.grpPrint.Controls.Add(this.lbPrint);
            this.grpPrint.Location = new System.Drawing.Point(12, 12);
            this.grpPrint.Name = "grpPrint";
            this.grpPrint.Size = new System.Drawing.Size(428, 204);
            this.grpPrint.TabIndex = 0;
            this.grpPrint.TabStop = false;
            this.grpPrint.Text = "Select a Print Book";
            // 
            // lbPrint
            // 
            this.lbPrint.FormattingEnabled = true;
            this.lbPrint.Items.AddRange(new object[] {
            "C# Programming Made Easy - $11.95",
            "Feel the Stress - $18.50",
            "Learn Calculus in One Day - $29.95",
            "The History of Computers - $14.50",
            ""});
            this.lbPrint.Location = new System.Drawing.Point(6, 19);
            this.lbPrint.Name = "lbPrint";
            this.lbPrint.Size = new System.Drawing.Size(416, 173);
            this.lbPrint.TabIndex = 0;
            this.lbPrint.SelectedIndexChanged += new System.EventHandler(this.lbPrint_SelectedIndexChanged);
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(284, 231);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddCart.TabIndex = 1;
            this.btnAddCart.Text = "&Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(365, 231);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PrintBooksForm
            // 
            this.AcceptButton = this.btnAddCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(452, 267);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.grpPrint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintBooksForm";
            this.Text = "Print Books";
            this.Load += new System.EventHandler(this.PrintBooksForm_Load);
            this.grpPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPrint;
        private System.Windows.Forms.ListBox lbPrint;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnClose;
    }
}