using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CompInspeccion.DtoS;

namespace CompInspeccion
{
    class Agregar
    {
        internal SqlConnection conexion;

        public void AgregarAbrirConexion()
        {
            conexion = new SqlConnection(Constantes.StrCon);
            conexion.Open();
        }

        public void AgregarCerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
        }

        
        public int DocumentoAgregarActualizar2(DtoDocumento dtoDocto)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Documento_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                // con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = dtoDocto.inspeccion_id;
                if (dtoDocto.documento_id!= -1)
                    con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                if (dtoDocto.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = dtoDocto.inspector_id;
                if (dtoDocto.tipo_documento_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.tipo_documento_id;
                if (dtoDocto.doc_url_archivo != "")
                    con.ObjCommand.Parameters.Add("@doc_url_archivo", SqlDbType.VarChar).Value = dtoDocto.doc_url_archivo;
                if (dtoDocto.doc_esta_asignado != -1)
                    con.ObjCommand.Parameters.Add("@doc_esta_asignado", SqlDbType.TinyInt).Value = dtoDocto.doc_esta_asignado;
                if (dtoDocto.doc_fec_documento != "")
                    con.ObjCommand.Parameters.Add("@doc_fec_documento", SqlDbType.DateTime).Value = dtoDocto.doc_fec_documento;
                if (dtoDocto.doc_forma_entrega != -1)
                    con.ObjCommand.Parameters.Add("@doc_forma_entrega", SqlDbType.TinyInt).Value = dtoDocto.doc_forma_entrega;
                if (dtoDocto.doc_fec_limite_entrega != "")
                    con.ObjCommand.Parameters.Add("@doc_fec_limite_entrega", SqlDbType.DateTime).Value = dtoDocto.doc_fec_limite_entrega;
                if (dtoDocto.doc_fec_entrega_programada != "")
                    con.ObjCommand.Parameters.Add("@doc_fec_entrega_programada", SqlDbType.DateTime).Value = dtoDocto.doc_fec_entrega_programada;
                if (dtoDocto.doc_observaciones != "")
                    con.ObjCommand.Parameters.Add("@doc_observaciones", SqlDbType.VarChar).Value = dtoDocto.doc_observaciones;
                if (dtoDocto.doc_estatus != -1)
                    con.ObjCommand.Parameters.Add("@doc_estatus", SqlDbType.TinyInt).Value = dtoDocto.doc_estatus;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoDocto.sys_usr;

                if (dtoDocto.doc_firman_titulares != -1)
                    con.ObjCommand.Parameters.Add("@doc_firman_titulares", SqlDbType.Int).Value = dtoDocto.doc_firman_titulares;
                if (dtoDocto.doc_nombre_firmante != "")
                    con.ObjCommand.Parameters.Add("@doc_nombre_firmante", SqlDbType.VarChar).Value = dtoDocto.doc_nombre_firmante;
                if (dtoDocto.doc_cargo_firmante != "")
                    con.ObjCommand.Parameters.Add("@doc_cargo_firmante", SqlDbType.VarChar).Value = dtoDocto.doc_cargo_firmante;
                if (dtoDocto.documento_firmado != -1)
                    con.ObjCommand.Parameters.Add("@documento_firmado", SqlDbType.VarChar).Value = dtoDocto.documento_firmado;

                if (dtoDocto.doc_url_archivo_sin_firmas != "")
                    con.ObjCommand.Parameters.Add("@doc_url_archivo_sin_firmas", SqlDbType.VarChar).Value = dtoDocto.doc_url_archivo_sin_firmas;



                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int NotificacionAgregarActualizar(DtoNotificacion dtoNotif)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Notificacion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@Notificacion_id", SqlDbType.Int).Value = dtoNotif.notificacion_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoNotif.tipo_documento_id;
                if (dtoNotif.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = dtoNotif.inspector_id;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = dtoNotif.inspeccion_id;
                if (dtoNotif.notif_motivo_no_entrega_id != -1)
                    con.ObjCommand.Parameters.Add("@notif_motivo_no_entrega_id", SqlDbType.Int).Value = dtoNotif.notif_motivo_no_entrega_id;
                if (dtoNotif.notif_forma_constatacion_id != -1)
                    con.ObjCommand.Parameters.Add("@notif_forma_constatacion_id", SqlDbType.Int).Value = dtoNotif.notif_forma_constatacion_id;
                if (dtoNotif.notif_estatus_asignacion != -1)
                    con.ObjCommand.Parameters.Add("@notif_estatus_asignacion", SqlDbType.TinyInt).Value = dtoNotif.notif_estatus_asignacion;
                if (dtoNotif.notif_forma_entrega != -1)
                    con.ObjCommand.Parameters.Add("@notif_forma_entrega", SqlDbType.TinyInt).Value = dtoNotif.notif_forma_entrega;
                if (dtoNotif.notif_forma_envio != "")
                    con.ObjCommand.Parameters.Add("@notif_forma_envio", SqlDbType.VarChar).Value = dtoNotif.notif_forma_envio;
                if (dtoNotif.notif_fec_limite_entrega != "")
                    con.ObjCommand.Parameters.Add("@notif_fec_limite_entrega", SqlDbType.DateTime).Value = dtoNotif.notif_fec_limite_entrega;
                if (dtoNotif.notif_hora_limite_recepcion != "")
                    con.ObjCommand.Parameters.Add("@notif_hora_limite_recepcion", SqlDbType.Char).Value = dtoNotif.notif_hora_limite_recepcion;
                if (dtoNotif.notif_notificacion_personal != -1)
                    con.ObjCommand.Parameters.Add("@notif_notificacion_personal", SqlDbType.TinyInt).Value = dtoNotif.notif_notificacion_personal;
                if (dtoNotif.notif_fec_envio != "")
                    con.ObjCommand.Parameters.Add("@notif_fec_envio", SqlDbType.DateTime).Value = dtoNotif.notif_fec_envio;
                if (dtoNotif.notif_num_guia != "")
                    con.ObjCommand.Parameters.Add("@notif_num_guia", SqlDbType.VarChar).Value = dtoNotif.notif_num_guia;
                if (dtoNotif.notif_fec_entrega_programada != "")
                    con.ObjCommand.Parameters.Add("@notif_fec_entrega_programada", SqlDbType.DateTime).Value = dtoNotif.notif_fec_entrega_programada;
                if (dtoNotif.notif_estatus_entrega != -1)
                    con.ObjCommand.Parameters.Add("@notif_estatus_entrega", SqlDbType.TinyInt).Value = dtoNotif.notif_estatus_entrega;
                if (dtoNotif.notif_se_recibio != -1)
                    con.ObjCommand.Parameters.Add("@notif_se_recibio", SqlDbType.TinyInt).Value = dtoNotif.notif_se_recibio;
                if (dtoNotif.notif_quedo_pegado != -1)
                    con.ObjCommand.Parameters.Add("@notif_quedo_pegado", SqlDbType.TinyInt).Value = dtoNotif.notif_quedo_pegado;
                if (dtoNotif.notif_otro_motivo != "")
                    con.ObjCommand.Parameters.Add("@notif_otro_motivo", SqlDbType.VarChar).Value = dtoNotif.notif_otro_motivo;
                if (dtoNotif.notif_fec_entrega != "")
                    con.ObjCommand.Parameters.Add("@notif_fec_entrega", SqlDbType.DateTime).Value = dtoNotif.notif_fec_entrega;
                if (dtoNotif.notif_nombre_recibio != "")
                    con.ObjCommand.Parameters.Add("@notif_nombre_recibio", SqlDbType.VarChar).Value = dtoNotif.notif_nombre_recibio;
                if (dtoNotif.notif_dijo_ser != "")
                    con.ObjCommand.Parameters.Add("@notif_dijo_ser", SqlDbType.VarChar).Value = dtoNotif.notif_dijo_ser;
                if (dtoNotif.notif_observaciones != "")
                    con.ObjCommand.Parameters.Add("@notif_observaciones", SqlDbType.VarChar).Value = dtoNotif.notif_observaciones;
                con.ObjCommand.Parameters.Add("@sys_usr ", SqlDbType.VarChar).Value = dtoNotif.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

                //con.ObjCommand.Connection.Open();
                //con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        //*******************************************************************
        public int NotifOtraActuacionAgregarActualizar(DtoNotifOtraActuacion dtoNotif)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_NotifOtraActuacion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (dtoNotif.notif_otra_actuacion_id != -1)
                    con.ObjCommand.Parameters.Add("@notif_otra_actuacion_id", SqlDbType.Int).Value = dtoNotif.notif_otra_actuacion_id;
                if (dtoNotif.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = dtoNotif.inspector_id;
                if (dtoNotif.cve_ur_solicita != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur_solicita", SqlDbType.Int).Value = dtoNotif.cve_ur_solicita;
                if (dtoNotif.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = dtoNotif.cve_ur;
                if (dtoNotif.notif_motivo_no_entrega_id != -1)
                    con.ObjCommand.Parameters.Add("@notif_motivo_no_entrega_id", SqlDbType.SmallInt).Value = dtoNotif.notif_motivo_no_entrega_id;
                if (dtoNotif.notif_forma_constatacion_id != -1)
                    con.ObjCommand.Parameters.Add("@notif_forma_constatacion_id", SqlDbType.SmallInt).Value = dtoNotif.notif_forma_constatacion_id;

                if (!String.IsNullOrEmpty(dtoNotif.notifoa_ur_especifica))
                    con.ObjCommand.Parameters.Add("@notifoa_ur_especifica", SqlDbType.VarChar).Value = dtoNotif.notifoa_ur_especifica;

                if (dtoNotif.notifoa_cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@notifoa_cve_edorep", SqlDbType.SmallInt).Value = dtoNotif.notifoa_cve_edorep;
                if (dtoNotif.notifoa_cve_municipio != -1)
                    con.ObjCommand.Parameters.Add("@notifoa_cve_municipio", SqlDbType.SmallInt).Value = dtoNotif.notifoa_cve_municipio;

                if (!String.IsNullOrEmpty(dtoNotif.notifoa_razon_social))
                    con.ObjCommand.Parameters.Add("@notifoa_razon_social", SqlDbType.VarChar).Value = dtoNotif.notifoa_razon_social;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_domicilio))
                    con.ObjCommand.Parameters.Add("@notifoa_domicilio", SqlDbType.VarChar).Value = dtoNotif.notifoa_domicilio;

                if (dtoNotif.notifoa_estatus_asignacion != -1)
                    con.ObjCommand.Parameters.Add("@notifoa_estatus_asignacion", SqlDbType.TinyInt).Value = dtoNotif.notifoa_estatus_asignacion;

                if (!String.IsNullOrEmpty(dtoNotif.notifoa_fec_solicitud))
                    con.ObjCommand.Parameters.Add("@notifoa_fec_solicitud", SqlDbType.DateTime).Value = dtoNotif.notifoa_fec_solicitud;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_num_solicitud))
                    con.ObjCommand.Parameters.Add("@notifoa_num_solicitud", SqlDbType.VarChar).Value = dtoNotif.notifoa_num_solicitud;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_tipo_documento))
                    con.ObjCommand.Parameters.Add("@notifoa_tipo_documento", SqlDbType.VarChar).Value = dtoNotif.notifoa_tipo_documento;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_cp))
                    con.ObjCommand.Parameters.Add("@notifoa_cp", SqlDbType.Char).Value = dtoNotif.notifoa_cp;

                if (dtoNotif.notifoa_forma_entrega != -1)
                    con.ObjCommand.Parameters.Add("@notifoa_forma_entrega", SqlDbType.TinyInt).Value = dtoNotif.notifoa_forma_entrega;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_forma_envio))
                    con.ObjCommand.Parameters.Add("@notifoa_forma_envio", SqlDbType.VarChar).Value = dtoNotif.notifoa_forma_envio;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_fec_limite_entrega))
                    con.ObjCommand.Parameters.Add("@notifoa_fec_limite_entrega", SqlDbType.DateTime).Value = dtoNotif.notifoa_fec_limite_entrega;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_hora_limite_recepcion))
                    con.ObjCommand.Parameters.Add("@notifoa_hora_limite_recepcion", SqlDbType.Char).Value = dtoNotif.notifoa_hora_limite_recepcion;

                if (dtoNotif.notifoa_notificacion_personal != -1)
                    con.ObjCommand.Parameters.Add("@notifoa_notificacion_personal", SqlDbType.TinyInt).Value = dtoNotif.notifoa_notificacion_personal;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_fec_envio))
                    con.ObjCommand.Parameters.Add("@notifoa_fec_envio", SqlDbType.DateTime).Value = dtoNotif.notifoa_fec_envio;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_num_guia))
                    con.ObjCommand.Parameters.Add("@notifoa_num_guia", SqlDbType.VarChar).Value = dtoNotif.notifoa_num_guia;

                if (dtoNotif.notifoa_estatus_entrega != -1)
                    con.ObjCommand.Parameters.Add("@notifoa_estatus_entrega", SqlDbType.TinyInt).Value = dtoNotif.notifoa_estatus_entrega;
                if (dtoNotif.notifoa_se_recibio != -1)
                    con.ObjCommand.Parameters.Add("@notifoa_se_recibio", SqlDbType.TinyInt).Value = dtoNotif.notifoa_se_recibio;
                if (dtoNotif.notifoa_quedo_pegado != -1)
                    con.ObjCommand.Parameters.Add("@notifoa_quedo_pegado", SqlDbType.TinyInt).Value = dtoNotif.notifoa_quedo_pegado;

                if (!String.IsNullOrEmpty(dtoNotif.notifoa_otro_motivo))
                    con.ObjCommand.Parameters.Add("@notifoa_otro_motivo", SqlDbType.VarChar).Value = dtoNotif.notifoa_otro_motivo;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_fec_entrega))
                    con.ObjCommand.Parameters.Add("@notifoa_fec_entrega", SqlDbType.DateTime).Value = dtoNotif.notifoa_fec_entrega;

                if (!String.IsNullOrEmpty(dtoNotif.notifoa_nombre_recibio))
                    con.ObjCommand.Parameters.Add("@notifoa_nombre_recibio", SqlDbType.VarChar).Value = dtoNotif.notifoa_nombre_recibio;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_dijo_ser))
                    con.ObjCommand.Parameters.Add("@notifoa_dijo_ser", SqlDbType.VarChar).Value = dtoNotif.notifoa_dijo_ser;
                if (!String.IsNullOrEmpty(dtoNotif.notifoa_observaciones))
                    con.ObjCommand.Parameters.Add("@notifoa_observaciones", SqlDbType.VarChar).Value = dtoNotif.notifoa_observaciones;
                con.ObjCommand.Parameters.Add("@sys_usr ", SqlDbType.VarChar).Value = dtoNotif.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


                return (int)vReturn.Value;
                //**


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoVariable_AgregarActualizar(DtoDoctoVariable dtoDocto)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoVariable_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_variable_id", SqlDbType.Int).Value = dtoDocto.docto_variable_id;
                con.ObjCommand.Parameters.Add("@var_variable", SqlDbType.VarChar).Value = dtoDocto.var_variable;
                con.ObjCommand.Parameters.Add("@var_descripcion", SqlDbType.VarChar).Value = dtoDocto.var_descripcion;
                con.ObjCommand.Parameters.Add("@var_tipo_variable", SqlDbType.Int).Value = dtoDocto.var_tipo_variable;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoVariables_Agregar(DtoDoctoVariables DtoDoctoVariables)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoVariables_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.CommandTimeout = 5000;

                con.ObjCommand.Parameters.Add("@DocumentoID", SqlDbType.Int).Value = DtoDoctoVariables.DocumentoID;
                con.ObjCommand.Parameters.Add("@Tipo_Documento", SqlDbType.Int).Value = DtoDoctoVariables.Tipo_Documento;

                if (DtoDoctoVariables.Ur != "")
                    con.ObjCommand.Parameters.Add("@Ur", SqlDbType.VarChar).Value = DtoDoctoVariables.Ur;
                if (DtoDoctoVariables.No_Expediente != "")
                    con.ObjCommand.Parameters.Add("@No_Expediente", SqlDbType.VarChar).Value = DtoDoctoVariables.No_Expediente;
                if (DtoDoctoVariables.Subtipo_Actuacion != "")
                    con.ObjCommand.Parameters.Add("@Subtipo_Actuacion", SqlDbType.VarChar).Value = DtoDoctoVariables.Subtipo_Actuacion;
                if (DtoDoctoVariables.Materia != "")
                    con.ObjCommand.Parameters.Add("@Materia", SqlDbType.VarChar).Value = DtoDoctoVariables.Materia;
                if (DtoDoctoVariables.Cargo != "")
                    con.ObjCommand.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = DtoDoctoVariables.Cargo;
                if (DtoDoctoVariables.Firmante != "")
                    con.ObjCommand.Parameters.Add("@Firmante", SqlDbType.VarChar).Value = DtoDoctoVariables.Firmante;
                if (DtoDoctoVariables.Fecha_Documento != "")
                    con.ObjCommand.Parameters.Add("@Fecha_Documento", SqlDbType.VarChar).Value = DtoDoctoVariables.Fecha_Documento;
                if (DtoDoctoVariables.Telefonos != "")
                    con.ObjCommand.Parameters.Add("@Telefonos", SqlDbType.VarChar).Value = DtoDoctoVariables.Telefonos;
                if (DtoDoctoVariables.Domicilio != "")
                    con.ObjCommand.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = DtoDoctoVariables.Domicilio;
                if (DtoDoctoVariables.Empresa != "")
                    con.ObjCommand.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = DtoDoctoVariables.Empresa;
                if (DtoDoctoVariables.Ncur != "")
                    con.ObjCommand.Parameters.Add("@Ncur", SqlDbType.VarChar).Value = DtoDoctoVariables.Ncur;
                if (DtoDoctoVariables.Ubicacion_Ur != "")
                    con.ObjCommand.Parameters.Add("@Ubicacion_Ur", SqlDbType.VarChar).Value = DtoDoctoVariables.Ubicacion_Ur;
                if (DtoDoctoVariables.Fecha_Inspeccion != "")
                    con.ObjCommand.Parameters.Add("@Fecha_Inspeccion", SqlDbType.VarChar).Value = DtoDoctoVariables.Fecha_Inspeccion;
                if (DtoDoctoVariables.Hora_inspeccion != "")
                    con.ObjCommand.Parameters.Add("@Hora_inspeccion", SqlDbType.VarChar).Value = DtoDoctoVariables.Hora_inspeccion;
                if (DtoDoctoVariables.Año != "")
                    con.ObjCommand.Parameters.Add("@Año", SqlDbType.VarChar).Value = DtoDoctoVariables.Año;
                if (DtoDoctoVariables.Credencial != "")
                    con.ObjCommand.Parameters.Add("@Credencial", SqlDbType.VarChar).Value = DtoDoctoVariables.Credencial;
                if (DtoDoctoVariables.Notificador != "")
                    con.ObjCommand.Parameters.Add("@Notificador", SqlDbType.VarChar).Value = DtoDoctoVariables.Notificador;

                if (DtoDoctoVariables.rama_constitucion != "")
                    con.ObjCommand.Parameters.Add("@rama_constitucion", SqlDbType.VarChar).Value = DtoDoctoVariables.rama_constitucion;
                if (DtoDoctoVariables.rama_lft != "")
                    con.ObjCommand.Parameters.Add("@rama_lft", SqlDbType.VarChar).Value = DtoDoctoVariables.rama_lft;
                if (DtoDoctoVariables.tins_tipo_542_lft != "")
                    con.ObjCommand.Parameters.Add("@tins_tipo_542_lft", SqlDbType.VarChar).Value = DtoDoctoVariables.tins_tipo_542_lft;
                if (DtoDoctoVariables.motivo_rgiasvll != "")
                    con.ObjCommand.Parameters.Add("@motivo_rgiasvll", SqlDbType.VarChar).Value = DtoDoctoVariables.motivo_rgiasvll;
                if (DtoDoctoVariables.fd_designacion_rgiasvll != "")
                    con.ObjCommand.Parameters.Add("@fd_designacion_rgiasvll", SqlDbType.VarChar).Value = DtoDoctoVariables.fd_designacion_rgiasvll;
                if (DtoDoctoVariables.circu_reglamento != "")
                    con.ObjCommand.Parameters.Add("@circu_reglamento", SqlDbType.VarChar).Value = DtoDoctoVariables.circu_reglamento;
                if (DtoDoctoVariables.circu_acuerdo != "")
                    con.ObjCommand.Parameters.Add("@circu_acuerdo", SqlDbType.VarChar).Value = DtoDoctoVariables.circu_acuerdo;
                if (DtoDoctoVariables.equipo != "")
                    con.ObjCommand.Parameters.Add("@equipo", SqlDbType.VarChar).Value = DtoDoctoVariables.equipo;
                if (DtoDoctoVariables.num_control != "")
                    con.ObjCommand.Parameters.Add("@num_control", SqlDbType.VarChar).Value = DtoDoctoVariables.num_control;
                if (DtoDoctoVariables.tipo_aviso != "")
                    con.ObjCommand.Parameters.Add("@tipo_aviso", SqlDbType.VarChar).Value = DtoDoctoVariables.tipo_aviso;
                if (DtoDoctoVariables.folio != "")
                    con.ObjCommand.Parameters.Add("@folio", SqlDbType.VarChar).Value = DtoDoctoVariables.folio;
                if (DtoDoctoVariables.medio_informacion != "")
                    con.ObjCommand.Parameters.Add("@medio_informacion", SqlDbType.VarChar).Value = DtoDoctoVariables.medio_informacion;
                if (DtoDoctoVariables.fec_autorizacion_provisional != "")
                    con.ObjCommand.Parameters.Add("@fec_autorizacion_provisional", SqlDbType.VarChar).Value = DtoDoctoVariables.fec_autorizacion_provisional;
                if (DtoDoctoVariables.pruebas != "")
                    con.ObjCommand.Parameters.Add("@pruebas", SqlDbType.VarChar).Value = DtoDoctoVariables.pruebas;

                if (DtoDoctoVariables.atribuciones_541_lft != "")
                    con.ObjCommand.Parameters.Add("@atribuciones_541_lft", SqlDbType.VarChar).Value = DtoDoctoVariables.atribuciones_541_lft;
                if (DtoDoctoVariables.atribuciones_art9_rgiasvll != "")
                    con.ObjCommand.Parameters.Add("@atribuciones_art9_rgiasvll", SqlDbType.VarChar).Value = DtoDoctoVariables.atribuciones_art9_rgiasvll;
                if (DtoDoctoVariables.asesoria_art10_rgiasvll != "")
                    con.ObjCommand.Parameters.Add("@asesoria_art10_rgiasvll", SqlDbType.VarChar).Value = DtoDoctoVariables.asesoria_art10_rgiasvll;
                if (DtoDoctoVariables.requisitos_rgiasvll != "")
                    con.ObjCommand.Parameters.Add("@requisitos_rgiasvll", SqlDbType.VarChar).Value = DtoDoctoVariables.requisitos_rgiasvll;
                if (DtoDoctoVariables.no_emplazamiento != "")
                    con.ObjCommand.Parameters.Add("@no_emplazamiento", SqlDbType.VarChar).Value = DtoDoctoVariables.no_emplazamiento;
                if (DtoDoctoVariables.fecha_emplazamiento != "")
                    con.ObjCommand.Parameters.Add("@fecha_emplazamiento", SqlDbType.VarChar).Value = DtoDoctoVariables.fecha_emplazamiento;
                if (DtoDoctoVariables.fec_notif_emplazamiento != "")
                    con.ObjCommand.Parameters.Add("@fec_notif_emplazamiento", SqlDbType.VarChar).Value = DtoDoctoVariables.fec_notif_emplazamiento;
                if (DtoDoctoVariables.acci_medio_informacion != "")
                    con.ObjCommand.Parameters.Add("@acci_medio_informacion", SqlDbType.VarChar).Value = DtoDoctoVariables.acci_medio_informacion;
                if (DtoDoctoVariables.inminente_peligro_medio_info != "")
                    con.ObjCommand.Parameters.Add("@inminente_peligro_medio_info", SqlDbType.VarChar).Value = DtoDoctoVariables.inminente_peligro_medio_info;
                if (DtoDoctoVariables.tipo_autorizacion != "")
                    con.ObjCommand.Parameters.Add("@tipo_autorizacion", SqlDbType.VarChar).Value = DtoDoctoVariables.tipo_autorizacion;
                if (DtoDoctoVariables.periodo_inicio != "")
                    con.ObjCommand.Parameters.Add("@periodo_inicio", SqlDbType.VarChar).Value = DtoDoctoVariables.periodo_inicio;
                if (DtoDoctoVariables.periodo_termino != "")
                    con.ObjCommand.Parameters.Add("@periodo_termino", SqlDbType.VarChar).Value = DtoDoctoVariables.periodo_termino;
                if (DtoDoctoVariables.empresa_que_se_visita != "")
                    con.ObjCommand.Parameters.Add("@empresa_que_se_visita", SqlDbType.VarChar).Value = DtoDoctoVariables.empresa_que_se_visita;

                if (DtoDoctoVariables.motivo_actuacion != "")
                    con.ObjCommand.Parameters.Add("@motivo_actuacion", SqlDbType.VarChar).Value = DtoDoctoVariables.motivo_actuacion;
                if (DtoDoctoVariables.dato_adicional_motivo != "")
                    con.ObjCommand.Parameters.Add("@dato_adicional_motivo", SqlDbType.VarChar).Value = DtoDoctoVariables.dato_adicional_motivo;

                //las nuevas variables
                if (DtoDoctoVariables.rubrica != "")
                    con.ObjCommand.Parameters.Add("@rubrica", SqlDbType.VarChar).Value = DtoDoctoVariables.rubrica;
                if (DtoDoctoVariables.fecha_escrito_ampliacion != "")
                    con.ObjCommand.Parameters.Add("@fecha_escrito_ampliacion", SqlDbType.VarChar).Value = DtoDoctoVariables.fecha_escrito_ampliacion;
                if (DtoDoctoVariables.numerales_medidas != "")
                    con.ObjCommand.Parameters.Add("@numerales_medidas", SqlDbType.VarChar).Value = DtoDoctoVariables.numerales_medidas;
                if (DtoDoctoVariables.motivo_ampliacion != "")
                    con.ObjCommand.Parameters.Add("@motivo_ampliacion", SqlDbType.VarChar).Value = DtoDoctoVariables.motivo_ampliacion;
                if (DtoDoctoVariables.otorgar_negar != "")
                    con.ObjCommand.Parameters.Add("@otorgar_negar", SqlDbType.VarChar).Value = DtoDoctoVariables.otorgar_negar;

                if (DtoDoctoVariables.noaa != "")
                    con.ObjCommand.Parameters.Add("@noaa", SqlDbType.VarChar).Value = DtoDoctoVariables.noaa;
                if (DtoDoctoVariables.nombre_comercial != "")
                    con.ObjCommand.Parameters.Add("@nombre_comercial", SqlDbType.VarChar).Value = DtoDoctoVariables.nombre_comercial;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoValores_AgregarActualizar(DtoDoctoValores dtoDocto)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoVariable_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_valor_id", SqlDbType.Int).Value = dtoDocto.docto_valor_id;
                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@docto_variable_id", SqlDbType.Int).Value = dtoDocto.docto_variable_id;
                con.ObjCommand.Parameters.Add("@dv_valor", SqlDbType.VarChar).Value = dtoDocto.dv_valor;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int DoctoParrafo_AgregarActualizar(DtoDoctoParrafo dtoDoctoP)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = dtoDoctoP.docto_parrafo_id;
                con.ObjCommand.Parameters.Add("@dp_tipo_documento_id", SqlDbType.Int).Value = dtoDoctoP.dp_tipo_documento_id;
                con.ObjCommand.Parameters.Add("@dp_variable", SqlDbType.VarChar).Value = dtoDoctoP.dp_variable;
                if (dtoDoctoP.dp_tipo_parrafo > -1)
                    con.ObjCommand.Parameters.Add("@dp_tipo_parrafo", SqlDbType.Int).Value = dtoDoctoP.dp_tipo_parrafo;
                con.ObjCommand.Parameters.Add("@dp_cond_tipo", SqlDbType.Int).Value = dtoDoctoP.dp_cond_tipo;
                con.ObjCommand.Parameters.Add("@dp_cond_subtipo", SqlDbType.Int).Value = dtoDoctoP.dp_cond_subtipo;
                con.ObjCommand.Parameters.Add("@dp_cond_materia", SqlDbType.Int).Value = dtoDoctoP.dp_cond_materia;
                con.ObjCommand.Parameters.Add("@dp_cond_otra", SqlDbType.Int).Value = dtoDoctoP.dp_cond_otra;
                con.ObjCommand.Parameters.Add("@dp_condicion", SqlDbType.VarChar).Value = dtoDoctoP.dp_condicion;
                con.ObjCommand.Parameters.Add("@dp_estatus", SqlDbType.Int).Value = dtoDoctoP.dp_estatus;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoDoctoP.sys_usr;
                if (dtoDoctoP.dp_es_fundamento > -1)
                    con.ObjCommand.Parameters.Add("@dp_es_fundamento", SqlDbType.Int).Value = dtoDoctoP.dp_es_fundamento;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int SDoctoParrafo_AgregarActualizar(DtoDoctoParrafoSipas dtoParrafo)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SDoctoParrafo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoParrafo.s_docto_parrafo_id != -1)
                    con.ObjCommand.Parameters.Add("@s_docto_parrafo_id", SqlDbType.Int).Value = dtoParrafo.s_docto_parrafo_id;
                if (dtoParrafo.s_tipo_documento_id != -1)
                    con.ObjCommand.Parameters.Add("@s_tipo_documento_id", SqlDbType.Int).Value = dtoParrafo.s_tipo_documento_id;
                if (dtoParrafo.sdp_tipo_parrafo != -1)
                    con.ObjCommand.Parameters.Add("@sdp_tipo_parrafo", SqlDbType.Int).Value = dtoParrafo.sdp_tipo_parrafo;
                if (dtoParrafo.sdp_cond_comparecencia != -1)
                    con.ObjCommand.Parameters.Add("@sdp_cond_comparecencia", SqlDbType.Int).Value = dtoParrafo.sdp_cond_comparecencia;
                if (dtoParrafo.sdp_cond_materia != -1)
                    con.ObjCommand.Parameters.Add("@sdp_cond_materia", SqlDbType.Int).Value = dtoParrafo.sdp_cond_materia;
                if (dtoParrafo.sdp_cond_otra != -1)
                    con.ObjCommand.Parameters.Add("@sdp_cond_otra", SqlDbType.Int).Value = dtoParrafo.sdp_cond_otra;
                if (dtoParrafo.sdp_estatus != -1)
                    con.ObjCommand.Parameters.Add("@sdp_estatus", SqlDbType.Int).Value = dtoParrafo.sdp_estatus;

                if (!String.IsNullOrEmpty(dtoParrafo.sdp_variable))
                    con.ObjCommand.Parameters.Add("@sdp_variable", SqlDbType.VarChar).Value = dtoParrafo.sdp_variable;
                if (!String.IsNullOrEmpty(dtoParrafo.sdp_condicion))
                    con.ObjCommand.Parameters.Add("@sdp_condicion ", SqlDbType.VarChar).Value = dtoParrafo.sdp_condicion;
                if (!String.IsNullOrEmpty(dtoParrafo.sys_usr_insert))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoParrafo.sys_usr_insert;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int DoctoParrafoTexto_AgregarActualizar(DtoDoctoParrafoTexto dtoDocto)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoTexto_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_texto_id;
                if (dtoDocto.docto_parrafo_id != -1)
                    con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_id;
                if (dtoDocto.@dpt_consecutivo != -1)
                    con.ObjCommand.Parameters.Add("@dpt_consecutivo", SqlDbType.Int).Value = dtoDocto.dpt_consecutivo;
                con.ObjCommand.Parameters.Add("@dpt_parrafo", SqlDbType.VarChar).Value = dtoDocto.dpt_parrafo;
                con.ObjCommand.Parameters.Add("@dpt_condicion", SqlDbType.VarChar).Value = dtoDocto.dpt_condicion;
                if (dtoDocto.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = dtoDocto.cve_ur;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int SDoctoParrafoTexto_AgregarActualizar(DtoDoctoParrafoTextoSipas dtoParrafo)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SDoctoParrafoTexto_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoParrafo.s_docto_parrafo_texto_id != -1)
                    con.ObjCommand.Parameters.Add("@s_docto_parrafo_texto_id", SqlDbType.Int).Value = dtoParrafo.s_docto_parrafo_texto_id;
                if (dtoParrafo.s_docto_parrafo_id != -1)
                    con.ObjCommand.Parameters.Add("@s_docto_parrafo_id", SqlDbType.Int).Value = dtoParrafo.s_docto_parrafo_id;
                if (dtoParrafo.dpt_consecutivo != -1)
                    con.ObjCommand.Parameters.Add("@dpt_consecutivo", SqlDbType.Int).Value = dtoParrafo.dpt_consecutivo;

                if (!String.IsNullOrEmpty(dtoParrafo.dpt_parrafo))
                    con.ObjCommand.Parameters.Add("@dpt_parrafo", SqlDbType.VarChar).Value = dtoParrafo.dpt_parrafo;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public void DoctoParrafoTexto_Eliminar(string docto_parrafo_texto_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoTexto_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = int.Parse(docto_parrafo_texto_id);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoParrafo_Eliminar(string docto_parrafo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafo_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = int.Parse(docto_parrafo_id);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }
        public void DoctoParrafoTexto_EliminarTodos(int docto_parrafo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoTexto_EliminarTodos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = docto_parrafo_id;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoParrafoMateria_AgregarActualizar(int docto_parrafo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoMateria_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = docto_parrafo_id;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoParrafoSubtipo_AgregarActualizar(int docto_parrafo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoSubtipo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = docto_parrafo_id;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoParrafoTipo_AgregarActualizar(int docto_parrafo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoTipo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = docto_parrafo_id;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void BitacoraAcceso_Agregar(DtoBitacoraAccesos dtoBitacora)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_BitacoraAccesos_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sistema", SqlDbType.VarChar).Value = dtoBitacora.sistema;
                con.ObjCommand.Parameters.Add("@usuario", SqlDbType.VarChar).Value = dtoBitacora.usuario;
                con.ObjCommand.Parameters.Add("@ip", SqlDbType.VarChar).Value = dtoBitacora.ip;
                con.ObjCommand.Parameters.Add("@ip_servidor", SqlDbType.VarChar).Value = dtoBitacora.ip_servidor;
                con.ObjCommand.Parameters.Add("@area", SqlDbType.VarChar).Value = dtoBitacora.area;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void AgregarContenido(DtoInfoApoyo dtoinfoapoyo)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InfoApoyo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@info_apoyo_id", SqlDbType.VarChar).Value = dtoinfoapoyo.info_apoyo_id;
                con.ObjCommand.Parameters.Add("@infa_descripcion", SqlDbType.VarChar).Value = dtoinfoapoyo.infa_descripcion;
                con.ObjCommand.Parameters.Add("@infa_tipo", SqlDbType.Int).Value = dtoinfoapoyo.infa_tipo;
                con.ObjCommand.Parameters.Add("@infa_url", SqlDbType.VarChar).Value = dtoinfoapoyo.infa_url;
                con.ObjCommand.Parameters.Add("@infa_material", SqlDbType.VarChar).Value = dtoinfoapoyo.infa_material;
                con.ObjCommand.Parameters.Add("@infa_orden", SqlDbType.Int).Value = dtoinfoapoyo.infa_orden;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoinfoapoyo.sys_usr;
                con.ObjCommand.Parameters.Add("@infa_vinculo", SqlDbType.Int).Value = dtoinfoapoyo.infa_vinculo;
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        //*****AGREGAR USUARIO***********************
        /// <summary>
        ///     Actualizar Crear UN USUARIO - considerar cualquier cambio en SIPAS se utiliza el mismo PA en el Login
        /// </summary>
        public int Usuario_AgregarActualizar(DtoUsuario dtousuario)
        {
            Constantes con = new Constantes();
            try
            {

                bool has_usr_login = false;

                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Usuario_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@usuario_id", SqlDbType.Int).Value = dtousuario.usuario_id;
                if (dtousuario.perfil_id != -1)
                    con.ObjCommand.Parameters.Add("@perfil_id", SqlDbType.Int).Value = dtousuario.perfil_id;
                if (dtousuario.cur_cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = dtousuario.cur_cve_ur;
                if (dtousuario.cen_cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = dtousuario.cen_cve_edorep;
                if (!String.IsNullOrEmpty(dtousuario.usr_nombre))
                    con.ObjCommand.Parameters.Add("@usr_nombre", SqlDbType.VarChar, 30).Value = dtousuario.usr_nombre;
                if (!String.IsNullOrEmpty(dtousuario.usr_primer_apellido))
                    con.ObjCommand.Parameters.Add("@usr_primer_apellido", SqlDbType.VarChar, 30).Value = dtousuario.usr_primer_apellido;
                if (!String.IsNullOrEmpty(dtousuario.usr_segundo_apellido))
                    con.ObjCommand.Parameters.Add("@usr_segundo_apellido", SqlDbType.VarChar, 30).Value = dtousuario.usr_segundo_apellido;
                if (!String.IsNullOrEmpty(dtousuario.usr_puesto))
                    con.ObjCommand.Parameters.Add("@usr_puesto", SqlDbType.VarChar, 100).Value = dtousuario.usr_puesto;
                if (!String.IsNullOrEmpty(dtousuario.usr_login))
                {
                    has_usr_login = true;
                    con.ObjCommand.Parameters.Add("@usr_login", SqlDbType.VarChar, 20).Value = dtousuario.usr_login;
                }
                    
                if (!String.IsNullOrEmpty(dtousuario.usr_email))
                {
                    con.ObjCommand.Parameters.Add("@usr_email", SqlDbType.VarChar, 100).Value = dtousuario.usr_email;

                }
                //CASO para creacion y edicion de participantes sin usr_email que crea o modifica un pre registro de usuario vacio sin email, si no tiene e-mail se permite tener usr_login vacio ya que un usuario sin e-mail no interactua en el proceso. 
                if (String.IsNullOrEmpty(dtousuario.usr_email) && has_usr_login == false)
                {
                    con.ObjCommand.Parameters.Add("@usr_login", SqlDbType.VarChar, 20).Value = dtousuario.usr_login;
                }
                if (!String.IsNullOrEmpty(dtousuario.usr_lada))
                    con.ObjCommand.Parameters.Add("@usr_lada", SqlDbType.VarChar, 10).Value = dtousuario.usr_lada;
                if (!String.IsNullOrEmpty(dtousuario.usr_telefono))
                    con.ObjCommand.Parameters.Add("@usr_telefono", SqlDbType.VarChar, 50).Value = dtousuario.usr_telefono;
                if (!String.IsNullOrEmpty(dtousuario.usr_estatus))
                    con.ObjCommand.Parameters.Add("@usr_estatus", SqlDbType.VarChar, 15).Value = dtousuario.usr_estatus;
                if (dtousuario.core_usuario_id != null)
                    con.ObjCommand.Parameters.Add("@core_usuario_id", SqlDbType.Int).Value = dtousuario.core_usuario_id;
                if (dtousuario.correo_institucional != "")
                    con.ObjCommand.Parameters.Add("@correo_institucional", SqlDbType.VarChar, 15).Value = dtousuario.correo_institucional;

                con.ObjCommand.Parameters.Add("@update_data_at", SqlDbType.DateTime).Value = dtousuario.update_data_at;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int Susuario_AgregarActualizar(DtoSusuario dtousuario)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Susuario_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_usuario_id", SqlDbType.Int).Value = dtousuario.s_usuario_id;
                if (dtousuario.s_perfil_id != -1)
                    con.ObjCommand.Parameters.Add("@s_perfil_id", SqlDbType.Int).Value = dtousuario.s_perfil_id;
                if (dtousuario.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = dtousuario.cve_ur;
                if (dtousuario.cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = dtousuario.cve_edorep;
                if (!String.IsNullOrEmpty(dtousuario.susr_nombre))
                    con.ObjCommand.Parameters.Add("@susr_nombre", SqlDbType.VarChar, 40).Value = dtousuario.susr_nombre;
                if (!String.IsNullOrEmpty(dtousuario.susr_primer_apellido))
                    con.ObjCommand.Parameters.Add("@susr_primer_apellido", SqlDbType.VarChar, 40).Value = dtousuario.susr_primer_apellido;
                if (!String.IsNullOrEmpty(dtousuario.susr_segundo_apellido))
                    con.ObjCommand.Parameters.Add("@susr_segundo_apellido", SqlDbType.VarChar, 40).Value = dtousuario.susr_segundo_apellido;
                if (!String.IsNullOrEmpty(dtousuario.susr_puesto))
                    con.ObjCommand.Parameters.Add("@susr_puesto", SqlDbType.VarChar, 100).Value = dtousuario.susr_puesto;
                if (!String.IsNullOrEmpty(dtousuario.susr_login))
                    con.ObjCommand.Parameters.Add("@susr_login", SqlDbType.VarChar, 20).Value = dtousuario.susr_login;
                if (!String.IsNullOrEmpty(dtousuario.susr_password))
                    con.ObjCommand.Parameters.Add("@susr_password", SqlDbType.VarChar, 10).Value = dtousuario.susr_password;
                if (!String.IsNullOrEmpty(dtousuario.susr_email))
                    con.ObjCommand.Parameters.Add("@susr_email", SqlDbType.VarChar, 100).Value = dtousuario.susr_email;
                if (!String.IsNullOrEmpty(dtousuario.susr_telefono))
                    con.ObjCommand.Parameters.Add("@susr_telefono", SqlDbType.VarChar, 50).Value = dtousuario.susr_telefono;
                if (!String.IsNullOrEmpty(dtousuario.susr_estatus))
                    con.ObjCommand.Parameters.Add("@susr_estatus", SqlDbType.VarChar, 15).Value = dtousuario.susr_estatus;
                if (!String.IsNullOrEmpty(dtousuario.correo_institucional))
                    con.ObjCommand.Parameters.Add("@correo_institucional", SqlDbType.VarChar, 15).Value = dtousuario.correo_institucional;

                con.ObjCommand.Parameters.Add("@update_data_at", SqlDbType.DateTime).Value = dtousuario.update_data_at;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int Participante_AgregarActualizar(DtoParticipante miDtoPar)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Participante_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoPar.participante_id != -1)
                    con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = miDtoPar.participante_id;
                if (miDtoPar.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoPar.inspector_id;
                if (miDtoPar.usuario_id != -1)
                    con.ObjCommand.Parameters.Add("@usuario_id", SqlDbType.Int).Value = miDtoPar.usuario_id;
                if (miDtoPar.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoPar.cve_ur;
                if (miDtoPar.perfil_id != -1)
                    con.ObjCommand.Parameters.Add("@perfil_id", SqlDbType.Int).Value = miDtoPar.perfil_id;
                if (miDtoPar.cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = miDtoPar.cve_edorep;
                if (!String.IsNullOrEmpty(miDtoPar.par_nombre))
                    con.ObjCommand.Parameters.Add("@par_nombre", SqlDbType.VarChar).Value = miDtoPar.par_nombre;
                if (!String.IsNullOrEmpty(miDtoPar.par_primer_apellido))
                    con.ObjCommand.Parameters.Add("@par_primer_apellido", SqlDbType.VarChar).Value = miDtoPar.par_primer_apellido;
                if (!String.IsNullOrEmpty(miDtoPar.par_segundo_apellido))
                    con.ObjCommand.Parameters.Add("@par_segundo_apellido", SqlDbType.VarChar).Value = miDtoPar.par_segundo_apellido;
                if (!String.IsNullOrEmpty(miDtoPar.par_puesto))
                    con.ObjCommand.Parameters.Add("@par_puesto", SqlDbType.VarChar).Value = miDtoPar.par_puesto;
                if (miDtoPar.par_es_inspector != -1)
                    con.ObjCommand.Parameters.Add("@par_es_inspector", SqlDbType.Int).Value = miDtoPar.par_es_inspector;
                if (miDtoPar.par_es_notificador != -1)
                    con.ObjCommand.Parameters.Add("@par_es_notificador", SqlDbType.Int).Value = miDtoPar.par_es_notificador;
                if (miDtoPar.par_es_firmante != -1)
                    con.ObjCommand.Parameters.Add("@par_es_firmante", SqlDbType.Int).Value = miDtoPar.par_es_firmante;
                if (miDtoPar.par_es_resp_juridico != -1)
                    con.ObjCommand.Parameters.Add("@par_es_resp_juridico", SqlDbType.Int).Value = miDtoPar.par_es_resp_juridico;
                if (miDtoPar.par_es_dictaminador != -1)
                    con.ObjCommand.Parameters.Add("@par_es_dictaminador", SqlDbType.Int).Value = miDtoPar.par_es_dictaminador;
                if (miDtoPar.par_estatus != -1)
                    con.ObjCommand.Parameters.Add("@par_estatus", SqlDbType.Int).Value = miDtoPar.par_estatus;
                if (!String.IsNullOrEmpty(miDtoPar.par_area_juridica))
                    con.ObjCommand.Parameters.Add("@par_area_juridica", SqlDbType.VarChar).Value = miDtoPar.par_area_juridica;

                con.ObjCommand.Parameters.Add("@cve_ur_comision", SqlDbType.Int).Value = miDtoPar.cve_ur_comision;

                con.ObjCommand.Parameters.Add("@par_esta_comisionado", SqlDbType.Bit).Value = miDtoPar.par_esta_comisionado;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int Inspector_AgregarActualizar(DtoInspector miDtoI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspector_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (miDtoI.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoI.inspector_id;
                if (!String.IsNullOrEmpty(miDtoI.insp_nombre))
                    con.ObjCommand.Parameters.Add("@insp_nombre", SqlDbType.VarChar).Value = miDtoI.insp_nombre;
                if (miDtoI.cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = miDtoI.cve_edorep;
                if (miDtoI.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoI.cve_ur;
                if (miDtoI.insp_solo_notifica != -1)
                    con.ObjCommand.Parameters.Add("@insp_solo_notifica", SqlDbType.Int).Value = miDtoI.insp_solo_notifica;
                if (!String.IsNullOrEmpty(miDtoI.insp_fec_expedicion))
                    con.ObjCommand.Parameters.Add("@insp_fec_expedicion", SqlDbType.DateTime).Value = miDtoI.insp_fec_expedicion;
                if (!String.IsNullOrEmpty(miDtoI.insp_fec_inicio))
                    con.ObjCommand.Parameters.Add("@insp_fec_inicio", SqlDbType.DateTime).Value = miDtoI.insp_fec_inicio;
                if (!String.IsNullOrEmpty(miDtoI.insp_fec_termino))
                    con.ObjCommand.Parameters.Add("@insp_fec_termino", SqlDbType.DateTime).Value = miDtoI.insp_fec_termino;
                if (!String.IsNullOrEmpty(miDtoI.insp_num_credencial))
                    con.ObjCommand.Parameters.Add("@insp_num_credencial", SqlDbType.VarChar).Value = miDtoI.insp_num_credencial;
                if (!String.IsNullOrEmpty(miDtoI.insp_nombre_suscribe))
                    con.ObjCommand.Parameters.Add("@insp_nombre_suscribe", SqlDbType.VarChar).Value = miDtoI.insp_nombre_suscribe;
                if (!String.IsNullOrEmpty(miDtoI.insp_puesto_suscribe))
                    con.ObjCommand.Parameters.Add("@insp_puesto_suscribe", SqlDbType.VarChar).Value = miDtoI.insp_puesto_suscribe;
                if (miDtoI.insp_estatus != -1)
                    con.ObjCommand.Parameters.Add("@insp_estatus", SqlDbType.Int).Value = miDtoI.insp_estatus;
                if (!String.IsNullOrEmpty(miDtoI.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoI.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Inspector_AgregarActualizarCapacidades(DtoInspector miDtoI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspector_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoI.inspector_id;

                con.ObjCommand.Parameters.Add("@insp_oportunidad_sh ", SqlDbType.Int).Value = miDtoI.insp_oportunidad_sh;
                con.ObjCommand.Parameters.Add("@insp_oportunidad_rspc", SqlDbType.Int).Value = miDtoI.insp_oportunidad_rspc;
                con.ObjCommand.Parameters.Add("@insp_oportunidad_supervision", SqlDbType.Int).Value = miDtoI.insp_oportunidad_supervision;
                con.ObjCommand.Parameters.Add("@insp_oportunidad_todas", SqlDbType.Int).Value = miDtoI.insp_oportunidad_todas;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();



            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        //Actualizar Materia
        public DataSet Materia_Actualizar(DtoMaterias miDtoM)
        {
            SqlDataAdapter objAdapter = null;
            Constantes con = new Constantes();
            DataSet objDataSet = new DataSet();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Materias_Actualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = miDtoM.sentencia;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoM.materia_id;
                con.ObjCommand.Parameters.Add("@mat_acronimo", SqlDbType.VarChar).Value = miDtoM.mat_acronimo;
                con.ObjCommand.Parameters.Add("@mat_nombre_corto", SqlDbType.VarChar).Value = miDtoM.mat_nombre_corto;
                con.ObjCommand.Parameters.Add("@mat_estatus", SqlDbType.TinyInt).Value = miDtoM.mat_estatus;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoM.sys_usr;
                con.ObjCommand.Parameters.Add("@normatividad_version_id", SqlDbType.Int).Value = miDtoM.normatividad_version_id;
                con.ObjCommand.Parameters.Add("@mat_controlada_sistema", SqlDbType.Int).Value = miDtoM.mat_controlada_sistema;
                con.ObjCommand.Parameters.Add("@mat_materia", SqlDbType.VarChar).Value = miDtoM.mat_materia;
                con.ObjCommand.Connection.Open();

                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");
                return objDataSet;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public DataSet Submateria_AgregarActualizar(DtoSubmateria miDtoS)
        {
            //[]
            SqlDataAdapter objAdapter = null;
            Constantes con = new Constantes();
            DataSet objDataSet = new DataSet();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Submateria_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = miDtoS.sentencia;
                if (miDtoS.submateria_id != -1) con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoS.submateria_id;
                if (miDtoS.materia_id != -1) con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoS.materia_id;
                if (miDtoS.smat_consecutivo != -1) con.ObjCommand.Parameters.Add("@smat_consecutivo", SqlDbType.Int).Value = miDtoS.smat_consecutivo;
                if (miDtoS.smat_submateria != String.Empty) con.ObjCommand.Parameters.Add("@smat_submateria", SqlDbType.VarChar).Value = miDtoS.smat_submateria;
                if (miDtoS.smat_nombre_corto != String.Empty) con.ObjCommand.Parameters.Add("@smat_nombre_corto", SqlDbType.VarChar).Value = miDtoS.smat_nombre_corto;
                if (miDtoS.smat_alcance != -1) con.ObjCommand.Parameters.Add("@smat_alcance", SqlDbType.Int).Value = miDtoS.smat_alcance;
                if (miDtoS.smat_opcion_no_aplicar != -1) con.ObjCommand.Parameters.Add("@smat_opcion_no_aplicar", SqlDbType.Int).Value = miDtoS.smat_opcion_no_aplicar;
                if (miDtoS.smat_estatus != -1) con.ObjCommand.Parameters.Add("@smat_estatus", SqlDbType.Int).Value = miDtoS.smat_estatus;
                if (miDtoS.smat_es_nom != -1) con.ObjCommand.Parameters.Add("@smat_es_nom", SqlDbType.Int).Value = miDtoS.smat_es_nom;
                //if (miDtoS.smat_nom != String.Empty) 
                con.ObjCommand.Parameters.Add("@smat_nom", SqlDbType.VarChar).Value = miDtoS.smat_nom;
                if (miDtoS.sys_usr != String.Empty) con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoS.sys_usr;
                if (miDtoS.smar_anio != -1) con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = miDtoS.smar_anio;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");
                return objDataSet;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }

        }

        public DataSet MateriasGrupo(DtoMateriaGrupo miDtoS)
        {
            //[]
            SqlDataAdapter objAdapter = null;
            Constantes con = new Constantes();
            DataSet objDataSet = new DataSet();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MateriasGrupo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = miDtoS.sentencia;
                if (miDtoS.materia_grupo_id > 0) con.ObjCommand.Parameters.Add("@materia_grupo_id", SqlDbType.Int).Value = miDtoS.materia_grupo_id;
                if (miDtoS.materia_id > 0) con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoS.materia_id;
                if (miDtoS.mg_nombre != "") con.ObjCommand.Parameters.Add("@mg_nombre", SqlDbType.VarChar).Value = miDtoS.mg_nombre;
                con.ObjCommand.Parameters.Add("@mg_num_materias", SqlDbType.Int).Value = miDtoS.mg_num_materias;
                con.ObjCommand.Parameters.Add("@mg_jurisdiccion", SqlDbType.Int).Value = miDtoS.mg_jurisdiccion;
                con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = miDtoS.normativa_version_id;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");
                return objDataSet;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        public int OperativoDocto_Agregar(int operativo_id, String odoc_tipo, String odoc_url, String sys_usr, int operativo_docto_id)
        {
            //[]
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoDocto_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (operativo_id != -1) con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                if (odoc_tipo != string.Empty) con.ObjCommand.Parameters.Add("@odoc_tipo", SqlDbType.VarChar).Value = odoc_tipo;
                if (odoc_url != string.Empty) con.ObjCommand.Parameters.Add("@odoc_url", SqlDbType.VarChar).Value = odoc_url;
                if (operativo_docto_id != -1) con.ObjCommand.Parameters.Add("@operativo_docto_id", SqlDbType.Int).Value = operativo_docto_id;
                if (sys_usr != string.Empty) con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int OperativoProgr_AgregarActualizar(DtoOperativo miDtoOp)
        {

            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoProgr_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoOp.operativo_id;
                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = miDtoOp.prog_anual_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoOp.materia_id;
                if (miDtoOp.tipo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_inspeccion_id", SqlDbType.Int).Value = miDtoOp.tipo_inspeccion_id;
                if (miDtoOp.prog_atributo_id != -1)
                    con.ObjCommand.Parameters.Add("@prog_atributo_id", SqlDbType.Int).Value = miDtoOp.prog_atributo_id;
                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = miDtoOp.motivo_inspeccion_id;
                if (miDtoOp.oper_tipo_operativo != -1)
                    con.ObjCommand.Parameters.Add("@oper_tipo_operativo", SqlDbType.Int).Value = miDtoOp.oper_tipo_operativo;
                con.ObjCommand.Parameters.Add("@oper_nombre", SqlDbType.VarChar).Value = miDtoOp.opr_nombre;
                con.ObjCommand.Parameters.Add("@oper_descripcion", SqlDbType.VarChar).Value = miDtoOp.oper_descripcion;
                con.ObjCommand.Parameters.Add("@oper_medio_informacion", SqlDbType.VarChar).Value = miDtoOp.oper_medio_informacion;
                con.ObjCommand.Parameters.Add("@oper_tiene_indicadores", SqlDbType.Int).Value = miDtoOp.oper_tiene_indicadores;
                con.ObjCommand.Parameters.Add("@oper_dia_inicio", SqlDbType.Int).Value = miDtoOp.oper_dia_inicio;
                con.ObjCommand.Parameters.Add("@oper_dia_termino", SqlDbType.Int).Value = miDtoOp.oper_dia_termino;
                if (!miDtoOp.oper_fec_inicio.Equals(string.Empty)) con.ObjCommand.Parameters.Add("@oper_fec_inicio", SqlDbType.DateTime).Value = miDtoOp.oper_fec_inicio;
                if (!miDtoOp.oper_fec_termino.Equals(string.Empty)) con.ObjCommand.Parameters.Add("@oper_fec_termino", SqlDbType.DateTime).Value = miDtoOp.oper_fec_termino;
                con.ObjCommand.Parameters.Add("@oper_es_prog_aleatoria", SqlDbType.Int).Value = miDtoOp.oper_es_prog_aleatoria;
                con.ObjCommand.Parameters.Add("@oper_asignar_inspectores", SqlDbType.Int).Value = miDtoOp.oper_asignar_inspectores;
                con.ObjCommand.Parameters.Add("@oper_es_ptu", SqlDbType.Int).Value = miDtoOp.oper_es_ptu;
                con.ObjCommand.Parameters.Add("@oper_estatus", SqlDbType.Int).Value = miDtoOp.oper_estatus;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoOp.sys_usr;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.VarChar).Value = miDtoOp.mes_id;
                if (miDtoOp.normativa_version_id != -1)
                    con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.VarChar).Value = miDtoOp.normativa_version_id;
                if (miDtoOp.subtipo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = miDtoOp.subtipo_inspeccion_id;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }

        }

        public int MotivoInspeccion_AgregarActualizar(DtoMotivosInspeccion miDtoMI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoInspeccion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = miDtoMI.motivo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@motiv_consecutivo", SqlDbType.Int).Value = miDtoMI.motiv_consecutivo;
                con.ObjCommand.Parameters.Add("@motiv_motivo", SqlDbType.VarChar).Value = miDtoMI.motiv_motivo;
                con.ObjCommand.Parameters.Add("@motiv_nombre_corto", SqlDbType.VarChar).Value = miDtoMI.motiv_nombre_corto;
                con.ObjCommand.Parameters.Add("@motiv_motivo_rgiasvll", SqlDbType.VarChar).Value = miDtoMI.motiv_motivo_rgiasvll;
                con.ObjCommand.Parameters.Add("@motiv_definicion", SqlDbType.Int).Value = miDtoMI.motiv_definicion;
                con.ObjCommand.Parameters.Add("@motiv_para_operativo_especial", SqlDbType.Int).Value = miDtoMI.motiv_para_operativo_especial;
                con.ObjCommand.Parameters.Add("@motiv_para_operativo_programado", SqlDbType.Int).Value = miDtoMI.motiv_para_operativo_programado;
                con.ObjCommand.Parameters.Add("@motiv_pedir_campo_adicional", SqlDbType.Int).Value = miDtoMI.motiv_pedir_campo_adicional;
                con.ObjCommand.Parameters.Add("@motiv_nombre_dato_adicional", SqlDbType.VarChar).Value = miDtoMI.motiv_nombre_dato_adicional;
                con.ObjCommand.Parameters.Add("@motiv_estatus", SqlDbType.Int).Value = miDtoMI.motiv_estatus;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoMI.sys_usr;
                con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.VarChar).Value = miDtoMI.normativa_version_id;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void MotivoMateria_AgregarActualizar(int materia_id, int motivo_inspeccion_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoMateria_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.VarChar).Value = motivo_inspeccion_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void MotivoSubtipo_AgregarActualizar(int subtipo_inspeccion_id, int motivo_inspeccion_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoSubtipo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = subtipo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.VarChar).Value = motivo_inspeccion_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int ProgAnual_AgregarActualizar(DtoProgAnual miDtoPA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAnual_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoPA.prog_anual_id != -1)
                    con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = miDtoPA.prog_anual_id;
                if (miDtoPA.panual_anio != -1)
                    con.ObjCommand.Parameters.Add("@panual_anio", SqlDbType.Int).Value = miDtoPA.panual_anio;
                if (miDtoPA.panual_meta_anual != -1)
                    con.ObjCommand.Parameters.Add("@panual_meta_anual", SqlDbType.Int).Value = miDtoPA.panual_meta_anual;
                if (!String.IsNullOrEmpty(miDtoPA.panual_fec_programacion))
                    con.ObjCommand.Parameters.Add("@panual_fec_programacion", SqlDbType.DateTime).Value = miDtoPA.panual_fec_programacion;
                if (miDtoPA.panual_num_inspectores != -1)
                    con.ObjCommand.Parameters.Add("@panual_num_inspectores", SqlDbType.Int).Value = miDtoPA.panual_num_inspectores;
                if (miDtoPA.panual_inspecciones_por_inspector != -1)
                    con.ObjCommand.Parameters.Add("@panual_inspecciones_por_inspector", SqlDbType.Decimal).Value = miDtoPA.panual_inspecciones_por_inspector;
                if (miDtoPA.panual_pct_prog_aleatoria != -1)
                    con.ObjCommand.Parameters.Add("@panual_pct_prog_aleatoria", SqlDbType.Int).Value = miDtoPA.panual_pct_prog_aleatoria;
                if (miDtoPA.panual_pct_prog_directa != -1)
                    con.ObjCommand.Parameters.Add("@panual_pct_prog_directa", SqlDbType.Int).Value = miDtoPA.panual_pct_prog_directa;
                if (miDtoPA.panual_estatus != -1)
                    con.ObjCommand.Parameters.Add("@panual_estatus", SqlDbType.Int).Value = miDtoPA.panual_estatus;
                if (!String.IsNullOrEmpty(miDtoPA.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoPA.sys_usr;

                if (miDtoPA.panual_estatus_distribucion != -1)
                    con.ObjCommand.Parameters.Add("@panual_estatus_distribucion", SqlDbType.Int).Value = miDtoPA.panual_estatus_distribucion;
                if (miDtoPA.panual_estatus_metas != -1)
                    con.ObjCommand.Parameters.Add("@panual_estatus_metas", SqlDbType.Int).Value = miDtoPA.panual_estatus_metas;
                if (miDtoPA.panual_estatus_operativo != -1)
                    con.ObjCommand.Parameters.Add("@panual_estatus_operativo", SqlDbType.Int).Value = miDtoPA.panual_estatus_operativo;
                if (miDtoPA.normativa_version_id != -1)
                    con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = miDtoPA.normativa_version_id;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        public bool ProgAnual_Eliminar(DtoProgAnual miDtoPA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAnual_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoPA.prog_anual_id != -1)
                    con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = miDtoPA.prog_anual_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return true;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int ProgEntidad_AgregarActualizar(DtoProgEntidad miDtoPE)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgEntidad_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoPE.prog_entidad_id != -1)
                    con.ObjCommand.Parameters.Add("@prog_entidad_id", SqlDbType.Int).Value = miDtoPE.prog_entidad_id;
                if (miDtoPE.prog_mes_id != -1)
                    con.ObjCommand.Parameters.Add("@prog_mes_id", SqlDbType.Int).Value = miDtoPE.prog_mes_id;
                if (miDtoPE.pent_cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@pent_cve_edorep", SqlDbType.Int).Value = miDtoPE.pent_cve_edorep;
                if (miDtoPE.pent_cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@pent_cve_ur", SqlDbType.Int).Value = miDtoPE.pent_cve_ur;
                if (miDtoPE.pent_total_mensual != -1)
                    con.ObjCommand.Parameters.Add("@pent_total_mensual", SqlDbType.Int).Value = miDtoPE.pent_total_mensual;
                if (miDtoPE.pent_pct_foraneas != -1)
                    con.ObjCommand.Parameters.Add("@pent_pct_foraneas", SqlDbType.Int).Value = miDtoPE.pent_pct_foraneas;
                if (miDtoPE.pent_num_operativos != -1)
                    con.ObjCommand.Parameters.Add("@pent_num_operativos", SqlDbType.Int).Value = miDtoPE.pent_num_operativos;
                if (!String.IsNullOrEmpty(miDtoPE.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoPE.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        //********************************************
        public int ProgMes_AgregarActualizar(DtoProgMes progmes)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgMes_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (progmes.prog_mes_id != -1)
                    con.ObjCommand.Parameters.Add("@prog_mes_id", SqlDbType.Int).Value = progmes.prog_mes_id;
                if (progmes.prog_anual_id != -1)
                    con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = progmes.prog_anual_id;
                if (progmes.mes_id != -1)
                    con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = progmes.mes_id;
                if (progmes.pmes_total_nacional != -1)
                    con.ObjCommand.Parameters.Add("@pmes_total_nacional", SqlDbType.Int).Value = progmes.pmes_total_nacional;
                if (progmes.pmes_total_foraneas != -1)
                    con.ObjCommand.Parameters.Add("@pmes_total_foraneas", SqlDbType.Decimal).Value = progmes.pmes_total_foraneas;
                if (progmes.pmes_total_operativo != -1)
                    con.ObjCommand.Parameters.Add("@pmes_total_operativo", SqlDbType.Int).Value = progmes.pmes_total_operativo;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void ProgMateria_Agregar(int prog_anual_id, string sys_usr, int normatividad_version_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgMateria_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;
                con.ObjCommand.Parameters.Add("@normatividad_id", SqlDbType.VarChar).Value = normatividad_version_id;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void ProgMateria_Actualizar(DtoProgMateria dtoPMateria)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgMateria_Actualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_anual_materia_id", SqlDbType.Int).Value = dtoPMateria.prog_anual_materia_id;
                if (dtoPMateria.pmat_pct_anual != -1)
                    con.ObjCommand.Parameters.Add("@pmat_pct_anual", SqlDbType.Int).Value = dtoPMateria.pmat_pct_anual;
                if (dtoPMateria.pmat_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pmat_prioridad", SqlDbType.Int).Value = dtoPMateria.pmat_prioridad;
                if (dtoPMateria.pmat_pct_iniciales != -1)
                    con.ObjCommand.Parameters.Add("@pmat_pct_iniciales", SqlDbType.Int).Value = dtoPMateria.pmat_pct_iniciales;
                if (dtoPMateria.pmat_pct_periodicas != -1)
                    con.ObjCommand.Parameters.Add("@pmat_pct_periodicas", SqlDbType.Int).Value = dtoPMateria.pmat_pct_periodicas;

                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoPMateria.sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int ProgAtributo_AgregarParaProgMuestra(int prog_anual_materia_id, string tipo_atributo, string sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributo_AgregarParaProgMuestra", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_anual_materia_id", SqlDbType.Int).Value = prog_anual_materia_id;
                con.ObjCommand.Parameters.Add("@tipo_atributo", SqlDbType.VarChar).Value = tipo_atributo;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public DataSet GenerarConsecutivo(int cve_ur, int anio)
        {
            Constantes con = new Constantes();
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_GenerarConsecutivo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");
                return objDataSet;

            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int ProgAtributo_AgregarParaOperativo(int operativo_id, string sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributo_AgregarParaOperativo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void ContenidoUsuario_AgregarActualizar(int usuario_id, int infa_tipo)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InfoApoyo_Usuario_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                con.ObjCommand.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuario_id;
                con.ObjCommand.Parameters.Add("@infa_tipo", SqlDbType.Int).Value = infa_tipo;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public DataSet ProgAtributo_EstatusConfiguracion(int atributo_id)
        {
            //[]
            SqlDataAdapter objAdapter = null;
            Constantes con = new Constantes();
            DataSet objDataSet = new DataSet();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributo_EstatusConfiguracion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@atributo_id", SqlDbType.Int).Value = atributo_id;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");
                return objDataSet;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int OperativoEntidad_AgregarActualizar(DtoOperativoEntidad miDtoOE)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoEntidad_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoOE.operativo_entidad_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_entidad_id", SqlDbType.Int).Value = miDtoOE.operativo_entidad_id;
                if (miDtoOE.operativo_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoOE.operativo_id;
                if (miDtoOE.operent_cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@operent_cve_edorep", SqlDbType.Int).Value = miDtoOE.operent_cve_edorep;
                if (miDtoOE.operent_cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@operent_cve_ur", SqlDbType.Int).Value = miDtoOE.operent_cve_ur;
                if (miDtoOE.operent_total_mensual != -1)
                    con.ObjCommand.Parameters.Add("@operent_total_mensual", SqlDbType.Int).Value = miDtoOE.operent_total_mensual;
                if (miDtoOE.operent_num_operativos != -1)
                    con.ObjCommand.Parameters.Add("@operent_num_operativos", SqlDbType.Int).Value = miDtoOE.operent_num_operativos;
                if (!String.IsNullOrEmpty(miDtoOE.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoOE.sys_usr;

                if (miDtoOE.mes_id != -1)
                    con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = miDtoOE.mes_id;
                if (miDtoOE.anio != -1)
                    con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = miDtoOE.anio;
                if (miDtoOE.prog_anual_id != -1)
                    con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = miDtoOE.prog_anual_id;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int ProgAtributo_Actualizar(DtoProgAtributo dtoPAtributo)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributo_Actualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_atributo_id", SqlDbType.Int).Value = dtoPAtributo.prog_atributo_id;
                if (dtoPAtributo.subtipo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = dtoPAtributo.subtipo_inspeccion_id;

                #region Primera Parte
                if (dtoPAtributo.pa_dne_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_dne_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_dne_aplica;
                if (dtoPAtributo.pa_dne_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_dne_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_dne_prioridad;
                if (dtoPAtributo.pa_dne_valor1 != -1)
                    con.ObjCommand.Parameters.Add("@pa_dne_valor1", SqlDbType.Int).Value = dtoPAtributo.pa_dne_valor1;
                if (dtoPAtributo.pa_dne_valor2 != -1)
                    con.ObjCommand.Parameters.Add("@pa_dne_valor2", SqlDbType.Int).Value = dtoPAtributo.pa_dne_valor2;
                if (dtoPAtributo.pa_dne_valor3 != -1)
                    con.ObjCommand.Parameters.Add("@pa_dne_valor3", SqlDbType.Int).Value = dtoPAtributo.pa_dne_valor3;

                if (dtoPAtributo.pa_tamanio_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_tamanio_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_tamanio_aplica;
                if (dtoPAtributo.pa_tamanio_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_tamanio_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_tamanio_prioridad;
                if (dtoPAtributo.pa_tamanio_valor1 != -1)
                    con.ObjCommand.Parameters.Add("@pa_tamanio_valor1", SqlDbType.Int).Value = dtoPAtributo.pa_tamanio_valor1;
                if (dtoPAtributo.pa_tamanio_valor2 != -1)
                    con.ObjCommand.Parameters.Add("@pa_tamanio_valor2", SqlDbType.Int).Value = dtoPAtributo.pa_tamanio_valor2;

                if (dtoPAtributo.pa_prioritaria_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_prioritaria_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_prioritaria_aplica;
                if (dtoPAtributo.pa_prioritaria_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_prioritaria_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_prioritaria_prioridad;

                if (dtoPAtributo.pa_clase_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_clase_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_clase_aplica;
                if (dtoPAtributo.pa_clase_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_clase_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_clase_prioridad;
                if (dtoPAtributo.pa_clase_valor1 != -1)
                    con.ObjCommand.Parameters.Add("@pa_clase_valor1", SqlDbType.Int).Value = dtoPAtributo.pa_clase_valor1;
                if (dtoPAtributo.pa_clase_valor2 != -1)
                    con.ObjCommand.Parameters.Add("@pa_clase_valor2", SqlDbType.Int).Value = dtoPAtributo.pa_clase_valor2;
                if (dtoPAtributo.pa_clase_valor3 != -1)
                    con.ObjCommand.Parameters.Add("@pa_clase_valor3", SqlDbType.Int).Value = dtoPAtributo.pa_clase_valor3;
                if (dtoPAtributo.pa_clase_valor4 != -1)
                    con.ObjCommand.Parameters.Add("@pa_clase_valor4", SqlDbType.Int).Value = dtoPAtributo.pa_clase_valor4;
                if (dtoPAtributo.pa_clase_valor5 != -1)
                    con.ObjCommand.Parameters.Add("@pa_clase_valor5", SqlDbType.Int).Value = dtoPAtributo.pa_clase_valor5;

                if (dtoPAtributo.pa_prima_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_prima_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_prima_aplica;
                if (dtoPAtributo.pa_prima_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_prima_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_prima_prioridad;
                if (dtoPAtributo.pa_prima_valor1 != -1.0)
                    con.ObjCommand.Parameters.Add("@pa_prima_valor1", SqlDbType.Decimal).Value = dtoPAtributo.pa_prima_valor1;
                if (dtoPAtributo.pa_prima_valor2 != -1.0)
                    con.ObjCommand.Parameters.Add("@pa_prima_valor2", SqlDbType.Decimal).Value = dtoPAtributo.pa_prima_valor2;

                if (dtoPAtributo.pa_rspc_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_rspc_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_rspc_aplica;
                if (dtoPAtributo.pa_rspc_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_rspc_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_rspc_prioridad;

                if (dtoPAtributo.pa_sustancias_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_sustancias_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_sustancias_aplica;
                if (dtoPAtributo.pa_sustancias_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_sustancias_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_sustancias_prioridad;

                if (dtoPAtributo.pa_liquidos_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_liquidos_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_liquidos_aplica;
                if (dtoPAtributo.pa_liquidos_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_liquidos_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_liquidos_prioridad;

                if (dtoPAtributo.pa_piroforicos_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_piroforicos_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_piroforicos_aplica;
                if (dtoPAtributo.pa_piroforicos_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_piroforicos_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_piroforicos_prioridad;
                #endregion

                #region Segunda Parte
                if (dtoPAtributo.pa_actividad_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_actividad_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_actividad_aplica;
                if (dtoPAtributo.pa_actividad_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_actividad_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_actividad_prioridad;
                if (dtoPAtributo.pa_actividad_tipo != -1)
                    con.ObjCommand.Parameters.Add("@pa_actividad_tipo", SqlDbType.Int).Value = dtoPAtributo.pa_actividad_tipo;
                #endregion

                #region Tercera Parte
                if (dtoPAtributo.pa_ultima_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_ultima_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_ultima_aplica;
                if (dtoPAtributo.pa_ultima_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_ultima_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_ultima_prioridad;
                if (dtoPAtributo.pa_ultima_valor1 != -1)
                    con.ObjCommand.Parameters.Add("@pa_ultima_valor1", SqlDbType.Int).Value = dtoPAtributo.pa_ultima_valor1;

                if (dtoPAtributo.pa_ptu_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_ptu_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_ptu_aplica;
                if (dtoPAtributo.pa_ptu_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_ptu_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_ptu_prioridad;

                if (dtoPAtributo.pa_reincidente_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_reincidente_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_reincidente_aplica;
                if (dtoPAtributo.pa_reincidente_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_reincidente_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_reincidente_prioridad;

                if (dtoPAtributo.pa_pendientes_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_pendientes_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_pendientes_aplica;
                if (dtoPAtributo.pa_pendientes_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_pendientes_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_pendientes_prioridad;

                if (dtoPAtributo.pa_capacitacion_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_capacitacion_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_capacitacion_aplica;
                if (dtoPAtributo.pa_capacitacion_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_capacitacion_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_capacitacion_prioridad;

                if (dtoPAtributo.pa_declare_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_declare_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_declare_aplica;
                if (dtoPAtributo.pa_declare_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_declare_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_declare_prioridad;
                if (dtoPAtributo.pa_declare_valor1 != -1)
                    con.ObjCommand.Parameters.Add("@pa_declare_valor1", SqlDbType.Int).Value = dtoPAtributo.pa_declare_valor1;

                if (dtoPAtributo.pa_passt_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_passt_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_passt_aplica;
                if (dtoPAtributo.pa_passt_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_passt_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_passt_prioridad;
                if (dtoPAtributo.pa_passt_valor1 != -1)
                    con.ObjCommand.Parameters.Add("@pa_passt_valor1", SqlDbType.Int).Value = dtoPAtributo.pa_passt_valor1;

                if (dtoPAtributo.pa_agencias_aplica != -1)
                    con.ObjCommand.Parameters.Add("@pa_agencias_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_agencias_aplica;
                if (dtoPAtributo.pa_agencias_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_agencias_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_agencias_prioridad;
                if (dtoPAtributo.pa_agencias_valor1 != -1)
                    con.ObjCommand.Parameters.Add("@pa_agencias_valor1", SqlDbType.Int).Value = dtoPAtributo.pa_agencias_valor1;

                //if (dtoPAtributo.pa_bdimss_aplica != -1)
                //    con.ObjCommand.Parameters.Add("@pa_bdimss_aplica", SqlDbType.Int).Value = dtoPAtributo.pa_bdimss_aplica;
                if (dtoPAtributo.pa_bdimss_prioridad != -1)
                    con.ObjCommand.Parameters.Add("@pa_bdimss_prioridad", SqlDbType.Int).Value = dtoPAtributo.pa_bdimss_prioridad;
                if (dtoPAtributo.pa_bdimss_valor1 != -1)
                    con.ObjCommand.Parameters.Add("@pa_bdimss_valor1", SqlDbType.Int).Value = dtoPAtributo.pa_bdimss_valor1;

                #endregion

                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoPAtributo.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int ProgAtributosActividad_Agregar(DtoProgAct miDtoPA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributosActividad_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_atributo_id", SqlDbType.Int).Value = miDtoPA.prog_atributo_id;
                con.ObjCommand.Parameters.Add("@pas_cae_id", SqlDbType.Int).Value = miDtoPA.par_cve_rama;
                con.ObjCommand.Parameters.Add("@pas_ponderacion", SqlDbType.Int).Value = miDtoPA.par_ponderacion;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoPA.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }

        }

        public void ProgAtributo2_Actualizar(DtoProgAct miDtoProgAct)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributo2_Actualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_atributo_id", SqlDbType.Int).Value = miDtoProgAct.prog_atributo_id;
                con.ObjCommand.Parameters.Add("@par_cve_rama", SqlDbType.Int).Value = miDtoProgAct.par_cve_rama;
                con.ObjCommand.Parameters.Add("@par_ponderacion", SqlDbType.Int).Value = miDtoProgAct.par_ponderacion;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoProgAct.sys_usr;

                //SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                //vReturn.Direction = ParameterDirection.ReturnValue;
                //con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                //return (int)vReturn.Value;


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }

        }

        public void ProgAtributo2SCIAN_Actualizar(DtoProgAct miDtoProgAct)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributo2SCIAN_Actualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_atributo_id", SqlDbType.Int).Value = miDtoProgAct.prog_atributo_id;
                con.ObjCommand.Parameters.Add("@pas_cae_id", SqlDbType.Int).Value = miDtoProgAct.par_cve_rama;
                con.ObjCommand.Parameters.Add("@pas_ponderacion", SqlDbType.Int).Value = miDtoProgAct.par_ponderacion;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoProgAct.sys_usr;

                //SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                //vReturn.Direction = ParameterDirection.ReturnValue;
                //con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                //return (int)vReturn.Value;


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }

        }

        public int OperativoAsignacion_AgregarActualizar(DtoOperativoAsignacion miDtoOA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAsignacion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoOA.operativo_asignacion_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_asignacion_id", SqlDbType.Int).Value = miDtoOA.operativo_asignacion_id;
                if (miDtoOA.operativo_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoOA.operativo_id;
                if (miDtoOA.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoOA.inspector_id;
                if (miDtoOA.oas_cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@oas_cve_edorep", SqlDbType.Int).Value = miDtoOA.oas_cve_edorep;
                if (miDtoOA.oas_cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@oas_cve_ur", SqlDbType.Int).Value = miDtoOA.oas_cve_ur;
                if (!String.IsNullOrEmpty(miDtoOA.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoOA.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        //*****************************
        public int InspeccionAlcance_AgregarActualizar(int inspec_alcance_id, int submateria_id, int inspeccion_id, string sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspeccionAlcance_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (inspec_alcance_id != -1)
                    con.ObjCommand.Parameters.Add("@inspec_alcance_id", SqlDbType.Int).Value = inspec_alcance_id;
                if (submateria_id != -1)
                    con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                if (inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                if (!String.IsNullOrEmpty(sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        //*********agregar inspecccion indicadores
        public int InspeccionIndicador_AgregarActualizar(int inspec_indicador_id, int indicador_id, int inspeccion_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspeccionIndicador_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (inspec_indicador_id != -1)
                    con.ObjCommand.Parameters.Add("@inspec_indicador_id", SqlDbType.Int).Value = inspec_indicador_id;
                if (indicador_id != -1)
                    con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                if (inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                //if (!String.IsNullOrEmpty(sys_usr))
                //    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int OperativoAlcance_AgregarActualizar(DtoOperativoAlcance miDtoOA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAlcance_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoOA.operativo_alcance_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_alcance_id", SqlDbType.Int).Value = miDtoOA.operativo_alcance_id;
                if (miDtoOA.operativo_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoOA.operativo_id;
                if (miDtoOA.submateria_id != -1)
                    con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoOA.submateria_id;

                if (!String.IsNullOrEmpty(miDtoOA.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoOA.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int OperativoIndicador_AgregarActualizar(DtoOperativoIndicador miDtoOI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoIndicador_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoOI.operativo_alcance_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_alcance_id", SqlDbType.Int).Value = miDtoOI.operativo_alcance_id;
                if (miDtoOI.operativo_indicador_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_indicador_id", SqlDbType.Int).Value = miDtoOI.operativo_indicador_id;
                if (miDtoOI.indicador_id != -1)
                    con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = miDtoOI.indicador_id;

                con.ObjCommand.Parameters.Add("@ind_inciso_id", SqlDbType.Int).Value = miDtoOI.inciso_id;

                if (!String.IsNullOrEmpty(miDtoOI.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoOI.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int InspectorDisponibilidad_Agregar(DtoInspectorDisponibilidad miDtoID)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspectorDisponibilidad_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoID.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoID.inspector_id;

                if (!String.IsNullOrEmpty(miDtoID.idis_fec_inicio))
                    con.ObjCommand.Parameters.Add("@idis_fec_inicio", SqlDbType.DateTime).Value = miDtoID.idis_fec_inicio;

                if (!String.IsNullOrEmpty(miDtoID.idis_fec_termino))
                    con.ObjCommand.Parameters.Add("@idis_fec_termino", SqlDbType.DateTime).Value = miDtoID.idis_fec_termino;

                if (!String.IsNullOrEmpty(miDtoID.idis_causa))
                    con.ObjCommand.Parameters.Add("@idis_causa", SqlDbType.VarChar).Value = miDtoID.idis_causa;

                if (!String.IsNullOrEmpty(miDtoID.idis_especificar))
                    con.ObjCommand.Parameters.Add("@idis_especificar", SqlDbType.VarChar).Value = miDtoID.idis_especificar;

                if (miDtoID.inspector_disponibilidad_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_disponibilidad_id", SqlDbType.Int).Value = miDtoID.inspector_disponibilidad_id;

                if (!String.IsNullOrEmpty(miDtoID.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoID.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoParrafoMateria_Actualizar(DtoDoctoParrafoMateria miDtoPM)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoMateria_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoPM.docto_parrafo_materia != -1)
                    con.ObjCommand.Parameters.Add("@docto_parrafo_materia", SqlDbType.Int).Value = miDtoPM.docto_parrafo_materia;
                if (miDtoPM.docto_parrafo_texto_id != -1)
                    con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = miDtoPM.docto_parrafo_texto_id;
                if (miDtoPM.materia_id != -1)
                    con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoPM.materia_id;
                if (miDtoPM.materia_seleccionado != -1)
                    con.ObjCommand.Parameters.Add("@materia_seleccionado", SqlDbType.Int).Value = miDtoPM.materia_seleccionado;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void SDoctoParrafoMateria_Actualizar(DtoDoctoParrafoMateriaSipas miDtoPM)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SDoctoParrafoMateria_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoPM.s_docto_parrafo_materia_id != -1)
                    con.ObjCommand.Parameters.Add("@s_docto_parrafo_materia_id", SqlDbType.Int).Value = miDtoPM.s_docto_parrafo_materia_id;
                if (miDtoPM.s_docto_parrafo_texto_id != -1)
                    con.ObjCommand.Parameters.Add("@s_docto_parrafo_texto_id", SqlDbType.Int).Value = miDtoPM.s_docto_parrafo_texto_id;
                if (miDtoPM.materia_id != -1)
                    con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoPM.materia_id;
                if (miDtoPM.materia_seleccionado != -1)
                    con.ObjCommand.Parameters.Add("@materia_seleccionado", SqlDbType.Int).Value = miDtoPM.materia_seleccionado;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void SDoctoParrafoComparecencia_Actualizar(int s_docto_parrafo_texto_id, int con_comparecencia, int comparecencia_seleccionado)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SDoctoParrafoComparecencia_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (s_docto_parrafo_texto_id != -1)
                    con.ObjCommand.Parameters.Add("@s_docto_parrafo_texto_id", SqlDbType.Int).Value = s_docto_parrafo_texto_id;
                if (con_comparecencia != -1)
                    con.ObjCommand.Parameters.Add("@con_comparecencia", SqlDbType.Int).Value = con_comparecencia;
                if (comparecencia_seleccionado != -1)
                    con.ObjCommand.Parameters.Add("@comparecencia_seleccionado", SqlDbType.Int).Value = comparecencia_seleccionado;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoParrafoEtiqueta_Actualizar(int parrafo_etiqueta, int parrafo_texto_id, int etiqueta_id, int etiqueta_seleccionado)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoEtiqueta_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (parrafo_etiqueta != -1)
                    con.ObjCommand.Parameters.Add("@docto_parrafo_etiqueta_id", SqlDbType.Int).Value = parrafo_etiqueta;
                if (parrafo_texto_id != -1)
                    con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = parrafo_texto_id;
                if (etiqueta_id != -1)
                    con.ObjCommand.Parameters.Add("@etiqueta_id", SqlDbType.Int).Value = etiqueta_id;
                if (etiqueta_seleccionado != -1)
                    con.ObjCommand.Parameters.Add("@etiqueta_seleccionado", SqlDbType.Int).Value = etiqueta_seleccionado;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void PA_SDoctoParrafoEtiqueta_AgregarActualizar(int parrafo_etiqueta, int parrafo_texto_id, int etiqueta_id, int etiqueta_seleccionado)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SDoctoParrafoEtiqueta_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (parrafo_etiqueta != -1)
                    con.ObjCommand.Parameters.Add("@s_docto_parrafo_etiqueta_id", SqlDbType.Int).Value = parrafo_etiqueta;
                if (parrafo_texto_id != -1)
                    con.ObjCommand.Parameters.Add("@s_docto_parrafo_texto_id", SqlDbType.Int).Value = parrafo_texto_id;
                if (etiqueta_id != -1)
                    con.ObjCommand.Parameters.Add("@s_etiqueta_id", SqlDbType.Int).Value = etiqueta_id;
                if (etiqueta_seleccionado != -1)
                    con.ObjCommand.Parameters.Add("@setiqueta_seleccionado", SqlDbType.Int).Value = etiqueta_seleccionado;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoParrafoSubtipo_Actualizar(DtoDoctoParrafoSubtipo miDtoPS)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoSubtipo_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoPS.docto_parrafo_subtipo_id != -1)
                    con.ObjCommand.Parameters.Add("@docto_parrafo_subtipo_id", SqlDbType.Int).Value = miDtoPS.docto_parrafo_subtipo_id;
                if (miDtoPS.docto_parrafo_texto_id != -1)
                    con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = miDtoPS.docto_parrafo_texto_id;
                if (miDtoPS.subtipo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = miDtoPS.subtipo_inspeccion_id;
                if (miDtoPS.subtipo_seleccionado != -1)
                    con.ObjCommand.Parameters.Add("@subtipo_seleccionado", SqlDbType.Int).Value = miDtoPS.subtipo_seleccionado;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoParrafoTipo_Actualizar(DtoDoctoParrafoTipo miDtoPT)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoTipo_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoPT.docto_parrafo_tipo_id != -1)
                    con.ObjCommand.Parameters.Add("@docto_parrafo_tipo_id", SqlDbType.Int).Value = miDtoPT.docto_parrafo_tipo_id;
                if (miDtoPT.docto_parrafo_texto_id != -1)
                    con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = miDtoPT.docto_parrafo_texto_id;
                if (miDtoPT.tipo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_inspeccion_id", SqlDbType.Int).Value = miDtoPT.tipo_inspeccion_id;
                if (miDtoPT.tipo_seleccionado != -1)
                    con.ObjCommand.Parameters.Add("@tipo_seleccionado", SqlDbType.Int).Value = miDtoPT.tipo_seleccionado;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public DataSet Indicadores_AgregarActualizar(DtoIndicadores miDtoInd)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Indicadores_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = miDtoInd.sentencia;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = miDtoInd.indicador_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoInd.submateria_id;
                if (miDtoInd.requisito_id != -1)
                    con.ObjCommand.Parameters.Add("@requisito_id", SqlDbType.Int).Value = miDtoInd.requisito_id;
                if (miDtoInd.ind_consecutivo != -1)
                    con.ObjCommand.Parameters.Add("@ind_consecutivo", SqlDbType.Int).Value = miDtoInd.ind_consecutivo;
                if (miDtoInd.ind_indicador != "")
                    con.ObjCommand.Parameters.Add("@ind_indicador", SqlDbType.VarChar).Value = miDtoInd.ind_indicador;
                if (miDtoInd.ind_aplica_alcance != -1)
                    con.ObjCommand.Parameters.Add("@ind_aplica_alcance", SqlDbType.TinyInt).Value = miDtoInd.ind_aplica_alcance;
                if (miDtoInd.ind_alcance_inspeccion != "")
                    con.ObjCommand.Parameters.Add("@ind_alcance_inspeccion", SqlDbType.VarChar).Value = miDtoInd.ind_alcance_inspeccion;
                if (miDtoInd.ind_fundamento != "")
                    con.ObjCommand.Parameters.Add("@ind_fundamento", SqlDbType.VarChar).Value = miDtoInd.ind_fundamento;
                if (miDtoInd.ind_alcance != -1)
                    con.ObjCommand.Parameters.Add("@ind_alcance", SqlDbType.Int).Value = miDtoInd.ind_alcance;
                if (miDtoInd.ind_obligatorio != -1)
                    con.ObjCommand.Parameters.Add("@ind_obligatorio", SqlDbType.Int).Value = miDtoInd.ind_obligatorio;
                if (miDtoInd.ind_se_incluye_en_docto != -1)
                    con.ObjCommand.Parameters.Add("@ind_se_incluye_en_docto", SqlDbType.Int).Value = miDtoInd.ind_se_incluye_en_docto;
                if (miDtoInd.ind_dependiente != -1)
                    con.ObjCommand.Parameters.Add("@ind_dependiente", SqlDbType.Int).Value = miDtoInd.ind_dependiente;
                if (miDtoInd.ind_info_adicional != -1)
                    con.ObjCommand.Parameters.Add("@ind_info_adicional", SqlDbType.Int).Value = miDtoInd.ind_info_adicional;
                if (miDtoInd.ind_anexar_docto != -1)
                    con.ObjCommand.Parameters.Add("@ind_anexar_docto", SqlDbType.Int).Value = miDtoInd.ind_anexar_docto;
                if (miDtoInd.ind_incisos != -1)
                    con.ObjCommand.Parameters.Add("@ind_incisos", SqlDbType.Int).Value = miDtoInd.ind_incisos;
                if (miDtoInd.ind_conduce_medida != -1)
                    con.ObjCommand.Parameters.Add("@ind_conduce_medida", SqlDbType.Int).Value = miDtoInd.ind_conduce_medida;
                if (miDtoInd.ind_tipo_incumplimiento != -1)
                    con.ObjCommand.Parameters.Add("@ind_tipo_incumplimiento", SqlDbType.Int).Value = miDtoInd.ind_tipo_incumplimiento;
                if (miDtoInd.ind_respuesta_depende != "")
                    con.ObjCommand.Parameters.Add("@ind_respuesta_depende", SqlDbType.VarChar).Value = miDtoInd.ind_respuesta_depende;
                if (miDtoInd.indicador_depende_id != -1)
                    con.ObjCommand.Parameters.Add("@indicador_depende_id", SqlDbType.Int).Value = miDtoInd.indicador_depende_id;
                if (miDtoInd.ind_estatus != -1)
                    con.ObjCommand.Parameters.Add("@ind_estatus", SqlDbType.TinyInt).Value = miDtoInd.ind_estatus;
                if (miDtoInd.sys_usr != "")
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoInd.sys_usr;
                if (miDtoInd.ind_tema_nom_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_tema_nom_id", SqlDbType.Int).Value = miDtoInd.ind_tema_nom_id;
                if (miDtoInd.ind_tema_frecuente != -1)
                    con.ObjCommand.Parameters.Add("@ind_tema_frecuente", SqlDbType.Int).Value = miDtoInd.ind_tema_frecuente;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");
                return objDataSet;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public DataSet TipoDocumento_Actualizar(DtoTipoDocumento dtoTipoDocumento)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TipoDocumento_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoTipoDocumento.tipo_documento_id;
                if (dtoTipoDocumento.mat_normativa_version_id != -1)
                    con.ObjCommand.Parameters.Add("@mat_normativa_version_id", SqlDbType.Int).Value = dtoTipoDocumento.mat_normativa_version_id;
                if (dtoTipoDocumento.td_plantilla_html != "")
                    con.ObjCommand.Parameters.Add("@td_plantilla_html", SqlDbType.VarChar).Value = dtoTipoDocumento.td_plantilla_html;
                if (dtoTipoDocumento.code != "")
                    con.ObjCommand.Parameters.Add("@code", SqlDbType.VarChar).Value = dtoTipoDocumento.code;
                if (dtoTipoDocumento.orientacion_documento != "")
                    con.ObjCommand.Parameters.Add("@orientacion_documento", SqlDbType.VarChar).Value = dtoTipoDocumento.orientacion_documento;
                if (dtoTipoDocumento.td_url_plantilla != "")
                    con.ObjCommand.Parameters.Add("@td_url_plantilla", SqlDbType.VarChar).Value = dtoTipoDocumento.td_url_plantilla;
                if (dtoTipoDocumento.td_tipo_documento != "")
                    con.ObjCommand.Parameters.Add("@td_tipo_documento", SqlDbType.VarChar).Value = dtoTipoDocumento.td_tipo_documento;
                if (dtoTipoDocumento.td_aplica_aleatoria != -1)
                    con.ObjCommand.Parameters.Add("@td_aplica_aleatoria", SqlDbType.Int).Value = dtoTipoDocumento.td_aplica_aleatoria;
                if (dtoTipoDocumento.td_aplica_directa != -1)
                    con.ObjCommand.Parameters.Add("@td_aplica_directa", SqlDbType.Int).Value = dtoTipoDocumento.td_aplica_directa;
                if (dtoTipoDocumento.td_aplica_automatica != -1)
                    con.ObjCommand.Parameters.Add("@td_aplica_automatica", SqlDbType.Int).Value = dtoTipoDocumento.td_aplica_automatica;
                if (dtoTipoDocumento.td_proceso != -1)
                    con.ObjCommand.Parameters.Add("@td_proceso", SqlDbType.Int).Value = dtoTipoDocumento.td_proceso;
                if (dtoTipoDocumento.td_requiere_notificacion != -1)
                    con.ObjCommand.Parameters.Add("@td_requiere_notificacion", SqlDbType.Int).Value = dtoTipoDocumento.td_requiere_notificacion;
                if (dtoTipoDocumento.td_forma_entrega != -1)
                    con.ObjCommand.Parameters.Add("@td_forma_entrega", SqlDbType.Int).Value = dtoTipoDocumento.td_forma_entrega;
                if (dtoTipoDocumento.td_limite_entrega != -1)
                    con.ObjCommand.Parameters.Add("@td_limite_entrega", SqlDbType.Int).Value = dtoTipoDocumento.td_limite_entrega;
                if (dtoTipoDocumento.etapa != -1)
                    con.ObjCommand.Parameters.Add("@etapa", SqlDbType.VarChar).Value = dtoTipoDocumento.etapa.ToString();
                if (dtoTipoDocumento.sub_etapa != -1)
                    con.ObjCommand.Parameters.Add("@sub_etapa", SqlDbType.VarChar).Value = dtoTipoDocumento.sub_etapa.ToString();
                if (dtoTipoDocumento.td_controlada_sistema != -1)
                    con.ObjCommand.Parameters.Add("@td_controlada_sistema", SqlDbType.Int).Value = dtoTipoDocumento.td_controlada_sistema;
                if (dtoTipoDocumento.td_activo != -1)
                    con.ObjCommand.Parameters.Add("@td_activo", SqlDbType.Int).Value = dtoTipoDocumento.td_activo;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");
                return objDataSet;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void TipoDocumento_ActualizarWord(int tipo_documento_id, String td_url_plantilla, int normatividad_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TipoDocumentoWord_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = tipo_documento_id;
                con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = normatividad_id;
                con.ObjCommand.Parameters.Add("@td_url_plantilla  ", SqlDbType.VarChar).Value = td_url_plantilla;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int STipoDocumento_AgregarActualizar(DtoTipoDocumentoSipas dtoSTipoDocumento, string sentencia)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_STipoDocumento_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (dtoSTipoDocumento.s_tipo_documento_id > 0)
                    con.ObjCommand.Parameters.Add("@s_tipo_documento_id", SqlDbType.Int).Value = dtoSTipoDocumento.s_tipo_documento_id;
                if (dtoSTipoDocumento.s_etapa_id > 0)
                    con.ObjCommand.Parameters.Add("@s_etapa_id", SqlDbType.Int).Value = dtoSTipoDocumento.s_etapa_id;
                con.ObjCommand.Parameters.Add("@std_tipo_documento", SqlDbType.VarChar).Value = dtoSTipoDocumento.std_tipo_documento;
                con.ObjCommand.Parameters.Add("@std_url_plantilla", SqlDbType.VarChar).Value = dtoSTipoDocumento.std_url_plantilla;
                con.ObjCommand.Parameters.Add("@std_plantilla_html", SqlDbType.VarChar).Value = dtoSTipoDocumento.std_plantilla_html;
                con.ObjCommand.Parameters.Add("@code", SqlDbType.VarChar).Value = dtoSTipoDocumento.code;
                con.ObjCommand.Parameters.Add("@orientacion_documento", SqlDbType.VarChar).Value = dtoSTipoDocumento.orientacion_documento;
                con.ObjCommand.Parameters.Add("@tamanio_hoja", SqlDbType.VarChar).Value = dtoSTipoDocumento.tamanio_hoja;
                if (dtoSTipoDocumento.std_controlado_por_el_sistema >= 0)
                    con.ObjCommand.Parameters.Add("@std_controlado_por_el_sistema", SqlDbType.Int).Value = dtoSTipoDocumento.std_controlado_por_el_sistema;
                if (dtoSTipoDocumento.std_activo >= 0)
                    con.ObjCommand.Parameters.Add("@std_activo", SqlDbType.Int).Value = dtoSTipoDocumento.std_activo;
                con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = dtoSTipoDocumento.normativa_version_id;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int Inspeccion_AgregarActualizar(DtoInspeccion miDtoI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoI.inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoI.inspeccion_id;
                if (miDtoI.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoI.inspector_id;
                if (miDtoI.notificador_id != -1)
                    con.ObjCommand.Parameters.Add("@notificador_id", SqlDbType.Int).Value = miDtoI.notificador_id;
                if (miDtoI.mes_id != -1)
                    con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = miDtoI.mes_id;
                if (miDtoI.materia_id != -1)
                    con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoI.materia_id;
                if (miDtoI.fundamento_designacion_id != -1)
                    con.ObjCommand.Parameters.Add("@fundamento_designacion_id", SqlDbType.Int).Value = miDtoI.fundamento_designacion_id;
                if (miDtoI.motivo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = miDtoI.motivo_inspeccion_id;
                if (miDtoI.subtipo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = miDtoI.subtipo_inspeccion_id;
                if (miDtoI.operativo_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoI.operativo_id;
                if (miDtoI.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoI.cve_ur;
                if (miDtoI.cve_rama != -1)
                    con.ObjCommand.Parameters.Add("@cve_rama", SqlDbType.Int).Value = miDtoI.cve_rama;
                if (miDtoI.centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = miDtoI.centro_trabajo_id;
                if (miDtoI.in_anio != -1)
                    con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = miDtoI.in_anio;
                if (!String.IsNullOrEmpty(miDtoI.in_num_expediente))
                    con.ObjCommand.Parameters.Add("@in_num_expediente", SqlDbType.VarChar).Value = miDtoI.in_num_expediente;
                if (!String.IsNullOrEmpty(miDtoI.in_otra_submateria))
                    con.ObjCommand.Parameters.Add("@in_otra_submateria", SqlDbType.VarChar).Value = miDtoI.in_otra_submateria;
                if (!String.IsNullOrEmpty(miDtoI.in_ct_rfc))
                    con.ObjCommand.Parameters.Add("@in_ct_rfc", SqlDbType.VarChar).Value = miDtoI.in_ct_rfc;
                if (!String.IsNullOrEmpty(miDtoI.in_domicilio_inspeccion2))
                    con.ObjCommand.Parameters.Add("@in_domicilio_inspeccion2", SqlDbType.VarChar).Value = miDtoI.in_domicilio_inspeccion2;
                //if (!String.IsNullOrEmpty(miDtoI.in_otra_submateria))
                //    con.ObjCommand.Parameters.Add("@in_otra_submateria", SqlDbType.VarChar).Value = miDtoI.in_otra_submateria;
                if (!String.IsNullOrEmpty(miDtoI.in_ct_razon_social))
                    con.ObjCommand.Parameters.Add("@in_ct_razon_social", SqlDbType.VarChar).Value = miDtoI.in_ct_razon_social;
                if (!String.IsNullOrEmpty(miDtoI.in_ct_nombre))
                    con.ObjCommand.Parameters.Add("@in_ct_nombre", SqlDbType.VarChar).Value = miDtoI.in_ct_nombre;
                if (!String.IsNullOrEmpty(miDtoI.in_ct_imss_registro))
                    con.ObjCommand.Parameters.Add("@in_ct_imss_registro", SqlDbType.VarChar).Value = miDtoI.in_ct_imss_registro;
                if (!String.IsNullOrEmpty(miDtoI.in_ct_clase_riesgo))
                    con.ObjCommand.Parameters.Add("@in_ct_clase_riesgo", SqlDbType.VarChar).Value = miDtoI.in_ct_clase_riesgo;
                if (!String.IsNullOrEmpty(miDtoI.in_fec_inspeccion))
                    con.ObjCommand.Parameters.Add("@in_fec_inspeccion", SqlDbType.DateTime).Value = miDtoI.in_fec_inspeccion;
                if (!String.IsNullOrEmpty(miDtoI.in_hr_inspeccion))
                    con.ObjCommand.Parameters.Add("@in_hr_inspeccion", SqlDbType.VarChar).Value = miDtoI.in_hr_inspeccion;
                if (miDtoI.in_alcance != -1)
                    con.ObjCommand.Parameters.Add("@in_alcance", SqlDbType.Int).Value = miDtoI.in_alcance;
                if (miDtoI.in_habilitar_dias_inhabiles != -1)
                    con.ObjCommand.Parameters.Add("@in_habilitar_dias_inhabiles", SqlDbType.Int).Value = miDtoI.in_habilitar_dias_inhabiles;
                if (miDtoI.in_habilitar_horas_inhabiles != -1)
                    con.ObjCommand.Parameters.Add("@in_habilitar_horas_inhabiles", SqlDbType.Int).Value = miDtoI.in_habilitar_horas_inhabiles;
                if (miDtoI.in_incluye_noms_esp != -1)
                    con.ObjCommand.Parameters.Add("@in_incluye_noms_esp", SqlDbType.Int).Value = miDtoI.in_incluye_noms_esp;
                if (!String.IsNullOrEmpty(miDtoI.in_fec_emision))
                    con.ObjCommand.Parameters.Add("@in_fec_emision", SqlDbType.DateTime).Value = miDtoI.in_fec_emision;
                if (miDtoI.in_es_inspeccion_en_centro != -1)
                    con.ObjCommand.Parameters.Add("@in_es_inspeccion_en_centro", SqlDbType.Int).Value = miDtoI.in_es_inspeccion_en_centro;
                if (!String.IsNullOrEmpty(miDtoI.in_domicilio_inspeccion))
                    con.ObjCommand.Parameters.Add("@in_domicilio_inspeccion", SqlDbType.VarChar).Value = miDtoI.in_domicilio_inspeccion;
                if (miDtoI.in_firman_titulares != -1)
                    con.ObjCommand.Parameters.Add("@in_firman_titulares", SqlDbType.Int).Value = miDtoI.in_firman_titulares;
                if (!String.IsNullOrEmpty(miDtoI.in_nombre_firmante))
                    con.ObjCommand.Parameters.Add("@in_nombre_firmante", SqlDbType.VarChar).Value = miDtoI.in_nombre_firmante;
                if (!String.IsNullOrEmpty(miDtoI.in_cargo_firmante))
                    con.ObjCommand.Parameters.Add("@in_cargo_firmante", SqlDbType.VarChar).Value = miDtoI.in_cargo_firmante;
                if (miDtoI.in_generar_citatorio != -1)
                    con.ObjCommand.Parameters.Add("@in_generar_citatorio", SqlDbType.Int).Value = miDtoI.in_generar_citatorio;
                if (miDtoI.in_incluir_notificador != -1)
                    con.ObjCommand.Parameters.Add("@in_incluir_notificador", SqlDbType.Int).Value = miDtoI.in_incluir_notificador;
                if (miDtoI.in_en_declare != -1)
                    con.ObjCommand.Parameters.Add("@in_en_declare", SqlDbType.Int).Value = miDtoI.in_en_declare;
                if (miDtoI.in_en_passt != -1)
                    con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = miDtoI.in_en_passt;
                if (!String.IsNullOrEmpty(miDtoI.in_medio_informacion))
                    con.ObjCommand.Parameters.Add("@in_medio_informacion", SqlDbType.VarChar).Value = miDtoI.in_medio_informacion;
                if (!String.IsNullOrEmpty(miDtoI.in_req_documentos_inicio))
                    con.ObjCommand.Parameters.Add("@in_req_documentos_inicio", SqlDbType.DateTime).Value = miDtoI.in_req_documentos_inicio;
                if (!String.IsNullOrEmpty(miDtoI.in_req_documentos_termino))
                    con.ObjCommand.Parameters.Add("@in_req_documentos_termino", SqlDbType.DateTime).Value = miDtoI.in_req_documentos_termino;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_tipo_equipo))
                    con.ObjCommand.Parameters.Add("@in_rsp_tipo_equipo", SqlDbType.VarChar).Value = miDtoI.in_rsp_tipo_equipo;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_equipo))
                    con.ObjCommand.Parameters.Add("@in_rsp_equipo", SqlDbType.VarChar).Value = miDtoI.in_rsp_equipo;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_num_control))
                    con.ObjCommand.Parameters.Add("@in_rsp_num_control", SqlDbType.VarChar).Value = miDtoI.in_rsp_num_control;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_fec_autorizacion_provisional))
                    con.ObjCommand.Parameters.Add("@in_rsp_fec_autorizacion_provisional", SqlDbType.DateTime).Value = miDtoI.in_rsp_fec_autorizacion_provisional;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_tipo_aviso))
                    con.ObjCommand.Parameters.Add("@in_rsp_tipo_aviso", SqlDbType.VarChar).Value = miDtoI.in_rsp_tipo_aviso;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_folio))
                    con.ObjCommand.Parameters.Add("@in_rsp_folio", SqlDbType.VarChar).Value = miDtoI.in_rsp_folio;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_pruebas))
                    con.ObjCommand.Parameters.Add("@in_rsp_pruebas", SqlDbType.VarChar).Value = miDtoI.in_rsp_pruebas;
                if (miDtoI.in_resultado != -1)
                    con.ObjCommand.Parameters.Add("@in_resultado", SqlDbType.Int).Value = miDtoI.in_resultado;
                if (miDtoI.in_etapa != -1)
                    con.ObjCommand.Parameters.Add("@in_etapa", SqlDbType.Int).Value = miDtoI.in_etapa;
                if (miDtoI.in_estatus != -1)
                    con.ObjCommand.Parameters.Add("@in_estatus", SqlDbType.Int).Value = miDtoI.in_estatus;
                if (miDtoI.in_tipo_programacion_id != -1)
                    con.ObjCommand.Parameters.Add("@in_tipo_programacion_id", SqlDbType.Int).Value = miDtoI.in_tipo_programacion_id;
                if (miDtoI.in_id_firmante != -1)
                    con.ObjCommand.Parameters.Add("@in_id_firmante", SqlDbType.Int).Value = miDtoI.in_id_firmante;

                if (!String.IsNullOrEmpty(miDtoI.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoI.sys_usr;

                if (!String.IsNullOrEmpty(miDtoI.in_otra_materia_motivo))
                    con.ObjCommand.Parameters.Add("@in_otra_materia_motivo", SqlDbType.VarChar).Value = miDtoI.in_otra_materia_motivo;
                if (miDtoI.in_otra_materia_submateria != -1)
                    con.ObjCommand.Parameters.Add("@in_otra_materia_submateria", SqlDbType.Int).Value = miDtoI.in_otra_materia_submateria;

                if (!String.IsNullOrEmpty(miDtoI.normativa_version_id.ToString()) && miDtoI.normativa_version_id > 0)
                    con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = miDtoI.normativa_version_id;

                if (miDtoI.inspeccion_origen_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = miDtoI.inspeccion_origen_id;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int Inspeccion_Agrega_CopiarParaReprogramacion(int inspeccion_id, string sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_CopiarParaEmplazamientoReprogramacion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@emp_rep", SqlDbType.Int).Value = 2;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int Inspeccion_Agrega_CopiarParaEmplazamiento(int inspeccion_id, string sys_usr)
        {
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_CopiarParaEmplazamientoReprogramacion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@emp_rep", SqlDbType.Int).Value = 1;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        public int Inspeccion_Agrega_CopiarParaComprobacionSanciones(int inspeccion_id, string sys_usr)
        {
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_CopiarComprobacionSancionesReprogramacion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        public int Calificacion_Agrega_CopiarParaEmplazamientoDocumental(int inspeccion_id, string sys_usr)
        {
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Calificacion_CopiarParaEmplazamientoDocumental", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;

                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        //************************************************
        public int Inspeccion_Agregar(DtoInspeccion miDtoI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoI.inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoI.inspeccion_id;
                if (miDtoI.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoI.inspector_id;
                if (miDtoI.notificador_id != -1)
                    con.ObjCommand.Parameters.Add("@notificador_id", SqlDbType.Int).Value = miDtoI.notificador_id;
                if (miDtoI.mes_id != -1)
                    con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = miDtoI.mes_id;
                if (miDtoI.materia_id != -1)
                    con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoI.materia_id;
                if (miDtoI.fundamento_designacion_id != -1)
                    con.ObjCommand.Parameters.Add("@fundamento_designacion_id", SqlDbType.Int).Value = miDtoI.fundamento_designacion_id;
                if (miDtoI.motivo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = miDtoI.motivo_inspeccion_id;
                if (miDtoI.subtipo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = miDtoI.subtipo_inspeccion_id;
                if (miDtoI.operativo_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoI.operativo_id;
                if (miDtoI.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoI.cve_ur;
                if (miDtoI.cve_rama != -1)
                    con.ObjCommand.Parameters.Add("@cve_rama", SqlDbType.Int).Value = miDtoI.cve_rama;
                if (miDtoI.centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = miDtoI.centro_trabajo_id;
                if (miDtoI.in_anio != -1)
                    con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = miDtoI.in_anio;
                if (!String.IsNullOrEmpty(miDtoI.in_num_expediente))
                    con.ObjCommand.Parameters.Add("@in_num_expediente", SqlDbType.VarChar).Value = miDtoI.in_num_expediente;
                if (!String.IsNullOrEmpty(miDtoI.in_otra_submateria))
                    con.ObjCommand.Parameters.Add("@in_otra_submateria", SqlDbType.VarChar).Value = miDtoI.in_otra_submateria;
                if (!String.IsNullOrEmpty(miDtoI.in_ct_rfc))
                    con.ObjCommand.Parameters.Add("@in_ct_rfc", SqlDbType.VarChar).Value = miDtoI.in_ct_rfc;
                if (!String.IsNullOrEmpty(miDtoI.in_num_expediente))
                    con.ObjCommand.Parameters.Add("@in_num_expediente", SqlDbType.VarChar).Value = miDtoI.in_num_expediente;
                if (!String.IsNullOrEmpty(miDtoI.in_otra_submateria))
                    con.ObjCommand.Parameters.Add("@in_otra_submateria", SqlDbType.VarChar).Value = miDtoI.in_otra_submateria;
                if (!String.IsNullOrEmpty(miDtoI.in_ct_razon_social))
                    con.ObjCommand.Parameters.Add("@in_ct_razon_social", SqlDbType.VarChar).Value = miDtoI.in_ct_razon_social;
                if (!String.IsNullOrEmpty(miDtoI.in_ct_nombre))
                    con.ObjCommand.Parameters.Add("@in_ct_nombre", SqlDbType.VarChar).Value = miDtoI.in_ct_nombre;
                if (!String.IsNullOrEmpty(miDtoI.in_ct_imss_registro))
                    con.ObjCommand.Parameters.Add("@in_ct_imss_registro", SqlDbType.VarChar).Value = miDtoI.in_ct_imss_registro;
                if (!String.IsNullOrEmpty(miDtoI.in_ct_clase_riesgo))
                    con.ObjCommand.Parameters.Add("@in_ct_clase_riesgo", SqlDbType.VarChar).Value = miDtoI.in_ct_clase_riesgo;
                if (!String.IsNullOrEmpty(miDtoI.in_fec_inspeccion))
                    con.ObjCommand.Parameters.Add("@in_fec_inspeccion", SqlDbType.DateTime).Value = miDtoI.in_fec_inspeccion;
                if (miDtoI.in_alcance != -1)
                    con.ObjCommand.Parameters.Add("@in_alcance", SqlDbType.Int).Value = miDtoI.in_alcance;
                if (miDtoI.in_habilitar_dias_inhabiles != -1)
                    con.ObjCommand.Parameters.Add("@in_habilitar_dias_inhabiles", SqlDbType.Int).Value = miDtoI.in_habilitar_dias_inhabiles;
                if (miDtoI.in_habilitar_horas_inhabiles != -1)
                    con.ObjCommand.Parameters.Add("@in_habilitar_horas_inhabiles", SqlDbType.Int).Value = miDtoI.in_habilitar_horas_inhabiles;
                if (miDtoI.in_incluye_noms_esp != -1)
                    con.ObjCommand.Parameters.Add("@in_incluye_noms_esp", SqlDbType.Int).Value = miDtoI.in_incluye_noms_esp;
                if (!String.IsNullOrEmpty(miDtoI.in_fec_emision))
                    con.ObjCommand.Parameters.Add("@in_fec_emision", SqlDbType.DateTime).Value = miDtoI.in_fec_emision;
                if (miDtoI.in_es_inspeccion_en_centro != -1)
                    con.ObjCommand.Parameters.Add("@in_es_inspeccion_en_centro", SqlDbType.Int).Value = miDtoI.in_es_inspeccion_en_centro;
                if (!String.IsNullOrEmpty(miDtoI.in_domicilio_inspeccion))
                    con.ObjCommand.Parameters.Add("@in_domicilio_inspeccion", SqlDbType.VarChar).Value = miDtoI.in_domicilio_inspeccion;
                if (miDtoI.in_firman_titulares != -1)
                    con.ObjCommand.Parameters.Add("@in_firman_titulares", SqlDbType.Int).Value = miDtoI.in_firman_titulares;
                if (!String.IsNullOrEmpty(miDtoI.in_nombre_firmante))
                    con.ObjCommand.Parameters.Add("@in_nombre_firmante", SqlDbType.VarChar).Value = miDtoI.in_nombre_firmante;
                if (!String.IsNullOrEmpty(miDtoI.in_cargo_firmante))
                    con.ObjCommand.Parameters.Add("@in_cargo_firmante", SqlDbType.VarChar).Value = miDtoI.in_cargo_firmante;
                if (miDtoI.in_generar_citatorio != -1)
                    con.ObjCommand.Parameters.Add("@in_generar_citatorio", SqlDbType.Int).Value = miDtoI.in_generar_citatorio;
                if (miDtoI.in_incluir_notificador != -1)
                    con.ObjCommand.Parameters.Add("@in_incluir_notificador", SqlDbType.Int).Value = miDtoI.in_incluir_notificador;
                if (miDtoI.in_en_declare != -1)
                    con.ObjCommand.Parameters.Add("@in_en_declare", SqlDbType.Int).Value = miDtoI.in_en_declare;
                if (miDtoI.in_en_passt != -1)
                    con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = miDtoI.in_en_passt;
                if (!String.IsNullOrEmpty(miDtoI.in_medio_informacion))
                    con.ObjCommand.Parameters.Add("@in_medio_informacion", SqlDbType.VarChar).Value = miDtoI.in_medio_informacion;
                if (!String.IsNullOrEmpty(miDtoI.in_req_documentos_inicio))
                    con.ObjCommand.Parameters.Add("@in_req_documentos_inicio", SqlDbType.DateTime).Value = miDtoI.in_req_documentos_inicio;
                if (!String.IsNullOrEmpty(miDtoI.in_req_documentos_termino))
                    con.ObjCommand.Parameters.Add("@in_req_documentos_termino", SqlDbType.DateTime).Value = miDtoI.in_req_documentos_termino;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_tipo_equipo))
                    con.ObjCommand.Parameters.Add("@in_rsp_tipo_equipo", SqlDbType.VarChar).Value = miDtoI.in_rsp_tipo_equipo;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_equipo))
                    con.ObjCommand.Parameters.Add("@in_rsp_equipo", SqlDbType.VarChar).Value = miDtoI.in_rsp_equipo;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_num_control))
                    con.ObjCommand.Parameters.Add("@in_rsp_num_control", SqlDbType.VarChar).Value = miDtoI.in_rsp_num_control;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_fec_autorizacion_provisional))
                    con.ObjCommand.Parameters.Add("@in_rsp_fec_autorizacion_provisional", SqlDbType.VarChar).Value = miDtoI.in_rsp_fec_autorizacion_provisional;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_tipo_aviso))
                    con.ObjCommand.Parameters.Add("@in_rsp_tipo_aviso", SqlDbType.VarChar).Value = miDtoI.in_rsp_tipo_aviso;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_folio))
                    con.ObjCommand.Parameters.Add("@in_rsp_folio", SqlDbType.VarChar).Value = miDtoI.in_rsp_folio;
                if (!String.IsNullOrEmpty(miDtoI.in_rsp_pruebas))
                    con.ObjCommand.Parameters.Add("@in_rsp_pruebas", SqlDbType.VarChar).Value = miDtoI.in_rsp_pruebas;
                if (miDtoI.in_resultado != -1)
                    con.ObjCommand.Parameters.Add("@in_resultado", SqlDbType.Int).Value = miDtoI.in_resultado;
                if (miDtoI.in_etapa != -1)
                    con.ObjCommand.Parameters.Add("@in_etapa", SqlDbType.Int).Value = miDtoI.in_etapa;
                if (miDtoI.in_estatus != -1)
                    con.ObjCommand.Parameters.Add("@in_estatus", SqlDbType.Int).Value = miDtoI.in_estatus;
                if (miDtoI.in_tipo_programacion_id != -1)
                    con.ObjCommand.Parameters.Add("@in_tipo_programacion_id", SqlDbType.Int).Value = miDtoI.in_tipo_programacion_id;

                if (!String.IsNullOrEmpty(miDtoI.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoI.sys_usr;

                if (!String.IsNullOrEmpty(miDtoI.in_otra_materia_motivo))
                    con.ObjCommand.Parameters.Add("@in_otra_materia_motivo", SqlDbType.VarChar).Value = miDtoI.in_otra_materia_motivo;
                if (miDtoI.in_otra_materia_submateria != -1)
                    con.ObjCommand.Parameters.Add("@in_otra_materia_submateria", SqlDbType.Int).Value = miDtoI.in_otra_materia_submateria;
                if (miDtoI.normativa_version_id != -1)
                    con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = miDtoI.normativa_version_id;
                if (miDtoI.colectivo_id != -1)
                    con.ObjCommand.Parameters.Add("@colectivo_id", SqlDbType.Int).Value = miDtoI.colectivo_id;
                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void InspecExperto_AgregarActualizar(int inspec_experto_id, int inspeccion_id, String iexp_experto, String code_participante)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecExperto_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (inspec_experto_id != -1)
                    con.ObjCommand.Parameters.Add("@inspec_experto_id", SqlDbType.Int).Value = inspec_experto_id;
                if (inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                if (!String.IsNullOrEmpty(iexp_experto))
                    con.ObjCommand.Parameters.Add("@iexp_experto", SqlDbType.VarChar).Value = iexp_experto;
                if (!String.IsNullOrEmpty(code_participante))
                    con.ObjCommand.Parameters.Add("@code_participante", SqlDbType.VarChar).Value = code_participante;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void InspecParticipante_AgregarActualizar(DtoInspecParticipante miDtoIP)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecParticipante_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoIP.inspec_participante_id != -1)
                    con.ObjCommand.Parameters.Add("@inspec_participante_id", SqlDbType.Int).Value = miDtoIP.inspec_participante_id;
                if (miDtoIP.inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoIP.inspeccion_id;
                if (miDtoIP.participante_id != -1)
                    con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = miDtoIP.participante_id;
                if (miDtoIP.ipar_tipo_participacion != -1)
                    con.ObjCommand.Parameters.Add("@ipar_tipo_participacion", SqlDbType.Int).Value = miDtoIP.ipar_tipo_participacion;
                if (!String.IsNullOrEmpty(miDtoIP.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoIP.sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void InspecAdicional_AgregarActualizar(DtoInspecAdicional miDtoIA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecAdicional_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoIA.inspec_adicional_id != -1)
                    con.ObjCommand.Parameters.Add("@inspec_adicional_id", SqlDbType.Int).Value = miDtoIA.inspec_adicional_id;
                if (miDtoIA.inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoIA.inspeccion_id;
                if (miDtoIA.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoIA.inspector_id;
                if (miDtoIA.fundamento_designacion_id != -1)
                    con.ObjCommand.Parameters.Add("@fundamento_designacion_id", SqlDbType.Int).Value = miDtoIA.fundamento_designacion_id;
                if (!String.IsNullOrEmpty(miDtoIA.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoIA.sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void InspeccionCopia_Agregar(int inspeccion_id, string icop_nombre_copia, string sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecionCopia_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@icop_nombre_copia", SqlDbType.VarChar).Value = icop_nombre_copia;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void InspeccionCopia_Agregar(int inspeccion_id, string icop_nombre_copia, int icop_copia_o_rubrica, string sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecionCopia_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@icop_nombre_copia", SqlDbType.VarChar).Value = icop_nombre_copia;
                con.ObjCommand.Parameters.Add("@icop_copia_o_rubrica", SqlDbType.TinyInt).Value = icop_copia_o_rubrica;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Modificacion_AgregarActualizar(DtoModificacion miDtoM)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Modificacion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@modificacion_id", SqlDbType.Int).Value = miDtoM.modificacion_id;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoM.inspeccion_id;
                con.ObjCommand.Parameters.Add("@motivo_modificacion_id", SqlDbType.Int).Value = miDtoM.motivo_modificacion_id;
                con.ObjCommand.Parameters.Add("@mod_tipo_modificacion", SqlDbType.Int).Value = miDtoM.mod_tipo_modificacion;
                con.ObjCommand.Parameters.Add("@mod_descripcion", SqlDbType.VarChar).Value = miDtoM.mod_descripcion;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoM.sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void ProgAnual_ReplicarAnio(DtoProgAnual miDtoPA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAnual_ReplicarAnio", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@panual_anio", SqlDbType.Int).Value = miDtoPA.panual_anio;
                con.ObjCommand.Parameters.Add("@panual_meta_anual", SqlDbType.Int).Value = miDtoPA.panual_meta_anual;
                con.ObjCommand.Parameters.Add("@panual_num_inspectores", SqlDbType.Int).Value = miDtoPA.panual_num_inspectores;
                con.ObjCommand.Parameters.Add("@panual_inspecciones_por_inspector", SqlDbType.Decimal).Value = miDtoPA.panual_inspecciones_por_inspector;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoPA.sys_usr;
                con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = miDtoPA.normativa_version_id;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void ProgAnual_DuplicarPlaneacion_MismoAnio(DtoProgAnual miDtoPA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAnual_DuplicarPlanecion_MismoAnio", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@panual_anio", SqlDbType.Int).Value = miDtoPA.panual_anio;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoPA.sys_usr;
                con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = miDtoPA.normativa_version_id;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Inspeccion_AgregarAleatoria(int anio, int mes, int cve_ur, int anio_periodicas, string sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_AgregarAleatoria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@anio_periodicas", SqlDbType.Int).Value = anio_periodicas;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;
                con.ObjCommand.CommandTimeout = 0;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        public int Inspeccion_AgregarAleatoria_Will(int anio, int mes, int cve_ur, int anio_periodicas, string sys_usr, int cve_ur_comision, int normatividad_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_AgregarAleatoria_Will", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.CommandTimeout = 8000;
                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
                con.ObjCommand.Parameters.Add("@normatividad_id", SqlDbType.Int).Value = normatividad_id;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@cve_ur_comision", SqlDbType.Int).Value = cve_ur_comision;
                con.ObjCommand.Parameters.Add("@anio_periodicas", SqlDbType.Int).Value = anio_periodicas;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;
                con.ObjCommand.CommandTimeout = 0;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;




            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int Inspeccion_AgregarAleatoriaOperativo(int anio, int mes, int cve_ur, int operativo_id, int normativa_version_id, string sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_AgregarAleatoriaOperativo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = normativa_version_id;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void InspecCambioInspector_AgregarActualizar(DtoInspecCambioInspector miDtoICI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecCambioInspector_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoICI.inspeccion_id;
                if (miDtoICI.inspector_aleatorio_id != -1) con.ObjCommand.Parameters.Add("@inspector_aleatorio_id", SqlDbType.Int).Value = miDtoICI.inspector_aleatorio_id;
                con.ObjCommand.Parameters.Add("@nuevo_inspector_id", SqlDbType.Int).Value = miDtoICI.nuevo_inspector_id;
                con.ObjCommand.Parameters.Add("@fundamento_designacion_id", SqlDbType.Int).Value = miDtoICI.fundamento_designacion_id;
                con.ObjCommand.Parameters.Add("@ici_motivo_designacion", SqlDbType.VarChar).Value = miDtoICI.ici_motivo_designacion;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoICI.sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int IndTemaFrecuente_AgregarActualizar(DtoIndTemaFrecuente miDtoITF)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndTemaFrecuente_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_tema_frecuente_id", SqlDbType.Int).Value = miDtoITF.ind_tema_frecuente_id;
                con.ObjCommand.Parameters.Add("@indtfrec_consecutivo", SqlDbType.Int).Value = miDtoITF.indtfrec_consecutivo;
                con.ObjCommand.Parameters.Add("@indtfrec_tema", SqlDbType.VarChar).Value = miDtoITF.indtfrec_tema;
                con.ObjCommand.Parameters.Add("@indtfrec_estatus", SqlDbType.Int).Value = miDtoITF.indtfrec_estatus;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoITF.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int IndicadorTemaNom_AgregarActualizar(DtoIndTema miDtoI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndicadorTemaNom_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoI.ind_tema_nom_id != -1) con.ObjCommand.Parameters.Add("@ind_tema_nom_id", SqlDbType.Int).Value = miDtoI.ind_tema_nom_id;
                if (miDtoI.indtnom_consecutivo != -1) con.ObjCommand.Parameters.Add("@indtnom_consecutivo", SqlDbType.Int).Value = miDtoI.indtnom_consecutivo;

                if (miDtoI.submateria_id != -1) con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoI.submateria_id;
                if (miDtoI.indtnom_tema != "") con.ObjCommand.Parameters.Add("@indtnom_tema", SqlDbType.VarChar).Value = miDtoI.indtnom_tema;
                if (miDtoI.indtnom_tipo != -1) con.ObjCommand.Parameters.Add("@indtnom_tipo", SqlDbType.Int).Value = miDtoI.indtnom_tipo;
                if (miDtoI.indtnom_estatus != -1) con.ObjCommand.Parameters.Add("@indtnom_estatus", SqlDbType.Int).Value = miDtoI.indtnom_estatus;
                if (miDtoI.tema_padre_id != -1) con.ObjCommand.Parameters.Add("@tema_padre_id", SqlDbType.Int).Value = miDtoI.tema_padre_id;
                if (miDtoI.sys_ur != "") con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoI.sys_ur;
                if (miDtoI.sentencia != "") con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = miDtoI.sentencia;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int IndMedidaPlazo_AgregarActualizar(DtoIndMedidaPlazo miDtoIMP)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndMedidaPlazo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_medida_plazo_id", SqlDbType.Int).Value = miDtoIMP.ind_medida_plazo_id;
                con.ObjCommand.Parameters.Add("@imp_consecutivo", SqlDbType.Int).Value = miDtoIMP.imp_consecutivo;
                con.ObjCommand.Parameters.Add("@imp_descripcion", SqlDbType.VarChar).Value = miDtoIMP.imp_descripcion;
                con.ObjCommand.Parameters.Add("@imp_plazo_dias", SqlDbType.Int).Value = miDtoIMP.imp_plazo_dias;
                if (miDtoIMP.imp_opcion_prorroga != -1)
                    con.ObjCommand.Parameters.Add("@imp_opcion_prorroga", SqlDbType.Int).Value = miDtoIMP.imp_opcion_prorroga;
                if (miDtoIMP.imp_pct_prorroga != -1)
                    con.ObjCommand.Parameters.Add("@imp_pct_prorroga", SqlDbType.Int).Value = miDtoIMP.imp_pct_prorroga;
                if (miDtoIMP.imp_aplica_senalizacion != -1)
                    con.ObjCommand.Parameters.Add("@imp_aplica_senalizacion", SqlDbType.Int).Value = miDtoIMP.imp_aplica_senalizacion;
                con.ObjCommand.Parameters.Add("@imp_senalizacion", SqlDbType.VarChar).Value = miDtoIMP.imp_senalizacion;
                con.ObjCommand.Parameters.Add("@imp_estatus", SqlDbType.Int).Value = miDtoIMP.imp_estatus;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoIMP.sys_usr;
                con.ObjCommand.Parameters.Add("@imp_senializacion_corta", SqlDbType.VarChar).Value = miDtoIMP.imp_senializacion_corta;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }
        public int IndMedidaPlazo_VersionActualizar(DtoIndMedidaPlazo miDtoIMP)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndMedidaPlazo_VersionActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@nv_ind_medida_plazo_id", SqlDbType.Int).Value = miDtoIMP.nv_ind_medida_plazo_id;
                con.ObjCommand.Parameters.Add("@ind_medida_plazo_id", SqlDbType.Int).Value = miDtoIMP.ind_medida_plazo_id;
                con.ObjCommand.Parameters.Add("@imp_consecutivo", SqlDbType.Int).Value = miDtoIMP.imp_consecutivo;
                con.ObjCommand.Parameters.Add("@imp_descripcion", SqlDbType.VarChar).Value = miDtoIMP.imp_descripcion;
                con.ObjCommand.Parameters.Add("@imp_plazo_dias", SqlDbType.Int).Value = miDtoIMP.imp_plazo_dias;
                if (miDtoIMP.imp_opcion_prorroga != -1)
                    con.ObjCommand.Parameters.Add("@imp_opcion_prorroga", SqlDbType.Int).Value = miDtoIMP.imp_opcion_prorroga;
                if (miDtoIMP.imp_pct_prorroga != -1)
                    con.ObjCommand.Parameters.Add("@imp_pct_prorroga", SqlDbType.Int).Value = miDtoIMP.imp_pct_prorroga;
                if (miDtoIMP.imp_aplica_senalizacion != -1)
                    con.ObjCommand.Parameters.Add("@imp_aplica_senalizacion", SqlDbType.Int).Value = miDtoIMP.imp_aplica_senalizacion;
                con.ObjCommand.Parameters.Add("@imp_senalizacion", SqlDbType.VarChar).Value = miDtoIMP.imp_senalizacion;
                con.ObjCommand.Parameters.Add("@imp_estatus", SqlDbType.Int).Value = miDtoIMP.imp_estatus;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoIMP.sys_usr;
                con.ObjCommand.Parameters.Add("@imp_senializacion_corta", SqlDbType.VarChar).Value = miDtoIMP.imp_senializacion_corta;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int Incisos_AgregarActualizar(DtoInciso miDtoInc)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Incisos_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = miDtoInc.sentencia;
                if (miDtoInc.ind_inciso_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_inciso_id", SqlDbType.Int).Value = miDtoInc.ind_inciso_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = miDtoInc.indicador_id;
                con.ObjCommand.Parameters.Add("@inc_consecutivo", SqlDbType.Decimal).Value = miDtoInc.inc_consecutivo;
                con.ObjCommand.Parameters.Add("@inc_inciso", SqlDbType.VarChar).Value = miDtoInc.inc_inciso;
                con.ObjCommand.Parameters.Add("@inc_alcance", SqlDbType.Int).Value = miDtoInc.inc_alcance;
                con.ObjCommand.Parameters.Add("@inc_obligatorio", SqlDbType.Int).Value = miDtoInc.inc_obligatorio;
                if (miDtoInc.inc_info_adicional != -1)
                    con.ObjCommand.Parameters.Add("@inc_info_adicional", SqlDbType.Int).Value = miDtoInc.inc_info_adicional;
                con.ObjCommand.Parameters.Add("@inc_fundamento", SqlDbType.VarChar).Value = miDtoInc.inc_fundamento;
                con.ObjCommand.Parameters.Add("@inc_conduce_medida", SqlDbType.Int).Value = miDtoInc.inc_conduce_medida;
                con.ObjCommand.Parameters.Add("@inc_estatus", SqlDbType.Int).Value = miDtoInc.inc_estatus;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoInc.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void InfoAdicional_AgregarActualizar(DtoInfoAdicional miDtoInf)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InfoAdicional_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoInf.ind_info_adicional_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = miDtoInf.ind_info_adicional_id;

                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = miDtoInf.indicador_id;
                if (miDtoInf.ind_inciso_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_inciso_id", SqlDbType.Int).Value = miDtoInf.ind_inciso_id;
                if (miDtoInf.iia_respuesta_depende != -1)
                    con.ObjCommand.Parameters.Add("@iia_respuesta_depende", SqlDbType.SmallInt).Value = miDtoInf.iia_respuesta_depende;
                if (miDtoInf.iia_info_adicional != "")
                    con.ObjCommand.Parameters.Add("@iia_info_adicional", SqlDbType.VarChar).Value = miDtoInf.iia_info_adicional;
                if (miDtoInf.iia_consecutivo != -1)
                    con.ObjCommand.Parameters.Add("@iia_consecutivo", SqlDbType.Int).Value = miDtoInf.iia_consecutivo;
                if (miDtoInf.iia_forma_incorporar != -1)
                    con.ObjCommand.Parameters.Add("@iia_forma_incorporar", SqlDbType.SmallInt).Value = miDtoInf.iia_forma_incorporar;
                if (miDtoInf.iia_opciones != "")
                    con.ObjCommand.Parameters.Add("@iia_opciones", SqlDbType.VarChar).Value = miDtoInf.iia_opciones;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoInf.sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void IndMedida_AgregarActualizar(DtoIndMedida miDtoIndMed)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndMedida_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("ind_medida_id", SqlDbType.Int).Value = miDtoIndMed.ind_medida_id;
                if (miDtoIndMed.indicador_id != -1)
                    con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = miDtoIndMed.indicador_id;
                if (miDtoIndMed.ind_inciso_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_inciso_id", SqlDbType.Int).Value = miDtoIndMed.ind_inciso_id;
                if (miDtoIndMed.ind_medida_plazo_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_medida_plazo_id", SqlDbType.Int).Value = miDtoIndMed.ind_medida_plazo_id;
                if (miDtoIndMed.imed_tipo_incumplimiento != -1)
                    con.ObjCommand.Parameters.Add("@imed_tipo_incumplimiento", SqlDbType.Int).Value = miDtoIndMed.imed_tipo_incumplimiento;
                if (miDtoIndMed.imed_gravedad != -1)
                    con.ObjCommand.Parameters.Add("@imed_gravedad", SqlDbType.Int).Value = miDtoIndMed.imed_gravedad;
                if (miDtoIndMed.imed_respuesta != -1)
                    con.ObjCommand.Parameters.Add("@imed_respuesta", SqlDbType.Int).Value = miDtoIndMed.imed_respuesta;
                if (miDtoIndMed.imed_medida != "")
                    con.ObjCommand.Parameters.Add("@imed_medida", SqlDbType.VarChar).Value = miDtoIndMed.imed_medida;
                if (miDtoIndMed.descripcion_condenatoria != "")
                    con.ObjCommand.Parameters.Add("@descripcion_condenatoria", SqlDbType.VarChar).Value = miDtoIndMed.descripcion_condenatoria;
                if (miDtoIndMed.imed_estatus != -1)
                    con.ObjCommand.Parameters.Add("@imed_estatus", SqlDbType.Int).Value = miDtoIndMed.imed_estatus;
                if (miDtoIndMed.sys_usr != "")
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoIndMed.sys_usr;
                

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Inspeccion_Replicar(int mes_id, int cve_ur, int in_anio, int in_etapa, int operativo_id, int tipo, String sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_Replicar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes_id;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.VarChar).Value = in_anio;
                con.ObjCommand.Parameters.Add("@in_etapa", SqlDbType.Int).Value = in_etapa;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void EmplazamientoNumeral_Agregar(int emplazamiento_id, int inspeccion_origen_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_EmplazamientoNumeral_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        public void EmplazamientoNumeral_Agregar_PorNegativaPatronal(int emplazamiento_id, int inspeccion_origen_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_EmplazamientoNumeral_Agregar_PorNegativaPatronal", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int EmplazamientoNumeral_AgregarActualizar(DtoEmplazamientoNumeral dtoEmp)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_EmplazamientoNumeral_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_numeral_id", SqlDbType.Int).Value = dtoEmp.emplazamiento_numeral_id;
                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = dtoEmp.emplazamiento_id;

                if (dtoEmp.en_areas != "")
                    con.ObjCommand.Parameters.Add("@en_areas", SqlDbType.VarChar).Value = dtoEmp.en_areas;
                if (dtoEmp.en_fundamento != "")
                    con.ObjCommand.Parameters.Add("@en_fundamento", SqlDbType.VarChar).Value = dtoEmp.en_fundamento;
                if (dtoEmp.en_medida != "")
                    con.ObjCommand.Parameters.Add("@en_medida", SqlDbType.VarChar).Value = dtoEmp.en_medida;
                if (dtoEmp.en_numeral != "")
                    con.ObjCommand.Parameters.Add("@en_numeral", SqlDbType.VarChar).Value = dtoEmp.en_numeral;

                if (dtoEmp.en_consecutivo != -1)
                    con.ObjCommand.Parameters.Add("@en_consecutivo", SqlDbType.Int).Value = dtoEmp.en_consecutivo;
                if (dtoEmp.en_estatus != -1)
                    con.ObjCommand.Parameters.Add("@en_estatus", SqlDbType.Int).Value = dtoEmp.en_estatus;
                if (dtoEmp.ind_medida_plazo_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_medida_plazo_id", SqlDbType.Int).Value = dtoEmp.ind_medida_plazo_id;
                if (dtoEmp.submateria_id != -1)
                    con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = dtoEmp.submateria_id;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        #region Dsgho

        //*************AgregarDshgoCentroTrabajo
        public int DshgoCentroTrabajoAgregarActualizar(DtoDshgoCentroTrabajo DshgoCT)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoCentroTrabajo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (DshgoCT.dshgo_centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = DshgoCT.dshgo_centro_trabajo_id;
                if (DshgoCT.desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DshgoCT.desahogo_id;
                if (DshgoCT.dct_cae_id != -1)
                    con.ObjCommand.Parameters.Add("@dct_cae_id", SqlDbType.Int).Value = DshgoCT.dct_cae_id;
                if (DshgoCT.dct_dne_centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@dct_dne_centro_trabajo_id", SqlDbType.Int).Value = DshgoCT.dct_dne_centro_trabajo_id;
                if (DshgoCT.dct_dne_seguridad_social_id != -1)
                    con.ObjCommand.Parameters.Add("@dct_dne_seguridad_social_id", SqlDbType.Int).Value = DshgoCT.dct_dne_seguridad_social_id;
                if (DshgoCT.dct_dne_tipo_agencia_id != -1)
                    con.ObjCommand.Parameters.Add("@dct_dne_tipo_agencia_id", SqlDbType.Int).Value = DshgoCT.dct_dne_tipo_agencia_id;
                if (DshgoCT.dct_mismo_domicilio_fiscal != -1)
                    con.ObjCommand.Parameters.Add("@dct_mismo_domicilio_fiscal", SqlDbType.Int).Value = DshgoCT.dct_mismo_domicilio_fiscal;
                if (DshgoCT.dct_no_conoce_domicilio != -1)
                    con.ObjCommand.Parameters.Add("@dct_no_conoce_domicilio", SqlDbType.Int).Value = DshgoCT.dct_no_conoce_domicilio;
                if (!String.IsNullOrEmpty(DshgoCT.dct_razon_social))
                    con.ObjCommand.Parameters.Add("@dct_razon_social", SqlDbType.VarChar).Value = DshgoCT.dct_razon_social;
                if (!String.IsNullOrEmpty(DshgoCT.dct_rfc))
                    con.ObjCommand.Parameters.Add("@dct_rfc", SqlDbType.VarChar).Value = DshgoCT.dct_rfc;
                if (!String.IsNullOrEmpty(DshgoCT.dct_calle))
                    con.ObjCommand.Parameters.Add("@dct_calle", SqlDbType.VarChar).Value = DshgoCT.dct_calle;
                if (!String.IsNullOrEmpty(DshgoCT.dct_num_exterior))
                    con.ObjCommand.Parameters.Add("@dct_num_exterior", SqlDbType.VarChar).Value = DshgoCT.dct_num_exterior;
                //  if (!String.IsNullOrEmpty(DshgoCT.dct_num_interior))
                con.ObjCommand.Parameters.Add("@dct_num_interior", SqlDbType.VarChar).Value = DshgoCT.dct_num_interior;
                if (!String.IsNullOrEmpty(DshgoCT.dct_colonia))
                    con.ObjCommand.Parameters.Add("@dct_colonia", SqlDbType.VarChar).Value = DshgoCT.dct_colonia;
                //if (!String.IsNullOrEmpty(DshgoCT.dct_poblacion))
                con.ObjCommand.Parameters.Add("@dct_poblacion", SqlDbType.VarChar).Value = DshgoCT.dct_poblacion;
                if (!String.IsNullOrEmpty(DshgoCT.dct_cp))
                    con.ObjCommand.Parameters.Add("@dct_cp", SqlDbType.VarChar).Value = DshgoCT.dct_cp;
                // if (!String.IsNullOrEmpty(DshgoCT.dct_ref_ubicacion))
                con.ObjCommand.Parameters.Add("@dct_ref_ubicacion", SqlDbType.VarChar).Value = DshgoCT.dct_ref_ubicacion;
                //if (!String.IsNullOrEmpty(DshgoCT.dct_longitud))
                con.ObjCommand.Parameters.Add("@dct_longitud", SqlDbType.VarChar).Value = DshgoCT.dct_longitud;
                // if (!String.IsNullOrEmpty(DshgoCT.dct_latitud))
                con.ObjCommand.Parameters.Add("@dct_latitud", SqlDbType.VarChar).Value = DshgoCT.dct_latitud;
                //  if (!String.IsNullOrEmpty(DshgoCT.dct_telefono))
                con.ObjCommand.Parameters.Add("@dct_telefono", SqlDbType.VarChar).Value = DshgoCT.dct_telefono;
                //  if (!String.IsNullOrEmpty(DshgoCT.dct_fax))
                con.ObjCommand.Parameters.Add("@dct_fax", SqlDbType.VarChar).Value = DshgoCT.dct_fax;
                // if (!String.IsNullOrEmpty(DshgoCT.dct_email))
                con.ObjCommand.Parameters.Add("@dct_email", SqlDbType.VarChar).Value = DshgoCT.dct_email;
                if (DshgoCT.dct_cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@dct_cve_edorep", SqlDbType.Int).Value = DshgoCT.dct_cve_edorep;
                if (DshgoCT.dct_cve_municipio != -1)
                    con.ObjCommand.Parameters.Add("@dct_cve_municipio", SqlDbType.Int).Value = DshgoCT.dct_cve_municipio;
                if (DshgoCT.dct_cuenta_registro_patronal != -1)
                    con.ObjCommand.Parameters.Add("@dct_cuenta_registro_patronal", SqlDbType.Int).Value = DshgoCT.dct_cuenta_registro_patronal;
                //if (!String.IsNullOrEmpty(DshgoCT.dct_imss_registro))
                con.ObjCommand.Parameters.Add("@dct_imss_registro", SqlDbType.VarChar).Value = DshgoCT.dct_imss_registro;
                if (!String.IsNullOrEmpty(DshgoCT.dct_clase_riesgo))
                    con.ObjCommand.Parameters.Add("@dct_clase_riesgo", SqlDbType.VarChar).Value = DshgoCT.dct_clase_riesgo;
                if (DshgoCT.dct_prima_riesgo != -1)
                    con.ObjCommand.Parameters.Add("@dct_prima_riesgo", SqlDbType.Decimal).Value = DshgoCT.dct_prima_riesgo;
                if (DshgoCT.dct_tiene_sindicato != -1)
                    con.ObjCommand.Parameters.Add("@dct_tiene_sindicato", SqlDbType.Int).Value = DshgoCT.dct_tiene_sindicato;
                if (DshgoCT.dct_tiene_acta_constitutiva != -1)
                    con.ObjCommand.Parameters.Add("@dct_tiene_acta_constitutiva", SqlDbType.Int).Value = DshgoCT.dct_tiene_acta_constitutiva;
                if (!String.IsNullOrEmpty(DshgoCT.dct_notario_num_escritura))
                    con.ObjCommand.Parameters.Add("@dct_notario_num_escritura", SqlDbType.VarChar).Value = DshgoCT.dct_notario_num_escritura;
                if (!String.IsNullOrEmpty(DshgoCT.dct_notario_fec_emision))
                    con.ObjCommand.Parameters.Add("@dct_notario_fec_emision", SqlDbType.DateTime).Value = DshgoCT.dct_notario_fec_emision;
                if (!String.IsNullOrEmpty(DshgoCT.dct_notario_nombre))
                    con.ObjCommand.Parameters.Add("@dct_notario_nombre", SqlDbType.VarChar).Value = DshgoCT.dct_notario_nombre;
                if (!String.IsNullOrEmpty(DshgoCT.dct_notario_numero))
                    con.ObjCommand.Parameters.Add("@dct_notario_numero", SqlDbType.VarChar).Value = DshgoCT.dct_notario_numero;
                if (!String.IsNullOrEmpty(DshgoCT.dct_objeto_social))
                    con.ObjCommand.Parameters.Add("@dct_objeto_social", SqlDbType.VarChar).Value = DshgoCT.dct_objeto_social;
                if (DshgoCT.dct_notario_cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@dct_notario_cve_edorep", SqlDbType.Int).Value = DshgoCT.dct_notario_cve_edorep;
                if (DshgoCT.dct_contrato_colectivo != -1)
                    con.ObjCommand.Parameters.Add("@dct_contrato_colectivo", SqlDbType.Int).Value = DshgoCT.dct_contrato_colectivo;
                if (DshgoCT.dct_contrato_ley != -1)
                    con.ObjCommand.Parameters.Add("@dct_contrato_ley", SqlDbType.Int).Value = DshgoCT.dct_contrato_ley;
                if (DshgoCT.dct_contrato_individual != -1)
                    con.ObjCommand.Parameters.Add("@dct_contrato_individual", SqlDbType.Int).Value = DshgoCT.dct_contrato_individual;
                if (!String.IsNullOrEmpty(DshgoCT.dct_fec_colectivo))
                    con.ObjCommand.Parameters.Add("@dct_fec_colectivo", SqlDbType.DateTime).Value = DshgoCT.dct_fec_colectivo;
                if (!String.IsNullOrEmpty(DshgoCT.dct_fec_ley))
                    con.ObjCommand.Parameters.Add("@dct_fec_ley", SqlDbType.DateTime).Value = DshgoCT.dct_fec_ley;
                if (DshgoCT.dct_cuenta_fec_colectivo != -1)
                    con.ObjCommand.Parameters.Add("@dct_cuenta_fec_colectivo", SqlDbType.Int).Value = DshgoCT.dct_cuenta_fec_colectivo;
                if (DshgoCT.dct_cuenta_fec_ley != -1)
                    con.ObjCommand.Parameters.Add("@dct_cuenta_fec_ley", SqlDbType.Int).Value = DshgoCT.dct_cuenta_fec_ley;
                if (DshgoCT.dct_cuenta_capital_contable != -1)
                    con.ObjCommand.Parameters.Add("@dct_cuenta_capital_contable", SqlDbType.Int).Value = DshgoCT.dct_cuenta_capital_contable;
                if (!String.IsNullOrEmpty(DshgoCT.dct_capital_contable))
                    con.ObjCommand.Parameters.Add("@dct_capital_contable", SqlDbType.VarChar).Value = DshgoCT.dct_capital_contable;
                if (DshgoCT.dct_afiliado_camara != -1)
                    con.ObjCommand.Parameters.Add("@dct_afiliado_camara", SqlDbType.Int).Value = DshgoCT.dct_afiliado_camara;
                if (DshgoCT.dct_cuenta_solidarias != -1)
                    con.ObjCommand.Parameters.Add("@dct_cuenta_solidarias", SqlDbType.Int).Value = DshgoCT.dct_cuenta_solidarias;
                if (DshgoCT.dct_tiene_rspc != -1)
                    con.ObjCommand.Parameters.Add("@dct_tiene_rspc", SqlDbType.Int).Value = DshgoCT.dct_tiene_rspc;
                if (DshgoCT.dct_rspc_numero != -1)
                    con.ObjCommand.Parameters.Add("@dct_rspc_numero", SqlDbType.Int).Value = DshgoCT.dct_rspc_numero;
                if (DshgoCT.dct_rspc_calderas != -1)
                    con.ObjCommand.Parameters.Add("@dct_rspc_calderas", SqlDbType.Int).Value = DshgoCT.dct_rspc_calderas;
                if (DshgoCT.dct_rspc_criogenicos != -1)
                    con.ObjCommand.Parameters.Add("@dct_rspc_criogenicos", SqlDbType.Int).Value = DshgoCT.dct_rspc_criogenicos;
                if (DshgoCT.dct_sust_quimicas_peligrosas != -1)
                    con.ObjCommand.Parameters.Add("@dct_sust_quimicas_peligrosas", SqlDbType.Int).Value = DshgoCT.dct_sust_quimicas_peligrosas;
                if (DshgoCT.dct_liquidos_inflamables != -1)
                    con.ObjCommand.Parameters.Add("@dct_liquidos_inflamables", SqlDbType.Int).Value = DshgoCT.dct_liquidos_inflamables;
                if (DshgoCT.dct_materiales_piroforicos != -1)
                    con.ObjCommand.Parameters.Add("@dct_materiales_piroforicos", SqlDbType.Int).Value = DshgoCT.dct_materiales_piroforicos;

                if (!String.IsNullOrEmpty(DshgoCT.url_imagen_centro))
                    con.ObjCommand.Parameters.Add("@url_imagen_centro", SqlDbType.VarChar).Value = DshgoCT.url_imagen_centro;

                if (!String.IsNullOrEmpty(DshgoCT.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = DshgoCT.sys_usr;
                // if (!String.IsNullOrEmpty(DshgoCT.dct_nombre_comercial))
                con.ObjCommand.Parameters.Add("@dct_nombre_comercial", SqlDbType.VarChar).Value = DshgoCT.dct_nombre_comercial;

                if (DshgoCT.dct_doc_soporte != -1)
                    con.ObjCommand.Parameters.Add("@dct_doc_soporte", SqlDbType.Int).Value = DshgoCT.dct_doc_soporte;
                if (!String.IsNullOrEmpty(DshgoCT.dct_doc_soporte_descripcion))
                    con.ObjCommand.Parameters.Add("@dct_doc_soporte_descripcion", SqlDbType.VarChar).Value = DshgoCT.dct_doc_soporte_descripcion;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        //el otro DshgoCentroTrabajoAgregarActualizar
        public int DshgoCentroTrabajoAgregarActualizar2(DtoDshgoCentroTrabajo DshgoCT)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoCentroTrabajo_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (DshgoCT.dshgo_centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = DshgoCT.dshgo_centro_trabajo_id;
                if (DshgoCT.desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DshgoCT.desahogo_id;
                if (DshgoCT.dct_dne_centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@dct_dne_centro_trabajo_id", SqlDbType.Int).Value = DshgoCT.dct_dne_centro_trabajo_id;

                if (!String.IsNullOrEmpty(DshgoCT.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = DshgoCT.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }
        //****Agregar Dshgo Domicilio Fiscal
        public int DshgoDomicilioFiscalAgregarActualizar(DtoDshgoDomicilioFiscal DshgoDF)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDomicilioFiscal_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (DshgoDF.dshgo_domicilio_fiscal_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_domicilio_fiscal_id", SqlDbType.Int).Value = DshgoDF.dshgo_domicilio_fiscal_id;
                if (DshgoDF.dshgo_centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = DshgoDF.dshgo_centro_trabajo_id;
                if (DshgoDF.dne_centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@dne_centro_trabajo_id", SqlDbType.Int).Value = DshgoDF.dne_centro_trabajo_id;
                // if (!String.IsNullOrEmpty(DshgoDF.ddf_calle))
                con.ObjCommand.Parameters.Add("@ddf_calle ", SqlDbType.VarChar).Value = DshgoDF.ddf_calle;
                // if (!String.IsNullOrEmpty(DshgoDF.ddf_num_exterior))
                con.ObjCommand.Parameters.Add("@ddf_num_exterior ", SqlDbType.VarChar).Value = DshgoDF.ddf_num_exterior;
                //  if (!String.IsNullOrEmpty(DshgoDF.ddf_num_interior))
                con.ObjCommand.Parameters.Add("@ddf_num_interior ", SqlDbType.VarChar).Value = DshgoDF.ddf_num_interior;
                // if (!String.IsNullOrEmpty(DshgoDF.ddf_colonia))
                con.ObjCommand.Parameters.Add("@ddf_colonia ", SqlDbType.VarChar).Value = DshgoDF.ddf_colonia;
                // if (!String.IsNullOrEmpty(DshgoDF.ddf_poblacion))
                con.ObjCommand.Parameters.Add("@ddf_poblacion ", SqlDbType.VarChar).Value = DshgoDF.ddf_poblacion;
                //   if (!String.IsNullOrEmpty(DshgoDF.ddf_cp))
                con.ObjCommand.Parameters.Add("@ddf_cp ", SqlDbType.VarChar).Value = DshgoDF.ddf_cp;
                //   if (!String.IsNullOrEmpty(DshgoDF.ddf_ref_ubicacion))
                con.ObjCommand.Parameters.Add("@ddf_ref_ubicacion ", SqlDbType.VarChar).Value = DshgoDF.ddf_ref_ubicacion;
                //   if (!String.IsNullOrEmpty(DshgoDF.ddf_longitud))
                con.ObjCommand.Parameters.Add("@ddf_longitud ", SqlDbType.VarChar).Value = DshgoDF.ddf_longitud;
                //   if (!String.IsNullOrEmpty(DshgoDF.ddf_latitud))
                con.ObjCommand.Parameters.Add("@ddf_latitud ", SqlDbType.VarChar).Value = DshgoDF.ddf_latitud;
                //   if (!String.IsNullOrEmpty(DshgoDF.ddf_telefono))
                con.ObjCommand.Parameters.Add("@ddf_telefono ", SqlDbType.VarChar).Value = DshgoDF.ddf_telefono;
                //   if (!String.IsNullOrEmpty(DshgoDF.ddf_fax))
                con.ObjCommand.Parameters.Add("@ddf_fax ", SqlDbType.VarChar).Value = DshgoDF.ddf_fax;
                //   if (!String.IsNullOrEmpty(DshgoDF.ddf_email))
                con.ObjCommand.Parameters.Add("@ddf_email ", SqlDbType.VarChar).Value = DshgoDF.ddf_email;
                //   if (DshgoDF.ddf_cve_edorep != -1)
                con.ObjCommand.Parameters.Add("@ddf_cve_edorep ", SqlDbType.Int).Value = DshgoDF.ddf_cve_edorep;
                //    if (DshgoDF.ddf_cve_municipio != -1)
                con.ObjCommand.Parameters.Add("@ddf_cve_municipio ", SqlDbType.Int).Value = DshgoDF.ddf_cve_municipio;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DshgoMotivoInforme_AgregarActualizar(DtoDshgoMotivoInforme miDtoDMI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMotivoInforme_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_motivo_informe_id", SqlDbType.Int).Value = miDtoDMI.dshgo_motivo_informe_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = miDtoDMI.desahogo_id;
                con.ObjCommand.Parameters.Add("@motivo_informe_id", SqlDbType.VarChar).Value = miDtoDMI.motivo_informe_id;
                con.ObjCommand.Parameters.Add("@dshgo_motivo_otro", SqlDbType.VarChar).Value = miDtoDMI.dshgo_motivo_otro;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int Desahogo_Agregar(DtoDesahogo miDtoD)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Desahogo_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoD.desahogo_id != -1) con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = miDtoD.desahogo_id;
                if (miDtoD.inspeccion_id != -1) con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoD.inspeccion_id;
                if (miDtoD.notif_forma_constatacion_id != -1) con.ObjCommand.Parameters.Add("@notif_forma_constatacion_id", SqlDbType.Int).Value = miDtoD.notif_forma_constatacion_id;
                if (miDtoD.tipo_establecimiento_id != -1) con.ObjCommand.Parameters.Add("@tipo_establecimiento_id", SqlDbType.Int).Value = miDtoD.tipo_establecimiento_id;
                if (miDtoD.dshgo_tipo_desahogo != -1) con.ObjCommand.Parameters.Add("@dshgo_tipo_desahogo", SqlDbType.Int).Value = miDtoD.dshgo_tipo_desahogo;
                if (miDtoD.dshgo_se_pudo_constituir != -1) con.ObjCommand.Parameters.Add("@dshgo_se_pudo_constituir", SqlDbType.Int).Value = miDtoD.dshgo_se_pudo_constituir;
                if (miDtoD.dshgo_otro_motivo_informe != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_otro_motivo_informe", SqlDbType.VarChar).Value = miDtoD.dshgo_otro_motivo_informe;
                if (miDtoD.dshgo_otra_forma_constatacion != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_otra_forma_constatacion", SqlDbType.VarChar).Value = miDtoD.dshgo_otra_forma_constatacion;
                if (miDtoD.dshgo_forma_constatacion != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_forma_constatacion", SqlDbType.VarChar).Value = miDtoD.dshgo_forma_constatacion;
                if (miDtoD.dshgo_tiene_sindicato != -1) con.ObjCommand.Parameters.Add("@dshgo_tiene_sindicato", SqlDbType.Int).Value = miDtoD.dshgo_tiene_sindicato;
                if (miDtoD.dshgo_sin_testigos != -1) con.ObjCommand.Parameters.Add("@dshgo_sin_testigos", SqlDbType.Int).Value = miDtoD.dshgo_sin_testigos;
                if (miDtoD.dshgo_motivo_designacion != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_motivo_designacion", SqlDbType.VarChar).Value = miDtoD.dshgo_motivo_designacion;
                if (miDtoD.dshgo_participa_comision != -1) con.ObjCommand.Parameters.Add("@dshgo_participa_comision", SqlDbType.Int).Value = miDtoD.dshgo_participa_comision;
                if (miDtoD.dshgo_motivo_no_comision != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_motivo_no_comision", SqlDbType.VarChar).Value = miDtoD.dshgo_motivo_no_comision;
                if (miDtoD.dshgo_actividad_real != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_actividad_real", SqlDbType.VarChar).Value = miDtoD.dshgo_actividad_real;
                if (miDtoD.dshgo_otro_tipo_establecimiento != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_otro_tipo_establecimiento", SqlDbType.VarChar).Value = miDtoD.dshgo_otro_tipo_establecimiento;
                if (miDtoD.dshgo_otro_tipo_instalacion != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_otro_tipo_instalacion", SqlDbType.VarChar).Value = miDtoD.dshgo_otro_tipo_instalacion;
                if (miDtoD.dshgo_metros_construccion != -1) con.ObjCommand.Parameters.Add("@dshgo_metros_construccion", SqlDbType.Int).Value = miDtoD.dshgo_metros_construccion;
                if (miDtoD.dshgo_metros_superficie != -1) con.ObjCommand.Parameters.Add("@dshgo_metros_superficie", SqlDbType.Int).Value = miDtoD.dshgo_metros_superficie;
                if (miDtoD.dshgo_no_cuenta_trabajadores != -1) con.ObjCommand.Parameters.Add("@dshgo_no_cuenta_trabajadores", SqlDbType.Int).Value = miDtoD.dshgo_no_cuenta_trabajadores;
                if (miDtoD.dshgo_proceso_descripcion != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_proceso_descripcion", SqlDbType.VarChar).Value = miDtoD.dshgo_proceso_descripcion;
                if (miDtoD.dshgo_proceso_productos != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_proceso_productos", SqlDbType.VarChar).Value = miDtoD.dshgo_proceso_productos;
                if (miDtoD.dshgo_proceso_desechos != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_proceso_desechos", SqlDbType.VarChar).Value = miDtoD.dshgo_proceso_desechos;
                if (miDtoD.dshgo_proceso_maquinaria != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_proceso_maquinaria", SqlDbType.VarChar).Value = miDtoD.dshgo_proceso_maquinaria;
                if (miDtoD.dshgo_proceso_tarifa != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_proceso_tarifa", SqlDbType.VarChar).Value = miDtoD.dshgo_proceso_tarifa;
                if (miDtoD.dshgo_no_interrogatorios != -1) con.ObjCommand.Parameters.Add("@dshgo_no_interrogatorios", SqlDbType.Int).Value = miDtoD.dshgo_no_interrogatorios;
                if (miDtoD.dshgo_tipo_cierre != -1) con.ObjCommand.Parameters.Add("@dshgo_tipo_cierre", SqlDbType.Int).Value = miDtoD.dshgo_tipo_cierre;
                if (miDtoD.dshgo_fec_cierre_parcial != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_fec_cierre_parcial", SqlDbType.DateTime).Value = miDtoD.dshgo_fec_cierre_parcial;
                if (miDtoD.dshgo_motivo_parcial != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_motivo_parcial", SqlDbType.VarChar).Value = miDtoD.dshgo_motivo_parcial;
                if (miDtoD.dshgo_fec_reinicio != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_fec_reinicio", SqlDbType.DateTime).Value = miDtoD.dshgo_fec_reinicio;
                if (miDtoD.dshgo_fec_cierre != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_fec_cierre", SqlDbType.DateTime).Value = miDtoD.dshgo_fec_cierre;
                if (miDtoD.dshgo_forma_entrega_informe != -1) con.ObjCommand.Parameters.Add("@dshgo_forma_entrega_informe", SqlDbType.Int).Value = miDtoD.dshgo_forma_entrega_informe;
                if (miDtoD.dshgo_motivo_negativa != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_motivo_negativa", SqlDbType.VarChar).Value = miDtoD.dshgo_motivo_negativa;
                if (miDtoD.dshgo_con_notif_electronica != -1) con.ObjCommand.Parameters.Add("@dshgo_con_notif_electronica", SqlDbType.Int).Value = miDtoD.dshgo_con_notif_electronica;
                if (miDtoD.dshgo_recibe_claves != -1) con.ObjCommand.Parameters.Add("@dshgo_recibe_claves", SqlDbType.Int).Value = miDtoD.dshgo_recibe_claves;
                if (miDtoD.dshgo_usuario_clave != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_usuario_clave", SqlDbType.VarChar).Value = miDtoD.dshgo_usuario_clave;
                if (miDtoD.dshgo_usuario_password != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_usuario_password", SqlDbType.VarChar).Value = miDtoD.dshgo_usuario_password;
                if (miDtoD.dshgo_estatus != -1) con.ObjCommand.Parameters.Add("@dshgo_estatus", SqlDbType.Int).Value = miDtoD.dshgo_estatus;
                if (miDtoD.sys_usr != String.Empty) con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoD.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }

        }

        public int Desahogo_CopiarParaEmplazamientoReprogramacion(int inspeccion_id, int dshgo_tipo_desahogo, string sys_usr, int inspeccion_origen_id = -1)
        {
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Desahogo_CopiarParaEmplazamientoReprogramacion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                if (dshgo_tipo_desahogo == -1)
                    dshgo_tipo_desahogo = 0;
                con.ObjCommand.Parameters.Add("@dshgo_tipo_desahogo", SqlDbType.Int).Value = dshgo_tipo_desahogo;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;
                if (inspeccion_origen_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int Desahogo_AgregarActualizar(DtoDesahogo miDtoD)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Desahogo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoD.desahogo_id != -1) con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = miDtoD.desahogo_id;
                if (miDtoD.inspeccion_id != -1) con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoD.inspeccion_id;
                if (miDtoD.notif_forma_constatacion_id != -1) con.ObjCommand.Parameters.Add("@notif_forma_constatacion_id", SqlDbType.Int).Value = miDtoD.notif_forma_constatacion_id;
                if (miDtoD.tipo_establecimiento_id != -1) con.ObjCommand.Parameters.Add("@tipo_establecimiento_id", SqlDbType.Int).Value = miDtoD.tipo_establecimiento_id;
                if (miDtoD.dshgo_tipo_desahogo != -1) con.ObjCommand.Parameters.Add("@dshgo_tipo_desahogo", SqlDbType.Int).Value = miDtoD.dshgo_tipo_desahogo;
                if (miDtoD.dshgo_se_pudo_constituir != -1) con.ObjCommand.Parameters.Add("@dshgo_se_pudo_constituir", SqlDbType.Int).Value = miDtoD.dshgo_se_pudo_constituir;
                if (miDtoD.dshgo_otro_motivo_informe != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_otro_motivo_informe", SqlDbType.VarChar).Value = miDtoD.dshgo_otro_motivo_informe;
                if (miDtoD.dshgo_otra_forma_constatacion != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_otra_forma_constatacion", SqlDbType.VarChar).Value = miDtoD.dshgo_otra_forma_constatacion;
                if (miDtoD.dshgo_forma_constatacion != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_forma_constatacion", SqlDbType.VarChar).Value = miDtoD.dshgo_forma_constatacion;
                if (miDtoD.dshgo_tiene_sindicato != -1) con.ObjCommand.Parameters.Add("@dshgo_tiene_sindicato", SqlDbType.Int).Value = miDtoD.dshgo_tiene_sindicato;
                if (miDtoD.dshgo_sin_testigos != -1) con.ObjCommand.Parameters.Add("@dshgo_sin_testigos", SqlDbType.Int).Value = miDtoD.dshgo_sin_testigos;
                if (miDtoD.dshgo_motivo_designacion != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_motivo_designacion", SqlDbType.VarChar).Value = miDtoD.dshgo_motivo_designacion;
                if (miDtoD.dshgo_participa_comision != -1) con.ObjCommand.Parameters.Add("@dshgo_participa_comision", SqlDbType.Int).Value = miDtoD.dshgo_participa_comision;
                if (miDtoD.dshgo_motivo_no_comision != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_motivo_no_comision", SqlDbType.VarChar).Value = miDtoD.dshgo_motivo_no_comision;
                if (miDtoD.dshgo_actividad_real != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_actividad_real", SqlDbType.VarChar).Value = miDtoD.dshgo_actividad_real;
                if (miDtoD.dshgo_otro_tipo_establecimiento != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_otro_tipo_establecimiento", SqlDbType.VarChar).Value = miDtoD.dshgo_otro_tipo_establecimiento;
                if (miDtoD.dshgo_otro_tipo_instalacion != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_otro_tipo_instalacion", SqlDbType.VarChar).Value = miDtoD.dshgo_otro_tipo_instalacion;
                if (miDtoD.dshgo_metros_construccion != -1) con.ObjCommand.Parameters.Add("@dshgo_metros_construccion", SqlDbType.Int).Value = miDtoD.dshgo_metros_construccion;
                if (miDtoD.dshgo_metros_superficie != -1) con.ObjCommand.Parameters.Add("@dshgo_metros_superficie", SqlDbType.Int).Value = miDtoD.dshgo_metros_superficie;
                if (miDtoD.dshgo_no_cuenta_trabajadores != -1) con.ObjCommand.Parameters.Add("@dshgo_no_cuenta_trabajadores", SqlDbType.Int).Value = miDtoD.dshgo_no_cuenta_trabajadores;
                if (miDtoD.dshgo_proceso_descripcion != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_proceso_descripcion", SqlDbType.VarChar).Value = miDtoD.dshgo_proceso_descripcion;
                if (miDtoD.dshgo_proceso_productos != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_proceso_productos", SqlDbType.VarChar).Value = miDtoD.dshgo_proceso_productos;
                if (miDtoD.dshgo_proceso_desechos != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_proceso_desechos", SqlDbType.VarChar).Value = miDtoD.dshgo_proceso_desechos;
                if (miDtoD.dshgo_proceso_maquinaria != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_proceso_maquinaria", SqlDbType.VarChar).Value = miDtoD.dshgo_proceso_maquinaria;
                if (miDtoD.dshgo_proceso_tarifa != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_proceso_tarifa", SqlDbType.VarChar).Value = miDtoD.dshgo_proceso_tarifa;
                if (miDtoD.dshgo_no_interrogatorios != -1) con.ObjCommand.Parameters.Add("@dshgo_no_interrogatorios", SqlDbType.Int).Value = miDtoD.dshgo_no_interrogatorios;
                if (miDtoD.dshgo_no_listado != -1) con.ObjCommand.Parameters.Add("@dshgo_no_listado", SqlDbType.Int).Value = miDtoD.dshgo_no_listado;
                if (miDtoD.dshgo_tipo_cierre != -1) con.ObjCommand.Parameters.Add("@dshgo_tipo_cierre", SqlDbType.Int).Value = miDtoD.dshgo_tipo_cierre;
                if (miDtoD.dshgo_fec_cierre_parcial != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_fec_cierre_parcial", SqlDbType.DateTime).Value = miDtoD.dshgo_fec_cierre_parcial;
                if (miDtoD.dshgo_motivo_parcial != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_motivo_parcial", SqlDbType.VarChar).Value = miDtoD.dshgo_motivo_parcial;
                if (miDtoD.dshgo_fec_reinicio != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_fec_reinicio", SqlDbType.DateTime).Value = miDtoD.dshgo_fec_reinicio;
                if (miDtoD.dshgo_fec_cierre != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_fec_cierre", SqlDbType.DateTime).Value = miDtoD.dshgo_fec_cierre;
                if (miDtoD.dshgo_forma_entrega_informe != -1) con.ObjCommand.Parameters.Add("@dshgo_forma_entrega_informe", SqlDbType.Int).Value = miDtoD.dshgo_forma_entrega_informe;
                if (miDtoD.dshgo_motivo_negativa != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_motivo_negativa", SqlDbType.VarChar).Value = miDtoD.dshgo_motivo_negativa;
                if (miDtoD.dshgo_con_notif_electronica != -1)
                {
                    if (miDtoD.dshgo_con_notif_electronica == 2)
                        miDtoD.dshgo_con_notif_electronica = null;
                    con.ObjCommand.Parameters.Add("@dshgo_con_notif_electronica", SqlDbType.Int).Value = miDtoD.dshgo_con_notif_electronica;
                }
                    
                if (miDtoD.dshgo_recibe_claves != -1)
                {
                    if (miDtoD.dshgo_recibe_claves == 2)
                        miDtoD.dshgo_recibe_claves = null;
                    con.ObjCommand.Parameters.Add("@dshgo_recibe_claves", SqlDbType.Int).Value = miDtoD.dshgo_recibe_claves;
                }
                    
                if (miDtoD.dshgo_usuario_clave != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_usuario_clave", SqlDbType.VarChar).Value = miDtoD.dshgo_usuario_clave;
                if (miDtoD.dshgo_usuario_password != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_usuario_password", SqlDbType.VarChar).Value = miDtoD.dshgo_usuario_password;
                if (miDtoD.dshgo_genera_acta_como_visita != -1) con.ObjCommand.Parameters.Add("@dshgo_genera_acta_como_visita", SqlDbType.Int).Value = miDtoD.dshgo_genera_acta_como_visita;
                if (miDtoD.dshgo_estatus != -1) con.ObjCommand.Parameters.Add("@dshgo_estatus", SqlDbType.Int).Value = miDtoD.dshgo_estatus;
                if (miDtoD.sys_usr != String.Empty) con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoD.sys_usr;

                if (miDtoD.dshgo_no_cuenta_trabajadores_motivo != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_no_cuenta_trabajadores_motivo", SqlDbType.VarChar).Value = miDtoD.dshgo_no_cuenta_trabajadores_motivo;
                if (miDtoD.dshgo_no_cuenta_solidaria != -1) con.ObjCommand.Parameters.Add("@dshgo_no_cuenta_solidaria", SqlDbType.Int).Value = miDtoD.dshgo_no_cuenta_solidaria;

                if (!String.IsNullOrEmpty(miDtoD.dshgo_descripcion_resultado))
                    con.ObjCommand.Parameters.Add("@dshgo_descripcion_resultado", SqlDbType.VarChar).Value = miDtoD.dshgo_descripcion_resultado;

                if (miDtoD.dshgo_fec_cierre_parcial2 != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_fec_cierre_parcial2", SqlDbType.DateTime).Value = miDtoD.dshgo_fec_cierre_parcial2;
                if (miDtoD.dshgo_motivo_parcial2 != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_motivo_parcial2", SqlDbType.VarChar).Value = miDtoD.dshgo_motivo_parcial2;
                if (miDtoD.dshgo_fec_reinicio2 != String.Empty) con.ObjCommand.Parameters.Add("@dshgo_fec_reinicio2", SqlDbType.DateTime).Value = miDtoD.dshgo_fec_reinicio2;

                if (miDtoD.dshgo_sin_consulta_restriccion != -1) con.ObjCommand.Parameters.Add("@dshgo_sin_consulta_restriccion", SqlDbType.Int).Value = miDtoD.dshgo_sin_consulta_restriccion;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }

        }

        public void Dshgo_Area_AgregarActualizar(DtoDshgoArea miDtoDsA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Area_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoDsA.dsgo_area_id != -1) con.ObjCommand.Parameters.Add("@dsgo_area_id", SqlDbType.Int).Value = miDtoDsA.dsgo_area_id;
                if (miDtoDsA.desahogo_id != -1) con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = miDtoDsA.desahogo_id;
                if (miDtoDsA.darea_orden != -1) con.ObjCommand.Parameters.Add("@darea_orden", SqlDbType.Int).Value = miDtoDsA.darea_orden;
                if (miDtoDsA.darea_area != String.Empty) con.ObjCommand.Parameters.Add("@darea_area", SqlDbType.VarChar).Value = miDtoDsA.darea_area;
                if (miDtoDsA.sys_usr != String.Empty) con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoDsA.sys_usr;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DshgoAlcance_AgregarActualizar(DtoDshgoAlcance miDtoDAl)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoAlcance_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoDAl.dshgo_alcance_id != -1) con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = miDtoDAl.dshgo_alcance_id;
                if (miDtoDAl.desahogo_id != -1) con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = miDtoDAl.desahogo_id;
                if (miDtoDAl.submateria_id != -1) con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoDAl.submateria_id;
                if (miDtoDAl.sys_usr != String.Empty) con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoDAl.sys_usr;
                if (miDtoDAl.dsal_estatus != -1) con.ObjCommand.Parameters.Add("@dsal_estatus", SqlDbType.Int).Value = miDtoDAl.dsal_estatus;
                if (miDtoDAl.dsal_no_aplica != -1) con.ObjCommand.Parameters.Add("@dsal_no_aplica", SqlDbType.Int).Value = miDtoDAl.dsal_no_aplica;
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DshgoInterrogatorio_AgregarActualizar(DtoDshgoInterrogatorio miDtoDshgoInt)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInterrogatorio_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoDshgoInt.dshgo_interrogatorio_id != -1) con.ObjCommand.Parameters.Add("@dshgo_interrogatorio_id", SqlDbType.Int).Value = miDtoDshgoInt.dshgo_interrogatorio_id;
                if (miDtoDshgoInt.dshgo_pregunta_id != -1) con.ObjCommand.Parameters.Add("@dshgo_pregunta_id", SqlDbType.Int).Value = miDtoDshgoInt.dshgo_pregunta_id;
                if (miDtoDshgoInt.dshgo_interrogado_id != -1) con.ObjCommand.Parameters.Add("@dshgo_interrogado_id", SqlDbType.Int).Value = miDtoDshgoInt.dshgo_interrogado_id;
                if (miDtoDshgoInt.dshgo_pregunta_respuesta != -1) con.ObjCommand.Parameters.Add("@dshgo_pregunta_respuesta", SqlDbType.VarChar).Value = miDtoDshgoInt.dshgo_pregunta_respuesta;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Dshgo_RepEmp_AgregarActualizar(DtoDshgoRepEmpresa miDtoDshgoRepEmp)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_RepEmpresa_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (miDtoDshgoRepEmp.dshgo_rep_empresa_id != -1) con.ObjCommand.Parameters.Add("@dshgo_rep_empresa_id", SqlDbType.Int).Value = miDtoDshgoRepEmp.dshgo_rep_empresa_id;
                if (miDtoDshgoRepEmp.dshgo_participante_id != -1) con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = miDtoDshgoRepEmp.dshgo_participante_id;
                if (miDtoDshgoRepEmp.tipo_representante_id != -1) con.ObjCommand.Parameters.Add("@tipo_representante_id ", SqlDbType.SmallInt).Value = miDtoDshgoRepEmp.tipo_representante_id;
                if (miDtoDshgoRepEmp.tipo_identificacion_id != -1) con.ObjCommand.Parameters.Add("@tipo_identificacion_id", SqlDbType.SmallInt).Value = miDtoDshgoRepEmp.tipo_identificacion_id;
                if (miDtoDshgoRepEmp.dremp_tipo_acreditacion != String.Empty) con.ObjCommand.Parameters.Add("@dremp_tipo_acreditacion", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_tipo_acreditacion;
                if (miDtoDshgoRepEmp.dremp_se_acredita != -1) con.ObjCommand.Parameters.Add("@dremp_se_acredita ", SqlDbType.SmallInt).Value = miDtoDshgoRepEmp.dremp_se_acredita;
                if (miDtoDshgoRepEmp.dremp_se_identifica != -1) con.ObjCommand.Parameters.Add("@dremp_se_identifica", SqlDbType.TinyInt).Value = miDtoDshgoRepEmp.dremp_se_identifica;
                con.ObjCommand.Parameters.Add("@dremp_acreditacion_documento", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_acreditacion_documento;
                con.ObjCommand.Parameters.Add("@dremp_acreditacion_num_escritura ", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_acreditacion_num_escritura;
                if (miDtoDshgoRepEmp.dremp_acreditacion_fec_emision != String.Empty) con.ObjCommand.Parameters.Add("@dremp_acreditacion_fec_emision", SqlDbType.DateTime).Value = miDtoDshgoRepEmp.dremp_acreditacion_fec_emision;
                if (miDtoDshgoRepEmp.dremp_acreditacion_notario != String.Empty) con.ObjCommand.Parameters.Add("@dremp_acreditacion_notario", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_acreditacion_notario;
                con.ObjCommand.Parameters.Add("@dremp_acrecitacion_notario_numero ", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_acrecitacion_notario_numero;
                if (miDtoDshgoRepEmp.dremp_acreditacion_entidad != -1) con.ObjCommand.Parameters.Add("@dremp_acreditacion_entidad", SqlDbType.SmallInt).Value = miDtoDshgoRepEmp.dremp_acreditacion_entidad;
                if (miDtoDshgoRepEmp.dremp_acreditacion_rfc != String.Empty) con.ObjCommand.Parameters.Add("@dremp_acreditacion_rfc", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_acreditacion_rfc;
                con.ObjCommand.Parameters.Add("@dremp_acreditacion_actividad ", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_acreditacion_actividad;
                if (miDtoDshgoRepEmp.dremp_acreditacion_fec_inscripcion != String.Empty) con.ObjCommand.Parameters.Add("@dremp_acreditacion_fec_inscripcion", SqlDbType.DateTime).Value = miDtoDshgoRepEmp.dremp_acreditacion_fec_inscripcion;
                if (miDtoDshgoRepEmp.dremp_acreditacion_fec_inicio != String.Empty) con.ObjCommand.Parameters.Add("@dremp_acreditacion_fec_inicio", SqlDbType.DateTime).Value = miDtoDshgoRepEmp.dremp_acreditacion_fec_inicio;
                con.ObjCommand.Parameters.Add("@dremp_acreditacion_reg_patronal", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_acreditacion_reg_patronal;
                con.ObjCommand.Parameters.Add("@dremp_acreditacion_giro_economico", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_acreditacion_giro_economico;
                con.ObjCommand.Parameters.Add("@dremp_acreditacion_contrato_servicios ", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_acreditacion_contrato_servicios;
                con.ObjCommand.Parameters.Add("@dremp_acreditacion_empresa_contratista", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_acreditacion_empresa_contratista;
                con.ObjCommand.Parameters.Add("@dremp_media_filiacion", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_media_filiacion;
                con.ObjCommand.Parameters.Add("@dremp_identificacion_numero ", SqlDbType.VarChar).Value = miDtoDshgoRepEmp.dremp_identificacion_numero;
                if (miDtoDshgoRepEmp.dremp_facilidades_desahogo != -1) con.ObjCommand.Parameters.Add("@dremp_facilidades_desahogo ", SqlDbType.TinyInt).Value = miDtoDshgoRepEmp.dremp_facilidades_desahogo;
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Dshgo_Inspector_AgregarActualizar(DtoDshgoInspector miDtoDshgoInspector)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Inspectores_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                //if (miDtoDshgoInspector.dshgo_inspector_id != -1) con.ObjCommand.Parameters.Add("@dshgo_rep_empresa_id", SqlDbType.Int).Value = miDtoDshgoInspector.dshgo_inspector_id;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoDshgoInspector.inspector_id;
                con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = miDtoDshgoInspector.dshgo_participante_id;
                if (miDtoDshgoInspector.cve_ur != -1) con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoDshgoInspector.cve_ur;

                if (miDtoDshgoInspector.dinsp_fec_expedicion != String.Empty) con.ObjCommand.Parameters.Add("@dinsp_fec_expedicion", SqlDbType.DateTime).Value = miDtoDshgoInspector.dinsp_fec_expedicion;
                if (miDtoDshgoInspector.dinsp_fec_inicio != String.Empty) con.ObjCommand.Parameters.Add("@dinsp_fec_inicio", SqlDbType.DateTime).Value = miDtoDshgoInspector.dinsp_fec_inicio;
                if (miDtoDshgoInspector.dinsp_fec_termino != String.Empty) con.ObjCommand.Parameters.Add("@dinsp_fec_termino", SqlDbType.DateTime).Value = miDtoDshgoInspector.dinsp_fec_termino;

                if (miDtoDshgoInspector.dinsp_num_credencial != String.Empty) con.ObjCommand.Parameters.Add("@dinsp_num_credencial", SqlDbType.DateTime).Value = miDtoDshgoInspector.dinsp_num_credencial;
                if (miDtoDshgoInspector.dinsp_nombre_suscribe != String.Empty) con.ObjCommand.Parameters.Add("@dinsp_nombre_suscribe", SqlDbType.DateTime).Value = miDtoDshgoInspector.dinsp_nombre_suscribe;
                if (miDtoDshgoInspector.@dinsp_puesto_suscribe != String.Empty) con.ObjCommand.Parameters.Add("@dinsp_puesto_suscribe", SqlDbType.DateTime).Value = miDtoDshgoInspector.@dinsp_puesto_suscribe;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Dshgo_Experto_AgregarActualizar(DtoDshgoExperto miDtoDshgoExperto)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Experto_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoDshgoExperto.dshgo_experto_id != -1) con.ObjCommand.Parameters.Add("@dshgo_experto_id", SqlDbType.Int).Value = miDtoDshgoExperto.dshgo_experto_id;
                if (miDtoDshgoExperto.dshgo_participante_id != -1) con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = miDtoDshgoExperto.dshgo_participante_id;
                if (miDtoDshgoExperto.tipo_identificacion_id != -1) con.ObjCommand.Parameters.Add("@tipo_identificacion_id", SqlDbType.SmallInt).Value = miDtoDshgoExperto.tipo_identificacion_id;
                con.ObjCommand.Parameters.Add("@dexp_num_identificacion", SqlDbType.VarChar).Value = miDtoDshgoExperto.dexp_num_identificacion;
                if (miDtoDshgoExperto.inspec_experto_id != -1) con.ObjCommand.Parameters.Add("@inspec_experto_id", SqlDbType.Int).Value = miDtoDshgoExperto.inspec_experto_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Dshgo_RepTrab_AgregarActualizar(DtoDshgoRepTrabajadores miDtoDshgoRepTrab, string sentencia = "")
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_RepTrab_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.CommandTimeout = 3600;
                if (sentencia != "") con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                if (miDtoDshgoRepTrab.dshgo_rep_trabajadores_id != -1) con.ObjCommand.Parameters.Add("@dshgo_rep_trabajadores_id", SqlDbType.Int).Value = miDtoDshgoRepTrab.dshgo_rep_trabajadores_id;
                if (miDtoDshgoRepTrab.dshgo_participante_id != -1) con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = miDtoDshgoRepTrab.dshgo_participante_id;
                if (miDtoDshgoRepTrab.tipo_representante_id != -1) con.ObjCommand.Parameters.Add("@tipo_representante_id", SqlDbType.SmallInt).Value = miDtoDshgoRepTrab.tipo_representante_id;
                if (miDtoDshgoRepTrab.tipo_identificacion_id != -1) con.ObjCommand.Parameters.Add("@tipo_identificacion_id", SqlDbType.SmallInt).Value = miDtoDshgoRepTrab.tipo_identificacion_id;
                if (miDtoDshgoRepTrab.dshgo_sindicato_id != -1) con.ObjCommand.Parameters.Add("@dshgo_sindicato_id", SqlDbType.Int).Value = miDtoDshgoRepTrab.dshgo_sindicato_id;
                if (miDtoDshgoRepTrab.drtrab_tipo_acreditacion != "") con.ObjCommand.Parameters.Add("@drtrab_tipo_acreditacion", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_tipo_acreditacion;
                if (miDtoDshgoRepTrab.drtrab_se_acredita != -1) con.ObjCommand.Parameters.Add("@drtrab_se_acredita", SqlDbType.TinyInt).Value = miDtoDshgoRepTrab.drtrab_se_acredita;
                if (miDtoDshgoRepTrab.drtrab_se_identifica != -1) con.ObjCommand.Parameters.Add("@drtrab_se_identifica", SqlDbType.TinyInt).Value = miDtoDshgoRepTrab.drtrab_se_identifica;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_documento != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_documento", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_acreditacion_documento;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_num_escritura != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_num_escritura", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_acreditacion_num_escritura;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_fec_emision != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_fec_emision", SqlDbType.DateTime).Value = miDtoDshgoRepTrab.drtrab_acreditacion_fec_emision;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_notario != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_notario", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_acreditacion_notario;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_notario_numero != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_notario_numero", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_acreditacion_notario_numero;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_cve_edorep != -1) con.ObjCommand.Parameters.Add("@drtrab_acreditacion_cve_edorep", SqlDbType.SmallInt).Value = miDtoDshgoRepTrab.drtrab_acreditacion_cve_edorep;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_rfc != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_rfc", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_acreditacion_rfc;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_actividad != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_actividad", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_acreditacion_actividad;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_fec_inscripcion != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_fec_inscripcion", SqlDbType.DateTime).Value = miDtoDshgoRepTrab.drtrab_acreditacion_fec_inscripcion;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_fec_inicio != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_fec_inicio", SqlDbType.DateTime).Value = miDtoDshgoRepTrab.drtrab_acreditacion_fec_inicio;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_reg_patronal != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_reg_patronal", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_acreditacion_reg_patronal;
                if (miDtoDshgoRepTrab.drtrab_acreditacion_giro_economico != "") con.ObjCommand.Parameters.Add("@drtrab_acreditacion_giro_economico", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_acreditacion_giro_economico;
                if (miDtoDshgoRepTrab.drtrab_identificacion_numero != "") con.ObjCommand.Parameters.Add("@drtrab_identificacion_numero", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_identificacion_numero;
                if (miDtoDshgoRepTrab.drtrab_toma_nota_numero != "") con.ObjCommand.Parameters.Add("@drtrab_toma_nota_numero", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_toma_nota_numero;
                if (miDtoDshgoRepTrab.drtrab_toma_nota_expediente != "") con.ObjCommand.Parameters.Add("@drtrab_toma_nota_expediente", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_toma_nota_expediente;
                if (miDtoDshgoRepTrab.drtrab_toma_nota_fecha != "") con.ObjCommand.Parameters.Add("@drtrab_toma_nota_fecha", SqlDbType.DateTime).Value = miDtoDshgoRepTrab.drtrab_toma_nota_fecha;
                if (miDtoDshgoRepTrab.drtrab_motivo_ausencia != "") con.ObjCommand.Parameters.Add("@drtrab_motivo_ausencia", SqlDbType.VarChar).Value = miDtoDshgoRepTrab.drtrab_motivo_ausencia;
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DshgoCaptura_AgregarActualizar(DtoDshgoCaptura miDtoCap)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoCaptura_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = miDtoCap.desahogo_id;
                con.ObjCommand.Parameters.Add("@dshgo_seccion_id", SqlDbType.Int).Value = miDtoCap.dshgo_seccion_id;
                con.ObjCommand.Parameters.Add("@dcapt_info_capturada", SqlDbType.Int).Value = miDtoCap.dcapt_info_capturada;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoCap.sys_usr;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int DshgoParticipantes_AgregarActualizar(DtoDshgoParticipantes miDtoD)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoParticipante_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoD.dshgo_participante_id != -1) con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = miDtoD.dshgo_participante_id;
                if (miDtoD.desahogo_id != -1) con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = miDtoD.desahogo_id;
                if (miDtoD.motivo_no_firma_id != -1) con.ObjCommand.Parameters.Add("@motivo_no_firma_id", SqlDbType.SmallInt).Value = miDtoD.motivo_no_firma_id;
                if (miDtoD.dpart_tipo_participante != -1) con.ObjCommand.Parameters.Add("@dpart_tipo_participante", SqlDbType.TinyInt).Value = miDtoD.dpart_tipo_participante;
                if (miDtoD.dpart_firma != -1) con.ObjCommand.Parameters.Add("@dpart_firma", SqlDbType.TinyInt).Value = miDtoD.dpart_firma;
                if (miDtoD.dpart_manifestacion != -1) con.ObjCommand.Parameters.Add("@dpart_manifestacion", SqlDbType.TinyInt).Value = miDtoD.dpart_manifestacion;
                con.ObjCommand.Parameters.Add("@dpart_nombre", SqlDbType.VarChar).Value = miDtoD.dpart_nombre;
                con.ObjCommand.Parameters.Add("@dpart_puesto", SqlDbType.VarChar).Value = miDtoD.dpart_puesto;
                if (miDtoD.dpart_manifestacion_indicado != "") con.ObjCommand.Parameters.Add("@dpart_manifestacion_indicado", SqlDbType.VarChar).Value = miDtoD.dpart_manifestacion_indicado;
                if (miDtoD.dpart_otro_motivo_no_firma != "") con.ObjCommand.Parameters.Add("@dpart_otro_motivo_no_firma", SqlDbType.VarChar).Value = miDtoD.dpart_otro_motivo_no_firma;
                con.ObjCommand.Parameters.Add("@Usr", SqlDbType.VarChar).Value = miDtoD.Usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }

        }

        public void Dshgo_Comision_AgregarActualizar(int dshgo_participante_id, int tipo_identificacion_id, string dcom_num_identificacion, int dcom_parte_representa)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Comision_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dshgo_participante_id != -1) con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = dshgo_participante_id;
                if (tipo_identificacion_id != -1) con.ObjCommand.Parameters.Add("@tipo_identificacion_id", SqlDbType.SmallInt).Value = tipo_identificacion_id;
                if (dcom_num_identificacion != String.Empty) con.ObjCommand.Parameters.Add("@dcom_num_identificacion", SqlDbType.VarChar).Value = dcom_num_identificacion;
                if (dcom_parte_representa != -1) con.ObjCommand.Parameters.Add("@dcom_parte_representa", SqlDbType.TinyInt).Value = dcom_parte_representa;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }



        public int Dshgo_SupuestoDsgn_AgregarActualizar(Int16 supuesto_designacion_id, string supd_supuesto, Int16 supd_designacion_testigo_1, Int16 supd_designacion_testigo_2, Int16 supd_designado_por)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Supuesto_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (supuesto_designacion_id != -1) con.ObjCommand.Parameters.Add("@supuesto_designacion_id", SqlDbType.SmallInt).Value = supuesto_designacion_id;
                if (supd_supuesto != "") con.ObjCommand.Parameters.Add("@supd_supuesto", SqlDbType.VarChar).Value = supd_supuesto;
                if (supd_designacion_testigo_1 != -1) con.ObjCommand.Parameters.Add("@supd_designacion_testigo_1", SqlDbType.SmallInt).Value = supd_designacion_testigo_1;
                if (supd_designacion_testigo_2 != -1) con.ObjCommand.Parameters.Add("@supd_designacion_testigo_2", SqlDbType.SmallInt).Value = supd_designacion_testigo_2;
                if (supd_designado_por != -1) con.ObjCommand.Parameters.Add("@supd_designado_por", SqlDbType.SmallInt).Value = supd_designado_por;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }

        }


        public void DshgoTestigo_AgregarActualizar(DtoDshgoTestigo miDto)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Testigo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDto.dshgo_testigo_id != -1) con.ObjCommand.Parameters.Add("@dshgo_testigo_id", SqlDbType.Int).Value = miDto.dshgo_testigo_id;
                if (miDto.dshgo_participante_id != -1) con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = miDto.dshgo_participante_id;
                if (miDto.tipo_identificacion_id != -1) con.ObjCommand.Parameters.Add("@tipo_identificacion_id", SqlDbType.SmallInt).Value = miDto.tipo_identificacion_id;
                if (miDto.supuesto_designacion_id != -1) con.ObjCommand.Parameters.Add("@supuesto_designacion_id", SqlDbType.SmallInt).Value = miDto.supuesto_designacion_id;
                con.ObjCommand.Parameters.Add("@dtes_num_identificacion", SqlDbType.VarChar).Value = miDto.dtes_num_identificacion;
                if (miDto.dtes_num_testigo != -1) con.ObjCommand.Parameters.Add("@dtes_num_testigo", SqlDbType.TinyInt).Value = miDto.dtes_num_testigo;
                if (miDto.dtes_designado_por != -1) con.ObjCommand.Parameters.Add("@dtes_designado_por", SqlDbType.TinyInt).Value = miDto.dtes_designado_por;
                con.ObjCommand.Parameters.Add("@dtes_motivo_inspector", SqlDbType.VarChar).Value = miDto.dtes_motivo_inspector;
                if (miDto.dtes_es_mismo_domicilio != -1) con.ObjCommand.Parameters.Add("@dtes_es_mismo_domicilio", SqlDbType.TinyInt).Value = miDto.dtes_es_mismo_domicilio;
                con.ObjCommand.Parameters.Add("@dtes_domicilio_notificaciones", SqlDbType.VarChar).Value = miDto.dtes_domicilio_notificaciones;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        public void DshgoTrabajador_AgregarTablero(int desahogo_id, string sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Trabajador_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int DshgoTrabajador_AgregarActualizar(DtoDshgoTrabajador dtoTrabajador)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Trabajador_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_trabajador_id", SqlDbType.Int).Value = dtoTrabajador.dshgo_trabajador_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = dtoTrabajador.desahogo_id;
                con.ObjCommand.Parameters.Add("@dshgo_tipo_trabajador_id", SqlDbType.Int).Value = dtoTrabajador.dshgo_tipo_trabajador_id;

                con.ObjCommand.Parameters.Add("@dtrab_num_hombres", SqlDbType.Int).Value = dtoTrabajador.dtrab_num_hombres;
                con.ObjCommand.Parameters.Add("@dtrab_num_mujeres", SqlDbType.Int).Value = dtoTrabajador.dtrab_num_mujeres;
                con.ObjCommand.Parameters.Add("@dtrab_num_total", SqlDbType.Int).Value = dtoTrabajador.dtrab_num_total;

                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoTrabajador.sys_usr;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int DshgoTrabajadorDetalle_AgregarActualizar(DtoDshgoTrabajadorDetalle dtoDshgoTrabajadorDetalle)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Trabajador_Detalle_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_trabajador_det_id", SqlDbType.Int).Value = dtoDshgoTrabajadorDetalle.dshgo_trabajador_det_id;
                con.ObjCommand.Parameters.Add("@dshgo_trabajador_id", SqlDbType.Int).Value = dtoDshgoTrabajadorDetalle.dshgo_trabajador_id;

                con.ObjCommand.Parameters.Add("@dtrabd_actividad", SqlDbType.VarChar).Value = dtoDshgoTrabajadorDetalle.dtrabd_actividad;
                con.ObjCommand.Parameters.Add("@dtrabd_edad", SqlDbType.VarChar).Value = dtoDshgoTrabajadorDetalle.dtrabd_edad;
                con.ObjCommand.Parameters.Add("@dtrabd_nombre", SqlDbType.VarChar).Value = dtoDshgoTrabajadorDetalle.dtrabd_nombre;
                con.ObjCommand.Parameters.Add("@dtrabd_puesto", SqlDbType.VarChar).Value = dtoDshgoTrabajadorDetalle.dtrabd_puesto;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int DshgoInterrogado_AgregarActualizar(DtoDshgoInterrogado miDtoInt)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInterrogado_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoInt.dshgo_interrogado_id != -1) con.ObjCommand.Parameters.Add("@dshgo_interrogado_id", SqlDbType.Int).Value = miDtoInt.dshgo_interrogado_id;
                if (miDtoInt.dshgo_participante_id != -1) con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = miDtoInt.dshgo_participante_id;
                if (miDtoInt.tipo_identificacion_id != -1) con.ObjCommand.Parameters.Add("@tipo_identificacion_id", SqlDbType.Int).Value = miDtoInt.tipo_identificacion_id;
                if (miDtoInt.dint_num_identificacion != String.Empty) con.ObjCommand.Parameters.Add("@dint_num_identificacion", SqlDbType.VarChar).Value = miDtoInt.dint_num_identificacion;
                if (miDtoInt.dint_domicilio_notificaciones != String.Empty) con.ObjCommand.Parameters.Add("@dint_domicilio_notificaciones", SqlDbType.VarChar).Value = miDtoInt.dint_domicilio_notificaciones;
                if (miDtoInt.dint_mismo_domicilio != -1) con.ObjCommand.Parameters.Add("@dint_mismo_domicilio", SqlDbType.Int).Value = miDtoInt.dint_mismo_domicilio;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }


        public int DshgoListadoTrabajador_AgregarActualizar(DtoDshgoListadoPersonalActivo miDtoListado)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoListadoPActivo_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_listado_personal_id", SqlDbType.Int).Value = miDtoListado.dshgo_listado_personal_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = miDtoListado.desahogo_id;
                con.ObjCommand.Parameters.Add("@dshgo_listado_trab_nombre", SqlDbType.VarChar).Value = miDtoListado.dshgo_listado_trab_nombre;
                con.ObjCommand.Parameters.Add("@dshgo_listado_trab_puesto", SqlDbType.VarChar).Value = miDtoListado.dshgo_listado_trab_puesto;
                con.ObjCommand.Parameters.Add("@dshgo_listado_trab_actividad", SqlDbType.VarChar).Value = miDtoListado.dshgo_listado_trab_actividad;
                con.ObjCommand.Parameters.Add("@dshgo_listado_trab_patron", SqlDbType.VarChar).Value = miDtoListado.dshgo_listado_trab_patron;
                con.ObjCommand.Parameters.Add("@dshgo_listado_trab_ss", SqlDbType.VarChar).Value = miDtoListado.dshgo_listado_trab_ss;
                con.ObjCommand.Parameters.Add("@sys_usr_insert", SqlDbType.VarChar).Value = miDtoListado.sys_usr_insert;
                con.ObjCommand.Parameters.Add("@sys_usr_update", SqlDbType.VarChar).Value = miDtoListado.sys_usr_update;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        public int DshgoConsultaRestriccionAcceso_AgregarRespuesta(DtoDshgoMedidaPrecautoriaConsulta midtoConsulta)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_ConsultaRestriccionAcceso_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = midtoConsulta.desahogo_id;
                con.ObjCommand.Parameters.Add("@dshgo_doc_respuesta_url", SqlDbType.VarChar).Value = midtoConsulta.dshgo_doc_respuesta_url;
                con.ObjCommand.Parameters.Add("@dshgo_consulta_estatus", SqlDbType.VarChar).Value = midtoConsulta.dshgo_consulta_estatus;
                con.ObjCommand.Parameters.Add("@dshgo_consulta_fecha_respuesta", SqlDbType.DateTime).Value = midtoConsulta.dshgo_consulta_fecha_respuesta;
                con.ObjCommand.Parameters.Add("@sys_usr_update", SqlDbType.VarChar).Value = midtoConsulta.sys_usr_update;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        public int DshgoConsultaRestriccionAcceso_AgregarActualizar(DtoDshgoMedidaPrecautoriaConsulta midtoConsulta)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_ConsultaRestriccionAcceso_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = midtoConsulta.desahogo_id;
                con.ObjCommand.Parameters.Add("@dshgo_doc_respuesta_url", SqlDbType.VarChar).Value = midtoConsulta.dshgo_doc_respuesta_url;
                con.ObjCommand.Parameters.Add("@dshgo_consulta_fecha_emision", SqlDbType.DateTime).Value = midtoConsulta.dshgo_consulta_fecha_emision;
                con.ObjCommand.Parameters.Add("@sys_usr_inserte", SqlDbType.VarChar).Value = midtoConsulta.sys_usr_inserte;
                con.ObjCommand.Parameters.Add("@sys_usr_update", SqlDbType.VarChar).Value = midtoConsulta.sys_usr_update;
                con.ObjCommand.Parameters.Add("@dshgo_consulta_estatus", SqlDbType.VarChar).Value = midtoConsulta.dshgo_consulta_estatus;
                con.ObjCommand.Parameters.Add("@dshgo_medida_precautoria_consulta_id", SqlDbType.VarChar).Value = midtoConsulta.dshgo_medida_precautoria_consulta_id;



                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        public int DesahogoInstalacion_AgregarActualizar(int dshgo_instalacion_id, int desahogo_id, int tipo_instalacion_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DesahogoInstalacion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dshgo_instalacion_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_instalacion_id", SqlDbType.Int).Value = dshgo_instalacion_id;
                if (desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                if (tipo_instalacion_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_instalacion_id", SqlDbType.Int).Value = tipo_instalacion_id;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DshgoInterrogatorioAbierta_AgregarActualizar(DtoDshgoInterrogatorioAbierta miDtoIA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInterrogatorioAbierta_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoIA.dshgo_interrogatorio_abierta_id != -1) con.ObjCommand.Parameters.Add("@dshgo_interrogatorio_abierta_id", SqlDbType.Int).Value = miDtoIA.dshgo_interrogatorio_abierta_id;
                if (miDtoIA.dshgo_interrogado_id != -1) con.ObjCommand.Parameters.Add("@dshgo_interrogado_id", SqlDbType.Int).Value = miDtoIA.dshgo_interrogado_id;
                if (miDtoIA.diabie_pregunta != "") con.ObjCommand.Parameters.Add("@diabie_pregunta", SqlDbType.VarChar).Value = miDtoIA.diabie_pregunta;
                if (miDtoIA.diabie_respuesta != "") con.ObjCommand.Parameters.Add("@diabie_respuesta", SqlDbType.VarChar).Value = miDtoIA.diabie_respuesta;
                if (miDtoIA.sys_usr != "") con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoIA.sys_usr;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int DshgoCentroCamara_AgregarActualizar(DtoDshgoCentroCamara dshgocamara)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoCentroCamara_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dshgocamara.dshgo_centro_camara_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_centro_camara_id", SqlDbType.Int).Value = dshgocamara.dshgo_centro_camara_id;
                if (dshgocamara.dshgo_centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = dshgocamara.dshgo_centro_trabajo_id;
                if (dshgocamara.dcc_dne_camara_id != -1)
                    con.ObjCommand.Parameters.Add("@dcc_dne_camara_id", SqlDbType.Int).Value = dshgocamara.dcc_dne_camara_id;
                if (!String.IsNullOrEmpty(dshgocamara.dcc_camara))
                    con.ObjCommand.Parameters.Add("@dcc_camara", SqlDbType.VarChar).Value = dshgocamara.dcc_camara;
                if (dshgocamara.dcc_orden != -1)
                    con.ObjCommand.Parameters.Add("@dcc_orden", SqlDbType.SmallInt).Value = dshgocamara.dcc_orden;
                if (dshgocamara.dcc_no_incluida != -1)
                    con.ObjCommand.Parameters.Add("@dcc_no_incluida", SqlDbType.Int).Value = dshgocamara.dcc_no_incluida;
                if (!String.IsNullOrEmpty(dshgocamara.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dshgocamara.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DshgoSolidaria_AgregarDNE(int dshgo_centro_trabajo_id, int centro_trabajo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Solidaria_AgregarDNE", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = dshgo_centro_trabajo_id;
                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int DshgoSolidaria_AgregarActualizar(DtoDshgoSolidaria dtoSolidaria)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Solidaria_Agregar_Actualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_solidaria_dne_id", SqlDbType.Int).Value = dtoSolidaria.dshgo_solidaria_dne_id;
                con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = dtoSolidaria.dshgo_centro_trabajo_id;
                con.ObjCommand.Parameters.Add("@dsol_dne_centro_trabajo_id", SqlDbType.Int).Value = dtoSolidaria.dsol_dne_centro_trabajo_id;
                con.ObjCommand.Parameters.Add("@dsol_dne_seguridad_social_id", SqlDbType.Int).Value = dtoSolidaria.dsol_dne_seguridad_social_id;
                con.ObjCommand.Parameters.Add("@dsol_mismo_domicilio", SqlDbType.Int).Value = dtoSolidaria.dsol_mismo_domicilio;
                con.ObjCommand.Parameters.Add("@dsol_no_conoce_domicilio", SqlDbType.Int).Value = dtoSolidaria.dsol_no_conoce_domicilio;
                con.ObjCommand.Parameters.Add("@dsol_cae_id", SqlDbType.Int).Value = dtoSolidaria.dsol_cae_id;
                con.ObjCommand.Parameters.Add("@dsol_num_hombres", SqlDbType.Int).Value = dtoSolidaria.dsol_num_hombres;
                con.ObjCommand.Parameters.Add("@dsol_num_mujeres", SqlDbType.Int).Value = dtoSolidaria.dsol_num_mujeres;
                con.ObjCommand.Parameters.Add("@dsol_num_total", SqlDbType.Int).Value = dtoSolidaria.dsol_num_total;

                con.ObjCommand.Parameters.Add("@dsol_razon_social", SqlDbType.VarChar).Value = dtoSolidaria.dsol_razon_social;
                con.ObjCommand.Parameters.Add("@dsol_rfc", SqlDbType.VarChar).Value = dtoSolidaria.dsol_rfc;
                con.ObjCommand.Parameters.Add("@dsol_calle", SqlDbType.VarChar).Value = dtoSolidaria.dsol_calle;
                con.ObjCommand.Parameters.Add("@dsol_num_exterior", SqlDbType.VarChar).Value = dtoSolidaria.dsol_num_exterior;
                con.ObjCommand.Parameters.Add("@dsol_num_interior", SqlDbType.VarChar).Value = dtoSolidaria.dsol_num_interior;
                con.ObjCommand.Parameters.Add("@dsol_colonia", SqlDbType.VarChar).Value = dtoSolidaria.dsol_colonia;
                con.ObjCommand.Parameters.Add("@dsol_poblacion", SqlDbType.VarChar).Value = dtoSolidaria.dsol_poblacion;
                con.ObjCommand.Parameters.Add("@dsol_cp", SqlDbType.VarChar).Value = dtoSolidaria.dsol_cp;
                con.ObjCommand.Parameters.Add("@dsol_ref_ubicacion", SqlDbType.VarChar).Value = dtoSolidaria.dsol_ref_ubicacion;
                con.ObjCommand.Parameters.Add("@dsol_longitud", SqlDbType.VarChar).Value = dtoSolidaria.dsol_longitud;
                con.ObjCommand.Parameters.Add("@dsol_latitud", SqlDbType.VarChar).Value = dtoSolidaria.dsol_latitud;
                con.ObjCommand.Parameters.Add("@dsol_telefono", SqlDbType.VarChar).Value = dtoSolidaria.dsol_telefono;
                con.ObjCommand.Parameters.Add("@dsol_fax", SqlDbType.VarChar).Value = dtoSolidaria.dsol_fax;
                con.ObjCommand.Parameters.Add("@dsol_email", SqlDbType.VarChar).Value = dtoSolidaria.dsol_email;
                con.ObjCommand.Parameters.Add("@dsol_imss_registro", SqlDbType.VarChar).Value = dtoSolidaria.dsol_imss_registro;
                con.ObjCommand.Parameters.Add("@dsol_cve_edorep", SqlDbType.VarChar).Value = dtoSolidaria.dsol_cve_edorep;
                con.ObjCommand.Parameters.Add("@dsol_cve_municipio", SqlDbType.VarChar).Value = dtoSolidaria.dsol_cve_municipio;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        //******agregar los DshgoDocumentos
        public void DshgoDocumentoAgregarActualizar(DtoDshgoDocumento dtoDocto)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDocumento_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dtoDocto.dshgo_documento_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = dtoDocto.desahogo_id;
                if (dtoDocto.tipo_documento_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.tipo_documento_id;
                if(dtoDocto.ddoc_nombre_documento != "")
                    con.ObjCommand.Parameters.Add("@ddoc_nombre_documento", SqlDbType.VarChar).Value = dtoDocto.ddoc_nombre_documento;
                if (dtoDocto.ddoc_url_documento != "")
                    con.ObjCommand.Parameters.Add("@ddoc_url_documento", SqlDbType.VarChar).Value = dtoDocto.ddoc_url_documento;
                if (dtoDocto.doc_url_archivo_sin_firmas != "")
                    con.ObjCommand.Parameters.Add("@doc_url_archivo_sin_firmas", SqlDbType.VarChar).Value = dtoDocto.doc_url_archivo_sin_firmas;
                con.ObjCommand.Parameters.Add("@ddoc_hash", SqlDbType.VarChar).Value = dtoDocto.ddoc_hash;
                con.ObjCommand.Parameters.Add("@sys_usr ", SqlDbType.VarChar).Value = dtoDocto.sys_usr;
                if (dtoDocto.documento_firmado != -1)
                    con.ObjCommand.Parameters.Add("@documento_firmado", SqlDbType.VarChar).Value = dtoDocto.documento_firmado;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int DshgoDocumentoAgregarActualizar2(DtoDshgoDocumento dtoDocto)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDocumento_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                //con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dtoDocto.dshgo_documento_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = dtoDocto.desahogo_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.tipo_documento_id;
                con.ObjCommand.Parameters.Add("@ddoc_nombre_documento", SqlDbType.VarChar).Value = dtoDocto.ddoc_nombre_documento;
                con.ObjCommand.Parameters.Add("@ddoc_url_documento", SqlDbType.VarChar).Value = dtoDocto.ddoc_url_documento;
                con.ObjCommand.Parameters.Add("@ddoc_hash", SqlDbType.VarChar).Value = dtoDocto.ddoc_hash;
                con.ObjCommand.Parameters.Add("@sys_usr ", SqlDbType.VarChar).Value = dtoDocto.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DoctoDshgoVariables_Agregar(DtoDshgoDoctoVariables miDshgoVariable)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDoctoVariables_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@DshgoDocumentoID", SqlDbType.Int).Value = miDshgoVariable.DshgoDocumentoID;

                if (miDshgoVariable.Ur != "") con.ObjCommand.Parameters.Add("@Ur", SqlDbType.VarChar).Value = miDshgoVariable.Ur;
                if (miDshgoVariable.No_Expediente != "") con.ObjCommand.Parameters.Add("@No_Expediente", SqlDbType.VarChar).Value = miDshgoVariable.No_Expediente;
                if (miDshgoVariable.Subtipo_Actuacion != "") con.ObjCommand.Parameters.Add("@Subtipo_Actuacion", SqlDbType.VarChar).Value = miDshgoVariable.Subtipo_Actuacion;
                if (miDshgoVariable.Materia != "") con.ObjCommand.Parameters.Add("@Materia", SqlDbType.VarChar).Value = miDshgoVariable.Materia;
                if (miDshgoVariable.Cargo != "") con.ObjCommand.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = miDshgoVariable.Cargo;
                if (miDshgoVariable.Domicilio_Ur != "") con.ObjCommand.Parameters.Add("@DOMICILIO_UR", SqlDbType.VarChar).Value = miDshgoVariable.Domicilio_Ur;
                if (miDshgoVariable.Firmante != "") con.ObjCommand.Parameters.Add("@Firmante", SqlDbType.VarChar).Value = miDshgoVariable.Firmante;
                if (miDshgoVariable.Fecha_Documento != "") con.ObjCommand.Parameters.Add("@Fecha_Documento", SqlDbType.VarChar).Value = miDshgoVariable.Fecha_Documento;
                if (miDshgoVariable.Telefonos != "") con.ObjCommand.Parameters.Add("@Telefonos", SqlDbType.VarChar).Value = miDshgoVariable.Telefonos;
                if (miDshgoVariable.Domicilio != "") con.ObjCommand.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = miDshgoVariable.Domicilio;
                if (miDshgoVariable.Empresa != "") con.ObjCommand.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = miDshgoVariable.Empresa;
                if (miDshgoVariable.Ncur != "") con.ObjCommand.Parameters.Add("@Ncur", SqlDbType.VarChar).Value = miDshgoVariable.Ncur;
                if (miDshgoVariable.Ubicacion_Ur != "") con.ObjCommand.Parameters.Add("@Ubicacion_Ur", SqlDbType.VarChar).Value = miDshgoVariable.Ubicacion_Ur;
                if (miDshgoVariable.Fecha_Inspeccion != "") con.ObjCommand.Parameters.Add("@Fecha_Inspeccion", SqlDbType.VarChar).Value = miDshgoVariable.Fecha_Inspeccion;
                if (miDshgoVariable.Hora_inspeccion != "") con.ObjCommand.Parameters.Add("@Hora_inspeccion", SqlDbType.VarChar).Value = miDshgoVariable.Hora_inspeccion;
                if (miDshgoVariable.Año != "") con.ObjCommand.Parameters.Add("@Año", SqlDbType.VarChar).Value = miDshgoVariable.Año;
                if (miDshgoVariable.Credencial != "") con.ObjCommand.Parameters.Add("@Credencial", SqlDbType.VarChar).Value = miDshgoVariable.Credencial;
                if (miDshgoVariable.Notificador != "") con.ObjCommand.Parameters.Add("@Notificador", SqlDbType.VarChar).Value = miDshgoVariable.Notificador;
                //mas variables
                if (miDshgoVariable.LUGAR_INSPECCION != "") con.ObjCommand.Parameters.Add("@lugar_inspeccion", SqlDbType.VarChar).Value = miDshgoVariable.LUGAR_INSPECCION;
                if (miDshgoVariable.ENTIDAD_INSPECCION != "") con.ObjCommand.Parameters.Add("@entidad_inspeccion", SqlDbType.VarChar).Value = miDshgoVariable.ENTIDAD_INSPECCION;
                if (miDshgoVariable.UR_FIRMANTE != "") con.ObjCommand.Parameters.Add("@ur_firmante", SqlDbType.VarChar).Value = miDshgoVariable.UR_FIRMANTE;
                if (miDshgoVariable.MOTIVO_INFORME != "") con.ObjCommand.Parameters.Add("@motivo_informe", SqlDbType.VarChar).Value = miDshgoVariable.MOTIVO_INFORME;
                if (miDshgoVariable.NOMBRE_REPRESENTANTE_EMPRESA != "") con.ObjCommand.Parameters.Add("@representante_nombre", SqlDbType.VarChar).Value = miDshgoVariable.NOMBRE_REPRESENTANTE_EMPRESA;
                if (miDshgoVariable.TIPO_REPRESENTANTE_EMPRESA != "") con.ObjCommand.Parameters.Add("@tipo_representante", SqlDbType.VarChar).Value = miDshgoVariable.TIPO_REPRESENTANTE_EMPRESA;
                if (miDshgoVariable.caracteres_autenticidad != "") con.ObjCommand.Parameters.Add("@caracteres_autenticidad", SqlDbType.VarChar).Value = miDshgoVariable.caracteres_autenticidad;
                if (miDshgoVariable.FECHA_CIERRE != "") con.ObjCommand.Parameters.Add("@FECHA_CIERRE", SqlDbType.VarChar).Value = miDshgoVariable.FECHA_CIERRE;
                if (miDshgoVariable.HORA_CIERRE != "") con.ObjCommand.Parameters.Add("@HORA_CIERRE", SqlDbType.VarChar).Value = miDshgoVariable.HORA_CIERRE;
                //lo de los párrafos
                if (miDshgoVariable.rama_constitucion != "") con.ObjCommand.Parameters.Add("@rama_constitucion", SqlDbType.VarChar).Value = miDshgoVariable.rama_constitucion;
                if (miDshgoVariable.rama_lft != "") con.ObjCommand.Parameters.Add("@rama_lft", SqlDbType.VarChar).Value = miDshgoVariable.rama_lft;
                if (miDshgoVariable.tins_tipo_542_lft != "") con.ObjCommand.Parameters.Add("@tins_tipo_542_lft", SqlDbType.VarChar).Value = miDshgoVariable.tins_tipo_542_lft;
                if (miDshgoVariable.motivo_rgiasvll != "") con.ObjCommand.Parameters.Add("@motivo_rgiasvll", SqlDbType.VarChar).Value = miDshgoVariable.motivo_rgiasvll;
                if (miDshgoVariable.fd_designacion_rgiasvll != "") con.ObjCommand.Parameters.Add("@fd_designacion_rgiasvll", SqlDbType.VarChar).Value = miDshgoVariable.fd_designacion_rgiasvll;
                if (miDshgoVariable.circu_reglamento != "") con.ObjCommand.Parameters.Add("@circu_reglamento", SqlDbType.VarChar).Value = miDshgoVariable.circu_reglamento;
                if (miDshgoVariable.circu_acuerdo != "") con.ObjCommand.Parameters.Add("@circu_acuerdo", SqlDbType.VarChar).Value = miDshgoVariable.circu_acuerdo;
                if (miDshgoVariable.equipo != "") con.ObjCommand.Parameters.Add("@equipo", SqlDbType.VarChar).Value = miDshgoVariable.equipo;
                if (miDshgoVariable.num_control != "") con.ObjCommand.Parameters.Add("@num_control", SqlDbType.VarChar).Value = miDshgoVariable.num_control;
                if (miDshgoVariable.tipo_aviso != "") con.ObjCommand.Parameters.Add("@tipo_aviso", SqlDbType.VarChar).Value = miDshgoVariable.tipo_aviso;
                if (miDshgoVariable.folio != "") con.ObjCommand.Parameters.Add("@folio", SqlDbType.VarChar).Value = miDshgoVariable.folio;
                if (miDshgoVariable.medio_informacion != "") con.ObjCommand.Parameters.Add("@medio_informacion", SqlDbType.VarChar).Value = miDshgoVariable.medio_informacion;
                if (miDshgoVariable.fec_autorizacion_provisional != "") con.ObjCommand.Parameters.Add("@fec_autorizacion_provisional", SqlDbType.VarChar).Value = miDshgoVariable.fec_autorizacion_provisional;
                if (miDshgoVariable.pruebas != "") con.ObjCommand.Parameters.Add("@pruebas", SqlDbType.VarChar).Value = miDshgoVariable.pruebas;
                if (miDshgoVariable.atribuciones_541_lft != "") con.ObjCommand.Parameters.Add("@atribuciones_541_lft", SqlDbType.VarChar).Value = miDshgoVariable.atribuciones_541_lft;
                if (miDshgoVariable.atribuciones_art9_rgiasvll != "") con.ObjCommand.Parameters.Add("@atribuciones_art9_rgiasvll", SqlDbType.VarChar).Value = miDshgoVariable.atribuciones_art9_rgiasvll;
                if (miDshgoVariable.asesoria_art10_rgiasvll != "") con.ObjCommand.Parameters.Add("@asesoria_art10_rgiasvll", SqlDbType.VarChar).Value = miDshgoVariable.asesoria_art10_rgiasvll;
                if (miDshgoVariable.requisitos_rgiasvll != "") con.ObjCommand.Parameters.Add("@requisitos_rgiasvll", SqlDbType.VarChar).Value = miDshgoVariable.requisitos_rgiasvll;
                if (miDshgoVariable.no_emplazamiento != "") con.ObjCommand.Parameters.Add("@no_emplazamiento", SqlDbType.VarChar).Value = miDshgoVariable.no_emplazamiento;
                if (miDshgoVariable.fecha_emplazamiento != "") con.ObjCommand.Parameters.Add("@fecha_emplazamiento", SqlDbType.VarChar).Value = miDshgoVariable.fecha_emplazamiento;
                if (miDshgoVariable.fec_notif_emplazamiento != "") con.ObjCommand.Parameters.Add("@fec_notif_emplazamiento", SqlDbType.VarChar).Value = miDshgoVariable.fec_notif_emplazamiento;
                if (miDshgoVariable.acci_medio_informacion != "") con.ObjCommand.Parameters.Add("@acci_medio_informacion", SqlDbType.VarChar).Value = miDshgoVariable.acci_medio_informacion;
                if (miDshgoVariable.inminente_peligro_medio_info != "") con.ObjCommand.Parameters.Add("@inminente_peligro_medio_info", SqlDbType.VarChar).Value = miDshgoVariable.inminente_peligro_medio_info;
                if (miDshgoVariable.tipo_autorizacion != "") con.ObjCommand.Parameters.Add("@tipo_autorizacion", SqlDbType.VarChar).Value = miDshgoVariable.tipo_autorizacion;
                if (miDshgoVariable.periodo_inicio != "") con.ObjCommand.Parameters.Add("@periodo_inicio", SqlDbType.VarChar).Value = miDshgoVariable.periodo_inicio;
                if (miDshgoVariable.periodo_termino != "") con.ObjCommand.Parameters.Add("@periodo_termino", SqlDbType.VarChar).Value = miDshgoVariable.periodo_termino;
                if (miDshgoVariable.empresa_que_se_visita != "") con.ObjCommand.Parameters.Add("@empresa_que_se_visita", SqlDbType.VarChar).Value = miDshgoVariable.empresa_que_se_visita;
                if (miDshgoVariable.motivo_actuacion != "") con.ObjCommand.Parameters.Add("@motivo_actuacion", SqlDbType.VarChar).Value = miDshgoVariable.motivo_actuacion;
                if (miDshgoVariable.dato_adicional_motivo != "") con.ObjCommand.Parameters.Add("@dato_adicional_motivo", SqlDbType.VarChar).Value = miDshgoVariable.dato_adicional_motivo;
                //variables de los parrafos nuevos
                if (miDshgoVariable.fecha_notificacion != "") con.ObjCommand.Parameters.Add("@fecha_notificacion", SqlDbType.VarChar).Value = miDshgoVariable.fecha_notificacion;
                if (miDshgoVariable.nombre_persona_notificada != "") con.ObjCommand.Parameters.Add("@nombre_persona_notificada", SqlDbType.VarChar).Value = miDshgoVariable.nombre_persona_notificada;
                if (miDshgoVariable.calidad_persona_notificada != "") con.ObjCommand.Parameters.Add("@calidad_persona_notificada", SqlDbType.VarChar).Value = miDshgoVariable.calidad_persona_notificada;
                if (miDshgoVariable.motivo_no_entregada != "") con.ObjCommand.Parameters.Add("@motivo_no_entregada", SqlDbType.VarChar).Value = miDshgoVariable.motivo_no_entregada;
                if (miDshgoVariable.puesto_representante_empresa != "") con.ObjCommand.Parameters.Add("@puesto_representante_empresa", SqlDbType.VarChar).Value = miDshgoVariable.puesto_representante_empresa;
                if (miDshgoVariable.empresa_contratista != "") con.ObjCommand.Parameters.Add("@empresa_contratista", SqlDbType.VarChar).Value = miDshgoVariable.empresa_contratista;
                if (miDshgoVariable.contrato_prestacion_servicios != "") con.ObjCommand.Parameters.Add("@contrato_prestacion_servicios", SqlDbType.VarChar).Value = miDshgoVariable.contrato_prestacion_servicios;
                if (miDshgoVariable.media_filiacion != "") con.ObjCommand.Parameters.Add("@media_filiacion", SqlDbType.VarChar).Value = miDshgoVariable.media_filiacion;
                if (miDshgoVariable.nombres_inspectores != "") con.ObjCommand.Parameters.Add("@nombres_inspectores", SqlDbType.VarChar).Value = miDshgoVariable.nombres_inspectores;
                if (miDshgoVariable.NOMBRE_REPRESENTANTE_TRABAJADORES != "") con.ObjCommand.Parameters.Add("@NOMBRE_REPRESENTANTE_TRABAJADORES", SqlDbType.VarChar).Value = miDshgoVariable.NOMBRE_REPRESENTANTE_TRABAJADORES;
                if (miDshgoVariable.PUESTO_REPRESENTANTE_TRABAJADORES != "") con.ObjCommand.Parameters.Add("@PUESTO_REPRESENTANTE_TRABAJADORES", SqlDbType.VarChar).Value = miDshgoVariable.PUESTO_REPRESENTANTE_TRABAJADORES;

                if (miDshgoVariable.TIPO_REPRESENTANTE_TRABAJADORES != "") con.ObjCommand.Parameters.Add("@TIPO_REPRESENTANTE_TRABAJADORES", SqlDbType.VarChar).Value = miDshgoVariable.TIPO_REPRESENTANTE_TRABAJADORES;
                if (miDshgoVariable.contrasena != "") con.ObjCommand.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = miDshgoVariable.contrasena;
                //Variables dshgo ACTA
                if (miDshgoVariable.RFC != "") con.ObjCommand.Parameters.Add("@RFC", SqlDbType.VarChar).Value = miDshgoVariable.RFC;
                if (miDshgoVariable.NOMBRE_COMERCIAL != "") con.ObjCommand.Parameters.Add("@NOMBRE_COMERCIAL", SqlDbType.VarChar).Value = miDshgoVariable.NOMBRE_COMERCIAL;
                if (miDshgoVariable.DOMICILIO2 != "") con.ObjCommand.Parameters.Add("@DOMICILIO2", SqlDbType.VarChar).Value = miDshgoVariable.DOMICILIO2;
                if (miDshgoVariable.LATITUD != "") con.ObjCommand.Parameters.Add("@LATITUD", SqlDbType.VarChar).Value = miDshgoVariable.LATITUD;
                if (miDshgoVariable.LONGITUD != "") con.ObjCommand.Parameters.Add("@LONGITUD", SqlDbType.VarChar).Value = miDshgoVariable.LONGITUD;
                if (miDshgoVariable.TELEFONOS2 != "") con.ObjCommand.Parameters.Add("@TELEFONOS2", SqlDbType.VarChar).Value = miDshgoVariable.TELEFONOS2;
                if (miDshgoVariable.FAX != "") con.ObjCommand.Parameters.Add("@FAX", SqlDbType.VarChar).Value = miDshgoVariable.FAX;
                if (miDshgoVariable.CORREO_ELECTRONICO != "") con.ObjCommand.Parameters.Add("@CORREO_ELECTRONICO", SqlDbType.VarChar).Value = miDshgoVariable.CORREO_ELECTRONICO;
                if (miDshgoVariable.DOMICILIO_FISCAL != "") con.ObjCommand.Parameters.Add("@DOMICILIO_FISCAL", SqlDbType.VarChar).Value = miDshgoVariable.DOMICILIO_FISCAL;
                if (miDshgoVariable.ESQUEMA != "") con.ObjCommand.Parameters.Add("@ESQUEMA", SqlDbType.VarChar).Value = miDshgoVariable.ESQUEMA;
                if (miDshgoVariable.REGISTRO_PATRONAL != "") con.ObjCommand.Parameters.Add("@REGISTRO_PATRONAL", SqlDbType.VarChar).Value = miDshgoVariable.REGISTRO_PATRONAL;
                if (miDshgoVariable.CLASE_RIESGO != "") con.ObjCommand.Parameters.Add("@CLASE_RIESGO", SqlDbType.VarChar).Value = miDshgoVariable.CLASE_RIESGO;
                if (miDshgoVariable.PRIMA_RIESGO != "") con.ObjCommand.Parameters.Add("@PRIMA_RIESGO", SqlDbType.VarChar).Value = miDshgoVariable.PRIMA_RIESGO;
                if (miDshgoVariable.ACTA_NO_ESCRITURA_PUBLICA != "") con.ObjCommand.Parameters.Add("@ACTA_NO_ESCRITURA_PUBLICA", SqlDbType.VarChar).Value = miDshgoVariable.ACTA_NO_ESCRITURA_PUBLICA;
                if (miDshgoVariable.ACTA_FECHA_EMISION != "") con.ObjCommand.Parameters.Add("@ACTA_FECHA_EMISION", SqlDbType.VarChar).Value = miDshgoVariable.ACTA_FECHA_EMISION;
                if (miDshgoVariable.ACTA_NOMBRE_NOTARIO != "") con.ObjCommand.Parameters.Add("@ACTA_NOMBRE_NOTARIO", SqlDbType.VarChar).Value = miDshgoVariable.ACTA_NOMBRE_NOTARIO;
                if (miDshgoVariable.ACTA_NO_NOTARIO != "") con.ObjCommand.Parameters.Add("@ACTA_NO_NOTARIO", SqlDbType.VarChar).Value = miDshgoVariable.ACTA_NO_NOTARIO;
                if (miDshgoVariable.ACTA_ENTIDAD_FEDERATIVA_NOTARIO != "") con.ObjCommand.Parameters.Add("@ACTA_ENTIDAD_FEDERATIVA_NOTARIO", SqlDbType.VarChar).Value = miDshgoVariable.ACTA_ENTIDAD_FEDERATIVA_NOTARIO;
                if (miDshgoVariable.ACTIVIDAD_CENTRO_DE_TRABAJO != "") con.ObjCommand.Parameters.Add("@ACTIVIDAD_CENTRO_DE_TRABAJO", SqlDbType.VarChar).Value = miDshgoVariable.ACTIVIDAD_CENTRO_DE_TRABAJO;
                if (miDshgoVariable.ACTIVIDAD_SCIAN != "") con.ObjCommand.Parameters.Add("@ACTIVIDAD_SCIAN", SqlDbType.VarChar).Value = miDshgoVariable.ACTIVIDAD_SCIAN;
                if (miDshgoVariable.TIPO_ESTABLECIMIENTO != "") con.ObjCommand.Parameters.Add("@TIPO_ESTABLECIMIENTO", SqlDbType.VarChar).Value = miDshgoVariable.TIPO_ESTABLECIMIENTO;
                if (miDshgoVariable.M2_CONSTRUCCION != "") con.ObjCommand.Parameters.Add("@M2_CONSTRUCCION", SqlDbType.VarChar).Value = miDshgoVariable.M2_CONSTRUCCION;
                if (miDshgoVariable.M2_SUPERFICIE != "") con.ObjCommand.Parameters.Add("@M2_SUPERFICIE", SqlDbType.VarChar).Value = miDshgoVariable.M2_SUPERFICIE;
                if (miDshgoVariable.TIPO_CONTRATACION != "") con.ObjCommand.Parameters.Add("@TIPO_CONTRATACION", SqlDbType.VarChar).Value = miDshgoVariable.TIPO_CONTRATACION;
                if (miDshgoVariable.FECHA_DE_CELEBRACION_COLECTIVO != "") con.ObjCommand.Parameters.Add("@FECHA_DE_CELEBRACION_COLECTIVO", SqlDbType.VarChar).Value = miDshgoVariable.FECHA_DE_CELEBRACION_COLECTIVO;
                if (miDshgoVariable.FECHA_DE_CELEBRACION_LEY != "") con.ObjCommand.Parameters.Add("@FECHA_DE_CELEBRACION_LEY", SqlDbType.VarChar).Value = miDshgoVariable.FECHA_DE_CELEBRACION_LEY;
                if (miDshgoVariable.CAPITAL_CONTABLE != "") con.ObjCommand.Parameters.Add("@CAPITAL_CONTABLE", SqlDbType.VarChar).Value = miDshgoVariable.CAPITAL_CONTABLE;
                if (miDshgoVariable.SIND != "") con.ObjCommand.Parameters.Add("@SIND", SqlDbType.VarChar).Value = miDshgoVariable.SIND;
                if (miDshgoVariable.SIND_H != "") con.ObjCommand.Parameters.Add("@SIND_H", SqlDbType.VarChar).Value = miDshgoVariable.SIND_H;
                if (miDshgoVariable.SIND_M != "") con.ObjCommand.Parameters.Add("@SIND_M", SqlDbType.VarChar).Value = miDshgoVariable.SIND_M;
                if (miDshgoVariable.PLANTA != "") con.ObjCommand.Parameters.Add("@PLANTA", SqlDbType.VarChar).Value = miDshgoVariable.PLANTA;
                if (miDshgoVariable.PLANTA_H != "") con.ObjCommand.Parameters.Add("@PLANTA_H", SqlDbType.VarChar).Value = miDshgoVariable.PLANTA_H;
                if (miDshgoVariable.PLANTA_M != "") con.ObjCommand.Parameters.Add("@PLANTA_M", SqlDbType.VarChar).Value = miDshgoVariable.PLANTA_M;
                if (miDshgoVariable.EVENT != "") con.ObjCommand.Parameters.Add("@EVENT", SqlDbType.VarChar).Value = miDshgoVariable.EVENT;
                if (miDshgoVariable.EVENT_H != "") con.ObjCommand.Parameters.Add("@EVENT_H", SqlDbType.VarChar).Value = miDshgoVariable.EVENT_H;
                if (miDshgoVariable.EVENT_M != "") con.ObjCommand.Parameters.Add("@EVENT_M", SqlDbType.VarChar).Value = miDshgoVariable.EVENT_M;
                if (miDshgoVariable.NO_SIND != "") con.ObjCommand.Parameters.Add("@NO_SIND", SqlDbType.VarChar).Value = miDshgoVariable.NO_SIND;
                if (miDshgoVariable.NO_SIND_H != "") con.ObjCommand.Parameters.Add("@NO_SIND_H", SqlDbType.VarChar).Value = miDshgoVariable.NO_SIND_H;
                if (miDshgoVariable.NO_SIND_M != "") con.ObjCommand.Parameters.Add("@NO_SIND_M", SqlDbType.VarChar).Value = miDshgoVariable.NO_SIND_M;
                if (miDshgoVariable.OBRA != "") con.ObjCommand.Parameters.Add("@OBRA", SqlDbType.VarChar).Value = miDshgoVariable.OBRA;
                if (miDshgoVariable.OBRA_H != "") con.ObjCommand.Parameters.Add("@OBRA_H", SqlDbType.VarChar).Value = miDshgoVariable.OBRA_H;
                if (miDshgoVariable.OBRA_M != "") con.ObjCommand.Parameters.Add("@OBRA_M", SqlDbType.VarChar).Value = miDshgoVariable.OBRA_M;
                if (miDshgoVariable.TIEMPO_D != "") con.ObjCommand.Parameters.Add("@TIEMPO_D", SqlDbType.VarChar).Value = miDshgoVariable.TIEMPO_D;
                if (miDshgoVariable.TIEMPO_D_H != "") con.ObjCommand.Parameters.Add("@TIEMPO_D_H", SqlDbType.VarChar).Value = miDshgoVariable.TIEMPO_D_H;
                if (miDshgoVariable.TIEMPO_D_M != "") con.ObjCommand.Parameters.Add("@TIEMPO_D_M", SqlDbType.VarChar).Value = miDshgoVariable.TIEMPO_D_M;
                if (miDshgoVariable.TIEMPO_I != "") con.ObjCommand.Parameters.Add("@TIEMPO_I", SqlDbType.VarChar).Value = miDshgoVariable.TIEMPO_I;
                if (miDshgoVariable.TIEMPO_I_H != "") con.ObjCommand.Parameters.Add("@TIEMPO_I_H", SqlDbType.VarChar).Value = miDshgoVariable.TIEMPO_I_H;
                if (miDshgoVariable.TIEMPO_I_M != "") con.ObjCommand.Parameters.Add("@TIEMPO_I_M", SqlDbType.VarChar).Value = miDshgoVariable.TIEMPO_I_M;
                if (miDshgoVariable.SUBTOTAL != "") con.ObjCommand.Parameters.Add("@SUBTOTAL", SqlDbType.VarChar).Value = miDshgoVariable.SUBTOTAL;
                if (miDshgoVariable.SUBTOTAL_H != "") con.ObjCommand.Parameters.Add("@SUBTOTAL_H", SqlDbType.VarChar).Value = miDshgoVariable.SUBTOTAL_H;
                if (miDshgoVariable.SUBTOTAL_M != "") con.ObjCommand.Parameters.Add("@SUBTOTAL_M", SqlDbType.VarChar).Value = miDshgoVariable.SUBTOTAL_M;
                if (miDshgoVariable.TERCERO != "") con.ObjCommand.Parameters.Add("@TERCERO", SqlDbType.VarChar).Value = miDshgoVariable.TERCERO;
                if (miDshgoVariable.TERCERO_H != "") con.ObjCommand.Parameters.Add("@TERCERO_H", SqlDbType.VarChar).Value = miDshgoVariable.TERCERO_H;
                if (miDshgoVariable.TERCERO_M != "") con.ObjCommand.Parameters.Add("@TERCERO_M", SqlDbType.VarChar).Value = miDshgoVariable.TERCERO_M;
                if (miDshgoVariable.TOTAL != "") con.ObjCommand.Parameters.Add("@TOTAL", SqlDbType.VarChar).Value = miDshgoVariable.TOTAL;
                if (miDshgoVariable.TOTAL_H != "") con.ObjCommand.Parameters.Add("@TOTAL_H", SqlDbType.VarChar).Value = miDshgoVariable.TOTAL_H;
                if (miDshgoVariable.TOTAL_M != "") con.ObjCommand.Parameters.Add("@TOTAL_M", SqlDbType.VarChar).Value = miDshgoVariable.TOTAL_M;
                if (miDshgoVariable.DISC != "") con.ObjCommand.Parameters.Add("@DISC", SqlDbType.VarChar).Value = miDshgoVariable.DISC;
                if (miDshgoVariable.DISC_H != "") con.ObjCommand.Parameters.Add("@DISC_H", SqlDbType.VarChar).Value = miDshgoVariable.DISC_H;
                if (miDshgoVariable.DISC_M != "") con.ObjCommand.Parameters.Add("@DISC_M", SqlDbType.VarChar).Value = miDshgoVariable.DISC_M;
                if (miDshgoVariable.MEN_14 != "") con.ObjCommand.Parameters.Add("@MEN_14", SqlDbType.VarChar).Value = miDshgoVariable.MEN_14;
                if (miDshgoVariable.MEN_14_H != "") con.ObjCommand.Parameters.Add("@MEN_14_H", SqlDbType.VarChar).Value = miDshgoVariable.MEN_14_H;
                if (miDshgoVariable.MEN_14_M != "") con.ObjCommand.Parameters.Add("@MEN_14_M", SqlDbType.VarChar).Value = miDshgoVariable.MEN_14_M;
                if (miDshgoVariable.v14_16_PERMISO != "") con.ObjCommand.Parameters.Add("@v14_16_PERMISO", SqlDbType.VarChar).Value = miDshgoVariable.v14_16_PERMISO;
                if (miDshgoVariable.v14_16_PERMISO_H != "") con.ObjCommand.Parameters.Add("@v14_16_PERMISO_H", SqlDbType.VarChar).Value = miDshgoVariable.v14_16_PERMISO_H;
                if (miDshgoVariable.v14_16_PERMISO_M != "") con.ObjCommand.Parameters.Add("@v14_16_PERMISO_M", SqlDbType.VarChar).Value = miDshgoVariable.v14_16_PERMISO_M;
                if (miDshgoVariable.v14_16_S_PERMISO != "") con.ObjCommand.Parameters.Add("@v14_16_S_PERMISO", SqlDbType.VarChar).Value = miDshgoVariable.v14_16_S_PERMISO;
                if (miDshgoVariable.v14_16_S_PERMISO_H != "") con.ObjCommand.Parameters.Add("@v14_16_S_PERMISO_H", SqlDbType.VarChar).Value = miDshgoVariable.v14_16_S_PERMISO_H;
                if (miDshgoVariable.v14_16_S_PERMISO_M != "") con.ObjCommand.Parameters.Add("@v14_16_S_PERMISO_M", SqlDbType.VarChar).Value = miDshgoVariable.v14_16_S_PERMISO_M;
                if (miDshgoVariable.v16_18 != "") con.ObjCommand.Parameters.Add("@v16_18", SqlDbType.VarChar).Value = miDshgoVariable.v16_18;
                if (miDshgoVariable.v16_18_H != "") con.ObjCommand.Parameters.Add("@v16_18_H", SqlDbType.VarChar).Value = miDshgoVariable.v16_18_H;
                if (miDshgoVariable.v16_18_M != "") con.ObjCommand.Parameters.Add("@v16_18_M", SqlDbType.VarChar).Value = miDshgoVariable.v16_18_M;
                if (miDshgoVariable.LACTANCIA != "") con.ObjCommand.Parameters.Add("@LACTANCIA", SqlDbType.VarChar).Value = miDshgoVariable.LACTANCIA;
                if (miDshgoVariable.GESTACION != "") con.ObjCommand.Parameters.Add("@GESTACION", SqlDbType.VarChar).Value = miDshgoVariable.GESTACION;

                if (miDshgoVariable.CONTRATISTA_SI_NO != "") con.ObjCommand.Parameters.Add("@CONTRATISTA_SI_NO", SqlDbType.VarChar).Value = miDshgoVariable.CONTRATISTA_SI_NO;
                if (miDshgoVariable.cae_descripcion != "") con.ObjCommand.Parameters.Add("@cae_descripcion", SqlDbType.VarChar).Value = miDshgoVariable.cae_descripcion;
                if (miDshgoVariable.dsol_razon_social != "") con.ObjCommand.Parameters.Add("@dsol_razon_social", SqlDbType.VarChar).Value = miDshgoVariable.dsol_razon_social;
                if (miDshgoVariable.dsol_domicilio != "") con.ObjCommand.Parameters.Add("@dsol_domicilio", SqlDbType.VarChar).Value = miDshgoVariable.dsol_domicilio;
                if (miDshgoVariable.dsol_imss_registro != "") con.ObjCommand.Parameters.Add("@dsol_imss_registro", SqlDbType.VarChar).Value = miDshgoVariable.dsol_imss_registro;
                if (miDshgoVariable.dsol_num_hombres != "") con.ObjCommand.Parameters.Add("@dsol_num_hombres", SqlDbType.VarChar).Value = miDshgoVariable.dsol_num_hombres;
                if (miDshgoVariable.dsol_num_mujeres != "") con.ObjCommand.Parameters.Add("@dsol_num_mujeres", SqlDbType.VarChar).Value = miDshgoVariable.dsol_num_mujeres;
                if (miDshgoVariable.dsol_num_total != "") con.ObjCommand.Parameters.Add("@dsol_num_total", SqlDbType.VarChar).Value = miDshgoVariable.dsol_num_total;
                if (miDshgoVariable.motivo_ausencia_rep_trab != "") con.ObjCommand.Parameters.Add("@motivo_ausencia_rep_trab", SqlDbType.VarChar).Value = miDshgoVariable.motivo_ausencia_rep_trab;
                if (miDshgoVariable.MOTIVO_NEGATIVA != "") con.ObjCommand.Parameters.Add("@dshgo_motivo_negativa", SqlDbType.VarChar).Value = miDshgoVariable.MOTIVO_NEGATIVA;
                if (miDshgoVariable.MOTIVO_TESTIGO_2 != "") con.ObjCommand.Parameters.Add("@MOTIVO_TESTIGO_2", SqlDbType.VarChar).Value = miDshgoVariable.MOTIVO_TESTIGO_2;
                if (miDshgoVariable.TIPO_COMISION != "") con.ObjCommand.Parameters.Add("@TIPO_COMISION", SqlDbType.VarChar).Value = miDshgoVariable.TIPO_COMISION;
                if (!miDshgoVariable.FORMA_CONSTATACION_INSPECCION.Equals("")) con.ObjCommand.Parameters.Add("@FORMA_CONSTATACION", SqlDbType.VarChar).Value = miDshgoVariable.FORMA_CONSTATACION_INSPECCION;

                if (miDshgoVariable.FECHA_CIERRE_PARCIAL != "") con.ObjCommand.Parameters.Add("@FECHA_CIERRE_PARCIAL", SqlDbType.VarChar).Value = miDshgoVariable.FECHA_CIERRE_PARCIAL;
                if (miDshgoVariable.HORA_CIERRE_PARCIAL != "") con.ObjCommand.Parameters.Add("@HORA_CIERRE_PARCIAL", SqlDbType.VarChar).Value = miDshgoVariable.HORA_CIERRE_PARCIAL;

                if (miDshgoVariable.FECHA_REINICIO != "") con.ObjCommand.Parameters.Add("@FECHA_REINICIO", SqlDbType.VarChar).Value = miDshgoVariable.FECHA_REINICIO;
                if (miDshgoVariable.HORA_REINICIO != "") con.ObjCommand.Parameters.Add("@HORA_REINICIO", SqlDbType.VarChar).Value = miDshgoVariable.HORA_REINICIO;
                if (miDshgoVariable.DSHGO_MOTIVO_PARCIAL != "") con.ObjCommand.Parameters.Add("@DSHGO_MOTIVO_PARCIAL", SqlDbType.VarChar).Value = miDshgoVariable.DSHGO_MOTIVO_PARCIAL;

                if (miDshgoVariable.FECHA_CIERRE_PARCIAL_2 != "") con.ObjCommand.Parameters.Add("@FECHA_CIERRE_PARCIAL_2", SqlDbType.VarChar).Value = miDshgoVariable.FECHA_CIERRE_PARCIAL_2;
                if (miDshgoVariable.HORA_CIERRE_PARCIAL_2 != "") con.ObjCommand.Parameters.Add("@HORA_CIERRE_PARCIAL_2", SqlDbType.VarChar).Value = miDshgoVariable.HORA_CIERRE_PARCIAL_2;

                if (miDshgoVariable.FECHA_REINICIO_2 != "") con.ObjCommand.Parameters.Add("@FECHA_REINICIO_2", SqlDbType.VarChar).Value = miDshgoVariable.FECHA_REINICIO_2;
                if (miDshgoVariable.HORA_REINICIO_2 != "") con.ObjCommand.Parameters.Add("@HORA_REINICIO_2", SqlDbType.VarChar).Value = miDshgoVariable.HORA_REINICIO_2;
                if (miDshgoVariable.DSHGO_MOTIVO_PARCIAL_2 != "") con.ObjCommand.Parameters.Add("@DSHGO_MOTIVO_PARCIAL_2", SqlDbType.VarChar).Value = miDshgoVariable.DSHGO_MOTIVO_PARCIAL_2;

                if (miDshgoVariable.MOTIVO_AUSENCIA_COMISION != "") con.ObjCommand.Parameters.Add("@MOTIVO_AUSENCIA_COMISION", SqlDbType.VarChar).Value = miDshgoVariable.MOTIVO_AUSENCIA_COMISION;
                if (miDshgoVariable.NO_CUENTA_CON_TRABAJADORES != "") con.ObjCommand.Parameters.Add("@NO_CUENTA_CON_TRABAJADORES", SqlDbType.VarChar).Value = miDshgoVariable.NO_CUENTA_CON_TRABAJADORES;
                if (miDshgoVariable.domicilio3 != "") con.ObjCommand.Parameters.Add("@domicilio4", SqlDbType.VarChar).Value = miDshgoVariable.domicilio3;
                if (miDshgoVariable.USUARIO_ACTUAL != "") con.ObjCommand.Parameters.Add("@USUARIO_ACTUAL", SqlDbType.VarChar).Value = miDshgoVariable.USUARIO_ACTUAL;

                con.ObjCommand.Connection.Open();
                var count = con.ObjCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "Insertar";
                throw excepcion;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }



        public int DshgoMedida_AgregarActualizar(DtoDshgoMedida midtoDM)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedida_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (midtoDM.dshgo_medida_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = midtoDM.dshgo_medida_id;
                if (midtoDM.desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = midtoDM.desahogo_id;
                if (midtoDM.ind_medida_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_medida_id", SqlDbType.Int).Value = midtoDM.ind_medida_id;
                if (midtoDM.ind_info_adicional_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = midtoDM.ind_info_adicional_id;
                if (!String.IsNullOrEmpty(midtoDM.dmed_observaciones))
                    con.ObjCommand.Parameters.Add("@dmed_observaciones", SqlDbType.VarChar).Value = midtoDM.dmed_observaciones;

                if (midtoDM.dmed_cumplimiento_espontaneo == 1)
                    con.ObjCommand.Parameters.Add("@dmed_observaciones", SqlDbType.VarChar).Value = "";

                if (midtoDM.dmed_cumplimiento_espontaneo != -1)
                    con.ObjCommand.Parameters.Add("@dmed_cumplimiento_espontaneo", SqlDbType.Int).Value = midtoDM.dmed_cumplimiento_espontaneo;
                if (!String.IsNullOrEmpty(midtoDM.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = midtoDM.sys_usr;
                if (!String.IsNullOrEmpty(midtoDM.dmed_info_adicional_texto))
                    con.ObjCommand.Parameters.Add("@dmed_info_adicional_texto", SqlDbType.VarChar).Value = midtoDM.dmed_info_adicional_texto;
                if (midtoDM.dmed_restriccion_acceso != -1)
                    con.ObjCommand.Parameters.Add("@dmed_restriccion_acceso", SqlDbType.Int).Value = midtoDM.dmed_restriccion_acceso;
                if (midtoDM.dmed_restriccion_acceso != -1)
                    con.ObjCommand.Parameters.Add("@dmed_restriccion_decreto", SqlDbType.Int).Value = midtoDM.dmed_restriccion_decreto;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        public void DshgoMedida_Agregar_PorNegativaPatronal(int inspeccion_id, int inspeccion_origen_id, int desahogo_id, string sys_usr)
        {
            
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedida_Agregar_PorNegativaPatronal", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();                                
                con.ObjConnection.Dispose();
            }
        }


        public int DshgoMedida_AgregarActualizarOpen(DtoDshgoMedida midtoDM)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjCommand = new SqlCommand("PA_DshgoMedida_AgregarActualizar", conexion);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (midtoDM.dshgo_medida_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = midtoDM.dshgo_medida_id;
                if (midtoDM.desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = midtoDM.desahogo_id;
                if (midtoDM.ind_medida_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_medida_id", SqlDbType.Int).Value = midtoDM.ind_medida_id;
                if (midtoDM.ind_info_adicional_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = midtoDM.ind_info_adicional_id;
                if (!String.IsNullOrEmpty(midtoDM.dmed_observaciones))
                    con.ObjCommand.Parameters.Add("@dmed_observaciones", SqlDbType.VarChar).Value = midtoDM.dmed_observaciones;
                if (midtoDM.dmed_cumplimiento_espontaneo != -1)
                    con.ObjCommand.Parameters.Add("@dmed_cumplimiento_espontaneo", SqlDbType.Int).Value = midtoDM.dmed_cumplimiento_espontaneo;
                if (!String.IsNullOrEmpty(midtoDM.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = midtoDM.sys_usr;
                if (!String.IsNullOrEmpty(midtoDM.dmed_info_adicional_texto))
                    con.ObjCommand.Parameters.Add("@dmed_info_adicional_texto", SqlDbType.VarChar).Value = midtoDM.dmed_info_adicional_texto;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjCommand.Dispose();


            }
        }
        
        public int ObtenerAreaPorNombreDesahogo(string area, int desahogo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjCommand = new SqlCommand("PA_ObtenerAreaPorNombreDesahogo", conexion);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = desahogo_id;
                if (area != "")
                    con.ObjCommand.Parameters.Add("@area", SqlDbType.VarChar).Value = area;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjCommand.Dispose();


            }
        }
        
        public int DshgoMedida_AgregarActualizar2(DtoDshgoMedida midtoDM)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedida_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (midtoDM.dshgo_medida_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = midtoDM.dshgo_medida_id;
                if (midtoDM.desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = midtoDM.desahogo_id;
                if (midtoDM.ind_medida_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_medida_id", SqlDbType.Int).Value = midtoDM.ind_medida_id;
                if (midtoDM.ind_info_adicional_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = midtoDM.ind_info_adicional_id;
                if (!String.IsNullOrEmpty(midtoDM.dmed_observaciones))
                    con.ObjCommand.Parameters.Add("@dmed_observaciones", SqlDbType.VarChar).Value = midtoDM.dmed_observaciones;
                if (midtoDM.dmed_cumplimiento_espontaneo != -1)
                    con.ObjCommand.Parameters.Add("@dmed_cumplimiento_espontaneo", SqlDbType.Int).Value = midtoDM.dmed_cumplimiento_espontaneo;
                if (!String.IsNullOrEmpty(midtoDM.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = midtoDM.sys_usr;
                if (!String.IsNullOrEmpty(midtoDM.dmed_info_adicional_texto))
                    con.ObjCommand.Parameters.Add("@dmed_info_adicional_texto", SqlDbType.VarChar).Value = midtoDM.dmed_info_adicional_texto;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DshgoSindicato_Agregar(int dshgo_sindicato_id, int desahogo_id, string dsind_sindicato, string sys_usr, int sindicato_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Sindicato_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dshgo_sindicato_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_sindicato_id", SqlDbType.Int).Value = dshgo_sindicato_id;
                if (desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                if (!String.IsNullOrEmpty(dsind_sindicato))
                    con.ObjCommand.Parameters.Add("@dsind_sindicato", SqlDbType.VarChar).Value = dsind_sindicato;
                if (!String.IsNullOrEmpty(sys_usr))
                    con.ObjCommand.Parameters.Add("@usr", SqlDbType.VarChar).Value = sys_usr;
                if (sindicato_id != -1 && sindicato_id != 0)
                    con.ObjCommand.Parameters.Add("@dsind_dne_sindicato_id", SqlDbType.Int).Value = sindicato_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DshgoSindicato_Agregar(int dshgo_sindicato_id, int desahogo_id, string dsind_sindicato, string sys_usr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Sindicato_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dshgo_sindicato_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_sindicato_id", SqlDbType.Int).Value = dshgo_sindicato_id;
                if (desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                if (!String.IsNullOrEmpty(dsind_sindicato))
                    con.ObjCommand.Parameters.Add("@dsind_sindicato", SqlDbType.VarChar).Value = dsind_sindicato;
                if (!String.IsNullOrEmpty(sys_usr))
                    con.ObjCommand.Parameters.Add("@usr", SqlDbType.VarChar).Value = sys_usr;
                //if (sindicato_id != -1)
                //    con.ObjCommand.Parameters.Add("@dsind_dne_sindicato_id", SqlDbType.Int).Value = sindicato_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int DshgoMedDescatalogada_AgregarActualizar(DtoDshgoMedDescatalogada midtoDM)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedDescatalogada_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (midtoDM.dshgo_med_descatalogada_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_med_descatalogada_id", SqlDbType.Int).Value = midtoDM.dshgo_med_descatalogada_id;
                if (midtoDM.desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = midtoDM.desahogo_id;
                if (midtoDM.submateria_id != -1)
                    con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = midtoDM.submateria_id;
                if (midtoDM.ind_medida_plazo_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_medida_plazo_id", SqlDbType.Int).Value = midtoDM.ind_medida_plazo_id;
                if (!String.IsNullOrEmpty(midtoDM.dmd_medida))
                    con.ObjCommand.Parameters.Add("@dmd_medida", SqlDbType.VarChar).Value = midtoDM.dmd_medida;
                if (!String.IsNullOrEmpty(midtoDM.dmd_fundamento))
                    con.ObjCommand.Parameters.Add("@dmd_fundamento", SqlDbType.VarChar).Value = midtoDM.dmd_fundamento;
                if (!String.IsNullOrEmpty(midtoDM.dmd_observaciones))
                    con.ObjCommand.Parameters.Add("@dmd_observaciones", SqlDbType.VarChar).Value = midtoDM.dmd_observaciones;
                if (midtoDM.dmd_cumplimiento_espontaneo != -1)
                    con.ObjCommand.Parameters.Add("@dmd_cumplimiento_espontaneo", SqlDbType.Int).Value = midtoDM.dmd_cumplimiento_espontaneo;
                if (!String.IsNullOrEmpty(midtoDM.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = midtoDM.sys_usr;
                if (midtoDM.dmd_restriccion_acceso != -1)
                    con.ObjCommand.Parameters.Add("@dmd_restriccion_acceso", SqlDbType.Int).Value = midtoDM.dmd_restriccion_acceso;
                if (midtoDM.dmd_restriccion_decreto != -1)
                    con.ObjCommand.Parameters.Add("@dmd_restriccion_decreto", SqlDbType.Int).Value = midtoDM.dmd_restriccion_decreto;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int DshgoRevision_AgregarActualizar(DtoDshgoRevision dtoRevision)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_Agregar_Actualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoRevision.dshgo_revision_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_revision_id", SqlDbType.Int).Value = dtoRevision.dshgo_revision_id;
                if (dtoRevision.dshgo_alcance_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dtoRevision.dshgo_alcance_id;
                if (dtoRevision.indicador_id != -1)
                    con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = dtoRevision.indicador_id;
                if (dtoRevision.ind_inciso_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_inciso_id", SqlDbType.Int).Value = dtoRevision.ind_inciso_id;
                if (dtoRevision.drev_respuesta != -1)
                    con.ObjCommand.Parameters.Add("@drev_respuesta", SqlDbType.Int).Value = dtoRevision.drev_respuesta;

                if (!String.IsNullOrEmpty(dtoRevision.drev_observaciones))
                    con.ObjCommand.Parameters.Add("@drev_observaciones", SqlDbType.VarChar).Value = dtoRevision.drev_observaciones;
                if (!String.IsNullOrEmpty(dtoRevision.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoRevision.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DshgoMedDescatalogadaArea_AgregarActualizar(int dsgo_area_id, int dshgo_med_descatalogada_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedDescatalogadaArea_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dsgo_area_id", SqlDbType.Int).Value = dsgo_area_id;
                con.ObjCommand.Parameters.Add("@dshgo_med_descatalogada_id", SqlDbType.Int).Value = dshgo_med_descatalogada_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }



        public void DshgoMedidaArea_AgregarActualizar(int dsgo_area_id, int dshgo_medida_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedidaArea_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dsgo_area_id", SqlDbType.Int).Value = dsgo_area_id;
                con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = dshgo_medida_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void DshgoMedidaArea_AgregarActualizarOpen(int dsgo_area_id, int dshgo_medida_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjCommand = new SqlCommand("PA_DshgoMedidaArea_AgregarActualizar", conexion);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dsgo_area_id", SqlDbType.Int).Value = dsgo_area_id;
                con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = dshgo_medida_id;

                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjCommand.Dispose();


            }
        }

        public void DshgoMedida_ActualizarObservaciones(int dshgo_medida_id, string observaciones, string sysusr)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedida_ActualizarObservaciones", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = dshgo_medida_id;
                con.ObjCommand.Parameters.Add("@dmed_observaciones", SqlDbType.VarChar).Value = observaciones;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sysusr;
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int DshgoRevisionInfo_AgregarActualizar(DtoDshgoRevisionInfo dtoRI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_Info_Agregar_Actualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoRI.dshgo_revision_info_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_revision_info_id", SqlDbType.Int).Value = dtoRI.dshgo_revision_info_id;
                if (dtoRI.dshgo_revision_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_revision_id", SqlDbType.Int).Value = dtoRI.dshgo_revision_id;
                if (dtoRI.ind_info_adicional_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = dtoRI.ind_info_adicional_id;

                if (!String.IsNullOrEmpty(dtoRI.dri_informacion))
                    con.ObjCommand.Parameters.Add("@dri_informacion", SqlDbType.VarChar).Value = dtoRI.dri_informacion;
                if (!String.IsNullOrEmpty(dtoRI.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoRI.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Desahogo_Actualizar_dshgo_sin_Medidas(int desahogo_id, int dshgo_sin_medidas)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Desahogo_Actualizar_dshgo_sin_Medidas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@dshgo_sin_medidas", SqlDbType.Int).Value = dshgo_sin_medidas;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void InspectorMedida_AgregarActualizar(int desahogo_id, int participante_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspectorMedida_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }



        public int Centro_Agregar(DtoCentro dtoCentro)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_CentroAgregar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = dtoCentro.centro_trabajo_id;
                if (dtoCentro.empresa_id != -1)
                    con.ObjCommand.Parameters.Add("@empresa_id", SqlDbType.Int).Value = dtoCentro.empresa_id;
                if (dtoCentro.tipo_agencia_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_agencia_id", SqlDbType.Int).Value = dtoCentro.tipo_agencia_id;

                //Datos generales
                if (dtoCentro.ct_tipo_alta != -1)
                    con.ObjCommand.Parameters.Add("@ct_tipo_alta", SqlDbType.TinyInt).Value = dtoCentro.ct_tipo_alta;
                if (!string.IsNullOrEmpty(dtoCentro.ct_nombre))
                    con.ObjCommand.Parameters.Add("@ct_nombre", SqlDbType.VarChar).Value = dtoCentro.ct_nombre;
                if (!string.IsNullOrEmpty(dtoCentro.ct_nombre_comercial))
                    con.ObjCommand.Parameters.Add("@ct_nombre_comercial", SqlDbType.VarChar).Value = dtoCentro.ct_nombre_comercial;
                if (dtoCentro.segruidad_social_id != -1)
                    con.ObjCommand.Parameters.Add("@segruidad_social_id", SqlDbType.Int).Value = dtoCentro.segruidad_social_id;
                //if (!string.IsNullOrEmpty(dtoCentro.ct_imss_registro))
                con.ObjCommand.Parameters.Add("@ct_imss_registro", SqlDbType.VarChar).Value = dtoCentro.ct_imss_registro;
                if (!string.IsNullOrEmpty(dtoCentro.ct_observaciones))
                    con.ObjCommand.Parameters.Add("@ct_observaciones", SqlDbType.VarChar).Value = dtoCentro.ct_observaciones;
                if (dtoCentro.ct_es_movil != -1)
                    con.ObjCommand.Parameters.Add("@ct_es_movil", SqlDbType.TinyInt).Value = dtoCentro.ct_es_movil;
                if (dtoCentro.ct_es_estacional != -1)
                    con.ObjCommand.Parameters.Add("@ct_es_estacional", SqlDbType.TinyInt).Value = dtoCentro.ct_es_estacional;
                if (dtoCentro.ct_es_temporal != -1)
                    con.ObjCommand.Parameters.Add("@ct_es_temporal", SqlDbType.TinyInt).Value = dtoCentro.ct_es_temporal;

                if (dtoCentro.ct_prima_riesgo != -1.0f)
                    con.ObjCommand.Parameters.Add("@ct_prima_riesgo", SqlDbType.Float).Value = dtoCentro.ct_prima_riesgo;
                if (dtoCentro.ct_contrato_colectivo != -1)
                    con.ObjCommand.Parameters.Add("@ct_contrato_colectivo", SqlDbType.TinyInt).Value = dtoCentro.ct_contrato_colectivo;
                if (dtoCentro.ct_contrato_ley != -1)
                    con.ObjCommand.Parameters.Add("@ct_contrato_ley", SqlDbType.TinyInt).Value = dtoCentro.ct_contrato_ley;
                if (dtoCentro.ct_contrato_individual != -1)
                    con.ObjCommand.Parameters.Add("@ct_contrato_individual", SqlDbType.TinyInt).Value = dtoCentro.ct_contrato_individual;
                if (!string.IsNullOrEmpty(dtoCentro.ct_fec_colectivo))
                    con.ObjCommand.Parameters.Add("@ct_fec_colectivo", SqlDbType.DateTime).Value = dtoCentro.ct_fec_colectivo;
                if (!string.IsNullOrEmpty(dtoCentro.ct_fec_ley))
                    con.ObjCommand.Parameters.Add("@ct_fec_ley", SqlDbType.DateTime).Value = dtoCentro.ct_fec_ley;
                if (dtoCentro.ct_afiliado_camara != -1)
                    con.ObjCommand.Parameters.Add("@ct_afiliado_camara", SqlDbType.TinyInt).Value = dtoCentro.ct_afiliado_camara;
                if (dtoCentro.ct_sust_quimicas_peligrosas != -1)
                    con.ObjCommand.Parameters.Add("@ct_sust_quimicas_peligrosas", SqlDbType.TinyInt).Value = dtoCentro.ct_sust_quimicas_peligrosas;
                if (dtoCentro.ct_liquidos_inflamables != -1)
                    con.ObjCommand.Parameters.Add("@ct_liquidos_inflamables", SqlDbType.TinyInt).Value = dtoCentro.ct_liquidos_inflamables;
                if (dtoCentro.ct_materiales_piroforicos != -1)
                    con.ObjCommand.Parameters.Add("@ct_materiales_piroforicos", SqlDbType.TinyInt).Value = dtoCentro.ct_materiales_piroforicos;
                if (dtoCentro.ct_tiene_rspc != -1)
                    con.ObjCommand.Parameters.Add("@ct_tiene_rspc", SqlDbType.TinyInt).Value = dtoCentro.ct_tiene_rspc;
                if (dtoCentro.ct_es_agencia_colocacion != -1)
                    con.ObjCommand.Parameters.Add("@ct_es_agencia_colocacion", SqlDbType.TinyInt).Value = dtoCentro.ct_es_agencia_colocacion;
                if (dtoCentro.ct_tiene_sindicato != -1)
                    con.ObjCommand.Parameters.Add("@ct_tiene_sindicato", SqlDbType.TinyInt).Value = dtoCentro.ct_tiene_sindicato;
                if (dtoCentro.ct_num_trabajadores != -1)
                    con.ObjCommand.Parameters.Add("@ct_num_trabajadores", SqlDbType.Int).Value = dtoCentro.ct_num_trabajadores;

                //Domicilio
                if (dtoCentro.ct_es_domicilio_fiscal != -1)
                    con.ObjCommand.Parameters.Add("@ct_es_domicilio_fiscal", SqlDbType.Int).Value = dtoCentro.ct_es_domicilio_fiscal;
                if (dtoCentro.ct_cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@ct_cve_edorep", SqlDbType.Int).Value = dtoCentro.ct_cve_edorep;
                if (dtoCentro.ct_cve_municipio != -1)
                    con.ObjCommand.Parameters.Add("@ct_cve_municipio", SqlDbType.Int).Value = dtoCentro.ct_cve_municipio;
                if (!string.IsNullOrEmpty(dtoCentro.ct_calle))
                    con.ObjCommand.Parameters.Add("@ct_calle", SqlDbType.VarChar).Value = dtoCentro.ct_calle;
                if (!string.IsNullOrEmpty(dtoCentro.ct_num_exterior))
                    con.ObjCommand.Parameters.Add("@ct_num_exterior", SqlDbType.VarChar).Value = dtoCentro.ct_num_exterior;
                if (!string.IsNullOrEmpty(dtoCentro.ct_num_interior))
                    con.ObjCommand.Parameters.Add("@ct_num_interior", SqlDbType.VarChar).Value = dtoCentro.ct_num_interior;
                if (!string.IsNullOrEmpty(dtoCentro.ct_colonia))
                    con.ObjCommand.Parameters.Add("@ct_colonia", SqlDbType.VarChar).Value = dtoCentro.ct_colonia;
                if (!string.IsNullOrEmpty(dtoCentro.ct_poblacion))
                    con.ObjCommand.Parameters.Add("@ct_poblacion", SqlDbType.VarChar).Value = dtoCentro.ct_poblacion;
                if (!string.IsNullOrEmpty(dtoCentro.ct_cp))
                    con.ObjCommand.Parameters.Add("@ct_cp", SqlDbType.VarChar).Value = dtoCentro.ct_cp;
                if (!string.IsNullOrEmpty(dtoCentro.ct_ref_ubicacion))
                    con.ObjCommand.Parameters.Add("@ct_ref_ubicacion", SqlDbType.VarChar).Value = dtoCentro.ct_ref_ubicacion;
                if (!string.IsNullOrEmpty(dtoCentro.ct_longitud))
                    con.ObjCommand.Parameters.Add("@ct_longitud", SqlDbType.VarChar).Value = dtoCentro.ct_longitud;
                if (!string.IsNullOrEmpty(dtoCentro.ct_latitud))
                    con.ObjCommand.Parameters.Add("@ct_latitud", SqlDbType.VarChar).Value = dtoCentro.ct_latitud;
                if (!string.IsNullOrEmpty(dtoCentro.ct_telefono))
                    con.ObjCommand.Parameters.Add("@ct_telefono", SqlDbType.VarChar).Value = dtoCentro.ct_telefono;
                if (!string.IsNullOrEmpty(dtoCentro.ct_fax))
                    con.ObjCommand.Parameters.Add("@ct_fax", SqlDbType.VarChar).Value = dtoCentro.ct_fax;
                if (!string.IsNullOrEmpty(dtoCentro.ct_email))
                    con.ObjCommand.Parameters.Add("@ct_email", SqlDbType.VarChar).Value = dtoCentro.ct_email;

                //Actividad
                if (dtoCentro.ct_actividad_scian != -1)
                    con.ObjCommand.Parameters.Add("@ct_actividad_scian", SqlDbType.Int).Value = dtoCentro.ct_actividad_scian;
                if (dtoCentro.ct_actividad_imss != -1)
                    con.ObjCommand.Parameters.Add("@ct_actividad_imss", SqlDbType.Int).Value = dtoCentro.ct_actividad_imss;
                if (dtoCentro.ct_actividad_imss_riesgo != -1)
                    con.ObjCommand.Parameters.Add("@ct_actividad_imss_riesgo", SqlDbType.Int).Value = dtoCentro.ct_actividad_imss_riesgo;
                if (dtoCentro.rama_industrial_id != -1)
                    con.ObjCommand.Parameters.Add("@rama_industrial_id", SqlDbType.Int).Value = dtoCentro.rama_industrial_id;
                if (dtoCentro.ct_jurisdiccion != -1)
                    con.ObjCommand.Parameters.Add("@ct_jurisdiccion", SqlDbType.Int).Value = dtoCentro.ct_jurisdiccion;


                if (!string.IsNullOrEmpty(dtoCentro.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoCentro.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int CentroCamara_AgregarActualizar(DtoCentroCamara dtoCC)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_CentroCamara_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = dtoCC.centro_trabajo_id;

                if (dtoCC.centro_camara_id != -1)
                    con.ObjCommand.Parameters.Add("@centro_camara_id", SqlDbType.Int).Value = dtoCC.centro_camara_id;
                if (dtoCC.camara_id != -1)
                    con.ObjCommand.Parameters.Add("@camara_id", SqlDbType.Int).Value = dtoCC.camara_id;
                if (dtoCC.cc_no_incluida != -1)
                    con.ObjCommand.Parameters.Add("@cc_no_incluida", SqlDbType.Int).Value = dtoCC.cc_no_incluida;
                if (dtoCC.cc_orden != -1)
                    con.ObjCommand.Parameters.Add("@cc_orden", SqlDbType.TinyInt).Value = dtoCC.cc_orden;

                if (!string.IsNullOrEmpty(dtoCC.cc_otra_camara))
                    con.ObjCommand.Parameters.Add("@cc_otra_camara", SqlDbType.VarChar).Value = dtoCC.cc_otra_camara;

                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoCC.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int Empresa_Agregar(DtoEmpresa dtoempresa)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_EmpresaAgregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@empresa_id", SqlDbType.Int).Value = dtoempresa.empresa_id;

                if (dtoempresa.grupo_empresarial_id != -1)
                    con.ObjCommand.Parameters.Add("@grupo_empresarial_id", SqlDbType.Int).Value = dtoempresa.grupo_empresarial_id;
                if (dtoempresa.emp_tipo_persona != -1)
                    con.ObjCommand.Parameters.Add("@emp_tipo_persona", SqlDbType.TinyInt).Value = dtoempresa.emp_tipo_persona;
                if (!string.IsNullOrEmpty(dtoempresa.emp_rfc))
                    con.ObjCommand.Parameters.Add("@emp_rfc", SqlDbType.VarChar).Value = dtoempresa.emp_rfc;
                if (!string.IsNullOrEmpty(dtoempresa.emp_curp))
                    con.ObjCommand.Parameters.Add("@emp_curp", SqlDbType.VarChar).Value = dtoempresa.emp_curp;
                if (!string.IsNullOrEmpty(dtoempresa.emp_nombre))
                    con.ObjCommand.Parameters.Add("@emp_nombre", SqlDbType.VarChar).Value = dtoempresa.emp_nombre;
                if (!string.IsNullOrEmpty(dtoempresa.emp_nombre_comercial))
                    con.ObjCommand.Parameters.Add("@emp_nombre_comercial", SqlDbType.VarChar).Value = dtoempresa.emp_nombre_comercial;
                if (!string.IsNullOrEmpty(dtoempresa.emp_observaciones))
                    con.ObjCommand.Parameters.Add("@emp_observaciones", SqlDbType.VarChar).Value = dtoempresa.emp_observaciones;
                if (dtoempresa.emp_estatus != -1)
                    con.ObjCommand.Parameters.Add("@emp_estatus", SqlDbType.SmallInt).Value = dtoempresa.emp_estatus;
                if (!string.IsNullOrEmpty(dtoempresa.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoempresa.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int CentroSindicato_AgregarActualizar(DtoCentroSindicato dtoCS)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_CentroSindicato_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = dtoCS.centro_trabajo_id;

                if (dtoCS.centro_sindicato_id != -1)
                    con.ObjCommand.Parameters.Add("@centro_sindicato_id", SqlDbType.Int).Value = dtoCS.centro_sindicato_id;
                if (dtoCS.sindicato_id != -1)
                    con.ObjCommand.Parameters.Add("@sindicato_id", SqlDbType.Int).Value = dtoCS.sindicato_id;
                if (dtoCS.cs_no_incluido != -1)
                    con.ObjCommand.Parameters.Add("@cs_no_incluido", SqlDbType.Int).Value = dtoCS.cs_no_incluido;
                if (dtoCS.cs_orden != -1)
                    con.ObjCommand.Parameters.Add("@cs_orden", SqlDbType.Int).Value = dtoCS.cs_orden;

                if (!string.IsNullOrEmpty(dtoCS.cs_otro_sindicato))
                    con.ObjCommand.Parameters.Add("@cs_otro_sindicato", SqlDbType.VarChar).Value = dtoCS.cs_otro_sindicato;

                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoCS.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int CentroInformacion_AgregarActualizar(DtoCentroInformacion dtoCI)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_CentroInformacion_AgregarActualizar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoCI.centro_informacion_id != -1)
                    con.ObjCommand.Parameters.Add("@centro_informacion_id", SqlDbType.Int).Value = dtoCI.centro_informacion_id;
                if (dtoCI.centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = dtoCI.centro_trabajo_id;
                if (dtoCI.ci_actividad_capturado != -1)
                    con.ObjCommand.Parameters.Add("@ci_actividad_capturado", SqlDbType.Int).Value = dtoCI.ci_actividad_capturado;
                if (dtoCI.ci_camara_capturado != -1)
                    con.ObjCommand.Parameters.Add("@ci_camara_capturado", SqlDbType.Int).Value = dtoCI.ci_camara_capturado;
                if (dtoCI.ci_domicilio_capturado != -1)
                    con.ObjCommand.Parameters.Add("@ci_domicilio_capturado", SqlDbType.Int).Value = dtoCI.ci_domicilio_capturado;
                if (dtoCI.ci_empresas_capturado != -1)
                    con.ObjCommand.Parameters.Add("@ci_empresas_capturado", SqlDbType.Int).Value = dtoCI.ci_empresas_capturado;
                if (dtoCI.ci_identificacion_capturado != -1)
                    con.ObjCommand.Parameters.Add("@ci_identificacion_capturado", SqlDbType.Int).Value = dtoCI.ci_identificacion_capturado;
                if (dtoCI.ci_programas_capturado != -1)
                    con.ObjCommand.Parameters.Add("@ci_programas_capturado", SqlDbType.Int).Value = dtoCI.ci_programas_capturado;
                if (dtoCI.ci_sindicato_capturado != -1)
                    con.ObjCommand.Parameters.Add("@ci_sindicato_capturado", SqlDbType.Int).Value = dtoCI.ci_sindicato_capturado;
                if (dtoCI.ci_tipo_capturado != -1)
                    con.ObjCommand.Parameters.Add("@ci_tipo_capturado", SqlDbType.Int).Value = dtoCI.ci_tipo_capturado;
                if (dtoCI.ci_trabajadores_capturado != -1)
                    con.ObjCommand.Parameters.Add("@ci_trabajadores_capturado", SqlDbType.Int).Value = dtoCI.ci_trabajadores_capturado;

                if (!string.IsNullOrEmpty(dtoCI.ci_actividad_origen))
                    con.ObjCommand.Parameters.Add("@ci_actividad_origen", SqlDbType.VarChar).Value = dtoCI.ci_actividad_origen;
                if (!string.IsNullOrEmpty(dtoCI.ci_actividad_usr))
                    con.ObjCommand.Parameters.Add("@ci_actividad_usr", SqlDbType.VarChar).Value = dtoCI.ci_actividad_usr;
                if (!string.IsNullOrEmpty(dtoCI.ci_camara_origen))
                    con.ObjCommand.Parameters.Add("@ci_camara_origen", SqlDbType.VarChar).Value = dtoCI.ci_camara_origen;
                if (!string.IsNullOrEmpty(dtoCI.ci_camara_usr))
                    con.ObjCommand.Parameters.Add("@ci_camara_usr", SqlDbType.VarChar).Value = dtoCI.ci_camara_usr;
                if (!string.IsNullOrEmpty(dtoCI.ci_domicilio_origen))
                    con.ObjCommand.Parameters.Add("@ci_domicilio_origen", SqlDbType.VarChar).Value = dtoCI.ci_domicilio_origen;
                if (!string.IsNullOrEmpty(dtoCI.ci_domicilio_usr))
                    con.ObjCommand.Parameters.Add("@ci_domicilio_usr", SqlDbType.VarChar).Value = dtoCI.ci_domicilio_usr;
                if (!string.IsNullOrEmpty(dtoCI.ci_empresas_origen))
                    con.ObjCommand.Parameters.Add("@ci_empresas_origen", SqlDbType.VarChar).Value = dtoCI.ci_empresas_origen;
                if (!string.IsNullOrEmpty(dtoCI.ci_empresas_usr))
                    con.ObjCommand.Parameters.Add("@ci_empresas_usr", SqlDbType.VarChar).Value = dtoCI.ci_empresas_usr;
                if (!string.IsNullOrEmpty(dtoCI.ci_identificacion_origen))
                    con.ObjCommand.Parameters.Add("@ci_identificacion_origen", SqlDbType.VarChar).Value = dtoCI.ci_identificacion_origen;
                if (!string.IsNullOrEmpty(dtoCI.ci_identificacion_usr))
                    con.ObjCommand.Parameters.Add("@ci_identificacion_usr", SqlDbType.VarChar).Value = dtoCI.ci_identificacion_usr;
                if (!string.IsNullOrEmpty(dtoCI.ci_programas_origen))
                    con.ObjCommand.Parameters.Add("@ci_programas_origen", SqlDbType.VarChar).Value = dtoCI.ci_programas_origen;
                if (!string.IsNullOrEmpty(dtoCI.ci_programas_usr))
                    con.ObjCommand.Parameters.Add("@ci_programas_usr", SqlDbType.VarChar).Value = dtoCI.ci_programas_usr;
                if (!string.IsNullOrEmpty(dtoCI.ci_sindicato_origen))
                    con.ObjCommand.Parameters.Add("@ci_sindicato_origen", SqlDbType.VarChar).Value = dtoCI.ci_sindicato_origen;
                if (!string.IsNullOrEmpty(dtoCI.ci_sindicato_usr))
                    con.ObjCommand.Parameters.Add("@ci_sindicato_usr", SqlDbType.VarChar).Value = dtoCI.ci_sindicato_usr;
                if (!string.IsNullOrEmpty(dtoCI.ci_tipo_origen))
                    con.ObjCommand.Parameters.Add("@ci_tipo_origen", SqlDbType.VarChar).Value = dtoCI.ci_tipo_origen;
                if (!string.IsNullOrEmpty(dtoCI.ci_tipo_usr))
                    con.ObjCommand.Parameters.Add("@ci_tipo_usr", SqlDbType.VarChar).Value = dtoCI.ci_tipo_usr;
                if (!string.IsNullOrEmpty(dtoCI.ci_trabajadores_origen))
                    con.ObjCommand.Parameters.Add("@ci_trabajadores_origen", SqlDbType.VarChar).Value = dtoCI.ci_trabajadores_origen;
                if (!string.IsNullOrEmpty(dtoCI.ci_trabajadores_usr))
                    con.ObjCommand.Parameters.Add("@ci_trabajadores_usr", SqlDbType.VarChar).Value = dtoCI.ci_trabajadores_usr;

                if (!string.IsNullOrEmpty(dtoCI.ci_actividad_fec))
                    con.ObjCommand.Parameters.Add("@ci_actividad_fec", SqlDbType.DateTime).Value = dtoCI.ci_actividad_fec;
                if (!string.IsNullOrEmpty(dtoCI.ci_camara_fec))
                    con.ObjCommand.Parameters.Add("@ci_camara_fec", SqlDbType.DateTime).Value = dtoCI.ci_camara_fec;
                if (!string.IsNullOrEmpty(dtoCI.ci_domicilio_fec))
                    con.ObjCommand.Parameters.Add("@ci_domicilio_fec", SqlDbType.DateTime).Value = dtoCI.ci_domicilio_fec;
                if (!string.IsNullOrEmpty(dtoCI.ci_empresas_fec))
                    con.ObjCommand.Parameters.Add("@ci_empresas_fec", SqlDbType.DateTime).Value = dtoCI.ci_empresas_fec;
                if (!string.IsNullOrEmpty(dtoCI.ci_identificacion_fec))
                    con.ObjCommand.Parameters.Add("@ci_identificacion_fec", SqlDbType.DateTime).Value = dtoCI.ci_identificacion_fec;
                if (!string.IsNullOrEmpty(dtoCI.ci_programas_fec))
                    con.ObjCommand.Parameters.Add("@ci_programas_fec", SqlDbType.DateTime).Value = dtoCI.ci_programas_fec;
                if (!string.IsNullOrEmpty(dtoCI.ci_sindicato_fec))
                    con.ObjCommand.Parameters.Add("@ci_sindicato_fec", SqlDbType.DateTime).Value = dtoCI.ci_sindicato_fec;
                if (!string.IsNullOrEmpty(dtoCI.ci_tipo_fec))
                    con.ObjCommand.Parameters.Add("@ci_tipo_fec", SqlDbType.DateTime).Value = dtoCI.ci_tipo_fec;
                if (!string.IsNullOrEmpty(dtoCI.ci_trabajadores_fec))
                    con.ObjCommand.Parameters.Add("@ci_trabajadores_fec", SqlDbType.DateTime).Value = dtoCI.ci_trabajadores_fec;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int CentroMovimiento_AgregarActualizar(DtoCentroMovimiento dtoCM)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_CentroMovimiento_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoCM.centro_movto_id != -1)
                    con.ObjCommand.Parameters.Add("@centro_movto_id", SqlDbType.Int).Value = dtoCM.centro_movto_id;
                if (dtoCM.centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = dtoCM.centro_trabajo_id;
                if (dtoCM.ctmov_tipo_movto != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_tipo_movto", SqlDbType.Int).Value = dtoCM.ctmov_tipo_movto;
                if (dtoCM.ctmov_resolucion != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_resolucion", SqlDbType.Int).Value = dtoCM.ctmov_resolucion;
                if (dtoCM.ctmov_estatus != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_estatus", SqlDbType.Int).Value = dtoCM.ctmov_estatus;

                if (!string.IsNullOrEmpty(dtoCM.ctmov_autor))
                    con.ObjCommand.Parameters.Add("@ctmov_autor", SqlDbType.VarChar).Value = dtoCM.ctmov_autor;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_origen))
                    con.ObjCommand.Parameters.Add("@ctmov_origen", SqlDbType.VarChar).Value = dtoCM.ctmov_origen;

                //Generales
                if (!string.IsNullOrEmpty(dtoCM.ctmov_nombre))
                    con.ObjCommand.Parameters.Add("@ctmov_nombre", SqlDbType.VarChar).Value = dtoCM.ctmov_nombre;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_nombre_comercial))
                    con.ObjCommand.Parameters.Add("@ctmov_nombre_comercial", SqlDbType.VarChar).Value = dtoCM.ctmov_nombre_comercial;
                if (dtoCM.segruidad_social_id != -1)
                    con.ObjCommand.Parameters.Add("@segruidad_social_id", SqlDbType.Int).Value = dtoCM.segruidad_social_id;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_imss_registro))
                    con.ObjCommand.Parameters.Add("@ctmov_imss_registro", SqlDbType.VarChar).Value = dtoCM.ctmov_imss_registro;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_observaciones))
                    con.ObjCommand.Parameters.Add("@ctmov_observaciones", SqlDbType.VarChar).Value = dtoCM.ctmov_observaciones;
                if (dtoCM.ctmov_es_movil != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_es_movil", SqlDbType.Int).Value = dtoCM.ctmov_es_movil;
                if (dtoCM.ctmov_es_estacional != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_es_estacional", SqlDbType.Int).Value = dtoCM.ctmov_es_estacional;
                if (dtoCM.ctmov_es_temporal != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_es_temporal", SqlDbType.Int).Value = dtoCM.ctmov_es_temporal;

                //Domicilio
                if (dtoCM.ctmov_es_domicilio_fiscal != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_es_domicilio_fiscal", SqlDbType.Int).Value = dtoCM.ctmov_es_domicilio_fiscal;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_calle))
                    con.ObjCommand.Parameters.Add("@ctmov_calle", SqlDbType.VarChar).Value = dtoCM.ctmov_calle;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_num_exterior))
                    con.ObjCommand.Parameters.Add("@ctmov_num_exterior", SqlDbType.VarChar).Value = dtoCM.ctmov_num_exterior;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_num_interior))
                    con.ObjCommand.Parameters.Add("@ctmov_num_interior", SqlDbType.VarChar).Value = dtoCM.ctmov_num_interior;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_colonia))
                    con.ObjCommand.Parameters.Add("@ctmov_colonia", SqlDbType.VarChar).Value = dtoCM.ctmov_colonia;
                if (dtoCM.ctmov_cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_cve_edorep", SqlDbType.Int).Value = dtoCM.ctmov_cve_edorep;
                if (dtoCM.ctmov_cve_municipio != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_cve_municipio", SqlDbType.Int).Value = dtoCM.ctmov_cve_municipio;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_poblacion))
                    con.ObjCommand.Parameters.Add("@ctmov_poblacion", SqlDbType.VarChar).Value = dtoCM.ctmov_poblacion;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_cp))
                    con.ObjCommand.Parameters.Add("@ctmov_cp", SqlDbType.Char).Value = dtoCM.ctmov_cp;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_ref_ubicacion))
                    con.ObjCommand.Parameters.Add("@ctmov_ref_ubicacion", SqlDbType.VarChar).Value = dtoCM.ctmov_ref_ubicacion;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_latitud))
                    con.ObjCommand.Parameters.Add("@ctmov_latitud", SqlDbType.VarChar).Value = dtoCM.ctmov_latitud;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_longitud))
                    con.ObjCommand.Parameters.Add("@ctmov_longitud", SqlDbType.VarChar).Value = dtoCM.ctmov_longitud;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_telefono))
                    con.ObjCommand.Parameters.Add("@ctmov_telefono", SqlDbType.Char).Value = dtoCM.ctmov_telefono;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_fax))
                    con.ObjCommand.Parameters.Add("@ctmov_fax", SqlDbType.Char).Value = dtoCM.ctmov_fax;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_email))
                    con.ObjCommand.Parameters.Add("@ctmov_email", SqlDbType.VarChar).Value = dtoCM.ctmov_email;

                //Actividad
                if (dtoCM.ctmov_actividad_scian != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_actividad_scian", SqlDbType.Int).Value = dtoCM.ctmov_actividad_scian;
                if (dtoCM.ctmov_actividad_imss != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_actividad_imss", SqlDbType.Int).Value = dtoCM.ctmov_actividad_imss;
                if (dtoCM.ctmov_actividad_imss_riesgo != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_actividad_imss_riesgo", SqlDbType.Int).Value = dtoCM.ctmov_actividad_imss_riesgo;
                if (dtoCM.ctmov_jurisdiccion != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_jurisdiccion", SqlDbType.TinyInt).Value = dtoCM.ctmov_jurisdiccion;
                if (dtoCM.rama_industrial_id != -1)
                    con.ObjCommand.Parameters.Add("@rama_industrial_id", SqlDbType.Int).Value = dtoCM.rama_industrial_id;

                //Trabajadores
                if (dtoCM.ctmov_contrato_individual != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_contrato_individual", SqlDbType.TinyInt).Value = dtoCM.ctmov_contrato_individual;
                if (dtoCM.ctmov_contrato_colectivo != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_contrato_colectivo", SqlDbType.TinyInt).Value = dtoCM.ctmov_contrato_colectivo;
                if (dtoCM.ctmov_contrato_ley != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_contrato_ley", SqlDbType.TinyInt).Value = dtoCM.ctmov_contrato_ley;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_fec_colectivo))
                    con.ObjCommand.Parameters.Add("@ctmov_fec_colectivo", SqlDbType.DateTime).Value = dtoCM.ctmov_fec_colectivo;
                if (!string.IsNullOrEmpty(dtoCM.ctmov_fec_ley))
                    con.ObjCommand.Parameters.Add("@ctmov_fec_ley", SqlDbType.DateTime).Value = dtoCM.ctmov_fec_ley;
                if (dtoCM.ctmov_num_trabajadores != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_num_trabajadores", SqlDbType.Int).Value = dtoCM.ctmov_num_trabajadores;
                if (dtoCM.ctmov_tiene_sindicato != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_tiene_sindicato", SqlDbType.TinyInt).Value = dtoCM.ctmov_tiene_sindicato;
                if (dtoCM.ctmov_afiliado_camara != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_afiliado_camara", SqlDbType.TinyInt).Value = dtoCM.ctmov_afiliado_camara;
                if (dtoCM.ctmov_es_organismo != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_es_organismo", SqlDbType.TinyInt).Value = dtoCM.ctmov_es_organismo;
                if (dtoCM.tipo_organismo_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_organismo_id", SqlDbType.Int).Value = dtoCM.tipo_organismo_id;
                if (dtoCM.ctmov_es_agencia_colocacion != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_es_agencia_colocacion", SqlDbType.TinyInt).Value = dtoCM.ctmov_es_agencia_colocacion;
                if (dtoCM.tipo_agencia_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_agencia_id", SqlDbType.Int).Value = dtoCM.tipo_agencia_id;
                //Programas
                if (dtoCM.ctmov_en_declare != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_en_declare", SqlDbType.TinyInt).Value = dtoCM.ctmov_en_declare;
                if (dtoCM.ctmov_en_passt != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_en_passt", SqlDbType.TinyInt).Value = dtoCM.ctmov_en_passt;
                if (dtoCM.ctmov_acreditado_sasst != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_acreditado_sasst", SqlDbType.TinyInt).Value = dtoCM.ctmov_acreditado_sasst;
                if (dtoCM.ctmov_todo_centro != -1)
                    con.ObjCommand.Parameters.Add("@ctmov_todo_centro", SqlDbType.TinyInt).Value = dtoCM.ctmov_todo_centro;
                //Solidarias
                if (!string.IsNullOrEmpty(dtoCM.ctmov_solidarias))
                    con.ObjCommand.Parameters.Add("@ctmov_solidarias", SqlDbType.Text).Value = dtoCM.ctmov_solidarias;
                //Sindicatos
                if (!string.IsNullOrEmpty(dtoCM.ctmov_sindicatos))
                    con.ObjCommand.Parameters.Add("@ctmov_sindicatos", SqlDbType.Text).Value = dtoCM.ctmov_sindicatos;
                //Camaras
                if (!string.IsNullOrEmpty(dtoCM.ctmov_camaras))
                    con.ObjCommand.Parameters.Add("@ctmov_camaras", SqlDbType.Text).Value = dtoCM.ctmov_camaras;



                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoCM.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public int EmpresaMovimiento_AgregarActualizar(DtoEmpresaMovimiento dtoEM)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_EmpresaMovimiento_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoEM.empresa_movto_id != -1)
                    con.ObjCommand.Parameters.Add("@empresa_movto_id", SqlDbType.Int).Value = dtoEM.empresa_movto_id;
                if (dtoEM.empresa_id != -1)
                    con.ObjCommand.Parameters.Add("@empresa_id", SqlDbType.Int).Value = dtoEM.empresa_id;
                if (dtoEM.emov_tipo_movto != -1)
                    con.ObjCommand.Parameters.Add("@emov_tipo_movto", SqlDbType.Int).Value = dtoEM.emov_tipo_movto;
                if (!string.IsNullOrEmpty(dtoEM.emov_autor))
                    con.ObjCommand.Parameters.Add("@emov_autor", SqlDbType.VarChar).Value = dtoEM.emov_autor;
                if (!string.IsNullOrEmpty(dtoEM.emov_origen))
                    con.ObjCommand.Parameters.Add("@emov_origen", SqlDbType.VarChar).Value = dtoEM.emov_origen;
                if (dtoEM.emov_resolucion != -1)
                    con.ObjCommand.Parameters.Add("@emov_resolucion", SqlDbType.Int).Value = dtoEM.emov_resolucion;
                if (!string.IsNullOrEmpty(dtoEM.emov_rfc))
                    con.ObjCommand.Parameters.Add("@emov_rfc", SqlDbType.VarChar).Value = dtoEM.emov_rfc;
                if (!string.IsNullOrEmpty(dtoEM.emov_curp))
                    con.ObjCommand.Parameters.Add("@emov_curp", SqlDbType.VarChar).Value = dtoEM.emov_curp;
                if (!string.IsNullOrEmpty(dtoEM.emov_nombre))
                    con.ObjCommand.Parameters.Add("@emov_nombre", SqlDbType.VarChar).Value = dtoEM.emov_nombre;
                if (dtoEM.emov_estatus != -1)
                    con.ObjCommand.Parameters.Add("@emov_estatus", SqlDbType.Int).Value = dtoEM.emov_estatus;

                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoEM.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }
        #endregion

        #region Calificaicon
        public int Calificacion_AgregarActualizar(DtoCalificacion DtoCalf)
        {
            Constantes con = new Constantes();
            try
            {
                int new_calificacion_id = 0;
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Calificacion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = DtoCalf.calificacion_id;
                if (DtoCalf.desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DtoCalf.desahogo_id;
                if (DtoCalf.participante_id != -1)
                    con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = DtoCalf.participante_id;
                if (DtoCalf.calif_fec_asignacion != "")
                    con.ObjCommand.Parameters.Add("@calif_fec_asignacion", SqlDbType.DateTime).Value = DtoCalf.calif_fec_asignacion;
                if (DtoCalf.calif_fec_calificacion != "")
                    con.ObjCommand.Parameters.Add("@calif_fec_calificacion", SqlDbType.DateTime).Value = DtoCalf.calif_fec_calificacion;
                if (DtoCalf.calif_fec_recibio_escrito != "")
                    con.ObjCommand.Parameters.Add("@calif_fec_recibio_escrito", SqlDbType.DateTime).Value = DtoCalf.calif_fec_recibio_escrito;
                if (DtoCalf.calif_se_recibio_escrito != -1)
                    con.ObjCommand.Parameters.Add("@calif_se_recibio_escrito", SqlDbType.Int).Value = DtoCalf.calif_se_recibio_escrito;
                if (DtoCalf.calif_escrito_dentro_plazo != -1)
                    con.ObjCommand.Parameters.Add("@calif_escrito_dentro_plazo", SqlDbType.Int).Value = DtoCalf.calif_escrito_dentro_plazo;
                if (DtoCalf.calif_num_fojas != "")
                    con.ObjCommand.Parameters.Add("@calif_num_fojas", SqlDbType.VarChar).Value = DtoCalf.calif_num_fojas;
                if (DtoCalf.calif_acredita_personalidad != -1)
                    con.ObjCommand.Parameters.Add("@calif_acredita_personalidad", SqlDbType.Int).Value = DtoCalf.calif_acredita_personalidad;
                if (DtoCalf.calif_solventa_violaciones != -1)
                    con.ObjCommand.Parameters.Add("@calif_solventa_violaciones", SqlDbType.Int).Value = DtoCalf.calif_solventa_violaciones;
                if (DtoCalf.calif_valoracion_pruebas != "")
                    con.ObjCommand.Parameters.Add("@calif_valoracion_pruebas", SqlDbType.VarChar).Value = DtoCalf.calif_valoracion_pruebas;
                if (DtoCalf.calif_cumple_requisitos != -1)
                    con.ObjCommand.Parameters.Add("@calif_cumple_requisitos", SqlDbType.Int).Value = DtoCalf.calif_cumple_requisitos;
                if (DtoCalf.calif_contiene_violaciones != -1)
                    con.ObjCommand.Parameters.Add("@calif_contiene_violaciones", SqlDbType.Int).Value = DtoCalf.calif_contiene_violaciones;
                if (DtoCalf.calif_contiene_medidas != -1)
                    con.ObjCommand.Parameters.Add("@calif_contiene_medidas", SqlDbType.Int).Value = DtoCalf.calif_contiene_medidas;
                if (DtoCalf.calif_estatus != -1)
                    con.ObjCommand.Parameters.Add("@calif_estatus", SqlDbType.Int).Value = DtoCalf.calif_estatus;





                if (DtoCalf.sys_usr != "")
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = DtoCalf.sys_usr;
                if (DtoCalf.sys_usr_insert != "")
                    con.ObjCommand.Parameters.Add("@sys_usr_insert", SqlDbType.VarChar).Value = DtoCalf.sys_usr_insert;


                SqlParameter outPutVal = new SqlParameter("@new_calificacion_id", SqlDbType.Int);
                outPutVal.Direction = ParameterDirection.Output;
                con.ObjCommand.Parameters.Add(outPutVal);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                if (outPutVal.Value != DBNull.Value)
                    new_calificacion_id = Convert.ToInt32(outPutVal.Value);
                else
                    new_calificacion_id = DtoCalf.calificacion_id;


                return new_calificacion_id;


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int CalifDocumento_AgregarActualizar(DtoCalifDocumento miDtoCD)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDocumento_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoCD.calif_documento_id != -1)
                    con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = miDtoCD.calif_documento_id;
                if (miDtoCD.tipo_documento_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = miDtoCD.tipo_documento_id;
                if (miDtoCD.calificacion_id != -1)
                    con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = miDtoCD.calificacion_id;
                if (miDtoCD.participante_id != -1)
                    con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = miDtoCD.participante_id;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_num_documento))
                    con.ObjCommand.Parameters.Add("@cdoc_num_documento", SqlDbType.VarChar).Value = miDtoCD.cdoc_num_documento;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_fec_documento))
                    con.ObjCommand.Parameters.Add("@cdoc_fec_documento", SqlDbType.DateTime).Value = miDtoCD.cdoc_fec_documento;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_nombre_documento))
                    con.ObjCommand.Parameters.Add("@cdoc_nombre_documento", SqlDbType.VarChar).Value = miDtoCD.cdoc_nombre_documento;
                if (miDtoCD.cdoc_firma_titular != -1)
                    con.ObjCommand.Parameters.Add("@cdoc_firma_titular", SqlDbType.Int).Value = miDtoCD.cdoc_firma_titular;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_firmante))
                    con.ObjCommand.Parameters.Add("@cdoc_firmante", SqlDbType.VarChar).Value = miDtoCD.cdoc_firmante;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_puesto))
                    con.ObjCommand.Parameters.Add("@cdoc_puesto", SqlDbType.VarChar).Value = miDtoCD.cdoc_puesto;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_observaciones))
                    con.ObjCommand.Parameters.Add("@cdoc_observaciones", SqlDbType.VarChar).Value = miDtoCD.cdoc_observaciones;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_url_documento))
                    con.ObjCommand.Parameters.Add("@cdoc_url_documento", SqlDbType.VarChar).Value = miDtoCD.cdoc_url_documento;
                if (!String.IsNullOrEmpty(miDtoCD.doc_url_archivo_sin_firmas))
                    con.ObjCommand.Parameters.Add("@doc_url_archivo_sin_firmas", SqlDbType.VarChar).Value = miDtoCD.doc_url_archivo_sin_firmas;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_hash))
                    con.ObjCommand.Parameters.Add("@cdoc_hash", SqlDbType.VarChar).Value = miDtoCD.cdoc_hash;
                if (!String.IsNullOrEmpty(miDtoCD.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoCD.sys_usr;
                if (miDtoCD.participante_juridico_id != -1)
                    con.ObjCommand.Parameters.Add("@participante_juridico_id", SqlDbType.Int).Value = miDtoCD.participante_juridico_id;
                if (miDtoCD.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoCD.cve_ur;
                if (miDtoCD.documento_firmado != -1)
                    con.ObjCommand.Parameters.Add("@documento_firmado", SqlDbType.Int).Value = miDtoCD.documento_firmado;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;


            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        //agregar califdocumento por calificacion
        public int CalifDocumento_AgregarActualizarPorCalificacion(DtoCalifDocumento miDtoCD)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDocumento_AgregarActualizarPorCalificacion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                //if (miDtoCD.calif_documento_id != -1)
                //    con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = miDtoCD.calif_documento_id;
                if (miDtoCD.tipo_documento_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = miDtoCD.tipo_documento_id;
                if (miDtoCD.calificacion_id != -1)
                    con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = miDtoCD.calificacion_id;
                if (miDtoCD.participante_id != -1)
                    con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = miDtoCD.participante_id;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_num_documento))
                    con.ObjCommand.Parameters.Add("@cdoc_num_documento", SqlDbType.VarChar).Value = miDtoCD.cdoc_num_documento;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_fec_documento))
                    con.ObjCommand.Parameters.Add("@cdoc_fec_documento", SqlDbType.DateTime).Value = miDtoCD.cdoc_fec_documento;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_nombre_documento))
                    con.ObjCommand.Parameters.Add("@cdoc_nombre_documento", SqlDbType.VarChar).Value = miDtoCD.cdoc_nombre_documento;
                if (miDtoCD.cdoc_firma_titular != -1)
                    con.ObjCommand.Parameters.Add("@cdoc_firma_titular", SqlDbType.Int).Value = miDtoCD.cdoc_firma_titular;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_firmante))
                    con.ObjCommand.Parameters.Add("@cdoc_firmante", SqlDbType.VarChar).Value = miDtoCD.cdoc_firmante;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_puesto))
                    con.ObjCommand.Parameters.Add("@cdoc_puesto", SqlDbType.VarChar).Value = miDtoCD.cdoc_puesto;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_observaciones))
                    con.ObjCommand.Parameters.Add("@cdoc_observaciones", SqlDbType.VarChar).Value = miDtoCD.cdoc_observaciones;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_url_documento))
                    con.ObjCommand.Parameters.Add("@cdoc_url_documento", SqlDbType.VarChar).Value = miDtoCD.cdoc_url_documento;
                if (!String.IsNullOrEmpty(miDtoCD.cdoc_hash))
                    con.ObjCommand.Parameters.Add("@cdoc_hash", SqlDbType.VarChar).Value = miDtoCD.cdoc_hash;
                if (!String.IsNullOrEmpty(miDtoCD.sys_usr))
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoCD.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void CalifDoctoCopias_AgregarActualizar(DtoCalifDoctoCopias miDtoCDC)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDoctoCopias_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = miDtoCDC.calif_documento_id;
                con.ObjCommand.Parameters.Add("@cdc_nombre", SqlDbType.VarChar).Value = miDtoCDC.cdc_nombre;
                con.ObjCommand.Parameters.Add("@cdc_copia_o_rubrica", SqlDbType.Int).Value = miDtoCDC.cdc_copia_o_rubrica;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoCDC.sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void CalifViolacion_AgregarNumSolicitud(DtoCalifViolacion miDtoCV, string tipo_inspeccion = "")
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_AgregarNumSolicitud", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = miDtoCV.calificacion_id;
                con.ObjCommand.Parameters.Add("@code_tipo_documento", SqlDbType.VarChar).Value = miDtoCV.code_tipo_documento;
                con.ObjCommand.Parameters.Add("@num_solicitud", SqlDbType.VarChar).Value = miDtoCV.num_solicitud;
                if(tipo_inspeccion !=  "")
                    con.ObjCommand.Parameters.Add("@tipo_inspeccion", SqlDbType.VarChar).Value = tipo_inspeccion;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        public void CalifViolacion_AgregarActualizar(DtoCalifViolacion miDtoCV)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_violacion_id", SqlDbType.Int).Value = miDtoCV.calif_violacion_id;
                if (miDtoCV.dshgo_revision_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_revision_id", SqlDbType.Int).Value = miDtoCV.dshgo_revision_id;
                if (miDtoCV.cdshgo_medida_id != -1)
                    con.ObjCommand.Parameters.Add("@cdshgo_medida_id ", SqlDbType.Int).Value = miDtoCV.cdshgo_medida_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = miDtoCV.calificacion_id;
                con.ObjCommand.Parameters.Add("@cviol_numeral", SqlDbType.VarChar).Value = miDtoCV.cviol_numeral;
                con.ObjCommand.Parameters.Add("@cviol_violacion", SqlDbType.VarChar).Value = miDtoCV.cviol_violacion;
                con.ObjCommand.Parameters.Add("@cviol_procede", SqlDbType.Int).Value = miDtoCV.cviol_procede;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoCV.sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }





        public void CalifViolacion_AgregarActualizarParaNegativa(DtoCalifViolacion miDtoCV, List<DtoCalifViolacionLista> ListViolaciones)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_AgregarActualizarParaNegativa", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_violacion_id", SqlDbType.Int).Value = miDtoCV.calif_violacion_id;
                if (miDtoCV.dshgo_revision_id != -1)
                    con.ObjCommand.Parameters.Add("@dshgo_revision_id", SqlDbType.Int).Value = miDtoCV.dshgo_revision_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = miDtoCV.calificacion_id;
                con.ObjCommand.Parameters.Add("@cviol_numeral", SqlDbType.VarChar).Value = miDtoCV.cviol_numeral;
                con.ObjCommand.Parameters.Add("@cviol_violacion", SqlDbType.VarChar).Value = miDtoCV.cviol_violacion;
                con.ObjCommand.Parameters.Add("@cviol_procede", SqlDbType.Int).Value = miDtoCV.cviol_procede;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtoCV.sys_usr;

                if (ListViolaciones.Count > 0)
                {
                    DataTable dtlistado = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(Newtonsoft.Json.JsonConvert.SerializeObject(ListViolaciones));

                    con.ObjCommand.Parameters.Add("@listViolaciones", SqlDbType.Structured).Value = dtlistado;

                }


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void CalifViolacion_AgregarPorComprobacionMedidas(int origen_calificacion_id, List<DtoCalifViolacionLista> ListViolaciones)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_AgregarPorComprobacionMedidas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = origen_calificacion_id;
                if (ListViolaciones.Count > 0)
                {
                    DataTable dtlistado = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(Newtonsoft.Json.JsonConvert.SerializeObject(ListViolaciones));

                    con.ObjCommand.Parameters.Add("@listViolaciones", SqlDbType.Structured).Value = dtlistado;

                }

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void CalifViolacion_AgregarPorComprobacionMedidas_NP(int calificacion_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_AgregarPorComprobacionMedidas_NP", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;                
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int CalifRequisitoRespuesta_AgregarActualizar(DtoCalifRequisitoRespuesta dtoCRR)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifRequisitoRespuesta_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoCRR.calif_requisito_respuesta_id != -1)
                    con.ObjCommand.Parameters.Add("@calif_requisito_respuesta_id", SqlDbType.Int).Value = dtoCRR.calif_requisito_respuesta_id;
                if (dtoCRR.calificacion_id != -1)
                    con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = dtoCRR.calificacion_id;
                if (dtoCRR.calif_requisito_fondo_id != -1)
                    con.ObjCommand.Parameters.Add("@calif_requisito_fondo_id", SqlDbType.Int).Value = dtoCRR.calif_requisito_fondo_id;
                if (dtoCRR.creqresp_respuesta != -1)
                    con.ObjCommand.Parameters.Add("@creqresp_respuesta", SqlDbType.Int).Value = dtoCRR.creqresp_respuesta;

                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoCRR.sys_usr;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }


        //agregar las variables 
        public void CalifDoctoVariables_Agregar(DtoCalifDoctoVariables dtoVar)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDoctoVariables_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@CalifDocumentoID", SqlDbType.Int).Value = dtoVar.CalifDocumentoID;
                //con.ObjCommand.Parameters.Add("@Tipo_Documento", SqlDbType.Int).Value = DtoDoctoVariables.Tipo_Documento;

                if (dtoVar.Ur != "")
                    con.ObjCommand.Parameters.Add("@Ur", SqlDbType.VarChar).Value = dtoVar.Ur;
                if (dtoVar.No_Expediente != "")
                    con.ObjCommand.Parameters.Add("@No_Expediente", SqlDbType.VarChar).Value = dtoVar.No_Expediente;
                if (dtoVar.Subtipo_Actuacion != "")
                    con.ObjCommand.Parameters.Add("@Subtipo_Actuacion", SqlDbType.VarChar).Value = dtoVar.Subtipo_Actuacion;
                if (dtoVar.Materia != "")
                    con.ObjCommand.Parameters.Add("@Materia", SqlDbType.VarChar).Value = dtoVar.Materia;
                if (dtoVar.Cargo != "")
                    con.ObjCommand.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = dtoVar.Cargo;
                if (dtoVar.Firmante != "")
                    con.ObjCommand.Parameters.Add("@Firmante", SqlDbType.VarChar).Value = dtoVar.Firmante;
                if (dtoVar.Fecha_Documento != "")
                    con.ObjCommand.Parameters.Add("@Fecha_Documento", SqlDbType.VarChar).Value = dtoVar.Fecha_Documento;
                if (dtoVar.Telefonos != "")
                    con.ObjCommand.Parameters.Add("@Telefonos", SqlDbType.VarChar).Value = dtoVar.Telefonos;
                if (dtoVar.Domicilio != "")
                    con.ObjCommand.Parameters.Add("@Domicilio", SqlDbType.VarChar).Value = dtoVar.Domicilio;
                if (dtoVar.Empresa != "")
                    con.ObjCommand.Parameters.Add("@Empresa", SqlDbType.VarChar).Value = dtoVar.Empresa;
                if (dtoVar.Ncur != "")
                    con.ObjCommand.Parameters.Add("@Ncur", SqlDbType.VarChar).Value = dtoVar.Ncur;
                if (dtoVar.Ubicacion_Ur != "")
                    con.ObjCommand.Parameters.Add("@Ubicacion_Ur", SqlDbType.VarChar).Value = dtoVar.Ubicacion_Ur;
                if (dtoVar.Fecha_Inspeccion != "")
                    con.ObjCommand.Parameters.Add("@Fecha_Inspeccion", SqlDbType.VarChar).Value = dtoVar.Fecha_Inspeccion;
                if (dtoVar.Hora_inspeccion != "")
                    con.ObjCommand.Parameters.Add("@Hora_inspeccion", SqlDbType.VarChar).Value = dtoVar.Hora_inspeccion;
                if (dtoVar.Año != "")
                    con.ObjCommand.Parameters.Add("@Año", SqlDbType.VarChar).Value = dtoVar.Año;
                if (dtoVar.credencial != "")
                    con.ObjCommand.Parameters.Add("@Credencial", SqlDbType.VarChar).Value = dtoVar.credencial;
                //if (dtoVar.Notificador != "")
                //    con.ObjCommand.Parameters.Add("@Notificador", SqlDbType.VarChar).Value = dtoVar.Notificador;

                if (dtoVar.rama_constitucion != "")
                    con.ObjCommand.Parameters.Add("@rama_constitucion", SqlDbType.VarChar).Value = dtoVar.rama_constitucion;
                if (dtoVar.rama_lft != "")
                    con.ObjCommand.Parameters.Add("@rama_lft", SqlDbType.VarChar).Value = dtoVar.rama_lft;
                if (dtoVar.tins_tipo_542_lft != "")
                    con.ObjCommand.Parameters.Add("@tins_tipo_542_lft", SqlDbType.VarChar).Value = dtoVar.tins_tipo_542_lft;
                if (dtoVar.motivo_rgiasvll != "")
                    con.ObjCommand.Parameters.Add("@motivo_rgiasvll", SqlDbType.VarChar).Value = dtoVar.motivo_rgiasvll;
                if (dtoVar.fd_designacion_rgiasvll != "")
                    con.ObjCommand.Parameters.Add("@fd_designacion_rgiasvll", SqlDbType.VarChar).Value = dtoVar.fd_designacion_rgiasvll;
                if (dtoVar.circu_reglamento != "")
                    con.ObjCommand.Parameters.Add("@circu_reglamento", SqlDbType.VarChar).Value = dtoVar.circu_reglamento;
                if (dtoVar.circu_acuerdo != "")
                    con.ObjCommand.Parameters.Add("@circu_acuerdo", SqlDbType.VarChar).Value = dtoVar.circu_acuerdo;
                if (dtoVar.equipo != "")
                    con.ObjCommand.Parameters.Add("@equipo", SqlDbType.VarChar).Value = dtoVar.equipo;
                if (dtoVar.num_control != "")
                    con.ObjCommand.Parameters.Add("@num_control", SqlDbType.VarChar).Value = dtoVar.num_control;
                if (dtoVar.tipo_aviso != "")
                    con.ObjCommand.Parameters.Add("@tipo_aviso", SqlDbType.VarChar).Value = dtoVar.tipo_aviso;
                if (dtoVar.folio != "")
                    con.ObjCommand.Parameters.Add("@folio", SqlDbType.VarChar).Value = dtoVar.folio;
                if (dtoVar.medio_informacion != "")
                    con.ObjCommand.Parameters.Add("@medio_informacion", SqlDbType.VarChar).Value = dtoVar.medio_informacion;
                if (dtoVar.fec_autorizacion_provisional != "")
                    con.ObjCommand.Parameters.Add("@fec_autorizacion_provisional", SqlDbType.VarChar).Value = dtoVar.fec_autorizacion_provisional;
                if (dtoVar.pruebas != "")
                    con.ObjCommand.Parameters.Add("@pruebas", SqlDbType.VarChar).Value = dtoVar.pruebas;

                if (dtoVar.atribuciones_541_lft != "")
                    con.ObjCommand.Parameters.Add("@atribuciones_541_lft", SqlDbType.VarChar).Value = dtoVar.atribuciones_541_lft;
                if (dtoVar.atribuciones_art9_rgiasvll != "")
                    con.ObjCommand.Parameters.Add("@atribuciones_art9_rgiasvll", SqlDbType.VarChar).Value = dtoVar.atribuciones_art9_rgiasvll;
                if (dtoVar.asesoria_art10_rgiasvll != "")
                    con.ObjCommand.Parameters.Add("@asesoria_art10_rgiasvll", SqlDbType.VarChar).Value = dtoVar.asesoria_art10_rgiasvll;
                if (dtoVar.requisitos_rgiasvll != "")
                    con.ObjCommand.Parameters.Add("@requisitos_rgiasvll", SqlDbType.VarChar).Value = dtoVar.requisitos_rgiasvll;
                if (dtoVar.no_emplazamiento != "")
                    con.ObjCommand.Parameters.Add("@no_emplazamiento", SqlDbType.VarChar).Value = dtoVar.no_emplazamiento;
                if (dtoVar.fecha_emplazamiento != "")
                    con.ObjCommand.Parameters.Add("@fecha_emplazamiento", SqlDbType.VarChar).Value = dtoVar.fecha_emplazamiento;
                if (dtoVar.fecha_notif_emplazamiento != "")
                    con.ObjCommand.Parameters.Add("@fec_notif_emplazamiento", SqlDbType.VarChar).Value = dtoVar.fecha_notif_emplazamiento;
                if (dtoVar.acci_medio_informacion != "")
                    con.ObjCommand.Parameters.Add("@acci_medio_informacion", SqlDbType.VarChar).Value = dtoVar.acci_medio_informacion;
                if (dtoVar.inminente_peligro_medio_info != "")
                    con.ObjCommand.Parameters.Add("@inminente_peligro_medio_info", SqlDbType.VarChar).Value = dtoVar.inminente_peligro_medio_info;
                if (dtoVar.tipo_autorizacion != "")
                    con.ObjCommand.Parameters.Add("@tipo_autorizacion", SqlDbType.VarChar).Value = dtoVar.tipo_autorizacion;
                if (dtoVar.periodo_inicio != "")
                    con.ObjCommand.Parameters.Add("@periodo_inicio", SqlDbType.VarChar).Value = dtoVar.periodo_inicio;
                if (dtoVar.periodo_termino != "")
                    con.ObjCommand.Parameters.Add("@periodo_termino", SqlDbType.VarChar).Value = dtoVar.periodo_termino;
                if (dtoVar.empresa_que_se_visita != "")
                    con.ObjCommand.Parameters.Add("@empresa_que_se_visita", SqlDbType.VarChar).Value = dtoVar.empresa_que_se_visita;

                if (dtoVar.motivo_actuacion != "")
                    con.ObjCommand.Parameters.Add("@motivo_actuacion", SqlDbType.VarChar).Value = dtoVar.motivo_actuacion;
                if (dtoVar.dato_adicional_motivo != "")
                    con.ObjCommand.Parameters.Add("@dato_adicional_motivo", SqlDbType.VarChar).Value = dtoVar.dato_adicional_motivo;
                if (dtoVar.cdoc_num_documento != "")
                    con.ObjCommand.Parameters.Add("@no_aa", SqlDbType.VarChar).Value = dtoVar.cdoc_num_documento;
                if (dtoVar.rubrica != "")
                    con.ObjCommand.Parameters.Add("@rubrica", SqlDbType.VarChar).Value = dtoVar.rubrica;
                if (dtoVar.motivo_reprogramacion != "")
                    con.ObjCommand.Parameters.Add("@motivo_reprogramacion", SqlDbType.VarChar).Value = dtoVar.motivo_reprogramacion;
                if (dtoVar.fundamento_reprogramacion != "")
                    con.ObjCommand.Parameters.Add("@fundamento_reprogramacion", SqlDbType.VarChar).Value = dtoVar.fundamento_reprogramacion;
                if (dtoVar.no_expediente2 != "")
                    con.ObjCommand.Parameters.Add("@no_expediente2", SqlDbType.VarChar).Value = dtoVar.no_expediente2;
                if (dtoVar.fecha_acuse_comparecencia != "")
                    con.ObjCommand.Parameters.Add("@fecha_acuse_comparecencia", SqlDbType.VarChar).Value = dtoVar.fecha_acuse_comparecencia;
                if (dtoVar.hora_acuse_comparecencia != "")
                    con.ObjCommand.Parameters.Add("@hora_acuse_comparecencia", SqlDbType.VarChar).Value = dtoVar.hora_acuse_comparecencia;
                if (dtoVar.fojas_comparecencia != "")
                    con.ObjCommand.Parameters.Add("@fojas_comparecencia", SqlDbType.VarChar).Value = dtoVar.fojas_comparecencia;
                if (dtoVar.valoracion_pruebas != "")
                    con.ObjCommand.Parameters.Add("@valoracion_pruebas", SqlDbType.VarChar).Value = dtoVar.valoracion_pruebas;
                if (dtoVar.fecha_escrito_ampliacion != "")
                    con.ObjCommand.Parameters.Add("@fecha_escrito_ampliacion", SqlDbType.VarChar).Value = dtoVar.fecha_escrito_ampliacion;
                if (dtoVar.numerales_medidas != "")
                    con.ObjCommand.Parameters.Add("@numerales_medidas", SqlDbType.VarChar).Value = dtoVar.numerales_medidas;
                if (dtoVar.motivo_ampliacion != "")
                    con.ObjCommand.Parameters.Add("@motivo_ampliacion", SqlDbType.VarChar).Value = dtoVar.motivo_ampliacion;
                if (dtoVar.otorgar_negar_ampliación != "")
                    con.ObjCommand.Parameters.Add("@otorgar_negar_ampliación", SqlDbType.VarChar).Value = dtoVar.otorgar_negar_ampliación;
                if (dtoVar.responsable_juridico != "")
                    con.ObjCommand.Parameters.Add("@responsable_juridico", SqlDbType.VarChar).Value = dtoVar.responsable_juridico;
                if (dtoVar.area_juridica != "")
                    con.ObjCommand.Parameters.Add("@area_juridica", SqlDbType.VarChar).Value = dtoVar.area_juridica;
                if (dtoVar.cargo_responsable_juridico != "")
                    con.ObjCommand.Parameters.Add("@cargo_responsable_juridico", SqlDbType.VarChar).Value = dtoVar.cargo_responsable_juridico;
                if (dtoVar.comparecencia_dentro_fuera != "")
                    con.ObjCommand.Parameters.Add("@comparecencia_dentro_fuera", SqlDbType.VarChar).Value = dtoVar.comparecencia_dentro_fuera;
                if (dtoVar.circunscripcion_sipas != "")
                    con.ObjCommand.Parameters.Add("@circunscripcion_sipas", SqlDbType.VarChar).Value = dtoVar.circunscripcion_sipas;
                if (dtoVar.domicilio_ur != "")
                    con.ObjCommand.Parameters.Add("@domicilio_ur ", SqlDbType.VarChar).Value = dtoVar.domicilio_ur;
                if (dtoVar.inspectores != "")
                    con.ObjCommand.Parameters.Add("@nombres_inspectores ", SqlDbType.VarChar).Value = dtoVar.inspectores;
                if (dtoVar.LUGAR_INSPECCION != "")
                    con.ObjCommand.Parameters.Add("@lugar_inspeccion ", SqlDbType.VarChar).Value = dtoVar.LUGAR_INSPECCION;
                if (dtoVar.ENTIDAD_INSPECCION != "")
                    con.ObjCommand.Parameters.Add("@entidad_inspeccion ", SqlDbType.VarChar).Value = dtoVar.ENTIDAD_INSPECCION;
                if (dtoVar.fecha_documento_orde != "")
                    con.ObjCommand.Parameters.Add("@Fecha_Documento_orden", SqlDbType.VarChar).Value = dtoVar.fecha_documento_orde;
                if (dtoVar.nombre_comercial != "")
                    con.ObjCommand.Parameters.Add("@nombre_comercial", SqlDbType.VarChar).Value = dtoVar.nombre_comercial;
                if (dtoVar.comparece != "")
                    con.ObjCommand.Parameters.Add("@comparece", SqlDbType.VarChar).Value = dtoVar.comparece;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        //generar numero de documento
        public void GenerarNumeroDocumentoParaAmpliacion(int cve_ur, int anio, int documento_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_GenerarNumeroDocumentoParaAmpliacion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = documento_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        //GENERAR
        //generar numero de documento
        public DataSet GenerarNumeroDocumentoPorCalifDocumentoID(int cve_ur, int tipo_documento_id, int anio, int calif_documento_id, int normatividad_Id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_GenerarNumeroDocumentoPorCalifDocumentoID", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = tipo_documento_id;
                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = calif_documento_id;
                con.ObjCommand.Parameters.Add("@normatividad_Id", SqlDbType.Int).Value = normatividad_Id;


                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;

                //con.ObjCommand.Connection.Open();
                //con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Emplazamiento_AgregarActualizar(DtoEmplazamiento dtoEmp)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Emplazamiento_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = dtoEmp.emplazamiento_id;

                if (dtoEmp.inspeccion_origen_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = dtoEmp.inspeccion_origen_id;
                if (dtoEmp.inspeccion_comprobacion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_comprobacion_id", SqlDbType.Int).Value = dtoEmp.inspeccion_comprobacion_id;
                if (dtoEmp.em_num_emplazamiento != "")
                    con.ObjCommand.Parameters.Add("@em_num_emplazamiento", SqlDbType.VarChar).Value = dtoEmp.em_num_emplazamiento;
                if (dtoEmp.em_fec_notificacion != "")
                    con.ObjCommand.Parameters.Add("@em_fec_notificacion", SqlDbType.DateTime).Value = dtoEmp.em_fec_notificacion;
                if (dtoEmp.em_plazo_mayor != -1)
                    con.ObjCommand.Parameters.Add("@em_plazo_mayor", SqlDbType.Int).Value = dtoEmp.em_plazo_mayor;
                if (dtoEmp.em_atencion_inmediata != -1)
                    con.ObjCommand.Parameters.Add("@em_atencion_inmediata", SqlDbType.Int).Value = dtoEmp.em_atencion_inmediata;
                if (dtoEmp.em_fec_acuse_solicitud != "")
                    con.ObjCommand.Parameters.Add("@em_fec_acuse_solicitud", SqlDbType.DateTime).Value = dtoEmp.em_fec_acuse_solicitud;
                if (dtoEmp.em_motivo_solicitud != "")
                    con.ObjCommand.Parameters.Add("@em_motivo_solicitud", SqlDbType.VarChar).Value = dtoEmp.em_motivo_solicitud;
                if (dtoEmp.em_resolucion_ampliacion != -1)
                    con.ObjCommand.Parameters.Add("@em_resolucion_ampliacion", SqlDbType.Int).Value = dtoEmp.em_resolucion_ampliacion;
                if (dtoEmp.em_motivo_resolucion != "")
                    con.ObjCommand.Parameters.Add("@em_motivo_resolucion", SqlDbType.VarChar).Value = dtoEmp.em_motivo_resolucion;
                if (dtoEmp.em_fec_emplazamiento != "")
                    con.ObjCommand.Parameters.Add("@em_fec_emplazamiento", SqlDbType.DateTime).Value = dtoEmp.em_fec_emplazamiento;
                if (dtoEmp.em_estatus != -1)
                    con.ObjCommand.Parameters.Add("@em_estatus", SqlDbType.Int).Value = dtoEmp.em_estatus;
                if (dtoEmp.sys_usr != "")
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoEmp.sys_usr;
                if (dtoEmp.em_dias_otorgados != -1)
                    con.ObjCommand.Parameters.Add("@em_dias_otorgados", SqlDbType.Int).Value = dtoEmp.em_dias_otorgados;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }
        public void Emplazamiento_Actualizar_FechaLimite(int emplazamiento_id, string em_fecha_limite)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Emplazamiento_Actualizar_FechaLimite", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento_id;
                con.ObjCommand.Parameters.Add("@em_fecha_limite", SqlDbType.DateTime).Value = em_fecha_limite;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void Sancion_Actualizar_FechaLimite(int sancion_id, string san_fecha_limite)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Sancion_Actualizar_FechaLimite", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sancion_id", SqlDbType.Int).Value = sancion_id;
                con.ObjCommand.Parameters.Add("@san_fecha_limite", SqlDbType.DateTime).Value = san_fecha_limite;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public void EmplazamientoDocumental_AgregarActualizar(DtoEmplazamiento dtoEmp)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_EmplazamientoDocumental_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = dtoEmp.emplazamiento_id;

                if (dtoEmp.inspeccion_origen_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = dtoEmp.inspeccion_origen_id;
                if (dtoEmp.calificacion_comprobacion_id != -1)
                    con.ObjCommand.Parameters.Add("@calificacion_comprobacion_id", SqlDbType.Int).Value = dtoEmp.calificacion_comprobacion_id;
                if (dtoEmp.em_num_emplazamiento != "")
                    con.ObjCommand.Parameters.Add("@em_num_emplazamiento", SqlDbType.VarChar).Value = dtoEmp.em_num_emplazamiento;
                if (dtoEmp.em_fec_notificacion != "")
                    con.ObjCommand.Parameters.Add("@em_fec_notificacion", SqlDbType.DateTime).Value = dtoEmp.em_fec_notificacion;
                if (dtoEmp.em_plazo_mayor != -1)
                    con.ObjCommand.Parameters.Add("@em_plazo_mayor", SqlDbType.Int).Value = dtoEmp.em_plazo_mayor;
                if (dtoEmp.em_atencion_inmediata != -1)
                    con.ObjCommand.Parameters.Add("@em_atencion_inmediata", SqlDbType.Int).Value = dtoEmp.em_atencion_inmediata;
                if (dtoEmp.em_fec_acuse_solicitud != "")
                    con.ObjCommand.Parameters.Add("@em_fec_acuse_solicitud", SqlDbType.DateTime).Value = dtoEmp.em_fec_acuse_solicitud;
                if (dtoEmp.em_motivo_solicitud != "")
                    con.ObjCommand.Parameters.Add("@em_motivo_solicitud", SqlDbType.VarChar).Value = dtoEmp.em_motivo_solicitud;
                if (dtoEmp.em_resolucion_ampliacion != -1)
                    con.ObjCommand.Parameters.Add("@em_resolucion_ampliacion", SqlDbType.Int).Value = dtoEmp.em_resolucion_ampliacion;
                if (dtoEmp.em_motivo_resolucion != "")
                    con.ObjCommand.Parameters.Add("@em_motivo_resolucion", SqlDbType.VarChar).Value = dtoEmp.em_motivo_resolucion;
                if (dtoEmp.em_fec_emplazamiento != "")
                    con.ObjCommand.Parameters.Add("@em_fec_emplazamiento", SqlDbType.DateTime).Value = dtoEmp.em_fec_emplazamiento;
                if (dtoEmp.em_estatus != -1)
                    con.ObjCommand.Parameters.Add("@em_estatus", SqlDbType.Int).Value = dtoEmp.em_estatus;
                if (dtoEmp.sys_usr != "")
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoEmp.sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }
        public void Reprogramacion_AgregarActualizar(DtoReprogramacion dtoRep)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Reprogramacion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@reprogramacion_id", SqlDbType.Int).Value = dtoRep.reprogramacion_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = dtoRep.inspeccion_origen_id;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = dtoRep.inspeccion_id;
                con.ObjCommand.Parameters.Add("@rep_fec_envio_notificacion ", SqlDbType.DateTime).Value = dtoRep.rep_fec_envio_notificacion;
                con.ObjCommand.Parameters.Add("@sys_usr ", SqlDbType.VarChar).Value = dtoRep.sys_usr;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        public void Calificacion_ActualizarRevisionDocumental(int calificacion_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Calif_ActualizarRevisionDocumental", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        #endregion

        public void CentroMateria_Agregar(int inspeccion_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CentroMateria_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }


        #region PAS

        public int s_notif_resultado_AgregarActualizar(DtoSNotifResultado miDtos_notif_resultado)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_s_notif_resultado_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (miDtos_notif_resultado.s_notif_resultado_id != -1)
                    con.ObjCommand.Parameters.Add("@s_notif_resultado_id", SqlDbType.Int).Value = miDtos_notif_resultado.s_notif_resultado_id;
                if (miDtos_notif_resultado.s_expediente_etapa_id != -1)
                    con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = miDtos_notif_resultado.s_expediente_etapa_id;
                if (miDtos_notif_resultado.inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtos_notif_resultado.inspeccion_id;
                if (miDtos_notif_resultado.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtos_notif_resultado.inspector_id;
                if (miDtos_notif_resultado.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtos_notif_resultado.cve_ur;
                if (miDtos_notif_resultado.notif_motivo_no_entrega_id != -1)
                    con.ObjCommand.Parameters.Add("@notif_motivo_no_entrega_id", SqlDbType.SmallInt).Value = miDtos_notif_resultado.notif_motivo_no_entrega_id;
                if (miDtos_notif_resultado.notif_forma_constatacion_id != -1)
                    con.ObjCommand.Parameters.Add("@notif_forma_constatacion_id", SqlDbType.SmallInt).Value = miDtos_notif_resultado.notif_forma_constatacion_id;
                if (miDtos_notif_resultado.snotif_numero != "")
                    con.ObjCommand.Parameters.Add("@snotif_numero", SqlDbType.VarChar).Value = miDtos_notif_resultado.snotif_numero;
                if (miDtos_notif_resultado.snotif_estatus_asignacion != -1)
                    con.ObjCommand.Parameters.Add("@snotif_estatus_asignacion", SqlDbType.TinyInt).Value = miDtos_notif_resultado.snotif_estatus_asignacion;
                if (miDtos_notif_resultado.snotif_forma_entrega != -1)
                    con.ObjCommand.Parameters.Add("@snotif_forma_entrega", SqlDbType.TinyInt).Value = miDtos_notif_resultado.snotif_forma_entrega;
                if (miDtos_notif_resultado.snotif_forma_envio != "")
                    con.ObjCommand.Parameters.Add("@snotif_forma_envio", SqlDbType.VarChar).Value = miDtos_notif_resultado.snotif_forma_envio;
                if (miDtos_notif_resultado.snotif_fec_limite_entrega != "")
                    con.ObjCommand.Parameters.Add("@snotif_fec_limite_entrega", SqlDbType.DateTime).Value = miDtos_notif_resultado.snotif_fec_limite_entrega;
                if (miDtos_notif_resultado.snotif_hora_limite_recepcion != "")
                    con.ObjCommand.Parameters.Add("@snotif_hora_limite_recepcion", SqlDbType.Char).Value = miDtos_notif_resultado.snotif_hora_limite_recepcion;
                if (miDtos_notif_resultado.snotif_notificacion_personal != -1)
                    con.ObjCommand.Parameters.Add("@snotif_notificacion_personal", SqlDbType.TinyInt).Value = miDtos_notif_resultado.snotif_notificacion_personal;
                if (miDtos_notif_resultado.snotif_fec_envio != "")
                    con.ObjCommand.Parameters.Add("@snotif_fec_envio", SqlDbType.DateTime).Value = miDtos_notif_resultado.snotif_fec_envio;
                if (miDtos_notif_resultado.snotif_num_guia != "")
                    con.ObjCommand.Parameters.Add("@snotif_num_guia", SqlDbType.VarChar).Value = miDtos_notif_resultado.snotif_num_guia;
                if (miDtos_notif_resultado.snotif_fec_entrega_programada != "")
                    con.ObjCommand.Parameters.Add("@snotif_fec_entrega_programada", SqlDbType.DateTime).Value = miDtos_notif_resultado.snotif_fec_entrega_programada;
                if (miDtos_notif_resultado.snotif_estatus_entrega != -1)
                    con.ObjCommand.Parameters.Add("@snotif_estatus_entrega", SqlDbType.TinyInt).Value = miDtos_notif_resultado.snotif_estatus_entrega;
                if (miDtos_notif_resultado.snotif_se_recibio != -1)
                    con.ObjCommand.Parameters.Add("@snotif_se_recibio", SqlDbType.TinyInt).Value = miDtos_notif_resultado.snotif_se_recibio;
                if (miDtos_notif_resultado.snotif_quedo_pegado != -1)
                    con.ObjCommand.Parameters.Add("@snotif_quedo_pegado", SqlDbType.TinyInt).Value = miDtos_notif_resultado.snotif_quedo_pegado;
                if (miDtos_notif_resultado.snotif_otro_motivo != "")
                    con.ObjCommand.Parameters.Add("@snotif_otro_motivo", SqlDbType.VarChar).Value = miDtos_notif_resultado.snotif_otro_motivo;
                if (miDtos_notif_resultado.snotif_fec_entrega != "")
                    con.ObjCommand.Parameters.Add("@snotif_fec_entrega", SqlDbType.DateTime).Value = miDtos_notif_resultado.snotif_fec_entrega;
                if (miDtos_notif_resultado.snotif_nombre_recibio != "")
                    con.ObjCommand.Parameters.Add("@snotif_nombre_recibio", SqlDbType.VarChar).Value = miDtos_notif_resultado.snotif_nombre_recibio;
                if (miDtos_notif_resultado.snotif_dijo_ser != "")
                    con.ObjCommand.Parameters.Add("@snotif_dijo_ser", SqlDbType.VarChar).Value = miDtos_notif_resultado.snotif_dijo_ser;
                if (miDtos_notif_resultado.snotif_observaciones != "")
                    con.ObjCommand.Parameters.Add("@snotif_observaciones", SqlDbType.VarChar).Value = miDtos_notif_resultado.snotif_observaciones;
                if (miDtos_notif_resultado.sys_usr != "")
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtos_notif_resultado.sys_usr;
                if (miDtos_notif_resultado.snotif_hechos_constatados != "")
                    con.ObjCommand.Parameters.Add("@s_notif_hechos_constatados", SqlDbType.VarChar).Value = miDtos_notif_resultado.snotif_hechos_constatados;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        public int notif_sancionador_AgregarActualizar(DtoNotifSancionador miDtonotif_sancionador)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_notif_sancionador_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (miDtonotif_sancionador.notif_sancionador_id != -1)
                    con.ObjCommand.Parameters.Add("@notif_sancionador_id", SqlDbType.Int).Value = miDtonotif_sancionador.notif_sancionador_id;
                if (miDtonotif_sancionador.s_expediente_etapa_id != -1)
                    con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = miDtonotif_sancionador.s_expediente_etapa_id;
                if (miDtonotif_sancionador.inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtonotif_sancionador.inspeccion_id;
                if (miDtonotif_sancionador.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtonotif_sancionador.inspector_id;
                if (miDtonotif_sancionador.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtonotif_sancionador.cve_ur;
                if (miDtonotif_sancionador.notif_motivo_no_entrega_id != -1)
                    con.ObjCommand.Parameters.Add("@notif_motivo_no_entrega_id", SqlDbType.SmallInt).Value = miDtonotif_sancionador.notif_motivo_no_entrega_id;
                if (miDtonotif_sancionador.notif_forma_constatacion_id != -1)
                    con.ObjCommand.Parameters.Add("@notif_forma_constatacion_id", SqlDbType.SmallInt).Value = miDtonotif_sancionador.notif_forma_constatacion_id;
                if (miDtonotif_sancionador.notifs_estatus_asignacion != -1)
                    con.ObjCommand.Parameters.Add("@notifs_estatus_asignacion", SqlDbType.TinyInt).Value = miDtonotif_sancionador.notifs_estatus_asignacion;
                if (miDtonotif_sancionador.notifs_forma_entrega != -1)
                    con.ObjCommand.Parameters.Add("@notifs_forma_entrega", SqlDbType.TinyInt).Value = miDtonotif_sancionador.notifs_forma_entrega;
                if (miDtonotif_sancionador.notifs_forma_envio != "")
                    con.ObjCommand.Parameters.Add("@notifs_forma_envio", SqlDbType.VarChar).Value = miDtonotif_sancionador.notifs_forma_envio;
                if (miDtonotif_sancionador.notifs_fec_limite_entrega != "")
                    con.ObjCommand.Parameters.Add("@notifs_fec_limite_entrega", SqlDbType.DateTime).Value = miDtonotif_sancionador.notifs_fec_limite_entrega;
                if (miDtonotif_sancionador.notifs_hora_limite_recepcion != "")
                    con.ObjCommand.Parameters.Add("@notifs_hora_limite_recepcion", SqlDbType.Char).Value = miDtonotif_sancionador.notifs_hora_limite_recepcion;
                if (miDtonotif_sancionador.notifs_notificacion_personal != -1)
                    con.ObjCommand.Parameters.Add("@notifs_notificacion_personal", SqlDbType.TinyInt).Value = miDtonotif_sancionador.notifs_notificacion_personal;
                if (miDtonotif_sancionador.notifs_fec_envio != "")
                    con.ObjCommand.Parameters.Add("@notifs_fec_envio", SqlDbType.DateTime).Value = miDtonotif_sancionador.notifs_fec_envio;
                if (miDtonotif_sancionador.notifs_num_guia != "")
                    con.ObjCommand.Parameters.Add("@notifs_num_guia", SqlDbType.VarChar).Value = miDtonotif_sancionador.notifs_num_guia;
                if (miDtonotif_sancionador.notifs_fec_entrega_programada != "")
                    con.ObjCommand.Parameters.Add("@notifs_fec_entrega_programada", SqlDbType.DateTime).Value = miDtonotif_sancionador.notifs_fec_entrega_programada;
                if (miDtonotif_sancionador.notifs_estatus_entrega != -1)
                    con.ObjCommand.Parameters.Add("@notifs_estatus_entrega", SqlDbType.TinyInt).Value = miDtonotif_sancionador.notifs_estatus_entrega;
                if (miDtonotif_sancionador.notifs_se_recibio != -1)
                    con.ObjCommand.Parameters.Add("@notifs_se_recibio", SqlDbType.TinyInt).Value = miDtonotif_sancionador.notifs_se_recibio;
                if (miDtonotif_sancionador.notifs_quedo_pegado != -1)
                    con.ObjCommand.Parameters.Add("@notifs_quedo_pegado", SqlDbType.TinyInt).Value = miDtonotif_sancionador.notifs_quedo_pegado;
                if (miDtonotif_sancionador.notifs_otro_motivo != "")
                    con.ObjCommand.Parameters.Add("@notifs_otro_motivo", SqlDbType.VarChar).Value = miDtonotif_sancionador.notifs_otro_motivo;
                if (miDtonotif_sancionador.notifs_fec_entrega != "")
                    con.ObjCommand.Parameters.Add("@notifs_fec_entrega", SqlDbType.DateTime).Value = miDtonotif_sancionador.notifs_fec_entrega;
                if (miDtonotif_sancionador.notifs_nombre_recibio != "")
                    con.ObjCommand.Parameters.Add("@notifs_nombre_recibio", SqlDbType.VarChar).Value = miDtonotif_sancionador.notifs_nombre_recibio;
                if (miDtonotif_sancionador.notifs_dijo_ser != "")
                    con.ObjCommand.Parameters.Add("@notifs_dijo_ser", SqlDbType.VarChar).Value = miDtonotif_sancionador.notifs_dijo_ser;
                if (miDtonotif_sancionador.notifs_observaciones != "")
                    con.ObjCommand.Parameters.Add("@notifs_observaciones", SqlDbType.VarChar).Value = miDtonotif_sancionador.notifs_observaciones;
                if (miDtonotif_sancionador.notifs_hechos_constatados != "")
                    con.ObjCommand.Parameters.Add("@notifs_hechos_constatados", SqlDbType.VarChar).Value = miDtonotif_sancionador.notifs_hechos_constatados;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }


        public int s_notif_requerir_AgregarActualizar(DtoSNotifRequerir miDtos_notif_requerir)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_s_notif_requerir_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (miDtos_notif_requerir.s_notif_requerir_id != -1)
                    con.ObjCommand.Parameters.Add("@s_notif_requerir_id", SqlDbType.Int).Value = miDtos_notif_requerir.s_notif_requerir_id;
                if (miDtos_notif_requerir.s_notif_solicitud_id != -1)
                    con.ObjCommand.Parameters.Add("@s_notif_solicitud_id", SqlDbType.Int).Value = miDtos_notif_requerir.s_notif_solicitud_id;
                if (miDtos_notif_requerir.notificacion_sipas_id != -1)
                    con.ObjCommand.Parameters.Add("@notificacion_sipas_id", SqlDbType.Int).Value = miDtos_notif_requerir.notificacion_sipas_id;
                if (miDtos_notif_requerir.snr_estatus != -1)
                    con.ObjCommand.Parameters.Add("@snr_estatus", SqlDbType.TinyInt).Value = miDtos_notif_requerir.snr_estatus;
                if (miDtos_notif_requerir.sys_usr != "")
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = miDtos_notif_requerir.sys_usr;


                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();

                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public DataSet SObtener_Supervisor_por_CVUR(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SObtener_Supervisor_por_CVUR", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }


        #endregion

        public void semaforoActualiza(string strColor, double sblRMa, double sblRMi)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_actualizaSemaforo ", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@color", SqlDbType.VarChar).Value = strColor;
                con.ObjCommand.Parameters.Add("@rangoMi", SqlDbType.Decimal).Value = sblRMa;
                con.ObjCommand.Parameters.Add("@rangoMa", SqlDbType.Decimal).Value = sblRMi;
                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }

        }

        #region Conteo de inspeciones por materia

        public bool Insertar_conteo_inspecciones(DtoConteoInspecciones dtoConteoInspeciones)
        {
            SqlCommand cmd = new SqlCommand();
            bool respuesta = false;

            try
            {
                AgregarAbrirConexion();

                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DML_dshgo_conteo_inspecciones";
                cmd.Parameters.AddWithValue("@sentencia", "INSERT");
                cmd.Parameters.AddWithValue("@usuario_id", dtoConteoInspeciones.Usuario_id);
                cmd.Parameters.AddWithValue("@materia_acronimo", dtoConteoInspeciones.Materia_acronimo);
                cmd.Parameters.AddWithValue("@total", 1);

                cmd.ExecuteNonQuery();
                respuesta = true;

            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "Insertar_conteo_inspecciones";
                throw excepcion;
            }
            finally
            {
                AgregarCerrarConexion();
                cmd = null;
            }

            return respuesta;

        }

        public bool Actualizar_conteo_inspecciones(DtoConteoInspecciones dtoConteoInspeciones)
        {
            SqlCommand cmd = new SqlCommand();
            bool respuesta = false;

            try
            {
                AgregarAbrirConexion();

                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DML_dshgo_conteo_inspecciones";
                cmd.Parameters.AddWithValue("@sentencia", "UPDATE");
                cmd.Parameters.AddWithValue("@dshgo_conteo_inspecciones_id", dtoConteoInspeciones.Dshgo_conteo_inspecciones_id);
                cmd.Parameters.AddWithValue("@total", dtoConteoInspeciones.Total + 1);
                cmd.ExecuteNonQuery();
                respuesta = true;

            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "Actualizar_conteo_inspecciones";
                throw excepcion;
            }
            finally
            {
                AgregarCerrarConexion();
                cmd = null;
            }

            return respuesta;

        }


        #endregion

        /// <summario>
        /// Crea un nuevo usuario en la dase de datos
        /// </summario>
        /// <parametro nombre="DtoInfoMetadato">
        /// Objeto DtoInfoMetadato (Data transfer object de la tabla de informacion_metadatos)
        /// </parametro>
        public DataSet InformacionMetadatos(DtoInfoMetadato dtoInfoMetadato, string sentencia)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Documentos_Informacion_Metadatos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@metadato_id", SqlDbType.VarChar).Value = dtoInfoMetadato.metadato_id;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = dtoInfoMetadato.documento_id;
                con.ObjCommand.Parameters.Add("@tipo_metadato", SqlDbType.VarChar).Value = dtoInfoMetadato.tipo_metadato;
                con.ObjCommand.Parameters.Add("@valor", SqlDbType.VarChar).Value = dtoInfoMetadato.valor;
                con.ObjCommand.Parameters.Add("@documento_tabla", SqlDbType.VarChar).Value = dtoInfoMetadato.documento_tabla;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }
        /// <summario>
        /// Crea un nuevo usuario en la dase de datos
        /// </summario>
        /// <parametro nombre="DtoFirmaDigital">
        /// Objeto DtoFirmaDigital (Data transfer object de la tabla de documentos_firma_digital)
        /// </parametro>
        public DataSet DocumentosFirmaDigital(DtoFirmaDigital dtoFirmaDigital, string sentencia)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Documentos_Firma_Digital", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (dtoFirmaDigital.fd_document_id != -1)
                    con.ObjCommand.Parameters.Add("@fd_document_id", SqlDbType.Int).Value = dtoFirmaDigital.fd_document_id;
                if (dtoFirmaDigital.fd_pd_documento_id != -1)
                    con.ObjCommand.Parameters.Add("@fd_pd_documento_id", SqlDbType.Int).Value = dtoFirmaDigital.fd_pd_documento_id;
                if (dtoFirmaDigital.fd_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@fd_inspeccion_id", SqlDbType.Int).Value = dtoFirmaDigital.fd_inspeccion_id;
                if (dtoFirmaDigital.fd_referencia != "")
                    con.ObjCommand.Parameters.Add("@fd_referencia", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_referencia;
                if (dtoFirmaDigital.fd_referencia_id != -1)
                    con.ObjCommand.Parameters.Add("@fd_referencia_id", SqlDbType.Int).Value = dtoFirmaDigital.fd_referencia_id;
                if (dtoFirmaDigital.fd_tipo_documento_id != -1)
                    con.ObjCommand.Parameters.Add("@fd_tipo_documento_id", SqlDbType.Int).Value = dtoFirmaDigital.fd_tipo_documento_id;
                if (dtoFirmaDigital.fd_nombre_firmante != "")
                    con.ObjCommand.Parameters.Add("@fd_nombre_firmante", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_nombre_firmante;
                if (dtoFirmaDigital.fd_cargo_firmante != "")
                    con.ObjCommand.Parameters.Add("@fd_cargo_firmante", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_cargo_firmante;
                if (dtoFirmaDigital.fd_rfc_emisor != "")
                    con.ObjCommand.Parameters.Add("@fd_rfc_emisor", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_rfc_emisor;
                if (dtoFirmaDigital.fd_cadena_original != "")
                    con.ObjCommand.Parameters.Add("@fd_cadena_original", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_cadena_original;
                if (dtoFirmaDigital.fd_cadena_original_hash != "")
                    con.ObjCommand.Parameters.Add("@fd_cadena_original_hash", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_cadena_original_hash;
                if (dtoFirmaDigital.fd_codigo_verificador != "")
                    con.ObjCommand.Parameters.Add("@fd_codigo_verificador", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_codigo_verificador;
                if (dtoFirmaDigital.fd_certificado_emisor != "")
                    con.ObjCommand.Parameters.Add("@fd_certificado_emisor", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_certificado_emisor;
                if (dtoFirmaDigital.fd_estatus != "")
                    con.ObjCommand.Parameters.Add("@fd_estatus", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_estatus;
                if (dtoFirmaDigital.fd_ruta != "")
                    con.ObjCommand.Parameters.Add("@fd_ruta", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_ruta;
                if (dtoFirmaDigital.fd_sello != "")
                    con.ObjCommand.Parameters.Add("@fd_sello", SqlDbType.VarChar).Value = dtoFirmaDigital.fd_sello;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        /// <summario>
        /// Crea un nuevo registro de documentos pro firmar
        /// </summario>
        /// <parametro nombre="DtoFirmantesDoc">
        /// Objeto DtoFirmantesDoc (Data transfer object de la tabla de firmantes_documentos)
        /// </parametro>
        public DataSet DocumentosFirmantesBandeja(DtoFirmantesDoc dtoFirmantesDoc, string sentencia)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Bandeja_Firmantes_Documentos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                if (dtoFirmantesDoc.fd_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@fd_inspeccion_id", SqlDbType.Int).Value = dtoFirmantesDoc.fd_inspeccion_id;
                if (dtoFirmantesDoc.fd_desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@fd_desahogo_id", SqlDbType.Int).Value = dtoFirmantesDoc.fd_desahogo_id;
                if (dtoFirmantesDoc.fd_calificacion_id != -1)
                    con.ObjCommand.Parameters.Add("@fd_calificacion_id", SqlDbType.Int).Value = dtoFirmantesDoc.fd_calificacion_id;
                if (dtoFirmantesDoc.fd_proceso != "")
                    con.ObjCommand.Parameters.Add("@fd_proceso", SqlDbType.VarChar).Value = dtoFirmantesDoc.fd_proceso;
                if (dtoFirmantesDoc.fd_estatus != -1)
                    con.ObjCommand.Parameters.Add("@fd_estatus", SqlDbType.Int).Value = dtoFirmantesDoc.fd_estatus;
                if (dtoFirmantesDoc.fd_fecha_firma != "")
                    con.ObjCommand.Parameters.Add("@fd_fecha_firma", SqlDbType.DateTime).Value = dtoFirmantesDoc.fd_fecha_firma;
                if (dtoFirmantesDoc.fd_total_documentos != -1)
                    con.ObjCommand.Parameters.Add("@fd_total_documentos", SqlDbType.Int).Value = dtoFirmantesDoc.fd_total_documentos;
                if (dtoFirmantesDoc.fd_total_firmados != -1)
                    con.ObjCommand.Parameters.Add("@fd_total_firmados", SqlDbType.Int).Value = dtoFirmantesDoc.fd_total_firmados;
                if (dtoFirmantesDoc.fd_participante_id != -1)
                    con.ObjCommand.Parameters.Add("@fd_participante_id", SqlDbType.Int).Value = dtoFirmantesDoc.fd_participante_id;
                if (dtoFirmantesDoc.firmantes_documentos_id > 0)
                    con.ObjCommand.Parameters.Add("@firmantes_documentos_id", SqlDbType.Int).Value = dtoFirmantesDoc.firmantes_documentos_id;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

        public int Dashboard_Agregar(string sentencia, string filtro, string periodo, DateTime inicio, DateTime final, string estatus, int core_id, string doc_url, int notificacion, string tipo_documento, string cur_cve_ur)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dashboard_Historico_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                con.ObjCommand.Parameters.Add("@filtro", SqlDbType.VarChar).Value = filtro;
                con.ObjCommand.Parameters.Add("@periodo", SqlDbType.VarChar).Value = periodo;
                con.ObjCommand.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = inicio;
                con.ObjCommand.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = final;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.VarChar).Value = estatus;
                con.ObjCommand.Parameters.Add("@core_id", SqlDbType.Int).Value = core_id;
                con.ObjCommand.Parameters.Add("@doc_url", SqlDbType.VarChar).Value = doc_url;
                con.ObjCommand.Parameters.Add("@notificacion", SqlDbType.Int).Value = notificacion;
                con.ObjCommand.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = tipo_documento;
                con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.VarChar).Value = cur_cve_ur;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        public int AgregarIncumplimientosAcuerdoCierreResolucion(DtoSancionViolacion dtoSancVio)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_AgregarIncumplimientosAcuerdoCierreResolucionSIPAS", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = "INSERT";
                if (dtoSancVio.expediente_juridico != "")
                    con.ObjCommand.Parameters.Add("@expediente_juridico", SqlDbType.VarChar).Value = dtoSancVio.expediente_juridico;
                if (dtoSancVio.inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("inspeccion_id", SqlDbType.Int).Value = dtoSancVio.inspeccion_id;
                if (dtoSancVio.dshgo_revision_id != -1)
                    con.ObjCommand.Parameters.Add("dshgo_revision_id", SqlDbType.Int).Value = dtoSancVio.dshgo_revision_id;
                if (dtoSancVio.calificacion_id != -1)
                    con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = dtoSancVio.calificacion_id;
                if (dtoSancVio.indicador_id != -1)
                    con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = dtoSancVio.indicador_id;
                if (dtoSancVio.submateria_id != -1)
                    con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = dtoSancVio.submateria_id;
                if (dtoSancVio.cviol_numeral != "")
                    con.ObjCommand.Parameters.Add("@cviol_numeral", SqlDbType.VarChar).Value = dtoSancVio.cviol_numeral;
                if (dtoSancVio.cviol_violacion != "")
                    con.ObjCommand.Parameters.Add("@cviol_violacion", SqlDbType.VarChar).Value = dtoSancVio.cviol_violacion;
                if (dtoSancVio.cviol_procede != -1)
                    con.ObjCommand.Parameters.Add("@cviol_procede", SqlDbType.Int).Value = dtoSancVio.cviol_procede;
                if (dtoSancVio.sys_usr_insert != "")
                    con.ObjCommand.Parameters.Add("@sys_usr_insert", SqlDbType.VarChar).Value = dtoSancVio.sys_usr_insert;
                if (dtoSancVio.num_solicitud != "")
                    con.ObjCommand.Parameters.Add("@num_solicitud", SqlDbType.VarChar).Value = dtoSancVio.num_solicitud;
                if (dtoSancVio.tipo_incumplimiento != -1)
                    con.ObjCommand.Parameters.Add("@tipo_incumplimiento", SqlDbType.Int).Value = dtoSancVio.tipo_incumplimiento;
                if (dtoSancVio.cviol_fundamento != "")
                    con.ObjCommand.Parameters.Add("@cviol_fundamento", SqlDbType.VarChar).Value = dtoSancVio.cviol_fundamento;
                if (dtoSancVio.cviol_descripcion != "")
                    con.ObjCommand.Parameters.Add("@cviol_descripcion", SqlDbType.VarChar).Value = dtoSancVio.cviol_descripcion;
                if (dtoSancVio.origen != "")
                    con.ObjCommand.Parameters.Add("@origen", SqlDbType.VarChar).Value = dtoSancVio.origen;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);


                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();


                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        public DataSet ObtenerIncumplimientosParaSancion(int inspeccion_origen_id, string sentencia)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtenerIncumplimientosParaSancion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (inspeccion_origen_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;
                if (sentencia != "")
                    con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.Int).Value = sentencia;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        public int Sancion_AgregarActualizar(DtoSancion dtoSancion)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Sancion_AgregarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sancion_id", SqlDbType.Int).Value = dtoSancion.sancion_id;

                if (dtoSancion.inspeccion_origen_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = dtoSancion.inspeccion_origen_id;
                if (dtoSancion.inspeccion_sancion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_sancion_id", SqlDbType.Int).Value = dtoSancion.inspeccion_sancion_id;
                if (dtoSancion.san_num_sancion != "")
                    con.ObjCommand.Parameters.Add("@san_num_sancion", SqlDbType.VarChar).Value = dtoSancion.san_num_sancion;
                if (dtoSancion.san_fec_notificacion != "")
                    con.ObjCommand.Parameters.Add("@san_fec_notificacion", SqlDbType.DateTime).Value = dtoSancion.san_fec_notificacion;
                if (dtoSancion.san_plazo_mayor != -1)
                    con.ObjCommand.Parameters.Add("@san_plazo_mayor", SqlDbType.Int).Value = dtoSancion.san_plazo_mayor;
                if (dtoSancion.san_atencion_inmediata != -1)
                    con.ObjCommand.Parameters.Add("@san_atencion_inmediata", SqlDbType.Int).Value = dtoSancion.san_atencion_inmediata;
                if (dtoSancion.san_fec_acuse_solicitud != "")
                    con.ObjCommand.Parameters.Add("@san_fec_acuse_solicitud", SqlDbType.DateTime).Value = dtoSancion.san_fec_acuse_solicitud;
                if (dtoSancion.san_motivo_solicitud != "")
                    con.ObjCommand.Parameters.Add("@san_motivo_solicitud", SqlDbType.VarChar).Value = dtoSancion.san_motivo_solicitud;
                if (dtoSancion.san_resolucion_ampliacion != -1)
                    con.ObjCommand.Parameters.Add("@san_resolucion_ampliacion", SqlDbType.Int).Value = dtoSancion.san_resolucion_ampliacion;
                if (dtoSancion.san_motivo_resolucion != "")
                    con.ObjCommand.Parameters.Add("@san_motivo_resolucion", SqlDbType.VarChar).Value = dtoSancion.san_motivo_resolucion;
                if (dtoSancion.san_fec_sancion != "")
                    con.ObjCommand.Parameters.Add("@san_fec_emplazamiento", SqlDbType.DateTime).Value = dtoSancion.san_fec_sancion;
                if (dtoSancion.san_estatus != -1)
                    con.ObjCommand.Parameters.Add("@san_estatus", SqlDbType.Int).Value = dtoSancion.san_estatus;
                if (dtoSancion.sys_usr != "")
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = dtoSancion.sys_usr;
                if (dtoSancion.san_dias_otorgados != -1)
                    con.ObjCommand.Parameters.Add("@san_dias_otorgados", SqlDbType.Int).Value = dtoSancion.san_dias_otorgados;
                if (dtoSancion.num_sanciones != -1)
                    con.ObjCommand.Parameters.Add("@num_sanciones", SqlDbType.Int).Value = dtoSancion.num_sanciones;
                if (dtoSancion.num_expediente_juridico != "")
                    con.ObjCommand.Parameters.Add("@num_expediente_juridico", SqlDbType.VarChar).Value = dtoSancion.num_expediente_juridico;
                if (dtoSancion.tipo_resolucion != -1)
                    con.ObjCommand.Parameters.Add("@tipo_resolucion", SqlDbType.Int).Value = dtoSancion.tipo_resolucion;
                if (dtoSancion.sentido_resolucion != -1)
                    con.ObjCommand.Parameters.Add("@sentido_resolucion", SqlDbType.Int).Value = dtoSancion.sentido_resolucion;
                con.ObjCommand.Parameters.Add("@fecha_resolucion", SqlDbType.DateTime).Value = dtoSancion.fecha_resolucion;

                SqlParameter vReturn = new SqlParameter("RETURN_VALUE", SqlDbType.Int);
                vReturn.Direction = ParameterDirection.ReturnValue;
                con.ObjCommand.Parameters.Add(vReturn);

                con.ObjCommand.Connection.Open();
                con.ObjCommand.ExecuteNonQuery();
                return (int)vReturn.Value;
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();

            }
        }

    }
}