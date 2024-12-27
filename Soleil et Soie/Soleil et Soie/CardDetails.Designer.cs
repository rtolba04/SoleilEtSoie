namespace Soleil_et_Soie
{
    partial class CardDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutMain
            // 
            this.flowLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMain.Name = "flowLayoutMain";
            this.flowLayoutMain.Size = new System.Drawing.Size(706, 312);
            this.flowLayoutMain.TabIndex = 0;
            // 
            // CardDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutMain);
            this.Name = "CardDetails";
            this.Size = new System.Drawing.Size(706, 312);
            this.Load += new System.EventHandler(this.CardDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutMain;
    }
}
