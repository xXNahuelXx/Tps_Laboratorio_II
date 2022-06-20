namespace GliottiCom
{
    partial class FrmLlamar
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
            this.btnCortar = new System.Windows.Forms.Button();
            this.lblEnLlamada = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCortar
            // 
            this.btnCortar.Location = new System.Drawing.Point(188, 50);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(67, 25);
            this.btnCortar.TabIndex = 1;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = true;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // lblEnLlamada
            // 
            this.lblEnLlamada.AutoSize = true;
            this.lblEnLlamada.Location = new System.Drawing.Point(18, 23);
            this.lblEnLlamada.Name = "lblEnLlamada";
            this.lblEnLlamada.Size = new System.Drawing.Size(68, 15);
            this.lblEnLlamada.TabIndex = 2;
            this.lblEnLlamada.Text = "En llamada:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(18, 50);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(0, 15);
            this.lblDuracion.TabIndex = 3;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(88, 23);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 15);
            this.lblNumero.TabIndex = 4;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(188, 19);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(67, 25);
            this.btnCopiar.TabIndex = 5;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // FrmLlamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 90);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblEnLlamada);
            this.Controls.Add(this.btnCortar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLlamar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Llamador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLlamar_FormClosing);
            this.Load += new System.EventHandler(this.FrmLlamar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Label lblEnLlamada;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnCopiar;
    }
}