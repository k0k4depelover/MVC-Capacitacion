using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_PolloRey.Modelos
{
    public class Puesto
    {

        public int IdPuesto { get; set; }
        public string NombrePuesto { get; set; }

        public string DescripcionPuesto { get; set; }

        public float SalarioPuesto { get; set; }

        public DateTime FechaCreacion { get; set; } 

        public Puesto() { }
        public Puesto(int idPuesto, string nombrePuesto, string descripcionPuesto, float salarioPuesto, DateTime fechaCreacion)
        {
            IdPuesto = idPuesto;
            NombrePuesto = nombrePuesto;
            DescripcionPuesto = descripcionPuesto;
            SalarioPuesto = salarioPuesto;
            FechaCreacion = fechaCreacion;
        }
    }
}
