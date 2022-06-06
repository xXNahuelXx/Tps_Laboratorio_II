namespace GliottiCom
{
    partial class FrmModificarCliente
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
            this.lblCelularError = new System.Windows.Forms.Label();
            this.lblDniError = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtModMail = new System.Windows.Forms.TextBox();
            this.txtModDireccion = new System.Windows.Forms.TextBox();
            this.cmbModPlan = new System.Windows.Forms.ComboBox();
            this.cmbModCompania = new System.Windows.Forms.ComboBox();
            this.txtModCelular = new System.Windows.Forms.TextBox();
            this.txtModDni = new System.Windows.Forms.TextBox();
            this.txtModApellido = new System.Windows.Forms.TextBox();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblComaniaMovil = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDniClienteABuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCelularError
            // 
            this.lblCelularError.AutoSize = true;
            this.lblCelularError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCelularError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCelularError.Location = new System.Drawing.Point(112, 134);
            this.lblCelularError.Name = "lblCelularError";
            this.lblCelularError.Size = new System.Drawing.Size(17, 21);
            this.lblCelularError.TabIndex = 42;
            this.lblCelularError.Text = "*";
            // 
            // lblDniError
            // 
            this.lblDniError.AutoSize = true;
            this.lblDniError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDniError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDniError.Location = new System.Drawing.Point(112, 104);
            this.lblDniError.Name = "lblDniError";
            this.lblDniError.Size = new System.Drawing.Size(17, 21);
            this.lblDniError.TabIndex = 41;
            this.lblDniError.Text = "*";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(208, 282);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(110, 30);
            this.btnGuardarCambios.TabIndex = 40;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // txtModMail
            // 
            this.txtModMail.Location = new System.Drawing.Point(135, 247);
            this.txtModMail.Name = "txtModMail";
            this.txtModMail.Size = new System.Drawing.Size(100, 23);
            this.txtModMail.TabIndex = 39;
            // 
            // txtModDireccion
            // 
            this.txtModDireccion.Location = new System.Drawing.Point(135, 218);
            this.txtModDireccion.Name = "txtModDireccion";
            this.txtModDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtModDireccion.TabIndex = 38;
            // 
            // cmbModPlan
            // 
            this.cmbModPlan.FormattingEnabled = true;
            this.cmbModPlan.Items.AddRange(new object[] {
            "Sin Plan",
            "Basico",
            "Avanzado",
            "Premium"});
            this.cmbModPlan.Location = new System.Drawing.Point(135, 189);
            this.cmbModPlan.Name = "cmbModPlan";
            this.cmbModPlan.Size = new System.Drawing.Size(100, 23);
            this.cmbModPlan.TabIndex = 37;
            // 
            // cmbModCompania
            // 
            this.cmbModCompania.FormattingEnabled = true;
            this.cmbModCompania.Items.AddRange(new object[] {
            "Claro",
            "Movistar",
            "Personal",
            "TMobile",
            "GliottiCom"});
            this.cmbModCompania.Location = new System.Drawing.Point(135, 160);
            this.cmbModCompania.Name = "cmbModCompania";
            this.cmbModCompania.Size = new System.Drawing.Size(100, 23);
            this.cmbModCompania.TabIndex = 36;
            // 
            // txtModCelular
            // 
            this.txtModCelular.Location = new System.Drawing.Point(135, 131);
            this.txtModCelular.Name = "txtModCelular";
            this.txtModCelular.Size = new System.Drawing.Size(100, 23);
            this.txtModCelular.TabIndex = 35;
            // 
            // txtModDni
            // 
            this.txtModDni.Location = new System.Drawing.Point(135, 102);
            this.txtModDni.Name = "txtModDni";
            this.txtModDni.Size = new System.Drawing.Size(100, 23);
            this.txtModDni.TabIndex = 34;
            // 
            // txtModApellido
            // 
            this.txtModApellido.Location = new System.Drawing.Point(135, 73);
            this.txtModApellido.Name = "txtModApellido";
            this.txtModApellido.Size = new System.Drawing.Size(100, 23);
            this.txtModApellido.TabIndex = 33;
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(135, 44);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(100, 23);
            this.txtModNombre.TabIndex = 32;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 255);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 15);
            this.lblMail.TabIndex = 31;
            this.lblMail.Text = "Mail:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 226);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 30;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(12, 197);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(33, 15);
            this.lblPlan.TabIndex = 29;
            this.lblPlan.Text = "Plan:";
            // 
            // lblComaniaMovil
            // 
            this.lblComaniaMovil.AutoSize = true;
            this.lblComaniaMovil.Location = new System.Drawing.Point(12, 168);
            this.lblComaniaMovil.Name = "lblComaniaMovil";
            this.lblComaniaMovil.Size = new System.Drawing.Size(65, 15);
            this.lblComaniaMovil.TabIndex = 28;
            this.lblComaniaMovil.Text = "Compañia:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(12, 139);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(47, 15);
            this.lblCelular.TabIndex = 27;
            this.lblCelular.Text = "Celular:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 110);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(28, 15);
            this.lblDni.TabIndex = 26;
            this.lblDni.Text = "Dni:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 81);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDniClienteABuscar
            // 
            this.txtDniClienteABuscar.Location = new System.Drawing.Point(135, 15);
            this.txtDniClienteABuscar.Name = "txtDniClienteABuscar";
            this.txtDniClienteABuscar.Size = new System.Drawing.Size(100, 23);
            this.txtDniClienteABuscar.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Dni Cliente a Buscar:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(241, 15);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(86, 23);
            this.btnBuscarCliente.TabIndex = 45;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(112, 282);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 30);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 324);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDniClienteABuscar);
            this.Controls.Add(this.lblCelularError);
            this.Controls.Add(this.lblDniError);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.txtModMail);
            this.Controls.Add(this.txtModDireccion);
            this.Controls.Add(this.cmbModPlan);
            this.Controls.Add(this.cmbModCompania);
            this.Controls.Add(this.txtModCelular);
            this.Controls.Add(this.txtModDni);
            this.Controls.Add(this.txtModApellido);
            this.Controls.Add(this.txtModNombre);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblComaniaMovil);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.FrmModificarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelularError;
        private System.Windows.Forms.Label lblDniError;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtModMail;
        private System.Windows.Forms.TextBox txtModDireccion;
        private System.Windows.Forms.ComboBox cmbModPlan;
        private System.Windows.Forms.ComboBox cmbModCompania;
        private System.Windows.Forms.TextBox txtModCelular;
        private System.Windows.Forms.TextBox txtModDni;
        private System.Windows.Forms.TextBox txtModApellido;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblComaniaMovil;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDniClienteABuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnModificar;
    }
}