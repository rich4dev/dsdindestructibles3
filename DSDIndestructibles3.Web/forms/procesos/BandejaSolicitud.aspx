<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BandejaSolicitud.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.BandejaSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td class="text-center" colspan="6"><strong>Bandeja de Solicitud</strong></td>
        </tr>
        <tr>
            <td>Desde:</td>
            <td>
                <asp:TextBox ID="txtFecIni" runat="server"></asp:TextBox>
            </td>
            <td>Hasta:</td>
            <td>
                <asp:TextBox ID="txtFecFin" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 22px">Estado:</td>
            <td style="height: 22px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="T">--- TODOS ---</asp:ListItem>
                    <asp:ListItem Value="R">Registrado</asp:ListItem>
                    <asp:ListItem Value="A">Atendido</asp:ListItem>
                    <asp:ListItem Value="C">Cancelado</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
            <td style="height: 22px">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
            </td>
            <td style="height: 22px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
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
            <td>&nbsp;</td>
        </tr>
    </table>
     <script>
  $(function() {
      $("#<%=txtFecIni.ClientID%>").datepicker();
      $("#<%=txtFecFin.ClientID%>").datepicker();

      $("#<%=btnBuscar.ClientID%>").button();
  });
  </script>
</asp:Content>
