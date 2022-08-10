
namespace ShoppingCartApp
{
    partial class AudioBooksForm
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
            this.grpAudio = new System.Windows.Forms.GroupBox();
            this.lbAudio = new System.Windows.Forms.ListBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpAudio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAudio
            // 
            this.grpAudio.Controls.Add(this.lbAudio);
            this.grpAudio.Location = new System.Drawing.Point(12, 12);
            this.grpAudio.Name = "grpAudio";
            this.grpAudio.Size = new System.Drawing.Size(428, 204);
            this.grpAudio.TabIndex = 1;
            this.grpAudio.TabStop = false;
            this.grpAudio.Text = "Select a Audio Book";
            // 
            // lbAudio
            // 
            this.lbAudio.FormattingEnabled = true;
            this.lbAudio.Items.AddRange(new object[] {
            "Developing People Skills - $12.95",
            "Indiscrete Math - $19.95",
            "Relaxation Techniques - $11.50",
            "You Can Program Too! - $25.50"});
            this.lbAudio.Location = new System.Drawing.Point(6, 19);
            this.lbAudio.Name = "lbAudio";
            this.lbAudio.Size = new System.Drawing.Size(416, 173);
            this.lbAudio.TabIndex = 0;
            this.lbAudio.Tag = "message";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(284, 230);
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
            this.btnClose.Location = new System.Drawing.Point(365, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AudioBooksForm
            // 
            this.AcceptButton = this.btnAddCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(452, 265);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.grpAudio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AudioBooksForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Audio Books";
            this.grpAudio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAudio;
        private System.Windows.Forms.ListBox lbAudio;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnClose;
    }
}