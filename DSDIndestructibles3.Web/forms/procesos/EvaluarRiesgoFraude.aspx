﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EvaluarRiesgoFraude.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.EvaluarRiesgoFraude" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td colspan="5" style="text-align: center; font-weight: bold">Evaluacion Riesgo Fraude</td>
        </tr>
        <tr>
            <td>Id Cliente:</td>
            <td>
                <asp:TextBox ID="txtidcliente" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td>Razon Social:</td>
            <td>
                <asp:TextBox ID="txtruc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Dirección comercial:</td>
            <td>
                <asp:TextBox ID="txtdirecomer" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td>Nombre del contacto:</td>
            <td>
                <asp:TextBox ID="txtnom" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Telefono:</td>
            <td>
                <asp:TextBox ID="txttelef" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td>Fecha Instalación</td>
            <td>
                <asp:TextBox ID="txtfechains" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Modelo del POS:</td>
            <td>
                <asp:TextBox ID="txtmodelpos" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td>Hora de Instalación</td>
            <td>
                <asp:TextBox ID="txthorains" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <hr /></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>Observaciones:</td>
            <td>
                <asp:TextBox ID="txtobs" runat="server" Height="80px" Width="185px"></asp:TextBox>
            </td>
            <td></td>
            <td>Se presentaron todos los papeles:</td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Value="Si"></asp:ListItem>
                    <asp:ListItem Value="No"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="height: 70px"></td>
            <td style="height: 70px"></td>
            <td style="height: 70px"></td>
            <td style="height: 70px">Cliente Riesgo?</td>
            <td style="height: 70px">
                <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                    <asp:ListItem Value="Si"></asp:ListItem>
                    <asp:ListItem Value="No"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Label ID="lblmensaje" runat="server" Text="Label" Visible="false"></asp:Label>
             </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnGuardar0" runat="server" Text="Guardar" OnClientClick="if (!confirm('Esta seguro que desea registrar la solicitud?')){ return false;} else { ShowPopup(); return false;}" OnClick="btnGuardar0_Click" />
            </td>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Limpiar" OnClick="Button1_Click" />
            </td>
            <td>
                <asp:Button ID="btnGuardar" runat="server" Text="Cancelar" OnClientClick="if (!confirm('Esta seguro que desea registrar la solicitud?')){ return false;} else { ShowPopup(); return false;}" Height="26px" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </table>
    <script>
        function ShowPopup() {
            $("#popup").show();
            $("#popup").dialog({
                //autoOpen: false,
                title: "Esta seguro de los datos a grabar?",
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
