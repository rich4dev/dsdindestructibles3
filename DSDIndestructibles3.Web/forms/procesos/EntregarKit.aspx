<%@ Page Title="Entregar kit de bienvenida" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EntregarKit.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.EntregarKit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td> <br /></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>Desde:</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td>Hasta:</td>
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <td></td>
            <td>                <asp:Button ID="btnBuscar" runat="server" Text="&Buscar" />
</td>
        </tr>        <tr>
            <td>
                <br />
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>

        <tr>
            <td colspan="6">            <asp:GridView ID="gvSolicitudes" runat="server" AutoGenerateColumns="False" OnRowDataBound="gvSolicitudes_RowDataBound">
                <Columns>
                    <asp:CheckBoxField DataField="Flag" HeaderText="" />
                    <asp:BoundField DataField="NroSolicitud" HeaderText="Nro Solicitud" />
                    <asp:BoundField DataField="FechaSolicitud" HeaderText="Fecha Solicitud" />
                    <asp:BoundField DataField="Ruc" HeaderText="Ruc" />
                    <asp:BoundField DataField="RazonSocial" HeaderText="Razon Social" />
                </Columns>
            </asp:GridView></td>
        </tr>
        <tr>
            <td>
                <br />
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td>                <input id="btnSi" type="button" value="Entregado"  OnClick="ShowPopup();"/>
</td>
            <td>                <input id="btnNo" type="button" value="No Entregado"  OnClick="ShowPopup();"/>
</td>
            <td></td>
            <td></td>
        </tr>
    </table>
    <div id="popup" style="display: none;">
        <table>
            <tr>
                <td> <asp:TextBox ID="txtComentarios" runat="server"></asp:TextBox>    
</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnGrabar" runat="server" Text="Grabar" /><asp:Button ID="btnSalir" runat="server" Text="Salir" /></td>
            </tr>
        </table>

    </div>
    <script>
        function ShowPopup() {
            $("#popup").show();
            $("#popup").dialog({
                //autoOpen: false,
                height: 300,
                width: 350,
                modal: true,
                buttons: {
                    Guardar: function () {
                        $(this).dialog("close");
                    },
                    Cerrar: function () {
                        $(this).dialog("close");
                    }
                }
            });
            return false;
        }
    </script>

</asp:Content>
