namespace Soleil_et_Soie
{
    partial class manage_prod
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restock_prod_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.view_prods_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "select product to restock:";
            // 
            // restock_prod_button
            // 
            this.restock_prod_button.Location = new System.Drawing.Point(27, 113);
            this.restock_prod_button.Name = "restock_prod_button";
            this.restock_prod_button.Size = new System.Drawing.Size(119, 23);
            this.restock_prod_button.TabIndex = 4;
            this.restock_prod_button.Text = "Restock product";
            this.restock_prod_button.UseVisualStyleBackColor = true;
            this.restock_prod_button.Click += new System.EventHandler(this.restock_prod_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(243, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 280);
            this.dataGridView1.TabIndex = 5;
            // 
            // view_prods_button
            // 
            this.view_prods_button.Location = new System.Drawing.Point(431, 339);
            this.view_prods_button.Name = "view_prods_button";
            this.view_prods_button.Size = new System.Drawing.Size(138, 23);
            this.view_prods_button.TabIndex = 6;
            this.view_prods_button.Text = "view all products";
            this.view_prods_button.UseVisualStyleBackColor = true;
            this.view_prods_button.Click += new System.EventHandler(this.view_prods_button_Click);
            // 
            // manage_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_prods_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.restock_prod_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "manage_prod";
            this.Text = "manage_prod";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restock_prod_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button view_prods_button;
    }
}