namespace ColasFIFO
{
    partial class frmPrincipal
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
            this.btnSimulacion = new System.Windows.Forms.Button();
            this.txbResultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSimulacion
            // 
            this.btnSimulacion.Location = new System.Drawing.Point(13, 14);
            this.btnSimulacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimulacion.Name = "btnSimulacion";
            this.btnSimulacion.Size = new System.Drawing.Size(264, 35);
            this.btnSimulacion.TabIndex = 0;
            this.btnSimulacion.Text = "&Iniciar simulacion 200 ciclos";
            this.btnSimulacion.UseVisualStyleBackColor = true;
            this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
            // 
            // txbResultados
            // 
            this.txbResultados.Enabled = false;
            this.txbResultados.Location = new System.Drawing.Point(13, 80);
            this.txbResultados.Multiline = true;
            this.txbResultados.Name = "txbResultados";
            this.txbResultados.Size = new System.Drawing.Size(264, 129);
            this.txbResultados.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AcceptButton = this.btnSimulacion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 280);
            this.Controls.Add(this.txbResultados);
            this.Controls.Add(this.btnSimulacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimulacion;
        private System.Windows.Forms.TextBox txbResultados;
    }
}

