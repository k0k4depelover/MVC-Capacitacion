using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_PolloRey.Modelos
{
    internal class PuestoEmpleado
    {

        private int IdEmpleado { get; set; }
        private int IdPuesto { get; set; }

        private string Sucursal { get; set; }

        public PuestoEmpleado(int idEmpleado, int idPuesto, string sucursal)
        {
            IdEmpleado = idEmpleado;
            IdPuesto = idPuesto;
            Sucursal = sucursal;
        }

    }
}
