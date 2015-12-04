<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarSolicitudAfilacion.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.RegistrarSolicitudAfilacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td colspan="4" style="text-align:center; height: 27px;">
                <asp:Label ID="Label3" runat="server" BorderStyle="None" Font-Bold="True" Font-Overline="False" Font-Size="Large" Font-Underline="True" Text="Solicitud de Afiliación"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 22px"></td>
            <td style="height: 22px; width: 152px;"></td>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
        </tr>
         <tr>
            <td style="height: 22px"><b>Datos Generales Empresa</b></td>
            <td style="height: 22px; width: 152px;"></td>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="RUC:"></asp:Label>
            </td>
            <td style="width: 152px">
                <asp:TextBox ID="txtruc" runat="server"></asp:TextBox>
            </td>
            <td>
                Razon Social:</td>
            <td>
                <asp:TextBox ID="txtrazonsocial" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Nombre Comercial:</td>
            <td style="width: 152px">
                <asp:TextBox ID="txtnombrecomercial" runat="server"></asp:TextBox>
            </td>
            <td>
                Direccion Comercial:</td>
            <td>
                <asp:TextBox ID="txtdirecomercial" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Direccion Administrativa:</td>
            <td style="width: 152px">
                <asp:TextBox ID="txtdirecadmin" runat="server"></asp:TextBox>
            </td>
            <td>
                Representante Legal 1:</td>
            <td>
                <asp:TextBox ID="txtrepresenante1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 42px">Representante Legal 2:</td>
            <td style="height: 42px; width: 152px;">
                <asp:TextBox ID="txtrepresentante2" runat="server"></asp:TextBox>
            </td>
            <td style="height: 42px">Persona Contacto (Punto de venta):</td>
            <td style="height: 42px">
                <asp:TextBox ID="txtpersonalcontacto" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><b>Datos para el pago de transacciones</b></td>
            <td style="width: 152px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 24px">Numero de Cuenta Bancaria:</td>
            <td style="height: 24px; width: 152px;">
                <asp:TextBox ID="txtcuentabancaria" runat="server"></asp:TextBox>
            </td>
            <td style="height: 24px"></td>
            <td style="height: 24px"></td>
        </tr>
        <tr>
            <td style="height: 24px">Tipo de cuenta:</td>
            <td style="height: 24px; width: 152px;">
                <asp:TextBox ID="txtipocuenta" runat="server"></asp:TextBox>
            </td>
            <td style="height: 24px">Moneda:</td>
            <td style="height: 24px">
                <asp:TextBox ID="txtmoneda" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Entidad Financiera:</td>
            <td style="width: 152px">
                <asp:TextBox ID="txtentidadfinanciera" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
          <tr>
            <td><b>Datos de Afiliacion</b></td>
            <td style="width: 152px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
          <tr>
            <td>Tipo de Afiliacion:</td>
            <td style="width: 152px">
                <asp:TextBox ID="txttipoafiliacion" runat="server"></asp:TextBox>
              </td>
            <td>Tipo de Producto:</td>
            <td>
                <asp:TextBox ID="txttipoproducto" runat="server"></asp:TextBox>
              </td>
        </tr>
          <tr>
            <td style="height: 22px">Tipo de comunicacion:</td>
            <td style="height: 22px; width: 152px;">
                <asp:TextBox ID="txttipocomunicacion" runat="server"></asp:TextBox>
              </td>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
        </tr>
          <tr>
            <td><b>Horario de Instalacion</b></td>
            <td style="width: 152px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td>Fecha de instalacion:</td>
            <td style="width: 152px">
                <asp:TextBox ID="txtfechainstalacion" runat="server"></asp:TextBox>
             </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td colspan="2">
                <asp:Label ID="lblmensaje" runat="server" Text="Label" Visible="false"></asp:Label>
             </td>
            <td>&nbsp;</td>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td style="width: 152px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
           <tr>
            <td>&nbsp;</td>
            <td style="width: 152px">
                <asp:Button ID="btngrabar" runat="server" Text="GRABAR" Width="136px" OnClick="btngrabar_Click" />
               </td>
            <td>
                <asp:Button ID="btnlimpiar" runat="server" Text="LIMPIAR" Width="187px" OnClick="btnlimpiar_Click" />
               </td>
            <td>
                <asp:Button ID="btncancelar" runat="server" Text="CANCELAR" Width="108px" />
               </td>
        </tr>
           <tr>
            <td>&nbsp;</td>
            <td style="width: 152px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
