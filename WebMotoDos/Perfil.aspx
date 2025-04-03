<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="WebMotoDos.Perfil" %>
<%@ Register Src="~/Header.ascx" TagPrefix="uc" TagName="Header" %>
<asp:Content ID="ContentPerfilHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="ContentPerfil" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc:Header ID="Header" runat="server" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <style>

        *{
            margin:0;
            padding:0;
            box-sizing:border-box;
        }

        .body{
            margin-top:2%;    
            display:flex;
        }
        .container-contacto{
            width:50%;
            display:flex;
            flex-direction:column;
            
        }

        .container-titulo{
            display:flex;
            align-items:center;
            justify-content:center;
            margin-top:1%;  
        }

        h4{
            color:#B43F3F;
        }

        .container-datos{
            background-color:#F1F4F5;
            width:50%;
            display:flex;
            flex-direction:column;
            border-radius:5px;
        }

        .mb-4 .form-control{
            height:30px;
        }
        
        .perfil{
            font-size:50px;
        }



    </style>
    <div class="container-titulo">
        <h3 class="perfil">PERFIL</h3>
    </div>
    <div class="container body">
        <div class="container-contacto">
            <div>
                <h3>CONTACTANOS</h3>
            </div>
            <div class="mb-2">

                <h4>¿Tenes alguna pregunta?</h4>
                <h6>¡Contáctanos siempre que tengas alguna pregunta! </h6>
            </div>
            <div class="mb-2">
                <h4>Email</h4>
                <h5>MotoDos@gmail.com</h5>
            </div>
            <div class="mb-2">
                <h4>Numero</h4>
                <h5>+54 9 11 2615 5960</h5>
            </div>
            <div class="mb-2">
                <h4>Atencion al cliente</h4>
                <h5>CABA, Almagro, Av.Rivadavia 1771</h5>
            </div>
        </div>
        <div class="container-fluid container-datos">
            <div class="mb-4" style="margin-top:20px;">
                <h4 class="mx-1">Nombre</h4>
                <asp:TextBox ID="txtNombre" REQUIRED CssClass="form-control w-100 mx-1" runat="server" Style="box-sizing: border-box;"></asp:TextBox>
            </div>
            <div class="mb-4">
                <h4 class="mx-1">Apellido</h4>
                <asp:TextBox ID="txtApellido" REQUIRED CssClass="form-control w-100 mx-1" runat="server" Style="box-sizing: border-box;"></asp:TextBox>
            </div>
            <div class="mb-4">
                <h4 class="mx-1">Email</h4>
                <asp:TextBox ID="txtEmail" REQUIRED CssClass="form-control w-100 mx-1" runat="server" Style="box-sizing: border-box;"></asp:TextBox>
            </div>
            <div class="mb-4 text-center">
                <p>
                    <button class="btn btn-danger" style="margin-bottom:20px;" type="button" data-bs-toggle="collapse" data-bs-target="#collapseWidthExample" aria-expanded="false" aria-controls="collapseWidthExample">
                        Cambiar contraseña
                    </button>
                </p>
                <div style="display:flex;justify-content:center;">
                    <div class="mb-4 collapse collapse-horizontal" id="collapseWidthExample">
                        <div class="card card-body" style="width: 300px;">
                            <asp:TextBox ID="txtContraseña" CssClass="form-control w-100" placeholder="Ingrese su nueva contraseña" runat="server"></asp:TextBox>
               
                        </div>
                    </div>
                </div>
            </div>
            <div class="d-flex justify-content-center">
                <asp:Button ID="btnGuardarCambios" OnClick="btnGuardarCambios_Click" CssClass="btn btn-dark" Style="width:180px;margin-bottom:20px;" runat="server" Text="Guardar cambios"
                    OnClientClick="$('#exampleModal').modal('show'); return false;"/>
            </div>
            <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h1 class="modal-title fs-5" id="exampleModalLabel">Modal title</h1>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            ...
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                            <button type="button" class="btn btn-primary">Save changes</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
