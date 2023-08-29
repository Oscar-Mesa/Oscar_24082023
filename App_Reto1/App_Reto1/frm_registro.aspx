<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_registro.aspx.cs" Inherits="App_Reto1.frm_registro" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Formulario de Registro de Usuarios</title>
    <link rel="stylesheet" type="text/css" href="estilos/estilos.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <h3>Formulario de Registro de Crédito</h3>
            <div class="form-group">
                <asp:TextBox ID="txt_codigo" runat="server" placeholder="ID *" required ="true"></asp:TextBox> 
            </div>
            <div class="form-group">
                <asp:TextBox ID="txt_nombre" runat="server" placeholder="Nombres *"></asp:TextBox> 
            </div>
            <div class="form-group">
                <asp:TextBox ID="TextBox1" runat="server" placeholder="Apellidos *" ></asp:TextBox> 
            </div>
            <div class="form-group">
                <asp:TextBox ID="txt_contacto" runat="server" placeholder="Contacto *" ></asp:TextBox> 
            </div>
            <div class="form-group">
                <asp:TextBox ID="txt_correo" runat="server" placeholder="Correo *" ></asp:TextBox> 
            </div>
            <div class="form-group">
                <asp:TextBox ID="txt_direccion" runat="server" placeholder="Dirección *" ></asp:TextBox> 
            </div>
            <div class="form-group">
                <asp:TextBox ID="txt_salario" runat="server" placeholder="Salario *" ></asp:TextBox> 
            </div>
            <div class="form-group">
                <asp:TextBox ID="txt_empresa_labora" runat="server" placeholder="Empresa en que trabaja *" ></asp:TextBox> 
            </div>
            <div class="form-group">
                <asp:TextBox ID="txt_estado_credito" runat="server" placeholder="Estado del credito *" ></asp:TextBox> 
            </div>
            <div class="form-group">
                <asp:TextBox ID="txt_fecha_solicitud" runat="server" placeholder="Fecha de la solicitud *" ></asp:TextBox> 
            </div>

            <asp:DropDownList ID="cbx_plazo" runat="server" CssClass="cbx">
                <asp:ListItem Value="6 ">6 Meses</asp:ListItem>
                <asp:ListItem Value="12 ">12 meses</asp:ListItem>
                <asp:ListItem Value="24 ">24 meses</asp:ListItem>
                <asp:ListItem Value="36 ">36 meses</asp:ListItem>
            </asp:DropDownList>

            <div class="btn-group">
                <asp:Button ID="btn_registrar" runat="server" Text="Registrar" CssClass="btn"  />
                <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" CssClass="btn btn-cancelar"  />
                <asp:Button ID="btn_consultar" runat="server" Text="Consulta" CssClass="btn" />
            </div>
            <asp:Label ID="lbl_mensaje" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
