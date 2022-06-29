namespace GliottiCom
{
    partial class FrmBajaCliente
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
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDniClienteABuscar = new System.Windows.Forms.TextBox();
            this.lblCelularError = new System.Windows.Forms.Label();
            this.lblDniError = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBajaMail = new System.Windows.Forms.TextBox();
            this.txtBajaDireccion = new System.Windows.Forms.TextBox();
            this.cmbBajaPlan = new System.Windows.Forms.ComboBox();
            this.cmbBajaCompania = new System.Windows.Forms.ComboBox();
            this.txtBajaCelular = new System.Windows.Forms.TextBox();
            this.txtBajaDni = new System.Windows.Forms.TextBox();
            this.txtBajaApellido = new System.Windows.Forms.TextBox();
            this.txtBajaNombre = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblComaniaMovil = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(244, 12);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(86, 23);
            this.btnBuscarCliente.TabIndex = 68;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 67;
            this.label1.Text = "Dni Cliente a Buscar:";
            // 
            // txtDniClienteABuscar
            // 
            this.txtDniClienteABuscar.Location = new System.Drawing.Point(138, 12);
            this.txtDniClienteABuscar.Name = "txtDniClienteABuscar";
            this.txtDniClienteABuscar.Size = new System.Drawing.Size(100, 23);
            this.txtDniClienteABuscar.TabIndex = 66;
            // 
            // lblCelularError
            // 
            this.lblCelularError.AutoSize = true;
            this.lblCelularError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCelularError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCelularError.Location = new System.Drawing.Point(115, 131);
            this.lblCelularError.Name = "lblCelularError";
            this.lblCelularError.Size = new System.Drawing.Size(17, 21);
            this.lblCelularError.TabIndex = 65;
            this.lblCelularError.Text = "*";
            // 
            // lblDniError
            // 
            this.lblDniError.AutoSize = true;
            this.lblDniError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDniError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDniError.Location = new System.Drawing.Point(115, 101);
            this.lblDniError.Name = "lblDniError";
            this.lblDniError.Size = new System.Drawing.Size(17, 21);
            this.lblDniError.TabIndex = 64;
            this.lblDniError.Text = "*";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(211, 279);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 30);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBajaMail
            // 
            this.txtBajaMail.Location = new System.Drawing.Point(138, 244);
            this.txtBajaMail.Name = "txtBajaMail";
            this.txtBajaMail.Size = new System.Drawing.Size(100, 23);
            this.txtBajaMail.TabIndex = 62;
            // 
            // txtBajaDireccion
            // 
            this.txtBajaDireccion.Location = new System.Drawing.Point(138, 215);
            this.txtBajaDireccion.Name = "txtBajaDireccion";
            this.txtBajaDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtBajaDireccion.TabIndex = 61;
            // 
            // cmbBajaPlan
            // 
            this.cmbBajaPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBajaPlan.FormattingEnabled = true;
            this.cmbBajaPlan.Items.AddRange(new object[] {
            "Sin Plan",
            "Basico",
            "Avanzado",
            "Premium"});
            this.cmbBajaPlan.Location = new System.Drawing.Point(138, 186);
            this.cmbBajaPlan.Name = "cmbBajaPlan";
            this.cmbBajaPlan.Size = new System.Drawing.Size(100, 23);
            this.cmbBajaPlan.TabIndex = 60;
            // 
            // cmbBajaCompania
            // 
            this.cmbBajaCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBajaCompania.FormattingEnabled = true;
            this.cmbBajaCompania.Items.AddRange(new object[] {
            "Claro",
            "Movistar",
            "Personal",
            "TMobile",
            "GliottiCom"});
            this.cmbBajaCompania.Location = new System.Drawing.Point(138, 157);
            this.cmbBajaCompania.Name = "cmbBajaCompania";
            this.cmbBajaCompania.Size = new System.Drawing.Size(100, 23);
            this.cmbBajaCompania.TabIndex = 59;
            // 
            // txtBajaCelular
            // 
            this.txtBajaCelular.Location = new System.Drawing.Point(138, 128);
            this.txtBajaCelular.Name = "txtBajaCelular";
            this.txtBajaCelular.Size = new System.Drawing.Size(100, 23);
            this.txtBajaCelular.TabIndex = 58;
            // 
            // txtBajaDni
            // 
            this.txtBajaDni.Location = new System.Drawing.Point(138, 99);
            this.txtBajaDni.Name = "txtBajaDni";
            this.txtBajaDni.Size = new System.Drawing.Size(100, 23);
            this.txtBajaDni.TabIndex = 57;
            // 
            // txtBajaApellido
            // 
            this.txtBajaApellido.Location = new System.Drawing.Point(138, 70);
            this.txtBajaApellido.Name = "txtBajaApellido";
            this.txtBajaApellido.Size = new System.Drawing.Size(100, 23);
            this.txtBajaApellido.TabIndex = 56;
            // 
            // txtBajaNombre
            // 
            this.txtBajaNombre.Location = new System.Drawing.Point(138, 41);
            this.txtBajaNombre.Name = "txtBajaNombre";
            this.txtBajaNombre.Size = new System.Drawing.Size(100, 23);
            this.txtBajaNombre.TabIndex = 55;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(15, 252);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 15);
            this.lblMail.TabIndex = 54;
            this.lblMail.Text = "Mail:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(15, 223);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 53;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(15, 194);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(33, 15);
            this.lblPlan.TabIndex = 52;
            this.lblPlan.Text = "Plan:";
            // 
            // lblComaniaMovil
            // 
            this.lblComaniaMovil.AutoSize = true;
            this.lblComaniaMovil.Location = new System.Drawing.Point(15, 165);
            this.lblComaniaMovil.Name = "lblComaniaMovil";
            this.lblComaniaMovil.Size = new System.Drawing.Size(65, 15);
            this.lblComaniaMovil.TabIndex = 51;
            this.lblComaniaMovil.Text = "Compañia:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(15, 136);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(47, 15);
            this.lblCelular.TabIndex = 50;
            this.lblCelular.Text = "Celular:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(15, 107);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(28, 15);
            this.lblDni.TabIndex = 49;
            this.lblDni.Text = "Dni:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 78);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 48;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Nombre:";
            // 
            // FrmBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 313);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDniClienteABuscar);
            this.Controls.Add(this.lblCelularError);
            this.Controls.Add(this.lblDniError);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBajaMail);
            this.Controls.Add(this.txtBajaDireccion);
            this.Controls.Add(this.cmbBajaPlan);
            this.Controls.Add(this.cmbBajaCompania);
            this.Controls.Add(this.txtBajaCelular);
            this.Controls.Add(this.txtBajaDni);
            this.Controls.Add(this.txtBajaApellido);
            this.Controls.Add(this.txtBajaNombre);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblComaniaMovil);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmBajaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elimimar Cliente";
            this.Load += new System.EventHandler(this.FrmBajaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDniClienteABuscar;
        private System.Windows.Forms.Label lblCelularError;
        private System.Windows.Forms.Label lblDniError;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBajaMail;
        private System.Windows.Forms.TextBox txtBajaDireccion;
        private System.Windows.Forms.ComboBox cmbBajaPlan;
        private System.Windows.Forms.ComboBox cmbBajaCompania;
        private System.Windows.Forms.TextBox txtBajaCelular;
        private System.Windows.Forms.TextBox txtBajaDni;
        private System.Windows.Forms.TextBox txtBajaApellido;
        private System.Windows.Forms.TextBox txtBajaNombre;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblComaniaMovil;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
    }
}