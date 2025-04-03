using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebMotoDos.Models;

namespace WebMotoDos.Controllers
{
    public class UsuarioController
    {
        public static Usuario obtenerUsuario(string email, string contraseña)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            bool flag = false;
            Usuario usuario = new Usuario();


            try
            {
                accesoDatos.setearParametros("@Email", email);
                accesoDatos.setearParametros("@Contraseña", contraseña);

                accesoDatos.setearProcedimiento("traerUsuario");

                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    flag = true;
                    usuario.Id = (int)accesoDatos.Lector["Id"];
                    usuario.Nombre = (string)accesoDatos.Lector["Nombre"];
                    usuario.Apellido = (string)accesoDatos.Lector["Apellido"];
                    usuario.Email = (string)accesoDatos.Lector["Email"];
                    usuario.Contraseña = (string)accesoDatos.Lector["Contraseña"];
                }

                if (!flag)
                {
                    throw new UsuarioNullException("Usuario no existente");
                }
            }
            catch (UsuarioNullException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (accesoDatos.conexion.State == System.Data.ConnectionState.Open) accesoDatos.conexion.Close();
            }

            return usuario;
        }


        public static int insertarUsuario(Usuario usuario)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearParametros("@Nombre", usuario.Nombre);
                accesoDatos.setearParametros("@Apellido",usuario.Apellido);
                accesoDatos.setearParametros("@Email", usuario.Email);
                accesoDatos.setearParametros("@Contraseña", usuario.Contraseña);

                SqlParameter idParametro = new SqlParameter("@Id",System.Data.SqlDbType.Int);
                idParametro.Direction = System.Data.ParameterDirection.Output;
                accesoDatos.setearParametros(idParametro);

                accesoDatos.setearProcedimiento("insertarUsuario");

                accesoDatos.ejecutarAccion();

                int id = Convert.ToInt32(idParametro.Value);

                return id;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (accesoDatos.conexion.State == System.Data.ConnectionState.Open) accesoDatos.conexion.Close();
            }
        }

        public static void verificarEmail(string email)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearParametros("@Email", email);

                accesoDatos.setearProcedimiento("verificarEmail");

                int coincidencias = accesoDatos.ejecutarAccionScalar();

                if(coincidencias > 0)
                {
                    throw new MailEnUsoException("Ese mail ya esta en uso");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (accesoDatos.conexion.State == System.Data.ConnectionState.Open) accesoDatos.conexion.Close();
            }
        }

        public static void modificarUsuario(Usuario usuario)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearParametros("@Id", usuario.Id);
                accesoDatos.setearParametros("@Nombre", usuario.Nombre);
                accesoDatos.setearParametros("@Apellido", usuario.Apellido);
                accesoDatos.setearParametros("@Email", usuario.Email);
                accesoDatos.setearParametros("@Contraseña", usuario.Contraseña);

                accesoDatos.setearProcedimiento("modificarUsuario");

                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (accesoDatos.conexion.State == System.Data.ConnectionState.Open) accesoDatos.conexion.Close();
            }
        }

        
    }
}