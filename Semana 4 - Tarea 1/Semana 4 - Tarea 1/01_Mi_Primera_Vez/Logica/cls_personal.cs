using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using _01_Mi_Primera_Vez.Datos;
using System.Globalization;

namespace _01_Mi_Primera_Vez.Logica
{
   
   public class cls_personal
    {
        private readonly conexion cn = new conexion();
        //insertar
        public string Insertar(dto_personal Personal) {

            using (var conexion = cn.obtenerConexion())
            {
                string cadena1 = "insert into Personal (Cedula, Nombre, Cargo, Sueldo, IdPais)values('" +
                    Personal.cedula + "','" +
                    Personal.nombre + "','" +
                    Personal.cargo + "'," +
                    Personal.sueldo + "," +
                    Personal.idPais + ")";
                using (var comando = new SqlCommand(cadena1, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "ok";
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }                 
                }
            }         
        }

        //todos   select * from   getall
        public List<dto_personal> todos() {
            var listapersonal = new List<dto_personal>();
            using (var conexion = cn.obtenerConexion())//1 llamo a la conexion con la base
            {
                string cadena = "SELECT IdPersonal, Cedula, Nombre, Cargo, Sueldo, Paises.IdPais, Paises.Detalle " +
                    "FROM Personal inner join Paises on Paises.IdPais = Personal.IdPais"; //2 creo la sentencia sql
                using (var comando = new SqlCommand(cadena, conexion)) //3 ejecuto el comando 
                {
                    conexion.Open(); //4 abrir la conexion
                    using (var lector = comando.ExecuteReader())//5 cargar el lector la informacion
                    {                      
                        while (lector.Read())  //6 recorrer el lector para obtener la iformacion
                        {
                            var personal = new dto_personal //7  creo un objeto dto_personal para asiganr lo que trae de la base de datos
                            {
                                IdPersonal = (int)lector["IdPersonal"],
                                cedula = lector["Cedula"].ToString(),
                                nombre = lector["Nombre"].ToString(),
                                cargo = lector["Cargo"].ToString(),
                                sueldo = (decimal)lector["Sueldo"],
                                Detalle = lector["Detalle"].ToString()
                            };
                            listapersonal.Add(personal); //8 agregar a la lista el objeto
                        }
                    }
                }
            }

            return listapersonal;
        }
        //uno  select * where

        public dto_personal uno(int id) {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = "select * from Personal where IdPersonal=" + id;
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        lector.Read();
                        var personal = new dto_personal 
                        {
                            IdPersonal = (int)lector["IdPersonal"],
                            cedula = lector["Cedula"].ToString(),
                            nombre = lector["Nombre"].ToString(),
                            cargo = lector["Cargo"].ToString(),
                            sueldo = (decimal)lector["Sueldo"],
                            idPais = (int)lector["IdPais"],
                        };
                        return personal;
                    }
                }
            }     
        }

        //uno con parametro cedula\
        public dto_personal uno(string cedula)
        {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"select * from Personal where Cedula='{cedula}'" ;
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            var personal = new dto_personal
                            {
                                IdPersonal = (int)lector["IdPersonal"],
                                cedula = lector["Cedula"].ToString(),
                                nombre = lector["Nombre"].ToString(),
                                cargo = lector["Cargo"].ToString(),
                                sueldo = (decimal)lector["Sueldo"],
                                idPais = (int)lector["IdPais"],
                            };
                            return personal;
                        }
                        else {
                            return new dto_personal();
                        }
                    }
                }
            }
        }

        //actualziar

        public string actualizar(dto_personal personal) {
            using (var conexion = cn.obtenerConexion())
            {
                string cadeba = "update Personal set " +
                    $"Cargo='{personal.cargo}', Cedula='{personal.cedula}'," +
                    $"IdPais={personal.idPais},Nombre='{personal.nombre}'," +
                    $"Sueldo={personal.sueldo} where IdPersonal={personal.IdPersonal}";
                using (var comando = new SqlCommand(cadeba, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "ok";
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
        }

        public bool duplicadoCedula(string cedula) {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"select count(*) as repetidos from Personal where Cedula='{cedula}'";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        lector.Read();
                        if ((int)lector["repetidos"] > 0)
                        {
                            return true; // verdadero - que hay numeros de cedula repetidos
                        }
                        else { return false; }
                    }
                }
            }
        }

        //eliminar
        public bool eliminar(int id) {
            using (var conexion = cn.obtenerConexion())
            {
                string cadena = $"delete from Personal where IdPersonal={id}";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

        
        public List<dto_personal> buscador(string texto)
        {
            List<dto_personal> listapersonal = new List<dto_personal>();

            using (var conexion = cn.obtenerConexion())//1 llamo a la conexion con la base
            {
                string cadena = "SELECT IdPersonal, Cedula, Nombre, Cargo, Sueldo, Paises.IdPais, Paises.Detalle " +
                    "FROM Personal inner join Paises on Paises.IdPais = Personal.IdPais " +
                    $"where nombre like '%{texto}%'"; //2 creo la sentencia sql
                using (var comando = new SqlCommand(cadena, conexion)) //3 ejecuto el comando 
                {
                    conexion.Open(); //4 abrir la conexion
                    using (var lector = comando.ExecuteReader())//5 cargar el lector la informacion
                    {
                        while (lector.Read())  //6 recorrer el lector para obtener la iformacion
                        {
                            var personal = new dto_personal //7  creo un objeto dto_personal para asiganr lo que trae de la base de datos
                            {
                                IdPersonal = (int)lector["IdPersonal"],
                                cedula = lector["Cedula"].ToString(),
                                nombre = lector["Nombre"].ToString(),
                                cargo = lector["Cargo"].ToString(),
                                sueldo = (decimal)lector["Sueldo"],
                                Detalle = lector["Detalle"].ToString()
                            };
                            listapersonal.Add(personal); //8 agregar a la lista el objeto
                        }
                    }
                }
            }

            return listapersonal;

        }

    }
}
