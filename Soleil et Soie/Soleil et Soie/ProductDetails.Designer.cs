namespace Soleil_et_Soie
{
    partial class ProductDetails
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
            this.labelDesName = new System.Windows.Forms.Label();
            this.pictureBoxdespic = new System.Windows.Forms.PictureBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdespic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDesName
            // 
            this.labelDesName.AutoSize = true;
            this.labelDesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesName.Location = new System.Drawing.Point(47, 46);
            this.labelDesName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesName.Name = "labelDesName";
            this.labelDesName.Size = new System.Drawing.Size(491, 25);
            this.labelDesName.TabIndex = 0;
            this.labelDesName.Text = "Are you ready to add Design Name To your Wardrobe?";
            // 
            // pictureBoxdespic
            // 
            this.pictureBoxdespic.Location = new System.Drawing.Point(52, 98);
            this.pictureBoxdespic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxdespic.Name = "pictureBoxdespic";
            this.pictureBoxdespic.Size = new System.Drawing.Size(292, 295);
            this.pictureBoxdespic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxdespic.TabIndex = 1;
            this.pictureBoxdespic.TabStop = false;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.ForeColor = System.Drawing.Color.Red;
            this.labelStock.Location = new System.Drawing.Point(376, 108);
            this.labelStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(251, 16);
            this.labelStock.TabIndex = 2;
            this.labelStock.Text = "Only STOCK left in Stock! Get yours NOW";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(376, 320);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 16);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Pay";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(608, 311);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownQuantity.TabIndex = 4;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(380, 362);
            this.buttonAddToCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(100, 28);
            this.buttonAddToCart.TabIndex = 5;
            this.buttonAddToCart.Text = "Add To Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(552, 362);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(100, 28);
            this.buttonOrder.TabIndex = 6;
            this.buttonOrder.Text = "Order Now!";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(380, 144);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(98, 16);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 554);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.pictureBoxdespic);
            this.Controls.Add(this.labelDesName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxdespic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesName;
        private System.Windows.Forms.PictureBox pictureBoxdespic;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelDescription;
    }
}