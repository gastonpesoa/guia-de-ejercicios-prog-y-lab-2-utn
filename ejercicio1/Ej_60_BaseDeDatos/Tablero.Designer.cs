namespace Ej_60_BaseDeDatos
{
    partial class Tablero
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
            this.productFoundListbox = new System.Windows.Forms.ListBox();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.buscarBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productFoundListbox
            // 
            this.productFoundListbox.FormattingEnabled = true;
            this.productFoundListbox.ItemHeight = 24;
            this.productFoundListbox.Location = new System.Drawing.Point(92, 167);
            this.productFoundListbox.Name = "productFoundListbox";
            this.productFoundListbox.Size = new System.Drawing.Size(498, 124);
            this.productFoundListbox.TabIndex = 0;
            // 
            // productNameText
            // 
            this.productNameText.Location = new System.Drawing.Point(256, 34);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(269, 29);
            this.productNameText.TabIndex = 1;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(88, 37);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(131, 24);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Product Name";
            // 
            // buscarBoton
            // 
            this.buscarBoton.Location = new System.Drawing.Point(213, 93);
            this.buscarBoton.Name = "buscarBoton";
            this.buscarBoton.Size = new System.Drawing.Size(233, 40);
            this.buscarBoton.TabIndex = 3;
            this.buscarBoton.Text = "Buscar";
            this.buscarBoton.UseVisualStyleBackColor = true;
            this.buscarBoton.Click += new System.EventHandler(this.buscarBoton_Click);
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 471);
            this.Controls.Add(this.buscarBoton);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productNameText);
            this.Controls.Add(this.productFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Tablero";
            this.Text = "SQL Data Acceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productFoundListbox;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Button buscarBoton;
    }
}

