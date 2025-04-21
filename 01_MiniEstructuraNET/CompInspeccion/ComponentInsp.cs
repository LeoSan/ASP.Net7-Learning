using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompInspeccion.DtoS;

namespace CompInspeccion
{
    public class ComponentInsp
    {
        public ComponentInsp()
		{
             Constantes.CargaStringsConeccion();
		}

		#region Agregar
        Agregar miAgregar = new Agregar();

        public void AgregarAbrirConexion()
        {
            miAgregar.AgregarAbrirConexion();
        }

        public void AgregarCerrarConexion()
        {
            miAgregar.AgregarCerrarConexion();
        }

		public DataSet GenerarConsecutivo(int cve_ur, int anio)
		{
           return miAgregar.GenerarConsecutivo(cve_ur, anio);
        }

        public int InspectorDisponibilidad_Agregar(DtoInspectorDisponibilidad miDtoID)
        {
            return miAgregar.InspectorDisponibilidad_Agregar(miDtoID);
        }

        public int DocumentoAgregarActualizar2(DtoDocumento dtoDocto)
        {
           return miAgregar.DocumentoAgregarActualizar2(dtoDocto);
        }

        public int NotificacionAgregarActualizar(DtoNotificacion dtoNotif)
        {
           return miAgregar.NotificacionAgregarActualizar(dtoNotif);
        }

        public int NotifOtraActuacionAgregarActualizar(DtoNotifOtraActuacion dtoNotif)
        {
           return miAgregar.NotifOtraActuacionAgregarActualizar(dtoNotif);
        }

        //****Agregar DshgoCentroTrabajo
        public int DshgoCentroTrabajoAgregarActualizar(DtoDshgoCentroTrabajo DshgoCT)
        {
            return miAgregar.DshgoCentroTrabajoAgregarActualizar(DshgoCT);
        }

        public int DshgoCentroTrabajoAgregarActualizar2(DtoDshgoCentroTrabajo DshgoCT)
        {
            return miAgregar.DshgoCentroTrabajoAgregarActualizar2(DshgoCT);
        }
        //Agregar DshgoDomicilioFiscal
        public int DshgoDomicilioFiscalAgregarActualizar(DtoDshgoDomicilioFiscal DshgoDF)
        {
            return miAgregar.DshgoDomicilioFiscalAgregarActualizar(DshgoDF);
        }

        public void DoctoVariable_AgregarActualizar(DtoDoctoVariable dtoDocto)
        {
            miAgregar.DoctoVariable_AgregarActualizar(dtoDocto);
        }

        public void DoctoVariables_Agregar(DtoDoctoVariables DtoDoctoVariables)
        {
            miAgregar.DoctoVariables_Agregar(DtoDoctoVariables);
        }

        public void Dshgo_RepTrab_AgregarActualizar(DtoDshgoRepTrabajadores miDtoDshgoRepTrabajadores, string sentencia = "")
        {
            miAgregar.Dshgo_RepTrab_AgregarActualizar(miDtoDshgoRepTrabajadores, sentencia);
        }

        public void Dshgo_RepEmp_AgregarActualizar(DtoDshgoRepEmpresa miDtoDshgoRepEmpresa)
        {
            miAgregar.Dshgo_RepEmp_AgregarActualizar(miDtoDshgoRepEmpresa);
        }

        public void Dshgo_Inspector_AgregarActualizar(DtoDshgoInspector miDtoDshgoInspector)
        {
            miAgregar.Dshgo_Inspector_AgregarActualizar(miDtoDshgoInspector);
        }
       
        public void Dshgo_Experto_AgregarActualizar(DtoDshgoExperto miDtoDshgoExperto)
        {
            miAgregar.Dshgo_Experto_AgregarActualizar(miDtoDshgoExperto);
        }


        public void DoctoValores_AgregarActualizar(DtoDoctoValores dtoDocto)
        {
            miAgregar.DoctoValores_AgregarActualizar(dtoDocto);
        }

        public int DoctoParrafo_AgregarActualizar(DtoDoctoParrafo dtoDoctoP)
        {
            return miAgregar.DoctoParrafo_AgregarActualizar(dtoDoctoP);
        }

        public int DoctoParrafo_AgregarActualizarSipas(DtoDoctoParrafoSipas dtoDoctoP)
        {
            return miAgregar.SDoctoParrafo_AgregarActualizar(dtoDoctoP);
        }

        public int DoctoParrafoTexto_AgregarActualizar(DtoDoctoParrafoTexto dtoDocto)
        {
            return miAgregar.DoctoParrafoTexto_AgregarActualizar(dtoDocto);
        }

        public int SDoctoParrafoTexto_AgregarActualizar(DtoDoctoParrafoTextoSipas dtoDocto)
        {
            return miAgregar.SDoctoParrafoTexto_AgregarActualizar(dtoDocto);
        }
        
        public void DoctoParrafoTexto_Eliminar(string docto_parrafo_texto_id)
        {
            miAgregar.DoctoParrafoTexto_Eliminar(docto_parrafo_texto_id);
        }

        public void DoctoParrafo_Eliminar(string docto_parrafo_id)
        {
            miAgregar.DoctoParrafo_Eliminar(docto_parrafo_id);
        }
        public void DoctoParrafoTexto_EliminarTodos(int docto_parrafo_id)
        {
            miAgregar.DoctoParrafoTexto_EliminarTodos(docto_parrafo_id);
        }

        public void DoctoParrafoMateria_AgregarActualizar(int docto_parrafo_id)
        {
            miAgregar.DoctoParrafoMateria_AgregarActualizar(docto_parrafo_id);
        }

        public void DoctoParrafoSubtipo_AgregarActualizar(int docto_parrafo_id)
        {
            miAgregar.DoctoParrafoSubtipo_AgregarActualizar(docto_parrafo_id);
        }

        public void DoctoParrafoTipo_AgregarActualizar(int docto_parrafo_id)
        {
            miAgregar.DoctoParrafoTipo_AgregarActualizar(docto_parrafo_id);
        }

        public void BitacoraAcceso_Agregar(DtoBitacoraAccesos dtoBitacora)
        {
            miAgregar.BitacoraAcceso_Agregar(dtoBitacora);
        }

       public int Participante_AgregarActualizar(DtoParticipante miDtoPar)
        {
           return  miAgregar.Participante_AgregarActualizar(miDtoPar);
        }

        //agregar usuario
        public int Usuario_AgregarActualizar(DtoUsuario dtousuario)
        {
            return miAgregar.Usuario_AgregarActualizar(dtousuario);
        }

        public int Susuario_AgregarActualizar(DtoSusuario dtosusuario)
        {
            return miAgregar.Susuario_AgregarActualizar(dtosusuario);
        }

        public int Inspector_AgregarActualizar(DtoInspector miDtoI)
        {
            return miAgregar.Inspector_AgregarActualizar(miDtoI);
        }

        //*****************
        public int InspeccioAlcance_AgregarActualizar(int inspec_alcance_id, int submateria_id, int inspeccion_id, string sys_usr)
        {
            return miAgregar.InspeccionAlcance_AgregarActualizar(inspec_alcance_id,submateria_id,inspeccion_id,sys_usr);
        }
        //agregar inspeccion indicador
        public int InspeccionIndicador_AgregarActualizar(int inspec_indicador_id, int indicador_id, int inspeccion_id)
        {
            return miAgregar.InspeccionIndicador_AgregarActualizar(inspec_indicador_id, indicador_id, inspeccion_id);
        }

        //actualizar Materia
        public DataSet Materia_Actualizar(DtoMaterias miDtoM)
        {
            return miAgregar.Materia_Actualizar(miDtoM);
        }

        public int MotivoInspeccion_AgregarActualizar(DtoMotivosInspeccion miDtoMI)
        {
            return miAgregar.MotivoInspeccion_AgregarActualizar(miDtoMI);
        }

        public void MotivoMateria_AgregarActualizar(int materia_id, int motivo_inspeccion_id)
        {
            miAgregar.MotivoMateria_AgregarActualizar(materia_id, motivo_inspeccion_id);
        }

        public int OperativoDocto_Agregar(int operativo_id, String odoc_tipo, String odoc_url, String sys_usr,int operativo_docto_id)
        {
           return miAgregar.OperativoDocto_Agregar(operativo_id, odoc_tipo, odoc_url, sys_usr, operativo_docto_id);
        }

        public void MotivoSubtipo_AgregarActualizar(int subtipo_inspeccion_id, int motivo_inspeccion_id)
        {
            miAgregar.MotivoSubtipo_AgregarActualizar(subtipo_inspeccion_id, motivo_inspeccion_id);
        }

        public DataSet Submateria_AgregarActualizar(DtoSubmateria miDtoS)
        {
            return miAgregar.Submateria_AgregarActualizar(miDtoS);
        }

        public DataSet MateriasGrupo(DtoMateriaGrupo miDtoS)
        {
            return miAgregar.MateriasGrupo(miDtoS);
        }
        
        public int ProgAnual_AgregarActualizar(DtoProgAnual miDtoPA)
        {
            return miAgregar.ProgAnual_AgregarActualizar(miDtoPA);
        }

        public bool ProgAnual_Eliminar(DtoProgAnual miDtoPA)
        {
            return miAgregar.ProgAnual_Eliminar(miDtoPA);
        }

        public int ProgEntidad_AgregarActualizar(DtoProgEntidad miDtoPE)
        {
            return miAgregar.ProgEntidad_AgregarActualizar(miDtoPE);
        }

        public int  OperativoProgr_AgregarActualizar(DtoOperativo miDtoOp)
        {
            return miAgregar.OperativoProgr_AgregarActualizar(miDtoOp);
        }

        //********************
        public int ProgMes_AgregarActualizar(DtoProgMes midto)
        {
            return miAgregar.ProgMes_AgregarActualizar(midto);
        }

		public void ProgMateria_Agregar(int prog_anual_id, string sys_usr, int normatividad_version_id)
		{
			miAgregar.ProgMateria_Agregar(prog_anual_id, sys_usr, normatividad_version_id);
		}

		public void ProgMateria_Actualizar(DtoProgMateria dtoPMateria)
		{
			miAgregar.ProgMateria_Actualizar(dtoPMateria);
		}

		public int ProgAtributo_AgregarParaProgMuestra(int prog_anual_materia_id, string tipo_atributo, string sys_usr)
		{
			return miAgregar.ProgAtributo_AgregarParaProgMuestra(prog_anual_materia_id, tipo_atributo, sys_usr);
		}

        public void ContenidoUsuario_AgregarActualizar(int usuario_id, int infa_tipo)
        {
            miAgregar.ContenidoUsuario_AgregarActualizar(usuario_id, infa_tipo);
        }
        public DataSet ProgAtributo_EstatusConfiguracion(int atributo_id)
        {
            return miAgregar.ProgAtributo_EstatusConfiguracion(atributo_id);
        }

        public int OperativoEntidad_AgregarActualizar(DtoOperativoEntidad miDtoOE)
		{
			return miAgregar.OperativoEntidad_AgregarActualizar(miDtoOE);
		}

		public int ProgAtributo_Actualizar(DtoProgAtributo dtoPAtributo)
		{
			return miAgregar.ProgAtributo_Actualizar(dtoPAtributo);
        }

        public int ProgAtributosActividad_Agregar(DtoProgAct miDtoPA)
        {
            return miAgregar.ProgAtributosActividad_Agregar(miDtoPA);
        }

        public int OperativoAsignacion_AgregarActualizar(DtoOperativoAsignacion miDtoOA)
        {
            return miAgregar.OperativoAsignacion_AgregarActualizar(miDtoOA);
        }        
        
        public int OperativoAsignacion_eliminar(DtoOperativoAsignacion miDtoOA)
        {
            return miEliminar.OperativoAsignacion_Eliminar(miDtoOA);
        }

        public void InspeccionEliminar_SinConcluir(int inspeccion_id)
        {
            miEliminar.PA_Inspeccion_Eliminar_SinConcluir(inspeccion_id);
        }

        public DataSet ProgAtributosActividad_Obtener(int prog_atributo_id)
        {
            return miConsultas.ProgAtributosActividad_Obtener(prog_atributo_id);
        }

        public int OperativoAlcance_AgregarActualizar(DtoOperativoAlcance miDtoOA)
        {
            return miAgregar.OperativoAlcance_AgregarActualizar(miDtoOA);
        }

        public void DoctoParrafoMateria_Actualizar(DtoDoctoParrafoMateria miDtoPM)
        {
            miAgregar.DoctoParrafoMateria_Actualizar(miDtoPM);
        }

        public void SDoctoParrafoMateria_Actualizar(DtoDoctoParrafoMateriaSipas miDtoPM)
        {
            miAgregar.SDoctoParrafoMateria_Actualizar(miDtoPM);
        }

        public void SDoctoParrafoComparecencia_Actualizar(int s_docto_parrafo_texto_id, int con_comparecencia, int comparecencia_seleccionado)
        {
            miAgregar.SDoctoParrafoComparecencia_Actualizar(s_docto_parrafo_texto_id, con_comparecencia, comparecencia_seleccionado);
        }

        public void DoctoParrafoEtiqueta_Actualizar(int parrafo_etiqueta, int parrafo_texto_id, int etiqueta_id, int etiqueta_seleccionado)
        {
            miAgregar.DoctoParrafoEtiqueta_Actualizar(parrafo_etiqueta, parrafo_texto_id, etiqueta_id, etiqueta_seleccionado);
        }

        public void SDoctoParrafoEtiqueta_Actualizar(int parrafo_etiqueta, int parrafo_texto_id, int etiqueta_id, int etiqueta_seleccionado)
        {
            miAgregar.PA_SDoctoParrafoEtiqueta_AgregarActualizar(parrafo_etiqueta, parrafo_texto_id, etiqueta_id, etiqueta_seleccionado);
        }
        
        public void DoctoParrafoSubtipo_Actualizar(DtoDoctoParrafoSubtipo miDtoPS)
        {
            miAgregar.DoctoParrafoSubtipo_Actualizar(miDtoPS);
        }

        public void DoctoParrafoTipo_Actualizar(DtoDoctoParrafoTipo miDtoPT)
        {
            miAgregar.DoctoParrafoTipo_Actualizar(miDtoPT);
        }

        public void ProgAtributo2_Actualizar(DtoProgAct miDtoProAct)
        {
            miAgregar.ProgAtributo2_Actualizar(miDtoProAct);

        }
        
		public void ProgAtributo2SCIAN_Actualizar(DtoProgAct miDtoProAct)
        {
            miAgregar.ProgAtributo2SCIAN_Actualizar(miDtoProAct);

        }

        public int ProgAtributo_AgregarParaOperativo(int operativo_id, string sys_usr)
        {
            return miAgregar.ProgAtributo_AgregarParaOperativo(operativo_id, sys_usr);
        }

        public int Inspeccion_AgregarActualizar(DtoInspeccion miDtoI)
        {
            return miAgregar.Inspeccion_AgregarActualizar(miDtoI);
		}

        public int Inspeccion_Agrega_CopiarParaEmplazamiento(int inspeccion_id, string sys_usr)
		{
			return miAgregar.Inspeccion_Agrega_CopiarParaEmplazamiento(inspeccion_id, sys_usr);
		}
        public int Inspeccion_Agrega_CopiarParaComprobacionSanciones(int inspeccion_id, string sys_usr)
        {
            return miAgregar.Inspeccion_Agrega_CopiarParaComprobacionSanciones(inspeccion_id, sys_usr);
        }
        public int Calificacion_Agrega_CopiarParaEmplazamientoDocumental(int inspeccion_id, string sys_usr)
        {
            return miAgregar.Calificacion_Agrega_CopiarParaEmplazamientoDocumental(inspeccion_id, sys_usr);
        }

        public int Inspeccion_Agrega_CopiarParaReprogramacion(int inspeccion_id, string sys_usr)
		{
			return miAgregar.Inspeccion_Agrega_CopiarParaReprogramacion(inspeccion_id, sys_usr);
		}

		public int Desahogo_CopiarParaEmplazamientoReprogramacion(int inspeccion_id, int dshgo_tipo_desahogo, string sys_usr, int inspeccion_origen_id = -1)
		{
			return miAgregar.Desahogo_CopiarParaEmplazamientoReprogramacion(inspeccion_id, dshgo_tipo_desahogo, sys_usr, inspeccion_origen_id);
		}

        //*******************
        public int Inspeccion_Agregar(DtoInspeccion miDtoI)
        {
            return miAgregar.Inspeccion_Agregar(miDtoI);
        }
        
		public void InspecExperto_AgregarActualizar(int inspec_experto_id, int inspeccion_id, String iexp_experto, String code_participante)
        {
            miAgregar.InspecExperto_AgregarActualizar(inspec_experto_id, inspeccion_id, iexp_experto, code_participante);
        }

        public void InspecParticipante_AgregarActualizar(DtoInspecParticipante miDtoIP)
        {
            miAgregar.InspecParticipante_AgregarActualizar(miDtoIP);
        }

        public void InspecAdicional_AgregarActualizar(DtoInspecAdicional miDtoIA)
        {
            miAgregar.InspecAdicional_AgregarActualizar(miDtoIA);
        }

		public void InspeccionCopia_Agregar(int inspeccion_id, string icop_nombre_copia, string sys_usr)
		{
			miAgregar.InspeccionCopia_Agregar(inspeccion_id, icop_nombre_copia, sys_usr);
        }

        public void InspeccionCopia_Agregar(int inspeccion_id, string icop_nombre_copia, int icop_copia_o_rubrica, string sys_usr)
        {
            miAgregar.InspeccionCopia_Agregar(inspeccion_id, icop_nombre_copia, icop_copia_o_rubrica, sys_usr);
        }

        public void Modificacion_AgregarActualizar(DtoModificacion miDtoM)
        {
            miAgregar.Modificacion_AgregarActualizar(miDtoM);
        }

        public DataSet TipoDocumento_Actualizar(DtoTipoDocumento dtoTipoDocumento)
        {
            return miAgregar.TipoDocumento_Actualizar(dtoTipoDocumento);
        }

        public void TipoDocumento_ActualizarWord(int tipo_documento_id, String td_url_plantilla, int normatividad_id)
        {
            miAgregar.TipoDocumento_ActualizarWord(tipo_documento_id, td_url_plantilla, normatividad_id);
        }

        public int STipoDocumento_Actualizar(DtoTipoDocumentoSipas dtoSTipoDocumento, string sentencia)
        {
            return miAgregar.STipoDocumento_AgregarActualizar(dtoSTipoDocumento, sentencia);
        }
        

        public void ProgAnual_ReplicarAnio(DtoProgAnual miDtoPA)
        {
            miAgregar.ProgAnual_ReplicarAnio(miDtoPA);
        }

        public void ProgAnual_DuplicarPlaneacion_MismoAnio(DtoProgAnual miDtoPA)
        {
            miAgregar.ProgAnual_DuplicarPlaneacion_MismoAnio(miDtoPA);
        }

        

        public void Inspeccion_AgregarAleatoria(int anio, int mes, int cve_ur, int anio_periodicas, string sys_usr)
		{
			miAgregar.Inspeccion_AgregarAleatoria(anio, mes, cve_ur, anio_periodicas, sys_usr);
		}

        public int Inspeccion_AgregarAleatoria_Will(int anio, int mes, int cve_ur, int anio_periodicas, string sys_usr, int cve_ur_comision, int normatividad_id)
        {
           return miAgregar.Inspeccion_AgregarAleatoria_Will(anio, mes, cve_ur, anio_periodicas, sys_usr, cve_ur_comision, normatividad_id);
        }

        public int Inspeccion_AgregarAleatoriaOperativo(int anio, int mes, int cve_ur, int operativo_id, int normativa_version_id, string sys_usr)
		{
           return miAgregar.Inspeccion_AgregarAleatoriaOperativo(anio, mes, cve_ur, operativo_id,normativa_version_id, sys_usr);
		}

        public void InspecCambioInspector_AgregarActualizar(DtoInspecCambioInspector miDtoICI)
        {
            miAgregar.InspecCambioInspector_AgregarActualizar(miDtoICI);
        }

        public int IndTemaFrecuente_AgregarActualizar(DtoIndTemaFrecuente miDtoITF)
        {
            return miAgregar.IndTemaFrecuente_AgregarActualizar(miDtoITF);
        }

