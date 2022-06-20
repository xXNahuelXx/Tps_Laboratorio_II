namespace GliottiCom
{
    partial class FrmListaClientes
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
            this.rtbListadoClientes = new System.Windows.Forms.RichTextBox();
            this.lblClientesTotales = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbListadoClientes
            // 
            this.rtbListadoClientes.Location = new System.Drawing.Point(6, 31);
            this.rtbListadoClientes.Name = "rtbListadoClientes";
            this.rtbListadoClientes.Size = new System.Drawing.Size(782, 407);
            this.rtbListadoClientes.TabIndex = 0;
            this.rtbListadoClientes.Text = "";
            // 
            // lblClientesTotales
            // 
            this.lblClientesTotales.AutoSize = true;
            this.lblClientesTotales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientesTotales.Location = new System.Drawing.Point(257, 9);
            this.lblClientesTotales.Name = "lblClientesTotales";
            this.lblClientesTotales.Size = new System.Drawing.Size(199, 15);
            this.lblClientesTotales.TabIndex = 1;
            this.lblClientesTotales.Text = "CANTIDAD DE CLIENTES TOTALES: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(462, 9);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 15);
            this.lblCantidad.TabIndex = 2;
            // 
            // FrmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblClientesTotales);
            this.Controls.Add(this.rtbListadoClientes);
            this.Name = "FrmListaClientes";
            this.Text = "FrmListaClientes";
            this.Load += new System.EventHandler(this.FrmListaClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListadoClientes;
        private System.Windows.Forms.Label lblClientesTotales;
        private System.Windows.Forms.Label lblCantidad;
    }
}