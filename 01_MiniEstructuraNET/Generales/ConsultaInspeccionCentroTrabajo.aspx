<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" AutoEventWireup="true" CodeBehind="ConsultaInspeccionCentroTrabajo.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultaInspeccionCentroTrabajo" Theme="Tema1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />

    <br />
    <h3 class="titulo bullet">
        <asp:Literal ID="ltTitulo" runat="server">Seguimiento</asp:Literal>
        de inspecciones del centro de trabajo</h3>
    <br />

    <br />
    <table align="center" width="613" height="51" cellspacing="8" cellpadding="0" border="0">
        <tbody>
            <tr>
                <td width="197" height="14">Nombre o razón social:</td>

                <td height="14">
                    <asp:Literal ID="ltNombre" runat="server"></asp:Literal></td>
            </tr>

            <tr>
                <td width="197" height="13">Domicilio:</td>
                <td width="370" height="13">
                    <asp:Literal ID="ltDomicilio" runat="server"></asp:Literal></td>
            </tr>

        </tbody>
    </table>

    <p>
        <br />
        <br />
    </p>
    <div class="tabla3">
        <asp:Repeater ID="rptInspeccion" runat="server">
            <HeaderTemplate>
                <table align="center" width="757" cellspacing="0" cellpadding="0" border="0" id="tab5">
                    <tr>
                        <th width="95">Número</th>
                        <th width="69">Fecha inspección</th>
                        <th width="81">Tipo</th>
                        <th width="49">Materia</th>
                        <th width="65">Último proceso</th>
                        <th width="66">Fecha</th>
                        <th width="95">Expediente SIPAS</th>
                        <th width="57">Archivos</th>

                        <th width="62">Consultar</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("in_num_expediente")%></td>
                    <td><%#Eval("fec_inspeccion")%></td>
                    <td><%#Eval("stins_subtipo")%></td>
                    <td><%#Eval("mat_acronimo")%></td>
                    <td><%#Eval("ultima_etapa")%></td>
                    <td><%#Eval("ultima_etapa_fec")%></td>

                    <td></td>
                    <td class="alt">
                        <asp:LinkButton ID="lbActuacion" runat="server" OnCommand="lbArchivos_Click" CommandArgument='<%#Eval("inspeccion_id") + "|" + Eval("in_etapa") + "|" + Eval("in_num_expediente") + "|" + Eval("stins_subtipo") + "|" + Eval("mat_materia")+"|"+Eval("fec_inspeccion")+"|"+Eval("desahogo_id") +"|"+Eval("operativo_id")+"|"+Eval("materia_id")+"|"+Eval("subtipo_inspeccion_id")%>'>
                            <asp:Image ID="Image6" ImageUrl="~/App_Themes/Tema1/imagenes/descarga.gif" runat="server" Width="16" Height="16"></asp:Image>
                        </asp:LinkButton></td>
                    <td class="alt">
                        <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="lbConsultar_Click" CommandArgument='<%#Eval("inspeccion_id") + "|" + Eval("in_etapa") + "|" + Eval("in_num_expediente") + "|" + Eval("stins_subtipo") + "|" + Eval("mat_materia") %>'>
                            <asp:Image ID="Image2" ImageUrl="~/App_Themes/Tema1/imagenes/ver.gif" runat="server" Width="16" Height="16"></asp:Image>
                        </asp:LinkButton></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    <table width="850" cellspacing="10" cellpadding="0" border="0">
        <tbody>
            <tr>

                <td align="right" width="830">
                    <asp:Button ID="btnRegresar" runat="server" Text="Regresar"
                        OnClick="btnRegresar_Click" /></td>
            </tr>
        </tbody>
    </table>

    <br />
    <br />
</asp:Content>