        //*************lo nuevo
        public int IndicadorTemaNom_AgregarActualizar(DtoIndTema midato)
        {
            return miAgregar.IndicadorTemaNom_AgregarActualizar(midato);
        }

        public int IndMedidaPlazo_AgregarActualizar(DtoIndMedidaPlazo miDtoIMP)
        {
            return miAgregar.IndMedidaPlazo_AgregarActualizar(miDtoIMP);
        }
        public int IndMedidaPlazo_VersionActualizar(DtoIndMedidaPlazo miDtoIMP)
        {
            return miAgregar.IndMedidaPlazo_VersionActualizar(miDtoIMP);
        }

        public int Incisos_AgregarActualizar(DtoInciso miDtoInc)
        {
            return miAgregar.Incisos_AgregarActualizar(miDtoInc);
        }

        public void InfoAdicional_AgregarActualizar(DtoInfoAdicional miDtoInf)
        {
            miAgregar.InfoAdicional_AgregarActualizar(miDtoInf);
        }


        public DataSet Indicadores_AgregarActualizar(DtoIndicadores miDtoInd)
        {
            return miAgregar.Indicadores_AgregarActualizar(miDtoInd);
        }

        public void IndMedida_AgregarActualizar(DtoIndMedida miDtoIndMed)
        {
            miAgregar.IndMedida_AgregarActualizar(miDtoIndMed);
        }

        public void OperativoIndicador_AgregarActualizar(DtoOperativoIndicador dtoInd)
        {
            miAgregar.OperativoIndicador_AgregarActualizar(dtoInd);
        }


        public void Inspector_AgregarActualizarCapacidades(DtoInspector miDtoI)
        {
            miAgregar.Inspector_AgregarActualizarCapacidades(miDtoI);
        }

        public void Inspeccion_Replicar(int mes_id, int cve_ur, int in_anio, int in_etapa, int operativo_id, int tipo, String sys_usr)
        {
            miAgregar.Inspeccion_Replicar(mes_id, cve_ur, in_anio, in_etapa, operativo_id, tipo, sys_usr);
        }

        public void DshgoMotivoInforme_AgregarActualizar(DtoDshgoMotivoInforme miDtoDMI)
        {
            miAgregar.DshgoMotivoInforme_AgregarActualizar(miDtoDMI);
        }

        public int Desahogo_Agregar(DtoDesahogo miDtoD)
        {
            return miAgregar.Desahogo_Agregar(miDtoD);
        }

        public int Desahogo_AgregarActualizar(DtoDesahogo miDtoD)
        {
            return miAgregar.Desahogo_AgregarActualizar(miDtoD);
        }

        public void Dshgo_Area_AgregarActualizar(DtoDshgoArea miDtoDsA)
        {
            miAgregar.Dshgo_Area_AgregarActualizar(miDtoDsA);
        }

        public void DshgoAlcance_AgregarActualizar(DtoDshgoAlcance miDtoDAl)
        {
            miAgregar.DshgoAlcance_AgregarActualizar(miDtoDAl);
        }

        //*************************
        public int DesahogoInstalacion_AgregarActualizar(int dshgo_instalacion_id, int desahogo_id, int tipo_instalacion_id)
        {
            return miAgregar.DesahogoInstalacion_AgregarActualizar(dshgo_instalacion_id,desahogo_id,tipo_instalacion_id);
        }

        public int DshgoCentroCamara_AgregarActualizar(DtoDshgoCentroCamara camara)
        {
            return miAgregar.DshgoCentroCamara_AgregarActualizar(camara);
        }

        public void DshgoCaptura_AgregarActualizar(DtoDshgoCaptura miDtoCap)
        {
            miAgregar.DshgoCaptura_AgregarActualizar(miDtoCap);
        }

        public int DshgoParticipantes_AgregarActualizar(DtoDshgoParticipantes miDtoPart)
        {
            return miAgregar.DshgoParticipantes_AgregarActualizar(miDtoPart);
        }

        public void Dshgo_Comision_AgregarActualizar(int dshgo_participante_id, int tipo_identificacion_id, string dcom_num_identificacion, int dcom_parte_representa)
        {
            miAgregar.Dshgo_Comision_AgregarActualizar(dshgo_participante_id,tipo_identificacion_id, dcom_num_identificacion, dcom_parte_representa);
        }


        public int Dshgo_SupuestoDsgn_AgregarActualizar(Int16 supuesto_designacion_id, string supd_supuesto, Int16 supd_designacion_testigo_1, Int16 supd_designacion_testigo_2, Int16 supd_designado_por)
        {
            return miAgregar.Dshgo_SupuestoDsgn_AgregarActualizar(supuesto_designacion_id, supd_supuesto, supd_designacion_testigo_1, supd_designacion_testigo_2, supd_designado_por);
        }


        public void DshgoTestigo_AgregarActualizar(DtoDshgoTestigo miDtoTestigo)
        {
            miAgregar.DshgoTestigo_AgregarActualizar(miDtoTestigo);
        }


		public void DshgoTrabajador_AgregarTablero(int desahogo_id, string sys_usr)
		{
			miAgregar.DshgoTrabajador_AgregarTablero(desahogo_id, sys_usr);
		}

		public int DshgoTrabajador_AgregarActualizar(DtoDshgoTrabajador dtoTrabajador)
		{
			return miAgregar.DshgoTrabajador_AgregarActualizar(dtoTrabajador);
		}

		public int DshgoTrabajadorDetalle_AgregarActualizar(DtoDshgoTrabajadorDetalle dtoDshgoTrabajadorDetalle)
		{
			return miAgregar.DshgoTrabajadorDetalle_AgregarActualizar(dtoDshgoTrabajadorDetalle);
		}

        public int DshgoInspector_Eliminar(int dshgo_inspector_id)
        {
           return miEliminar.DshgoInspector_Eliminar(dshgo_inspector_id);
        }

        public int DshgoExperto_Eliminar(int dshgo_experto_id)
        {
            return miEliminar.DshgoExperto_Eliminar(dshgo_experto_id);
        }
       
	    public void DshgoParticipantes_Eliminar(int dshgo_inspector_id)
        {
            miEliminar.DshgoParticipantes_Eliminar(dshgo_inspector_id);
        }
        public void DshgoTestigo_Eliminar(int dshgo_testigo_id)
        {
            miEliminar.DshgoTestigo_Eliminar(dshgo_testigo_id);
        }

        public int DshgoInterrogado_AgregarActualizar(DtoDshgoInterrogado miDtoInt)
        {
            return miAgregar.DshgoInterrogado_AgregarActualizar(miDtoInt);
        }

        public int DshgoListadoTrabajador_AgregarActualizar(DtoDshgoListadoPersonalActivo midtoListado)
        {
            return miAgregar.DshgoListadoTrabajador_AgregarActualizar(midtoListado);
        }

        public void DshgoInterrogatorio_AgregarActualizar(DtoDshgoInterrogatorio miDtoDshgoInt)
        {
            miAgregar.DshgoInterrogatorio_AgregarActualizar(miDtoDshgoInt);
        }

        public void DshgoInterrogatorioAbierta_AgregarActualizar(DtoDshgoInterrogatorioAbierta miDtoIA)
        {
            miAgregar.DshgoInterrogatorioAbierta_AgregarActualizar(miDtoIA);
        }

		public void DshgoSolidaria_AgregarDNE(int dshgo_centro_trabajo_id, int centro_trabajo_id)
		{
			miAgregar.DshgoSolidaria_AgregarDNE(dshgo_centro_trabajo_id, centro_trabajo_id);
		}

		public int DshgoSolidaria_AgregarActualizar(DtoDshgoSolidaria dtoSolidaria)
		{
			return miAgregar.DshgoSolidaria_AgregarActualizar(dtoSolidaria);
		}


        public void DshgoDocumentoAgregarActualizar(DtoDshgoDocumento dtoDocto)
        {
            miAgregar.DshgoDocumentoAgregarActualizar(dtoDocto);
        }

        public int DshgoDocumentoAgregarActualizar2(DtoDshgoDocumento dtoDocto)
        {
            return miAgregar.DshgoDocumentoAgregarActualizar2(dtoDocto);
        }

        public int DshgoMedida_AgregarActualizar(DtoDshgoMedida midtoDM)
        {
           return  miAgregar.DshgoMedida_AgregarActualizar(midtoDM);
        }

        public void DshgoMedida_Agregar_PorNegativaPatronal(int inspeccion_id, int inspeccion_origen_id, int desahogo_id, string sys_usr)
        {
            miAgregar.DshgoMedida_Agregar_PorNegativaPatronal(inspeccion_id, inspeccion_origen_id, desahogo_id, sys_usr);
        }

        public int DshgoMedida_AgregarActualizarOpen(DtoDshgoMedida midtoDM)
        {
            return miAgregar.DshgoMedida_AgregarActualizarOpen(midtoDM);
        }
        
        public int ObtenerAreaPorNombreDesahogo(string area, int desahogo_id)
        {
            return miAgregar.ObtenerAreaPorNombreDesahogo(area, desahogo_id);
        }
        
        public int DshgoMedida_AgregarActualizar2(DtoDshgoMedida midtoDM)
        {
            return miAgregar.DshgoMedida_AgregarActualizar2(midtoDM);
        }


        public void DshgoSindicato_Agregar(int dshgo_sindicato_id, int desahogo_id, string dsind_sindicato, string sys_usr,int sindicato_id)
        {
            miAgregar.DshgoSindicato_Agregar(dshgo_sindicato_id, desahogo_id, dsind_sindicato, sys_usr, sindicato_id);
        }

        public void DshgoSindicato_Agregar(int dshgo_sindicato_id, int desahogo_id, string dsind_sindicato, string sys_usr)
        {
            miAgregar.DshgoSindicato_Agregar(dshgo_sindicato_id, desahogo_id, dsind_sindicato, sys_usr);
        }


        public void DshgoDoctoVariables_Agregar(DtoDshgoDoctoVariables DtoDshgoDoctoVariables)
        {
            miAgregar.DoctoDshgoVariables_Agregar(DtoDshgoDoctoVariables);
        }

        public int DshgoMedDescatalogada_AgregarActualizar(DtoDshgoMedDescatalogada midtoDM)
        {
            return miAgregar.DshgoMedDescatalogada_AgregarActualizar(midtoDM);
        }

		public int DshgoRevision_AgregarActualizar(DtoDshgoRevision dtoRevision)
		{
			return miAgregar.DshgoRevision_AgregarActualizar(dtoRevision);
		}

        public void DshgoMedDescatalogadaArea_AgregarActualizar(int dsgo_area_id, int dshgo_med_descatalogada_id)
        {
            miAgregar.DshgoMedDescatalogadaArea_AgregarActualizar(dsgo_area_id, dshgo_med_descatalogada_id);
        }


        public void DshgoMedidaArea_AgregarActualizar(int dsgo_area_id, int dshgo_medida_id)
        {
            miAgregar.DshgoMedidaArea_AgregarActualizar(dsgo_area_id,dshgo_medida_id);
        }

        public void DshgoMedidaArea_AgregarActualizarOpen(int dsgo_area_id, int dshgo_medida_id)
        {
            miAgregar.DshgoMedidaArea_AgregarActualizarOpen(dsgo_area_id, dshgo_medida_id);
        }

        public void DshgoMedida_ActualizarObservaciones(int dshgo_medida_id,string obs,string usr)
        {
            miAgregar.DshgoMedida_ActualizarObservaciones(dshgo_medida_id,obs,usr);
        }

		public int DshgoRevisionInfo_AgregarActualizar(DtoDshgoRevisionInfo dtoRI)
		{
			return miAgregar.DshgoRevisionInfo_AgregarActualizar(dtoRI);
        }

        public void Desahogo_Actualizar_dshgo_sin_Medidas(int desahogo_id , int dshgo_sin_medidas)
        {
            miAgregar.Desahogo_Actualizar_dshgo_sin_Medidas(desahogo_id ,dshgo_sin_medidas);
        }


        public int Calificacion_AgregarActualizar(DtoCalificacion DtoCalf)
        {
           return miAgregar.Calificacion_AgregarActualizar(DtoCalf);
        }

        public void Calificacion_ActualizarRevisionDocumental(int calificacion_id)
        {
            miAgregar.Calificacion_ActualizarRevisionDocumental(calificacion_id);
        }

        public int CalifDocumento_AgregarActualizar(DtoCalifDocumento miDtoCD)
        {
            return miAgregar.CalifDocumento_AgregarActualizar(miDtoCD);
        }

        //califdocumento por calificacion
        public int CalifDocumento_AgregarActualizarPorCalificacion(DtoCalifDocumento miDtoCD)
        {
            return miAgregar.CalifDocumento_AgregarActualizarPorCalificacion(miDtoCD);
        }

        public void CalifDoctoCopias_AgregarActualizar(DtoCalifDoctoCopias miDtoCDC)
        {
            miAgregar.CalifDoctoCopias_AgregarActualizar(miDtoCDC);
        }

        public void CalifViolacion_AgregarActualizar(DtoCalifViolacion miDtoCV)
        {
            miAgregar.CalifViolacion_AgregarActualizar(miDtoCV);
        }

        public void CalifViolacion_AgregarNumSolicitud(DtoCalifViolacion miDtoCV, string tipo_inspeccion = "")
        {
            miAgregar.CalifViolacion_AgregarNumSolicitud(miDtoCV, tipo_inspeccion);
        }



        public void CalifViolacion_AgregarActualizarParaNegativa(DtoCalifViolacion miDtoCV, List<DtoCalifViolacionLista> ListViolaciones)
        {
            miAgregar.CalifViolacion_AgregarActualizarParaNegativa(miDtoCV, ListViolaciones);
        }

        public void CalifViolacion_AgregarPorComprobacionMedidas(int origen_calificacion_id, List<DtoCalifViolacionLista> ListViolaciones)
        {
            miAgregar.CalifViolacion_AgregarPorComprobacionMedidas(origen_calificacion_id, ListViolaciones);
        }

        public void CalifViolacion_AgregarPorComprobacionMedidas_NP(int calificacion_id)
        {
            miAgregar.CalifViolacion_AgregarPorComprobacionMedidas_NP(calificacion_id);
        }

        

        public int CalifRequisitoRespuesta_AgregarActualizar(DtoCalifRequisitoRespuesta dtoCRR)
		{
			return miAgregar.CalifRequisitoRespuesta_AgregarActualizar(dtoCRR);
		}

        public void CalifDoctoVariables_Agregar(DtoCalifDoctoVariables dtoVar)
        {
            miAgregar.CalifDoctoVariables_Agregar(dtoVar);
        }

        public DataSet GenerarNumeroDocumentoPorCalifDocumentoID(int cve_ur, int tipo_documento_id, int anio, int calif_documento_id, int normatividad_Id)
        {
          return  miAgregar.GenerarNumeroDocumentoPorCalifDocumentoID(cve_ur,tipo_documento_id,anio,calif_documento_id, normatividad_Id);
        }

        public void GenerarNumeroDocumentoParaAmpliacion(int cve_ur, int anio, int calif_documento_id)
        {
            miAgregar.GenerarNumeroDocumentoParaAmpliacion(cve_ur, anio, calif_documento_id);
        }

        public void InspectorMedida_AgregarActualizar(int desahogo_id, int participante_id)
        {
            miAgregar.InspectorMedida_AgregarActualizar( desahogo_id, participante_id);
        }

       

        public void Emplazamiento_AgregarActualizar(DtoEmplazamiento dtoEmp)
        {
            miAgregar.Emplazamiento_AgregarActualizar(dtoEmp);
        }
        public int Sancion_AgregarActualizar(DtoSancion dtoSancion)
        {
            return miAgregar.Sancion_AgregarActualizar(dtoSancion);
        }
        public DataSet ObtenerIncumplimientosParaSancion(int inspeccion_origen_id, string sentencia)
        {
            return miAgregar.ObtenerIncumplimientosParaSancion(inspeccion_origen_id,sentencia);
        }

        public void Emplazamiento_Actualizar_FechaLimite(int emplazamiento_id, string em_fecha_limite)
        {
            miAgregar.Emplazamiento_Actualizar_FechaLimite(emplazamiento_id, em_fecha_limite);
        }

        public void Sancion_Actualizar_FechaLimite(int sancion_id, string san_fecha_limite)
        {
            miAgregar.Sancion_Actualizar_FechaLimite(sancion_id, san_fecha_limite);
        }

        public void EmplazamientoDocumental_AgregarActualizar(DtoEmplazamiento dtoEmp)
        {
            miAgregar.EmplazamientoDocumental_AgregarActualizar(dtoEmp);
        }

        public void Reprogramacion_AgregarActualizar(DtoReprogramacion dtoRep)
        {
            miAgregar.Reprogramacion_AgregarActualizar(dtoRep);
        }

		public void EmplazamientoNumeral_Agregar(int emplazamiento_id, int inspeccion_origen_id)
		{
			miAgregar.EmplazamientoNumeral_Agregar(emplazamiento_id, inspeccion_origen_id);
		}

        public void EmplazamientoNumeral_Agregar_PorNegativaPatronal(int emplazamiento_id, int inspeccion_origen_id)
        {
            miAgregar.EmplazamientoNumeral_Agregar_PorNegativaPatronal(emplazamiento_id, inspeccion_origen_id);
        }

        

        public int EmplazamientoNumeral_AgregarActualizar(DtoEmplazamientoNumeral dtoEmp)
        {
            return miAgregar.EmplazamientoNumeral_AgregarActualizar(dtoEmp);
        }

        //**************
        public int Centro_Agregar(DtoCentro dtoCentro)
        {
            return miAgregar.Centro_Agregar(dtoCentro);
        }

        public int Empresa_Agregar(DtoEmpresa dtoempresa)
        {
            return miAgregar.Empresa_Agregar(dtoempresa);
        }

        public int CentroCamara_AgregarActualizar(DtoCentroCamara dtoCC)
        {
            return miAgregar.CentroCamara_AgregarActualizar(dtoCC);
        }

        public int CentroSindicato_AgregarActualizar(DtoCentroSindicato dtoCC)
        {
            return miAgregar.CentroSindicato_AgregarActualizar(dtoCC);
        }

		public void CentroMateria_Agregar(int inspeccion_id)
		{
			miAgregar.CentroMateria_Agregar(inspeccion_id);
		}

        public int CentroInformacion_AgregarActualizar(DtoCentroInformacion dtoCI)
        {
            return miAgregar.CentroInformacion_AgregarActualizar(dtoCI);
        }

        public int CentroMovimiento_AgregarActualizar(DtoCentroMovimiento dtoCM)
        {
            return miAgregar.CentroMovimiento_AgregarActualizar(dtoCM);
        }

        public int EmpresaMovimiento_AgregarActualizar(DtoEmpresaMovimiento dtoEM)
        {
            return miAgregar.EmpresaMovimiento_AgregarActualizar(dtoEM);
        }

        #region PAS

        public int s_notif_resultado_AgregarActualizar(DtoSNotifResultado miDtos_notif_resultado)
        {
            return miAgregar.s_notif_resultado_AgregarActualizar(miDtos_notif_resultado);
        }

        public int notif_sancionador_AgregarActualizar(DtoNotifSancionador miDtonotif_sancionador)
        {
            return miAgregar.notif_sancionador_AgregarActualizar(miDtonotif_sancionador);
        }

        public int s_notif_requerir_AgregarActualizar(DtoSNotifRequerir miDtos_notif_requerir)
        {
            return miAgregar.s_notif_requerir_AgregarActualizar(miDtos_notif_requerir);
        }

        #endregion

        public int DshgoConsultaRestriccionAcceso_AgregarActualizar(DtoDshgoMedidaPrecautoriaConsulta midtoConsulta)
        {
            return miAgregar.DshgoConsultaRestriccionAcceso_AgregarActualizar(midtoConsulta);
        }

        public int DshgoConsultaRestriccionAcceso_AgregarRespuesta(DtoDshgoMedidaPrecautoriaConsulta midtoConsulta)
        {
            return miAgregar.DshgoConsultaRestriccionAcceso_AgregarRespuesta(midtoConsulta);
        }
        
        #endregion

        #region Consultar
        Consultas miConsultas = new Consultas();

        public void AbrirConexion()
        {
            miConsultas.AbrirConexion();
        }

