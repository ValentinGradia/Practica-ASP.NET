<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="WebMotoDos.Header1" %>
    <script type="text/javascript">

        document.addEventListener("DOMContentLoaded", function () {
            var anchoPantalla = window.innerWidth;
            var btnDesplegable = document.getElementById("boton-desplegable-links");
            var contenedorLinks = document.getElementById("offcanvasNavbar");
            var iconoPerfil = document.getElementById("iconoPerfil");
            var iconoFavoritos = document.getElementById("icono-favs");
            var contenedorIconos = document.getElementById("contenedor-iconos");

            if (anchoPantalla < 650) {
                btnDesplegable.style.display = "inline-block";
                contenedorLinks.style.display = "flex";
                iconoPerfil.style.display = "none";
                iconoFavoritos.style.display = "none";
                contenedorIconos.style.justifyContent = "center";
            }

            else {
                btnDesplegable.style.display = "none";
                contenedorLinks.style.display = "none";
                iconoPerfil.style.display = "inline-block";
                iconoFavoritos.style.display = "inline-block";
                contenedorIconos.style.justifyContent = "end";
            }
        });
    </script>
    <header>
     <nav class="navbar bg-body-tertiary" style="padding:0;">
         <div id="contenedor-header" style="padding:0;">
             <div id="fila-header" class="row align-items-center">
                 <div class="col d-flex justify-content-center">
                     <h2 class="titulo-logo">
                         <a style="text-decoration:none;color:white;" href="Default.aspx">MS</a>
                     </h2>
                 </div>
                 <div id="contenedor-buscador" class="col-6 d-flex">
                     <form class="d-flex" role="search">
                         <input class="form-control me-2" id="buscador" type="search" placeholder="Buscar" aria-label="Search">
                         <button class="btn btn-outline-success" type="submit"><i class="fa-solid fa-magnifying-glass"></i></button>
                     </form>
                 </div>
                 <div id="contenedor-iconos" class="col iconos d-flex">
                     <ul class="nav flex-row">
                         <li class="nav-item">
                             <div id="iconoPerfil">
                                 <asp:HyperLink ID="perfilLink" CssClass="nav-link" NavigateUrl="~/Registro.aspx" runat="server">
                                         <div class="usuario-icono">
                                             <i class="fa-solid fa-user fa-2xl icono-header" style="color: #f5efef;"></i>
                                             <p><asp:Label ID="lblUsuario" runat="server" Text="Login"></asp:Label></p>
                                         </div>
                                 </asp:HyperLink>
                             </div>
                         </li>
                         <li id="icono-favs" class="nav-item">
                             <a class="nav-link" href="#"><i class="fa-solid fa-star fa-2xl icono-header" style="color: #FFD43B;"></i></a>
                         </li>
                         <li>
                             <button style="background-color:white;" id="boton-desplegable-links" class="navbar-toggler" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasNavbar" aria-controls="offcanvasNavbar" aria-label="Toggle navigation">
                                 <span class="navbar-toggler-icon"></span>
                             </button>
                             <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasNavbar" aria-labelledby="offcanvasNavbarLabel">
                                 <div class="offcanvas-header">
                                     <h5 class="offcanvas-title" id="offcanvasNavbarLabel">MotoDos</h5>
                                     <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="Close"></button>
                                 </div>
                                 <div class="offcanvas-body">
                                     <ul class="navbar-nav justify-content-end flex-grow-1 pe-3">
                                         <li class="nav-item">
                                             <a class="nav-link" aria-current="page" href="#">Home</a>
                                         </li>
                                         <li class="nav-item">
                                             <a class="nav-link"  aria-current="page" href="#">Perfil</a>
                                         </li>
                                     </ul>
                                 </div>
                             </div>
                         </li>
                     </ul>
                 </div>
             </div>
             <div>
             </div>
         </div>

     </nav>

    <style>

        .usuario-icono{
            display:flex;
            justify-content:center;
            align-items:center;
        }

        body {
            box-sizing:border-box;
            text-decoration:none;
        }

        body, html {
            margin: 0;
            padding: 0;
        }

        #contenedor-header {
            width: 100%;
            padding: 0;
            margin:0;
            background-color: #2E2B2B;
            height:82px;
        }

        header, nav .container-fluid{
            background-color: #2E2B2B;
        }


        .titulo-logo{
            color:white;
        }

        #buscador{
            width:65%;
        }


        p{
            font-size: 3.5vh;
            line-height: 30px;
            width: 50%;
            margin: auto;
            color: white;
            font-family: Arial, Helvetica, sans-serif;
        }


        h2 {
            font-size: 70px;
        }


        @media(max-width: 750px)
        {
            .nav-link{
                padding:8px;
            }
        }

        @media(max-width:610px)
        {
            .titulo-logo{
                font-size: 30px;
            }


            .icono-header{
                font-size:1.5rem;
            }

            #contenedor-buscador{
                width:40%;
            }


        }


        @media(max-width:375px)
        {
            #subtitulo-presentacion{
                font-size:12px;

            }

        }
    </style>

    <script>
        function ajustarDesplegables() {
            var anchoPantalla = window.innerWidth;
            var btnDesplegable = document.getElementById("boton-desplegable-links");
            var contenedorLinks = document.getElementById("offcanvasNavbar");
            var iconoPerfil = document.getElementById("iconoPerfil");
            var iconoFavoritos = document.getElementById("icono-favs");
            var contenedorIconos = document.getElementById("contenedor-iconos");

            if (anchoPantalla < 650) {
                btnDesplegable.style.display = "inline-block";
                contenedorLinks.style.display = "flex";
                iconoPerfil.style.display = "none";
                iconoFavoritos.style.display = "none";
                contenedorIconos.style.justifyContent = "center";
            }

            else {
                btnDesplegable.style.display = "none";
                contenedorLinks.style.display = "none";
                iconoPerfil.style.display = "inline-block";
                iconoFavoritos.style.display = "inline-block";
                contenedorIconos.style.justifyContent = "end";
            }
        }

        window.addEventListener('resize', ajustarDesplegables);

    </script>
</header>