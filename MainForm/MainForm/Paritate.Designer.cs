namespace MainForm
{
    partial class Paritate
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
            this.lblNr = new System.Windows.Forms.Label();
            this.txtInsertNo = new System.Windows.Forms.TextBox();
            this.btnCheckNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Location = new System.Drawing.Point(12, 19);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(85, 13);
            this.lblNr.TabIndex = 0;
            this.lblNr.Text = "Insereaza numar";
            // 
            // txtInsertNo
            // 
            this.txtInsertNo.Location = new System.Drawing.Point(15, 35);
            this.txtInsertNo.Name = "txtInsertNo";
            this.txtInsertNo.Size = new System.Drawing.Size(100, 20);
            this.txtInsertNo.TabIndex = 1;
            // 
            // btnCheckNo
            // 
            this.btnCheckNo.Location = new System.Drawing.Point(149, 33);
            this.btnCheckNo.Name = "btnCheckNo";
            this.btnCheckNo.Size = new System.Drawing.Size(95, 23);
            this.btnCheckNo.TabIndex = 2;
            this.btnCheckNo.Text = "Verifica numar";
            this.btnCheckNo.UseVisualStyleBackColor = true;
            this.btnCheckNo.Click += new System.EventHandler(this.btnCheckNo_Click);
            // 
            // Paritate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 80);
            this.Controls.Add(this.btnCheckNo);
            this.Controls.Add(this.txtInsertNo);
            this.Controls.Add(this.lblNr);
            this.Name = "Paritate";
            this.Text = "Paritate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.TextBox txtInsertNo;
        private System.Windows.Forms.Button btnCheckNo;
    }
}