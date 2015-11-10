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
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="ALL">      -------------------</asp:ListItem>
                    <asp:ListItem Value="A">DIGI</asp:ListItem>
                    <asp:ListItem Value="B">ICT250 Dial IP-CTLS</asp:ListItem>
                    <asp:ListItem Value="C">PAD Externo (i3010)</asp:ListItem>
                    <asp:ListItem Value="D">PAD Int.Caj (3500)</asp:ListItem>
                    <asp:ListItem Value="E">PAD Int.Caj (i3070)</asp:ListItem>
                    <asp:ListItem Value="F">POS Dial Up A (5100)</asp:ListItem>
                    <asp:ListItem Value="G">POS Dial Up B (Aqua)</asp:ListItem>
                    <asp:ListItem Value="H">POS IP (5100 IP)</asp:ListItem>
                    <asp:ListItem Value="I">PP320</asp:ListItem>
                    <asp:ListItem Value="J">VX520 Dial IP</asp:ListItem>
                </asp:DropDownList>
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
                <!--<asp:Button ID="Button1" runat="server" Text="Cancelar" />-->
                <input id="Button1" type="button" value="Cancelar"  OnClick="ShowPopup();"/>
            </td>
            <td>
                <!--<asp:Button ID="Button2" runat="server" Text="Guardar" />-->
                <input id="Button2" type="button" value="Guardar"  OnClick="ShowPopup();"/>
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
           <td>Esta Seguro que no se ha instalado el POS?</td>
        <table>
            
            <tr>
               
            </tr>
        </table>

    </div>
       <div id="popup1" style="display: none;">
           <td>Esta Seguro que no se ha señalizado el Comercio?</td>
        <table>
            
            <tr>
                <td></td>
                    <td>Existe Señalizacion     :</td>
                <td>
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Ok" />
                </td>
                <td></td>
            </tr>
            <tr>
                 <td></td>
            <td>Falta de Espacio        :</td>
            <td>
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Ok" />
            </td>
            <td></td>
            </tr>
            <tr>
                 <td></td>
            <td>Rechazado por el Cliente        :</td>
            <td>
                <asp:CheckBox ID="CheckBox4" runat="server" Text="Ok" />
            </td>
            <td></td>
            </tr>
               
            
        </table>

    </div>
    <script>
        function ShowPopup() {
            if (RadioButtonList = "No") {
                $("#popup").show();
                $("#popup").dialog({
                    //autoOpen: false,
                    height: 200,
                    width: 390,
                    modal: true,
                    buttons: {
                        Si: function () {
                            ShowPopup1()

                        },
                        No: function () {
                            $(this).dialog("close");
                        }
                    }
                });
                return false;
            }
        }
    </script>
    <script>
        function ShowPopup1() {
            $("#popup1").show();
            $("#popup1").dialog({
                //autoOpen: false,
                height: 250,
                width: 450,
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
