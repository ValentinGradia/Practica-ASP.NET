using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMotoDos.Models
{
    public class UsuarioNullException : Exception
    {
        public UsuarioNullException(string mensaje):base(mensaje) { }

        public UsuarioNullException(string mensaje,Exception inner) : base(mensaje, inner) { }
    }
}