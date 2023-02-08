namespace SampleTextEditiorL4DC
{
    partial class frmFindandReplace
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
            this.lblfind = new System.Windows.Forms.Label();
            this.lblreplace = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.txtreplace = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnreplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfind
            // 
            this.lblfind.AutoSize = true;
            this.lblfind.Location = new System.Drawing.Point(54, 43);
            this.lblfind.Name = "lblfind";
            this.lblfind.Size = new System.Drawing.Size(35, 17);
            this.lblfind.TabIndex = 0;
            this.lblfind.Text = "Find";
            // 
            // lblreplace
            // 
            this.lblreplace.AutoSize = true;
            this.lblreplace.Location = new System.Drawing.Point(54, 120);
            this.lblreplace.Name = "lblreplace";
            this.lblreplace.Size = new System.Drawing.Size(88, 17);
            this.lblreplace.TabIndex = 1;
            this.lblreplace.Text = "Replace with";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(180, 40);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(138, 22);
            this.txtfind.TabIndex = 2;
            // 
            // txtreplace
            // 
            this.txtreplace.Location = new System.Drawing.Point(180, 115);
            this.txtreplace.Name = "txtreplace";
            this.txtreplace.Size = new System.Drawing.Size(138, 22);
            this.txtreplace.TabIndex = 3;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(57, 180);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 4;
            this.btnfind.Text = "Find ";
            this.btnfind.UseVisualStyleBackColor = true;
            // 
            // btnreplace
            // 
            this.btnreplace.Location = new System.Drawing.Point(243, 180);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(75, 23);
            this.btnreplace.TabIndex = 5;
            this.btnreplace.Text = "Replace";
            this.btnreplace.UseVisualStyleBackColor = true;
            // 
            // frmFindandReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 262);
            this.Controls.Add(this.btnreplace);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtreplace);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.lblreplace);
            this.Controls.Add(this.lblfind);
            this.Name = "frmFindandReplace";
            this.Text = "Find and Replace";
            this.Load += new System.EventHandler(this.frmFindandReplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfind;
        private System.Windows.Forms.Label lblreplace;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.TextBox txtreplace;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnreplace;
    }
}