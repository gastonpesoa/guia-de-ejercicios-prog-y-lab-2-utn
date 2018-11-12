namespace Ej_69_MDI_eventos
{
    partial class FrmTestDelegados
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
            this.txtActualizar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtActualizar
            // 
            this.txtActualizar.Location = new System.Drawing.Point(49, 32);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(159, 20);
            this.txtActualizar.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(49, 71);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(159, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.Location = new System.Drawing.Point(49, 101);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(159, 23);
            this.btnBuscarFoto.TabIndex = 3;
            this.btnBuscarFoto.Text = "Buscar";
            this.btnBuscarFoto.UseVisualStyleBackColor = true;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmTestDelegados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 282);
            this.Controls.Add(this.btnBuscarFoto);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtActualizar);
            this.Name = "FrmTestDelegados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTestDelegados";
            this.Load += new System.EventHandler(this.FrmTestDelegados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}