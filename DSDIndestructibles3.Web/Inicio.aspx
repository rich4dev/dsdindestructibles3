<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="DSDIndestructibles3.Web.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-4">
            <h2>Iniciar Sesión</h2>
            <div style="display: table;">
                <div style="display: table-row;">
                    <div style="display: table-cell;">Usuario</div>
                    <div style="display: table-cell;">
                        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></div>
                    <div style="display: table-cell;"></div>
                </div>
                <div style="display: table-row;">
                    <div style="display: table-cell;">Clave:</div>
                    <div style="display: table-cell;">
                        <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox></div>
                    <div style="display: table-cell;"></div>
                </div>
                <div style="display: table-row;">
                    <div style="display: table-cell;"></div>
                    <div style="display: table-cell;"><a class="btn btn-default" href="Default.aspx">Entrar</a></div>
                    <div style="display: table-cell;"></div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
