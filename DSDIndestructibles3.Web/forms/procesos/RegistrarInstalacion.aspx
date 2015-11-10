<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarInstalacion.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.RegistrarInstalacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td colspan="6" style="text-align: center; font-weight: 700">Registrar Instalación</td>
        </tr>
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
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClientClick="if (!confirm('Esta seguro que desea registrar la solicitud?')){ return false;} else { ShowPopup(); return false;}" />
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
        <div id="popup" style="display: none;">
        <table>
            <tr>
                <td>
                    Existe señalización:
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Ok" />
                </td>
            </tr>
            <tr>
                <td>
                    Falta de espacio:
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Ok" />
                </td>
            </tr>
            <tr>
                <td>
                    Rechazado por el cliente:
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox4" runat="server" Text="Ok" />
                </td>
            </tr>
        </table>

    </div>
        <script>
        function ShowPopup() {
            $("#popup").show();
            $("#popup").dialog({
                //autoOpen: false,
                title: "Esta seguro que no se ha señalizado el comercio?",
                height: 300,
                width: 350,
                modal: true,
                buttons: {
                    Si: function () {
                        $(this).dialog("close");
                    },
                    No: function () {
                        $(this).dialog("close");
                    }
                }
            });
            return false;
        }
    </script>

</asp:Content>
