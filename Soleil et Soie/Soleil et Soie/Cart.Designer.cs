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
            this.buttonCheckOut.Location = new System.Drawing.Point(377, 253);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(134, 23);
            this.buttonCheckOut.TabIndex = 0;
            this.buttonCheckOut.Text = "Proceed To Checkout";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(377, 315);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(134, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Continue Shopping";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "+ Tax And Shipping";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grand Total";
            // 
            // labelOrderTotal
            // 
            this.labelOrderTotal.AutoSize = true;
            this.labelOrderTotal.Location = new System.Drawing.Point(449, 71);
            this.labelOrderTotal.Name = "labelOrderTotal";
            this.labelOrderTotal.Size = new System.Drawing.Size(84, 13);
            this.labelOrderTotal.TabIndex = 5;
            this.labelOrderTotal.Text = "ORDER TOTAL";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(441, 125);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(108, 13);
            this.labelTax.TabIndex = 6;
            this.labelTax.Text = "TAX AND SHIPPING";
            // 
            // labelGrandTot
            // 
            this.labelGrandTot.AutoSize = true;
            this.labelGrandTot.Location = new System.Drawing.Point(449, 181);
            this.labelGrandTot.Name = "labelGrandTot";
            this.labelGrandTot.Size = new System.Drawing.Size(84, 13);
            this.labelGrandTot.TabIndex = 7;
            this.labelGrandTot.Text = "GRAND TOTAL";
            // 
            // flowLayoutPanelCart
            // 
            this.flowLayoutPanelCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCart.Location = new System.Drawing.Point(34, 22);
            this.flowLayoutPanelCart.Name = "flowLayoutPanelCart";
            this.flowLayoutPanelCart.Size = new System.Drawing.Size(294, 316);
            this.flowLayoutPanelCart.TabIndex = 8;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.flowLayoutPanelCart);
            this.Controls.Add(this.labelGrandTot);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelOrderTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCheckOut);
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