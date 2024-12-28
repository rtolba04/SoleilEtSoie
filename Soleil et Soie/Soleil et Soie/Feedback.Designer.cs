namespace Soleil_et_Soie
{
    partial class Feedback
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
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFeedback = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProductFB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFeedBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.Location = new System.Drawing.Point(314, 130);
            this.numericUpDownRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(41, 22);
            this.numericUpDownRating.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Give us a rating!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leave a suggestion";
            // 
            // textBoxFeedback
            // 
            this.textBoxFeedback.Location = new System.Drawing.Point(314, 184);
            this.textBoxFeedback.Multiline = true;
            this.textBoxFeedback.Name = "textBoxFeedback";
            this.textBoxFeedback.Size = new System.Drawing.Size(339, 170);
            this.textBoxFeedback.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Edwardian Script ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 47);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thank you for visiting!";
            // 
            // comboBoxProductFB
            // 
            this.comboBoxProductFB.FormattingEnabled = true;
            this.comboBoxProductFB.Location = new System.Drawing.Point(532, 128);
            this.comboBoxProductFB.Name = "comboBoxProductFB";
            this.comboBoxProductFB.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProductFB.TabIndex = 5;
            this.comboBoxProductFB.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductFB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Specific product?";
            // 
            // buttonFeedBack
            // 
            this.buttonFeedBack.Location = new System.Drawing.Point(451, 384);
            this.buttonFeedBack.Name = "buttonFeedBack";
            this.buttonFeedBack.Size = new System.Drawing.Size(75, 23);
            this.buttonFeedBack.TabIndex = 7;
            this.buttonFeedBack.Text = "Send";
            this.buttonFeedBack.UseVisualStyleBackColor = true;
            this.buttonFeedBack.Click += new System.EventHandler(this.buttonFeedBack_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFeedBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxProductFB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFeedback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownRating);
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProductFB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFeedBack;
    }
}