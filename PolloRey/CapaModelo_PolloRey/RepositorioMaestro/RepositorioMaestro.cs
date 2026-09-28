using CapaModelo_PolloRey.Conexion;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;


namespace CapaModelo_PolloRey.RepositorioMaestro
{
        public abstract class RepositorioMaestro : ConectionString
        {
            public  int EjecutarNoQuery(string _comand, List<OdbcParameter> _params, CommandType _type)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var ocComando = new OdbcCommand())
                {
                    ocComando.Connection = conexion;
                    ocComando.CommandText = _comand;
                    ocComando.CommandType = _type;
                    ocComando.Parameters.AddRange(_params.ToArray());

                    return ocComando.ExecuteNonQuery();
                }

            
            }
        }
        

        public DataTable EjecutarQuery(string _comand, CommandType commandType)
        {
            DataTable dtTable = new DataTable();
            using (var conexion = GetConnection())
            {


                conexion.Open();

                using (var ocComando = new OdbcCommand())
                {
                    ocComando.Connection = conexion;
                    ocComando.CommandText = _comand;
                    ocComando.CommandType = commandType;
                    using (var reader = ocComando.ExecuteReader())
                            dtTable.Load(reader);  //Llenar la tabla de datos 
                    }
                return dtTable; 
                }


            }

        }


    }

