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
            this.getuserscombo = new System.Windows.Forms.ComboBox();
            this.select_user_label = new System.Windows.Forms.Label();
            this.viewall_button = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.deluser_button = new System.Windows.Forms.Button();
            this.deactivate_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // create_user_button
            // 
            this.create_user_button.Location = new System.Drawing.Point(89, 56);
            this.create_user_button.Name = "create_user_button";
            this.create_user_button.Size = new System.Drawing.Size(134, 51);
            this.create_user_button.TabIndex = 0;
            this.create_user_button.Text = "Create/Update admin/designer ";
            this.create_user_button.UseVisualStyleBackColor = true;
            this.create_user_button.Click += new System.EventHandler(this.create_user_button_Click);
            // 
            // getuserscombo
            // 
            this.getuserscombo.FormattingEnabled = true;
            this.getuserscombo.Location = new System.Drawing.Point(89, 228);
            this.getuserscombo.Name = "getuserscombo";
            this.getuserscombo.Size = new System.Drawing.Size(121, 24);
            this.getuserscombo.TabIndex = 3;
            // 
            // select_user_label
            // 
            this.select_user_label.AutoSize = true;
            this.select_user_label.Location = new System.Drawing.Point(93, 195);
            this.select_user_label.Name = "select_user_label";
            this.select_user_label.Size = new System.Drawing.Size(130, 16);
            this.select_user_label.TabIndex = 4;
            this.select_user_label.Text = "select user to delete:";
            // 
            // viewall_button
            // 
            this.viewall_button.Location = new System.Drawing.Point(537, 37);
            this.viewall_button.Name = "viewall_button";
            this.viewall_button.Size = new System.Drawing.Size(141, 23);
            this.viewall_button.TabIndex = 8;
            this.viewall_button.Text = "View All Users";
            this.viewall_button.UseVisualStyleBackColor = true;
            this.viewall_button.Click += new System.EventHandler(this.viewall_button_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(391, 82);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(448, 273);
            this.dg.TabIndex = 9;
            // 
            // deluser_button
            // 
            this.deluser_button.Location = new System.Drawing.Point(96, 258);
            this.deluser_button.Name = "deluser_button";
            this.deluser_button.Size = new System.Drawing.Size(106, 23);
            this.deluser_button.TabIndex = 27;
            this.deluser_button.Text = "delete user";
            this.deluser_button.UseVisualStyleBackColor = true;
            this.deluser_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // deactivate_button
            // 
            this.deactivate_button.Location = new System.Drawing.Point(89, 300);
            this.deactivate_button.Name = "deactivate_button";
            this.deactivate_button.Size = new System.Drawing.Size(122, 23);
            this.deactivate_button.TabIndex = 28;
            this.deactivate_button.Text = "Deactivate user";
            this.deactivate_button.UseVisualStyleBackColor = true;
            this.deactivate_button.Click += new System.EventHandler(this.deactivate_button_Click);
            // 
            // manage_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 537);
            this.Controls.Add(this.deactivate_button);
            this.Controls.Add(this.deluser_button);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.viewall_button);
            this.Controls.Add(this.select_user_label);
            this.Controls.Add(this.getuserscombo);
            this.Controls.Add(this.create_user_button);
            this.Name = "manage_users";
            this.Text = "manage_users";
            this.Load += new System.EventHandler(this.manage_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_user_button;
        private System.Windows.Forms.ComboBox getuserscombo;
        private System.Windows.Forms.Label select_user_label;
        private System.Windows.Forms.Button viewall_button;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button deluser_button;
        private System.Windows.Forms.Button deactivate_button;
    }
}