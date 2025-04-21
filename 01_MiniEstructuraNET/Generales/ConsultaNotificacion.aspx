<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" Theme ="Tema1"  AutoEventWireup="true" CodeBehind="ConsultaNotificacion.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultaNotificacion" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="Content1" runat="server">
    <br />

<br />
  <h3 class="titulo"> <asp:Image ID="Image1" runat="server" ImageUrl="~/App_Themes/Tema1/Imagenes/titlebullet.gif" /><asp:Literal
      ID="ltTitulo" runat="server"></asp:Literal> </h3>
  
  <br />
  <br />
  
  <div id="divAsignar" runat="server">
    <table id="tblAsignar" runat="server" align="center" border="0" cellpadding="0" cellspacing="10" height="67" width="759px">
            <tbody><tr>

              <td colspan="2" height="19"><b>Datos del centro de 
				trabajo</b></td>
              </tr>
			<tr>
              <td style="width: 207px">Nombre o razón social:</td>
              <td    width="349px"> 
                  <asp:Literal ID="ltNombre" runat="server"></asp:Literal>
                </td>

            </tr>

			<tr>
              <td style="width: 207px">Domicilio:</td>
              <td    width="349px"> 
                  <asp:Literal ID="ltDomicilio" runat="server"></asp:Literal>
                </td>

            </tr>
            <tr>
              <td colspan="2" height="17"><b>Datos de la actuación</b></td>
            </tr>
             <tr>
              <td style="width: 207px">Fecha de inspección:</td>
              <td height="17" width="349px">

				  <asp:Literal ID="ltFecInsp" runat="server"></asp:Literal>
                 </td>

            </tr>
             <tr>
              <td style="width: 207px">No. de expediente:</td>
              <td height="17" width="349px">

				  <asp:Literal ID="ltNumExp" runat="server"></asp:Literal>
                 </td>

            </tr>

             <tr>
              <td style="width: 207px">Subtipo de actuación:</td>
              <td height="17" width="349px">

				  <asp:Literal ID="ltSubTipoAct" runat="server"></asp:Literal>
                 </td>

            </tr>
             <tr>
              <td style="width: 207px">Materia:</td>
              <td height="17" width="349px">

				  <asp:Literal ID="ltMateria" runat="server"></asp:Literal>
                 </td>

            </tr>
             <tr>
              <td colspan="2" height="17"><b>Datos de la 
				notificación</b></td>
              </tr>
			<tr>
              <td height="17" style="width: 207px">Tipo de documento:</td>
              <td height="17" width="349px">

				  <asp:Literal ID="ltTipoDoc" runat="server"></asp:Literal>
                 </td>

            </tr>
             <tr>
              <td style="width: 207px">Forma de entrega:</td>
              <td    width="349px"> 

				  <asp:Literal ID="ltFormaEntrega" runat="server"></asp:Literal>
                 </td>

            </tr>
             <tr>
              <td style="width: 207px">Fecha límite de entrega:</td>
              <td    width="349px"> 
                  <asp:Literal ID="ltFecLimiteEntrega" runat="server"></asp:Literal>
                 </td>

            </tr>
             <tr>
              <td height="17" style="width: 207px">Nombre del notificador:</td>

              <td height="17" width="349px"> 
				  <asp:Literal ID="ltNombreNotificador" runat="server"></asp:Literal>
                 </td>

            </tr>
             <tr>
              <td style="width: 207px">Fecha de entrega programada:</td>
              <td    width="349px"> 
                  <asp:Literal ID="ltFecProgramada" runat="server"></asp:Literal>
                 </td>

            </tr>
             </tbody></table>

    <br />

	<table align="center" border="0" cellpadding="0" cellspacing="10" height="45" width="598px">
             <tbody><tr>
			 <td align="right" height="25" style="width: 368px">
                 <asp:Button ID="btnRegresar" runat="server" Text="Regresar" 
                     onclick="btnCancelar_Click" /></td>

			 <td align="right" height="25">
                 &nbsp;</td>

            </tr>
 </tbody></table>
  
  </div>


  <div id="divRegistrar" runat="server">
  

  	<table id="tblRegistrar" runat="server" align="center" border="0" cellpadding="0" cellspacing="10" width="759px">
		<tbody><tr>
			<td colspan="2" height="17" width="739px"><b>Datos del centro de 
			trabajo</b></td>
		</tr>
		<tr>
			<td height="15" style="width: 332px">Nombre o razón social:</td>
			<td height="15" width="402px"> 
                  <asp:Literal ID="ltNombre2" runat="server"></asp:Literal>
                </td>
		</tr>
		<tr>
			<td height="17" style="width: 332px">Domicilio:</td>
			<td height="17" width="402px"> 
                  <asp:Literal ID="ltDomicilio2" runat="server"></asp:Literal>
                </td>

		</tr>
		<tr>
			<td colspan="2" height="17" width="739"><b>Datos de la actuación</b></td>
		</tr>
		<tr>
			<td height="17" style="width: 332px">Fecha de inspección:</td>
			<td height="17" width="402px">

				  <asp:Literal ID="ltFecInsp2" runat="server"></asp:Literal>
                 </td>

		</tr>
		<tr>
			<td height="17" style="width: 332px">No. de expediente:</td>
			<td height="17" width="402px">

				  <asp:Literal ID="ltNumExp2" runat="server"></asp:Literal>
                 </td>
		</tr>
		<tr>
			<td height="17" style="width: 332px">Subtipo de actuación:<br></td>

			<td height="17" width="402px">

				  <asp:Literal ID="ltSubTipoAct2" runat="server"></asp:Literal>
                 </td>
		</tr>
		<tr>
			<td height="17" style="width: 332px">Materia:</td>
			<td height="17" width="402px">

				  <asp:Literal ID="ltMateria2" runat="server"></asp:Literal>
                 </td>
		</tr>
		<tr>
			<td colspan="2" height="17" width="714"><b>Datos de la entrega de la 
			notificación</b></td>
		</tr>
		<tr>
			<td height="17" style="width: 332px">Nombre del notificador:</td>
			<td height="17" width="402px" align="left">

			    <asp:Literal ID="ltNombreNotificador2" runat="server"></asp:Literal>
            </td>
		</tr>
		<tr>
			<td height="17" style="width: 332px">Recibió la empresa:</td>
			<td height="17" width="402px" align="left">

			    <asp:Literal ID="ltRecibio" runat="server"></asp:Literal>
            </td>
		</tr>
        <tr>
			<td height="17" style="width: 332px">Se dejó pegado:</td>
			<td height="17" width="402px" align="left"><asp:Literal ID="ltSeDejo" runat="server"></asp:Literal>
			    &nbsp;</td>
		</tr>

		<tr>
			<td height="17" style="width: 332px">Motivo:</td>
			<td height="17" width="438"><asp:Literal ID="ltMotivoDejo" runat="server"></asp:Literal>
				&nbsp;</td>
		</tr>



		<tr>
			<td height="17" style="width: 332px">Forma de constatación de razón social y 
			domicilio:</td>
			<td height="17" width="402px"><asp:Literal ID="ltFormaCons" runat="server"></asp:Literal>
                &nbsp;</td>
		</tr>
		<tr>

			<td style="width: 332px">Fecha de entrega:<br />
            </td>
			<td style="width: 319px"><asp:Literal ID="ltFecEntrega" runat="server"></asp:Literal>
            </td>

		</tr>
		<tr>
			<td height="17" style="width: 332px">Nombre de la persona que recibió:</td>
			<td height="17" width="402px">
				<asp:Literal ID="ltNombreRecibio" runat="server"></asp:Literal>
				</td>
		</tr>
		<tr>
			<td height="17" style="width: 332px">Dijo ser:</td>

			<td height="17" width="402px"><asp:Literal ID="ltDijoSer" runat="server"></asp:Literal>
				</td>
		</tr>
		<tr>
			<td height="17" style="width: 332px">Observaciones:</td>
			<td height="17" width="355">&nbsp;<asp:Literal ID="ltObservaciones" runat="server"></asp:Literal></td>
			</tr>

	</tbody></table><br>
	<table align="center" border="0" cellpadding="0" cellspacing="7" width="519">
		<tbody><tr>
			<td align="right" valign="top">
			    <asp:Button ID="btnRegresar2" runat="server" Text="Regresar" 
                    onclick="btnCancelar2_Click" />
            </td>
			<td align="right" vsalign="top" width="74">
			
			    &nbsp;</td>
		</tr>
	</tbody></table>




  </div>




</asp:Content>