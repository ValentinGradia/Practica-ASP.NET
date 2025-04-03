﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMotoDos.Controllers;
using WebMotoDos.Models;

namespace WebMotoDos
{
    public partial class CatalogoCompras : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //List<Moto> lista = MotoController.obtenerMotos();
                List<Moto> motos = new List<Moto>
        {
            new Moto { Id = 1, Marca = "Honda", Cilindrada = "250cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.CABA, Precio = 150000, Modelo = "CBR250R", Km = 12000, Año = 2018, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/BoKag2ChZGQzciZMQNL-7NB9h5rRP1q4Lg66L-sgdsc/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTYw/OTExNjMxL3Bob3Rv/L3NpbHZlci1tb3Rv/cmN5Y2xlLmpwZz9z/PTYxMng2MTImdz0w/Jms9MjAmYz1wVzli/Z29uN3NwZWVtek9Z/TGpYaTlWaEVPMkRT/aXJSdWRqb1gtaVJh/elhRPQ", Descripcion = "Moto deportiva en excelente estado.", Vendida = false },
            new Moto { Id = 2, Marca = "Yamaha", Cilindrada = "150cc", Tipo = "Street", Ubicacion = Ubicaciones.GBANorte, Precio = 100000, Modelo = "FZ-S", Km = 8000, Año = 2019, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/pYrKNFl7S8r1NONRW_Cz0tJpw2ThMt_CuRuV72EKRGg/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvNDU4/MTA3MjgxL3Bob3Rv/L3ZlcnktZmFzdC1i/aWtlLmpwZz9zPTYx/Mng2MTImdz0wJms9/MjAmYz1ObUhVYi1i/OW90akFZY0xrb2hG/YUViaGtiM1hwTGxv/aFpsckR4ODRaZktF/PQ", Descripcion = "Moto ligera y ágil, ideal para ciudad.", Vendida = true },
            new Moto { Id = 3, Marca = "Suzuki", Cilindrada = "300cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBASur, Precio = 200000, Modelo = "GSX300", Km = 5000, Año = 2020, Color = "Azul", UrlImagen = "https://imgs.search.brave.com/BoKag2ChZGQzciZMQNL-7NB9h5rRP1q4Lg66L-sgdsc/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTYw/OTExNjMxL3Bob3Rv/L3NpbHZlci1tb3Rv/cmN5Y2xlLmpwZz9z/PTYxMng2MTImdz0w/Jms9MjAmYz1wVzli/Z29uN3NwZWVtek9Z/TGpYaTlWaEVPMkRT/aXJSdWRqb1gtaVJh/elhRPQ", Descripcion = "Moto naked con gran potencia.", Vendida = false },
            new Moto { Id = 4, Marca = "Kawasaki", Cilindrada = "600cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBAOeste, Precio = 350000, Modelo = "Ninja 600", Km = 15000, Año = 2017, Color = "Verde", UrlImagen = "https://imgs.search.brave.com/pYrKNFl7S8r1NONRW_Cz0tJpw2ThMt_CuRuV72EKRGg/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvNDU4/MTA3MjgxL3Bob3Rv/L3ZlcnktZmFzdC1i/aWtlLmpwZz9zPTYx/Mng2MTImdz0wJms9/MjAmYz1ObUhVYi1i/OW90akFZY0xrb2hG/YUViaGtiM1hwTGxv/aFpsckR4ODRaZktF/PQ", Descripcion = "Moto deportiva de alto rendimiento.", Vendida = false },
            new Moto { Id = 5, Marca = "BMW", Cilindrada = "1200cc", Tipo = "Touring", Ubicacion = Ubicaciones.CABA, Precio = 500000, Modelo = "R1200GS", Km = 25000, Año = 2016, Color = "Gris", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto touring para largas distancias.", Vendida = true },
            new Moto { Id = 6, Marca = "Ducati", Cilindrada = "800cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBANorte, Precio = 450000, Modelo = "Monster 821", Km = 10000, Año = 2019, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto deportiva con estilo italiano.", Vendida = false },
            new Moto { Id = 7, Marca = "Triumph", Cilindrada = "900cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBASur, Precio = 400000, Modelo = "Street Triple", Km = 7000, Año = 2020, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/pYrKNFl7S8r1NONRW_Cz0tJpw2ThMt_CuRuV72EKRGg/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvNDU4/MTA3MjgxL3Bob3Rv/L3ZlcnktZmFzdC1i/aWtlLmpwZz9zPTYx/Mng2MTImdz0wJms9/MjAmYz1ObUhVYi1i/OW90akFZY0xrb2hG/YUViaGtiM1hwTGxv/aFpsckR4ODRaZktF/PQ", Descripcion = "Moto naked con excelente manejo.", Vendida = true },
            new Moto { Id = 8, Marca = "Harley-Davidson", Cilindrada = "1200cc", Tipo = "Cruiser", Ubicacion = Ubicaciones.GBAOeste, Precio = 600000, Modelo = "Iron 1200", Km = 3000, Año = 2021, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto cruiser con gran estilo.", Vendida = false },
            new Moto { Id = 9, Marca = "KTM", Cilindrada = "390cc", Tipo = "Adventure", Ubicacion = Ubicaciones.CABA, Precio = 250000, Modelo = "390 Adventure", Km = 12000, Año = 2021, Color = "Naranja", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto adventure lista para cualquier terreno.", Vendida = false },
            new Moto { Id = 10, Marca = "Royal Enfield", Cilindrada = "500cc", Tipo = "Classic", Ubicacion = Ubicaciones.GBANorte, Precio = 220000, Modelo = "Classic 500", Km = 10000, Año = 2018, Color = "Verde", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto clásica con encanto retro.", Vendida = true },
            new Moto { Id = 11, Marca = "Aprilia", Cilindrada = "900cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBASur, Precio = 480000, Modelo = "RSV4", Km = 5000, Año = 2021, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto deportiva de alta gama.", Vendida = false },
            new Moto { Id = 12, Marca = "MV Agusta", Cilindrada = "800cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBAOeste, Precio = 470000, Modelo = "Brutale 800", Km = 4000, Año = 2021, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto naked con diseño agresivo.", Vendida = false },
            new Moto { Id = 13, Marca = "Honda", Cilindrada = "150cc", Tipo = "Street", Ubicacion = Ubicaciones.CABA, Precio = 90000, Modelo = "CBF150", Km = 15000, Año = 2016, Color = "Blanco", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto street económica y confiable.", Vendida = true },
            new Moto { Id = 14, Marca = "Yamaha", Cilindrada = "250cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBANorte, Precio = 130000, Modelo = "YZF-R3", Km = 7000, Año = 2018, Color = "Azul", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto deportiva para principiantes.", Vendida = false },
            new Moto { Id = 15, Marca = "Suzuki", Cilindrada = "600cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBASur, Precio = 370000, Modelo = "GSX-R600", Km = 12000, Año = 2017, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto deportiva de alto rendimiento.", Vendida = true },
            new Moto { Id = 16, Marca = "Kawasaki", Cilindrada = "400cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBAOeste, Precio = 210000, Modelo = "Z400", Km = 8000, Año = 2019, Color = "Verde", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto naked ágil y rápida.", Vendida = false },
            new Moto { Id = 17, Marca = "BMW", Cilindrada = "750cc", Tipo = "Adventure", Ubicacion = Ubicaciones.CABA, Precio = 460000, Modelo = "F750GS", Km = 6000, Año = 2020, Color = "Amarillo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto adventure con gran tecnología.", Vendida = true },
            new Moto { Id = 18, Marca = "Ducati", Cilindrada = "1200cc", Tipo = "Touring", Ubicacion = Ubicaciones.GBANorte, Precio = 550000, Modelo = "Multistrada 1200", Km = 10000, Año = 2018, Color = "Rojo", UrlImagen = "https://example.com/moto18.jpg", Descripcion = "Moto touring potente y cómoda.", Vendida = false },
            new Moto { Id = 19, Marca = "Triumph", Cilindrada = "675cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBASur, Precio = 420000, Modelo = "Daytona 675", Km = 8000, Año = 2019, Color = "Blanco", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto deportiva con gran manejo.", Vendida = false }
                };
                List<Moto> primerasMotos = motos.Take(4).ToList();
                Session.Add("listaMotos", motos);
                Session.Add("indiceActual", 4);
                repRepetidor.DataSource = primerasMotos;
                repRepetidor.DataBind();
            }
        }

        protected void btnAnterior_Click(object sender, EventArgs e)
        {
            if ((int)Session["indiceActual"] != 4)
            {
                //List<Moto> lista = MotoController.obtenerMotos();
                List<Moto> lista = new List<Moto>
        {
            new Moto { Id = 1, Marca = "Honda", Cilindrada = "250cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.CABA, Precio = 150000, Modelo = "CBR250R", Km = 12000, Año = 2018, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/BoKag2ChZGQzciZMQNL-7NB9h5rRP1q4Lg66L-sgdsc/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTYw/OTExNjMxL3Bob3Rv/L3NpbHZlci1tb3Rv/cmN5Y2xlLmpwZz9z/PTYxMng2MTImdz0w/Jms9MjAmYz1wVzli/Z29uN3NwZWVtek9Z/TGpYaTlWaEVPMkRT/aXJSdWRqb1gtaVJh/elhRPQ", Descripcion = "Moto deportiva en excelente estado.", Vendida = false },
            new Moto { Id = 2, Marca = "Yamaha", Cilindrada = "150cc", Tipo = "Street", Ubicacion = Ubicaciones.GBANorte, Precio = 100000, Modelo = "FZ-S", Km = 8000, Año = 2019, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/pYrKNFl7S8r1NONRW_Cz0tJpw2ThMt_CuRuV72EKRGg/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvNDU4/MTA3MjgxL3Bob3Rv/L3ZlcnktZmFzdC1i/aWtlLmpwZz9zPTYx/Mng2MTImdz0wJms9/MjAmYz1ObUhVYi1i/OW90akFZY0xrb2hG/YUViaGtiM1hwTGxv/aFpsckR4ODRaZktF/PQ", Descripcion = "Moto ligera y ágil, ideal para ciudad.", Vendida = true },
            new Moto { Id = 3, Marca = "Suzuki", Cilindrada = "300cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBASur, Precio = 200000, Modelo = "GSX300", Km = 5000, Año = 2020, Color = "Azul", UrlImagen = "https://imgs.search.brave.com/BoKag2ChZGQzciZMQNL-7NB9h5rRP1q4Lg66L-sgdsc/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTYw/OTExNjMxL3Bob3Rv/L3NpbHZlci1tb3Rv/cmN5Y2xlLmpwZz9z/PTYxMng2MTImdz0w/Jms9MjAmYz1wVzli/Z29uN3NwZWVtek9Z/TGpYaTlWaEVPMkRT/aXJSdWRqb1gtaVJh/elhRPQ", Descripcion = "Moto naked con gran potencia.", Vendida = false },
            new Moto { Id = 4, Marca = "Kawasaki", Cilindrada = "600cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBAOeste, Precio = 350000, Modelo = "Ninja 600", Km = 15000, Año = 2017, Color = "Verde", UrlImagen = "https://imgs.search.brave.com/pYrKNFl7S8r1NONRW_Cz0tJpw2ThMt_CuRuV72EKRGg/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvNDU4/MTA3MjgxL3Bob3Rv/L3ZlcnktZmFzdC1i/aWtlLmpwZz9zPTYx/Mng2MTImdz0wJms9/MjAmYz1ObUhVYi1i/OW90akFZY0xrb2hG/YUViaGtiM1hwTGxv/aFpsckR4ODRaZktF/PQ", Descripcion = "Moto deportiva de alto rendimiento.", Vendida = false },
            new Moto { Id = 5, Marca = "BMW", Cilindrada = "1200cc", Tipo = "Touring", Ubicacion = Ubicaciones.CABA, Precio = 500000, Modelo = "R1200GS", Km = 25000, Año = 2016, Color = "Gris", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto touring para largas distancias.", Vendida = true },
            new Moto { Id = 6, Marca = "Ducati", Cilindrada = "800cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBANorte, Precio = 450000, Modelo = "Monster 821", Km = 10000, Año = 2019, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto deportiva con estilo italiano.", Vendida = false },
            new Moto { Id = 7, Marca = "Triumph", Cilindrada = "900cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBASur, Precio = 400000, Modelo = "Street Triple", Km = 7000, Año = 2020, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/pYrKNFl7S8r1NONRW_Cz0tJpw2ThMt_CuRuV72EKRGg/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvNDU4/MTA3MjgxL3Bob3Rv/L3ZlcnktZmFzdC1i/aWtlLmpwZz9zPTYx/Mng2MTImdz0wJms9/MjAmYz1ObUhVYi1i/OW90akFZY0xrb2hG/YUViaGtiM1hwTGxv/aFpsckR4ODRaZktF/PQ", Descripcion = "Moto naked con excelente manejo.", Vendida = true },
            new Moto { Id = 8, Marca = "Harley-Davidson", Cilindrada = "1200cc", Tipo = "Cruiser", Ubicacion = Ubicaciones.GBAOeste, Precio = 600000, Modelo = "Iron 1200", Km = 3000, Año = 2021, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto cruiser con gran estilo.", Vendida = false },
            new Moto { Id = 9, Marca = "KTM", Cilindrada = "390cc", Tipo = "Adventure", Ubicacion = Ubicaciones.CABA, Precio = 250000, Modelo = "390 Adventure", Km = 12000, Año = 2021, Color = "Naranja", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto adventure lista para cualquier terreno.", Vendida = false },
            new Moto { Id = 10, Marca = "Royal Enfield", Cilindrada = "500cc", Tipo = "Classic", Ubicacion = Ubicaciones.GBANorte, Precio = 220000, Modelo = "Classic 500", Km = 10000, Año = 2018, Color = "Verde", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto clásica con encanto retro.", Vendida = true },
            new Moto { Id = 11, Marca = "Aprilia", Cilindrada = "900cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBASur, Precio = 480000, Modelo = "RSV4", Km = 5000, Año = 2021, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto deportiva de alta gama.", Vendida = false },
            new Moto { Id = 12, Marca = "MV Agusta", Cilindrada = "800cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBAOeste, Precio = 470000, Modelo = "Brutale 800", Km = 4000, Año = 2021, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto naked con diseño agresivo.", Vendida = false },
            new Moto { Id = 13, Marca = "Honda", Cilindrada = "150cc", Tipo = "Street", Ubicacion = Ubicaciones.CABA, Precio = 90000, Modelo = "CBF150", Km = 15000, Año = 2016, Color = "Blanco", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto street económica y confiable.", Vendida = true },
            new Moto { Id = 14, Marca = "Yamaha", Cilindrada = "250cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBANorte, Precio = 130000, Modelo = "YZF-R3", Km = 7000, Año = 2018, Color = "Azul", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto deportiva para principiantes.", Vendida = false },
            new Moto { Id = 15, Marca = "Suzuki", Cilindrada = "600cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBASur, Precio = 370000, Modelo = "GSX-R600", Km = 12000, Año = 2017, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto deportiva de alto rendimiento.", Vendida = true },
            new Moto { Id = 16, Marca = "Kawasaki", Cilindrada = "400cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBAOeste, Precio = 210000, Modelo = "Z400", Km = 8000, Año = 2019, Color = "Verde", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto naked ágil y rápida.", Vendida = false },
            new Moto { Id = 17, Marca = "BMW", Cilindrada = "750cc", Tipo = "Adventure", Ubicacion = Ubicaciones.CABA, Precio = 460000, Modelo = "F750GS", Km = 6000, Año = 2020, Color = "Amarillo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto adventure con gran tecnología.", Vendida = true },
            new Moto { Id = 18, Marca = "Ducati", Cilindrada = "1200cc", Tipo = "Touring", Ubicacion = Ubicaciones.GBANorte, Precio = 550000, Modelo = "Multistrada 1200", Km = 10000, Año = 2018, Color = "Rojo", UrlImagen = "https://example.com/moto18.jpg", Descripcion = "Moto touring potente y cómoda.", Vendida = false },
            new Moto { Id = 19, Marca = "Triumph", Cilindrada = "675cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBASur, Precio = 420000, Modelo = "Daytona 675", Km = 8000, Año = 2019, Color = "Blanco", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto deportiva con gran manejo.", Vendida = false }
                };
                int indices = (int)Session["indiceActual"];
                List<Moto> motos = lista.Skip(indices - 8).Take(4).ToList();
                Session["indiceActual"] = indices - 4;
                repRepetidor.DataSource = motos;
                repRepetidor.DataBind();
            }
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {

            //var lista =  MotoController.obtenerMotos();
            List<Moto> lista = new List<Moto>
        {
            new Moto { Id = 1, Marca = "Honda", Cilindrada = "250cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.CABA, Precio = 150000, Modelo = "CBR250R", Km = 12000, Año = 2018, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/BoKag2ChZGQzciZMQNL-7NB9h5rRP1q4Lg66L-sgdsc/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTYw/OTExNjMxL3Bob3Rv/L3NpbHZlci1tb3Rv/cmN5Y2xlLmpwZz9z/PTYxMng2MTImdz0w/Jms9MjAmYz1wVzli/Z29uN3NwZWVtek9Z/TGpYaTlWaEVPMkRT/aXJSdWRqb1gtaVJh/elhRPQ", Descripcion = "Moto deportiva en excelente estado.", Vendida = false },
            new Moto { Id = 2, Marca = "Yamaha", Cilindrada = "150cc", Tipo = "Street", Ubicacion = Ubicaciones.GBANorte, Precio = 100000, Modelo = "FZ-S", Km = 8000, Año = 2019, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/pYrKNFl7S8r1NONRW_Cz0tJpw2ThMt_CuRuV72EKRGg/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvNDU4/MTA3MjgxL3Bob3Rv/L3ZlcnktZmFzdC1i/aWtlLmpwZz9zPTYx/Mng2MTImdz0wJms9/MjAmYz1ObUhVYi1i/OW90akFZY0xrb2hG/YUViaGtiM1hwTGxv/aFpsckR4ODRaZktF/PQ", Descripcion = "Moto ligera y ágil, ideal para ciudad.", Vendida = true },
            new Moto { Id = 3, Marca = "Suzuki", Cilindrada = "300cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBASur, Precio = 200000, Modelo = "GSX300", Km = 5000, Año = 2020, Color = "Azul", UrlImagen = "https://imgs.search.brave.com/BoKag2ChZGQzciZMQNL-7NB9h5rRP1q4Lg66L-sgdsc/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTYw/OTExNjMxL3Bob3Rv/L3NpbHZlci1tb3Rv/cmN5Y2xlLmpwZz9z/PTYxMng2MTImdz0w/Jms9MjAmYz1wVzli/Z29uN3NwZWVtek9Z/TGpYaTlWaEVPMkRT/aXJSdWRqb1gtaVJh/elhRPQ", Descripcion = "Moto naked con gran potencia.", Vendida = false },
            new Moto { Id = 4, Marca = "Kawasaki", Cilindrada = "600cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBAOeste, Precio = 350000, Modelo = "Ninja 600", Km = 15000, Año = 2017, Color = "Verde", UrlImagen = "https://imgs.search.brave.com/pYrKNFl7S8r1NONRW_Cz0tJpw2ThMt_CuRuV72EKRGg/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvNDU4/MTA3MjgxL3Bob3Rv/L3ZlcnktZmFzdC1i/aWtlLmpwZz9zPTYx/Mng2MTImdz0wJms9/MjAmYz1ObUhVYi1i/OW90akFZY0xrb2hG/YUViaGtiM1hwTGxv/aFpsckR4ODRaZktF/PQ", Descripcion = "Moto deportiva de alto rendimiento.", Vendida = false },
            new Moto { Id = 5, Marca = "BMW", Cilindrada = "1200cc", Tipo = "Touring", Ubicacion = Ubicaciones.CABA, Precio = 500000, Modelo = "R1200GS", Km = 25000, Año = 2016, Color = "Gris", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto touring para largas distancias.", Vendida = true },
            new Moto { Id = 6, Marca = "Ducati", Cilindrada = "800cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBANorte, Precio = 450000, Modelo = "Monster 821", Km = 10000, Año = 2019, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto deportiva con estilo italiano.", Vendida = false },
            new Moto { Id = 7, Marca = "Triumph", Cilindrada = "900cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBASur, Precio = 400000, Modelo = "Street Triple", Km = 7000, Año = 2020, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/pYrKNFl7S8r1NONRW_Cz0tJpw2ThMt_CuRuV72EKRGg/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvNDU4/MTA3MjgxL3Bob3Rv/L3ZlcnktZmFzdC1i/aWtlLmpwZz9zPTYx/Mng2MTImdz0wJms9/MjAmYz1ObUhVYi1i/OW90akFZY0xrb2hG/YUViaGtiM1hwTGxv/aFpsckR4ODRaZktF/PQ", Descripcion = "Moto naked con excelente manejo.", Vendida = true },
            new Moto { Id = 8, Marca = "Harley-Davidson", Cilindrada = "1200cc", Tipo = "Cruiser", Ubicacion = Ubicaciones.GBAOeste, Precio = 600000, Modelo = "Iron 1200", Km = 3000, Año = 2021, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto cruiser con gran estilo.", Vendida = false },
            new Moto { Id = 9, Marca = "KTM", Cilindrada = "390cc", Tipo = "Adventure", Ubicacion = Ubicaciones.CABA, Precio = 250000, Modelo = "390 Adventure", Km = 12000, Año = 2021, Color = "Naranja", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto adventure lista para cualquier terreno.", Vendida = false },
            new Moto { Id = 10, Marca = "Royal Enfield", Cilindrada = "500cc", Tipo = "Classic", Ubicacion = Ubicaciones.GBANorte, Precio = 220000, Modelo = "Classic 500", Km = 10000, Año = 2018, Color = "Verde", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto clásica con encanto retro.", Vendida = true },
            new Moto { Id = 11, Marca = "Aprilia", Cilindrada = "900cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBASur, Precio = 480000, Modelo = "RSV4", Km = 5000, Año = 2021, Color = "Negro", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto deportiva de alta gama.", Vendida = false },
            new Moto { Id = 12, Marca = "MV Agusta", Cilindrada = "800cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBAOeste, Precio = 470000, Modelo = "Brutale 800", Km = 4000, Año = 2021, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto naked con diseño agresivo.", Vendida = false },
            new Moto { Id = 13, Marca = "Honda", Cilindrada = "150cc", Tipo = "Street", Ubicacion = Ubicaciones.CABA, Precio = 90000, Modelo = "CBF150", Km = 15000, Año = 2016, Color = "Blanco", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto street económica y confiable.", Vendida = true },
            new Moto { Id = 14, Marca = "Yamaha", Cilindrada = "250cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBANorte, Precio = 130000, Modelo = "YZF-R3", Km = 7000, Año = 2018, Color = "Azul", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto deportiva para principiantes.", Vendida = false },
            new Moto { Id = 15, Marca = "Suzuki", Cilindrada = "600cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBASur, Precio = 370000, Modelo = "GSX-R600", Km = 12000, Año = 2017, Color = "Rojo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto deportiva de alto rendimiento.", Vendida = true },
            new Moto { Id = 16, Marca = "Kawasaki", Cilindrada = "400cc", Tipo = "Naked", Ubicacion = Ubicaciones.GBAOeste, Precio = 210000, Modelo = "Z400", Km = 8000, Año = 2019, Color = "Verde", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto naked ágil y rápida.", Vendida = false },
            new Moto { Id = 17, Marca = "BMW", Cilindrada = "750cc", Tipo = "Adventure", Ubicacion = Ubicaciones.CABA, Precio = 460000, Modelo = "F750GS", Km = 6000, Año = 2020, Color = "Amarillo", UrlImagen = "https://imgs.search.brave.com/sgg8JAu_vtAaZlhxWXnaEp1TO-_WkrFiuWhHyR7q7sQ/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9tZWRp/YS5nZXR0eWltYWdl/cy5jb20vaWQvMTE4/NjM0ODIxNy9waG90/by9ibGFjay1tb3Rv/cmN5Y2xlLWRyaXZl/ci5qcGc_cz02MTJ4/NjEyJnc9MCZrPTIw/JmM9cGxYUThzYjZE/ZWdWMkI2Y1NvMTAy/MzRRRjVnTkt3Vk9o/dGxvaWx2OG1yYz0", Descripcion = "Moto adventure con gran tecnología.", Vendida = true },
            new Moto { Id = 18, Marca = "Ducati", Cilindrada = "1200cc", Tipo = "Touring", Ubicacion = Ubicaciones.GBANorte, Precio = 550000, Modelo = "Multistrada 1200", Km = 10000, Año = 2018, Color = "Rojo", UrlImagen = "https://example.com/moto18.jpg", Descripcion = "Moto touring potente y cómoda.", Vendida = false },
            new Moto { Id = 19, Marca = "Triumph", Cilindrada = "675cc", Tipo = "Deportiva", Ubicacion = Ubicaciones.GBASur, Precio = 420000, Modelo = "Daytona 675", Km = 8000, Año = 2019, Color = "Blanco", UrlImagen = "https://imgs.search.brave.com/Up0Q56ekR7hECBxwIHfpQOtF-fVfGVrr0S_YYS6yX-E/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9pbWcu/ZnJlZXBpay5jb20v/ZnJlZS1waG90by9i/aWtlci1yaWRpbmct/bW90b3JjeWNsZV83/NTAyLTQ5NTkuanBn/P3NpemU9NjI2JmV4/dD1qcGc", Descripcion = "Moto deportiva con gran manejo.", Vendida = false }
                };
            int indices = (int)Session["indiceActual"];
            List<Moto> motos = lista.Skip(indices).Take(4).ToList();
            Session["indiceActual"] = indices + 4;
            repRepetidor.DataSource = motos;
            repRepetidor.DataBind();
        }

        protected void btnInformacionMoto_Click(object sender, EventArgs e)
        {
            
        }
    }
}