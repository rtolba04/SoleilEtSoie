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
            this.labelDesName.Location = new System.Drawing.Point(35, 37);
            this.labelDesName.Name = "labelDesName";
            this.labelDesName.Size = new System.Drawing.Size(394, 20);
            this.labelDesName.TabIndex = 0;
            this.labelDesName.Text = "Are you ready to add Design Name To your Wardrobe?";
            // 
            // pictureBoxdespic
            // 
            this.pictureBoxdespic.Location = new System.Drawing.Point(39, 80);
            this.pictureBoxdespic.Name = "pictureBoxdespic";
            this.pictureBoxdespic.Size = new System.Drawing.Size(219, 240);
            this.pictureBoxdespic.TabIndex = 1;
            this.pictureBoxdespic.TabStop = false;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.ForeColor = System.Drawing.Color.Red;
            this.labelStock.Location = new System.Drawing.Point(282, 88);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(207, 13);
            this.labelStock.TabIndex = 2;
            this.labelStock.Text = "Only STOCK left in Stock! Get yours NOW";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(282, 260);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(25, 13);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Pay";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(456, 253);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(33, 20);
            this.numericUpDownQuantity.TabIndex = 4;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(285, 294);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToCart.TabIndex = 5;
            this.buttonAddToCart.Text = "Add To Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(414, 294);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonOrder.TabIndex = 6;
            this.buttonOrder.Text = "Order Now!";
            this.buttonOrder.UseVisualStyleBackColor = true;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(285, 117);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(80, 13);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.pictureBoxdespic);
            this.Controls.Add(this.labelDesName);
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