        public void CerrarConexion()
        {
            miConsultas.CerrarConexion();
        }



        #region Consultas Seguimiento Inspecciones

        public DataSet Seguimiento_ObtenerInspeccionesDetalle(int tipoDetalle, int tipoPeriodo, int filtro, DateTime fechaActual, int cve_edo = -1, int cve_ur = -1, int inspector_id = -1)
        {
            return miConsultas.ObtenerInspeccionesDetalle(tipoDetalle, tipoPeriodo, filtro, fechaActual, cve_edo, cve_ur, inspector_id);
        }

        public List<DtoInspeccionDetalle> Seguimiento_ObtenerInspeccionesDetalleDto(int tipoDetalle, int tipoPeriodo, int filtro, DateTime fechaActual, int cve_edo = -1, int cve_ur = -1, int inspector_id = -1)
        {
            List<DtoInspeccionDetalle> lstResult = new List<DtoInspeccionDetalle>();
            DataSet dsInspDetalle = miConsultas.ObtenerInspeccionesDetalle(tipoDetalle, tipoPeriodo, filtro, fechaActual, cve_edo, cve_ur, inspector_id);
            if (dsInspDetalle.Tables.Count > 0)
            {
                foreach (DataRow dr in dsInspDetalle.Tables["resultado"].Rows)
                {
                    DtoInspeccionDetalle newDetalle = new DtoInspeccionDetalle();
                    newDetalle.inspectorId = int.Parse(dr["inspectorId"].ToString());
                    newDetalle.inspectorNombre = dr["inspectorNombre"].ToString();
                    newDetalle.inspectorCredencial = dr["inspectorCredencial"].ToString();
                    newDetalle.inspeccionFecha = DateTime.Parse(dr["inspeccionFecha"].ToString());
                    newDetalle.inspeccionExpediente = dr["inspeccionExpediente"].ToString();
                    newDetalle.unidadResponsable = dr["unidadResponsable"].ToString();
                    newDetalle.estado = dr["estado"].ToString();
                    newDetalle.razonSocial = dr["razonSocial"].ToString();
                    newDetalle.materiaAcronimo = dr["materiaAcronimo"].ToString();
                    newDetalle.materiaNombre = dr["materiaNombre"].ToString();
                    newDetalle.infoAdicional = dr["infoAdicional"].ToString();
                    lstResult.Add(newDetalle);
                }
            }
            return lstResult;
        }

        public DataSet Seguimiento_ObtenerInspeccionesPorMateria(int cve_ur = -1, int cve_edorep = -1, int participante_id = -1, DateTime? fechaActual = null)
        {
            return miConsultas.ObtenerInspeccionesPorMateria(cve_ur, cve_edorep, participante_id, fechaActual);
        }

        public DataSet Seguimiento_ObtenerInspeccionesPorOperativo(int cve_ur = -1, int cve_edorep = -1, int participante_id = -1, DateTime? fechaActual = null)
        {
            return miConsultas.ObtenerInspeccionesPorOperativo(cve_ur, cve_edorep, participante_id, fechaActual);
        }

        public DataSet Seguimiento_ObtenerInspeccionesPorResultado(int cve_ur = -1, int cve_edorep = -1, int participante_id = -1, DateTime? fechaActual = null)
        {
            return miConsultas.ObtenerInspeccionesPorResultado(cve_ur, cve_edorep, participante_id, fechaActual);
        }

        #region Promedios Utilizados para los Semaforos

        public DataSet Seguimiento_ObtenerSemaforo()
        {
            return miConsultas.ObtenerSemaforo();
        }

        public DataSet Seguimiento_ObtenerInspeccionesPorPromedioNacional(int cve_edo = -1, DateTime? fechaActual = null)
        {
            return miConsultas.ObtenerInspeccionesPorPromedioNacional(cve_edo, fechaActual);
        }

        public DataSet Seguimiento_ObtenerInspeccionesPorPromedioEstatal(int cve_edo = -1, int cve_ur = -1, DateTime? fechaActual = null)
        {
            return miConsultas.ObtenerInspeccionesPorPromedioEstatal(cve_edo, cve_ur, fechaActual);
        }



        #endregion


        public void semaforoActualiza(string strColor, double sblRMa, double sblRMi)
        {
            miAgregar.semaforoActualiza(strColor, sblRMa, sblRMi);
        }
        public DataSet obtenrSemaforo()
        {
            return miConsultas.obtenrSemaforo();

        }
        public DataSet obtenResolucionesInspeccion(int cve_ur = -1, int cve_edorep = -1, int in_anio = -1, int participante_id = -1, DateTime? fechaActual = null)
        {
            return miConsultas.obtenResolucionesInspeccion(cve_ur, cve_edorep, in_anio, fechaActual);
        }
        public DataSet buscaInspectorGen(string strCriterio, string strEdo)
        {
            return miConsultas.obtenInspectorGen(strCriterio, strEdo);
        }
        public DataSet Estados_ObtenerPorAbreviacion(string edo)
        {
            return miConsultas.ObtenerEstadosPorAbreviacion(edo);
        }

        public DataSet Inspector_Tablero_Obtener(int cve_ur = -1, int cve_cve_edorep = -1, int inspector_id = -1, string insp_num_credencial = "")
        {
            return miConsultas.Inspector_Tablero_Obtener(cve_ur, cve_cve_edorep, inspector_id, insp_num_credencial);
        }
        #endregion



        #region Inspeccion
        public DataSet Usuario_Obtener(int usuario_id, String usr_login, String usr_email, String usr_estatus = "Ninguno", int perfil_id = -1)
		{
			return miConsultas.Usuario_Obtener(usuario_id, usr_login, usr_email, usr_estatus, perfil_id);
		}

        public DataSet SUsuario_Obtener(int usuario_id, String usr_login, String usr_email, String usr_estatus = "Ninguno")
        {
            return miConsultas.SUsuario_Obtener(usuario_id, usr_login, usr_email, usr_estatus);
        }
        
        public bool Usuario_Actualizar_CoreUsuarioId(int core_usuario_id, String usr_email)
        {
            return miConsultas.Usuario_Actualizar_CoreUsuarioId(core_usuario_id, usr_email);
        }

        public DataSet SUsuario_ObtenerUsuariosPorIdPerfil(int perfil_id, int cve_ur = -1)
        {
            return miConsultas.SUsuario_ObtenerUsuariosPorIdPerfil(perfil_id, cve_ur);
        }

        //usuario obtener por edo o ur
        public DataSet Usuario_ObtenerPorEdoUr(int usuario_id, int ur, int edo, string txt_search)
		{
			return miConsultas.Usuario_ObtenerPorEdoUr(usuario_id, ur, edo, txt_search);
		}

        public DataSet OperativosProgramados_Obtener(int prog_anual_id, int operativo_id, int oper_tipo_operativo, int mes, int oper_estatus, int panual_estatus = -1)
		{
            return miConsultas.OperativosProgramados_Obtener(prog_anual_id, operativo_id, oper_tipo_operativo, mes,oper_estatus, panual_estatus);
		}
        
        public DataSet OperativosProgramados_ObtenerParaProgInsp(int prog_anual_id, int operativo_id, int oper_tipo_operativo, int mes, int oper_estatus, int dia_hoy, int tipo_inspeccion_id=-1)
        {
            return miConsultas.OperativosProgramados_ObtenerParaProgInsp(prog_anual_id, operativo_id, oper_tipo_operativo, mes, oper_estatus, dia_hoy, tipo_inspeccion_id);
        }
		public DataSet OperativosDocto_Obtener(int operativo_id)
		{
			return miConsultas.OperativosDocto_Obtener(operativo_id);
		}		
        
        public DataSet OperativosDocto_ObtenerPorID(int operativo_docto_id)
		{
			return miConsultas.OperativosDocto_ObtenerPorID(operativo_docto_id);
		}

        //******************
        public DataSet InspeccionAlcance_Obtener(int inspec_alcance_id, int submateria_id, int inspeccion_id)
        {
            return miConsultas.InspeccionAlcance_Obtener(inspec_alcance_id,submateria_id,inspeccion_id);
        }

        //***inspec indicador obtener
        public DataSet InspeccionIndicador_Obtener(int inspec_indicador_id, int indicador_id, int inspeccion_id)
        {
            return miConsultas.InspeccionIndicador_Obtener(inspec_indicador_id, indicador_id, inspeccion_id);
        }
        public DataSet OperativosDocto_ObtenerSinOp()
        {
            return miConsultas.OperativosDocto_ObtenerSinOp();
        }
		public DataSet Perfil_Obtener()
		{
			return miConsultas.ObtenerPerfiles();
		}

		public DataSet Estados_Obtener(int edo)
		{
			return miConsultas.ObtenerEstados(edo);
		}
        public DataSet MateriasObtener(int materia_id, int? normativa_version_id = -1, string mat_acronimo = null, int mat_estatus = -1,int diferentes = -1)
		{
			return miConsultas.MateriasObtener(materia_id, normativa_version_id, mat_acronimo, mat_estatus, diferentes);
		}
        public DataSet DatosObtenerDocumentoLegadoPorInspeccionId(int inspeccion_id)
		{
			return miConsultas.DatosObtenerDocumentoLegadoPorInspeccionId(inspeccion_id);
		}

        public DataSet Obtener_DatosExpediente_Satelite(int inspeccion_id)
        {
            return miConsultas.Obtener_DatosExpediente_Satelite(inspeccion_id);
        }

        public DataSet Variables_Obtener(int documento_id)
        {
            return miConsultas.Variables_Obtener(documento_id);
        }

        public DataSet Variables_Obtener2(int documento_id)
        {
            return miConsultas.Variables_Obtener2(documento_id);
        }

		public DataSet DoctoParrafo_Obtener(DtoDoctoBusqueda dtoDocto)
		{
			return miConsultas.DoctoParrafo_Obtener(dtoDocto);
		}

        public DataSet SDoctoParrafo_Obtener(DtoDoctoBusquedaSipas dtoDocto)
		{
			return miConsultas.SDoctoParrafo_Obtener(dtoDocto);
		}
        


        public DataSet DoctoParrafoTexto_Obtener(DtoDoctoBusqueda dtoDocto)
		{
			return miConsultas.DoctoParrafoTexto_Obtener(dtoDocto);
		}

        public DataSet DoctoParrafoTexto_Obtener2(DtoDoctoBusqueda dtoDocto)
        {
            return miConsultas.DoctoParrafoTexto_Obtener2(dtoDocto);
        }

        public DataSet SDoctoParrafoTexto_Obtener2(int s_docto_parrafo_id)
        {
            return miConsultas.SDoctoParrafoTexto_Obtener(s_docto_parrafo_id);
        }

        public DataSet DoctoVariableValores_Obtener(DtoDoctoBusqueda dtoDocto)
		{
			return miConsultas.DoctoVariableValores_Obtener(dtoDocto);
		}


        public DataSet DoctoVariableValores_Obtener2(DtoDoctoBusqueda dtoDocto)
        {
            return miConsultas.DoctoVariableValores_Obtener2(dtoDocto);
        }

		public DataSet Documento_Obtener(DtoDocumento dtoDocto, string sentencia = "SELECT")
		{
			return miConsultas.Documento_Obtener(dtoDocto, sentencia);
		}

        public void DocumentoEliminarPorID(int documento_id, String tipo_borrado = "documento")
        {
            miEliminar.DocumentoEliminarPorID(documento_id, tipo_borrado);
        }

        public DataSet Tipo_Documento_Obtener(DtoTipoDocumento dtoTipo)
        {
            return miConsultas.Tipo_Documento_Obtener(dtoTipo);
        }

        public DataSet S_Tipo_Documento_Obtener(int tipo, int normativa_id = -1)
        {
            return miConsultas.STipoDocumento_Obtener(tipo, normativa_id);
        }

        public DataSet Parrafo_BuscarActualizar(string sentencia, int mat_normativa_version_id, string buscar_parrafo, int docto_parrafo_texto_id, string dpt_parrafo)
        {
            return miConsultas.Parrafo_BuscarActualizar(sentencia, mat_normativa_version_id, buscar_parrafo, docto_parrafo_texto_id, dpt_parrafo);
        }

        public DataSet Tipo_Documento_Inspeccion(DtoTipoDocumentoInspeccion dtoTipo)
        {
            return miConsultas.Tipo_Documento_Inspeccion(dtoTipo);
        }

        public DataSet Normatividad_Version(NormatividadVersion dtoNormatividadVersion, string orderBy = "normatividad_version_id")
        {
            return miConsultas.Normatividad_Version(dtoNormatividadVersion, orderBy);
        }

        public DataSet Tipo_DocumentoOtro_Obtener(DtoTipoDocumento dtoTipo)
        {
            return miConsultas.Tipo_DocumentoOtro_Obtener(dtoTipo);
        }


		public DataSet Participante_Obtener(DtoParticipante miDtoPar, int dpart_tipo_participante = -1, string usr_estatus = null)
		{
			return miConsultas.Participante_Obtener(miDtoPar,-1, usr_estatus);
		}

        public DataSet Participante_Obtener(DtoParticipante miDtoPar, int dpart_tipo_participante)
        {
            return miConsultas.Participante_Obtener(miDtoPar, dpart_tipo_participante);
        }

        public DataSet Notificadores_Obtener(DtoParticipante miDtoPar)
        {
            return miConsultas.Notificadores_Obtener(miDtoPar);
        }

		public DataSet MotivoInspeccion_Obtener(int motivo_inspeccion_id, int motiv_consecutivo, int normatividad_id = -1)
		{
			return miConsultas.MotivoInspeccion_Obtener(motivo_inspeccion_id, motiv_consecutivo, normatividad_id);
		}

        public DataSet MotivoInspeccion_ObtenerOp(int motivo_inspeccion_id, int motiv_consecutivo, int motiv_para_operativo_programado, int motiv_para_operativo_especial)
		{
			return miConsultas.MotivoInspeccion_ObtenerOp(motivo_inspeccion_id, motiv_consecutivo, motiv_para_operativo_programado, motiv_para_operativo_especial);
		}
		
		public DataSet MotivoMateria_Obtener(int motivo_inspeccion_id,int mat, string sentencia = "DEFAULT")
		{
			return miConsultas.MotivoMateria_Obtener(motivo_inspeccion_id, mat, sentencia);
		}

        //***************
        public DataSet SubtipoMateria_Obtener(int subtipo_inspeccion_id, int mat)
        {
            return miConsultas.SubtipoMateria_Obtener(subtipo_inspeccion_id, mat);
        }

        public DataSet SubtipoMateria(DtoSubtipoMateria dtoSubtipoMateria)
        {
            return miConsultas.SubtipoMateria(dtoSubtipoMateria);
        }

        public DataSet SeccionesMateria(DtoSeccionesMateria dtoSeccionesMateria)
        {
            return miConsultas.SeccionesMateria(dtoSeccionesMateria);
        }

        public DataSet MotivoMateriaSubtipo_Obtener(int motivo_inspeccion_id, int mat,int sub)
        {
            return miConsultas.MotivoMateriaSubtipo_Obtener(motivo_inspeccion_id, mat, sub);
        }

        //motivo para operativo
        public DataSet MotivoMateriaSubtipo_ObtenerPorTipoOperativo(int motivo_inspeccion_id, int mat, int sub,int opesp,int opprog)
        {
            return miConsultas.MotivoMateriaSubtipo_ObtenerPorTipoOperativo(motivo_inspeccion_id, mat, sub,opesp,opprog);
        }

		public DataSet ProgEntidad_Obtener(DtoProgEntidad miDtoPE, int anio, int prog_anual_id)
		{
			return miConsultas.ProgEntidad_Obtener(miDtoPE, anio, prog_anual_id);
		}

        public DataSet ProgEntidad_ObtenerTodosMeses(DtoProgEntidad miDtoPE)
        {
            return miConsultas.ProgEntidad_ObtenerTodosMeses(miDtoPE);
        }
		//******
        public DataSet ProgEntidad_ObtenerAnual(DtoProgEntidad miDtoPE)
        {
            return miConsultas.ProgEntidad_ObtenerAnual(miDtoPE);
        }

        //*****
        public DataSet ProgEntidad_ObtenerAnualEstado(DtoProgEntidad miDtoPE)
        {
            return miConsultas.ProgEntidad_ObtenerAnualEstado(miDtoPE);
        }

        //********
        public DataSet ProgEntidad_ObtenerTotalPorProgAnual(int prog_anual_id)
        {
            return miConsultas.ProgEntidad_ObtenerTotalPorProgAnual(prog_anual_id);
        }
		public DataSet MotivoSubtipo_Obtener(int motivo_inspeccion_id)
		{
			return miConsultas.MotivoSubtipo_Obtener(motivo_inspeccion_id);
		}

		public DataSet SubtipoInspeccion_Obtener(int tipo, int comprobacionSanciones = 0)
		{
			return miConsultas.SubtipoInspeccion_Obtener(tipo, comprobacionSanciones);
		}
        
		public DataSet TipoInspeccion_ObtenerPorIdSubtipo(int tipo)
        {
            return miConsultas.TipoInspeccion_ObtenerPorIdSubtipo(tipo);
        }
		
		public int SubmateriaObtenerMax()
		{
			return miConsultas.SubmateriaObtenerMax();
		}

   

		public DataSet Mes_Obtener(int mes_id)
		{
			return miConsultas.Mes_Obtener(mes_id);
		}

		//***************
		public DataSet ProgMes_Obtener(int prog_mes_id, int prog_anual_id, int mes_id)
		{
			return miConsultas.ProgMes_Obtener(prog_mes_id, prog_anual_id, mes_id);
		}

		public DataSet ProgMateria_ObtenerPorProgAnualID(int prog_anual_id)
		{
			return miConsultas.ProgMateria_ObtenerPorProgAnualID(prog_anual_id);
		}

        public DataSet ProgMateriaAtributo_ObtenerPorProgAnualID(int prog_anual_id)
        {
            return miConsultas.ProgMateriaAtributo_ObtenerPorProgAnualID(prog_anual_id);
        }

		public DataSet Inspector_ObtenerPorAnio(int inspector_id, int anio)
		{
			return miConsultas.Inspector_ObtenerPorAnio(inspector_id, anio);
		}

        //**********************
        public DataSet Inspector_ObtenerPorUR(int inspector_id, string insp_num_credencial,int ur,int edo)
		{
            return miConsultas.Inspector_ObtenerPorUR(inspector_id, insp_num_credencial, ur,edo);
		}

		public DataSet Contenido_Usuario_Revision(int usuario_id, int infa_tipo)
		{
			return miConsultas.Contenido_Usuario_Revision(usuario_id, infa_tipo);
		}

		public DataSet OperativoEntidad_Obtener(DtoOperativoEntidad miDtoOE)
		{
			return miConsultas.OperativoEntidad_Obtener(miDtoOE);
		}

        public DataSet OperativoEntidad_ObtenerMetas(DtoOperativoEntidad miDtoOE)
        {
            return miConsultas.OperativoEntidad_ObtenerMetas(miDtoOE);
        }

        public DataSet OperativoEntidad_ObtenerOtro(int operativo_id, int edo, int ur, int prog_anual_id, int mes)
        {
            return miConsultas.OperativoEntidad_ObtenerOtro(operativo_id,edo,ur,prog_anual_id,mes);
        }

        public DataSet OperativoAsignacion_Obtener(DtoOperativoAsignacion miDtoOA)
        {
            return miConsultas.OperativoAsignacion_Obtener(miDtoOA);
        }

		public DataSet ProgAtributo_ObtenerPorID(int prog_atributo_id)
		{
			return miConsultas.ProgAtributo_ObtenerPorID(prog_atributo_id);
		}

        public DataSet Documentos_ConsultarActualizar(DtoGestorDocumentos dtoDoc)
        {
            return miConsultas.Documentos_ConsultarActualizar(dtoDoc);
        }

        public DataSet DoctoParrafoTipo_Obtener(int docto_parrafo_texto_id, int tipo_inspeccion_id)
        {
            return miConsultas.DoctoParrafoTipo_Obtener(docto_parrafo_texto_id, tipo_inspeccion_id);
        }

        public DataSet DoctoParrafoSubtipo_Obtener(int docto_parrafo_texto_id, int subtipo_inspeccion_id)
        {
            return miConsultas.DoctoParrafoSubtipo_Obtener(docto_parrafo_texto_id, subtipo_inspeccion_id);
        }

