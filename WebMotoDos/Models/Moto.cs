using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMotoDos.Models
{
    public enum Ubicaciones
    {
        CABA = 0,
        GBANorte = 1,
        GBASur = 2,
        GBAOeste = 3
    }

    public class Moto
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Cilindrada { get; set; }

        public string Tipo { get; set; }

        public Ubicaciones Ubicacion { get; set; }

        public decimal Precio {  get; set; }

        public string Modelo {  get; set; }

        public int Km {  get; set; }

        public int Año { get; set; }

        public string Color {  get; set; }

        public string UrlImagen { get; set; }

        public string Descripcion { get; set; }

        public bool Vendida { get; set; }

        public Moto() { }
    }
}