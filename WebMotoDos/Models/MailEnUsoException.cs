using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMotoDos.Models
{
    public class MailEnUsoException : Exception
    {
        public MailEnUsoException(string mensaje) : base(mensaje) { }

        public MailEnUsoException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}