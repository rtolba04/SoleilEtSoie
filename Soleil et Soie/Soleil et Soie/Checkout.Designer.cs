namespace Soleil_et_Soie
{
    partial class Checkout
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
            this.flowLayoutItems = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutCard = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFinishOrder = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.radioButtonCard = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutItems
            // 
            this.flowLayoutItems.AutoScroll = true;
            this.flowLayoutItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutItems.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutItems.Name = "flowLayoutItems";
            this.flowLayoutItems.Size = new System.Drawing.Size(308, 366);
            this.flowLayoutItems.TabIndex = 0;
            // 
            // flowLayoutCard
            // 
            this.flowLayoutCard.AutoScroll = true;
            this.flowLayoutCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutCard.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutCard.Location = new System.Drawing.Point(308, 209);
            this.flowLayoutCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutCard.Name = "flowLayoutCard";
            this.flowLayoutCard.Size = new System.Drawing.Size(292, 157);
            this.flowLayoutCard.TabIndex = 1;
            // 
            // buttonFinishOrder
            // 
            this.buttonFinishOrder.AutoSize = true;
            this.buttonFinishOrder.Location = new System.Drawing.Point(503, 182);
            this.buttonFinishOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFinishOrder.Name = "buttonFinishOrder";
            this.buttonFinishOrder.Size = new System.Drawing.Size(74, 23);
            this.buttonFinishOrder.TabIndex = 2;
            this.buttonFinishOrder.Text = "Order Now!!";
            this.buttonFinishOrder.UseVisualStyleBackColor = true;
            this.buttonFinishOrder.Visible = false;
            this.buttonFinishOrder.Click += new System.EventHandler(this.buttonFinishOrder_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(312, 187);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(79, 13);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total amount is";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(312, 52);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address";
            // 
            // radioButtonCard
            // 
            this.radioButtonCard.AutoSize = true;
            this.radioButtonCard.Location = new System.Drawing.Point(352, 136);
            this.radioButtonCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonCard.Name = "radioButtonCard";
            this.radioButtonCard.Size = new System.Drawing.Size(47, 17);
            this.radioButtonCard.TabIndex = 5;
            this.radioButtonCard.TabStop = true;
            this.radioButtonCard.Text = "Card";
            this.radioButtonCard.UseVisualStyleBackColor = true;
            this.radioButtonCard.CheckedChanged += new System.EventHandler(this.radioButtonCard_CheckedChanged);
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(482, 136);
            this.radioButtonCash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(103, 17);
            this.radioButtonCash.TabIndex = 6;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash on delivery";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Payment Method";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(377, 52);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(201, 20);
            this.textBoxAddress.TabIndex = 8;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonCash);
            this.Controls.Add(this.radioButtonCard);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonFinishOrder);
            this.Controls.Add(this.flowLayoutCard);
            this.Controls.Add(this.flowLayoutItems);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutCard;
        private System.Windows.Forms.Button buttonFinishOrder;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.RadioButton radioButtonCard;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddress;
    }
}