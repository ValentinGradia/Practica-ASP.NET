<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CatalogoCompras.aspx.cs" Inherits="WebMotoDos.CatalogoCompras" Async="true" %>
<%@ Register Src="~/Header.ascx" TagPrefix="uc" TagName="Header" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc:Header ID="Header" runat="server" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <style>
        *{
            margin:0;
            padding:0;
            box-sizing:border-box;
        }

        .container-body {
            margin: 2% 17% 0 17%;
            display:flex;
        }

        .catalogo-motos{
            margin-left:15%;
            display:grid;
            grid-template-columns:repeat(2,1fr);
            gap:20px;
            padding:10px;
        }

        .filtros{
            width:25%;
            position:sticky;
            text-align:center;
            height:100%;
            
        }

        #contenedorBotonFiltrar{
            margin-top:25px;
        }

        #contenedorBotonFiltrar .btn{
            width:130px;
            height:45px;
        }

        .textbox{
            width:100px;
        }

        #cuerpoMarcas, #cuerpoColores{
            display:grid;
            grid-template-columns:repeat(3,1fr);
            gap:5px;
        }

        .botones{
            width:120px;
            height:50px;
        }

        img{
            max-width:300px;
        }

    </style>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container-body">
                <div class="filtros">
                    <h1>Filtros</h1>
                    <div class="accordion accordion-flush" id="accordionFlushExample">
                        <div class="accordion-item">
                            <h2 class="accordion-header">
                                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
                                    Ubicacion
                                </button>
                            </h2>
                            <div id="flush-collapseOne" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                                <div class="accordion-body" id="cuerpo-ubicacion">
                                    <div>
                                        <label> CABA</label>
                                        <asp:CheckBox ID="cbxCaba" runat="server" />
                                    </div>
                                    <div>
                                        <label> GBA Norte</label>
                                        <asp:CheckBox ID="cbxGBANorte"  runat="server" />
                                    </div>
                                    <div>
                                        <label> GBA Oeste</label>
                                        <asp:CheckBox ID="cbxGBAOeste" runat="server" />
                                    </div>
                                    <div>
                                        <label> GBA Sur</label>
                                        <asp:CheckBox ID="cbxGBASur"  runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="accordion-item">
                            <h2 class="accordion-header">
                                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
                                    Marca
                                </button>
                            </h2>
                            <div id="flush-collapseTwo" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                                <div class="accordion-body grid-container" id="cuerpoMarcas">
                                    <div class="grid-item">
                                        <label> Marca 1</label>
                                        <asp:CheckBox ID="cbxHonda" runat="server" />
                                    </div>
                                    <div class="grid-item">
                                        <label> Marca 2</label>
                                        <asp:CheckBox ID="CheckBox2"  runat="server" />
                                    </div>
                                    <div class="grid-item">
                                        <label> Marca 3</label>
                                        <asp:CheckBox ID="CheckBox3" runat="server" />
                                    </div>
                                    <div class="grid-item">
                                        <label> Marca 4</label>
                                        <asp:CheckBox ID="CheckBox4"  runat="server" />
                                    </div>
                                    <div class="grid-item">
                                        <label> Marca 5</label>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </div>
                                    <div class="grid-item">
                                        <label> Marca 6</label>
                                        <asp:CheckBox ID="CheckBox5"  runat="server" />
                                    </div>
                                    <div class="grid-item">
                                        <label> Marca 7</label>
                                        <asp:CheckBox ID="CheckBox6" runat="server" />
                                    </div>
                                    <div class="grid-item">
                                        <label> Marca 8</label>
                                        <asp:CheckBox ID="CheckBox7"  runat="server" />
                                    </div>

                                </div>
                            </div>
                        </div>
                        <div class="accordion-item">
                            <h2 class="accordion-header">
                                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseThree" aria-expanded="false" aria-controls="flush-collapseThree">
                                    Color
                                </button>
                            </h2>
                            <div id="flush-collapseThree" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                                <div class="accordion-body" id="cuerpoColores">
                                    <div>
                                        <label>Color 1</label>
                                        <asp:CheckBox ID="CheckBox8" runat="server" />
                                    </div>
                                    <div>
                                        <label>Color 2</label>
                                        <asp:CheckBox ID="CheckBox9" runat="server" />
                                    </div>
                                    <div>
                                        <label>Color 3</label>
                                        <asp:CheckBox ID="CheckBox10" runat="server" />
                                    </div>
                                    <div>
                                        <label>Color 4</label>
                                        <asp:CheckBox ID="CheckBox11" runat="server" />
                                    </div>
                                    <div>
                                        <label>Color 5</label>
                                        <asp:CheckBox ID="CheckBox12" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="accordion-item">
                            <h2 class="accordion-header">
                                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseFour" aria-expanded="false" aria-controls="flush-collapseFour">
                                    Precio
                                </button>
                            </h2>
                            <div id="flush-collapseFour" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                                <div class="accordion-body">
                                    <asp:TextBox ID="txtMinimoPrecio" CssClass="textbox" placeholder="Minimo" runat="server"></asp:TextBox>
                                    <i class="fa-solid fa-minus"></i>
                                    <asp:TextBox ID="txtMaximoPrecio" CssClass="textbox" placeholder="Maximo" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="accordion-item">
                            <h2 class="accordion-header">
                                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseFive" aria-expanded="false" aria-controls="flush-collapseFive">
                                    Kilometros
                                </button>
                            </h2>
                            <div id="flush-collapseFive" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                                <div class="accordion-body">
                                    <asp:TextBox ID="txtMinimoKm" CssClass="textbox" placeholder="Minimo" runat="server"></asp:TextBox>
                                    <i class="fa-solid fa-minus"></i>
                                    <asp:TextBox ID="txtMaximoKm" CssClass="textbox" placeholder="Maximo" runat="server"></asp:TextBox>
                                 </div>
                            </div>
                        </div>
                        <div class="accordion-item">
                            <h2 class="accordion-header">
                                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseSix" aria-expanded="false" aria-controls="flush-collapseSix">
                                    Año
                                </button>
                            </h2>
                            <div id="flush-collapseSix" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                                <div class="accordion-body">
                                    <asp:TextBox ID="txtMinimoAño" CssClass="textbox" placeholder="Minimo" runat="server"></asp:TextBox>
                                    <i class="fa-solid fa-minus"></i>
                                    <asp:TextBox ID="txtMaximoAño" CssClass="textbox" placeholder="Maximo" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="accordion-item" id="contenedorBotonFiltrar">
                            <asp:Button ID="btnFiltrar" CssClass="btn btn-danger" runat="server" Text="Filtrar" />
                        </div>
                    </div>
                </div>
                <div class="catalogo-motos">
                    <asp:Repeater ID="repRepetidor" runat="server">
                        <ItemTemplate>
                            <div class="card" style="min-width:180px; max-width:300px;">
                                <div class="image-box">
                                    <img style="height:250px; width:300px" src="<%#Eval("UrlImagen")%>" />
                                </div>
                                <div class="detalle-moto" style="padding-left:10px; display:flex;justify-content:space-around;margin-top:10px;">
                                    <div class="informacion-moto">
                                        <div class="marca-modelo">
                                            <h4 id="marca-moto"><%#Eval("Marca") %></h4>
                                            <h4 class="Modelo"><%#Eval("Modelo") %></h4>
                                        </div>
                                        <div class="año-cilindrada">
                                            <h5 class="Año"><%#Eval("Año") %></h5>
                                        </div>
                                    </div>
                                    <div class="boton-moto" style="margin-top:20px;">
                                        <asp:Button ID="btnInformacionMoto" OnClick="btnInformacionMoto_Click" CommandName="infoMoto" CommandArgument='<%#Eval("Id")%>'
                                            CssClass="btn btn-danger" runat="server" Text="Ver Mas" />
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                    <div style="text-align:center;">
                        <asp:Button ID="btnAnterior" CssClass="btn btn-dark botones" runat="server" Text="Anterior" OnClick="btnAnterior_Click" />
                    </div>
                    <div style="text-align:center;"> 

                        <asp:Button ID="btnSiguiente"  CssClass="btn btn-dark botones" runat="server" Text="Siguiente" OnClick="btnSiguiente_Click" />
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
