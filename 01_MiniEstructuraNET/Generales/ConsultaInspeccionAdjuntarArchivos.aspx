<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" AutoEventWireup="true" CodeBehind="ConsultaInspeccionAdjuntarArchivos.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultaInspeccionAdjuntarArchivos"  Theme="Tema1"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="div1">
        <h3 class="titulo" align="left">
            <asp:Image ID="Image1" ImageUrl="~/App_Themes/Tema1/imagenes/titlebullet.gif" runat="server"
                Width="18" Height="15"></asp:Image>Adjuntar documentos al expediente
            <br>
            <br>
            <br>
            <br>
        </h3>
        <center>
            <table border="0" cellpadding="0" cellspacing="10" align="center" width="600">
                <tr>
                    <td height="17" width="100" align="left" valign="top">
                        Documento:
                    </td>
                    <td height="17" width="500" align="left" valign="top">
                        <asp:DropDownList ID="ddlTipoDocumento" runat="server" DataTextField="td_tipo_documento"
                            DataValueField="tipo_documento_id" AutoPostBack="true" OnSelectedIndexChanged="ddlTipoDocumento_SelectedIndexChanged">
                            <asp:ListItem Text="Acta de inspección"></asp:ListItem>
                            <asp:ListItem Text="Informe de comisión"></asp:ListItem>
                            <asp:ListItem Text="Acta de negativa patronal"></asp:ListItem>
                            <asp:ListItem Text="Acta en términos de orientación y asesoría"></asp:ListItem>
                            <asp:ListItem Text="Otro"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr runat="server" id="trOtro" visible="false">
                    <td align="left" valign="top">
                        Nombre:
                    </td>
                    <td align="left" valign="top">
                        <asp:TextBox ID="tbOtro" runat="server" Columns="50" MaxLength="200"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvOtro" runat="server" ControlToValidate="tbOtro"
                            ErrorMessage="Campo requerido" ForeColor="Red" ValidationGroup="aceptar"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td height="17" width="202" align="left" valign="top">
                        Archivo:
                    </td>
                    <td height="17" align="left" valign="top">
                        <asp:FileUpload ID="fuArchivo" runat="server" /><asp:CustomValidator ID="CustomValidator1"
                            runat="server" Display="Dynamic" ErrorMessage="Sólo es posible adjuntar documentos con extensiones Doc y Docx"
                            ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="validacion"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="right">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click"
                            ValidationGroup="aceptar" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <div class="tabla3">
                <asp:Repeater ID="repDocumentos" runat="server" OnItemCommand="repDocumentos_ItemCommand">
                    <HeaderTemplate>
                        <table border="0" cellpadding="0" cellspacing="0" id="tab5" align="center" width="577">
                            <tr>
                                <th>
                                    No.
                                </th>
                                <th width="60">
                                    Fecha
                                </th>
                                <th width="317">
                                    Documento
                                </th>
                                <th width="122">
                                    Eliminar
                                </th>
                                <th width="122">
                                    Obtener documento
                                </th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td style="text-align: center; vertical-align: top;">
                                <%#Container.ItemIndex + 1 %>
                            </td>
                            <td class="alt" width="66" style="text-align: center; vertical-align: top;">
                                <%#string.Format("{0:d}", Eval("sys_fec_insert"))%>
                            </td>
                            <td class="alt" width="323" style="text-align: left; vertical-align: top;">
                                <%#Eval("ddoc_nombre_documento")%>
                            </td>
                            <td class="alt" width="128" style="text-align: center; vertical-align: top;">
                                <asp:ImageButton ID="btnEliminar" runat="server" CommandName="eliminar" CommandArgument='<%#Eval("dshgo_documento_id") + "|" + Eval("ddoc_url_documento") %>'
                                    ImageUrl="~/App_Themes/Tema1/Imagenes/borra.gif" OnClientClick="return confirm('¿Desea eliminar el documento seleccionado?')" />
                            </td>
                            <td class="alt" width="128" style="text-align: center; vertical-align: top;">
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("ddoc_url_documento") %>'>
                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/App_Themes/Tema1/Imagenes/descarga.gif" /></asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <br />
            <br />
            <br />
            <table width="600" border="0" cellpadding="0" cellspacing="7" align="center">
                <tr>
                    <td align="right" valign="top">
                        <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" />
                        
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </center>
    </div>
</asp:Content>
