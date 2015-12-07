<%@ Page Title="Programar Instalación" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistraInspeccion.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.ProgramarInstalacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td style="height: 22px"></td>
            <td style="height: 22px">
                </td>
            <td style="height: 22px" colspan="10"> <style="color:white;background-color:blue">VISITAS DE INSPECCION PROGRAMADAS</td>
            <td style="width: 23px"> </td>
        </tr><tr>
            <td style="height: 22px"></td>
            <td style="height: 22px">
                </td>
            <td style="height: 22px"></td>
            <td style="height: 10px; width: 30px;"></td>
            <td style="height: 22px">
                </td>
            <td style="height: 1px; width: 25px;">
                </td>
            <td style="height: 22px; " colspan="2">
                Fecha:</td>
            <td style="height: 22px; " colspan="4">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 23px"> </td>
        </tr>
        <tr>
            <td style="height: 22px"></td>
            <td style="height: 22px">
                </td>
            <td style="height: 22px"></td>
            <td style="height: 10px; width: 30px;"></td>
            <td style="height: 22px">
                </td>
            <td style="height: 1px; width: 25px;">
                </td>
            <td style="height: 22px; width: 88px;">
                </td>
            <td style="height: 22px; width: 26px;">
                </td>
            <td style="height: 22px; width: 21px;"></td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td style="width: 23px"> </td>
        </tr>
         <tr>
            <td style="height: 22px"></td>
            <td style="height: 22px">
                </td>
            <td style="height: 22px" colspan="2">Ejecutivo:</td>
            <td style="height: 22px" colspan="8">
                <asp:TextBox ID="TextBox1" runat="server" Width="362px"></asp:TextBox>
                </td>
            <td style="width: 23px"> </td>
        </tr>
         <tr>
            <td style="height: 22px"></td>
            <td style="height: 22px">
                </td>
            <td style="height: 22px"></td>
            <td style="height: 10px; width: 30px;"></td>
            <td style="height: 22px">
                </td>
            <td style="height: 1px; width: 25px;">
                </td>
            <td style="height: 22px; width: 88px;">
                </td>
            <td style="height: 22px; width: 26px;">
                </td>
            <td style="height: 22px; width: 21px;"></td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td style="width: 23px"> </td>
        </tr>
        <tr>
            <td style="h<a href="../">../</a>eight: 23px"></td>
            <td style="height: 23px">
                </td>
            <td colspan="10" rowspan="8" style="align-content:flex-start">
                <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Solicitud" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:CommandField ShowSelectButton="True"  HeaderText="Selección"/>
                        <asp:BoundField DataField="Solicitud" HeaderText="Numero de Solicitud" InsertVisible="False" ReadOnly="True" SortExpression="Solicitud" />
                        <asp:BoundField DataField="empresa" HeaderText="Nombre del Solicitante" SortExpression="empresa" />
                        <asp:BoundField DataField="estado" HeaderText="Estado" SortExpression="estado" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:indestructibles3ConnectionString %>" SelectCommand="select soli.SolicitudServicioId as Solicitud, 
       empe.RazonSocial as empresa, esta.Descripcion as estado
from SolicitudServicio soli,
     Estado esta, Empresa empe
where 
     soli.Estado=esta.estadoId and
     soli.EmpresaId=empe.EmpresaId"></asp:SqlDataSource>
            </td>
            <td> </td>

        </tr>
        <tr>
            <td></td>
            <td>
                </td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td style="width: 30px"></td>
            <td></td>
            <td style="width: 25px"></td>
            <td style="width: 88px"></td>
            <td style="width: 26px"></td>
            <td style="width: 21px"></td>
            <td style="width: 27px">&nbsp;</td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
         <tr>
            <td></td>
            <td></td>
            <td colspan="3" style="color:white;background-color:blue">LEYENDA</td>
            <td style="width: 25px"></td>
            <td style="width: 88px">&nbsp;</td>
            <td style="width: 26px">&nbsp;</td>
            <td style="width: 21px">&nbsp;</td>
        </tr>
         <tr>
            <td></td>
            <td></td>
            <td>Pendiente</td>
             <td style="background-color:blue; width: 30px;"></td>
            <td style="width: 117px; color:red">En Tramite </td>
            <td style="width: 25px; background-color:red"></td>
            <td style="width: 88px; color:green">Anulado</td>
           <td style="width: 26px; background-color:green"></td>
            <td ></td>
            <td style="width: 27px">&nbsp;</td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
         <tr>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
            <td style="width: 30px; height: 22px;"></td>
            <td style="height: 22px" ></td>
            <td style="width: 25px; height: 22px" ></td>
            <td style="height: 22px; width: 88px;"></td>
            <td style="width: 26px; height: 22px;"></td>
            <td style="width: 21px; height: 22px;"></td>
            <td style="width: 27px; height: 22px;"></td>
            <td style="width: 23px; height: 22px;"></td>
            <td style="width: 29px; height: 22px;"></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td style="width: 30px">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Cancelar" />
            </td>
            <td style="width: 25px">
                &nbsp;</td>
            <td style="width: 88px">
                <asp:Button ID="Button2" runat="server" Text="Guardar" />
            </td>
            <td style="width: 26px">
                &nbsp;</td>
            <td style="width: 21px"></td>
            <td style="width: 27px">&nbsp;</td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td style="width: 30px"></td>
            <td></td>
            <td style="width: 25px"></td>
            <td style="width: 88px"></td>
            <td style="width: 26px"></td>
            <td style="width: 21px"></td>
            <td style="width: 27px">&nbsp;</td>
            <td style="width: 23px">&nbsp;</td>
            <td style="width: 29px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
