<%@ Page Title="Entregar kit de bienvenida" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EntregarKit.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.EntregarKit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="display: table;">
        <div style="display: table-row;">
            <div style="display: table-cell;">Desde:</div>
            <div style="display: table-cell;">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div style="display: table-cell;">Hasta;</div>
            <div style="display: table-cell;">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;">
                <asp:Button ID="btnBuscar" runat="server" Text="&Buscar" />
            </div>
        </div>
        <div style="display: table-row;">
            <asp:GridView ID="gvSolicitudes" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:CheckBoxField />
                    <asp:BoundField DataField="NroSolicitud" HeaderText="Nro Solicitud" />
                    <asp:BoundField DataField="FechaSolicitud" HeaderText="Fecha Solicitud" />
                    <asp:BoundField DataField="Ruc" HeaderText="Ruc" />
                    <asp:BoundField DataField="RazonSocial" HeaderText="Razon Social" />
                </Columns>
            </asp:GridView>
        </div>
        <div style="display: table-row;">
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
        </div>
        <div style="display: table-row;">
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;">
                <asp:Button ID="btnEntregado" runat="server" Text="Entregado" />
            </div>
            <div style="display: table-cell;">
                <asp:Button ID="btnNoEntregado" runat="server" Text="No Entregado" /></div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
        </div>
        <div style="display: table-row;">
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
            <div style="display: table-cell;"></div>
        </div>
    </div>

</asp:Content>
