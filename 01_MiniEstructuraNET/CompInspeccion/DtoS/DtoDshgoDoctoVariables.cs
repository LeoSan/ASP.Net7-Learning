using System;
using System.Collections.Generic;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoDoctoVariables
    {
            public int DshgoDocumentoID = -1;
            public string Ur = "";
            public string No_Expediente = "";
            public string Subtipo_Actuacion = "";
            public string Materia = "";
            public string Cargo = "";
            public string Domicilio_Ur = "";
            public string Firmante = "";
            public string Fecha_Documento = "";
            public string Telefonos = "";
            public string Domicilio = "";
            public string Empresa = "";
            public string Ncur = "";
            public string Ubicacion_Ur = "";
            public string Fecha_Inspeccion = "";
            public string Hora_inspeccion = "";
            public string Año = "";
            public string Credencial = "";
            public string Notificador = "";
            public string LUGAR_INSPECCION = "";
            public string ENTIDAD_INSPECCION = "";
            public string HORAINICIO = "";
            public string FECHAINICIO = "";
            public string UR_FIRMANTE = "";
            public string TIPO_CENTRO_CIERRE = "";
            public string EMPRESA2 = "";
            public string DOMICILIO2 = "";
            public string FORMA_CONSTATACION_INSPECCION = "";
            public string TIPO_REPRESENTANTE_EMPRESA = "";
            public string HORA_CIERRE  = "";
            public string FECHA_CIERRE   = "";
            public string NOMBRE_REPRESENTANTE_EMPRESA  = "";
            public string NOMBRE_REPRESENTANTE_TRABAJADORES  = "";
            public string PUESTO_REPRESENTANTE_TRABAJADORES = "";
            public string TIPO_REPRESENTANTE_TRABAJADORES  = "";
            public string REPRESENTANTE_EMPRESA_COMISION = "";
            public string REPRESENTANTE_TRABAJADORES_COMISION  = "";
            public string MOTIVO_INFORME = "";
            public string caracteres_autenticidad = "";

            //las variables de los parrafos
            public string rama_constitucion = "";
            public string rama_lft = "";
            public string tins_tipo_542_lft = "";
            public string motivo_rgiasvll = "";
            public string fd_designacion_rgiasvll = "";
            public string circu_reglamento = "";
            public string circu_acuerdo = "";
            public string equipo = "";
            public string num_control = "";
            public string tipo_aviso = "";
            public string folio = "";
            public string medio_informacion = "";
            public string fec_autorizacion_provisional = "";
            public string pruebas = "";
            public string atribuciones_541_lft = "";
            public string atribuciones_art9_rgiasvll = "";
            public string asesoria_art10_rgiasvll = "";
            public string requisitos_rgiasvll = "";
            public string no_emplazamiento = "";
            public string fecha_emplazamiento = "";
            public string fec_notif_emplazamiento = "";
            public string acci_medio_informacion = "";
            public string inminente_peligro_medio_info = "";
            public string tipo_autorizacion = "";
            public string periodo_inicio = "";
            public string periodo_termino = "";
            public string empresa_que_se_visita = "";
            public string motivo_actuacion = "";
            public string dato_adicional_motivo = "";

            //variables de los parrafos nuevos
            public string fecha_notificacion="";
            public string nombre_persona_notificada="";
            public string calidad_persona_notificada="";
            public string motivo_no_entregada="";
            public string puesto_representante_empresa="";
            public string empresa_contratista="";
            public string contrato_prestacion_servicios="";
            public string media_filiacion="";
            public string nombres_inspectores="";
            public string contrasena = "";
            //variables de acta
            public string  RFC   = "";
			public string  NOMBRE_COMERCIAL = "";
			public string  DOMICILIO3 = "";
			public string  LATITUD = "";
			public string  LONGITUD = "";
			public string  TELEFONOS2 = "";
			public string  FAX = "";
			public string  CORREO_ELECTRONICO = "";
			public string  DOMICILIO_FISCAL = "";
			public string  ESQUEMA = "";
			public string  REGISTRO_PATRONAL = "";
			public string  CLASE_RIESGO = "";
			public string  PRIMA_RIESGO = "";
			public string  ACTA_NO_ESCRITURA_PUBLICA = "";
			public string  ACTA_FECHA_EMISION = "";
			public string  ACTA_NOMBRE_NOTARIO = "";
			public string  ACTA_NO_NOTARIO = "";
			public string  OBJETO_SOCIAL = "";
			public string  ACTA_ENTIDAD_FEDERATIVA_NOTARIO = "";
			public string  ACTIVIDAD_CENTRO_DE_TRABAJO = "";
			public string  ACTIVIDAD_SCIAN = "";
			public string  TIPO_ESTABLECIMIENTO = "";
			public string  M2_CONSTRUCCION = "";
			public string  M2_SUPERFICIE = "";
			public string  TIPO_CONTRATACION = "";
			public string  FECHA_DE_CELEBRACION_COLECTIVO = "";
			public string  FECHA_DE_CELEBRACION_LEY = "";
			public string  CAPITAL_CONTABLE = "";
			public string  SIND = "";
			public string  SIND_H = "";
			public string  SIND_M = "";
			public string  PLANTA = "";
			public string  PLANTA_H = "";
			public string  PLANTA_M = "";
			public string  EVENT = "";
			public string  EVENT_H = "";
			public string  EVENT_M = "";
			public string  NO_SIND = "";
			public string  NO_SIND_H = "";
			public string  NO_SIND_M = "";
			public string  OBRA = "";
			public string  OBRA_H = "";
			public string  OBRA_M = "";
			public string  TIEMPO_D = "";
			public string  TIEMPO_D_H = "";
            public string  TIEMPO_D_M = "";
            public string  TIEMPO_I = "";
			public string  TIEMPO_I_H = "";
			public string  TIEMPO_I_M = "";
			public string  SUBTOTAL = "";
			public string  SUBTOTAL_H = "";
			public string  SUBTOTAL_M = "";
			public string  TERCERO = "";
			public string  TERCERO_H = "";
			public string  TERCERO_M = "";
			public string  TOTAL = "";
			public string  TOTAL_H = "";
			public string  TOTAL_M = "";
			public string  DISC = "";
			public string  DISC_H = "";
			public string  DISC_M = "";
			public string  MEN_14 = "";
			public string  MEN_14_H = "";
			public string  MEN_14_M = "";
			public string  v14_16_PERMISO = "";
			public string  v14_16_PERMISO_H = "";
			public string  v14_16_PERMISO_M = "";
			public string  v14_16_S_PERMISO = "";
			public string  v14_16_S_PERMISO_H = "";
			public string  v14_16_S_PERMISO_M = "";
			public string  v16_18 = "";
			public string  v16_18_H = "";
			public string  v16_18_M = "";
			public string  LACTANCIA = "";
			public string  GESTACION = "";
            public string  CONTRATISTA_SI_NO = "";
            public string  dsol_razon_social = "";
            public string  cae_descripcion = "";
            public string  dsol_domicilio = "";
            public string  dsol_imss_registro = "";
            public string  dsol_num_hombres = "";
            public string  dsol_num_mujeres = "";
            public string  dsol_num_total = "";
            public string  motivo_ausencia_rep_trab ="";
            public string  MOTIVO_NEGATIVA = "";

            public string FECHA_CIERRE_PARCIAL = "";
            public string HORA_CIERRE_PARCIAL = "";
            public string FECHA_REINICIO = "";
            public string HORA_REINICIO = "";
            public string DSHGO_MOTIVO_PARCIAL = "";
        

            public string FECHA_CIERRE_PARCIAL_2 = "";
            public string HORA_CIERRE_PARCIAL_2 = "";
            public string FECHA_REINICIO_2 = "";
            public string HORA_REINICIO_2 = "";
            public string DSHGO_MOTIVO_PARCIAL_2 = "";
    
            public string MOTIVO_TESTIGO_2 = "";
            public string TIPO_COMISION = "";
            public string MOTIVO_AUSENCIA_COMISION = "";
            public string NO_CUENTA_CON_TRABAJADORES = "";

            public string domicilio3 = "";
            public string USUARIO_ACTUAL = "";

        
            public void Agregar()
        {
            ComponentInsp miComponente = new ComponentInsp();
            miComponente.DshgoDoctoVariables_Agregar(this);
        }
    }
}
