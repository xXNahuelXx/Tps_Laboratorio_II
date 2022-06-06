namespace GliottiCom
{
    partial class FrmAltaCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblComaniaMovil = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.cmbCompania = new System.Windows.Forms.ComboBox();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblDniError = new System.Windows.Forms.Label();
            this.lblCelularError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 47);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 76);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(28, 15);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "Dni:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(12, 105);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(47, 15);
            this.lblCelular.TabIndex = 3;
            this.lblCelular.Text = "Celular:";
            // 
            // lblComaniaMovil
            // 
            this.lblComaniaMovil.AutoSize = true;
            this.lblComaniaMovil.Location = new System.Drawing.Point(12, 134);
            this.lblComaniaMovil.Name = "lblComaniaMovil";
            this.lblComaniaMovil.Size = new System.Drawing.Size(65, 15);
            this.lblComaniaMovil.TabIndex = 4;
            this.lblComaniaMovil.Text = "Compañia:";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(12, 163);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(33, 15);
            this.lblPlan.TabIndex = 5;
            this.lblPlan.Text = "Plan:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 192);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 221);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 15);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(135, 39);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 13;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(135, 68);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 14;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(135, 97);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 23);
            this.txtCelular.TabIndex = 15;
            // 
            // cmbCompania
            // 
            this.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompania.FormattingEnabled = true;
            this.cmbCompania.Items.AddRange(new object[] {
            "Claro",
            "Movistar",
            "Personal",
            "TMobile",
            "GliottiCom"});
            this.cmbCompania.Location = new System.Drawing.Point(135, 126);
            this.cmbCompania.Name = "cmbCompania";
            this.cmbCompania.Size = new System.Drawing.Size(100, 23);
            this.cmbCompania.TabIndex = 16;
            // 
            // cmbPlan
            // 
            this.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Items.AddRange(new object[] {
            "Sin Plan",
            "Basico",
            "Avanzado",
            "Premium"});
            this.cmbPlan.Location = new System.Drawing.Point(135, 155);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(100, 23);
            this.cmbPlan.TabIndex = 17;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(135, 184);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 18;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(135, 213);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 23);
            this.txtMail.TabIndex = 19;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(135, 256);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblDniError
            // 
            this.lblDniError.AutoSize = true;
            this.lblDniError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDniError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDniError.Location = new System.Drawing.Point(112, 70);
            this.lblDniError.Name = "lblDniError";
            this.lblDniError.Size = new System.Drawing.Size(17, 21);
            this.lblDniError.TabIndex = 22;
            this.lblDniError.Text = "*";
            // 
            // lblCelularError
            // 
            this.lblCelularError.AutoSize = true;
            this.lblCelularError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCelularError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCelularError.Location = new System.Drawing.Point(112, 100);
            this.lblCelularError.Name = "lblCelularError";
            this.lblCelularError.Size = new System.Drawing.Size(17, 21);
            this.lblCelularError.TabIndex = 23;
            this.lblCelularError.Text = "*";
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 286);
            this.Controls.Add(this.lblCelularError);
            this.Controls.Add(this.lblDniError);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbPlan);
            this.Controls.Add(this.cmbCompania);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblComaniaMovil);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaCliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblComaniaMovil;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.ComboBox cmbCompania;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblDniError;
        private System.Windows.Forms.Label lblCelularError;
    }
}