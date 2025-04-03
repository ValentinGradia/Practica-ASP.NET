using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Cryptography;

namespace WebMotoDos.Models
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string email;
        private string contraseña;

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Usuario() { }

        public static string HashearContraseña(string contraseña)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(contraseña);

            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] hashBytes = sHA256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach(byte b in hashBytes)
                {
                    sb.Append(b);
                }

                return sb.ToString();
            }

        }

    }
}