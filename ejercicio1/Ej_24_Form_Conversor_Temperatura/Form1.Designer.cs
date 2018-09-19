namespace Ej_24_Form_Conversor_Temperatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFahrenheitAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnConvertFahrenheit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFahrenheitACelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheitAKelvin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelsiusAKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusACelsius = new System.Windows.Forms.TextBox();
            this.btnConvertCelsius = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtCelsiusAFahrenheit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKelvinAKelvin = new System.Windows.Forms.TextBox();
            this.txtKelvinACelsius = new System.Windows.Forms.TextBox();
            this.btnConvertKelvin = new System.Windows.Forms.Button();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtKelvinAFahrenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit";
            // 
            // txtFahrenheitAFahrenheit
            // 
            this.txtFahrenheitAFahrenheit.Location = new System.Drawing.Point(305, 27);
            this.txtFahrenheitAFahrenheit.Name = "txtFahrenheitAFahrenheit";
            this.txtFahrenheitAFahrenheit.ReadOnly = true;
            this.txtFahrenheitAFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitAFahrenheit.TabIndex = 1;
            this.txtFahrenheitAFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(118, 27);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 2;
            this.txtFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConvertFahrenheit
            // 
            this.btnConvertFahrenheit.Location = new System.Drawing.Point(224, 25);
            this.btnConvertFahrenheit.Name = "btnConvertFahrenheit";
            this.btnConvertFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btnConvertFahrenheit.TabIndex = 3;
            this.btnConvertFahrenheit.Text = "->";
            this.btnConvertFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Celsius";
            // 
            // txtFahrenheitACelsius
            // 
            this.txtFahrenheitACelsius.Location = new System.Drawing.Point(411, 27);
            this.txtFahrenheitACelsius.Name = "txtFahrenheitACelsius";
            this.txtFahrenheitACelsius.ReadOnly = true;
            this.txtFahrenheitACelsius.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitACelsius.TabIndex = 5;
            this.txtFahrenheitACelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFahrenheitAKelvin
            // 
            this.txtFahrenheitAKelvin.Location = new System.Drawing.Point(517, 27);
            this.txtFahrenheitAKelvin.Name = "txtFahrenheitAKelvin";
            this.txtFahrenheitAKelvin.ReadOnly = true;
            this.txtFahrenheitAKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitAKelvin.TabIndex = 6;
            this.txtFahrenheitAKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kelvin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fahrenheit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Celsius";
            // 
            // txtCelsiusAKelvin
            // 
            this.txtCelsiusAKelvin.Location = new System.Drawing.Point(517, 56);
            this.txtCelsiusAKelvin.Name = "txtCelsiusAKelvin";
            this.txtCelsiusAKelvin.ReadOnly = true;
            this.txtCelsiusAKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusAKelvin.TabIndex = 13;
            this.txtCelsiusAKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCelsiusACelsius
            // 
            this.txtCelsiusACelsius.Location = new System.Drawing.Point(411, 56);
            this.txtCelsiusACelsius.Name = "txtCelsiusACelsius";
            this.txtCelsiusACelsius.ReadOnly = true;
            this.txtCelsiusACelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusACelsius.TabIndex = 12;
            this.txtCelsiusACelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConvertCelsius
            // 
            this.btnConvertCelsius.Location = new System.Drawing.Point(224, 54);
            this.btnConvertCelsius.Name = "btnConvertCelsius";
            this.btnConvertCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnConvertCelsius.TabIndex = 11;
            this.btnConvertCelsius.Text = "->";
            this.btnConvertCelsius.UseVisualStyleBackColor = true;
            this.btnConvertCelsius.Click += new System.EventHandler(this.btnConvertCelsius_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(118, 56);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 10;
            this.txtCelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCelsiusAFahrenheit
            // 
            this.txtCelsiusAFahrenheit.Location = new System.Drawing.Point(305, 56);
            this.txtCelsiusAFahrenheit.Name = "txtCelsiusAFahrenheit";
            this.txtCelsiusAFahrenheit.ReadOnly = true;
            this.txtCelsiusAFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusAFahrenheit.TabIndex = 9;
            this.txtCelsiusAFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Kelvin";
            // 
            // txtKelvinAKelvin
            // 
            this.txtKelvinAKelvin.Location = new System.Drawing.Point(517, 85);
            this.txtKelvinAKelvin.Name = "txtKelvinAKelvin";
            this.txtKelvinAKelvin.ReadOnly = true;
            this.txtKelvinAKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtKelvinAKelvin.TabIndex = 19;
            this.txtKelvinAKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKelvinACelsius
            // 
            this.txtKelvinACelsius.Location = new System.Drawing.Point(411, 85);
            this.txtKelvinACelsius.Name = "txtKelvinACelsius";
            this.txtKelvinACelsius.ReadOnly = true;
            this.txtKelvinACelsius.Size = new System.Drawing.Size(100, 20);
            this.txtKelvinACelsius.TabIndex = 18;
            this.txtKelvinACelsius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConvertKelvin
            // 
            this.btnConvertKelvin.Location = new System.Drawing.Point(224, 83);
            this.btnConvertKelvin.Name = "btnConvertKelvin";
            this.btnConvertKelvin.Size = new System.Drawing.Size(75, 23);
            this.btnConvertKelvin.TabIndex = 17;
            this.btnConvertKelvin.Text = "->";
            this.btnConvertKelvin.UseVisualStyleBackColor = true;
            this.btnConvertKelvin.Click += new System.EventHandler(this.btnConvertKelvin_Click);
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(118, 85);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtKelvin.TabIndex = 16;
            this.txtKelvin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKelvinAFahrenheit
            // 
            this.txtKelvinAFahrenheit.Location = new System.Drawing.Point(305, 85);
            this.txtKelvinAFahrenheit.Name = "txtKelvinAFahrenheit";
            this.txtKelvinAFahrenheit.ReadOnly = true;
            this.txtKelvinAFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtKelvinAFahrenheit.TabIndex = 15;
            this.txtKelvinAFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 119);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKelvinAKelvin);
            this.Controls.Add(this.txtKelvinACelsius);
            this.Controls.Add(this.btnConvertKelvin);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtKelvinAFahrenheit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCelsiusAKelvin);
            this.Controls.Add(this.txtCelsiusACelsius);
            this.Controls.Add(this.btnConvertCelsius);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtCelsiusAFahrenheit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFahrenheitAKelvin);
            this.Controls.Add(this.txtFahrenheitACelsius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvertFahrenheit);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtFahrenheitAFahrenheit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFahrenheitAFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnConvertFahrenheit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFahrenheitACelsius;
        private System.Windows.Forms.TextBox txtFahrenheitAKelvin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCelsiusAKelvin;
        private System.Windows.Forms.TextBox txtCelsiusACelsius;
        private System.Windows.Forms.Button btnConvertCelsius;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtCelsiusAFahrenheit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKelvinAKelvin;
        private System.Windows.Forms.TextBox txtKelvinACelsius;
        private System.Windows.Forms.Button btnConvertKelvin;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtKelvinAFahrenheit;
    }
}

