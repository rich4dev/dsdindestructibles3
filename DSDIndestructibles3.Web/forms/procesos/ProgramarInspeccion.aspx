<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProgramarInspeccion.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.ProgramarInspeccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="margin-left: 10px; text-align: left;">        
        <tr>
            <td colspan="5" style="text-align: center"><strong>Programar Inspecci&oacute;n</strong></td>
        </tr>
        <tr>
            <td colspan="5" style="text-align: center"><b>Solicitud de inpecci&oacute;n activas</b></td>
        </tr>
        <tr>
            <td colspan="5"><br /></td>
        </tr>
        <tr>
            <td colspan="5">
                <table id="tbSolicitudes">
                    <thead>
                        <tr>
                            <td class="head">N° Solicitud</td>
                            <td class="head">Nombre solicitante</td>
                            <td class="head">Estado</td>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:literal runat="server" id="ltrSolicitudes"></asp:literal>
                    </tbody>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
