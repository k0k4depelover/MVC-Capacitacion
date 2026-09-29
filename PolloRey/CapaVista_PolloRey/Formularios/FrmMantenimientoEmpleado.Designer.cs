namespace CapaVista_PolloRey.Formularios
{
    partial class FrmMantenimientoEmpleado
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.IdPuesto = new System.Windows.Forms.Label();
            this.Sucursal = new System.Windows.Forms.Label();
            this.Cumpleanos = new System.Windows.Forms.Label();
            this.Dpi = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.textBoxIdPuesto = new System.Windows.Forms.TextBox();
            this.textBoxSucursal = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxDpi = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCumpleanos = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.GridEmpleados = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panIngresoDatos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpleados)).BeginInit();
            this.panIngresoDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(430, 303);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 38);
            this.btnNuevo.TabIndex = 46;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(303, 303);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 38);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(187, 303);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 38);
            this.btnBorrar.TabIndex = 44;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(492, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 38);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(27, 39);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(448, 22);
            this.textBoxBuscar.TabIndex = 42;
            // 
            // IdPuesto
            // 
            this.IdPuesto.AutoSize = true;
            this.IdPuesto.Location = new System.Drawing.Point(16, 318);
            this.IdPuesto.Name = "IdPuesto";
            this.IdPuesto.Size = new System.Drawing.Size(60, 16);
            this.IdPuesto.TabIndex = 41;
            this.IdPuesto.Text = "IdPuesto";
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSize = true;
            this.Sucursal.Location = new System.Drawing.Point(14, 274);
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Size = new System.Drawing.Size(59, 16);
            this.Sucursal.TabIndex = 40;
            this.Sucursal.Text = "Sucursal";
            // 
            // Cumpleanos
            // 
            this.Cumpleanos.AutoSize = true;
            this.Cumpleanos.Location = new System.Drawing.Point(16, 226);
            this.Cumpleanos.Name = "Cumpleanos";
            this.Cumpleanos.Size = new System.Drawing.Size(83, 16);
            this.Cumpleanos.TabIndex = 39;
            this.Cumpleanos.Text = "Cumpleaños";
      
            // 
            // Dpi
            // 
            this.Dpi.AutoSize = true;
            this.Dpi.Location = new System.Drawing.Point(16, 182);
            this.Dpi.Name = "Dpi";
            this.Dpi.Size = new System.Drawing.Size(28, 16);
            this.Dpi.TabIndex = 38;
            this.Dpi.Text = "Dpi";
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Location = new System.Drawing.Point(16, 138);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(48, 16);
            this.Correo.TabIndex = 37;
            this.Correo.Text = "Correo";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(14, 90);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(61, 16);
            this.Telefono.TabIndex = 36;
            this.Telefono.Text = "Telefono";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(12, 44);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(57, 16);
            this.Apellido.TabIndex = 35;
            this.Apellido.Text = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(19, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 34;
            this.Nombre.Text = "Nombre";
            // 
            // textBoxIdPuesto
            // 
            this.textBoxIdPuesto.Location = new System.Drawing.Point(15, 337);
            this.textBoxIdPuesto.Name = "textBoxIdPuesto";
            this.textBoxIdPuesto.Size = new System.Drawing.Size(144, 22);
            this.textBoxIdPuesto.TabIndex = 33;
            this.textBoxIdPuesto.TextChanged += new System.EventHandler(this.textBoxIdPuesto_TextChanged);
            // 
            // textBoxSucursal
            // 
            this.textBoxSucursal.Location = new System.Drawing.Point(17, 293);
            this.textBoxSucursal.Name = "textBoxSucursal";
            this.textBoxSucursal.Size = new System.Drawing.Size(144, 22);
            this.textBoxSucursal.TabIndex = 32;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(15, 113);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(144, 22);
            this.textBoxTelefono.TabIndex = 31;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(15, 157);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(144, 22);
            this.textBoxCorreo.TabIndex = 30;
            // 
            // textBoxDpi
            // 
            this.textBoxDpi.Location = new System.Drawing.Point(15, 201);
            this.textBoxDpi.Name = "textBoxDpi";
            this.textBoxDpi.Size = new System.Drawing.Size(144, 22);
            this.textBoxDpi.TabIndex = 29;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(15, 19);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(144, 22);
            this.textBoxNombre.TabIndex = 28;
            // 
            // textBoxCumpleanos
            // 
            this.textBoxCumpleanos.Location = new System.Drawing.Point(15, 249);
            this.textBoxCumpleanos.Name = "textBoxCumpleanos";
            this.textBoxCumpleanos.Size = new System.Drawing.Size(144, 22);
            this.textBoxCumpleanos.TabIndex = 27;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(15, 65);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(144, 22);
            this.textBoxApellido.TabIndex = 26;
            // 
            // GridEmpleados
            // 
            this.GridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmpleados.Location = new System.Drawing.Point(27, 92);
            this.GridEmpleados.Name = "GridEmpleados";
            this.GridEmpleados.RowHeadersWidth = 51;
            this.GridEmpleados.RowTemplate.Height = 24;
            this.GridEmpleados.Size = new System.Drawing.Size(557, 205);
            this.GridEmpleados.TabIndex = 25;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 393);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 38);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(3, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 47);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panIngresoDatos
            // 
            this.panIngresoDatos.Controls.Add(this.btnGuardar);
            this.panIngresoDatos.Controls.Add(this.textBoxIdPuesto);
            this.panIngresoDatos.Controls.Add(this.IdPuesto);
            this.panIngresoDatos.Controls.Add(this.textBoxSucursal);
            this.panIngresoDatos.Controls.Add(this.Sucursal);
            this.panIngresoDatos.Controls.Add(this.textBoxNombre);
            this.panIngresoDatos.Controls.Add(this.Nombre);
            this.panIngresoDatos.Controls.Add(this.Apellido);
            this.panIngresoDatos.Controls.Add(this.Telefono);
            this.panIngresoDatos.Controls.Add(this.Correo);
            this.panIngresoDatos.Controls.Add(this.Dpi);
            this.panIngresoDatos.Controls.Add(this.textBoxApellido);
            this.panIngresoDatos.Controls.Add(this.Cumpleanos);
            this.panIngresoDatos.Controls.Add(this.textBoxTelefono);
            this.panIngresoDatos.Controls.Add(this.textBoxCumpleanos);
            this.panIngresoDatos.Controls.Add(this.textBoxDpi);
            this.panIngresoDatos.Controls.Add(this.textBoxCorreo);
            this.panIngresoDatos.Location = new System.Drawing.Point(608, 32);
            this.panIngresoDatos.Name = "panIngresoDatos";
            this.panIngresoDatos.Size = new System.Drawing.Size(200, 437);
            this.panIngresoDatos.TabIndex = 48;
            // 
            // FrmMantenimientoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 533);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.GridEmpleados);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panIngresoDatos);
            this.Name = "FrmMantenimientoEmpleado";
            this.Text = "MantenimientoEmpleados";
            this.Load += new System.EventHandler(this.FrmMantenimientoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpleados)).EndInit();
            this.panIngresoDatos.ResumeLayout(false);
            this.panIngresoDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label IdPuesto;
        private System.Windows.Forms.Label Sucursal;
        private System.Windows.Forms.Label Cumpleanos;
        private System.Windows.Forms.Label Dpi;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textBoxIdPuesto;
        private System.Windows.Forms.TextBox textBoxSucursal;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxDpi;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCumpleanos;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.DataGridView GridEmpleados;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panIngresoDatos;
    }
}