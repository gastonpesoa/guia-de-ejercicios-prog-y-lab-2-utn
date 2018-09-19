namespace Ej_25_Conversor_Numerico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btbDecToBin = new System.Windows.Forms.Button();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(121, 37);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 20);
            this.txtBinario.TabIndex = 0;
            this.txtBinario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Location = new System.Drawing.Point(308, 37);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.ReadOnly = true;
            this.txtResultadoDec.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoDec.TabIndex = 1;
            this.txtResultadoDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(227, 35);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(75, 23);
            this.btnBinToDec.TabIndex = 2;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Binario a Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Decimal a Binario";
            // 
            // btbDecToBin
            // 
            this.btbDecToBin.Location = new System.Drawing.Point(227, 61);
            this.btbDecToBin.Name = "btbDecToBin";
            this.btbDecToBin.Size = new System.Drawing.Size(75, 23);
            this.btbDecToBin.TabIndex = 6;
            this.btbDecToBin.Text = "->";
            this.btbDecToBin.UseVisualStyleBackColor = true;
            this.btbDecToBin.Click += new System.EventHandler(this.btbDecToBin_Click);
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Location = new System.Drawing.Point(308, 63);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.ReadOnly = true;
            this.txtResultadoBin.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoBin.TabIndex = 5;
            this.txtResultadoBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(121, 63);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 4;
            this.txtDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btbDecToBin);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.txtBinario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbDecToBin;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.TextBox txtDecimal;
    }
}

