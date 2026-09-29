using CapaControlador_PolloRey;
using CapaControlador_PolloRey.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace CapaVista_PolloRey.Formularios
{
    public partial class FrmMantenimientoPuestos : Form
    {
        private ModeloPuesto modeloPuesto = new ModeloPuesto();

        public FrmMantenimientoPuestos()
        {
            InitializeComponent();
            panIngresoDatos.Enabled = false;

            // Asegura que el evento Load se enlace aunque no esté en el diseñador
            this.Load += FrmMantenimientoPuestos_Load;
        }

        private void FrmMantenimientoPuestos_Load(object sender, EventArgs e)
        {
            CargarPuestos();
        }

        private void CargarPuestos()
        {
            try
            {
                GridPuestos.AutoGenerateColumns = true;
                var datos = modeloPuesto.ObtenerTodos();

                // Limpiar enlace anterior y asignar nueva lista
                GridPuestos.DataSource = null;
                GridPuestos.DataSource = datos;
                GridPuestos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los puestos: " + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panIngresoDatos.Enabled = true;
            LimpiarCampos();
            modeloPuesto.Estado = EstadoEntidad.Agregado;
            textBoxPuesto.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GridPuestos.CurrentRow != null && GridPuestos.CurrentRow.Index >= 0)
            {
                panIngresoDatos.Enabled = true;
                modeloPuesto.Estado = EstadoEntidad.Modificado;

                var fila = GridPuestos.CurrentRow;
                modeloPuesto.IdPuesto = Convert.ToInt32(fila.Cells["IdPuesto"].Value);
                textBoxPuesto.Text = fila.Cells["NombrePuesto"].Value?.ToString();
                textBoxDescripcion.Text = fila.Cells["DescripcionPuesto"].Value?.ToString();
                textBoxSalario.Text = fila.Cells["SalarioPuesto"].Value?.ToString();
                textBoxPuesto.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un puesto de la tabla para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (GridPuestos.CurrentRow != null && GridPuestos.CurrentRow.Index >= 0)
            {
                var dialog = MessageBox.Show("¿Está seguro de eliminar el puesto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    modeloPuesto.Estado = EstadoEntidad.Eliminado;
                    modeloPuesto.IdPuesto = Convert.ToInt32(GridPuestos.CurrentRow.Cells["IdPuesto"].Value);

                    string respuesta = modeloPuesto.Guardar();
                    MessageBox.Show(respuesta, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarPuestos();
                    LimpiarCampos();
                    panIngresoDatos.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un puesto de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                modeloPuesto.NombrePuesto = textBoxPuesto.Text.Trim();
                modeloPuesto.DescripcionPuesto = textBoxDescripcion.Text.Trim();

                if (float.TryParse(textBoxSalario.Text.Trim(), out float salario))
                {
                    modeloPuesto.SalarioPuesto = salario;
                }
                else
                {
                    MessageBox.Show("El salario debe ser un valor numérico válido (ej. 4500.00).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación mediante DataAnnotations
                var contexto = new ValidationContext(modeloPuesto, null, null);
                var listaErrores = new List<ValidationResult>();

                if (!Validator.TryValidateObject(modeloPuesto, contexto, listaErrores, true))
                {
                    string errores = string.Join("\n", listaErrores.Select(r => r.ErrorMessage));
                    MessageBox.Show(errores, "Validación requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string respuesta = modeloPuesto.Guardar();
                MessageBox.Show(respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarPuestos();
                LimpiarCampos();
                panIngresoDatos.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                GridPuestos.DataSource = null;
                GridPuestos.DataSource = modeloPuesto.ObtenerPorId(textBoxBuscar.Text.Trim());
                GridPuestos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            textBoxPuesto.Clear();
            textBoxDescripcion.Clear();
            textBoxSalario.Clear();
        }
    }
}