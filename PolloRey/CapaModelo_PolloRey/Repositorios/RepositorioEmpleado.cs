using CapaModelo_PolloRey.Modelos;
using Maestro = CapaModelo_PolloRey.RepositorioMaestro.RepositorioMaestro;

using CapaModelo_PolloRey.RepositoriosGenericos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_PolloRey.Repositorios
{
    public class RepositorioEmpleado : Maestro, IRepositorioEmpleado
    {
        private String selectAll;
        private String insert; 
        private String update;
        private String delete;

        public RepositorioEmpleado()
        {
            selectAll = "SELECT * FROM tbl_empleado";
            insert = "INSERT INTO tbl_empleado VALUES (NULL, ?, ? , ?, ?, ? , ?, ?, ? , ?)";
            update = "UPDATE tbl_empleado SET NombreEmpleado=?, ApellidoEmpleado=?, TelefonoEmpleado=?, CorreoEmpleado=?, DpiEmpleado=?, CumpleanosEmpleado=?, Sucursal=?, IdPuesto=?,  FechaCreacion=? WHERE IdEmpleado=?";
            delete = "DELETE FROM tbl_empleado WHERE IdEmpleado =?";
        }
        int RepositorioGenerico<Empleado>.Create(Empleado empleado)
        {
            var _parametros = new List<OdbcParameter>();

            _parametros.Add(new OdbcParameter("IdEmpleado", empleado.IdEmpleado));
            _parametros.Add(new OdbcParameter("NombreEmpleado", empleado.NombreEmpleado));
            _parametros.Add(new OdbcParameter("ApellidoEmpleado", empleado.ApellidoEmpleado));
            _parametros.Add(new OdbcParameter("TelefonoEmpleado", empleado.TelefonoEmpleado));
            _parametros.Add(new OdbcParameter("CorreoEmpleado", empleado.CorreoEmpleado));
            _parametros.Add(new OdbcParameter("DpiEmpleado", empleado.DpiEmpleado));
            _parametros.Add(new OdbcParameter("CumpleanosEmpleado", empleado.CumpleanosEmpleado));
            _parametros.Add(new OdbcParameter("Sucursal", empleado.Sucursal));
            _parametros.Add(new OdbcParameter("IdPuesto", empleado.IdPuesto));
            _parametros.Add(new OdbcParameter("FechaCreacion", empleado.FechaCreacion));

            return EjecutarNoQuery(insert, _parametros, CommandType.Text);
        }

        int RepositorioGenerico<Empleado>.Delete(Empleado empleado)
        {
            var _parametros = new List<OdbcParameter>();

            _parametros.Add(new OdbcParameter("IdEmpleado", empleado.IdEmpleado));

            return EjecutarNoQuery(delete, _parametros, CommandType.Text);
        }

        List<Empleado> RepositorioGenerico<Empleado>.Read()
        {
            var listEmpleado = new List<Empleado>();
            var tabla= EjecutarQuery(selectAll, CommandType.Text);

            foreach( DataRow row in tabla.Rows)
            {
                var empleado = new Empleado();
                empleado.IdEmpleado = Convert.ToInt32(row[0]);
                empleado.NombreEmpleado = row[1].ToString();
                empleado.ApellidoEmpleado = row[2].ToString();
                empleado.TelefonoEmpleado = row[3].ToString();
                empleado.CorreoEmpleado = row[4].ToString();
                empleado.DpiEmpleado = row[5].ToString();
                empleado.CumpleanosEmpleado = Convert.ToDateTime(row[6]);
                empleado.Sucursal = row[7].ToString();
                empleado.IdPuesto = Convert.ToInt32(row[8]);
                empleado.FechaCreacion = Convert.ToDateTime(row[9]);

                listEmpleado.Add(empleado);

            }
            tabla.Clear();
            tabla = null;
            return listEmpleado;
        }

        int RepositorioGenerico<Empleado>.Update(Empleado empleado)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("NombreEmpleado", empleado.NombreEmpleado));
            _parametros.Add(new OdbcParameter("ApellidoEmpleado", empleado.ApellidoEmpleado));
            _parametros.Add(new OdbcParameter("TelefonoEmpleado", empleado.TelefonoEmpleado));
            _parametros.Add(new OdbcParameter("CorreoEmpleado", empleado.CorreoEmpleado));
            _parametros.Add(new OdbcParameter("DpiEmpleado", empleado.DpiEmpleado));
            _parametros.Add(new OdbcParameter("CumpleanosEmpleado", empleado.CumpleanosEmpleado));
            _parametros.Add(new OdbcParameter("Sucursal", empleado.Sucursal));
            _parametros.Add(new OdbcParameter("IdPuesto", empleado.IdPuesto));
            _parametros.Add(new OdbcParameter("FechaCreacion", empleado.FechaCreacion));

            return EjecutarNoQuery(update, _parametros, CommandType.Text);
        }
    }
}
