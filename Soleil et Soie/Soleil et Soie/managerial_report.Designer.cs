namespace Soleil_et_Soie
{
    partial class managerial_report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maxprod_button = new System.Windows.Forms.Button();
            this.min_prod_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 99);
            this.dataGridView1.TabIndex = 0;
            // 
            // maxprod_button
            // 
            this.maxprod_button.Location = new System.Drawing.Point(23, 248);
            this.maxprod_button.Name = "maxprod_button";
            this.maxprod_button.Size = new System.Drawing.Size(161, 23);
            this.maxprod_button.TabIndex = 1;
            this.maxprod_button.Text = "View max product sold";
            this.maxprod_button.UseVisualStyleBackColor = true;
            this.maxprod_button.Click += new System.EventHandler(this.maxprod_button_Click);
            // 
            // min_prod_button
            // 
            this.min_prod_button.Location = new System.Drawing.Point(23, 277);
            this.min_prod_button.Name = "min_prod_button";
            this.min_prod_button.Size = new System.Drawing.Size(148, 23);
            this.min_prod_button.TabIndex = 2;
            this.min_prod_button.Text = "View min product sold";
            this.min_prod_button.UseVisualStyleBackColor = true;
            this.min_prod_button.Click += new System.EventHandler(this.min_prod_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(284, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(339, 22);
            this.textBox2.TabIndex = 4;
            // 
            // managerial_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.min_prod_button);
            this.Controls.Add(this.maxprod_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "managerial_report";
            this.Text = "managerial_report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button maxprod_button;
        private System.Windows.Forms.Button min_prod_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}