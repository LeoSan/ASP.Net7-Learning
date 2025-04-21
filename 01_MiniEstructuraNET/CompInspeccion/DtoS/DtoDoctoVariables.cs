using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDoctoVariables
    {
          public int Tipo_Documento = -1;
          public int DocumentoID = -1;
          public String Ur = "";
          public String No_Expediente = "";
          public String Subtipo_Actuacion = "";
          public String Materia = "";
          public String Cargo = "";
          public String Firmante = "";
          public String Fecha_Documento  ="";
          public String Telefonos = ""; 
          public String Domicilio = "";
          public String Empresa = "";
          public String Ncur = "";
          public String Ubicacion_Ur = "";
          public String  Fecha_Inspeccion = "";
          public String  Hora_inspeccion = "";
          public String Año = "";
          public String Credencial = "";
          public String Notificador ="";
          public String rama_constitucion = "";
          public String  rama_lft="";
         public String tins_tipo_542_lft="";
         public String atribuciones_541_lft="";
        public String atribuciones_art9_rgiasvll="";
        public String asesoria_art10_rgiasvll="";
        public String requisitos_rgiasvll="";
        public String motivo_rgiasvll="";
        public String fd_designacion_rgiasvll="";
        public String circu_reglamento="";
        public String circu_acuerdo="";
        public String no_emplazamiento="";
        public String fecha_emplazamiento="";
        public String fec_notif_emplazamiento="";
        public String equipo="";
        public String num_control="";
        public String tipo_aviso="";
        public String folio="";
        public String medio_informacion="";
        public String acci_medio_informacion="";
        public String inminente_peligro_medio_info="";
        public String tipo_autorizacion="";
        public String periodo_inicio="";
        public String periodo_termino="";
        public String empresa_que_se_visita="";
        public String fec_autorizacion_provisional="";
        public String pruebas="";
        public String Empresa2 = "";
        public String in_req_documentos_inicio = "";
        public String in_req_documentos_termino = "";
        public String motivo_actuacion = "";
        public String dato_adicional_motivo = "";

        public string lugar_inspeccion = "";
        public string entidad_inspeccion = "";
        public string ur_firmante = "";
        public string motivo_informe_comision = "";
        public string nombre_representante_empresa = "";
        public string tipo_representante_empresa = "";
        public string caracteres_autenticidad = "";
        public string empresa2 = "";
        public string domicilio2 = "";
        public string forma_constatacion = "";
        public string fecha_notificacion="";
        public string nombre_persona_notificada = "";
        public string calidad_persona_notificada = "";
        public string motivo_no_entregada = "";
        public string puesto_representante_empresa = "";
        public string empresa_contratista = "";
        public string contrato_prestacion_servicios = "";
        public string media_filiacion = "";
        public string hora_cierre = "";


        public string fecha_escrito_ampliacion = "";
        public string numerales_medidas = "";
        public string motivo_ampliacion = "";
        public string otorgar_negar = "";
        public string rubrica = "";
        public string noaa= "";

        public string nombre_comercial = "";
        public void Agregar()
        {
            ComponentInsp miComponente = new ComponentInsp();
            miComponente.DoctoVariables_Agregar(this);
        }

    }
}
