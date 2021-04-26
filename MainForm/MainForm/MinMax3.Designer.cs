namespace MainForm
{
    partial class MinMax3
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
            this.txtNo1 = new System.Windows.Forms.TextBox();
            this.txtNo3 = new System.Windows.Forms.TextBox();
            this.txtNo2 = new System.Windows.Forms.TextBox();
            this.btnCheckMin = new System.Windows.Forms.Button();
            this.btnCheckMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNo1
            // 
            this.txtNo1.Location = new System.Drawing.Point(53, 26);
            this.txtNo1.Name = "txtNo1";
            this.txtNo1.Size = new System.Drawing.Size(100, 20);
            this.txtNo1.TabIndex = 0;
            // 
            // txtNo3
            // 
            this.txtNo3.Location = new System.Drawing.Point(53, 141);
            this.txtNo3.Name = "txtNo3";
            this.txtNo3.Size = new System.Drawing.Size(100, 20);
            this.txtNo3.TabIndex = 1;
            // 
            // txtNo2
            // 
            this.txtNo2.Location = new System.Drawing.Point(53, 83);
            this.txtNo2.Name = "txtNo2";
            this.txtNo2.Size = new System.Drawing.Size(100, 20);
            this.txtNo2.TabIndex = 2;
            // 
            // btnCheckMin
            // 
            this.btnCheckMin.Location = new System.Drawing.Point(217, 45);
            this.btnCheckMin.Name = "btnCheckMin";
            this.btnCheckMin.Size = new System.Drawing.Size(103, 23);
            this.btnCheckMin.TabIndex = 3;
            this.btnCheckMin.Text = "Check min value";
            this.btnCheckMin.UseVisualStyleBackColor = true;
            this.btnCheckMin.Click += new System.EventHandler(this.btnCheckMin_Click);
            // 
            // btnCheckMax
            // 
            this.btnCheckMax.Location = new System.Drawing.Point(217, 104);
            this.btnCheckMax.Name = "btnCheckMax";
            this.btnCheckMax.Size = new System.Drawing.Size(103, 23);
            this.btnCheckMax.TabIndex = 4;
            this.btnCheckMax.Text = "Check max value";
            this.btnCheckMax.UseVisualStyleBackColor = true;
            this.btnCheckMax.Click += new System.EventHandler(this.btnCheckMax_Click);
            // 
            // MinMax3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 217);
            this.Controls.Add(this.btnCheckMax);
            this.Controls.Add(this.btnCheckMin);
            this.Controls.Add(this.txtNo2);
            this.Controls.Add(this.txtNo3);
            this.Controls.Add(this.txtNo1);
            this.Name = "MinMax3";
            this.Text = "MinMax3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNo1;
        private System.Windows.Forms.TextBox txtNo3;
        private System.Windows.Forms.TextBox txtNo2;
        private System.Windows.Forms.Button btnCheckMin;
        private System.Windows.Forms.Button btnCheckMax;
    }
}