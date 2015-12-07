<%@ page title="" language="C#" masterpagefile="~/Site.Master" autoeventwireup="true" codebehind="ProgramarInspeccion.aspx.cs" inherits="DSDIndestructibles3.Web.forms.procesos.ProgramarInspeccion" %>

<asp:content id="Content1" contentplaceholderid="MainContent" runat="server">

        
            
    <table style="margin-left: 10px; text-align: left;">        
        <tr>
            <td style="text-align: center">
                <strong>Programar Inspecci&oacute;n</strong>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="text-align: center"><b>Solicitud de inpecci&oacute;n activas</b></td>
        </tr>
        <tr>
            <td><br /></td>
        </tr>
        <tr>
            <td>
                <asp:HiddenField runat="server" id="hdLstSolicitudes"></asp:HiddenField>
                <table id="tbSolicitudes" style="width: 550px;  ">
                    <thead>
                        <tr>
                            <td class="head" style="width: 115px;" >N° Solicitud</td>
                            <td class="head" style="width: 230px;" >Nombre solicitante</td>
                            <td class="head" style="width: 200px;" >Estado</td>
                        </tr>
                    </thead>
                    <tbody id="lstSolicitudes">
                    </tbody>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:button runat="server" text="Programar Inspección" OnClick="btnCargarSolicitud_Click" id="btnCargarSolicitud"/>
                    </ContentTemplate> 
                </asp:UpdatePanel>
            </td>
        </tr>
        <asp:HiddenField runat="server" id="hdSolicitudSelect"></asp:HiddenField>

    </table>
    <br /><br />
    <br />
    
    
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
        <asp:Panel id="pnlRegistro" runat="server" visible="false">

            <fieldset>
                <legend><asp:Label runat="server" id="lblTitle"></asp:Label></legend>
                <asp:HiddenField runat="server" id="hdSolicitudSave"></asp:HiddenField>
                <strong>Detalles del Solicitante</strong>
                <table>
                    <tr>
                        <td style="width: 170px;">
                            Raz&oacute;n Social
                        </td>
                        <td>
                            <asp:Textbox runat="server" enabled="false" style="width: 300px;" id="txtRazonSocial"></asp:Textbox>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            R.U.C
                        </td>
                        <td>
                            <asp:Textbox runat="server" enabled="false" style="width: 300px;" id="txtRuc"></asp:Textbox>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset>
                <table>
                    <tr>
                        <td style="width: 170px;">
                            Direcci&oacute;n Comercial
                        </td>
                        <td>
                            <asp:Textbox runat="server" enabled="false" style="width: 300px;" id="txtDireccionComercial"></asp:Textbox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 170px;">
                            Direcci&oacute;n Administrativa
                        </td>
                        <td>
                            <asp:Textbox runat="server"  enabled="false" style="width: 300px;" id="txtDireccionAdministrativa"></asp:Textbox>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset>
                <table>
                    <tr>
                        <td style="width: 170px;">
                            Representante Legal
                        </td>
                        <td>
                            <asp:Textbox runat="server" enabled="false" style="width: 300px;" id="txtRepresentanteLegal"></asp:Textbox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 170px;">
                            Contacto
                        </td>
                        <td>
                            <asp:Textbox runat="server" enabled="false" style="width: 300px;" id="txtPersonaContacto"></asp:Textbox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">Referencias</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Textbox runat="server" TextMode="multiline" Columns="50" Rows="5" id="txtReferencias"></asp:Textbox>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <br />
            <br />
            <fieldset>
                <legend>Programaci&oacute;n de visita</legend>
                <table>
                    <tr>
                        <td style="width: 170px;">
                            T&eacute;cnico asignado
                        </td>
                        <td>
                            <asp:DropDownList runat="server" id="ddlTecnicos">
                                <asp:ListItem Text="Tecnico 1" Value="1" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 170px;">
                            Fecha
                        </td>
                        <td>
                            <asp:TextBox ID="txtFecInsp" runat="server" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 170px;">
                            Hora
                        </td>
                        <td>
                            <asp:TextBox ID="txtHora" runat="server" ClientIDMode="Static"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 170px;">
                            Estado actual
                        </td>
                        <td>
                            <asp:DropDownList runat="server" id="ddlEstadoActual">
                                <asp:ListItem Text="Programado" Value="1" />
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:button runat="server" text="Grabar Inspección" OnClientClick="return Validar();" OnClick="btnGrabarSolicitud_Click" id="btnGrabar"/>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <table>
                <tr>
                    <td colspan="5">
                    </td>
                </tr>
            </table>

        </asp:Panel>
                        
        </ContentTemplate>
    </asp:UpdatePanel>
    <table>
        
        <tr>
            <td>
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <asp:Label runat="server" id="lblmessage"></asp:Label>
                    </ContentTemplate> 
                </asp:UpdatePanel>
            </td>
        </tr>
    </table>

    <script type="text/javascript">

        $(document).ready(function () {
            var data = JSON.parse($("#MainContent_hdLstSolicitudes").val())
            var i = 0;
            var html = "";
            for (i = 0; i <= data.length - 1; i++) {
                html += "<tr>";
                html += "<td style='text-align: center;'><span>" + data[i].SolicitudAfiliacionID + "</span></td>";
                html += "<td>" + data[i].NombreComercial + "</td>";
                html += "<td>" + data[i].TipoProduccto + "</td>";
                html += "</tr>";
            }
            $("#lstSolicitudes").append(html);


            $("#lstSolicitudes tr").click(function () {
                $("#lstSolicitudes tr").removeClass("solicitudSelect");
                $(this).addClass("solicitudSelect");
                var selSolicitud = $(this).find("td:first").text();
                console.log(selSolicitud);
                $("#MainContent_hdSolicitudSelect").val(selSolicitud);
            });

            $("#<%=txtFecInsp.ClientID%>").datepicker();

       });


        function Validar() {
            try {
                var fecha = '', comercio = '', motivo = '', modelo = '', estado = '', mensaje = '', flag = false;
                fecha = $("#txtFecInsp").val();
                referencia = $("#MainContent_txtReferencias").val();
                hora = $("#txtHora").val();

                if (referencia == 0) {
                    flag = true;
                    mensaje += 'Favor, Ingresar referencia.\n';
                }
                if (fecha == '') {
                    flag = true;
                    mensaje += 'Favor, Seleccionar fecha.\n';
                }
                if (hora == '') {
                    flag = true;
                    mensaje += 'Favor, Ingresar hora.\n';
                }

                if (flag) {
                    alert(mensaje);
                    return false;
                }

                if (!confirm('Esta seguro que desea programar la inspección?'))
                    return false;
            } catch (e) {
                console.log(e);
            }
            return true;
        }

    </script>
</asp:content>
