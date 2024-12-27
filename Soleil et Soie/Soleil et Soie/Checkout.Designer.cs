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
            this.flowLayoutItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutItems.Name = "flowLayoutItems";
            this.flowLayoutItems.Size = new System.Drawing.Size(411, 450);
            this.flowLayoutItems.TabIndex = 0;
            // 
            // flowLayoutCard
            // 
            this.flowLayoutCard.AutoScroll = true;
            this.flowLayoutCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutCard.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutCard.Location = new System.Drawing.Point(411, 257);
            this.flowLayoutCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutCard.Name = "flowLayoutCard";
            this.flowLayoutCard.Size = new System.Drawing.Size(389, 193);
            this.flowLayoutCard.TabIndex = 1;
            // 
            // buttonFinishOrder
            // 
            this.buttonFinishOrder.AutoSize = true;
            this.buttonFinishOrder.Location = new System.Drawing.Point(671, 224);
            this.buttonFinishOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFinishOrder.Name = "buttonFinishOrder";
            this.buttonFinishOrder.Size = new System.Drawing.Size(99, 28);
            this.buttonFinishOrder.TabIndex = 2;
            this.buttonFinishOrder.Text = "Order Now!!";
            this.buttonFinishOrder.UseVisualStyleBackColor = true;
            this.buttonFinishOrder.Visible = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(416, 230);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(98, 16);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total amount is";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(416, 64);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 16);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address";
            // 
            // radioButtonCard
            // 
            this.radioButtonCard.AutoSize = true;
            this.radioButtonCard.Location = new System.Drawing.Point(469, 167);
            this.radioButtonCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonCard.Name = "radioButtonCard";
            this.radioButtonCard.Size = new System.Drawing.Size(57, 20);
            this.radioButtonCard.TabIndex = 5;
            this.radioButtonCard.TabStop = true;
            this.radioButtonCard.Text = "Card";
            this.radioButtonCard.UseVisualStyleBackColor = true;
            this.radioButtonCard.CheckedChanged += new System.EventHandler(this.radioButtonCard_CheckedChanged);
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(642, 167);
            this.radioButtonCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(128, 20);
            this.radioButtonCash.TabIndex = 6;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash on delivery";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Payment Method";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(503, 64);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(267, 22);
            this.textBoxAddress.TabIndex = 8;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonCash);
            this.Controls.Add(this.radioButtonCard);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonFinishOrder);
            this.Controls.Add(this.flowLayoutCard);
            this.Controls.Add(this.flowLayoutItems);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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