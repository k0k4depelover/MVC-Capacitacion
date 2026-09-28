using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_PolloRey.Modelos
{
    public class Empleado
    {

        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }

        public string ApellidoEmpleado { get; set; }
        public string TelefonoEmpleado { get; set; }
        public string CorreoEmpleado { get; set; }          
        public string DpiEmpleado { get; set; }

        public DateTime CumpleanosEmpleado { get; set; }

        public string Sucursal { get; set; }
        public int IdPuesto { get; set; }

        public DateTime FechaCreacion { get; set; }

        public Empleado()
        {
        }
        public Empleado(int idEmpleado, string nombreEmpleado, string apellidoEmpleado, string telefonoEmpleado, string correoEmpleado, string dpiEmpleado, DateTime cumpleanosEmpleado, string sucursal, int idPuesto, DateTime fechaCreacion)
        {
            IdEmpleado = idEmpleado;
            NombreEmpleado = nombreEmpleado;
            ApellidoEmpleado = apellidoEmpleado;
            TelefonoEmpleado = telefonoEmpleado;
            CorreoEmpleado = correoEmpleado;
            DpiEmpleado = dpiEmpleado;
            CumpleanosEmpleado = cumpleanosEmpleado;
            Sucursal = sucursal;
            IdPuesto = idPuesto;
            FechaCreacion = DateTime.Now;
        }
    }
}