        public DataSet DoctoParrafoMateria_Obtener(int docto_parrafo_texto_id, int materia_id, int? normatividad_id = 1)
        {
            return miConsultas.DoctoParrafoMateria_Obtener(docto_parrafo_texto_id, materia_id, normatividad_id);
        }

        public DataSet SDoctoParrafoMateria_Obtener(int s_docto_parrafo_texto_id, int materia_id)
        {
            return miConsultas.SDoctoParrafoMateria_Obtener(s_docto_parrafo_texto_id, materia_id);
        }

        public DataSet SDoctoParrafoComparecencia_Obtener(int s_docto_parrafo_texto_id)
        {
            return miConsultas.SDoctoParrafoComparecencia_Obtener(s_docto_parrafo_texto_id);
        }
        
        public DataSet OperativoAlcance_Obtener(int operativo_alcance_id, int operativo_id,int materia_id)
        {
            return miConsultas.OperativoAlcance_Obtener(operativo_alcance_id, operativo_id,materia_id);
        }

        //***********
        public DataSet OperativoAlcance_ObtenerTipoAlcance(int operativo_alcance_id, int operativo_id, int materia_id,int alcance)
        {
            return miConsultas.OperativoAlcance_ObtenerTipoAlcance(operativo_alcance_id, operativo_id, materia_id,alcance);
        }

        //************
        public DataSet OperativoAlcance_ObtenerPorOperativoPorSubmateria(int operativo_alcance_id, int operativo_id, int submateria_id)
        {
            return miConsultas.OperativoAlcance_ObtenerPorOperativoPorSubmateria(operativo_alcance_id, operativo_id, submateria_id);
        }

        public DataSet OperativoIndicador_Obtener(int operativo_alcance_id, int submateria_id, int ind_alcance)
        {
            return miConsultas.OperativoIndicador_Obtener(operativo_alcance_id, submateria_id, ind_alcance);
        }

        public DataSet OperativoIndicadorMenu_Obtener(int operativo_alcance_id)
        {
            return miConsultas.OperativoIndicadorMenu_Obtener(operativo_alcance_id);
        }

        //*************
        public DataSet OperativoIndicador_ObtenerParaInspeccion(int operativo_alcance_id, int submateria_id, int ind_alcance,int operativo)
        {
            return miConsultas.OperativoIndicador_ObtenerParaInspeccion(operativo_alcance_id, submateria_id, ind_alcance,operativo);
        }

        public DataSet ProgAnual_Consultar(int panual_anio, int pent_cve_ur, int prog_anual_id)
        {
            return miConsultas.ProgAnual_Consultar(panual_anio, pent_cve_ur, prog_anual_id);
        }

        public DataSet ProgAnual_Obtener(int prog_anual_id, int panual_anio, int panual_estatus, int pent_cve_ur,int estatus_normativa = -1)
        {
            return miConsultas.ProgAnual_Obtener(prog_anual_id, panual_anio, panual_estatus, pent_cve_ur, estatus_normativa);
        }

        public DataSet DML_Inspecciones_Acotadas(int inspeccion_id, string sentencia, int inspec_alcance_propuesta_id = -1, int submateria_id = -1, string motivo = "")
        {
            return miConsultas.DML_Inspecciones_Acotadas(inspeccion_id, sentencia, inspec_alcance_propuesta_id, submateria_id, motivo);
        }

        public DataSet Inspeccion_Obtener(DtoInspeccion miDtoI)
        {
            return miConsultas.Inspeccion_Obtener(miDtoI);
        }
        public DataSet Inspeccion_Origen_Obtener(int inspeccion_id)
        {
            return miConsultas.Inspeccion_Origen_Obtener(inspeccion_id);
        }
        public DataSet Inspeccion_Obtener2(DtoInspeccion miDtoI)
        {
            return miConsultas.Inspeccion_Obtener2(miDtoI);
        }

        public DataSet Inspeccion_ConsultarEmpresa(DtoBusqueda miDtoB)
        {
            return miConsultas.Inspeccion_ConsultarEmpresa(miDtoB);
        }

        public DataSet Inspeccion_Consulta(int centro_trabajo_id)
        {
            return miConsultas.Inspeccion_Consulta(centro_trabajo_id);
        }

        public DataSet Inspeccion_ConsultarEtapas(int inspeccion_id, int in_etapa)
        {
            return miConsultas.Inspeccion_ConsultarEtapas(inspeccion_id, in_etapa);
        }

		public DataSet Inspeccion_ObtenerFormato(int inspeccion_id)
		{
			return miConsultas.Inspeccion_ObtenerFormato(inspeccion_id);
		}
        public DataSet ObtenerResumenInspeccionOrigenReprogramacion(int inspeccion_id, int inspeccion_origen_id)
		{
			return miConsultas.ObtenerResumenInspeccionOrigenReprogramacion(inspeccion_id, inspeccion_origen_id);
        }

        public DataSet InspecExperto_Obtener(int inspeccion_id)
        {
            return miConsultas.InspecExperto_Obtener(inspeccion_id);
        }

        public DataSet InspecParticipante_Obtener(int inspeccion_id)
        {
            return miConsultas.InspecParticipante_Obtener(inspeccion_id);
        }

        //************
        public DataSet TodosInspectoresPorInspeccion_Obtener(int inspeccion_id)
        {
            return miConsultas.TodosInspectoresPorInspeccion_Obtener(inspeccion_id);
        }

        public DataSet InspecParticipante_Obtener(int inspeccion_id, int participante_id)
        {
            return miConsultas.InspecParticipante_Obtener(inspeccion_id, participante_id);
        }

        public DataSet FundamentoDesignacion_Obtener()
        {
            return miConsultas.FundamentoDesignacion_Obtener();
        }

        public DataSet InspecAdicional_Obtener(int inspeccion_id)
        {
            return miConsultas.InspecAdicional_Obtener(inspeccion_id);
        }

        public DataSet InspecAdicional_Obtener(int inspeccion_id, int inspector_id)
        {
            return miConsultas.InspecAdicional_Obtener(inspeccion_id, inspector_id);
        }

		public DataSet ProgAtributo_ValidarPorProgAnualID(int prog_anual_id)
		{
			return miConsultas.ProgAtributo_ValidarPorProgAnualID(prog_anual_id);
		}

        public DataSet InspeccionCopia_Obtener(int inspeccion_id)
        {
            return miConsultas.InspeccionCopia_Obtener(inspeccion_id);
        }

		public DataSet InspeccionCopia_ObtenerPorInspeccionID(int inspeccion_id)
		{
			return miConsultas.InspeccionCopia_ObtenerPorInspeccionID(inspeccion_id);
		}

        public DataSet Inspeccion_Busqueda(DtoInspeccion miDtoI)
        {
            return miConsultas.Inspeccion_Busqueda(miDtoI);
        }

        public int Inspeccion_Obtener_Ultima_Por_Materia(int centro_trabajo_id, string materia_acronimo)
        {
            return miConsultas.Inspeccion_Obtener_Ultima_Por_Materia(centro_trabajo_id,materia_acronimo);
        }

        public DataSet Programacion_Busqueda(DtoInspeccion miDtoI)
        {
            return miConsultas.Programacion_Busqueda(miDtoI);
        }


        public DataSet Inspector_Obtener(int inspector_id, String insp_num_credencial)
        {
            return miConsultas.Inspector_Obtener(inspector_id, insp_num_credencial);
        }

        public DataSet Inspector_Obtener(int inspector_id, String insp_num_credencial, int cve_ur)
        {
            return miConsultas.Inspector_Obtener(inspector_id, insp_num_credencial, cve_ur);
        }

        public DataSet ProgAnual_Obtener(int prog_anual_id, int panual_anio, int panual_estatus, int estatus_normativa=-1)
        {
            return miConsultas.ProgAnual_Obtener(prog_anual_id, panual_anio, panual_estatus, estatus_normativa);
        }
        
        public DataSet ObtenerCatalogoPorNombre(string nombre_catalogo)
        {
            return miConsultas.ObtenerCatalogoPorNombre(nombre_catalogo);
        }

        public DataSet PA_DML_Factor(string tipo_consulta, int cve_edo_rep, int cur_cve_ur, int anio, int total_inspecciones, string factor, int prog_anual_id)
        {
            return miConsultas.PA_DML_Factor(tipo_consulta, cve_edo_rep, cur_cve_ur, anio, total_inspecciones, factor, prog_anual_id);
        }

        public DataSet PA_ObetenerTotalInspectoresPorEdoRep(int int_anio, int anio_select, int prog_anual_id)
        {
            return miConsultas.PA_ObetenerTotalInspectoresPorEdoRep(int_anio, anio_select, prog_anual_id);
        }

        public DataSet ProgAtributoRama_ObtenerPorIniPer(int prog_atributo_idini, int prog_atributo_idper)
        {
            return miConsultas.ProgAtributoRama_ObtenerPorIniPer(prog_atributo_idini, prog_atributo_idper);
        }

        public DataSet ProgAtributoScian_ObtenerPorIniPer(int prog_atributo_idini, int prog_atributo_idper)
        {
            return miConsultas.ProgAtributoScian_ObtenerPorIniPer(prog_atributo_idini, prog_atributo_idper);
        }

        public DataSet MotivoModificacion_Obtener()
        {
            return miConsultas.MotivoModificacion_Obtener();
        }

		public DataSet Modificacion_ObtenerPorInspeccionID(int inspeccion_id)
		{
			return miConsultas.Modificacion_ObtenerPorInspeccionID(inspeccion_id);
		}

        public DataSet Programacion_Mensual(int mes_id, int in_anio, int cve_ur, int participante_id, String in_fec_inspeccion)
        {
            return miConsultas.Programacion_Mensual(mes_id, in_anio, cve_ur, participante_id, in_fec_inspeccion);
        }

        public DataSet Notificacion_Busqueda(DtoNotificacion miDtoN)
        {
            return miConsultas.Notificacion_Busqueda(miDtoN);
        }

        public DataSet RegistroActividad_Busqueda(DtoBusquedaRegistroActividad miDtoN)
        {
            return miConsultas.RegistroActividad_Busqueda(miDtoN);
        }
        public DataSet DoctoParrafoEtiqueta_Obtener(int docto_parrafo_texto_id)
        {
            return miConsultas.DoctoParrafoEtiqueta_Obtener(docto_parrafo_texto_id);
        }

        public DataSet SDoctoParrafoEtiqueta_Obtener(int s_docto_parrafo_texto_id)
        {
            return miConsultas.SDoctoParrafoEtiqueta_Obtener(s_docto_parrafo_texto_id);
        }
        

        public DataSet Programacion_Mensual_Datos(int mes_id, int in_anio, int cve_ur, int participante_id)
        {
            return miConsultas.Programacion_Mensual_Datos(mes_id, in_anio, cve_ur, participante_id);
        }

        public DataSet Programacion_MensualPorInspector(String fecha_inicio, String fecha_fin, int participante_id)
        {
            return miConsultas.Programacion_MensualPorInspector(fecha_inicio, fecha_fin, participante_id);
        }

        public DataSet Programacion_PorInspector(String fecha_inicio, String fecha_fin, int ordenar, int participante_id)
        {
            return miConsultas.Programacion_PorInspector(fecha_inicio, fecha_fin, ordenar, participante_id);
        }

        public DataSet Programacion_PorInspectorparaDesahogo(String fecha_programada, String razon_social, String No_inspeccion, int participante_id)
        {
            return miConsultas.Programacion_PorInspectorparaDesahogo(fecha_programada,razon_social,No_inspeccion,participante_id);
        }

        public DataSet IndTemaFrecuente_Consultar(int ind_tema_frecuente_id, int indtfrec_consecutivo, int estatus)
        {
            return miConsultas.IndTemaFrecuente_Consultar(ind_tema_frecuente_id, indtfrec_consecutivo, estatus);
        }

        public DataSet IndTemaFrecuente_Consultar(int ind_tema_frecuente_id, int indtfrec_consecutivo)
        {
            return miConsultas.IndTemaFrecuente_Consultar(ind_tema_frecuente_id, indtfrec_consecutivo);
        }

        //***temas noms
        public DataSet IndicadorTemaNom_Consultar(int ind_tema_nom_id, int consecutivo, int padre,int submat,int tipo,int estatus)
        {
            return miConsultas.IndicadorTemaNom_Consultar(ind_tema_nom_id,consecutivo,padre,submat,tipo,estatus);
        }

        public DataSet IndMedidaPlazo_Consultar(int ind_medida_plazo_id, int imp_consecutivo, int normatividad_id, int version_id = -1, int inspeccion_id = -1)
        {
            return miConsultas.IndMedidaPlazo_Consultar(ind_medida_plazo_id, imp_consecutivo, normatividad_id,version_id,inspeccion_id);
        }
        
        public DataSet TableroMedidasPlazoDML(int normatividad_id, string sentencia = "SELECT", int ind_medida_plazo_id = -1, int imp_consecutivo = -1, string sys_usr = "", int nvimp_id = -1, string version_descripcion = "", string fecha_de_publicacion = "", int last_normatividad_id = -1)
        {
            return miConsultas.TableroMedidasPlazoDML(normatividad_id,sentencia, ind_medida_plazo_id, imp_consecutivo, sys_usr, nvimp_id, version_descripcion, fecha_de_publicacion, last_normatividad_id);
        }

        public DataSet Inspector_Delegaciones_Obtener()
        {
            return miConsultas.Inspector_Delegaciones_Obtener();
        }

		public DataSet Inspeccion_VerificarAleatoria(int anio, int mes, int cve_ur)
		{
			return miConsultas.Inspeccion_VerificarAleatoria(anio, mes, cve_ur);
		}

        public DataSet Emplazamiento_Obtener(int inspeccion_comprobacion_id, int inspeccion_origen_id)
        {
            return miConsultas.Emplazamiento_Obtener(inspeccion_comprobacion_id, inspeccion_origen_id);
        }
        public DataSet Sancion_Obtener(int inspeccion_sancion_id, int inspeccion_origen_id)
        {
            return miConsultas.Sancion_Obtener(inspeccion_sancion_id, inspeccion_origen_id);
        }

        public DataSet Sancion_Violacion_Obtener(int inspeccion_origen_id)
        {
            return miConsultas.Sancion_Violacion_Obtener(inspeccion_origen_id);
        }
       
        public DataSet Emplazamiento_Obtener_TMP_Fecha_Limite()
        {
            return miConsultas.Emplazamiento_Obtener_TMP_Fecha_Limite();
        }

        public DataSet Emplazamiento_ObtenerPorDesahogo(int desahogo_id)
        {
            return miConsultas.Emplazamiento_ObtenerPorDesahogo(desahogo_id);
        }
		#endregion

		#region Catalogos Institucionales

		public DataSet UnidadResp_ObtenerConAleatoria(int ur, int edo, int mes, int anio)
		{
			return miConsultas.UnidadResp_ObtenerConAleatoria(ur, edo, mes, anio);
		}

        public DataSet UnidadResp_Obtener(int ur, int edo)
        {
            return miConsultas.ObtenerUnidadResp(ur, edo);
        }

        public DataSet AreaSolicitud_Obtener(int ur)
        {
            return miConsultas.AreaSolicitud_Obtener(ur);
        }

        public DataSet Entidades_ObtenerPorUnidadResponsable(int cur_cve_ur)
        {
            return miConsultas.Entidades_ObtenerPorUnidadResponsable(cur_cve_ur);
        }


        public DataSet Entidades_ObtenerPorUnidadResponsable_Buesquedaempresa(int cur_cve_ur, int cen_cve_edorep=-1, string catalogo="Entidades")
        {
            return miConsultas.Entidades_ObtenerPorUnidadResponsable_Buesquedaempresa(cur_cve_ur, cen_cve_edorep,catalogo);
        }
        

        public DataSet Entidades_ObtenerPorUnidadResponsable(int cur_cve_ur, int cen_cve_edorep)
        {
            return miConsultas.Entidades_ObtenerPorUnidadResponsable(cur_cve_ur, cen_cve_edorep);
        }
        public DataSet UnidadResp_ObtenerURPorEstado(int edo_id)
        {
            return miConsultas.UnidadResp_ObtenerURPorEstado(edo_id);
        }
        public DataSet UnidadResp_ObtenerURPorEstado2(int edo_id)
        {
            return miConsultas.UnidadResp_ObtenerURPorEstado2(edo_id);
        }
        public DataSet RamaIndustrial_ObtenerPorID(int ramaid)
		{
			return miConsultas.RamaIndustrial_ObtenerPorID(ramaid);
		}

		public DataSet IMSSActividad_ObtenerPorID(int imss_actividad_id)
		{
			return miConsultas.IMSSActividad_ObtenerPorID(imss_actividad_id);
		}

		public DataSet ObtenerCatSCIAN(int cae_id)
		{
			return miConsultas.ObtenerCatSCIAN(cae_id);
		}

        public DataSet ObtenerMunicipios(int edo, int mun)
        {
            return miConsultas.ObtenerMunicipios(edo, mun);
        }

        //*********
        public DataSet ObtenerCatSCIANBusqueda(string cae_clase, string texto)
        {
            return miConsultas.ObtenerCatSCIANBusqueda(cae_clase, texto);
        }

        #endregion

        public DataSet SObtener_Supervisor_por_CVUR(int inspeccion_id)
        {
            return miAgregar.SObtener_Supervisor_por_CVUR(inspeccion_id);
        }

        #region Contenidos
        public DataSet ObtenerContenido(int infa_tipo)
        {
            return miConsultas.ObtenerContenido(infa_tipo);
        }

        public List<DtoInfoApoyo> ObtenerTodosInfoApoyo()
        {
            return miConsultas.obtener_todos_info_apoyo();
        }

        public void AgregarContenido(DtoInfoApoyo dtoinfoapoyo)
        {
            miAgregar.AgregarContenido(dtoinfoapoyo);
        }

        public DataSet ObtenerContenidoPorId(int apoyo_id)
        {
            return miConsultas.ObtenerContenidoPorId(apoyo_id);
        }

        public DataSet ObtenerContenidoPorOrden(int infa_orden, int infa_tipo)
        {
            return miConsultas.ObtenerContenidoPorOrden(infa_orden, infa_tipo);
        }


        public DataSet SubmateriaObtenerPorIdMateria(DtoSubmateria miDtoS)
        {
            return miConsultas.SubmateriaObtenerPorIdMateria(miDtoS);
        }

        //*****
        public DataSet Submateria_Obtener(DtoSubmateria miDtoS, int normatividad_id = -1)
        {
            return miConsultas.Submateria_Obtener(miDtoS, normatividad_id);
        }

        //****************
        public DataSet InspeccionAlcance_ObtenerAlcanceGeneral(int inspec_alcance_id, int submateria, int inspeccion_id)
        {
            return miConsultas.InspeccionAlcance_ObtenerAlcanceGeneral(inspec_alcance_id,submateria,inspeccion_id);
        }

        public DataSet IndicadoresObtenerPorIdSubMateria(DtoIndicadores miDtoS)
        {
            return miConsultas.IndicadoresObtenerPorIdSubMateria(miDtoS);
        }

        public DataSet Indicadores_Obtener(DtoIndicadores miDtoS)
        {
            return miConsultas.Indicadores_Obtener(miDtoS);
        }
        //*********
        public DataSet Indicadores_ObtenerporAlcance(DtoIndicadores miDtoS)
        {
            return miConsultas.Indicadores_ObtenerporAlcance(miDtoS);
        }

        public DataSet InfoAdicional_Obtener(DtoInfoAdicional miDtoS)
        {
            return miConsultas.InfoAdicional_Obtener(miDtoS);
        }
       
        public DataSet SubmateriaObtenerPorIdMateriaPorAlcance(DtoSubmateria miDtoS)
        {
            return miConsultas.SubmateriaObtenerPorIdMateriaPorAlcance(miDtoS);
        }


        //****
        public DataSet SubmateriaNomsObtenerPorIdMateriaPorAlcance(DtoSubmateria miDtoS)
        {
            return miConsultas.SubmateriaNomsObtenerPorIdMateriaPorAlcance(miDtoS);
        }
        #endregion

