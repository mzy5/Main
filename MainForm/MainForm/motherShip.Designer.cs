namespace MainForm
{
    partial class motherShip
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
            this.btnParitate = new System.Windows.Forms.Button();
            this.btnGeneratii = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnSarbatorit = new System.Windows.Forms.Button();
            this.btnMinMax3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParitate
            // 
            this.btnParitate.Location = new System.Drawing.Point(29, 22);
            this.btnParitate.Name = "btnParitate";
            this.btnParitate.Size = new System.Drawing.Size(75, 23);
            this.btnParitate.TabIndex = 0;
            this.btnParitate.Text = "Paritate";
            this.btnParitate.UseVisualStyleBackColor = true;
            this.btnParitate.Click += new System.EventHandler(this.btnParitate_Click);
            // 
            // btnGeneratii
            // 
            this.btnGeneratii.Location = new System.Drawing.Point(29, 74);
            this.btnGeneratii.Name = "btnGeneratii";
            this.btnGeneratii.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratii.TabIndex = 1;
            this.btnGeneratii.Text = "Generatii";
            this.btnGeneratii.UseVisualStyleBackColor = true;
            this.btnGeneratii.Click += new System.EventHandler(this.btnGeneratii_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(29, 124);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(75, 23);
            this.btnCombo.TabIndex = 2;
            this.btnCombo.Text = "Combobox";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnSarbatorit
            // 
            this.btnSarbatorit.Location = new System.Drawing.Point(29, 176);
            this.btnSarbatorit.Name = "btnSarbatorit";
            this.btnSarbatorit.Size = new System.Drawing.Size(75, 23);
            this.btnSarbatorit.TabIndex = 3;
            this.btnSarbatorit.Text = "Sarbatorit";
            this.btnSarbatorit.UseVisualStyleBackColor = true;
            this.btnSarbatorit.Click += new System.EventHandler(this.btnSarbatorit_Click);
            // 
            // btnMinMax3
            // 
            this.btnMinMax3.Location = new System.Drawing.Point(29, 228);
            this.btnMinMax3.Name = "btnMinMax3";
            this.btnMinMax3.Size = new System.Drawing.Size(75, 23);
            this.btnMinMax3.TabIndex = 4;
            this.btnMinMax3.Text = "MinMax3";
            this.btnMinMax3.UseVisualStyleBackColor = true;
            this.btnMinMax3.Click += new System.EventHandler(this.btnMinMax3_Click);
            // 
            // motherShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMinMax3);
            this.Controls.Add(this.btnSarbatorit);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnGeneratii);
            this.Controls.Add(this.btnParitate);
            this.Name = "motherShip";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParitate;
        private System.Windows.Forms.Button btnGeneratii;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnSarbatorit;
        private System.Windows.Forms.Button btnMinMax3;
    }
}

