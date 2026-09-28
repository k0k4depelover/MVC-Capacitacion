using CapaModelo_PolloRey.Modelos;
using CapaModelo_PolloRey.RepositoriosGenericos;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using Maestro = CapaModelo_PolloRey.RepositorioMaestro.RepositorioMaestro;
namespace CapaModelo_PolloRey.Repositorios
{
    public class RepositorioPuesto : Maestro, IRepositorioPuesto
    {
        private String selectAll;
        private String insert;
        private String update;
        private String delete;

        public RepositorioPuesto()
        {
            selectAll = "SELECT * FROM tbl_puesto";
            insert = "INSERT INTO tbl_puesto VALUES (NULL, ?, ? , ?, ?)";
            update = "UPDATE tbl_puesto SET NombrePuesto=?, DescripcionPuesto=?, SalarioPuesto=?, FechaCreacion=? WHERE IdPuesto=?";
            delete = "DELETE FROM tbl_puesto WHERE IdPuesto=?";
        }

        int RepositorioGenerico<Puesto>.Create(Puesto puesto)
        {
            var _parametros = new List<OdbcParameter>();


            _parametros.Add(new OdbcParameter("NombrePuesto", puesto.NombrePuesto));
            _parametros.Add(new OdbcParameter("DescripcionPuesto", puesto.DescripcionPuesto));
            _parametros.Add(new OdbcParameter("SalarioPuesto", puesto.SalarioPuesto));
            _parametros.Add(new OdbcParameter("FechaCreacion", puesto.FechaCreacion));
        
              return EjecutarNoQuery(insert, _parametros, CommandType.Text);
        }

        int RepositorioGenerico<Puesto>.Delete(Puesto puesto)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("IdPuesto", puesto.IdPuesto));
            return EjecutarNoQuery(delete, _parametros, CommandType.Text);
        }

        List<Puesto> RepositorioGenerico<Puesto>.Read()
        {
            var tabla = EjecutarQuery(selectAll, CommandType.Text);
            var listPuesto = new List<Puesto>();

            foreach(DataRow row in tabla.Rows)
            {
                var puesto = new Puesto
                {
                    IdPuesto = Convert.ToInt32(row[0]),
                    NombrePuesto = row[1].ToString(),
                    DescripcionPuesto = row[2].ToString(),
                    SalarioPuesto = Convert.ToSingle(row[3]),
                    FechaCreacion = Convert.ToDateTime(row[4])
                };
                listPuesto.Add(puesto);
            
            }
            tabla.Clear();
            tabla = null;
            return listPuesto;
        }

        int RepositorioGenerico<Puesto>.Update(Puesto empleado)
        {
            throw new NotImplementedException();
        }
    }
}
