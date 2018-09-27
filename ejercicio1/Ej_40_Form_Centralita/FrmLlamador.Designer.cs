namespace Ej_40_Form_Centralita
{
    partial class FrmLlamador
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
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.txtNumeroDestino = new System.Windows.Forms.TextBox();
            this.gbPanel = new System.Windows.Forms.GroupBox();
            this.btnPanelAsterisco = new System.Windows.Forms.Button();
            this.btnPanel0 = new System.Windows.Forms.Button();
            this.btnPanelNumeral = new System.Windows.Forms.Button();
            this.btnPanel9 = new System.Windows.Forms.Button();
            this.btnPanel8 = new System.Windows.Forms.Button();
            this.btnPanel7 = new System.Windows.Forms.Button();
            this.btnPanel4 = new System.Windows.Forms.Button();
            this.btnPanel5 = new System.Windows.Forms.Button();
            this.btnPanel6 = new System.Windows.Forms.Button();
            this.btnPanel3 = new System.Windows.Forms.Button();
            this.btnPanel2 = new System.Windows.Forms.Button();
            this.btnPanel1 = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNumeroOrigen = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFranja
            // 
            this.cmbFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(13, 311);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(293, 24);
            this.cmbFranja.TabIndex = 0;
            this.cmbFranja.Text = "Franja";
            // 
            // txtNumeroDestino
            // 
            this.txtNumeroDestino.BackColor = System.Drawing.Color.White;
            this.txtNumeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDestino.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNumeroDestino.Location = new System.Drawing.Point(13, 13);
            this.txtNumeroDestino.Name = "txtNumeroDestino";
            this.txtNumeroDestino.ReadOnly = true;
            this.txtNumeroDestino.Size = new System.Drawing.Size(293, 31);
            this.txtNumeroDestino.TabIndex = 1;
            // 
            // gbPanel
            // 
            this.gbPanel.Controls.Add(this.btnPanelAsterisco);
            this.gbPanel.Controls.Add(this.btnPanel0);
            this.gbPanel.Controls.Add(this.btnPanelNumeral);
            this.gbPanel.Controls.Add(this.btnPanel9);
            this.gbPanel.Controls.Add(this.btnPanel8);
            this.gbPanel.Controls.Add(this.btnPanel7);
            this.gbPanel.Controls.Add(this.btnPanel4);
            this.gbPanel.Controls.Add(this.btnPanel5);
            this.gbPanel.Controls.Add(this.btnPanel6);
            this.gbPanel.Controls.Add(this.btnPanel3);
            this.gbPanel.Controls.Add(this.btnPanel2);
            this.gbPanel.Controls.Add(this.btnPanel1);
            this.gbPanel.Location = new System.Drawing.Point(13, 52);
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.Size = new System.Drawing.Size(177, 253);
            this.gbPanel.TabIndex = 2;
            this.gbPanel.TabStop = false;
            this.gbPanel.Text = "Panel";
            // 
            // btnPanelAsterisco
            // 
            this.btnPanelAsterisco.Location = new System.Drawing.Point(6, 188);
            this.btnPanelAsterisco.Name = "btnPanelAsterisco";
            this.btnPanelAsterisco.Size = new System.Drawing.Size(50, 50);
            this.btnPanelAsterisco.TabIndex = 11;
            this.btnPanelAsterisco.Text = "*";
            this.btnPanelAsterisco.UseVisualStyleBackColor = true;
            this.btnPanelAsterisco.Click += new System.EventHandler(this.btnPanelAsterisco_Click);
            // 
            // btnPanel0
            // 
            this.btnPanel0.Location = new System.Drawing.Point(64, 188);
            this.btnPanel0.Name = "btnPanel0";
            this.btnPanel0.Size = new System.Drawing.Size(50, 50);
            this.btnPanel0.TabIndex = 10;
            this.btnPanel0.Text = "0";
            this.btnPanel0.UseVisualStyleBackColor = true;
            this.btnPanel0.Click += new System.EventHandler(this.btnPanel0_Click);
            // 
            // btnPanelNumeral
            // 
            this.btnPanelNumeral.Location = new System.Drawing.Point(118, 188);
            this.btnPanelNumeral.Name = "btnPanelNumeral";
            this.btnPanelNumeral.Size = new System.Drawing.Size(50, 50);
            this.btnPanelNumeral.TabIndex = 9;
            this.btnPanelNumeral.Text = "#";
            this.btnPanelNumeral.UseVisualStyleBackColor = true;
            this.btnPanelNumeral.Click += new System.EventHandler(this.btnPanelNumeral_Click);
            // 
            // btnPanel9
            // 
            this.btnPanel9.Location = new System.Drawing.Point(118, 132);
            this.btnPanel9.Name = "btnPanel9";
            this.btnPanel9.Size = new System.Drawing.Size(50, 50);
            this.btnPanel9.TabIndex = 8;
            this.btnPanel9.Text = "9";
            this.btnPanel9.UseVisualStyleBackColor = true;
            this.btnPanel9.Click += new System.EventHandler(this.btnPanel9_Click);
            // 
            // btnPanel8
            // 
            this.btnPanel8.Location = new System.Drawing.Point(63, 132);
            this.btnPanel8.Name = "btnPanel8";
            this.btnPanel8.Size = new System.Drawing.Size(50, 50);
            this.btnPanel8.TabIndex = 7;
            this.btnPanel8.Text = "8";
            this.btnPanel8.UseVisualStyleBackColor = true;
            this.btnPanel8.Click += new System.EventHandler(this.btnPanel8_Click);
            // 
            // btnPanel7
            // 
            this.btnPanel7.Location = new System.Drawing.Point(7, 132);
            this.btnPanel7.Name = "btnPanel7";
            this.btnPanel7.Size = new System.Drawing.Size(50, 50);
            this.btnPanel7.TabIndex = 6;
            this.btnPanel7.Text = "7";
            this.btnPanel7.UseVisualStyleBackColor = true;
            this.btnPanel7.Click += new System.EventHandler(this.btnPanel7_Click);
            // 
            // btnPanel4
            // 
            this.btnPanel4.Location = new System.Drawing.Point(6, 76);
            this.btnPanel4.Name = "btnPanel4";
            this.btnPanel4.Size = new System.Drawing.Size(50, 50);
            this.btnPanel4.TabIndex = 5;
            this.btnPanel4.Text = "4";
            this.btnPanel4.UseVisualStyleBackColor = true;
            this.btnPanel4.Click += new System.EventHandler(this.btnPanel4_Click);
            // 
            // btnPanel5
            // 
            this.btnPanel5.Location = new System.Drawing.Point(62, 76);
            this.btnPanel5.Name = "btnPanel5";
            this.btnPanel5.Size = new System.Drawing.Size(50, 50);
            this.btnPanel5.TabIndex = 4;
            this.btnPanel5.Text = "5";
            this.btnPanel5.UseVisualStyleBackColor = true;
            this.btnPanel5.Click += new System.EventHandler(this.btnPanel5_Click);
            // 
            // btnPanel6
            // 
            this.btnPanel6.Location = new System.Drawing.Point(118, 76);
            this.btnPanel6.Name = "btnPanel6";
            this.btnPanel6.Size = new System.Drawing.Size(50, 50);
            this.btnPanel6.TabIndex = 3;
            this.btnPanel6.Text = "6";
            this.btnPanel6.UseVisualStyleBackColor = true;
            this.btnPanel6.Click += new System.EventHandler(this.btnPanel6_Click);
            // 
            // btnPanel3
            // 
            this.btnPanel3.Location = new System.Drawing.Point(119, 20);
            this.btnPanel3.Name = "btnPanel3";
            this.btnPanel3.Size = new System.Drawing.Size(50, 50);
            this.btnPanel3.TabIndex = 2;
            this.btnPanel3.Text = "3";
            this.btnPanel3.UseVisualStyleBackColor = true;
            this.btnPanel3.Click += new System.EventHandler(this.btnPanel3_Click);
            // 
            // btnPanel2
            // 
            this.btnPanel2.Location = new System.Drawing.Point(63, 19);
            this.btnPanel2.Name = "btnPanel2";
            this.btnPanel2.Size = new System.Drawing.Size(50, 50);
            this.btnPanel2.TabIndex = 1;
            this.btnPanel2.Text = "2";
            this.btnPanel2.UseVisualStyleBackColor = true;
            this.btnPanel2.Click += new System.EventHandler(this.btnPanel2_Click);
            // 
            // btnPanel1
            // 
            this.btnPanel1.Location = new System.Drawing.Point(7, 20);
            this.btnPanel1.Name = "btnPanel1";
            this.btnPanel1.Size = new System.Drawing.Size(50, 50);
            this.btnPanel1.TabIndex = 0;
            this.btnPanel1.Text = "1";
            this.btnPanel1.UseVisualStyleBackColor = true;
            this.btnPanel1.Click += new System.EventHandler(this.btnPanel1_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(196, 72);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(110, 50);
            this.btnLlamar.TabIndex = 3;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(196, 128);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 50);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNumeroOrigen
            // 
            this.txtNumeroOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOrigen.Location = new System.Drawing.Point(197, 200);
            this.txtNumeroOrigen.Name = "txtNumeroOrigen";
            this.txtNumeroOrigen.Size = new System.Drawing.Size(109, 22);
            this.txtNumeroOrigen.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(197, 240);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 343);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNumeroOrigen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.gbPanel);
            this.Controls.Add(this.txtNumeroDestino);
            this.Controls.Add(this.cmbFranja);
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.gbPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.TextBox txtNumeroDestino;
        private System.Windows.Forms.GroupBox gbPanel;
        private System.Windows.Forms.Button btnPanelAsterisco;
        private System.Windows.Forms.Button btnPanel0;
        private System.Windows.Forms.Button btnPanelNumeral;
        private System.Windows.Forms.Button btnPanel9;
        private System.Windows.Forms.Button btnPanel8;
        private System.Windows.Forms.Button btnPanel7;
        private System.Windows.Forms.Button btnPanel4;
        private System.Windows.Forms.Button btnPanel5;
        private System.Windows.Forms.Button btnPanel6;
        private System.Windows.Forms.Button btnPanel3;
        private System.Windows.Forms.Button btnPanel2;
        private System.Windows.Forms.Button btnPanel1;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNumeroOrigen;
        private System.Windows.Forms.Button btnSalir;
    }
}