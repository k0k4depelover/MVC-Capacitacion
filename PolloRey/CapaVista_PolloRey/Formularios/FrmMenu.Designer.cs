namespace CapaVista_PolloRey.Formularios
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.btnAbrirEmpleados = new System.Windows.Forms.Button();
            this.btnAbrirPuestos = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirEmpleados
            // 
            this.btnAbrirEmpleados.Location = new System.Drawing.Point(287, 161);
            this.btnAbrirEmpleados.Name = "btnAbrirEmpleados";
            this.btnAbrirEmpleados.Size = new System.Drawing.Size(216, 34);
            this.btnAbrirEmpleados.TabIndex = 1;
            this.btnAbrirEmpleados.Text = "Mantenimiento Empleados";
            this.btnAbrirEmpleados.UseVisualStyleBackColor = true;
            this.btnAbrirEmpleados.Click += new System.EventHandler(this.btnAbrirEmpleados_Click);
            // 
            // btnAbrirPuestos
            // 
            this.btnAbrirPuestos.Location = new System.Drawing.Point(287, 267);
            this.btnAbrirPuestos.Name = "btnAbrirPuestos";
            this.btnAbrirPuestos.Size = new System.Drawing.Size(216, 38);
            this.btnAbrirPuestos.TabIndex = 2;
            this.btnAbrirPuestos.Text = "Mantenimiento Puestos";
            this.btnAbrirPuestos.UseVisualStyleBackColor = true;
            this.btnAbrirPuestos.Click += new System.EventHandler(this.btnAbrirPuestos_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROTOTIPO UMG MEJORADO";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnAbrirEmpleados);
            this.panelMenu.Controls.Add(this.btnAbrirPuestos);
            this.panelMenu.Location = new System.Drawing.Point(0, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 451);
            this.panelMenu.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "FrmMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirEmpleados;
        private System.Windows.Forms.Button btnAbrirPuestos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
    }
}