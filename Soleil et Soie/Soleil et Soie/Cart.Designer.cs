namespace Soleil_et_Soie
{
    partial class Cart
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
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOrderTotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelGrandTot = new System.Windows.Forms.Label();
            this.flowLayoutPanelCart = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Location = new System.Drawing.Point(503, 311);
            this.buttonCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(179, 28);
            this.buttonCheckOut.TabIndex = 0;
            this.buttonCheckOut.Text = "Proceed To Checkout";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(503, 388);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(179, 28);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Continue Shopping";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "+ Tax And Shipping";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grand Total";
            // 
            // labelOrderTotal
            // 
            this.labelOrderTotal.AutoSize = true;
            this.labelOrderTotal.Location = new System.Drawing.Point(599, 87);
            this.labelOrderTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderTotal.Name = "labelOrderTotal";
            this.labelOrderTotal.Size = new System.Drawing.Size(103, 16);
            this.labelOrderTotal.TabIndex = 5;
            this.labelOrderTotal.Text = "ORDER TOTAL";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(588, 154);
            this.labelTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(131, 16);
            this.labelTax.TabIndex = 6;
            this.labelTax.Text = "TAX AND SHIPPING";
            // 
            // labelGrandTot
            // 
            this.labelGrandTot.AutoSize = true;
            this.labelGrandTot.Location = new System.Drawing.Point(599, 223);
            this.labelGrandTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrandTot.Name = "labelGrandTot";
            this.labelGrandTot.Size = new System.Drawing.Size(103, 16);
            this.labelGrandTot.TabIndex = 7;
            this.labelGrandTot.Text = "GRAND TOTAL";
            // 
            // flowLayoutPanelCart
            // 
            this.flowLayoutPanelCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCart.Location = new System.Drawing.Point(45, 27);
            this.flowLayoutPanelCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelCart.Name = "flowLayoutPanelCart";
            this.flowLayoutPanelCart.Size = new System.Drawing.Size(392, 389);
            this.flowLayoutPanelCart.TabIndex = 8;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 554);
            this.Controls.Add(this.flowLayoutPanelCart);
            this.Controls.Add(this.labelGrandTot);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelOrderTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCheckOut);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cart";
            this.Text = "My Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOrderTotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelGrandTot;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCart;
    }
}