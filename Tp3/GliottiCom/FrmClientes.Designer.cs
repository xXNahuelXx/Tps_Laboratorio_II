namespace GliottiCom
{
    partial class FrmClientes
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
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnBajaCliente = new System.Windows.Forms.Button();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(36, 21);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(113, 23);
            this.btnAltaCliente.TabIndex = 0;
            this.btnAltaCliente.Text = "Nuevo Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(36, 60);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(113, 23);
            this.btnModificarCliente.TabIndex = 1;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnBajaCliente
            // 
            this.btnBajaCliente.Location = new System.Drawing.Point(36, 100);
            this.btnBajaCliente.Name = "btnBajaCliente";
            this.btnBajaCliente.Size = new System.Drawing.Size(113, 23);
            this.btnBajaCliente.TabIndex = 2;
            this.btnBajaCliente.Text = "Baja Cliente";
            this.btnBajaCliente.UseVisualStyleBackColor = true;
            this.btnBajaCliente.Click += new System.EventHandler(this.btnBajaCliente_Click);
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(36, 139);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(113, 23);
            this.btnListarClientes.TabIndex = 3;
            this.btnListarClientes.Text = "Lista Clientes ";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 183);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.btnBajaCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnAltaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnBajaCliente;
        private System.Windows.Forms.Button btnListarClientes;
    }
}