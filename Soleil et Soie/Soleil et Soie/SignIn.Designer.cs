namespace Soleil_et_Soie
{
    partial class SignIn
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.labelError1 = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.labelError3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.radioButtonf = new System.Windows.Forms.RadioButton();
            this.radioButtonm = new System.Windows.Forms.RadioButton();
            this.labelError4 = new System.Windows.Forms.Label();
            this.labelError5 = new System.Windows.Forms.Label();
            this.labelError6 = new System.Windows.Forms.Label();
            this.labelError7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(199, 73);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(229, 20);
            this.textBoxUserName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(199, 116);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(229, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(353, 282);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSignIn.TabIndex = 4;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.ForeColor = System.Drawing.Color.Red;
            this.labelError1.Location = new System.Drawing.Point(69, 292);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(246, 13);
            this.labelError1.TabIndex = 5;
            this.labelError1.Text = "User Name cannot be made up entirely of numbers";
            this.labelError1.Visible = false;
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(69, 292);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(265, 13);
            this.labelError2.TabIndex = 6;
            this.labelError2.Text = "User Name cannot be Empty! Please Enter User Name";
            this.labelError2.Visible = false;
            // 
            // labelError3
            // 
            this.labelError3.AutoSize = true;
            this.labelError3.ForeColor = System.Drawing.Color.Red;
            this.labelError3.Location = new System.Drawing.Point(69, 292);
            this.labelError3.Name = "labelError3";
            this.labelError3.Size = new System.Drawing.Size(251, 13);
            this.labelError3.TabIndex = 7;
            this.labelError3.Text = "Password cannot be Empty! Please Enter Password";
            this.labelError3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(199, 159);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(229, 20);
            this.textBoxPhone.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(199, 196);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(229, 20);
            this.textBoxEmail.TabIndex = 12;
            // 
            // radioButtonf
            // 
            this.radioButtonf.AutoSize = true;
            this.radioButtonf.Location = new System.Drawing.Point(199, 231);
            this.radioButtonf.Name = "radioButtonf";
            this.radioButtonf.Size = new System.Drawing.Size(59, 17);
            this.radioButtonf.TabIndex = 13;
            this.radioButtonf.TabStop = true;
            this.radioButtonf.Text = "Female";
            this.radioButtonf.UseVisualStyleBackColor = true;
            // 
            // radioButtonm
            // 
            this.radioButtonm.AutoSize = true;
            this.radioButtonm.Location = new System.Drawing.Point(327, 231);
            this.radioButtonm.Name = "radioButtonm";
            this.radioButtonm.Size = new System.Drawing.Size(48, 17);
            this.radioButtonm.TabIndex = 14;
            this.radioButtonm.TabStop = true;
            this.radioButtonm.Text = "Male";
            this.radioButtonm.UseVisualStyleBackColor = true;
            // 
            // labelError4
            // 
            this.labelError4.AutoSize = true;
            this.labelError4.ForeColor = System.Drawing.Color.Red;
            this.labelError4.Location = new System.Drawing.Point(46, 292);
            this.labelError4.Name = "labelError4";
            this.labelError4.Size = new System.Drawing.Size(301, 13);
            this.labelError4.TabIndex = 15;
            this.labelError4.Text = "Phone Number cannot be Empty! Please Enter Phone Number";
            this.labelError4.Visible = false;
            // 
            // labelError5
            // 
            this.labelError5.AutoSize = true;
            this.labelError5.ForeColor = System.Drawing.Color.Red;
            this.labelError5.Location = new System.Drawing.Point(74, 292);
            this.labelError5.Name = "labelError5";
            this.labelError5.Size = new System.Drawing.Size(209, 13);
            this.labelError5.TabIndex = 16;
            this.labelError5.Text = "Email cannot be Empty! Please Enter Email";
            this.labelError5.Visible = false;
            // 
            // labelError6
            // 
            this.labelError6.AutoSize = true;
            this.labelError6.ForeColor = System.Drawing.Color.Red;
            this.labelError6.Location = new System.Drawing.Point(74, 292);
            this.labelError6.Name = "labelError6";
            this.labelError6.Size = new System.Drawing.Size(183, 13);
            this.labelError6.TabIndex = 17;
            this.labelError6.Text = "Phone Number cannot contain letters";
            this.labelError6.Visible = false;
            // 
            // labelError7
            // 
            this.labelError7.AutoSize = true;
            this.labelError7.ForeColor = System.Drawing.Color.Red;
            this.labelError7.Location = new System.Drawing.Point(74, 292);
            this.labelError7.Name = "labelError7";
            this.labelError7.Size = new System.Drawing.Size(205, 13);
            this.labelError7.TabIndex = 18;
            this.labelError7.Text = "Phone Number Should Consist of 11 digits";
            this.labelError7.Visible = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 349);
            this.Controls.Add(this.labelError7);
            this.Controls.Add(this.labelError6);
            this.Controls.Add(this.labelError5);
            this.Controls.Add(this.labelError4);
            this.Controls.Add(this.radioButtonm);
            this.Controls.Add(this.radioButtonf);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelError3);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.labelError1);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.Label labelError3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.RadioButton radioButtonf;
        private System.Windows.Forms.RadioButton radioButtonm;
        private System.Windows.Forms.Label labelError4;
        private System.Windows.Forms.Label labelError5;
        private System.Windows.Forms.Label labelError6;
        private System.Windows.Forms.Label labelError7;
    }
}