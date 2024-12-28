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
            this.button1 = new System.Windows.Forms.Button();
            this.manage_prod_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manage_users_button
            // 
            this.manage_users_button.Location = new System.Drawing.Point(22, 60);
            this.manage_users_button.Name = "manage_users_button";
            this.manage_users_button.Size = new System.Drawing.Size(168, 27);
            this.manage_users_button.TabIndex = 1;
            this.manage_users_button.Text = "Manage Users ";
            this.manage_users_button.UseVisualStyleBackColor = true;
            this.manage_users_button.Click += new System.EventHandler(this.manage_users_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "manage design submissions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // manage_prod_button
            // 
            this.manage_prod_button.Location = new System.Drawing.Point(37, 168);
            this.manage_prod_button.Name = "manage_prod_button";
            this.manage_prod_button.Size = new System.Drawing.Size(141, 31);
            this.manage_prod_button.TabIndex = 3;
            this.manage_prod_button.Text = "Manage products";
            this.manage_prod_button.UseVisualStyleBackColor = true;
            this.manage_prod_button.Click += new System.EventHandler(this.manage_prod_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Manage Feedbacks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "View managerial report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "View detailed report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // adminFunctionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 536);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.manage_prod_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manage_users_button);
            this.Name = "adminFunctionalities";
            this.Text = "adminFunctionalities";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button manage_users_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button manage_prod_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}