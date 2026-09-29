using CapaModelo_PolloRey.Modelos;
using CapaModelo_PolloRey.Repositorios;
using CapaModelo_PolloRey.RepositoriosGenericos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace CapaControlador_PolloRey.Modelos
{
    public class ModeloPuesto
    {
        private int _idPuesto;
        private string _nombrePuesto;
        private string _descripcionPuesto;
        private float _salarioPuesto;
        private readonly DateTime _fechaCreacion;
        private IRepositorioPuesto _repositorioPuesto;

        public EstadoEntidad Estado { private get; set; }
        private List<ModeloPuesto> ListaPuestos;

        public ModeloPuesto()
        {
            _repositorioPuesto = new RepositorioPuesto();
        }

        public int IdPuesto { get => _idPuesto; set => _idPuesto = value; }



        [Required(ErrorMessage = "El nombre del puesto es obligatorio.")]
        [RegularExpression("^[a-zA-Zá-ú ]+$", ErrorMessage = "El nombre debe incluir solo letras")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre del puesto debe tener entre 3 y 50 caracteres.")]
        public string NombrePuesto { get => _nombrePuesto; set => _nombrePuesto = value; }


        [RegularExpression("^[a-zA-Zá-ú ]+$", ErrorMessage = "La descripcion debe incluir solo letras")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "La descripcion del puesto debe tener entre 10 y 250 caracteres.")]
        public string DescripcionPuesto { get => _descripcionPuesto; set => _descripcionPuesto = value; }

        [Required(ErrorMessage = "El monto del salario es obligatorio.")]
        [RegularExpression("([0-9]+\\.[0-9]+)", ErrorMessage = "Numero de identificacion debe ser numerico")]
        [Range(4002.28, 100000.00, ErrorMessage = "El salario debe estar entre el minimo actual y 100,000.00")]
        public float SalarioPuesto { get => _salarioPuesto; set => _salarioPuesto = value; }

        public DateTime FechaCreacion { get => _fechaCreacion; }



        public string Guardar()
        {
            string messaje = string.Empty;

            try
            {
                var puesto = new Puesto
                {
                    NombrePuesto = _nombrePuesto,
                    DescripcionPuesto = _descripcionPuesto,
                    SalarioPuesto = _salarioPuesto,
                    FechaCreacion = _fechaCreacion

                };

                switch (Estado)
                {
                    case EstadoEntidad.Agregado:
                        _repositorioPuesto.Create(puesto);
                        messaje = "Puesto agregado correctamente.";
                        break;
                    case EstadoEntidad.Modificado:
                        _repositorioPuesto.Update(puesto);
                        messaje = "Puesto modificado correctamente.";
                        break;
                    case EstadoEntidad.Eliminado:
                        _repositorioPuesto.Delete(puesto);
                        messaje = "Puesto eliminado correctamente.";
                        break;
                    default:
                        messaje = "Estado de entidad no válido.";
                        break;
                }


            }
            catch (Exception ex)
            {
                messaje = $"Error al guardar el puesto: {ex.Message}";
            }




            return messaje;
        }





        public List<ModeloPuesto> ObtenerTodos()
        {
            var puestos = _repositorioPuesto.Read();
            var modelosPuestos = new List<ModeloPuesto>();
            foreach (var puesto in puestos)
            {
                var modeloPuesto = new ModeloPuesto
                {
                    _idPuesto = puesto.IdPuesto,
                    _nombrePuesto = puesto.NombrePuesto,
                    _descripcionPuesto = puesto.DescripcionPuesto,
                    _salarioPuesto = puesto.SalarioPuesto,
                    // FechaCreacion = puesto.FechaCreacion // Assuming FechaCreacion is set in the constructor or elsewhere
                };
                modelosPuestos.Add(modeloPuesto);
            }
            return modelosPuestos;
        }




        public IEnumerable<ModeloPuesto> ObtenerPorId(string filter)
        {
            return ListaPuestos.FindAll(e => e.IdPuesto.ToString().Contains(filter) || e._nombrePuesto.Contains(filter));
        }

    }
}