        #region Programación
        public DataSet ProgAtributo2_ObtenerPorID(int Atributo_id)
        {
            return miConsultas.ProgAtributo2_ObtenerPorID(Atributo_id);
        }
        public DataSet ProgAtributo2SCIAN_ObtenerPorID(int Atributo_id)
        {
            return miConsultas.ProgAtributo2SCIAN_ObtenerPorID(Atributo_id);
        }

		#region Automatica
		public DataSet ProgramacionAutomatica_ObtenerTablero(int cve_ur, int comprobacionSanciones = 0)
		{
			return miConsultas.ProgramacionAutomatica_ObtenerTablero(cve_ur, comprobacionSanciones);
		}

		public DataSet Emplazamiento_ObtenerTablero(int cve_ur, int dias_plazo)
		{
			return miConsultas.Emplazamiento_ObtenerTablero(cve_ur, dias_plazo);
		}

        public DataSet Sancion_ObtenerTablero(int cve_ur, int dias_plazo)
        {
            return miConsultas.Sancion_ObtenerTablero(cve_ur, dias_plazo);
        }

        public DataSet Emplazamiento_ObtenerPorID(int EmplazamientoID, int dias_plazo)
		{
			return miConsultas.Emplazamiento_ObtenerPorID(EmplazamientoID, dias_plazo);
		}

        public DataSet Sancion_ObtenerPorID(int sancionID, int dias_plazo)
        {
            return miConsultas.Sancion_ObtenerPorID(sancionID, dias_plazo);
        }

        public DataSet EmplazamientoNumeral_ObtenerTablero(int emplazamiento_id)
		{
			return miConsultas.EmplazamientoNumeral_ObtenerTablero(emplazamiento_id);
		}

		public DataSet Emplazamiento_ObtenerMedidasRecorrido(int emplazamiento_id)
		{
			return miConsultas.Emplazamiento_ObtenerMedidasRecorrido(emplazamiento_id);
		}

		public DataSet Reprogramacion_ObtenerTablero(int cve_ur, int dias_plazo)
		{
		return miConsultas.Reprogramacion_ObtenerTablero(cve_ur, dias_plazo);
		}

		public DataSet Reprogramacion_ObtenerPorID(int reprogramacion_id, int dias_plazo)
		{
			return miConsultas.Reprogramacion_ObtenerPorID(reprogramacion_id, dias_plazo);
		}
        public void Reprogramacion_Subtipo_Actualizar(int reprogramacion_id)
		{
			miConsultas.Reprogramacion_Subtipo_Actualizar(reprogramacion_id);
		}

		#endregion

        #endregion

        #region DFT
        //Consulta
        public DataSet Municipios_ObtenerMunicipiosPorEstadoId(int entidad_id)
        {
            return miConsultas.Municipios_ObtenerMunicipiosPorEstadoId(entidad_id);
        }

        public DataSet Municipios_ObtenerMunicipio(short entidad_id, short municipio_id)
        {
            return miConsultas.Municipios_ObtenerMunicipio(entidad_id, municipio_id);
        }

        //******
        public DataSet Municipios_ObtenerOtro(int entidad_id, int municipio_id)
        {
            return miConsultas.Municipios_ObtenerOtro(entidad_id, municipio_id);
        }

        public DataSet MotivosNoEntrega_Obtener(int motivo_id)
        {
            return miConsultas.MotivosNoEntrega_Obtener(motivo_id);
        }

        public DataSet SeguridadSocialObtener()
        {
            return miConsultas.SeguridadSocialObtener();
        }

        public DataSet Entidades_ObtenerTodasEntidades()
        {
            return miConsultas.Entidades_ObtenerTodasEntidades();
        }

        public DataSet Entidades_ObtenerPorId(short entidad_id)
        {
            return miConsultas.Entidades_ObtenerPorId(entidad_id);
        }

        public DataSet Empresa_Buscar(DtoBusqueda dtoBuscar)
        {
            return miConsultas.Empresa_Buscar(dtoBuscar);
        }

        public DataSet Empresa_Buscar2(DtoDFT dtoDFT)
        {
            return miConsultas.Empresa_Buscar2(dtoDFT);
        }

        public DataSet Centro_Buscar2(DtoDFT dtoDFT)
        {
            return miConsultas.Centro_Buscar2(dtoDFT);
        }

        public DataSet Centro_Buscar3(DtoBusqueda dtoBusqueda)
        {
            return miConsultas.Centro_Buscar3(dtoBusqueda);
        }

        public DataSet InspecParticipante_ObtenerPorTipo(int es_inspector, int es_notif, int es_firma, int cve_ur, string usr_estatus = null)
        {
            return miConsultas.InspecParticipante_ObtenerPorTipo(es_inspector, es_notif, es_firma, cve_ur, usr_estatus);
        }

        public DataSet DFTObtenerDocumento()
        {
            return miConsultas.DFTObtenerDocumento();
        }

        public DataSet Notificacion_ObtenerPorEtapa(int inspeccion_id, int etapa)
        {
            return miConsultas.Notificacion_ObtenerPorEtapa(inspeccion_id, etapa);
        }

        public DataSet Notificacion_Obtener(int notificacion_id, int inspeccion_id)
        {
            return miConsultas.Notificacion_Obtener(notificacion_id,inspeccion_id);
        }

        public DataSet FormaConstatacion_Obtener()
        {
            return miConsultas.FormaConstatacion_Obtener();
        }

        //**************
        public DataSet SubmateriaAlcanceIndicador_Obtener(int inspeccion_id, int submateria_id, int indicador_id,int incluye_docto)
        {
            return miConsultas.SubmateriaAlcanceIndicador_Obtener(inspeccion_id, submateria_id, indicador_id, incluye_docto);
        }
        //-------
        public DataSet SubmateriaIndicador_ObtenerParaDocto(int inspeccion_id, int submateria_id)
        {
            return miConsultas.SubmateriaIndicador_ObtenerParaDocto(inspeccion_id, submateria_id);
        }
        //*************
        public DataSet SubmateriaIndicador_ObtenerParaDoctoConOperativo(int inspeccion_id, int submateria_id,int operativo)
        {
            return miConsultas.SubmateriaIndicador_ObtenerParaDoctoConOperativo(inspeccion_id, submateria_id,operativo);
        }
        //********
        public DataSet MedidaAlcanceIndicador_Obtener(int inspeccion_id, int submateria_id, int indicador_id,int medida_id)
        {
            return miConsultas.MedidaAlcanceIndicador_Obtener(inspeccion_id, submateria_id, indicador_id, medida_id);
        }

        public DataSet NotifOtraActuacion_Obtener(int notif_id,int ur1, int ur, int mun,int edo, int forma, int estatus,int estatusentrega, string fechaini, string fechafin, int inspector, string no_solicitud, string razon_social)
        {
            return miConsultas.NotifOtraActuacion_Obtener(notif_id,ur1, ur,mun,edo,forma, estatus,estatusentrega,fechaini,fechafin,inspector, no_solicitud, razon_social);
        }
        #endregion

        #region DNE

        public DataSet Empresa_UltimasInspecciones_Obtener(DtoDFT dtoDFT)
        {
            return miConsultas.Empresa_UltimasInspecciones_Obtener(dtoDFT);
        }

        public DataSet Rama_Industriales()
        {
            return miConsultas.Rama_Industriales();
        }
        public DataSet Programacion_Empresa_Buscar(string emp_nombre, string emp_rfc, int cve_edorep, int cve_municipio, int estatus, string ramaindustrial)
        {
            return miConsultas.Programacion_Empresa_Buscar(emp_nombre, emp_rfc, cve_edorep, cve_municipio, estatus,ramaindustrial);
        }
        public DataSet CentroTrabajo_PorEmpresaId_Buscar(int empresa_id, int cve_edorep, string domicilio)
        {
            return miConsultas.CentroTrabajo_PorEmmpresaId_Buscar(empresa_id, cve_edorep, domicilio);
        }
        public DataSet CentroTrabajo_Buscar(string emp_nombre, string emp_rfc, int cve_edorep, int estatus)
        {
            return miConsultas.CentroTrabajo_Buscar(emp_nombre, emp_rfc, cve_edorep, estatus);
        }

		public DataSet CentroTrabajo_ObtenerDatosPorID(int centro_trabajo_id)
		{
			return miConsultas.CentroTrabajo_ObtenerDatosPorID(centro_trabajo_id);
		}

		public DataSet EmpresaSolidaria_ObtenerPorCentroID(int centro_trabajo_id)
		{
			return miConsultas.EmpresaSolidaria_ObtenerPorCentroID(centro_trabajo_id);
		}

		public DataSet CentroTrabajo_ConsultarPorId(int centro_trabajo_id)
		{
			return miConsultas.CentroTrabajo_ConsultarPorId(centro_trabajo_id);
		}

        public DataSet TablaProcesoAC_Obtener(int dshgo_id, int inspeccion_id)
        {
            return miConsultas.TablaProcesoAC_Obtener( dshgo_id, inspeccion_id);
        }

		public DataSet Empresa_ConsultarPorId(int empresa_id)
		{
			return miConsultas.Empresa_ConsultarPorId(empresa_id);
		}

        public DataSet Camara_ObtenerPorDescripcion(string cam_camara)
        {
            return miConsultas.Camara_ObtenerPorDescripcion(cam_camara);
        }

        public DataSet CentroCamara_ObtenerPorCentroID(int centro_trabajo_id)
        {
            return miConsultas.CentroCamara_ObtenerPorCentroID(centro_trabajo_id);
        }

        public DataSet CentroSindicato_ObtenerPorCentroID(int centro_trabajo_id)
        {
            return miConsultas.CentroSindicato_ObtenerPorCentroID(centro_trabajo_id);
        }


        public DataSet Sindicato_ObtenerPorDescripcion(string sind_sindicato)
        {
            return miConsultas.Sindicato_ObtenerPorDescripcion(sind_sindicato);
        }

        #endregion

        #region Desahogo
        public bool Dshgo_Participantes_ConsultarEstado(int inspeccion_id, int desahogo_id, int tipo_documento, int materia_id)
        {
            return miConsultas.Dshgo_Participantes_ConsultarEstado(inspeccion_id, desahogo_id, tipo_documento,  materia_id);
        }

        public DataSet TipoRep_ConsultarporID(int TipoRep_ID, int dsecc_en_oficio, int trep_de_empresa)
        {
            return miConsultas.TipoRep_ConsultarporID(TipoRep_ID, dsecc_en_oficio, trep_de_empresa);
        }

        public DataSet TipoID_ConsultarporID(int TipoID_ID)
        {
            return miConsultas.TipoID_ConsultarporID(TipoID_ID);
        }

        public DataSet DshgoMotivoInforme_Obtener(int desahogo_id, int motivo_informe_id)
        {
            return miConsultas.DshgoMotivoInforme_Obtener(desahogo_id, motivo_informe_id);
        }

        public DataSet Desahogo_Obtener(DtoDesahogo dtoD)
        {
            return miConsultas.Desahogo_Obtener(dtoD);
        }

        public DataSet ObtenerFechasExpediente(int inspeccion_id)
        {
            return miConsultas.ObtenerFechasExpediente(inspeccion_id);
        }

        public DataSet Calificacion_Expediente_Obtener(int inspeccion_id, int calificacion_id)
        {
            return miConsultas.Calificacion_Expediente_Obtener(inspeccion_id, calificacion_id);
        }

        //*****DshgoCentroTrabajo
        public DataSet DshgoCentroTrabajo_Obtener(DtoDshgoCentroTrabajo dtoD)
        {
            return miConsultas.DshgoCentroTrabajo_Obtener(dtoD);
        }
        //***DshgoDomicilioFiscal
        public DataSet DshgoDomicilioFiscal_Obtener(DtoDshgoDomicilioFiscal dtoD)
        {
            return miConsultas.DshgoDomicilioFiscal_Obtener(dtoD);
        }

        //***desahogoinstalacion
        public DataSet DesahogoInstalacion_Obtener(int dshgo_instalacion_id, int desahogo_id, int tipo_instalacion_id)
        {
            return miConsultas.DesahogoInstalacion_Obtener(dshgo_instalacion_id, desahogo_id, tipo_instalacion_id);
        }
      
        //****dshgo camara
        public DataSet DshgoCentroCamara_Obtener(DtoDshgoCentroCamara camara)
        {
            return miConsultas.DshgoCentroCamara_Obtener(camara);
        }

        //****obtener tipo de establecimiento
        public DataSet TipoEstablecimiento_Obtener(int id)
        {
            return miConsultas.TipoEstablecimiento_Obtener(id);
        }

        //Dshgo_Testigos_Consultar
        public DataSet Dshgo_Testigos_Consultar(int desahogo_id)
        {
            return miConsultas.Dshgo_Testigos_Consultar(desahogo_id);
        }

        public DataSet TipoInstalacion_Obtener(int id)
        {
            return miConsultas.TipoInstalacion_Obtener(id);
        }

        public DataSet MotivoInforme_Obtener()
        {
            return miConsultas.MotivoInforme_Obtener();
        }

        public DataSet DshgoExperto_Obtener(int inspeccion_id, int desahogo_id)
        {
            return miConsultas.DshgoExperto_Obtener(inspeccion_id, desahogo_id);
        }

        public DataSet TablaExperto_Obtener(int inspeccion_id, int desahogo_id)
        {
            return miConsultas.TablaExperto_Obtener(inspeccion_id, desahogo_id);
        }

        //sacar inpectores que participan en el desahogo
        public DataSet DshgoParticipanteInspectores_Obtener(int dshgo_participante_id, int desahogo_id)
        {
            return miConsultas.DshgoParticipanteInspectores_Obtener(dshgo_participante_id, desahogo_id);
        }

        public DataSet Dshgo_Inspectores_Obtener(int inspeccion_id, int desahogo_id)
        {
            return miConsultas.Dshgo_Inspectores_Obtener(inspeccion_id, desahogo_id);
        }

        public DataSet Dshgo_Sindicato_Obtener(int dshgo_sindicato_id, int desahogo_id)
        {
            return miConsultas.Dshgo_Sindicato_Obtener(dshgo_sindicato_id, desahogo_id);
        }

        public DataSet Dshgo_Area_Obtener(int dsgo_area_id, int desahogo_id)
        {
            return miConsultas.Dshgo_Area_Obtener(dsgo_area_id, desahogo_id);
        }

        public DataSet DshgoAlcance_Obtener(int inspeccion_id, int desahogo_id)
        {
            return miConsultas.DshgoAlcance_Obtener(inspeccion_id, desahogo_id);
        }

        public DataSet DshgoParticipantes_ObtenerPorTipo(int desahogo_id, int dpart_tipo_participante)
        {
            return miConsultas.DshgoParticipantes_ObtenerPorTipo(desahogo_id, dpart_tipo_participante);
        }

        //****
        public DataSet PA_DshgoParticipante_Obtener_porTipo2(int desahogo_id, int dpart_tipo_participante)
        {
            return miConsultas.DshgoParticipante_Obtener_porTipo2(desahogo_id, dpart_tipo_participante);
        }

        public DataSet DshgoParticipantes_Obtener(int dshgo_participante_id, int desahogo_id)
        {
            return miConsultas.DshgoParticipantes_Obtener(dshgo_participante_id, desahogo_id);
        }

        public DataSet DshgoParticipante_ObtenerParaCierre(int desahogo_id)
        {
            return miConsultas.DshgoParticipante_ObtenerParaCierre(desahogo_id);
        }

		public DataSet DshgoTrabajadores_ObtenerTablero(int desahogo_id)
		{
			return miConsultas.DshgoTrabajadores_ObtenerTablero(desahogo_id);
		}

        public DataSet DshgoTrabajadores_ObtenerTablero2(int desahogo_id)
        {
            return miConsultas.DshgoTrabajadores_ObtenerTablero2(desahogo_id);
        }

		public DataSet DshgoTrabajadoresDetalle_ObtenerPorID(int dshgo_trabajador_det_id)
		{
			return miConsultas.DshgoTrabajadoresDetalle_ObtenerPorID(dshgo_trabajador_det_id);
		}

		public DataSet DshgoTrabajadoresDetalle_ObtenerPorTrabajadorID(int dshgo_trabajador_id)
		{
			return miConsultas.DshgoTrabajadoresDetalle_ObtenerPorTrabajadorID(dshgo_trabajador_id);
		}

        public DataSet Dshgo_Trabajador_Detalle_Tabla(int desahogo_id)
        {
            return miConsultas.Dshgo_Trabajador_Detalle_Tabla(desahogo_id);
        }

        public DataSet DshgoCaptura_ObtenerSinTerminar(int desahogo_id, int dsecc_en_oficio, int dsecc_en_acta, int dsecc_en_negativa, int materia_id, int subtipo_inspeccion_id)
        {
            return miConsultas.DshgoCaptura_ObtenerSinTerminar(desahogo_id, dsecc_en_oficio, dsecc_en_acta, dsecc_en_negativa, materia_id, subtipo_inspeccion_id);
        }

        public DataSet DshgoInterrogatorio_Obtener(int dshgo_interrogatorio_id, int dshgo_pregunta_id, int dshgo_interrogado_id)
        {
            return miConsultas.DshgoInterrogatorio_Obtener(dshgo_interrogatorio_id, dshgo_pregunta_id, dshgo_interrogado_id);
        }

        public DataSet DshgoInterrogatorioAbierta_Obtener(int dshgo_interrogatorio_abierta_id, int dshgo_interrogado_id)
        {
            return miConsultas.DshgoInterrogatorioAbierta_Obtener(dshgo_interrogatorio_abierta_id, dshgo_interrogado_id);
        }

		public DataSet DshgoSolidaria_ObtenerPorDshgoCentroTrabajoID(int dshgo_centro_trabajo_id)
		{
			return miConsultas.DshgoSolidaria_ObtenerPorDshgoCentroTrabajoID(dshgo_centro_trabajo_id);
		}

		public DataSet DshgoSolidaria_ValidarNumTrabajadores(int dshgo_centro_trabajo_id)
		{
			return miConsultas.DshgoSolidaria_ValidarNumTrabajadores(dshgo_centro_trabajo_id);
        }

        public DataSet IndMedida_ObtenerSubmateria(int imed_tipo_incumplimiento, int desahogo_id)
        {
            return miConsultas.IndMedida_ObtenerSubmateria(imed_tipo_incumplimiento, desahogo_id);
        }

        public DataSet IndMedida_ObtenerSubmateria2(int imed_tipo_incumplimiento, int desahogo_id, int dsgo_area_id, int cumplimiento_espontaneo=-1)
        {
            return miConsultas.IndMedida_ObtenerSubmateria2(imed_tipo_incumplimiento, desahogo_id, dsgo_area_id, cumplimiento_espontaneo);
        }

        public DataSet Dshgo_Revision_ObtenerMedidasAdmin2(int desahogo_id, int indicador_id, int? solo_indicadores)
        {
            return miConsultas.Dshgo_Revision_ObtenerMedidasAdmin2(desahogo_id, indicador_id, solo_indicadores);
        }

        public DataSet DshgoVariables_Obtener(int dshgo_documento_id)
        {
            return miConsultas.DshgoVariables_Obtener(dshgo_documento_id);
        }

		public DataSet DshgoSolidaria_ObtenerPorID(int dshgo_solidaria_dne_id)
		{
			return miConsultas.DshgoSolidaria_ObtenerPorID(dshgo_solidaria_dne_id);
		}


        public DataSet Dshgo_MedidaAdm_Obtener(int desahogo_id)
        {
            return miConsultas.Dshgo_MedidaAdm_Obtener(desahogo_id);
        }

        public DataSet TablaRepresentanteEmpresa_Obtener(int desahogo)
        {
            return miConsultas.TablaRepresentanteEmpresa_Obtener(desahogo);
        }

        public DataSet TablaSindicato_Obtener(int desahogo)
        {
            return miConsultas.TablaSindicato_Obtener(desahogo);
        }

        public DataSet TablaSolidario_Obtener(int desahogo)
        {
            return miConsultas.TablaSolidario_Obtener(desahogo);
        }

        public DataSet TablaProceso_Obtener(int desahogo)
        {
            return miConsultas.TablaProceso_Obtener(desahogo);
        }

        public DataSet TablaInstalacion_Obtener(int desahogo)
        {
            return miConsultas.TablaInstalacion_Obtener(desahogo);
        }
        public DataSet TablaCamara_Obtener(int desahogo)
        {
            return miConsultas.TablaCamara_Obtener(desahogo);
        }

