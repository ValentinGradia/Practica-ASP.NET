using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebMotoDos.Models;

namespace WebMotoDos.Controllers
{
    public class MotoController
    {
        public static List<Moto> obtenerMotos()
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            List<Moto> lista = new List<Moto>();

            try
            {
                accesoDatos.setearProcedimiento("obtenerMotos");

                accesoDatos.ejecutarLectura();

                while(accesoDatos.Lector.Read())
                {
                    Moto moto = new Moto();
                    moto.Id = (int)accesoDatos.Lector["Id"];
                    moto.Marca = (string)accesoDatos.Lector["Marca"];
                    moto.UrlImagen = (string)accesoDatos.Lector["UrlImagen"];
                    moto.Cilindrada = (string)accesoDatos.Lector["Cilindrada"];
                    moto.Tipo = (string)accesoDatos.Lector["Tipo"];
                    moto.Ubicacion = (Ubicaciones)Convert.ToInt32(accesoDatos.Lector["Ubicacion"]);
                    moto.Precio = (decimal)accesoDatos.Lector["Precio"];
                    moto.Modelo = (string)accesoDatos.Lector["Modelo"];
                    moto.Km = (int)accesoDatos.Lector["Km"];
                    moto.Año = (int)accesoDatos.Lector["Año"];
                    moto.Color = (string)accesoDatos.Lector["Color"];
                    moto.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    lista.Add(moto);
                }

                accesoDatos.Lector.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (accesoDatos.conexion.State == System.Data.ConnectionState.Open) accesoDatos.conexion.Close();
            }

            return lista;
        }
    }
}