<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_estudiantes.aspx.cs" Inherits="App_sistema_academico.frm_estudiantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous"/>
<link href="estilos/main.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="frm_estudiantes" runat="server" class="form-floatin">
            <div id="container">
            <h3>Formulario de Registro de estudiantes</h3>
            <div class="form-floating">
                <asp:TextBox ID="txt_codigo" class="form-control"  runat="server" placeholder="ID *"></asp:TextBox> 
                 <label for="txt_codigo">ID *</label>
            </div>
            <div class="form-floating">
                <asp:TextBox ID="txt_nombre" class="form-control" runat="server" placeholder="Nombres *"></asp:TextBox> 
                <label for="txt_nombre">Nombres *</label>
            </div>
            <div class="form-floating">
                <asp:TextBox ID="txt_contacto" class="form-control" runat="server" placeholder="Contacto *"></asp:TextBox> 
                <label for="txt_contacto">Contacto *</label>
            </div>
            <div class="form-floating">
                <asp:TextBox ID="txt_correo" class="form-control" runat="server" placeholder="Correo *" ></asp:TextBox> 
                <label for="txt_correo">Correo *</label>
            </div>
            <div class="form-floating">
                <asp:TextBox ID="txt_direccion" class="form-control" runat="server" placeholder="Dirección *" ></asp:TextBox> 
                <label for="txt_direccion">Dirección *</label>
            </div>
            <div class="form-floating">
                <asp:TextBox ID="txt_acudiente" class="form-control" runat="server" placeholder="Acudiente *" ></asp:TextBox> 
                <label for="txt_acudiente">Acudiente *</label>
            </div>
            
            <div class = "cbx-group">
            <asp:DropDownList ID="cbx_estrato" runat="server" CssClass="cbx">
                <asp:ListItem Value="0 ">Estrato 1</asp:ListItem>
                <asp:ListItem Value="1 ">Estrato 2</asp:ListItem>
                <asp:ListItem Value="2 ">Estrato 3</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:DropDownList ID="cbx_sexo" runat="server" CssClass="cbx">
                <asp:ListItem Value="0 ">Hombre</asp:ListItem>
                <asp:ListItem Value="1 ">Mujer</asp:ListItem>
            </asp:DropDownList>
            </div>

            <div class="form-floating">
                <asp:TextBox ID="txt_observaciones" class="form-control"  runat="server" placeholder="Observaciones" ></asp:TextBox> 
                <label for="txt_observaciones">Observaciones</label> 
            </div>

            <div class="btn-group">
                <asp:Button ID="btn_registrar" runat="server" Text="Registrar" type="button" class="btn btn-success" OnClick="btn_registrar_Click"  /> 
                <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" type="button" class="btn btn-secondary" OnClick="btn_cancelar_Click" />  
                <asp:Button ID="btn_consultar" runat="server" Text="Consultar" type="button" class="btn btn-info" OnClick="btn_consultar_Click"  />
            </div>
            <asp:Label ID="lbl_mensaje" runat="server" ForeColor="Black"></asp:Label>
        </div>
    </form>
</body>
</html>