        public DataSet TablaDomicilioNoCoincide_Obtener(int desahogo)
        {
            return miConsultas.TablaDomicilioNoCoincide_Obtener(desahogo);
        }

        public DataSet TablaIdentificación_Obtener(int desahogo)
        {
            return miConsultas.TablaIdentificación_Obtener(desahogo);
        }
        public DataSet TablaTestigos_Obtener(int desahogo, int testigo)
        {
            return miConsultas.TablaTestigos_Obtener(desahogo, testigo);
        }
        public DataSet TablaComsion_Obtener(int desahogo, int dcom_parte_representa)
        {
            return miConsultas.TablaComision_Obtener(desahogo, dcom_parte_representa);
        }
        public DataSet TablaRepresentanteTrabajadores_Obtener(int desahogo)
        {
            return miConsultas.TablaRepresentanteTrabajadores_Obtener(desahogo);
        }

        public DataSet TablaIdentificaciónRepresentanteTrabajadores_Obtener(int desahogo)
        {
            return miConsultas.TablaIdentificaciónRepresentanteTrabajadores_Obtener(desahogo);
        }


        public DataSet DshgoDoctoVariableValores_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            return miConsultas.DshgoDoctoVariableValores_Obtener(dtoDocto);
        }

        public DataSet DshgoDoctoParrafoTexto_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            return miConsultas.DshgoDoctoParrafoTexto_Obtener(dtoDocto);
        }

		public DataSet DshgoAlcance_ObtenerTablero(int desahogo_id)
		{
			return miConsultas.DshgoAlcance_ObtenerTablero(desahogo_id);
		}

		public DataSet DshgoAlcance_ObtenerNoTerminadas(int desahogo_id)
		{
			return miConsultas.DshgoAlcance_ObtenerNoTerminadas(desahogo_id);
		}

        public DataSet Desahogo_ConsultarFormato(int desahogo_id)
        {
            return miConsultas.Desahogo_ConsultarFormato(desahogo_id);
        }

        public DataSet DshgoTrabajador_ConsultarFormato(int desahogo_id)
        {
            return miConsultas.DshgoTrabajador_ConsultarFormato(desahogo_id);
        }

        public DataSet DshgoMedDescatalogadaArea_Obtener(int dshgo_med_descatalogada_id)
        {
            return miConsultas.DshgoMedDescatalogadaArea_Obtener(dshgo_med_descatalogada_id);
		}

		public DataSet Dshgo_Revision_ObtenerPorID(int dshgo_revision_id)
		{
			return miConsultas.Dshgo_Revision_ObtenerPorID(dshgo_revision_id);
		}

		public DataSet Dshgo_Revision_ObtenerIndicadores(int dshgo_alcance_id)
		{
			return miConsultas.Dshgo_Revision_ObtenerIndicadores(dshgo_alcance_id);
		}
        public DataSet Dshgo_Revision_ObtenerIndicadoresComprobacionSanciones(int dshgo_alcance_id, int inspeccion_origen_id)
        {
            return miConsultas.Dshgo_Revision_ObtenerIndicadoresComprobacionSanciones(dshgo_alcance_id, inspeccion_origen_id);
        }

        public DataSet Dshgo_Revision_ObtenerIndicadores(int dshgo_alcance_id, int indicador_id)
		{
			return miConsultas.Dshgo_Revision_ObtenerIndicadores(dshgo_alcance_id, indicador_id);
		}

        public int Dshgo_Revision_Medidas_por_InfoID(int ind_info_adicional_id)
        {
            return miConsultas.Dshgo_Revision_Medidas_por_InfoID(ind_info_adicional_id);
        }


		public DataSet Dshgo_Revision_ObtenerIncisos(int dshgo_alcance_id, int indicador_id)
		{
			return miConsultas.Dshgo_Revision_ObtenerIncisos(dshgo_alcance_id, indicador_id);
		}
       
        public DataSet Dshgo_Revision_ObtenerIncisoaComprobacionSanciones(int dshgo_alcance_id, int indicador_id, int inspeccion_origen_id)
        {
            return miConsultas.Dshgo_Revision_ObtenerIncisoaComprobacionSanciones(dshgo_alcance_id, indicador_id, inspeccion_origen_id);
        }
        public DataSet Agregar_Alcance_Desahogo_Negativa(int inspeccion_id, int desahogo_id, string sys_usr, string sentencia = "INDICADORES", int indicador_id = -1)
		{
			return miConsultas.Agregar_Alcance_Desahogo_Negativa(inspeccion_id, desahogo_id, sys_usr, sentencia, indicador_id);
		}

        public DataSet Actualizar_Alcance_Desahogo_Negativa_CM(int desahogo_id, string sys_usr)
        {
            return miConsultas.Actualizar_Alcance_Desahogo_Negativa_CM(desahogo_id, sys_usr);
        }

        public DataSet Agregar_Alcance_Desahogo_Negativa_ComprobacionSanciones(int inspeccion_id, int desahogo_id, string sys_usr, string sentencia = "INDICADORES", int indicador_id = -1, int inspeccion_origen_id=-1)
        {
            return miConsultas.Agregar_Alcance_Desahogo_Negativa_ComprobacionSanciones(inspeccion_id, desahogo_id, sys_usr, sentencia, indicador_id, inspeccion_origen_id);
        }

        

        public DataSet Dshgo_Revision_ObtenerIncisosPorIndicadorDependiente(int dshgo_alcance_id, int indicador_id, int indicador_depende_id, string ind_respuesta_depende)
		{
			return miConsultas.Dshgo_Revision_ObtenerIncisosPorIndicadorDependiente(dshgo_alcance_id, indicador_id, indicador_depende_id, ind_respuesta_depende);
		}

		public DataSet Dshgo_Revision_ObtenerIndicadoresPorDesahogoID(int desahogo_id)
		{
			return miConsultas.Dshgo_Revision_ObtenerIndicadoresPorDesahogoID(desahogo_id);
		}

		public DataSet Dshgo_Revision_ObtenerIncisosPorDesahogoIndicadorID(int desahogo_id, int indicador_id)
		{
			return miConsultas.Dshgo_Revision_ObtenerIncisosPorDesahogoIndicadorID(desahogo_id, indicador_id);
		}

        public DataSet Dshgo_Revision_ObtenerMedidasAdmin(int desahogo_id, int indicador_id, int? solo_indicadores)
        {
            return miConsultas.Dshgo_Revision_ObtenerMedidasAdmin(desahogo_id, indicador_id, solo_indicadores);
        }
        public DataSet Dshgo_Revision_ObtenerMedidasAdmin3(int inspeccion_id, int inspeccion_origen_id, int indicador_id, int? solo_indicadores)
        {
            return miConsultas.Dshgo_Revision_ObtenerMedidasAdmin3(inspeccion_id,inspeccion_origen_id, indicador_id, solo_indicadores);
        }

        public DataSet Emplazamiento_Medidas_Limpiar(int desahogo_id, int inspeccion_origen_id)
        {
            return miConsultas.Emplazamiento_Medidas_Limpiar(desahogo_id, inspeccion_origen_id);
        }
        public DataSet Dshgo_Medidas_Emplazamiento_Obtener(int desahogo_id, int inspeccion_origen_id)
        {
            return miConsultas.Dshgo_Medidas_Emplazamiento_Obtener(desahogo_id, inspeccion_origen_id);
        }

        public DataSet Dshgo_Revision_Borras_Incisos_Dependientes(int dshgo_alcance_id, int indicador_id)
        {
            return miConsultas.Dshgo_Revision_Borras_Incisos_Dependientes(dshgo_alcance_id, indicador_id);
        }

        public DataSet Dshgo_Revision_ObtenerIndicadoresDependientes(int dshgo_alcance_id, int indicador_depende_id, string ind_respuesta_depende)
		{
			return miConsultas.Dshgo_Revision_ObtenerIndicadoresDependientes(dshgo_alcance_id, indicador_depende_id, ind_respuesta_depende);
		}

		public DataSet Dshgo_Revision_ObtenerIndicadorPorIncumplimientoDesahogoID(int desahogo_id)
		{
			return miConsultas.Dshgo_Revision_ObtenerIndicadorPorIncumplimientoDesahogoID(desahogo_id);
		}

		public DataSet Dshgo_Revision_ObtenerIncisosPorIncumplimientoDesahogoID(int desahogo_id, int indicador_id)
		{
			return miConsultas.Dshgo_Revision_ObtenerIncisosPorIncumplimientoDesahogoID(desahogo_id, indicador_id);
		}

		public DataSet Dshgo_Revision_Info_Obtener(int dshgo_alcance_id, int indicador_id, int drev_respuesta)
		{
			return miConsultas.Dshgo_Revision_Info_Obtener(dshgo_alcance_id, indicador_id, drev_respuesta);
        }

        public DataSet Medidas_BusquedaAvanzada(DtoBusquedaAvanzada dtoBusq)
        {
            return miConsultas.Medidas_BusquedaAvanzada(dtoBusq);
        }

        public DataSet DshgoParrafoTexto_ObtenerFormato(int desahogo_id)
        {
            return miConsultas.DshgoParrafoTexto_ObtenerFormato(desahogo_id);
        }
        #endregion

        #region Calificacion
        public DataSet Calificacion_Obtener(DtoCalificacion DtoCalf)
        {
            return miConsultas.Calificacion_Obtener(DtoCalf);
        }

        public DataSet Calificacion_Consultar(DtoCalificacion DtoCalf)
        {
            return miConsultas.Calificacion_Consultar(DtoCalf);
        }
        public DataSet Calificacion_ConsultarAutomatica(DtoCalificacion DtoCalf)
        {
            return miConsultas.Calificacion_ConsultarAutomatica(DtoCalf);
        }
        public DataSet Calificacion_ConsultarPorParticipante(DtoCalificacion DtoCalf)
        {
            return miConsultas.Calificacion_ConsultarPorParticipante(DtoCalf);
        }
        public DataSet CalificacionAutomatica_ConsultarPorParticipante(DtoCalificacion DtoCalf)
        {
            return miConsultas.CalificacionAutomatica_ConsultarPorParticipante(DtoCalf);
        }
        //*************
        /*public DataSet ObtenerNuevoNumeroDocumentoPorCalifDocumentoID(int ur,int tipo_documento,int anio)
        {
            return miConsultas.ObtenerNuevoNumeroDocumentoPorCalifDocumentoID(ur,tipo_documento, anio);
        }*/

        public DataSet CalifDocumento_Consultar(DtoCalifDocumento miDtoCD)
        {
            return miConsultas.CalifDocumento_Consultar(miDtoCD);
        }

        public DataSet SExpedientes_Sancion_Inspeccion_Buscar(int por_pagina, int offset, int calif_estatus, int calificacion_id = -1)
        {
            return miConsultas.SExpedientes_Sancion_Inspeccion_Buscar(por_pagina, offset, calif_estatus, calificacion_id);
        }

        public DataSet doctoParrafoTexto_Actualizar_Parrafo(int docto_parrafo_texto_id, int docto_parrafo_id, string dpt_parrafo, int? cve_ur)
        {
            return miConsultas.doctoParrafoTexto_Actualizar_Parrafo(docto_parrafo_texto_id,docto_parrafo_id, dpt_parrafo, cve_ur);
        }

        public DataSet PA_Incumplimientos_Consultar(int tipo_documento_id, int calificacion_id, string num_solicitud)
        {
            return miConsultas.PA_Incumplimientos_Consultar(tipo_documento_id, calificacion_id, num_solicitud);
        }

        public DataSet Reinscidencias_Medida(int ind_medida_id, int centro_trabajo_id)
        {
            return miConsultas.Reinscidencias_Medida(ind_medida_id, centro_trabajo_id);
        }
        

        public DataSet Configuracion(DtoConfiguracion dtoConfiguracion)
        {
            return miConsultas.Configuracion(dtoConfiguracion);
        }
        

        public DataSet CalifDocumento_ObtenerParaPlantilla(int calif_documento_id)
        {
            return miConsultas.CalifDocumento_ObtenerParaPlantilla(calif_documento_id);
        }

        public DataSet CalifDoctoCopias_Consultar(int calif_documento_id, int cdc_copia_o_rubrica)
        {
            return miConsultas.CalifDoctoCopias_Consultar(calif_documento_id, cdc_copia_o_rubrica);
        }

        public DataSet CalifViolacion_Consultar(int calif_violacion_id, int desahogo_id, int calificacion_id, int materia_id)
        {
            return miConsultas.CalifViolacion_Consultar(calif_violacion_id, desahogo_id, calificacion_id, materia_id);
        }

        public DataSet CalifViolacion_Consultar2(int desahogo_id, int calificacion_id, int materia_id, int indicador_id, int? solo_indicadores)
        {
            return miConsultas.CalifViolacion_Consultar2(desahogo_id, calificacion_id, materia_id, indicador_id, solo_indicadores);
        }
        /*
         * SE COMENTA POR QUE SE SUSTITUYO POR COMPLETO CON EL CalifViolacion_Consultar4 27/08/2024
         * public DataSet CalifViolacion_Consultar3(int desahogo_id, int calificacion_id, int materia_id, int indicador_id, int? solo_indicadores)
        {
            return miConsultas.CalifViolacion_Consultar3(desahogo_id, calificacion_id, materia_id, indicador_id, solo_indicadores);
        }*/
        public DataSet CalifViolacion_Consultar4(int calif_violacion_id, int desahogo_id, int calificacion_id, int materia_id, int cviol_procede)
        {
            return miConsultas.CalifViolacion_Consultar4(calif_violacion_id, desahogo_id, calificacion_id, materia_id, cviol_procede);
        }

        public DataSet medidasAdinistrativasNoCumple(int calificacion_id)
        {
            return miConsultas.medidasAdinistrativasNoCumple(calificacion_id);
        }
        

        public DataSet CalifViolacion_Consultar_EmplazamientoMedidas(int desahogo_id, int calificacion_id, int materia_id, int indicador_id, int? solo_indicadores)
        {
            return miConsultas.CalifViolacion_Consultar_EmplazamientoMedidas(desahogo_id, calificacion_id, materia_id, indicador_id, solo_indicadores);
        }

        public DataSet CalifViolacion_ConsultarNegativa(int calif_violacion_id, int calificacion_id)
        {
            return miConsultas.CalifViolacion_ConsultarNegativa(calif_violacion_id, calificacion_id);
        }

        public DataSet CalifDoctoParrafoTexto_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            return miConsultas.CalifDoctoParrafoTexto_Obtener(dtoDocto);
        }

        public DataSet CalifDoctoVariableValores_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            return miConsultas.CalifDoctoVariableValores_Obtener(dtoDocto);
        }

		public DataSet CalifRequisitoRespuesta_ObtenerTablero(int calificacion_id)
		{
			return miConsultas.CalifRequisitoRespuesta_ObtenerTablero(calificacion_id);
		}

        public DataSet CalifVariables_Obtener(int calif_documento_id)
        {
            return miConsultas.CalifVariables_Obtener(calif_documento_id);
        }

		public DataSet VerificarDesahogoContieneMedida(int desahogo_id)
		{
			return miConsultas.VerificarDesahogoContieneMedida(desahogo_id);
		}

        public DataSet MedidasAdminPorSubmateriaDesahogo_Obtener(int desahogo_id,int submateria)
        {
            return miConsultas.MedidasAdminPorSubmateriaDesahogo_Obtener(desahogo_id,submateria);
        }
        public DataSet MedidasAdminPorSubmateriaComprobacionSanciones_Obtener(int sancion_id, int submateria, int inspeccion_id)
        {
            return miConsultas.MedidasAdminPorSubmateriaComprobacionSanciones_Obtener(sancion_id, submateria, inspeccion_id);
        }

        public DataSet ObtenerMedidasAdminComprobacionMedidasNoCumplen(int desahogo_id)
        {
            return miConsultas.ObtenerMedidasAdminComprobacionMedidasNoCumplen(desahogo_id);
        }

        public DataSet CalifViolacion_Consultar_Violaciones(int desahogo_id, int calificacion_id, int materia_id)
        {
            return miConsultas.CalifViolacion_Consultar_Violaciones(desahogo_id, calificacion_id, materia_id);
        }

        public DataSet MedidasAdminPorSubmateriaDesahogo_ObtenerEmplazamientoDocumental(int desahogo_id, int submateria)
        {
            return miConsultas.MedidasAdminPorSubmateriaDesahogo_ObtenerEmplazamientoDocumental(desahogo_id, submateria);
        }
       
        public DataSet MedidasAdminPorSubmateriaDesahogo_Obtener2(int emplazamiento_id, int submateria)
        {
            return miConsultas.MedidasAdminPorSubmateriaDesahogo_Obtener2(emplazamiento_id, submateria);
        }

        public DataSet MedidasAdminPorSubmateriaEmplazamiento_Obtener(int emplazamiento, int submateria)
        {
            return miConsultas.MedidasAdminPorSubmateriaEmplazamiento_Obtener(emplazamiento, submateria);
        }
        #endregion 

		#region CT
		public DataSet CT_ObtenerPorUsuarioClave(string dshgo_usuario_clave)
		{
			return miConsultas.CT_ObtenerPorUsuarioClave(dshgo_usuario_clave);
		}

		public DataSet CT_ObtenerPorExpedienteEmail(string in_num_expediente, string dct_email)
		{
			return miConsultas.CT_ObtenerPorExpedienteEmail(in_num_expediente, dct_email);
		}

		public DataSet CT_ObtenerPorInspeccionID(int inspeccion_id)
		{
			return miConsultas.CT_ObtenerPorInspeccionID(inspeccion_id);
		}

		public DataSet CT_ObtenerTablero(int inspeccion_id)
		{
			return miConsultas.CT_ObtenerTablero(inspeccion_id);
		}

		public DataSet CT_ObtenerDatosInspeccionPorInspeccionID(int inspeccion_id)
		{
			return miConsultas.CT_ObtenerDatosInspeccionPorInspeccionID(inspeccion_id);
		}

		public DataSet CT_ObtenerDatosCitatorioPorInspeccionID(int inspeccion_id)
		{
			return miConsultas.CT_ObtenerDatosCitatorioPorInspeccionID(inspeccion_id);
		}

		public DataSet CT_ObtenerResultadoInspeccionPorInspeccionID(int inspeccion_id)
		{
			return miConsultas.CT_ObtenerResultadoInspeccionPorInspeccionID(inspeccion_id);
		}
		#endregion

        #region PAS


        public DataSet SEtapa_ObtenerPorID(int s_etapa_id)
        {
            return miConsultas.SEtapa_ObtenerPorID(s_etapa_id);
        }

        public DataSet SEtapa_ObtenerPorNombre(string setapa_nombre)
        {
            return miConsultas.SEtapa_ObtenerPorNombre(setapa_nombre);
        }

        public DataSet SNotificacion_Obtener(int s_notif_solicitud_id, int s_expediente_etapa_id, int estatus, int sns_forma_entrega, int etapa_id, String sns_tipo_notif, int cve_edorep, int cve_mun, int cve_ur, string fecha1, string fecha2)
        {
            return miConsultas.SNotificacion_Obtener(s_notif_solicitud_id, s_expediente_etapa_id, estatus, sns_forma_entrega,etapa_id, sns_tipo_notif, cve_edorep, cve_mun, cve_ur, fecha1, fecha2);
        }

        public DataSet SNotificacionResultado_Obtener(int s_notif_resultado_id, int s_expediente_etapa_id, int estatus, int snr_forma_entrega, int etapa_id, String snr_tipo_notif, string ct_nombre, int cve_ur, string fecha1, string fecha2, int edo, int mun, int inspector_id)
        {
            return miConsultas.SNotificacionResultado_Obtener(s_notif_resultado_id, s_expediente_etapa_id, estatus, snr_forma_entrega,etapa_id,  snr_tipo_notif, ct_nombre, cve_ur, fecha1, fecha2, edo, mun, inspector_id, -1,-1);
        }

        public DataSet SNotificacionResultado_Obtener(int s_notif_resultado_id, int s_expediente_etapa_id, int estatus, int snr_forma_entrega, int etapa_id, String snr_tipo_notif, string ct_nombre, int cve_ur, string fecha1, string fecha2, int edo, int mun, int inspector_id, int estatus1, int cve_ur1)
        {
            return miConsultas.SNotificacionResultado_Obtener(s_notif_resultado_id, s_expediente_etapa_id, estatus, snr_forma_entrega, etapa_id, snr_tipo_notif, ct_nombre, cve_ur, fecha1, fecha2, edo, mun, inspector_id, estatus1,cve_ur1);
        }

        public DataSet Notificaciones_SIPAS(DtoNotificacionSIPAS notificacion)
        {
            return miConsultas.Notificaciones_SIPAS(notificacion);
        }

        public DataSet SNotificacionResultado_Obtener(int s_notif_resultado_id, int s_expediente_etapa_id, int estatus, int snr_forma_entrega, int etapa_id, String snr_tipo_notif, string ct_nombre, int cve_ur, string fecha1, string fecha2, int edo, int mun)
        {
            return miConsultas.SNotificacionResultado_Obtener(s_notif_resultado_id, s_expediente_etapa_id, estatus, snr_forma_entrega, etapa_id, snr_tipo_notif, ct_nombre, cve_ur, fecha1, fecha2, edo, mun,-1,-1,-1);
        }

        public DataSet NotifSancionador_Obtener(int notif_sancionador_id, int s_expediente_etapa_id, int estatus, int snr_forma_entrega, int etapa_id, String snr_tipo_notif, string ct_nombre, int cve_ur, string fecha1, string fecha2, int edo, int mun, int inspector_id, int estatus1)
        {
            return miConsultas.NotifSancionador_Obtener(notif_sancionador_id, s_expediente_etapa_id, estatus, snr_forma_entrega, etapa_id, snr_tipo_notif, ct_nombre, cve_ur, fecha1, fecha2, edo, mun, inspector_id, estatus1);
        }

        public DataSet ObtenerUltimoDomicilioNotificaciones(int s_expediente_id,int s_expediente_etapa_id)
        {
            return miConsultas.ObtenerUltimoDomicilioNotificaciones(s_expediente_id, s_expediente_etapa_id);
        }


        public DataSet SExpedienteEtapa_ObtenerUltimaEtapaAnterior(int s_expediente_etapa_id, int s_etapa_id)
        {
            return miConsultas.SExpedienteEtapa_ObtenerUltimaEtapaAnterior(s_expediente_etapa_id, s_etapa_id);
        }
        public DataSet SIncumplimientos_acuerdoCierreResolucion(int s_expediente_etapa_id, string num_solicitud,int indicadorId, int submateriaId, string sentencia = "SELECT", int inspeccion_id =-1, String medida = "")
        {
            return miConsultas.SIncumplimientos_acuerdoCierreResolucion(s_expediente_etapa_id, num_solicitud,indicadorId, submateriaId ,sentencia, inspeccion_id, medida);
        }
        public DataSet MedDescatalogada_ObtenerPorMedidaFundamento(int desahogo_id, string medida, string fundamento) {
            return miConsultas.MedDescatalogada_ObtenerPorMedidaFundamento(desahogo_id, medida, fundamento);
        }
        public int AgregarIncumplimientosAcuerdoCierreResolucion(DtoSancionViolacion dtoSancVio)
        {
            return miAgregar.AgregarIncumplimientosAcuerdoCierreResolucion(dtoSancVio);
        }

        public DataSet SExpediente_ObtenerEtapas(int s_expediente_id, int s_expediente_etapa_id)
        {
            return miConsultas.SExpediente_ObtenerEtapas(s_expediente_id, s_expediente_etapa_id);
        }

        public DataSet ObtenerSExpedientesIDsPorInspeccionId(int inspeccion_id)
        {
            return miConsultas.ObtenerSExpedientesIDsPorInspeccionId(inspeccion_id);
        }
        public DataSet SExpediente_ObtenerEtapas(int s_expediente_id, int s_expediente_etapa_id, string proceso = null, string etapa_padre = null)
        {
            return miConsultas.SExpediente_ObtenerEtapas(s_expediente_id, s_expediente_etapa_id, proceso, etapa_padre);
        }

        public DataSet SSolicitud_Cobro_Consulta_Res(int s_expediente_id)
        {
            return miConsultas.SSolicitud_Cobro_Consulta_Res(s_expediente_id);
        }

        public DataSet SAcuerdo_Escrito_Particular_Consultar(int s_expediente_etapa_id, int s_acuerdo_escrito_particular_id)
        {
            return miConsultas.SAcuerdo_Escrito_Particular_Consultar(s_expediente_etapa_id, s_acuerdo_escrito_particular_id);
        }
        public DataSet SAutoridadFiscal_Obtener(int s_autoridad_fiscal_id, int cen_cve_edorep)
        {
            return miConsultas.SAutoridadFiscal_Obtener(s_autoridad_fiscal_id, cen_cve_edorep);
        }
        public DataSet SExpedienteEtapa_Obtener(DtoSExpedienteEtapa midto)
        {
            return miConsultas.SExpedienteEtapa_Obtener(midto);
        }

        public DataSet NotifRequerir_Obtener(int s_notif_solicitud_id, int cve_ur)
        {
            return miConsultas.NotifRequerir_Obtener(s_notif_solicitud_id, cve_ur);
        }

        public DataSet SAcuerdoNotificacion_Obtener(int s_expediente_etapa_id)
        {
            return miConsultas.SAcuerdoNotificacion_Obtener(s_expediente_etapa_id);
        }

        public DataSet Tablero_Estatus_Resolucion_Expedientes(DtoBusquedaPAS dtoB)
        {
            return miConsultas.Tablero_Estatus_Resolucion_Expedientes(dtoB);
        }        
        public DataSet PA_Listado_Resolucion_Cumplimiento(DtoBusqueda dtoB)
        {
            return miConsultas.PA_Listado_Resolucion_Cumplimiento(dtoB);
        }        

        public DataSet SParticipante_Obtener(int s_participante_id, int cve_edorep)
        {
            return miConsultas.SParticipante_Obtener(s_participante_id, cve_edorep);
        }
        public DataSet Tablero_EtapaProcesal(DtoBusquedaPAS dtoB)
        {
            return miConsultas.Tablero_EtapaProcesal(dtoB);
        }        
        
        public DataSet Tablero_EtapaProcesal_Dos(DtoBusquedaPAS dtoB)
        {
            return miConsultas.Tablero_EtapaProcesal_Dos(dtoB);
        }
        public DataSet Tablero_Impugnaciones(DtoBusquedaPAS dtoB)
        {
            return miConsultas.Tablero_Impugnaciones(dtoB);
        }
        public DataSet Tablero_RemitidosPorAutoridadFiscal(DtoBusquedaPAS dtoB)
        {
            return miConsultas.Tablero_RemitidosPorAutoridadFiscal(dtoB);
        }
        public DataSet SResolucionCumplimiento_Reporte(DtoBusquedaPAS dtoB)
        {
            return miConsultas.SResolucionCumplimiento_Reporte(dtoB);
        }
        public DataSet Tablero_ReporteResolucionExpediente(DtoBusquedaPAS dtoB)
        {
            return miConsultas.Tablero_ReporteResolucionExpediente(dtoB);
        }
        public DataSet Tablero_ResolucionesTipo(DtoBusquedaPAS dtoB)
        {
            return miConsultas.Tablero_ResolucionesTipo(dtoB);
        }
        public DataSet SParticipante_Obtener(int s_participante_id, int cve_edorep, int cur_cve_ur)
        {
            return miConsultas.SParticipante_Obtener(s_participante_id, cve_edorep, cur_cve_ur);
        }
        #endregion

        public DataSet Operativos_Obtener(int prog_anual_id, int operativo_id, int oper_tipo_operativo, int mes_id, int ur, int panual_estatus)
        {
            return miConsultas.Operativos_Obtener(prog_anual_id, operativo_id, oper_tipo_operativo, mes_id, ur, panual_estatus, -1);
        }

        public DataSet Operativos_Obtener(int prog_anual_id, int operativo_id, int oper_tipo_operativo, int mes_id, int ur, int panual_estatus, int oper_estatus)
        {
            return miConsultas.Operativos_Obtener(prog_anual_id, operativo_id, oper_tipo_operativo, mes_id, ur, panual_estatus, oper_estatus);
        }

        public DataSet InspectorDisponibilidad_Obtener(int inspector_id, int inspector_disponibilidad_id)
        {
            return miConsultas.InspectorDisponibilidad_Obtener(inspector_id, inspector_disponibilidad_id);
        }
        public DataSet InspectorDisponibilidad_ConsultarFechas(int inspector_id, int inspector_disponibilidad_id, int mes, int anio)
        {
            return miConsultas.InspectorDisponibilidad_ConsultarFechas(inspector_id, inspector_disponibilidad_id, mes, anio);
        }

        public DataSet Obtener_Supervisor_por_CVUR(int inspeccion_id)
        {
            return miConsultas.Obtener_Supervisor_por_CVUR(inspeccion_id);
        }

        public DataSet ActividadRama_Busqueda(string cadenaBusqueda)
        {
            return miConsultas.ActividadRama_Busqueda(cadenaBusqueda);
        }

        public DataSet ActividadRama_ObtenerClavePorDesc(string cadenaBusqueda)
        {
            return miConsultas.ActividadRama_ObtenerClavePorDesc(cadenaBusqueda);
        }

        public DataSet Incisos_Obtener(int indicador_id, int ind_inciso_id)
        {
            return miConsultas.Incisos_Obtener(indicador_id, ind_inciso_id);
        }

        public DataSet IndMedida_Obtener(DtoIndMedida miDtoInd)
        {
            return miConsultas.IndMedida_Obtener(miDtoInd);
        }

        public DataSet dshgoSeccion_ObtenerTablero(DtodshgoTablero tablero)
        {
            return miConsultas.dshgoSeccion_ObtenerTablero(tablero);
        }

        public DataSet dshgoProcesos_Offline(DtoProcesosOffline dtoProcesos)
        {
            return miConsultas.dshgoProcesos_Offline(dtoProcesos);
        }

        public DataSet DshgoInterrogado_Obtener(int dshgo_participante_id, int dshgo_interrogado_id, int desahogo_id)
        {
            return miConsultas.DshgoInterrogado_Obtener(dshgo_participante_id, dshgo_interrogado_id, desahogo_id);
        }
        public DataSet DshgoListadoPActivo_Obtener(int desahogo_id, int dshgo_listado_personal_id)
        {
            return miConsultas.DshgoListadoPActivo_Obtener(desahogo_id, dshgo_listado_personal_id);
        }
        public DataSet Dshgo_RepEmpresa_Obtener2(int desahogo_id)
        {
            return miConsultas.Dshgo_RepEmpresa_Obtener2(desahogo_id);
        }

        //**
        public DataSet Dshgo_RepEmpresa_ObtenerPorTipo(int desahogo_id, int tipo_representante_id, int dshgo_rep_empresa_id, int dshgo_participante_id)
        {
            return miConsultas.Dshgo_RepEmpresa_ObtenerPorTipo( desahogo_id, tipo_representante_id, dshgo_rep_empresa_id, dshgo_participante_id);
        }

        public DataSet Dshgo_Comision_Obtener(int desahogo_id)
        {
            return miConsultas.Dshgo_Comision_Obtener(desahogo_id);
        }

        public DataSet Dshgo_RepTrabajador_Obtener2(int desahogo_id)
        {
            return miConsultas.Dshgo_RepTrabajador_Obtener2(desahogo_id);
        }

        public DataSet DshgoPreguntas_Obtener(int materia_id, int submateria_id, int dpreg_tipo_pregunta, string sentencia = "SELECT", string dpreg_pregunta = "", int dpreg_estatus = -1, int dpreg_consecutivo = -1, int dshgo_pregunta_id = -1)
        {
            return miConsultas.DshgoPreguntas_Obtener(materia_id, submateria_id, dpreg_tipo_pregunta, sentencia, dpreg_pregunta, dpreg_estatus, dpreg_consecutivo, dshgo_pregunta_id);
        }

        public DataSet Dshgo_Supuesto_Obtener(int supuesto_designacion_id, int esTestigo1, int esTestigo2, int designadopor)
        {
            return miConsultas.Dshgo_Supuesto_Obtener(supuesto_designacion_id, esTestigo1, esTestigo2, designadopor);
        }


        public DataSet DshgoPreguntaRespuesta_Obtener(int dshgo_pregunta_id, string sentencia = "SELECT", int dshgo_pregunta_respuesta = -1, int dpresp_orden = -1, string dpresp_respuesta = "")
        {
            return miConsultas.DshgoPreguntaRespuesta_Obtener(dshgo_pregunta_id, sentencia, dshgo_pregunta_respuesta, dpresp_orden, dpresp_respuesta);
        }

        public DataSet MenuMedidas_Obtener(int participante_id)
        {
            return miConsultas.MenuMedidas_Obtener(participante_id);
        }

        public DataSet MenuMedidasSugeridas_Obtener(string menu_sentencia, int participante_id, int materia_id)
        {
            return miConsultas.MenuMedidasSugeridas_Obtener(menu_sentencia, participante_id, materia_id);
        }

        public DataSet DshgoDocumento_Obtener(DtoDshgoDocumento dtoDocto, int no_otros = -1) {
            return miConsultas.DshgoDocumento_Obtener(dtoDocto, no_otros);
        }

        public DataSet PA_DshgoDocumento_ObtenerConsultaRespuesta(DtoDshgoDocumento dtoDocto, int no_otros = -1)
        {
            return miConsultas.PA_DshgoDocumento_ObtenerConsultaRespuesta(dtoDocto, no_otros);
        }

        public DataSet DshgoDocumentoAnexo_Obtener(DtoDshgoDocumento dtoDocto)
        {
            return miConsultas.DshgoDocumentoAnexo_Obtener(dtoDocto);
        }

        public DataSet DshgoMedida_Obtener(int desahogo_id, int dshgo_medida_id)
        {
            return miConsultas.DshgoMedida_Obtener(desahogo_id, dshgo_medida_id);
        }

        public DataSet DshgoMedidaNoAdmin_Obtener(int desahogo_id, int dmed_cumplimiento_espontaneo)
        {
            return miConsultas.DshgoMedidaNoAdmin_Obtener(desahogo_id, dmed_cumplimiento_espontaneo);
        }

        public DataSet MotivoNoFirma_Obtener()
        {
            return miConsultas.MotivoNoFirma_Obtener();
        }

        public DataSet DshgoMedDescatalogada_Obtener(int desahogo_id, int dshgo_med_descatalogada_id)
        {
            return miConsultas.DshgoMedDescatalogada_Obtener(desahogo_id, dshgo_med_descatalogada_id);
		}


        public DataSet Medidas_ObtenerMedidasPorTema(int tema_id, int tipo, int desahogo_id, int participante_id, int normatividad_id = -1)
        {
            return miConsultas.Medidas_ObtenerMedidasPorTema(tema_id, tipo, desahogo_id, participante_id, normatividad_id);
        }

        public DataSet DshgoMedidaArea_Obtener(int ind_medida_id, int ind_info_adicional_id,int desahogo_id)
        {
            return miConsultas.DshgoMedidaArea_Obtener(ind_medida_id,ind_info_adicional_id, desahogo_id);
        }

        public DataTable DshgoMedidaArea_ObtenerOpen(int ind_medida_id, int ind_info_adicional_id, int desahogo_id)
        {
            return miConsultas.DshgoMedidaArea_ObtenerOpen(ind_medida_id, ind_info_adicional_id, desahogo_id);
        }

        public DataSet DshgoInfoAdicional_Obtener(int indicador_id, int ind_inciso_id, int desahogo_id)
        {
            return miConsultas.DshgoInfoAdicional_Obtener(indicador_id,ind_inciso_id, desahogo_id);
        }

        public DataSet DshgoMedida_Valida_MedidasSugeridas(int desahogo_id)
        {
            return miConsultas.DshgoMedida_Valida_MedidasSugeridas(desahogo_id);
        }

        public DataSet TodasAreasDshgoMedida_Obtener(int dshgo_medida_id)
        {
            return miConsultas.TodasAreasDshgoMedida_Obtener(dshgo_medida_id);
        }


        public DataSet MedidasAutoComplet_Obtener(int desahogo_id, String texto)
        {
            return miConsultas.MedidasAutoComplet_Obtener(desahogo_id, texto);
        }


        public DataSet CatalogosMedidas_Submateria(int submateria_id)
        {
            return miConsultas.CatalogosMedidas_Submateria(submateria_id);
        }

        //obtener submaterias para las medidas administrativas
        public DataSet SubmateriaMedidasAdmin_Obtener(int desahogo_id,int submateria_id,int amp)
        {
            return miConsultas.SubmateriaMedidasAdmin_Obtener(desahogo_id,submateria_id,amp);
        }
        public DataSet SubmateriaMedidasAdminComprobacionSanciones_Obtener(int sancion_id, int submateria_id, int inspeccion_id)
        {
            return miConsultas.SubmateriaMedidasAdminComprobacionSanciones_Obtener(sancion_id, submateria_id, inspeccion_id);
        }
        public DataSet SubmateriaMedidasAdmin_ObtenerEmplazamientoDocumental(int desahogo_id, int submateria_id, int amp)
        {
            return miConsultas.SubmateriaMedidasAdmin_ObtenerEmplazamientoDocumental(desahogo_id, submateria_id, amp);
        }

        public DataSet SubmateriaMedidasAdmin_ObtenerEmplazamientoMedidas(int desahogo_id, int submateria_id, int amp)
        {
            return miConsultas.SubmateriaMedidasAdmin_ObtenerEmplazamientoMedidas(desahogo_id, submateria_id, amp);
        }

        public DataSet Alcance_Submaterias_Indicadores_incisos_Obtener(int inspeccion_id)
        {
            return miConsultas.Alcance_Submaterias_Indicadores_incisos_Obtener(inspeccion_id);
        }

        public DataSet SubmateriaMedidasFisicas_ObtenerEmplazamientoMedidas(int imed_tipo_incumplimiento, int desahogo_id)
        {
            return miConsultas.SubmateriaMedidasFisicas_ObtenerEmplazamientoMedidas(imed_tipo_incumplimiento, desahogo_id);
        }

        public DataSet SubmateriaMedidasAdmin_ObtenerEmplazamiento(int emplazamiento_id, int submateria_id)
        {
            return miConsultas.SubmateriaMedidasAdmin_ObtenerEmplazamiento(emplazamiento_id, submateria_id);
        }

        public DataSet SubmateriaMedidasAdmin_ObtenerEmplazamiento2(int emplazamiento_id, int submateria_id)
        {
            return miConsultas.SubmateriaMedidasAdmin_ObtenerEmplazamiento2(emplazamiento_id, submateria_id);
        }

        public DataSet TodosDocumentos_ConsultarPorInspeccion(int inspeccion_id)
        {
            return miConsultas.TodosDocumentos_ConsultarPorInspeccion(inspeccion_id);
        }
        public DataSet ObtenerConfirmacionDocumento(int inspeccion_id, int tipo_documento_id)
        {
            return miConsultas.ObtenerConfirmacionDocumento(inspeccion_id, tipo_documento_id);
        }



        public DataSet MedidasRecorridoParaEmplazamiento_Obtener(int desahogo_id)
        {
            return miConsultas.MedidasRecorridoParaEmplazamiento_Obtener(desahogo_id);
        }
        public DataSet MedidasRecorridoParaComprobacionSanciones_Obtener(int sancion_id, int submateria_id, int inspeccion_id)
        {
            return miConsultas.MedidasRecorridoParaComprobacionSanciones_Obtener(sancion_id, submateria_id, inspeccion_id);
        }

        public DataSet MedidasRecorridoParaEmplazamiento_Obtener2(int emplazamiento_id)
        {
            return miConsultas.MedidasRecorridoParaEmplazamiento_Obtener2(emplazamiento_id);
        }

        public DataSet Tablas_ObtenerInfo(String Tabla)
        {
            return miConsultas.Tablas_ObtenerInfo(Tabla);
        }

        public DataSet UnidadResp_BuscarDescripcion(string cur_descripcion)
        {
            return miConsultas.UnidadResp_BuscarDescripcion(cur_descripcion);
        }
        public DataSet CatalogoUnidadResp_BuscarPorUR(int? cve_ur)
        {
            return miConsultas.CatalogoUnidadResp_BuscarPorUR(cve_ur);
        }

        public DataSet ConsultaRestriccionAcceso(int desahogo_id)
        {
            return miConsultas.ConsultaRestriccionAcceso(desahogo_id);
        }
        public DataSet ConsultaRestriccionAccesoDGIFT(DtoDshgoMedidaPrecautoriaConsulta DtoConsulta)
        {
            return miConsultas.ConsultaRestriccionAccesoDGIFT(DtoConsulta);
        }
        public DataSet ConsultaRestriccionAccesoRespuesta(DtoDshgoMedidaPrecautoriaConsulta DtoCalf)
        {
            return miConsultas.ConsultaRestriccionAccesoRespuesta(DtoCalf);
        }
        #endregion

        #region Eliminar
        Eliminar miEliminar = new Eliminar();

        public void EliminarAbrirConexion()
        {
            miEliminar.EliminarAbrirConexion();
        }

        public void EliminarCerrarConexion()
        {
            miEliminar.EliminarCerrarConexion();
        }


        public void EliminarContenido(int apoyo_id)
        {
            miEliminar.EliminarContenido(apoyo_id);
        }

        public void OperativoDocto_Eliminar(int operativo_docto_id)
        {
            miEliminar.OperativoDocto_Eliminar(operativo_docto_id);
        }

        public void OperativosProg_Eliminar(int operativo_id)
        {
            miEliminar.OperativosProg_Eliminar(operativo_id);
        }

		public void OperativoDocto_EliminarPorOperativoId(int operativo_id)
		{
			miEliminar.OperativoDocto_EliminarPorOperativoId(operativo_id);
		}

        public void OperativoAlcance_EliminarPorOperativoId(int operativo_id)
        {
            miEliminar.OperativoAlcance_EliminarPorOperativoId(operativo_id);
        }

        public void OperativoAsignacion_EliminarPorOperativoId(int operativo_id)
        {
            miEliminar.OperativoAsignacion_EliminarPorOperativoId(operativo_id);
        }

        public void OperativoEntidad_EliminarPorOperativoId(int operativo_id)
        {
            miEliminar.OperativoEntidad_EliminarPorOperativoId(operativo_id);
        }

        public void ProgAtributosActividad_Eliminar(int prog_actividad_federal_id)
        {
            miEliminar.ProgAtributosActividad_Eliminar(prog_actividad_federal_id);
        }

        public void InspecAdicional_Eliminar(int inspec_adicional_id)
        {
            miEliminar.InspecAdicional_Eliminar(inspec_adicional_id);
        }

        public void InspecExperto_Eliminar(int inspec_experto_id)
        {
            miEliminar.InspecExperto_Eliminar(inspec_experto_id);
        }

		public void InspeccionCopia_EliminarPorInspeccionID(int inspec_copia_id)
		{
			miEliminar.InspeccionCopia_EliminarPorInspeccionID(inspec_copia_id);
		}

        public void InspeccionCopia_Eliminar(int inspeccion_id)
        {
            miEliminar.InspeccionCopia_Eliminar(inspeccion_id);
        }

        public void Usuario_Eliminar(int usuario_id)
        {
            miEliminar.Usuario_Eliminar(usuario_id);
        }

        public void Inspector_Eliminar(int inspector_id)
        {
            miEliminar.Inspector_Eliminar(inspector_id);
        }

        public void OperativoIndicador_Eliminar(int operativo_indicador_id)
        {
            miEliminar.OperativoIndicador_Eliminar(operativo_indicador_id);
        }

        public void OperativoIndicador_EliminarPorOperativoId(int operativo_id)
        {
            miEliminar.OperativoIndicador_EliminarPorOperativoId(operativo_id);
        }

		public void DshgoTrabajadoresDetalle_EliminarPorID(int dshgo_trabajador_det_id)
		{
			miEliminar.DshgoTrabajadoresDetalle_EliminarPorID(dshgo_trabajador_det_id);
		}

		public void DshgoSolidaria_EliminarPorID(int dshgo_solidaria_dne_id)
		{
			miEliminar.DshgoSolidaria_EliminarPorID(dshgo_solidaria_dne_id);
		}

        public void DshgoMedida_Eliminar(int dshgo_medida_id)
        {
            miEliminar.DshgoMedida_Eliminar(dshgo_medida_id);
        }

       public void DshgoMedida_EliminarTodas(int desahogo_id)
        {
            miEliminar.DshgoMedida_EliminarTodas(desahogo_id);
        }

	   public void Inspeccion_EliminarAleatoria(int anio, int mes, int cve_ur)
	   {
		   miEliminar.Inspeccion_EliminarAleatoria(anio, mes, cve_ur);
	   }

        public void DshgoInterrogatorio_Eliminar(int dshgo_interrogado_id)
        {
            miEliminar.DshgoInterrogatorio_Eliminar(dshgo_interrogado_id);
        }
        public void DshgoListadoPActivo_Eliminar(int dshgo_listado_personal_id)
        {
            miEliminar.DshgoListadoPActivo_Eliminar(dshgo_listado_personal_id);
        }        
        public void DshgoListadoPersonal_Eliminar_Masivamente(int dshgo_listado_personal_id)
        {
            miEliminar.DshgoListadoPersonal_Eliminar_Masivamente(dshgo_listado_personal_id);
        }
        public void DshgoInterrogatorioAbierta_Eliminar(int dshgo_interrogado_id)
        {
            miEliminar.DshgoInterrogatorioAbierta_Eliminar(dshgo_interrogado_id);
        }        
        
        public void DshgoInterrogatorioAbierta_EliminarUnica(int dshgo_interrogatorio_abierta_id)
        {
            miEliminar.DshgoInterrogatorioAbierta_EliminarUnica(dshgo_interrogatorio_abierta_id);
        }
        public void DshgoMedDescatalogada_Eliminar(int dshgo_med_descatalogada_id)
        {
            miEliminar.DshgoMedDescatalogada_Eliminar(dshgo_med_descatalogada_id);
        }

        public void DshgoMotivoInforme_Eliminar(int motivo_informe_id, int desahogo_id)
        {
            miEliminar.DshgoMotivoInforme_Eliminar(motivo_informe_id, desahogo_id);
        }

		public void CalifDoctoCopias_Eliminar(int calif_docto_copias_id)
		{
			miEliminar.CalifDoctoCopias_Eliminar(calif_docto_copias_id);
		}

        public void CentroSindicato_Eliminar(int centro_trabajo_id, int cs_orden)
        {
            miEliminar.CentroSindicato_Eliminar(centro_trabajo_id, cs_orden);
        }
        #endregion

		public void InspeccionAlcance_Eliminar(int inspeccion_id)
		{
			miEliminar.InspeccionAlcance_Eliminar(inspeccion_id);
		}

        //***eliminar inspec indicador
        public void InspeccionIndicador_Eliminar(int inspeccion_id)
        {
            miEliminar.InspeccionIndicador_Eliminar(inspeccion_id);
        }

        public void OperativoAlcance_Eliminar(int operativo_id)
        {
            miEliminar.OperativoAlcance_Eliminar(operativo_id);
        }

        //*****
        public void OperativoAlcance_EliminarPorOperativoPorSubmateria(int operativo_id,int submateria_id)
        {
            miEliminar.OperativoAlcance_EliminarPorOperativoPorSubmateria(operativo_id, submateria_id);
        }

        public void Dshgo_Area_Eliminar(int dshgo_area_id)
        {
            miEliminar.Dshgo_Area_Eliminar(dshgo_area_id);
        }

        public void DshgoAlcance_Eliminar(int dshgo_alcance_id)
        {
            miEliminar.DshgoAlcance_Eliminar(dshgo_alcance_id);
        }

        public void DshgoInterrogado_Eliminar(int dshgo_interrogado_id)
        {
            miEliminar.DshgoInterrogado_Eliminar(dshgo_interrogado_id);
        }

        public void InspectorDisponibilidad_Eliminar(int inspector_disponibilidad_id)
        {
            miEliminar.InspectorDisponibilidad_Eliminar(inspector_disponibilidad_id);
        }

        public void MotivoSubtipo_Eliminar(int motivo_id)
        {
            miEliminar.MotivoSubtipo_Eliminar(motivo_id);
        }

        public void MotivoMateria_Eliminar(int motivo_id)
        {
            miEliminar.MotivoMateria_Eliminar(motivo_id);
        }

        public void InfoAdicional_Eliminar(int indicador_id, int ind_inciso_id, int info_id)
        {
            miEliminar.InfoAdicional_Eliminar(indicador_id, ind_inciso_id, info_id);
        }

        public void DshgoMedida_Eliminar(int ind_medida_id, int desahogo_id, int ind_info_adicional_id)
        {
            miEliminar.DshgoMedida_Eliminar(ind_medida_id, desahogo_id, ind_info_adicional_id);
        }

        public void DshgoMedida_EliminarOpen(int ind_medida_id, int desahogo_id, int ind_info_adicional_id)
        {
            miEliminar.DshgoMedida_EliminarOpen(ind_medida_id, desahogo_id, ind_info_adicional_id);
        }

        public void DshgoMedidaArea_Eliminar(int dshgo_medida_id, int dsgo_area_id)
        {
            miEliminar.DshgoMedidaArea_Eliminar(dshgo_medida_id, dsgo_area_id);
        }

        public void DshgoMedidaArea_EliminarOpen(int dshgo_medida_id, int dsgo_area_id)
        {
            miEliminar.DshgoMedidaArea_EliminarOpen(dshgo_medida_id, dsgo_area_id);
        }

        public void DshgoMedDescatalogadaArea_Eliminar(int dshgo_med_descatalogada_id, int dsgo_area_id)
        {
            miEliminar.DshgoMedDescatalogadaArea_Eliminar(dshgo_med_descatalogada_id, dsgo_area_id);
        }

        //*******************

		public DataSet Inspeccion_ObtenerAleatoria(int anio, int mes, int cve_ur, int in_estatus, int ordenar, int cve_ur_comision, int inspector_asignado, string nombre_razon_social)
		{
			return miConsultas.Inspeccion_ObtenerAleatoria(anio, mes, cve_ur, in_estatus, ordenar,  cve_ur_comision, inspector_asignado, nombre_razon_social);
		}
       
        public DataSet Inspeccion_OperativoEspecial(int anio, int mes, int cve_ur, int operativo_id)
        {
            return miConsultas.Inspeccion_OperativoEspecial(anio, mes, cve_ur, operativo_id);
        }

		public DataSet UnidadResponsable_ObtenerPorID(int cve_ur, int cur_cve_edorep)
		{
			return miConsultas.UnidadResponsable_ObtenerPorID(cve_ur, cur_cve_edorep);
		}

		public DataSet UnidadResponsable_ObtenerPorID(int cve_ur)
		{
			return miConsultas.UnidadResponsable_ObtenerPorID(cve_ur, -1);
        }

        public void DesahogoInstalacion_Eliminar(int desahogo_id)
        {
            miEliminar.DesahogoInstalacion_Eliminar(desahogo_id);
        }

        public void DshgoCentroCamara_Eliminar(int dshgo_centro_trabajo_id)
        {
            miEliminar.DshgoCentroCamara_Eliminar(dshgo_centro_trabajo_id);
        }

        public void DshgoDocumento_Eliminar(int dshgo_documento_id, string tipo_borrado = null, string sentencia = "eliminar")
        {
            miEliminar.DshgoDocumento_Eliminar(dshgo_documento_id, tipo_borrado, sentencia);
        }

        public void CalifDocumento_Eliminar(int calif_documento_id, string sentencia = "eliminar")
        {
            miEliminar.CalifDocumento_Eliminar(calif_documento_id, sentencia);
        }

        public void CalifDocumento_EliminarPlus(string calif_documento_ids, int calificacion_id)
        {
            miEliminar.CalifDocumento_EliminarPlus(calif_documento_ids, calificacion_id);
        }

        

        public DataSet Notif_MotivoNoEntrega()
        {
            return miConsultas.Notif_MotivoNoEntrega();
        }

        public DataSet MedidasViolaciones_ParaConsulta(int calificacion_id)
        {
            return miConsultas.MedidasViolaciones_ParaConsulta(calificacion_id);
        }

        public DataSet MedidasViolaciones_Consulta(int calificacion_id)
        {
            return miConsultas.MedidasViolaciones_Consulta(calificacion_id);
        }

        public DataSet DshgoMedidasArea_ObtenerPorArea(int dsgo_area_id)
        {
            return miConsultas.DshgoMedidasArea_ObtenerPorArea(dsgo_area_id);
        }

        public DataSet Participante_ObtenerUsuario(string inspector_id)
        {
            return miConsultas.Participante_ObtenerUsuario(inspector_id);
        }      

        public DataSet Perfil_ObtenerUsuarios(string email_usuario)
        {
            return miConsultas.Perfil_ObtenerUsuarios(email_usuario, "SELECT");
        }

        public DataSet Perfil_ObtenerEstatus(string email_usuario)
        {
            return miConsultas.Perfil_ObtenerUsuarios(email_usuario, "SEARCH");
        }

        #region Conteo de inspecciones por materia

        public DtoConteoInspecciones Obtener_Inspector_AcronimoMateria(int inspeccion_id)
        {
           return miConsultas.obtener_inspector_acronimo(inspeccion_id);
        }

        public DtoConteoInspecciones Obtener_Conteo_Inspecciones(DtoConteoInspecciones dtoConteoInspeciones)
        {
            return miConsultas.obtener_conteo_inspeciones(dtoConteoInspeciones);
        }

        public bool Insertar_Conteo_Inspecciones(DtoConteoInspecciones dtoConteoInspeciones)
        {
            return miAgregar.Insertar_conteo_inspecciones(dtoConteoInspeciones);
        }

        public bool Actualizar_Conteo_Inspecciones(DtoConteoInspecciones dtoConteoInspeciones)
        {
            return miAgregar.Actualizar_conteo_inspecciones(dtoConteoInspeciones);
        }


        #endregion

        #region Consultar calificacion usuario inspeccion ID
        public DtoCalificacion Calificacion_usuario_inspeccion(int calificacion_id)
        {
            return miConsultas.obtener_calificacion_usuario_inspeccion(calificacion_id);
        }
        #endregion

        #region Consultar inspeccion usuario por inspeccion ID
        public List<DtoInspeccion> inspeccion_usuario(int inspeccion_id)
        {
            return miConsultas.obtener_inspeccion_usuario(inspeccion_id);
        }
        #endregion

        public List<DtoInspeccion> Historial_Inspecciones(DtoInspeccion dtoInspeccion)
        {
            return miConsultas.obtener_historial_inspeciones(dtoInspeccion);
        }


        public List<DtoConteoInspecciones> obtener_conteo_inspeciones_inspectores(DtoDFT miDtoDFT)
        {
            return miConsultas.obtener_conteo_inspeciones_inspectores(miDtoDFT);
        }


        #region Listado de Expedientes Reportes SIPAS en SIAPI

        public DataSet Listado_Estatus_Resolucion_Expedientes(DtoBusqueda miDtoBusqueda)
        {
            return miConsultas.Listado_Estatus_Resolucion_Expedientes(miDtoBusqueda);
        }        
        
        public DataSet Listado_Resoluciones_Tipo(DtoBusqueda miDtoBusqueda)
        {
            return miConsultas.Listado_Resoluciones_Tipo(miDtoBusqueda);
        }

        public DataSet Listado_Impugnaciones(DtoBusqueda miDtoBusqueda)
        {
            return miConsultas.Listado_Impugnaciones(miDtoBusqueda);
        }


        public DataSet Listado_Etapa_Procesal(DtoBusqueda miDtoBusqueda)
        {
            return miConsultas.Listado_Etapa_Procesal(miDtoBusqueda);
        }        
        
        public DataSet Listado_Remitidos_Autoridad_Fiscal(DtoBusqueda miDtoBusqueda)
        {
            return miConsultas.Listado_Remitidos_Autoridad_Fiscal(miDtoBusqueda);
        }        
        
        public DataSet Tablero_Front_Resolucion_Por_Expedientes(DtoBusqueda miDtoBusqueda)
        {
            return miConsultas.Tablero_Front_Resolucion_Por_Expedientes(miDtoBusqueda);
        }

        



        #endregion

        public DataSet Obtener_Insertar_InformacionMetadatos(DtoInfoMetadato dtoInfoMetadato, string sentencia)
        {
            return miAgregar.InformacionMetadatos(dtoInfoMetadato, sentencia);
        }
        public DataSet Insertar_Actualizar_FirmaDigital(DtoFirmaDigital dtoFirmaDigital, string sentencia)
        {
            return miAgregar.DocumentosFirmaDigital(dtoFirmaDigital, sentencia);
        }

        public DataSet Obtener_Resultado_EliminarMotivoInspeccion(int motivo_id) {
            return miEliminar.Obtener_Resultado_EliminarMotivoInspeccion(motivo_id);
        }

        public DataSet Documentos_Firmantes_Bandeja(DtoFirmantesDoc dtoFirmantesDoc, string sentencia)
        {
            return miAgregar.DocumentosFirmantesBandeja(dtoFirmantesDoc, sentencia);
        }

        public int Dashboard_Agregar(string sentencia, string filtro,string periodo, DateTime inicio, DateTime final, string estatus, int core_id, string doc_url, int notificacion, string tipo_documento, string cur_cve_ur)
        {
            return miAgregar.Dashboard_Agregar(sentencia, filtro, periodo, inicio, final, estatus, core_id, doc_url, notificacion, tipo_documento, cur_cve_ur);
        }

        public DataSet Dashboard_Obtener(int core_usuario_id)
        {
            return miConsultas.Dashboard_Obtener(core_usuario_id);
        }

        public void Dashboard_Actualizar(int dashboard_historico_id, int core_id, string sentencia, string doc_url = "", string estatus = "", int notificacion = -1)
        {
            miConsultas.Dashboard_Actualizar(dashboard_historico_id, core_id, sentencia,doc_url, estatus, notificacion);
        }

        public DataSet ReporteDashboard_Obtener(int sys_fec_insert,int in_fec_inspeccion,int in_fec_emision, int sys_fec_insert_doc, String fec_inicio, String fec_final, string consulta, int cur_cve_ur = -1) 
        { 
            return miConsultas.ReporteDashboard_Obtener(sys_fec_insert, in_fec_inspeccion, in_fec_emision, sys_fec_insert_doc, fec_inicio, fec_final, consulta, cur_cve_ur);
        }
        public List<DtoDashboard> Reporte_Dashboard_Obtener(int sys_fec_insert, int in_fec_inspeccion, int in_fec_emision, int sys_fec_insert_doc, String fec_inicio, String fec_final, string consulta, int cur_cve_ur = -1)
        {
            return miConsultas.Reporte_Dashboard_Obtener(sys_fec_insert, in_fec_inspeccion, in_fec_emision, sys_fec_insert_doc, fec_inicio, fec_final, consulta, cur_cve_ur);
        }


        public void DML_Borrado_Desahogo(string sentencia, int desahogo_id)
        {
            miConsultas.DML_Borrado_Desahogo(sentencia, desahogo_id);
        }

        public void Borrado_Medidas_PorInformeComision(int desahogo_id)
        {
            miConsultas.Borrado_Medidas_PorInformeComision(desahogo_id);
        }

        

        #region Consultas para servicios SIPAS 3

        public DataSet AutoridadesTurnan_Obtener(int cve_edorep, int cve_ur, int estatus = -1)
        {
            return miConsultas.AutoridadesTurnan_Obtener(cve_edorep, cve_ur, estatus);
        }

        #endregion

        #region Sidil
        public DataSet generarListadoCentrosTrabajos(string ids)
        {
           return miConsultas.consultarListadoIdsCentrosTrabajo(ids);
        }

        public DataSet programarColectivoInspecciones(DtoColectivoInspecciones dtoColectivoInspecciones, string sentencia)
        {
            return miConsultas.colectivoInspecciones(dtoColectivoInspecciones, sentencia);
        }
        public DataSet consultaListadoCargasColectivas(int usuario_id)
        {
            return miConsultas.consultaListadoCargasColectivas(usuario_id);
        }

        public DataSet obtenerInspeccionesColectivasSinConcluir(int colectivo_id)
        {
            return miConsultas.inspeccionesColectivasSinConcluir(colectivo_id);
        }
        #endregion

    }
}
