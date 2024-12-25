namespace Soleil_et_Soie
{
    partial class manage_users
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
            this.create_user_button = new System.Windows.Forms.Button();
            this.select_pending_combo = new System.Windows.Forms.ComboBox();
            this.select_user_label = new System.Windows.Forms.Label();
            this.del_button = new System.Windows.Forms.Button();
            this.viewall_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // create_user_button
            // 
            this.create_user_button.Location = new System.Drawing.Point(96, 23);
            this.create_user_button.Name = "create_user_button";
            this.create_user_button.Size = new System.Drawing.Size(134, 51);
            this.create_user_button.TabIndex = 0;
            this.create_user_button.Text = "Create/Update admin/designer ";
            this.create_user_button.UseVisualStyleBackColor = true;
            this.create_user_button.Click += new System.EventHandler(this.create_user_button_Click);
            // 
            // select_pending_combo
            // 
            this.select_pending_combo.FormattingEnabled = true;
            this.select_pending_combo.Location = new System.Drawing.Point(145, 367);
            this.select_pending_combo.Name = "select_pending_combo";
            this.select_pending_combo.Size = new System.Drawing.Size(121, 24);
            this.select_pending_combo.TabIndex = 3;
            // 
            // select_user_label
            // 
            this.select_user_label.AutoSize = true;
            this.select_user_label.Location = new System.Drawing.Point(9, 370);
            this.select_user_label.Name = "select_user_label";
            this.select_user_label.Size = new System.Drawing.Size(130, 16);
            this.select_user_label.TabIndex = 4;
            this.select_user_label.Text = "select user to delete:";
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(89, 422);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(128, 23);
            this.del_button.TabIndex = 6;
            this.del_button.Text = "Delete User";
            this.del_button.UseVisualStyleBackColor = true;
            // 
            // viewall_button
            // 
            this.viewall_button.Location = new System.Drawing.Point(89, 99);
            this.viewall_button.Name = "viewall_button";
            this.viewall_button.Size = new System.Drawing.Size(141, 23);
            this.viewall_button.TabIndex = 8;
            this.viewall_button.Text = "View All Users";
            this.viewall_button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(295, 191);
            this.dataGridView1.TabIndex = 9;
            // 
            // manage_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.viewall_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.select_user_label);
            this.Controls.Add(this.select_pending_combo);
            this.Controls.Add(this.create_user_button);
            this.Name = "manage_users";
            this.Text = "manage_users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_user_button;
        private System.Windows.Forms.ComboBox select_pending_combo;
        private System.Windows.Forms.Label select_user_label;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button viewall_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}