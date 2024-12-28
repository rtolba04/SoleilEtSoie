namespace Soleil_et_Soie
{
    partial class FeedBackadmin
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

        //        /// <summary>
        //        /// Required method for Designer support - do not modify
        //        /// the contents of this method with the code editor.
        //        /// </summary>
        private void InitializeComponent()
        {
            ////<<<<<<< admin3
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.view_all_feed_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.delete_feed_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // view_all_feed_button
            // 
            this.view_all_feed_button.Location = new System.Drawing.Point(24, 295);
            this.view_all_feed_button.Name = "view_all_feed_button";
            this.view_all_feed_button.Size = new System.Drawing.Size(125, 23);
            this.view_all_feed_button.TabIndex = 1;
            this.view_all_feed_button.Text = "View all feedback";
            this.view_all_feed_button.UseVisualStyleBackColor = true;
            this.view_all_feed_button.Click += new System.EventHandler(this.view_all_feed_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "View feedback for chosen product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 337);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(480, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // delete_feed_button
            // 
            this.delete_feed_button.Location = new System.Drawing.Point(629, 73);
            this.delete_feed_button.Name = "delete_feed_button";
            this.delete_feed_button.Size = new System.Drawing.Size(135, 23);
            this.delete_feed_button.TabIndex = 5;
            this.delete_feed_button.Text = "Delete feedback";
            this.delete_feed_button.UseVisualStyleBackColor = true;
            this.delete_feed_button.Click += new System.EventHandler(this.delete_feed_button_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_feed_button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.view_all_feed_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Feedback";
            this.Text = "Feedback";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            //=======

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button view_all_feed_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button delete_feed_button;
    }
}