using CapaControlador_PolloRey;
using CapaControlador_PolloRey.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_PolloRey.Formularios
{
    public partial class FrmMantenimientoEmpleado : Form
    {
        private ModeloEmpleado empleado = new ModeloEmpleado();

        public FrmMantenimientoEmpleado()
        {
            InitializeComponent();
            panIngresoDatos.Enabled = false;
        }

        private void FrmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            listaEmpleados();
        }

        private void listaEmpleados()
        {
            try
            {
                GridEmpleados.DataSource = empleado.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la lista de empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panIngresoDatos.Enabled = true;
            limpiarCampos();
            empleado.Estado = EstadoEntidad.Agregado;
            textBoxNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GridEmpleados.SelectedRows.Count > 0)
            {
                panIngresoDatos.Enabled = true;
                empleado.Estado = EstadoEntidad.Modificado;

                // Cargar datos de la fila seleccionada a los controles
                var fila = GridEmpleados.CurrentRow;
                empleado.IdEmpleado = Convert.ToInt32(fila.Cells["IdEmpleado"].Value);
                textBoxNombre.Text = fila.Cells["NombreEmpleado"].Value?.ToString();
                textBoxApellido.Text = fila.Cells["ApellidoEmpleado"].Value?.ToString();
                textBoxTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
                textBoxCorreo.Text = fila.Cells["CorreoEmpleado"].Value?.ToString();
                textBoxDpi.Text = fila.Cells["DpiEmpleado"].Value?.ToString();
                if (fila.Cells["CumpleanosEmpleado"].Value != null &&
                    DateTime.TryParse(fila.Cells["CumpleanosEmpleado"].Value.ToString(), out DateTime fecha))
                {
                    textBoxCumpleanos.Text = fecha.ToString("yyyy-MM-dd"); // o el formato que prefieras (ej. "dd/MM/yyyy")
                }
                else
                {
                    textBoxCumpleanos.Text = string.Empty;
                }
                textBoxIdPuesto.Text = fila.Cells["IdPuesto"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila en la tabla para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (GridEmpleados.SelectedRows.Count > 0)
            {
                var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar al empleado seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    empleado.Estado = EstadoEntidad.Eliminado;
                    empleado.IdEmpleado = Convert.ToInt32(GridEmpleados.CurrentRow.Cells["IdEmpleado"].Value);

                    string resultado = empleado.GuardarCambios();
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listaEmpleados();
                    limpiarCampos();
                    panIngresoDatos.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila en la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Pasar los datos de los controles a la entidad de la capa controlador
                empleado.NombreEmpleado = textBoxNombre.Text.Trim();
                empleado.ApellidoEmpleado = textBoxApellido.Text.Trim();
                empleado.Telefono = textBoxTelefono.Text.Trim();
                empleado.CorreoEmpleado = textBoxCorreo.Text.Trim();
                empleado.DpiEmpleado = textBoxDpi.Text.Trim();
                empleado.CumpleanosEmpleado = Convert.ToDateTime(textBoxCumpleanos.Text.Trim());
                empleado.Sucursal = textBoxSucursal.Text.Trim();

                int idPuesto;
                if (int.TryParse(textBoxIdPuesto.Text.Trim(), out idPuesto))
                {
                    empleado.IdPuesto = idPuesto;
                }
                else
                {
                    MessageBox.Show("El ID del puesto debe ser numérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación mediante DataAnnotations declaradas en ModeloEmpleado
                var contexto = new ValidationContext(empleado, null, null);
                var errores = new List<ValidationResult>();

                if (!Validator.TryValidateObject(empleado, contexto, errores, true))
                {
                    string mensajeErrores = string.Join("\n", errores.Select(r => r.ErrorMessage));
                    MessageBox.Show(mensajeErrores, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Guardar cambios en la base de datos
                string resultado = empleado.GuardarCambios();
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listaEmpleados();
                limpiarCampos();
                panIngresoDatos.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarEmpleadoPorId(textBoxBuscar.Text.Trim());
        }

        private void buscarEmpleadoPorId(string filter)
        {
            try
            {
                GridEmpleados.DataSource = empleado.ObtenerPorId(filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
            textBoxDpi.Clear();
            textBoxCumpleanos.Clear();
            textBoxSucursal.Clear();
            textBoxIdPuesto.Clear();
        }

        private void textBoxIdPuesto_TextChanged(object sender, EventArgs e)
        {
        }
    }
}