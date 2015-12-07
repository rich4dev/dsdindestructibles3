<%@ Page Title="Programar Instalación" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistraInspeccionDetalle.aspx.cs" Inherits="DSDIndestructibles3.Web.forms.procesos.ProgramarInstalacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td></td>
            <td colspan="2" style="color:white;background-color:blue">Visita de Inspección</td>
            <td style="width: 119px" >&nbsp;</td>
            <td >Fecha: </td>
            <td style="width: 104px" >
                <asp:DropDownList ID="DropDownList5" runat="server">
                </asp:DropDownList>
            </td>
            <td></td>

        </tr>
              <tr>
            <td style="height: 8px"></td>
            <td style="height: 8px" colspan="2">
                <asp:TextBox ID="TextBox17" runat="server" Width="253px"></asp:TextBox>
                  </td>
            <td style="height: 8px; width: 119px;"></td>
            <td style="height: 8px; ">Hora:</td>
            <td style="height: 8px; width: 104px;">
                <asp:DropDownList ID="DropDownList6" runat="server">
                </asp:DropDownList>
                  </td>
            <td style="height: 8px"></td>
        </tr>
         <tr>
            <td style="height: 8px"></td>
            <td style="height: 8px"></td>
            <td style="height: 8px; width: 94px;"></td>
            <td style="height: 8px; width: 119px;"></td>
            <td style="height: 8px; ">&nbsp;</td>
            <td style="height: 8px; width: 104px;">
            
                  </td>
            <td style="height: 8px"></td>
        </tr>
        
        <tr>
            <td style="height: 24px"></td>
            <td style="height: 24px">Razon Social:</td>
            <td colspan="3" style="height: 24px">
                <asp:TextBox ID="TextBox1" runat="server" Width="320px"></asp:TextBox>
            </td>
            <td style="width: 104px; height: 24px;">
                </td>
            <td style="height: 24px"></td>
        </tr>
        <tr>
            <td style="height: 24px">&nbsp;</td>
            <td style="height: 24px">R.U.C:</td>
            <td style="height: 24px" colspan="3">
                <asp:TextBox ID="TextBox2" runat="server" Width="204px"></asp:TextBox>
            </td>
            <td style="height: 24px; width: 104px;">
                </td>
            <td style="height: 24px"></td>
        </tr>
        <tr>
            <td></td>
            <td>Dirección:</td>
            <td colspan="3">
                <asp:TextBox ID="TextBox9" runat="server" Width="322px" OnTextChanged="TextBox9_TextChanged"></asp:TextBox>
            </td>
            <td style="width: 104px">
                &nbsp;</td>
            <td></td>
        </tr>
       
        <tr>
            <td></td>
            <td>Departamento:</td>
            <td style="width: 94px">
                <asp:TextBox ID="TextBox12" runat="server" ></asp:TextBox>
            </td>
            <td style="width: 119px">Distrito:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td>
                <asp:TextBox ID="TextBox13" runat="server" ></asp:TextBox>
            </td>
            <td style="width: 104px"></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>Telefono:</td>
            <td style="width: 94px">
                <asp:TextBox ID="TextBox10" runat="server" ></asp:TextBox>
            </td>
            <td style="width: 119px">Celular:</td>
            <td>
                <asp:TextBox ID="TextBox14" runat="server" ></asp:TextBox>
            </td>
            <td style="width: 104px"></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td style="width: 94px">
                &nbsp;</td>
            <td style="width: 119px"></td>
            <td>&nbsp;</td>
            <td style="width: 104px">
                &nbsp;</td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>Contacto:</td>
            <td colspan="3">
                <asp:TextBox ID="TextBox15" runat="server" Width="323px" ></asp:TextBox>
            </td>
            <td style="width: 104px">
                &nbsp;</td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>Referencias:</td>
            <td colspan="3" rowspan="2">
                <asp:TextBox ID="TextBox16" runat="server" Height="39px" Width="323px" ></asp:TextBox>
            </td>
            <td style="width: 104px"></td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td style="width: 104px"></td>
            <td></td>
        </tr>
        <tr>
            <td style="width: 2px"></td>
             <td style="width: 2px"></td>
             <td style="width: 94px"></td>
             <td style="width: 119px"></td>
             <td></td>
             <td style="width: 104px"></td>
             <td style="width: 2px"></td>
        </tr>
         <tr>
            <td></td>
             <td>Servicio POS:</td>
             <td style="width: 94px">
                 <asp:RadioButton ID="RadioButton1" runat="server" Text="Delivery" />
             </td>
             <td style="width: 119px">
                 <asp:RadioButton ID="RadioButton2" runat="server" Text="Terminal" />
             </td>
             <td>
                 Fecha Programada</td>
             <td>
                 <asp:DropDownList ID="DropDownList7" runat="server">
                 </asp:DropDownList>
             </td>
             <td></td>
        </tr>
         <tr>
            <td style="height: 24px"></td>
             <td style="height: 24px">Estado Visita:</td>
             <td style="width: 94px; height: 24px;">
                 <asp:RadioButton ID="RadioButton3" runat="server" Text="Conforme" />
             </td>
             <td style="width: 119px; height: 24px;">
                 <asp:RadioButton ID="RadioButton4" runat="server" Text="Observado" />
             </td>
             <td style="height: 24px">
                 Hora</td>
             <td style="width: 104px; height: 24px;"><asp:DropDownList ID="DropDownList8" runat="server">
                 </asp:DropDownList>
             </td>
             <td style="height: 24px"></td>
        </tr>
         <tr>
            <td>&nbsp;</td>
             <td>Observaciones:</td>
             <td colspan="4" rowspan="2">
                <asp:TextBox ID="TextBox18" runat="server" Width="487px" Height="40px" ></asp:TextBox>
             </td>
             <td></td>
        </tr>
         <tr>
            <td style="height: 22px"></td>
             <td style="height: 22px"></td>
             <td style="height: 22px"></td>
        </tr>
 <tr>
            <td></td>
             <td></td>
             <td style="width: 94px"></td>
             <td style="width: 119px"></td>
             <td></td>
             <td style="width: 104px"></td>
             <td></td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Cancelar" />
            </td>
            <td style="width: 94px">
                <asp:Button ID="Button3" runat="server" Text="Modificar" OnClick="Button3_Click" />
            </td>
            <td colspan="2">
                <asp:Button ID="Button2" runat="server" Text="Guardar" />
            </td>
            <td style="width: 104px">
                &nbsp;</td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td style="width: 94px"></td>
            <td style="width: 119px"></td>
            <td>
                &nbsp;</td>
            <td style="width: 104px"></td>
            <td></td>
        </tr>
    </table>
</asp:Content>
