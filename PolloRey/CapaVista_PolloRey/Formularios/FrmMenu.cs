using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_PolloRey.Formularios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAbrirEmpleados_Click(object sender, EventArgs e)
        {
            // 1. Ocultar el panel de bienvenida
            panelMenu.Visible = false;

            FrmMantenimientoEmpleado frm = Application.OpenForms.OfType<FrmMantenimientoEmpleado>().FirstOrDefault();
            if (frm == null)
            {
                frm = new FrmMantenimientoEmpleado();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Para que use toda la pantalla

                // 2. Al cerrar el formulario hijo, volver a mostrar el menú de botones
                frm.FormClosed += (s, args) =>
                {
                    if (this.MdiChildren.Length <= 1)
                    {
                        panelMenu.Visible = true;
                    }
                };

                frm.Show();
            }
            else
            {
                frm.BringToFront();
            }
        }


        private void btnAbrirPuestos_Click(object sender, EventArgs e)
        {
            // 1. Ocultar el panel de bienvenida
            panelMenu.Visible = false;

            FrmMantenimientoPuestos frm = Application.OpenForms.OfType<FrmMantenimientoPuestos>().FirstOrDefault();
            if (frm == null)
            {
                frm = new FrmMantenimientoPuestos();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized; // Para que use toda la pantalla

                // 2. Al cerrar el formulario hijo, volver a mostrar el menú de botones
                frm.FormClosed += (s, args) =>
                {
                    if (this.MdiChildren.Length <= 1)
                    {
                        panelMenu.Visible = true;
                    }
                };

                frm.Show();
            }
            else
            {
                frm.BringToFront();
            }
        }
    }
}
