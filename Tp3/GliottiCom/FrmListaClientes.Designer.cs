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
            this.SuspendLayout();
            // 
            // rtbListadoClientes
            // 
            this.rtbListadoClientes.Location = new System.Drawing.Point(6, 15);
            this.rtbListadoClientes.Name = "rtbListadoClientes";
            this.rtbListadoClientes.Size = new System.Drawing.Size(782, 423);
            this.rtbListadoClientes.TabIndex = 0;
            this.rtbListadoClientes.Text = "";
            this.rtbListadoClientes.TextChanged += new System.EventHandler(this.rtbListadoClientes_TextChanged);
            // 
            // FrmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbListadoClientes);
            this.Name = "FrmListaClientes";
            this.Text = "FrmListaClientes";
            this.Load += new System.EventHandler(this.FrmListaClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListadoClientes;
    }
}