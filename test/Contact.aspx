<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="test.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<form >
        <div class="container">
            <div class="row">
                <div class="col-sm-5 col-sm-offset-1">

                    <h2 class="">Enviame un correo</h2>

                    <div class="form-group">
                        <label for="txtNombre" >Nombre</label>
                        <asp:TextBox ID ="txtNombre" CssClass="form-control" runat="server" required="required"></asp:TextBox>
                    </div>

                     <div class="form-group">
                        <label for="TextEmail" >Email</label>
                        <asp:TextBox ID ="TextEmail" CssClass="form-control" runat="server" required="required"></asp:TextBox>
                    </div>

                      <div class="form-group">
                        <label for="TxtMensaje">Mensaje</label>
                        <asp:TextBox ID ="TxtMensaje" CssClass="form-control " runat="server" TextMode="Multiline" ></asp:TextBox>
                    </div>

                     <div class="form-group">
                         <asp:Button ID="btnEnviar" CssClass="btn btn-primary col-sm-10" runat="server"  Text="Enviar Mensaje" Height="50px" OnClick="btnEnviar_Click" />
                    </div>

                </div>
            </div>
        </div>
        <hr />
    </form>

</asp:Content>
