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
            FrmMantenimientoEmpleado frm = Application.OpenForms.OfType<FrmMantenimientoEmpleado>().FirstOrDefault();
            if (frm == null)
            {
                frm = new FrmMantenimientoEmpleado();
                frm.MdiParent = this;
                frm.Show();
            }

            else
            {
                frm.BringToFront();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirPuestos_Click(object sender, EventArgs e)
        {
            FrmMantenimientoPuestos frm = Application.OpenForms.OfType<FrmMantenimientoPuestos>().FirstOrDefault();
            if (frm ==null)
            {
                frm = new FrmMantenimientoPuestos();
                frm.MdiParent = this;
                frm.Show();
            }

            else
            {
                frm.BringToFront();
            }
        }
    }
}
