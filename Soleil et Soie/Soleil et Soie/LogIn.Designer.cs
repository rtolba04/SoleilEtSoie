namespace Soleil_et_Soie
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelsignin = new System.Windows.Forms.LinkLabel();
            this.labelError = new System.Windows.Forms.Label();
            this.ShowPassPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(308, 149);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(291, 22);
            this.textBoxUserName.TabIndex = 2;
            this.textBoxUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxUserName_KeyUp);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(308, 218);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(291, 22);
            this.textBoxPass.TabIndex = 3;
            this.textBoxPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPass_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Edwardian Script ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 71);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome to Soleil et Soie";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(500, 284);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 28);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 6;
            // 
            // linkLabelsignin
            // 
            this.linkLabelsignin.AutoSize = true;
            this.linkLabelsignin.Location = new System.Drawing.Point(364, 343);
            this.linkLabelsignin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelsignin.Name = "linkLabelsignin";
            this.linkLabelsignin.Size = new System.Drawing.Size(213, 16);
            this.linkLabelsignin.TabIndex = 7;
            this.linkLabelsignin.TabStop = true;
            this.linkLabelsignin.Text = "Don\'t have an account yet? Sign in!";
            this.linkLabelsignin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelsignin_LinkClicked);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(175, 297);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(221, 16);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "User Name or Password is Incorrect";
            this.labelError.Visible = false;
            // 
            // ShowPassPic
            // 
            this.ShowPassPic.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowPassPic.Image = ((System.Drawing.Image)(resources.GetObject("ShowPassPic.Image")));
            this.ShowPassPic.Location = new System.Drawing.Point(606, 218);
            this.ShowPassPic.Name = "ShowPassPic";
            this.ShowPassPic.Size = new System.Drawing.Size(41, 29);
            this.ShowPassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPassPic.TabIndex = 9;
            this.ShowPassPic.TabStop = false;
            this.ShowPassPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPassPic_MouseDown);
            this.ShowPassPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPassPic_MouseUp);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 554);
            this.Controls.Add(this.ShowPassPic);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.linkLabelsignin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelsignin;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox ShowPassPic;
    }
}

