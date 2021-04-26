namespace MainForm
{
    partial class Sarbatorit
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCheckBirthday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnCheckBirthday
            // 
            this.btnCheckBirthday.Location = new System.Drawing.Point(274, 39);
            this.btnCheckBirthday.Name = "btnCheckBirthday";
            this.btnCheckBirthday.Size = new System.Drawing.Size(108, 23);
            this.btnCheckBirthday.TabIndex = 1;
            this.btnCheckBirthday.Text = "Check Birthday";
            this.btnCheckBirthday.UseVisualStyleBackColor = true;
            this.btnCheckBirthday.Click += new System.EventHandler(this.btnCheckBirthday_Click);
            // 
            // Sarbatorit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 95);
            this.Controls.Add(this.btnCheckBirthday);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Sarbatorit";
            this.Text = "Sarbatorit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCheckBirthday;
    }
}