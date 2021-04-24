namespace MainForm
{
    partial class Generatii
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
            this.lblVarsta = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnDetermineGeneration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Location = new System.Drawing.Point(109, 36);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(85, 13);
            this.lblVarsta.TabIndex = 0;
            this.lblVarsta.Text = "Insereaza varsta";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(89, 52);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(117, 20);
            this.txtAge.TabIndex = 1;
            // 
            // btnDetermineGeneration
            // 
            this.btnDetermineGeneration.Location = new System.Drawing.Point(89, 89);
            this.btnDetermineGeneration.Name = "btnDetermineGeneration";
            this.btnDetermineGeneration.Size = new System.Drawing.Size(117, 23);
            this.btnDetermineGeneration.TabIndex = 2;
            this.btnDetermineGeneration.Text = "Determina generatia";
            this.btnDetermineGeneration.UseVisualStyleBackColor = true;
            this.btnDetermineGeneration.Click += new System.EventHandler(this.btnDetermineGeneration_Click);
            // 
            // Generatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 144);
            this.Controls.Add(this.btnDetermineGeneration);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblVarsta);
            this.Name = "Generatii";
            this.Text = "Generatii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnDetermineGeneration;
    }
}