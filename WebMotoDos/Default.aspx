<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebMotoDos.Default" Async="true" %>
<%@ Register Src="~/Header.ascx" TagPrefix="uc" TagName="Header" %>

<asp:Content ID="ContentHomeHead" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</asp:Content>

<asp:Content ID="ContentHome" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc:Header ID="Header" runat="server" />
    <div class="container-fluid" id="contenedor-presentacion">
        <div class="izquierda">
            <h1 class="titulo-presentacion"> MOTO  <span class="creative"> DOS </span></h1>
            <p id="subtitulo-presentacion"> Bienvenido a MotoDos, tu destino confiable para la compra y venta de motos usadas. Nos especializamos en ofrecerte una amplia seleccion de motos para que vos puedas adquirir cualquier tipo de moto que desees."</p>
            <div class="linkCompra">
                <asp:Button ID="btnComprar" OnClick="btnComprar_Click" CssClass="btn btn-dark btnComprar" runat="server" Text="Comprar" />
            </div>
        </div>
        <div class="derecha">
        </div>
    </div>

    <div class="seccion-motos"> 
        <div class="titulo">
            <h1 class="mi-titulo">ELEGI TU PROXIMA MOTO</h1>        </div>

        <div class="container">
            <div class="swiper-container">
                <div class="swiper-wrapper">
                    <asp:Repeater ID="repRepetidor" runat="server">
                        <ItemTemplate>
                            <div class="swiper-slide card" style="min-width:180px;">
                                <div class="image-box">
                                    <img src="<%#Eval("UrlImagen")%>" />
                                </div>
                                <div class="detalle-moto">
                                    <div class="informacion-moto">
                                        <div class="marca-modelo">
                                            <h4 id="marca-moto"><%#Eval("Marca") %></h4>
                                            <h4 class="Modelo"><%#Eval("Modelo") %></h4>
                                        </div>
                                        <div class="año-cilindrada">
                                            <h5 class="Año"><%#Eval("Año") %></h5>
                                        </div>
                                    </div>
                                    <div class="boton-moto">
                                        <asp:Button ID="btnInformacionMoto" OnClick="btnInformacionMoto_Click" CommandName="infoMoto" CommandArgument='<%#Eval("Id")%>'
                                            CssClass="btn btn-danger" runat="server" Text="Ver Mas" />

                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <div class="swiper-button-next"></div>
            <div class="swiper-button-prev"></div>
            <div class="swiper-pagination"></div>
        </div>
    </div>

    <div class="container-fluid seccion-vender">
        <div class="titulo-subtitulo">
            <div class="titulo-venta">
                <h2 class="texto-venta">¿QUERES </h2>
                <h2 class="texto-venta">VENDER </h2>
                <h2 class="texto-venta">TU </h2>
                <h2 class="texto-venta">MOTO? </h2>
            </div>
            <div class="subtitulo-venta">
                <ul>
                    <li><h4> Registrate antes de vender</h4></li>
                </ul>
            </div>
        </div>
        <div class="imagen-botonVenta">
            <div class="container-info-boton">
                <ul>
                    <li><h4>A continuacion completa los formularios acerca de la informacion de la moto</h4></li>
                    <li><h4>Asegurate de tener el titulo de la propiedad de la moto</h4></li>
                    <li><h4>Toma fotos claras y detaladas de la moto a la hora de publicarla</h4></li>
                </ul>
                <div class="boton-venta">
                    <asp:Button ID="btnVenta" CssClass="btn btn-danger btnComprar" runat="server" Text="Vender" />
                </div>
            </div>
        </div>


    </div>
    <footer>
        <div class="container-sm">
            <div class="links">
                <div class="link-home">
                    <p><a href="#" class="link-danger">Home</a></p>
                </div>
                <div class="link-catalogo">
                    <p><a href="#" class="link-danger">Catalogo</a></p>
                </div>
                <div class="link-perfil">
                    <p><a href="#" class="link-danger">Perfil</a></p>
                </div>
            </div>
            <hr />
        </div>
        <div class="derechos">
            <p>
                © 2024 Check Movilidad S.A. Todos los derechos reservados. · Políticas de Privacidad · Términos y Condiciones · Defensa del Consumidor · Botón de arrepentimiento
            </p>
        </div>
    </footer>

    <style>

    

        body {
            box-sizing:border-box;
            text-decoration:none;
        }

        body, html {
            margin: 0;
            padding: 0;
        }


        #contenedor-presentacion{
            padding:0;
            height:80vh;
            display:flex;
        }

        .izquierda {
            background-color: #B43F3F;
            width:50%;
        }

        .derecha {
            background: url(https://imgs.search.brave.com/fjJryn1jfboDx5TnwV9WjK2UyqAWOmgMJ7lNwPo64To/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly91cGxv/YWRzLXNzbC53ZWJm/bG93LmNvbS82NDg2/MjVhOTA4YmRjZjYw/YWRlMjVjZDYvNjRi/MDMwMDM5OGZiYTZm/NGMzYWE3MWIxX2p1/c2Rldm95YWdlLVFw/dGVXTkNnZ0EwLXVu/c3BsYXNoLmpwZw);
            background-size:cover;
            background-position:center;
            width:50%;
            height:80vh;
        }

        .creative {
            color: white;
        }

        .titulo-presentacion{
            font-size: 4.3vw ;
            width: 50%;
            margin: auto;
            margin-bottom: 2vh;
            margin-top: 2vh;
        }

        .mi-titulo {
            font-size: 50px;
            width: 100%;
            text-align:center;
        }

        .linkCompra{
            text-align:center;
            margin-top:4vh;
        }

        p, .subtitulo-presentacion{
            font-size: 3.5vh;
            line-height: 30px;
            width: 50%;
            margin: auto;
            color: white;
            font-family: Arial, Helvetica, sans-serif;
        }

        .btnComprar {
            padding: 20px;
            text-decoration: none;
            color: white;
            border-radius: 15px;
            font-weight: bold;
            width:150px;
        }


        .seccion-motos {
            margin-top: 150px;
        }


        .container {
            width: 100%;
            overflow: hidden; 
            position:relative;
        }

        .swiper-container {
            width: 100%;
            position: relative;
        }

        .card-wrapper {
            display: flex;
            overflow: hidden;
        }

        .card {
            flex: 0 0 auto;
            width: 300px;
            margin: 10px;
            background-color: white;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 10px;
            overflow: hidden;
        }

        .image-box {
            width: 100%;
            height: auto;
            max-height: 300px; 
            overflow: hidden; 
        }

        .image-box img {
            width: 100%;
            height: 100%;
            object-fit: cover; 
        }

        .detalle-moto {
            padding: 20px;
            display:flex;
        }

        .informacion-moto{
            width:50%;
        }

        .boton-moto{
            margin-top:20%;
            display:flex;
            justify-content:end;
            align-items:center;
            width:50%;
            height:7vh;
        }

        .detalle-moto .name {
            margin-bottom: 10px;
        }

        .detalle-moto h3{
            color:black;
        }

        .marca-modelo, .año-cilindrada{
            display:flex;
            flex-direction:row;
            gap:10px;
        }

        .detalle-moto{
            color: #666;
        }

        .swiper-button-next,
        .swiper-button-prev {
            color: black;
            width: 40px;
            height: 40px;
            line-height: 40px;
            text-align: center;
            font-size: 20px;
            pointer-events: auto;
        }

        .swiper-button-next {
            right: -10px;
        }


        .swiper-pagination {
            position: absolute;
            bottom: 10px;
            left: 0;
            width: 100%;
            text-align: center;
            z-index:10;
        }

        .swiper-pagination-bullet {
            display:none;
        }

        .seccion-vender{
            margin-top:10%;
            display:flex;

        }

        .titulo-subtitulo{
            width: 50%;
            display:flex;
            flex-direction:column;
            padding-right:10%;
        }

        .titulo-venta{
            display:flex;
            flex-direction:column;
            align-items:end;

        }

        h2 {
            font-size: 70px;
        }

        .subtitulo-venta{
            display:flex;
            justify-content:end;
            width:100%;
            padding-top:15px;
        }

        .imagen-botonVenta {
            width: 50%;
            margin-right: 10%;
        }

        .container-info-boton {
            padding-top:25px;
            background-color: #D9D9D9;
            width: auto;
            max-width: 570px;
            border-radius: 10% 0 10% 0;
        }

        .boton-venta{
            margin-top:10%;
            display:flex;
            justify-content:start;
            padding-left:15px;
            padding-bottom:15px;
        }

        footer {
            margin-top: 3%;
            background-color: #343434;
            padding-top: 3%;
            padding-bottom: 3%;
        }

        .links{
            display:flex;
            width:100%;
            justify-content:space-around;
        }

        hr{
            color:white;
            border:1.5px solid;
            width:100%;
        }

        .derechos p{
            font-size:1.5em;
        }

        .derechos{
            width:100%;
        }

        
        @media(min-width: 1100px)
        {
            .image-box img{
                height:250px;
            }
        }

        @media(min-width: 900px)
        {
            .image-box img{
                height:230px;
            }
        }

        @media(min-width: 770px)
        {
            .image-box img{
                height:200px;
            }
        }

        @media(max-width:770px)
        {
            .boton-moto{
                margin-top:70%;

            }

            .image-box img{
                height:180px;
            }

            .texto-venta{
                font-size:3rem;
            }

            .container-info-boton ul li h4{
                font-size:1.1rem;
            }
        }

        @media(max-width:610px)
        {
            .titulo-logo{
                font-size: 30px;
            }


            .btnComprar {
                padding:10px;
                width:120px;
            }

            .icono-header{
                font-size:1.5rem;
            }

            #contenedor-buscador{
                width:40%;
            }

            .derechos p{
                font-size:15px;
            }

        }

        @media(max-width:500px)
        {
            .texto-venta{
                font-size:2rem;
            }

            .imagen-botonVenta{
                margin:0;
            }

            .container-info-boton ul li h4{
                font-size:0.9rem;
            }

            .subtitulo-venta ul li h4{
                font-size:18px;
            }

            .swiper-wrapper{
                height:270px;
            }

            .image-box img{
                height:120px;
            }

            .boton-moto{
                margin-top:60px;
            }
            
            .swiper-slide {
                margin:0;
            }


        }

        @media(max-width:375px)
        {
            p{
                font-size:12px;
            }


            .btnComprar{
                width:90px;
                padding:5px;
            }

            .derechos p{
                font-size:10px;
            }

            .container-info-boton ul li h4{
                font-size:0.7rem;
            }

            .texto-venta{
                font-size:1.6rem;
            }

            .izquierda h1{
                font-size:27px;
            }

        }

        
        @media(max-width:330px)
        {
            .linkCompra{
                margin-top:10px;
            }
        }


    </style>
        
    <script src="https://unpkg.com/swiper/swiper-bundle.min.js"></script>
    <script>

        function cambiarContenido() 
        {
            anchoPantalla = window.innerWidth;
            var subtituloPresentacion = document.getElementById("subtitulo-presentacion")
            var marcaMoto = document.getElementById("marca-moto");
            if (anchoPantalla < 900) {
                subtituloPresentacion.innerText = "Bienvenido a MotoDos, tu destino confiable para la compra y venta de motos usadas.";
            }
            else if (anchoPantalla < 760)
            {
                marcaMoto.style.fontSize = "20px";
            }
            else {
                subtituloPresentacion.innerText = "Bienvenido a MotoDos, tu destino confiable para la compra y venta de motos usadas. Nos especializamos en ofrecerte una amplia seleccion de motos para que vos puedas adquirir cualquier tipo de moto que desees.";
            }
        }

        window.addEventListener('DOMContentLoaded', cambiarContenido);

        document.addEventListener('DOMContentLoaded', function () {
            var swiper = new Swiper('.swiper-container', {
                loop: true,
                slidesPerView: 3,
                slidesPerGroup: 1,
                spaceBetween: 20,
                navigation: {
                    nextEl: '.swiper-button-next',
                    prevEl: '.swiper-button-prev',
                },
                pagination: {
                    el: '.swiper-pagination',
                    clickable: true,
                },
                simulateTouch: false,
                touchMove: false
            });


        });

        window.addEventListener('resize', cambiarContenido);
    </script>

</asp:Content>
