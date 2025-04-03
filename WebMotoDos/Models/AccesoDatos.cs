using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebMotoDos.Models
{
    public class AccesoDatos
    {
        public SqlCommand comando;
        public SqlConnection conexion;
        private static string cadenaConexion;
        public SqlDataReader Lector;


        static AccesoDatos()
        {
            AccesoDatos.cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=motoDos;Integrated Security=True;TrustServerCertificate=True";
        }

        public AccesoDatos()
        {
            this.conexion = new SqlConnection(cadenaConexion);
            this.comando = new SqlCommand();
        }

        public void setearProcedimiento(string procedimiento)
        {
            this.comando.Connection = conexion;
            this.comando.CommandType = System.Data.CommandType.StoredProcedure;
            this.comando.CommandText = procedimiento;
        }

        public void ejecutarLectura()
        {
            try
            {
                this.conexion.Open();
                Lector = this.comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            try
            {
                 this.conexion.Open();
                 this.comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int ejecutarAccionScalar()
        {
            try
            {
                conexion.Open();
                return int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void setearParametros(string nombre, object value)
        {
            this.comando.Parameters.AddWithValue(nombre, value);
        }

        public void setearParametros(object value)
        {
            this.comando.Parameters.Add(value);
        }
        
    }
}