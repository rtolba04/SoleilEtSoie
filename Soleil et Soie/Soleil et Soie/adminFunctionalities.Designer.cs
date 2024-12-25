namespace Soleil_et_Soie
{
    partial class adminFunctionalities
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
            this.manage_users_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manage_users_button
            // 
            this.manage_users_button.Location = new System.Drawing.Point(22, 60);
            this.manage_users_button.Name = "manage_users_button";
            this.manage_users_button.Size = new System.Drawing.Size(168, 23);
            this.manage_users_button.TabIndex = 1;
            this.manage_users_button.Text = "Manage Users ";
            this.manage_users_button.UseVisualStyleBackColor = true;
            this.manage_users_button.Click += new System.EventHandler(this.manage_users_button_Click);
            // 
            // adminFunctionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 536);
            this.Controls.Add(this.manage_users_button);
            this.Name = "adminFunctionalities";
            this.Text = "adminFunctionalities";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button manage_users_button;
    }
}