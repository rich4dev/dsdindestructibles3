<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarInstalacion.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.RegistrarInstalacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>Id Cliente:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td>Razon Social:</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Dirección comercial:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td>Nombre del contacto:</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Telefono:</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td>Fecha Instalación</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Modelo del POS:</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td>Hora de Instalación</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td colspan="6">
                <hr />
            </td>
        </tr>
        <tr>
            <td>Modelo POS Instalado:</td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>Cargo del capacitado:</td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server" OnTextChanged="TextBox10_TextChanged"></asp:TextBox>
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>Observaciones:</td>
            <td>
                <asp:TextBox ID="TextBox11" runat="server" Height="80px" Width="185px"></asp:TextBox>
            </td>
            <td></td>
            <td>Se instalo exitosamente:</td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Value="Si"></asp:ListItem>
                    <asp:ListItem Value="No"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>Se señalizo:</td>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Ok" />
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Cancelar" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Guardar" />
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </table>
</asp:Content>
