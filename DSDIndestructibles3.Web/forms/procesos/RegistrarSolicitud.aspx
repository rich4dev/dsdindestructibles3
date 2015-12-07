<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarSolicitud.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.RegistrarSolicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td colspan="5" style="text-align: center"><strong>Registrar Solicitud</strong></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Fecha Solicitud:</td>
            <td>
                <asp:TextBox ID="txtFecSol" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Comercio:</td>
            <td>
                <asp:DropDownList ID="ddlCli" runat="server" ClientIDMode="Static">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Motivo Solicitud:</td>
            <td>
                <asp:DropDownList ID="ddlMotSol" runat="server" ClientIDMode="Static">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Terminal Solicitado:</td>
            <td>
                <asp:DropDownList ID="ddlTerSol" runat="server" ClientIDMode="Static">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Estado:</td>
            <td>
                <asp:DropDownList ID="ddlEstado" runat="server" ClientIDMode="Static" Enabled="false">
                    <asp:ListItem Value="R">Registrado</asp:ListItem>
                    <asp:ListItem Value="A">Atendido</asp:ListItem>
                    <asp:ListItem Value="C">Cancelado</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <input id="test get" type="button" value="button" onclick="TestValidar();" />
                <asp:Button ID="btnRegistrar" runat="server" OnClientClick="return Validar();" OnClick="btnRegistrar_Click" Text="Registrar" />
                &nbsp;<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <script>

        function Validar() {
            try {
                var fecha = '', comercio = '', motivo = '', modelo = '', estado = '', mensaje = '', flag = false;
                fecha = $("#txtFecSol").val();
                comercio = $("#ddlCli").val();
                motivo = $("#ddlMotSol").val();
                modelo = $("#ddlTerSol").val();
                estado = $("#ddlEstado").val();
                if (fecha == '') {
                    flag = true;
                    mensaje += 'Favor, Ingresar fecha.\n';
                }
                if (comercio == 0) {
                    flag = true;
                    mensaje += 'Favor, Selecciona comercio.\n';
                }
                if (motivo == 0) {
                    flag = true;
                    mensaje += 'Favor, Seleccionar motivo.\n';
                }
                if (modelo == 0) {
                    flag = true;
                    mensaje += 'Favor, Seleccionar modelo.\n';
                }
                if (flag) {
                    alert(mensaje);
                    return false;
                }
                
                if (!confirm('Esta seguro que desea registrar la solicitud?'))
                    return false;
            } catch (e) {
                console.log(e);
            }
            return true;
        }
        $(function () {
            $("#<%=txtFecSol.ClientID%>").datepicker();
            $("#<%=btnRegistrar.ClientID%>").button();
            $("#<%=btnCancelar.ClientID%>").button();
        });
    </script>
</asp:Content>
