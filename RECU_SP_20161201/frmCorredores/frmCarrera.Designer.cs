namespace frmCorredores
{
    partial class frmCarrera
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
            this.pgbCarril1 = new System.Windows.Forms.ProgressBar();
            this.lblCarril1 = new System.Windows.Forms.Label();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.lblCarril2 = new System.Windows.Forms.Label();
            this.pgbCarril2 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pgbCarril1
            // 
            this.pgbCarril1.Location = new System.Drawing.Point(130, 10);
            this.pgbCarril1.Name = "pgbCarril1";
            this.pgbCarril1.Size = new System.Drawing.Size(325, 23);
            this.pgbCarril1.TabIndex = 0;
            // 
            // lblCarril1
            // 
            this.lblCarril1.AutoSize = true;
            this.lblCarril1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarril1.Location = new System.Drawing.Point(12, 9);
            this.lblCarril1.Name = "lblCarril1";
            this.lblCarril1.Size = new System.Drawing.Size(76, 24);
            this.lblCarril1.TabIndex = 1;
            this.lblCarril1.Text = "Carril 1";
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(318, 92);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(137, 44);
            this.btnCorrer.TabIndex = 2;
            this.btnCorrer.Text = "Correr";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // lblCarril2
            // 
            this.lblCarril2.AutoSize = true;
            this.lblCarril2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarril2.Location = new System.Drawing.Point(12, 51);
            this.lblCarril2.Name = "lblCarril2";
            this.lblCarril2.Size = new System.Drawing.Size(76, 24);
            this.lblCarril2.TabIndex = 4;
            this.lblCarril2.Text = "Carril 2";
            // 
            // pgbCarril2
            // 
            this.pgbCarril2.Location = new System.Drawing.Point(130, 52);
            this.pgbCarril2.Name = "pgbCarril2";
            this.pgbCarril2.Size = new System.Drawing.Size(325, 23);
            this.pgbCarril2.TabIndex = 3;
            // 
            // frmCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 149);
            this.Controls.Add(this.lblCarril2);
            this.Controls.Add(this.pgbCarril2);
            this.Controls.Add(this.btnCorrer);
            this.Controls.Add(this.lblCarril1);
            this.Controls.Add(this.pgbCarril1);
            this.Name = "frmCarrera";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbCarril1;
        private System.Windows.Forms.Label lblCarril1;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.Label lblCarril2;
        private System.Windows.Forms.ProgressBar pgbCarril2;
    }
}

