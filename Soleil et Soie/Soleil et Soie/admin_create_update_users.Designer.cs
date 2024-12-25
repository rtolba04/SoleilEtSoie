namespace Soleil_et_Soie
{
    partial class admin_create_update_users
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.f_radio = new System.Windows.Forms.RadioButton();
            this.m_radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.create_button = new System.Windows.Forms.Button();
            this.admin_radio = new System.Windows.Forms.RadioButton();
            this.designer_radio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.error1 = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.error3 = new System.Windows.Forms.Label();
            this.error4 = new System.Windows.Forms.Label();
            this.error5 = new System.Windows.Forms.Label();
            this.error6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(148, 31);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(100, 22);
            this.username_textbox.TabIndex = 5;
            // 
            // pass_textbox
            // 
            this.pass_textbox.Location = new System.Drawing.Point(148, 57);
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.Size = new System.Drawing.Size(100, 22);
            this.pass_textbox.TabIndex = 6;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(148, 85);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(100, 22);
            this.phone_textbox.TabIndex = 7;
            this.phone_textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(148, 121);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(100, 22);
            this.email_textbox.TabIndex = 8;
            // 
            // f_radio
            // 
            this.f_radio.AutoSize = true;
            this.f_radio.Location = new System.Drawing.Point(22, 32);
            this.f_radio.Name = "f_radio";
            this.f_radio.Size = new System.Drawing.Size(36, 20);
            this.f_radio.TabIndex = 9;
            this.f_radio.TabStop = true;
            this.f_radio.Text = "F";
            this.f_radio.UseVisualStyleBackColor = true;
            // 
            // m_radio
            // 
            this.m_radio.AutoSize = true;
            this.m_radio.Location = new System.Drawing.Point(87, 32);
            this.m_radio.Name = "m_radio";
            this.m_radio.Size = new System.Drawing.Size(39, 20);
            this.m_radio.TabIndex = 10;
            this.m_radio.TabStop = true;
            this.m_radio.Text = "M";
            this.m_radio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.f_radio);
            this.groupBox1.Controls.Add(this.m_radio);
            this.groupBox1.Location = new System.Drawing.Point(42, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 56);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(64, 359);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(143, 23);
            this.create_button.TabIndex = 12;
            this.create_button.Text = "Create User";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // admin_radio
            // 
            this.admin_radio.AutoSize = true;
            this.admin_radio.Location = new System.Drawing.Point(6, 31);
            this.admin_radio.Name = "admin_radio";
            this.admin_radio.Size = new System.Drawing.Size(65, 20);
            this.admin_radio.TabIndex = 13;
            this.admin_radio.TabStop = true;
            this.admin_radio.Text = "admin";
            this.admin_radio.UseVisualStyleBackColor = true;
            // 
            // designer_radio
            // 
            this.designer_radio.AutoSize = true;
            this.designer_radio.Location = new System.Drawing.Point(95, 31);
            this.designer_radio.Name = "designer_radio";
            this.designer_radio.Size = new System.Drawing.Size(81, 20);
            this.designer_radio.TabIndex = 14;
            this.designer_radio.TabStop = true;
            this.designer_radio.Text = "designer";
            this.designer_radio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.admin_radio);
            this.groupBox2.Controls.Add(this.designer_radio);
            this.groupBox2.Location = new System.Drawing.Point(39, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 70);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User type";
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.ForeColor = System.Drawing.Color.Red;
            this.error1.Location = new System.Drawing.Point(254, 34);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(186, 16);
            this.error1.TabIndex = 16;
            this.error1.Text = "username cant all be numbers";
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.ForeColor = System.Drawing.Color.Red;
            this.error2.Location = new System.Drawing.Point(465, 34);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(147, 16);
            this.error2.TabIndex = 17;
            this.error2.Text = "please insert username";
            // 
            // error3
            // 
            this.error3.AutoSize = true;
            this.error3.ForeColor = System.Drawing.Color.Red;
            this.error3.Location = new System.Drawing.Point(268, 63);
            this.error3.Name = "error3";
            this.error3.Size = new System.Drawing.Size(146, 16);
            this.error3.TabIndex = 18;
            this.error3.Text = "please insert password";
            // 
            // error4
            // 
            this.error4.AutoSize = true;
            this.error4.ForeColor = System.Drawing.Color.Red;
            this.error4.Location = new System.Drawing.Point(254, 88);
            this.error4.Name = "error4";
            this.error4.Size = new System.Drawing.Size(280, 16);
            this.error4.TabIndex = 19;
            this.error4.Text = "invalid phone number(cant include characters)";
            // 
            // error5
            // 
            this.error5.AutoSize = true;
            this.error5.ForeColor = System.Drawing.Color.Red;
            this.error5.Location = new System.Drawing.Point(540, 88);
            this.error5.Name = "error5";
            this.error5.Size = new System.Drawing.Size(271, 16);
            this.error5.TabIndex = 20;
            this.error5.Text = "phone number must be exactly 11 characters";
            // 
            // error6
            // 
            this.error6.AutoSize = true;
            this.error6.ForeColor = System.Drawing.Color.Red;
            this.error6.Location = new System.Drawing.Point(268, 290);
            this.error6.Name = "error6";
            this.error6.Size = new System.Drawing.Size(155, 16);
            this.error6.TabIndex = 21;
            this.error6.Text = "please choose user type";
            // 
            // admin_create_update_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.error6);
            this.Controls.Add(this.error5);
            this.Controls.Add(this.error4);
            this.Controls.Add(this.error3);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "admin_create_update_users";
            this.Text = "admin_create_update_users";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox pass_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.RadioButton f_radio;
        private System.Windows.Forms.RadioButton m_radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.RadioButton admin_radio;
        private System.Windows.Forms.RadioButton designer_radio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.Label error2;
        private System.Windows.Forms.Label error3;
        private System.Windows.Forms.Label error4;
        private System.Windows.Forms.Label error5;
        private System.Windows.Forms.Label error6;
    }
}