using CapaModelo_PolloRey.Modelos;
using CapaModelo_PolloRey.RepositoriosGenericos;
using System;
using CapaModelo_PolloRey.Repositorios;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_PolloRey.Modelos
{
    public class ModeloEmpleado
    {
        private int _idEmpleado;
        private string _nombreEmpleado;
        private string _apellidoEmpleado;
        private string _telefonoEmpleado;
        private string _correoEmpleado;
        private string _dpiEmpleado;
        private DateTime _cumpleanosEmpleado;
        private string _sucursal;
        private int _idPuesto;
        private int _edad;
        private DateTime _fechaCreacion;
        private IRepositorioEmpleado _repositorioEmpleado;
        private List<ModeloEmpleado> ListaEmpleados;
        public EstadoEntidad Estado { private get; set; }


        public ModeloEmpleado()
        {
            _repositorioEmpleado = new RepositorioEmpleado();
        }

        public int IdEmpleado
        {
            get => _idEmpleado;
            set => _idEmpleado = value;
        }

        [Required(ErrorMessage = "El nombre del empleado es obligatorio.")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$", ErrorMessage = "El nombre debe incluir solo letras.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre del empleado debe tener entre 3 y 100 caracteres.")]
        public string NombreEmpleado
        {
            get => _nombreEmpleado;
            set => _nombreEmpleado = value;
        }

        [Required(ErrorMessage = "El apellido del empleado es obligatorio.")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$", ErrorMessage = "El apellido debe incluir solo letras.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El apellido del empleado debe tener entre 3 y 100 caracteres.")]
        public string ApellidoEmpleado
        {
            get => _apellidoEmpleado;
            set => _apellidoEmpleado = value;
        }

        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "El teléfono debe contener exactamente 8 dígitos.")]
        public string Telefono
        {
            get => _telefonoEmpleado;
            set => _telefonoEmpleado = value;
        }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debe ingresar una dirección de correo válida.")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "El correo debe tener entre 6 y 150 caracteres.")]
        public string CorreoEmpleado
        {
            get => _correoEmpleado;
            set => _correoEmpleado = value;
        }

        [Required(ErrorMessage = "El DPI es obligatorio.")]
        [RegularExpression(@"^[0-9]{13}$", ErrorMessage = "El DPI debe contener exactamente 13 dígitos.")]
        public string DpiEmpleado
        {
            get => _dpiEmpleado;
            set => _dpiEmpleado = value;
        }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime CumpleanosEmpleado
        {
            get => _cumpleanosEmpleado;
            set => _cumpleanosEmpleado = value;
        }

        [Required(ErrorMessage = "La sucursal es obligatoria.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "La sucursal debe tener entre 3 y 25 caracteres.")]
        public string Sucursal
        {
            get => _sucursal;
            set => _sucursal = value;
        }

        [Required(ErrorMessage = "Debe seleccionar un puesto.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un puesto válido.")]
        public int IdPuesto
        {
            get => _idPuesto;
            set => _idPuesto = value;
        }

        public int Edad { get => _edad; private set => _edad = value; }

        // Se asigna automáticamente por MySQL
        public DateTime FechaCreacion
        {
            get => _fechaCreacion;
        }



        public string GuardarCambios()
        {
            string messaje = string.Empty;
            try
            {
                var modeloDatosEmpleados = new Empleado
                {
                    IdEmpleado = _idEmpleado,
                    NombreEmpleado = _nombreEmpleado,
                    ApellidoEmpleado = _apellidoEmpleado,
                    TelefonoEmpleado = _telefonoEmpleado,
                    CorreoEmpleado = _correoEmpleado,
                    DpiEmpleado = _dpiEmpleado,
                    CumpleanosEmpleado = _cumpleanosEmpleado,
                    Sucursal = _sucursal,
                    IdPuesto = _idPuesto,
                };
                switch (Estado)
                {
                    case EstadoEntidad.Agregado:
                        _repositorioEmpleado.Create(modeloDatosEmpleados);
                        messaje = "Empleado agregado correctamente.";
                        break;
                    case EstadoEntidad.Modificado:
                        _repositorioEmpleado.Update(modeloDatosEmpleados);
                        messaje = "Empleado modificado correctamente.";
                        break;
                    case EstadoEntidad.Eliminado:
                        _repositorioEmpleado.Delete(modeloDatosEmpleados);
                        messaje = "Empleado eliminado correctamente.";
                        break;
                }
            }

            catch (Exception ex)
            {
                messaje = $"Error al guardar cambios: {ex.Message}";
            }

            return messaje;

        }

        public List<ModeloEmpleado> ObtenerTodos()
        {
            try
            {
                var modeloDatosEmpleados = _repositorioEmpleado.Read();
                List<ModeloEmpleado> listaEmpleados = new List<ModeloEmpleado>();

                foreach (var empleado in modeloDatosEmpleados)
                {
                    listaEmpleados.Add(new ModeloEmpleado
                    {
                        _idEmpleado = empleado.IdEmpleado,
                        _nombreEmpleado = empleado.NombreEmpleado,
                        _apellidoEmpleado = empleado.ApellidoEmpleado,
                        _telefonoEmpleado = empleado.TelefonoEmpleado,
                        _correoEmpleado = empleado.CorreoEmpleado,
                        _dpiEmpleado = empleado.DpiEmpleado,
                        _cumpleanosEmpleado = empleado.CumpleanosEmpleado,

                        _sucursal = empleado.Sucursal,
                        _edad = CalcularEdad(empleado.CumpleanosEmpleado),
                        _idPuesto = empleado.IdPuesto,
                        _fechaCreacion = empleado.FechaCreacion
                    });
                }
                this.ListaEmpleados = listaEmpleados;
                return listaEmpleados;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener empleados: {ex.Message}");
            }


        }


        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }


        public IEnumerable<ModeloEmpleado> ObtenerPorId(string filter)
        {
            return ListaEmpleados.FindAll(e => e.IdEmpleado.ToString().Contains(filter) || e._nombreEmpleado.Contains(filter));
        }



    }
}