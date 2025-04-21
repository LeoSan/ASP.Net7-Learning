using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CompInspeccion.DtoS;
using System.Text.RegularExpressions;

namespace CompInspeccion
{
    class Consultas
    {
        internal SqlConnection conexion;

        public void AbrirConexion()
        {
            conexion = new SqlConnection(Constantes.StrCon);
            conexion.Open();
        }

        public void CerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
        }

        #region Seguimiento Inspecciones

        public DataSet ObtenerInspeccionesDetalle(int tipoDetalle, int tipoPeriodo, int filtro, DateTime fechaActual, int cve_edo, int cve_ur, int inspector_id)
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Seguimiento_DetalleInspecciones", con.ObjConnection);
            SQLConnectionManager.ConfiguraTimeOut(con.ObjCommand);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Parameters.Add("@tipoDetalle", SqlDbType.Int).Value = tipoDetalle;
            con.ObjCommand.Parameters.Add("@tipoPeriodo", SqlDbType.Int).Value = tipoPeriodo;
            con.ObjCommand.Parameters.Add("@filtro", SqlDbType.Int).Value = filtro;
            con.ObjCommand.Parameters.Add("@fechaActual", SqlDbType.DateTime).Value = fechaActual;
            con.ObjCommand.Parameters.Add("@cve_edo", SqlDbType.Int).Value = cve_edo;
            con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
            con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;


            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();

            return objDataSet;
        }


        public DataSet ObtenerInspeccionesPorMateria(int cve_ur, int cve_edorep, int participante_id, DateTime? fechaActual)
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Seguimiento_InspeccionesPorMateria", con.ObjConnection);
            SQLConnectionManager.ConfiguraTimeOut(con.ObjCommand);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
            con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = cve_edorep;
            con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;
            con.ObjCommand.Parameters.Add("@fechaActual", SqlDbType.DateTime).Value = fechaActual;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();

            return objDataSet;
        }

        public DataSet ObtenerInspeccionesPorOperativo(int cve_ur, int cve_edorep, int participante_id, DateTime? fechaActual)
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Seguimiento_InspeccionesPorOperativo", con.ObjConnection);
            SQLConnectionManager.ConfiguraTimeOut(con.ObjCommand);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
            con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = cve_edorep;
            con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;
            con.ObjCommand.Parameters.Add("@fechaActual", SqlDbType.DateTime).Value = fechaActual;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();

            return objDataSet;
        }

        public DataSet ObtenerInspeccionesPorResultado(int cve_ur, int cve_edorep, int participante_id, DateTime? fechaActual)
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Seguimiento_InspeccionesPorResultado", con.ObjConnection);
            SQLConnectionManager.ConfiguraTimeOut(con.ObjCommand);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
            con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = cve_edorep;
            con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;
            con.ObjCommand.Parameters.Add("@fechaActual", SqlDbType.DateTime).Value = fechaActual;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();

            return objDataSet;
        }


        #region Promedios Utilizados para los Semaforos

        public DataSet ObtenerSemaforo()
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_SemaforoSeguimiento_Obtener", con.ObjConnection);
            SQLConnectionManager.ConfiguraTimeOut(con.ObjCommand);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();

            return objDataSet;
        }

        public DataSet ObtenerInspeccionesPorPromedioNacional(int cve_edo, DateTime? fechaActual)
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Seguimiento_InspeccionesPorPromedioNacional", con.ObjConnection);
            SQLConnectionManager.ConfiguraTimeOut(con.ObjCommand);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Parameters.Add("@cve_edo", SqlDbType.Int).Value = cve_edo;
            con.ObjCommand.Parameters.Add("@fechaActual", SqlDbType.DateTime).Value = fechaActual;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();

            return objDataSet;
        }

        public DataSet ObtenerInspeccionesPorPromedioEstatal(int cve_edo, int cve_ur, DateTime? fechaActual)
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Seguimiento_InspeccionesPorPromedioEstatal", con.ObjConnection);
            SQLConnectionManager.ConfiguraTimeOut(con.ObjCommand);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Parameters.Add("@cve_edo", SqlDbType.Int).Value = cve_edo;
            con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
            con.ObjCommand.Parameters.Add("@fechaActual", SqlDbType.DateTime).Value = fechaActual;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();

            return objDataSet;
        }
        public DataSet ObtenerEstadosPorAbreviacion(string edo)
        {

            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Estados_ObtenerPorAbreviacion", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;
            con.ObjCommand.Parameters.Add("@cen_abreviacion", SqlDbType.VarChar).Value = edo;
            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();


            return objDataSet;
        }
        #endregion

        public DataSet obtenrSemaforo()
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtieneSemaforo", con.ObjConnection);
                SQLConnectionManager.ConfiguraTimeOut(con.ObjCommand);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");
            }

            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }

            return objDataSet;

        }
        public DataSet obtenResolucionesInspeccion(int cve_ur, int cve_edorep, int in_anio, DateTime? fechaActual)
        {

            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Seguimiento_Resoluciones", con.ObjConnection);
                SQLConnectionManager.ConfiguraTimeOut(con.ObjCommand);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = cve_edorep;
                con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = in_anio;
                con.ObjCommand.Parameters.Add("@fechaActual", SqlDbType.DateTime).Value = fechaActual;



                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");
            }

            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }

            return objDataSet;
        }
        public DataSet obtenInspectorGen(string inspCriterio, string strEdo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspector_ObtenerGene", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@insp_criterio", SqlDbType.VarChar).Value = inspCriterio;
                con.ObjCommand.Parameters.Add("@cveEdo", SqlDbType.VarChar).Value = strEdo;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");
            }

            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }

            return objDataSet;
        }

        public DataSet Inspector_Tablero_Obtener(int cve_ur = -1, int cve_cve_edorep = -1, int inspector_id = -1, string insp_num_credencial = "")
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Inspector_Tablero", con.ObjConnection);
            SQLConnectionManager.ConfiguraTimeOut(con.ObjCommand);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
            con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = cve_cve_edorep;
            con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;
            con.ObjCommand.Parameters.Add("@insp_num_credencial", SqlDbType.VarChar).Value = insp_num_credencial;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();

            return objDataSet;
        }
        #endregion

        #region Inspeccion

        public DataSet ObtenerPerfiles()
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Perfil_Obtener", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;
            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();

            return objDataSet;
        }
        /// <summary>
        ///     OBTENER UN USUARIO - considerar cualquier cambio en SIPAS se utiliza el mismo PA en el Login
        /// </summary>
        public DataSet Usuario_Obtener(int usuario_id, String usr_login, String usr_email, String usr_estatus = "Ninguno", int perfil_id = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Usuario_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuario_id;
                con.ObjCommand.Parameters.Add("@usr_login", SqlDbType.VarChar).Value = usr_login;
                con.ObjCommand.Parameters.Add("@usr_email", SqlDbType.VarChar).Value = usr_email;
                con.ObjCommand.Parameters.Add("@usr_estatus", SqlDbType.VarChar).Value = usr_estatus;
                con.ObjCommand.Parameters.Add("@perfil_id", SqlDbType.Int).Value = perfil_id;

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

        public DataSet SUsuario_Obtener(int usuario_id, String usr_login, String usr_email, String usr_estatus = "Ninguno")
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Susuario_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_usuario_id", SqlDbType.Int).Value = usuario_id;
                con.ObjCommand.Parameters.Add("@susr_login", SqlDbType.VarChar).Value = usr_login;
                con.ObjCommand.Parameters.Add("@susr_email", SqlDbType.VarChar).Value = usr_email;
                con.ObjCommand.Parameters.Add("@usr_estatus", SqlDbType.VarChar).Value = usr_estatus;

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
        public bool Usuario_Actualizar_CoreUsuarioId(int core_usuario_id, String usr_email)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Usuario_ActualizarCoreUsuarioId", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@core_usuario_id", SqlDbType.Int).Value = core_usuario_id;
                con.ObjCommand.Parameters.Add("@usr_email", SqlDbType.VarChar).Value = usr_email;

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

        public DataSet SUsuario_ObtenerUsuariosPorIdPerfil(int perfil_id, int cve_ur = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SUsuario_ObtenerUsuariosPorIdPerfil", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@s_perfil_id", SqlDbType.Int).Value = perfil_id;
                if (cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
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

        public DataSet Usuario_ObtenerPorEdoUr(int usuario_id, int ur, int edo, string txt_search)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Usuario_ObtenerPorEdoUR", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuario_id;
                con.ObjCommand.Parameters.Add("@usr_ur", SqlDbType.Int).Value = ur;
                con.ObjCommand.Parameters.Add("@usr_edorep", SqlDbType.Int).Value = edo;
                con.ObjCommand.Parameters.Add("@txt_search", SqlDbType.Text).Value = txt_search;

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

        public DataSet DoctoParrafo_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafo_Obtener ", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.dp_tipo_documento_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@dp_variable", SqlDbType.VarChar).Value = dtoDocto.dp_variable;
                con.ObjCommand.Parameters.Add("@dp_tipo_parrafo ", SqlDbType.Int).Value = dtoDocto.dp_tipo_parrafo;

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

        public DataSet SDoctoParrafo_Obtener(DtoDoctoBusquedaSipas dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDt = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SDoctoParrafo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_tipo_documento_id", SqlDbType.Int).Value = dtoDocto.s_tipo_documento_id;
                con.ObjCommand.Parameters.Add("@s_docto_parrafo_id", SqlDbType.Int).Value = dtoDocto.s_docto_parrafo_id;
                con.ObjCommand.Parameters.Add("@sdp_variable", SqlDbType.VarChar).Value = dtoDocto.sdp_variable;
                con.ObjCommand.Parameters.Add("@sdp_tipo_parrafo", SqlDbType.Int).Value = dtoDocto.sdp_tipo_parrafo;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDt, "resultado");

                return objDt;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public DataSet DoctoParrafoTexto_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoTexto_Obtener", con.ObjConnection);
                con.ObjCommand.CommandTimeout = 420;
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.dp_tipo_documento_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@dp_variable", SqlDbType.VarChar).Value = dtoDocto.dp_variable;

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


        public DataSet DoctoParrafoTexto_Obtener2(DtoDoctoBusqueda dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoTexto_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.dp_tipo_documento_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@dp_variable", SqlDbType.VarChar).Value = dtoDocto.dp_variable;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.VarChar).Value = dtoDocto.cve_ur;
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


        public DataSet SDoctoParrafoTexto_Obtener(int s_docto_parrafo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SDoctoParrafoTexto_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_docto_parrafo_id", SqlDbType.Int).Value = s_docto_parrafo_id;

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


        public DataSet DoctoVariableValores_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoVariableValores_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@docto_valor_id", SqlDbType.Int).Value = dtoDocto.docto_valor_id;
                con.ObjCommand.Parameters.Add("@docto_variable_id", SqlDbType.Int).Value = dtoDocto.docto_variable_id;
                con.ObjCommand.Parameters.Add("@var_tipo_variable", SqlDbType.Int).Value = dtoDocto.var_tipo_variable;
                con.ObjCommand.Parameters.Add("@var_variable", SqlDbType.VarChar).Value = dtoDocto.var_variable;
                con.ObjCommand.Parameters.Add("@var_proceso", SqlDbType.Int).Value = dtoDocto.td_proceso;
                con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dtoDocto.dshgo_documento_id;

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


        public DataSet DoctoVariableValores_Obtener2(DtoDoctoBusqueda dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoVariableValores_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@docto_valor_id", SqlDbType.Int).Value = dtoDocto.docto_valor_id;
                con.ObjCommand.Parameters.Add("@docto_variable_id", SqlDbType.Int).Value = dtoDocto.docto_variable_id;
                con.ObjCommand.Parameters.Add("@var_tipo_variable", SqlDbType.Int).Value = dtoDocto.var_tipo_variable;
                con.ObjCommand.Parameters.Add("@var_variable", SqlDbType.VarChar).Value = dtoDocto.var_variable;
                con.ObjCommand.Parameters.Add("@var_proceso", SqlDbType.Int).Value = dtoDocto.td_proceso;
                con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dtoDocto.dshgo_documento_id;

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


        public DataSet Documento_Obtener(DtoDocumento dtoDocto, string sentencia = "SELECT")
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Documento_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@inspeccion_id ", SqlDbType.Int).Value = dtoDocto.inspeccion_id;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = dtoDocto.inspector_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.tipo_documento_id;
                con.ObjCommand.Parameters.Add("@td_requiere_notificacion", SqlDbType.Int).Value = dtoDocto.aplica_notificacion;
                con.ObjCommand.Parameters.Add("@etapa", SqlDbType.Int).Value = dtoDocto.etapa;

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

        public DataSet Tipo_Documento_Obtener(DtoTipoDocumento dtoTipo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TipoDocumento_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoTipo.tipo_documento_id;
                con.ObjCommand.Parameters.Add("@td_aplica_aleatoria", SqlDbType.Int).Value = dtoTipo.td_aplica_aleatoria;
                con.ObjCommand.Parameters.Add("@td_aplica_automatica ", SqlDbType.Int).Value = dtoTipo.td_aplica_automatica;
                con.ObjCommand.Parameters.Add("@td_aplica_directa", SqlDbType.Int).Value = dtoTipo.td_aplica_directa;
                con.ObjCommand.Parameters.Add("@td_requiere_notificacion", SqlDbType.Int).Value = dtoTipo.td_requiere_notificacion;
                con.ObjCommand.Parameters.Add("@etapa", SqlDbType.Int).Value = dtoTipo.etapa;
                con.ObjCommand.Parameters.Add("@sub_etapa", SqlDbType.Int).Value = dtoTipo.sub_etapa;
                con.ObjCommand.Parameters.Add("@td_controlada_sistema", SqlDbType.Int).Value = dtoTipo.td_controlada_sistema;
                con.ObjCommand.Parameters.Add("@td_activo", SqlDbType.Int).Value = dtoTipo.td_activo;

                if (dtoTipo.code != "")
                    con.ObjCommand.Parameters.Add("@code", SqlDbType.VarChar).Value = dtoTipo.code;

                if (dtoTipo.mat_normativa_version_id != -1)
                    con.ObjCommand.Parameters.Add("@mat_normativa_version_id", SqlDbType.Int).Value = dtoTipo.mat_normativa_version_id;

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

        public DataSet STipoDocumento_Obtener(int tipo, int normativa_id = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_STipoDocumento_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_tipo_documento_id", SqlDbType.Int).Value = tipo;

                if (normativa_id != -1)
                    con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = normativa_id;


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

        public DataSet Parrafo_BuscarActualizar(string sentencia, int mat_normativa_version_id, string buscar_parrafo, int docto_parrafo_texto_id, string dpt_parrafo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Parrafo_BuscarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                con.ObjCommand.Parameters.Add("@mat_normativa_version_id", SqlDbType.Int).Value = mat_normativa_version_id;
                con.ObjCommand.Parameters.Add("@buscar_parrafo", SqlDbType.VarChar).Value = buscar_parrafo;
                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@dpt_parrafo", SqlDbType.VarChar).Value = dpt_parrafo;

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

        public DataSet Tipo_Documento_Inspeccion(DtoTipoDocumentoInspeccion dtoTipo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Documentos_Plantilla_Inspeccion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = dtoTipo.sentencia;
                con.ObjCommand.Parameters.Add("@pd_documento_id", SqlDbType.Int).Value = dtoTipo.pd_documento_id;
                con.ObjCommand.Parameters.Add("@pd_plantilla_html", SqlDbType.VarChar).Value = dtoTipo.pd_plantilla_html;
                con.ObjCommand.Parameters.Add("@pd_inspeccion_id ", SqlDbType.Int).Value = dtoTipo.pd_inspeccion_id;
                con.ObjCommand.Parameters.Add("@pd_tipo_documento_id", SqlDbType.Int).Value = dtoTipo.pd_tipo_documento_id;
                con.ObjCommand.Parameters.Add("@pd_confirmacion", SqlDbType.Int).Value = dtoTipo.pd_confirmacion;
                con.ObjCommand.Parameters.Add("@orientacion_documento", SqlDbType.VarChar).Value = dtoTipo.orientacion_documento;
                con.ObjCommand.Parameters.Add("@pd_plantilla_editada", SqlDbType.VarChar).Value = dtoTipo.pd_plantilla_editada;

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

        public DataSet Tipo_DocumentoOtro_Obtener(DtoTipoDocumento dtoTipo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TipoDocumentoOtro_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoTipo.tipo_documento_id;
                con.ObjCommand.Parameters.Add("@td_aplica_aleatoria", SqlDbType.Int).Value = dtoTipo.td_aplica_aleatoria;
                con.ObjCommand.Parameters.Add("@td_aplica_automatica ", SqlDbType.Int).Value = dtoTipo.td_aplica_automatica;
                con.ObjCommand.Parameters.Add("@td_aplica_directa", SqlDbType.Int).Value = dtoTipo.td_aplica_directa;
                con.ObjCommand.Parameters.Add("@mat_normativa_version_id", SqlDbType.Int).Value = dtoTipo.mat_normativa_version_id;
                con.ObjCommand.Parameters.Add("@etapa", SqlDbType.Int).Value = dtoTipo.etapa;
                con.ObjCommand.Parameters.Add("@td_activo", SqlDbType.Int).Value = dtoTipo.td_activo;


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

        //*****************
        public DataSet InspeccionAlcance_Obtener(int inspec_alcance_id, int submateria_id, int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspeccionAlcance_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspec_alcance_id", SqlDbType.Int).Value = inspec_alcance_id;
                con.ObjCommand.Parameters.Add("@submateria_id ", SqlDbType.Int).Value = submateria_id;
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

        //inspeccion indicador obtener
        public DataSet InspeccionIndicador_Obtener(int inspec_indicador_id, int indicador_id, int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspeccionIndicador_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspec_indicador_id", SqlDbType.Int).Value = inspec_indicador_id;
                con.ObjCommand.Parameters.Add("@indicador_id ", SqlDbType.Int).Value = indicador_id;
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

        public DataSet OperativosProgramados_Obtener(int prog_anual_id, int operativo_id, int oper_tipo_operativo, int mes, int oper_estatus, int panual_estatus = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativosProgramados_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@oper_tipo_operativo", SqlDbType.Int).Value = oper_tipo_operativo;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes;
                con.ObjCommand.Parameters.Add("@oper_estatus", SqlDbType.Int).Value = oper_estatus;
                con.ObjCommand.Parameters.Add("@panual_estatus", SqlDbType.Int).Value = panual_estatus;

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

        public DataSet OperativosProgramados_ObtenerParaProgInsp(int prog_anual_id, int operativo_id, int oper_tipo_operativo, int mes, int oper_estatus, int dia_hoy, int tipo_inspeccion_id = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativosProgramados_ObtenerParaProgInsp", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@oper_tipo_operativo", SqlDbType.Int).Value = oper_tipo_operativo;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes;
                con.ObjCommand.Parameters.Add("@oper_estatus", SqlDbType.Int).Value = oper_estatus;
                con.ObjCommand.Parameters.Add("@dia_hoy", SqlDbType.Int).Value = dia_hoy;
                con.ObjCommand.Parameters.Add("@tipo_inspeccion_id", SqlDbType.Int).Value = tipo_inspeccion_id;

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
        public DataSet OperativosDocto_Obtener(int operativo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativosDocto_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;


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


        public DataSet OperativosDocto_ObtenerPorID(int operativo_docto_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativosDocto_ObtenerDocPorID", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                con.ObjCommand.Parameters.Add("@operativo_docto_id", SqlDbType.Int).Value = operativo_docto_id;


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

        public DataSet OperativosDocto_ObtenerSinOp()
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativosDocto_ObtenerSinOp", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

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
        public DataSet Participante_Obtener(DtoParticipante miDtoPar, int dpart_tipo_participante, string usr_estatus = null)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Participante_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = miDtoPar.participante_id;
                con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = miDtoPar.cve_edorep;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoPar.cve_ur;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoPar.inspector_id;
                con.ObjCommand.Parameters.Add("@dpart_tipo_participante", SqlDbType.Int).Value = dpart_tipo_participante;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.Int).Value = miDtoPar.par_estatus;
                con.ObjCommand.Parameters.Add("@txt_search", SqlDbType.VarChar).Value = miDtoPar.txt_search;
                con.ObjCommand.Parameters.Add("@usr_estatus", SqlDbType.VarChar).Value = usr_estatus;

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

        public DataSet Notificadores_Obtener(DtoParticipante miDtoPar)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Notificadores_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = miDtoPar.participante_id;
                con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = miDtoPar.cve_edorep;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoPar.cve_ur;

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

        public DataSet MateriasObtener(int materia_id, int? normativa_version_id, string mat_acronimo, int mat_estatus, int diferentes)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MateriasObtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@normativa_version_id", SqlDbType.Int).Value = normativa_version_id;
                con.ObjCommand.Parameters.Add("@mat_acronimo", SqlDbType.VarChar).Value = mat_acronimo;
                con.ObjCommand.Parameters.Add("@mat_estatus", SqlDbType.Int).Value = mat_estatus;
                con.ObjCommand.Parameters.Add("@diferentes", SqlDbType.Int).Value = diferentes;

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

        public DataSet DatosObtenerDocumentoLegadoPorInspeccionId(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DatosObtenerDocumentoLegadoPorInspeccionId", con.ObjConnection);
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

        public DataSet Obtener_DatosExpediente_Satelite(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Obtener_DatosExpediente_Satelite", con.ObjConnection);
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



        public DataSet Variables_Obtener(int documento_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Variables_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = documento_id;


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

        //***la otra para obtener variables
        public DataSet Variables_Obtener2(int documento_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Variables_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = documento_id;


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

        public DataSet SubmateriaObtenerPorIdMateria(DtoSubmateria miDtoS)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaObtenerPorIdMateria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoS.materia_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoS.submateria_id;
                con.ObjCommand.Parameters.Add("@consecutivo", SqlDbType.Int).Value = miDtoS.smat_consecutivo;
                con.ObjCommand.Parameters.Add("@smat_estatus", SqlDbType.Int).Value = miDtoS.smat_estatus;


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

        //*********ka
        public DataSet Submateria_Obtener(DtoSubmateria miDtoS, int normatividad_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Submateria_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoS.materia_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoS.submateria_id;
                con.ObjCommand.Parameters.Add("@consecutivo", SqlDbType.Int).Value = miDtoS.smat_consecutivo;
                con.ObjCommand.Parameters.Add("@smat_estatus", SqlDbType.Int).Value = miDtoS.smat_estatus;
                con.ObjCommand.Parameters.Add("@smat_alcance", SqlDbType.Int).Value = miDtoS.smat_alcance;
                con.ObjCommand.Parameters.Add("@normatividad_id", SqlDbType.Int).Value = normatividad_id;

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

        //*******************
        public DataSet InspeccionAlcance_ObtenerAlcanceGeneral(int inspec_alcance_id, int submateria, int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspeccionAlcance_ObtenerAlcanceGeneral", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspec_alcance_id", SqlDbType.Int).Value = inspec_alcance_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria;
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


        public DataSet Incisos_Obtener(int indicador_id, int ind_inciso_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Incisos_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@ind_inciso_id", SqlDbType.Int).Value = ind_inciso_id;


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


        //******************
        public DataSet SubmateriaObtenerPorIdMateriaPorAlcance(DtoSubmateria miDtoS)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaObtenerPorIdMateriaPorAlcance", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoS.materia_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoS.submateria_id;
                con.ObjCommand.Parameters.Add("@consecutivo", SqlDbType.Int).Value = miDtoS.smat_consecutivo;
                con.ObjCommand.Parameters.Add("@alcance", SqlDbType.Int).Value = miDtoS.smat_alcance;

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

        public DataSet IndicadoresObtenerPorIdSubMateria(DtoIndicadores miDtoS)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndicadoresObtenerPorIdSubMateria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoS.submateria_id;

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

        public DataSet Indicadores_Obtener(DtoIndicadores miDtoS)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Indicadores_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = miDtoS.indicador_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoS.submateria_id;
                con.ObjCommand.Parameters.Add("@requisito_id", SqlDbType.Int).Value = miDtoS.requisito_id;
                con.ObjCommand.Parameters.Add("@ind_estatus", SqlDbType.Int).Value = miDtoS.ind_estatus;

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

        //**********
        public DataSet Indicadores_ObtenerporAlcance(DtoIndicadores miDtoS)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Indicadores_ObtenerporAlcance", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = miDtoS.indicador_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoS.submateria_id;
                con.ObjCommand.Parameters.Add("@requisito_id", SqlDbType.Int).Value = miDtoS.requisito_id;
                con.ObjCommand.Parameters.Add("@ind_alcance", SqlDbType.Int).Value = miDtoS.ind_alcance;

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
        public DataSet InfoAdicional_Obtener(DtoInfoAdicional miDtoS)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InfoAdicional_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (miDtoS.ind_info_adicional_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = miDtoS.ind_info_adicional_id;
                if (miDtoS.indicador_id != -1)
                    con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = miDtoS.indicador_id;
                if (miDtoS.ind_inciso_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_inciso_id", SqlDbType.Int).Value = miDtoS.ind_inciso_id;
                if (miDtoS.iia_forma_incorporar != -1)
                    con.ObjCommand.Parameters.Add("@iia_forma_incorporar", SqlDbType.TinyInt).Value = miDtoS.iia_forma_incorporar;
                if (miDtoS.iia_respuesta_depende != -1)
                    con.ObjCommand.Parameters.Add("@iia_respuesta_depende", SqlDbType.TinyInt).Value = miDtoS.iia_respuesta_depende;


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

        public DataSet IndMedida_Obtener(DtoIndMedida miDtoInd)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndMedida_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = miDtoInd.indicador_id;
                con.ObjCommand.Parameters.Add("@ind_inciso_id", SqlDbType.Int).Value = miDtoInd.ind_inciso_id;
                con.ObjCommand.Parameters.Add("@ind_medida_id", SqlDbType.Int).Value = miDtoInd.ind_medida_id;

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

        //*****obtener noms
        public DataSet SubmateriaNomsObtenerPorIdMateriaPorAlcance(DtoSubmateria miDtoS)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaNomsObtenerPorIdMateriaPorAlcance", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoS.materia_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = miDtoS.submateria_id;
                con.ObjCommand.Parameters.Add("@consecutivo", SqlDbType.Int).Value = miDtoS.smat_consecutivo;
                con.ObjCommand.Parameters.Add("@alcance", SqlDbType.Int).Value = miDtoS.smat_alcance;

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
        public int SubmateriaObtenerMax()
        {
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaObtenerMax", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Connection.Open();
                return Convert.ToInt32(con.ObjCommand.ExecuteScalar());

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public DataSet MotivoInspeccion_Obtener(int motivo_inspeccion_id, int motiv_consecutivo, int normatividad_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoInspeccion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = motivo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@motiv_consecutivo", SqlDbType.Int).Value = motiv_consecutivo;
                con.ObjCommand.Parameters.Add("@normatividad_id", SqlDbType.Int).Value = normatividad_id;

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


        public DataSet MotivoInspeccion_ObtenerOp(int motivo_inspeccion_id, int motiv_consecutivo, int motiv_para_operativo_programado, int motiv_para_operativo_especial)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoInspeccion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = motivo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@motiv_consecutivo", SqlDbType.Int).Value = motiv_consecutivo;
                con.ObjCommand.Parameters.Add("@motiv_para_operativo_programado", SqlDbType.Int).Value = motiv_para_operativo_programado;
                con.ObjCommand.Parameters.Add("@motiv_para_operativo_especial", SqlDbType.Int).Value = motiv_para_operativo_especial;

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

        public DataSet MotivoMateria_Obtener(int motivo_inspeccion_id, int materia_id, string sentencia = "DEFAULT")
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoMateria_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = motivo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;

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

        //**************
        public DataSet SubtipoMateria_Obtener(int subtipo_inspeccion_id, int materia_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubtipoMateria_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = subtipo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;

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

        public DataSet SubtipoMateria(DtoSubtipoMateria dtoSubtipoMateria)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubtipoMateria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = dtoSubtipoMateria.subtipo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = dtoSubtipoMateria.materia_id;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = dtoSubtipoMateria.sentencia;
                con.ObjCommand.Parameters.Add("@ms_atribuciones_541_lft", SqlDbType.VarChar).Value = dtoSubtipoMateria.ms_atribuciones_541_lft;
                con.ObjCommand.Parameters.Add("@ms_atribuciones_art_9_rgiasvll", SqlDbType.VarChar).Value = dtoSubtipoMateria.ms_atribuciones_art_9_rgiasvll;
                con.ObjCommand.Parameters.Add("@ms_asesoria_art_10_rgiasvll", SqlDbType.VarChar).Value = dtoSubtipoMateria.ms_asesoria_art_10_rgiasvll;
                con.ObjCommand.Parameters.Add("@ms_requisitos_rgiasvll", SqlDbType.VarChar).Value = dtoSubtipoMateria.ms_requisitos_rgiasvll;
                con.ObjCommand.Parameters.Add("@ms_tipo_542_lft", SqlDbType.VarChar).Value = dtoSubtipoMateria.ms_tipo_542_lft;
                con.ObjCommand.Parameters.Add("@materia_subtipo_id", SqlDbType.Int).Value = dtoSubtipoMateria.materia_subtipo_id;

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

        public DataSet SeccionesMateria(DtoSeccionesMateria dtoSeccionesMateria)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_dshgoSeccionMateria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_seccion_materia_id", SqlDbType.Int).Value = dtoSeccionesMateria.dshgo_seccion_materia_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = dtoSeccionesMateria.materia_id;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = dtoSeccionesMateria.sentencia;
                con.ObjCommand.Parameters.Add("@dshgo_seccion_id", SqlDbType.Int).Value = dtoSeccionesMateria.dshgo_seccion_id;

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

        //**************
        public DataSet MotivoMateriaSubtipo_Obtener(int motivo_inspeccion_id, int materia_id, int subtipo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoMateriaSubtipo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = motivo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@subtipo_id", SqlDbType.Int).Value = subtipo_id;
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

        //******consultar motivo tomando en cuenta,  materia, subtipo y tipo de operativo
        public DataSet MotivoMateriaSubtipo_ObtenerPorTipoOperativo(int motivo_inspeccion_id, int materia_id, int subtipo_id, int motiv_para_operativo_especial, int motiv_para_operativo_prog)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoMateriaSubtipo_ObtenerPorTipoOperativo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = motivo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@subtipo_id", SqlDbType.Int).Value = subtipo_id;
                con.ObjCommand.Parameters.Add("@motiv_para_operativo_especial", SqlDbType.Int).Value = motiv_para_operativo_especial;
                con.ObjCommand.Parameters.Add("@motiv_para_operativo_programado", SqlDbType.Int).Value = motiv_para_operativo_prog;

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

        public DataSet SubtipoInspeccion_Obtener(int tipo, int comprobacionSanciones = 0)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubtipoInspeccion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@tipo_inspeccion", SqlDbType.Int).Value = tipo;
                con.ObjCommand.Parameters.Add("@comprobacionSanciones", SqlDbType.Int).Value = comprobacionSanciones;

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

        public DataSet TipoInspeccion_ObtenerPorIdSubtipo(int tipo)
        {

            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TipoInspeccion_ObtenerPorIdSubtipo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = tipo;

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

        //***************
        public DataSet MotivoSubtipo_Obtener(int motivo_inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoSubtipo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = motivo_inspeccion_id;
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

        public DataSet Inspector_Obtener(int inspector_id, String insp_num_credencial)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspector_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;
                con.ObjCommand.Parameters.Add("@insp_num_credencial", SqlDbType.VarChar).Value = insp_num_credencial;

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

        public DataSet Inspector_Obtener(int inspector_id, String insp_num_credencial, int cve_ur)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspector_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;
                con.ObjCommand.Parameters.Add("@insp_num_credencial", SqlDbType.VarChar).Value = insp_num_credencial;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;

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


        public DataSet Inspector_ObtenerPorUR(int inspector_id, string insp_num_credencial, int ur, int edo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspector_ObtenerPorUR", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;
                if (insp_num_credencial != "")
                {
                    con.ObjCommand.Parameters.Add("@insp_num_credencial", SqlDbType.VarChar).Value = insp_num_credencial;
                }
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = ur;
                con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = edo;
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

        public DataSet ProgAnual_Obtener(int prog_anual_id, int panual_anio, int panual_estatus, int estatus_normativa)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAnual_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;
                con.ObjCommand.Parameters.Add("@panual_anio", SqlDbType.Int).Value = panual_anio;
                con.ObjCommand.Parameters.Add("@panual_estatus", SqlDbType.Int).Value = panual_estatus;
                con.ObjCommand.Parameters.Add("@estatus_normativa", SqlDbType.Int).Value = estatus_normativa;
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

        public DataSet ObtenerCatalogoPorNombre(string nombre_catalogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtenerCatalogoPorNombre", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@nombre_catalogo", SqlDbType.VarChar).Value = nombre_catalogo;
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

        public DataSet PA_ObetenerTotalInspectoresPorEdoRep(int int_anio, int anio_select, int prog_anual_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObetenerTotalInspectoresPorEdoRep", con.ObjConnection);
                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = int_anio;
                con.ObjCommand.Parameters.Add("@anio_select", SqlDbType.Int).Value = anio_select;
                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
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
        //tipo_consulta = ["select","UpdateOrCreate"]
        public DataSet PA_DML_Factor(string tipo_consulta, int cve_edo_rep, int cur_cve_ur, int anio, int total_inspecciones, string factor, int prog_anual_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            DateTime fecha = DateTime.Now;

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DML_Factor", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@tipo_consulta", SqlDbType.VarChar).Value = tipo_consulta;
                con.ObjCommand.Parameters.Add("@cve_edo_rep", SqlDbType.Int).Value = cve_edo_rep;
                con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = cur_cve_ur;
                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@total_inspecciones", SqlDbType.Int).Value = total_inspecciones;
                con.ObjCommand.Parameters.Add("@factor", SqlDbType.VarChar).Value = factor;
                con.ObjCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;

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

        public DataSet ProgAnual_Obtener(int prog_anual_id, int panual_anio, int panual_estatus, int pent_cve_ur, int estatus_normativa)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAnual_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@estatus_normativa", SqlDbType.Int).Value = estatus_normativa;
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

        public DataSet ProgEntidad_Obtener(DtoProgEntidad miDtoPE, int anio, int prog_anual_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgEntidad_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@prog_entidad_id", SqlDbType.Int).Value = miDtoPE.prog_entidad_id;
                con.ObjCommand.Parameters.Add("@prog_mes_id", SqlDbType.Int).Value = miDtoPE.prog_mes_id;
                con.ObjCommand.Parameters.Add("@pent_cve_edorep", SqlDbType.Int).Value = miDtoPE.pent_cve_edorep;
                con.ObjCommand.Parameters.Add("@pent_cve_ur", SqlDbType.Int).Value = miDtoPE.pent_cve_ur;
                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;
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


        //************************todos los meses
        public DataSet ProgEntidad_ObtenerTodosMeses(DtoProgEntidad miDtoPE)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgEntidad_ObtenerTodosMeses", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@prog_entidad_id", SqlDbType.Int).Value = miDtoPE.prog_entidad_id;
                con.ObjCommand.Parameters.Add("@prog_mes_id", SqlDbType.Int).Value = miDtoPE.prog_mes_id;
                con.ObjCommand.Parameters.Add("@pent_cve_edorep", SqlDbType.Int).Value = miDtoPE.pent_cve_edorep;
                con.ObjCommand.Parameters.Add("@pent_cve_ur", SqlDbType.Int).Value = miDtoPE.pent_cve_ur;
                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = miDtoPE.prog_anual_id;
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


        //****prog  entidad anual
        public DataSet ProgEntidad_ObtenerAnual(DtoProgEntidad miDtoPE)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgEntidad_ObtenerAnual", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@pent_cve_edorep", SqlDbType.Int).Value = miDtoPE.pent_cve_edorep;

                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = miDtoPE.prog_anual_id;
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

        //prog anual por estado
        //****prog  entidad anual
        public DataSet ProgEntidad_ObtenerAnualEstado(DtoProgEntidad miDtoPE)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgEntidad_ObtenerAnualEstado", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@pent_cve_edorep", SqlDbType.Int).Value = miDtoPE.pent_cve_edorep;

                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = miDtoPE.prog_anual_id;
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

        //progentidad total por prog anual id
        public DataSet ProgEntidad_ObtenerTotalPorProgAnual(int prog_anual_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgEntidad_ObtenerTotalPorProgAnual", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                //con.ObjCommand.Parameters.Add("@pent_cve_edorep", SqlDbType.Int).Value = miDtoPE.pent_cve_edorep;

                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;
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


        public DataSet ProgMes_Obtener(int prog_mes_id, int prog_anual_id, int mes_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgMes_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;
                con.ObjCommand.Parameters.Add("@prog_mes_id", SqlDbType.Int).Value = prog_mes_id;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes_id;
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

        public DataSet ProgMateria_ObtenerPorProgAnualID(int prog_anual_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgMateria_ObtenerPorProgAnualID", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;

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


        public DataSet ProgMateriaAtributo_ObtenerPorProgAnualID(int prog_anual_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgMateriaAtributo_ObtenerPorProgAnualID", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;

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

        //obtener mes
        public DataSet Mes_Obtener(int mes_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MES_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes_id;
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

        //obtener inspector por año
        public DataSet Inspector_ObtenerPorAnio(int inspector_id, int anio)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspector_ObtenerPorAño", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;
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

        //para anunciar aviso o noticia en bienvenida
        public DataSet Contenido_Usuario_Revision(int usuario_id, int infa_tipo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InfoApoyo_Usuario_Revision", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuario_id;
                con.ObjCommand.Parameters.Add("@infa_tipo", SqlDbType.Int).Value = infa_tipo;

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

        public DataSet OperativoEntidad_Obtener(DtoOperativoEntidad miDtoOE)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoEntidad_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@operativo_entidad_id", SqlDbType.Int).Value = miDtoOE.operativo_entidad_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoOE.operativo_id;
                con.ObjCommand.Parameters.Add("@operent_cve_edorep", SqlDbType.Int).Value = miDtoOE.operent_cve_edorep;
                con.ObjCommand.Parameters.Add("@operent_cve_ur", SqlDbType.Int).Value = miDtoOE.operent_cve_ur;
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

        public DataSet OperativoEntidad_ObtenerMetas(DtoOperativoEntidad miDtoOE)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoEntidad_ObtenerMetas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@operativo_entidad_id", SqlDbType.Int).Value = miDtoOE.operativo_entidad_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoOE.operativo_id;
                con.ObjCommand.Parameters.Add("@operent_cve_edorep", SqlDbType.Int).Value = miDtoOE.operent_cve_edorep;
                con.ObjCommand.Parameters.Add("@operent_cve_ur", SqlDbType.Int).Value = miDtoOE.operent_cve_ur;
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

        public DataSet OperativoEntidad_ObtenerOtro(int operativo_id, int edo, int ur, int prog_anual_id, int mes)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoEntidad_ObtenerOtro", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@operent_cve_edorep", SqlDbType.Int).Value = edo;
                con.ObjCommand.Parameters.Add("@operent_cve_ur", SqlDbType.Int).Value = ur;
                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes;
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

        public DataSet OperativoAsignacion_Obtener(DtoOperativoAsignacion miDtoOA)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAsignacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@operativo_asignacion_id", SqlDbType.Int).Value = miDtoOA.operativo_asignacion_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoOA.operativo_id;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoOA.inspector_id;
                con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = miDtoOA.oas_cve_edorep;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoOA.oas_cve_ur;

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

        public DataSet ProgAtributo_ObtenerPorID(int prog_atributo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_atributo_id", SqlDbType.VarChar).Value = prog_atributo_id;

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


        public DataSet DoctoParrafoTipo_Obtener(int docto_parrafo_texto_id, int tipo_inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoTipo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@tipo_inspeccion_id", SqlDbType.Int).Value = tipo_inspeccion_id;


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

        public DataSet Documentos_ConsultarActualizar(DtoGestorDocumentos dtoDoc)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Documentos_ConsultarActualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = dtoDoc.sentencia;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDoc.tipo_documento_id;
                if (String.IsNullOrEmpty(dtoDoc.tipo_documento))
                    dtoDoc.tipo_documento = "";
                if (!String.IsNullOrEmpty(dtoDoc.tipo_documento))
                    con.ObjCommand.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = dtoDoc.tipo_documento;
                if (dtoDoc.aplica_aleatoria != -1)
                    con.ObjCommand.Parameters.Add("@aplica_aleatoria", SqlDbType.Int).Value = dtoDoc.aplica_aleatoria;
                if (dtoDoc.aplica_directa != -1)
                    con.ObjCommand.Parameters.Add("@aplica_directa", SqlDbType.Int).Value = dtoDoc.aplica_directa;
                if (dtoDoc.aplica_automatica != -1)
                    con.ObjCommand.Parameters.Add("@aplica_automatica", SqlDbType.Int).Value = dtoDoc.aplica_automatica;
                if (dtoDoc.aplica_notificacion != -1)
                    con.ObjCommand.Parameters.Add("@aplica_notificacion", SqlDbType.Int).Value = dtoDoc.aplica_notificacion;
                if (dtoDoc.normativa_version != -1)
                    con.ObjCommand.Parameters.Add("@mat_normativa_version_id", SqlDbType.Int).Value = dtoDoc.normativa_version;
                if (dtoDoc.td_activo != -1)
                    con.ObjCommand.Parameters.Add("@activo", SqlDbType.Int).Value = dtoDoc.td_activo;
                if (!String.IsNullOrEmpty(dtoDoc.etapa))
                    con.ObjCommand.Parameters.Add("@etapa", SqlDbType.VarChar).Value = dtoDoc.etapa;

                con.ObjCommand.Parameters.Add("@code", SqlDbType.VarChar).Value = Regex.Replace(dtoDoc.tipo_documento.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "").Replace(" ", "_").ToLower();

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

        public DataSet DoctoParrafoSubtipo_Obtener(int docto_parrafo_texto_id, int subtipo_inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoSubtipo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = subtipo_inspeccion_id;


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

        public DataSet DoctoParrafoMateria_Obtener(int docto_parrafo_texto_id, int materia_id, int? normatividad_id = 1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoMateria_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@normatividad_id", SqlDbType.Int).Value = normatividad_id;



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

        public DataSet SDoctoParrafoMateria_Obtener(int s_docto_parrafo_texto_id, int materia_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDt = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SDoctoParrafoMateria_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_docto_parrafo_texto_id", SqlDbType.Int).Value = s_docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDt, "resultado");

                return objDt;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public DataSet SDoctoParrafoComparecencia_Obtener(int s_docto_parrafo_texto_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDt = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SDoctoParrafoComparecencia_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_docto_parrafo_texto_id", SqlDbType.Int).Value = s_docto_parrafo_texto_id;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDt, "resultado");

                return objDt;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public DataSet OperativoAlcance_Obtener(int operativo_alcance_id, int operativo_id, int materia_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAlcance_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_alcance_id", SqlDbType.Int).Value = operativo_alcance_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;

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

        //*****
        public DataSet OperativoAlcance_ObtenerTipoAlcance(int operativo_alcance_id, int operativo_id, int materia_id, int alcance)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAlcance_ObtenerTipoAlcance", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_alcance_id", SqlDbType.Int).Value = operativo_alcance_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@alcance", SqlDbType.Int).Value = alcance;

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

        //****************************************
        public DataSet OperativoAlcance_ObtenerPorOperativoPorSubmateria(int operativo_alcance_id, int operativo_id, int submateria_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAlcance_ObtenerPorOperativoPorSubmateria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_alcance_id", SqlDbType.Int).Value = operativo_alcance_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;

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

        public DataSet OperativoIndicador_Obtener(int operativo_alcance_id, int submateria_id, int ind_alcance)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoIndicador_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_alcance_id", SqlDbType.Int).Value = operativo_alcance_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                con.ObjCommand.Parameters.Add("@ind_alcance", SqlDbType.Int).Value = ind_alcance;


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

        public DataSet OperativoIndicadorMenu_Obtener(int operativo_alcance_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoIndicadorMenu_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_alcance_id", SqlDbType.Int).Value = operativo_alcance_id;


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


        //obtener indicadores de un operativo para una inspeccion
        public DataSet OperativoIndicador_ObtenerParaInspeccion(int operativo_alcance_id, int submateria_id, int ind_alcance, int operativo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoIndicador_ObtenerParaInspeccion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_alcance_id", SqlDbType.Int).Value = operativo_alcance_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                con.ObjCommand.Parameters.Add("@ind_alcance", SqlDbType.Int).Value = ind_alcance;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;

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

        public DataSet ProgAnual_Consultar(int panual_anio, int pent_cve_ur, int prog_anual_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAnual_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@panual_anio", SqlDbType.Int).Value = panual_anio;
                con.ObjCommand.Parameters.Add("@pent_cve_ur", SqlDbType.Int).Value = pent_cve_ur;
                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;


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

        public DataSet DML_Inspecciones_Acotadas(int inspeccion_id, string sentencia, int inspec_alcance_propuesta_id = -1, int submateria_id = -1, string motivo = "")
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DML_Inspecciones_Acotadas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;

                if(inspec_alcance_propuesta_id != -1)
                    con.ObjCommand.Parameters.Add("@inspec_alcance_propuesta_id", SqlDbType.Int).Value = inspec_alcance_propuesta_id;
                if (submateria_id != -1)
                    con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                if (motivo != "")
                    con.ObjCommand.Parameters.Add("@motivo", SqlDbType.VarChar).Value = motivo;

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

        public DataSet Inspeccion_Obtener(DtoInspeccion miDtoI)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoI.inspeccion_id;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = miDtoI.mes_id;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoI.cve_ur;
                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = miDtoI.centro_trabajo_id;
                con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = miDtoI.in_anio;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoI.operativo_id;
                con.ObjCommand.Parameters.Add("@in_tipo_programacion_id", SqlDbType.Int).Value = miDtoI.in_tipo_programacion_id;
                con.ObjCommand.Parameters.Add("@tipo_inspeccion_id", SqlDbType.Int).Value = miDtoI.tipo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@in_aplica_especial", SqlDbType.Int).Value = miDtoI.in_aplica_especial;
                con.ObjCommand.Parameters.Add("@in_estatus", SqlDbType.Int).Value = miDtoI.in_estatus;

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

        public DataSet Inspeccion_Origen_Obtener(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_Origen_Obtener", con.ObjConnection);
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

        //****nuevo inspeccion obtener, 
        public DataSet Inspeccion_Obtener2(DtoInspeccion miDtoI)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoI.inspeccion_id;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = miDtoI.mes_id;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoI.cve_ur;
                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = miDtoI.centro_trabajo_id;
                con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = miDtoI.in_anio;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoI.operativo_id;
                con.ObjCommand.Parameters.Add("@in_tipo_programacion_id", SqlDbType.Int).Value = miDtoI.in_tipo_programacion_id;
                con.ObjCommand.Parameters.Add("@tipo_inspeccion_id", SqlDbType.Int).Value = miDtoI.tipo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@in_aplica_especial", SqlDbType.Int).Value = miDtoI.in_aplica_especial;
                con.ObjCommand.Parameters.Add("@in_estatus", SqlDbType.Int).Value = miDtoI.in_estatus;

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

        public DataSet Inspeccion_ConsultarEmpresa(DtoBusqueda miDtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_ConsultarEmpresa", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (!String.IsNullOrEmpty(miDtoB.nombre_corto))
                    con.ObjCommand.Parameters.Add("@in_ct_nombre", SqlDbType.VarChar).Value = miDtoB.nombre_corto;
                if (!String.IsNullOrEmpty(miDtoB.calle))
                    con.ObjCommand.Parameters.Add("@in_domicilio_inspeccion", SqlDbType.VarChar).Value = miDtoB.calle;
                if (!String.IsNullOrEmpty(miDtoB.exp_corto))
                    con.ObjCommand.Parameters.Add("@in_num_expediente", SqlDbType.VarChar).Value = miDtoB.exp_corto;
                if (!String.IsNullOrEmpty(miDtoB.rfc))
                    con.ObjCommand.Parameters.Add("@in_ct_rfc", SqlDbType.VarChar).Value = miDtoB.rfc;
                if (!String.IsNullOrEmpty(miDtoB.fecha_inicio))
                    con.ObjCommand.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = miDtoB.fecha_inicio;
                if (!String.IsNullOrEmpty(miDtoB.fecha_fin))
                    con.ObjCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = miDtoB.fecha_fin;
                if (miDtoB.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoB.cve_ur;
                if (miDtoB.tipo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@tipo_inspeccion_id", SqlDbType.Int).Value = miDtoB.tipo_inspeccion_id;
                if (miDtoB.subtipo_inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = miDtoB.subtipo_inspeccion_id;
                if (miDtoB.materia_id != -1)
                    con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoB.materia_id;
                if (miDtoB.operativo_id != -1)
                    con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoB.operativo_id;
                if (miDtoB.participante_id != -1)
                    con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = miDtoB.participante_id;

                if (miDtoB.ct_entidad != -1)
                    con.ObjCommand.Parameters.Add("@cur_cve_edorep", SqlDbType.Int).Value = miDtoB.ct_entidad;
                if (miDtoB.in_etapa != -1)
                    con.ObjCommand.Parameters.Add("@in_etapa", SqlDbType.Int).Value = miDtoB.in_etapa;

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

        public DataSet Inspeccion_Consulta(int centro_trabajo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_Consulta", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (centro_trabajo_id != -1)
                    con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;

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

        public int Inspeccion_Obtener_Ultima_Por_Materia(int centro_trabajo_id, string materia_acronimo)
        {
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_Obtener_Ultima", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@materia_acronimo", SqlDbType.VarChar).Value = materia_acronimo;
                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;
                con.ObjCommand.Connection.Open();
                return Convert.ToInt32(con.ObjCommand.ExecuteScalar());
            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }


        }


        public DataSet Inspeccion_ConsultarEtapas(int inspeccion_id, int in_etapa)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_ConsultarEtapas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@in_etapa", SqlDbType.Int).Value = in_etapa;

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

        public DataSet Inspeccion_ObtenerFormato(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_ObtenerFormato", con.ObjConnection);
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
        public DataSet ObtenerResumenInspeccionOrigenReprogramacion(int inspeccion_id, int inspeccion_origen_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtenerResumenInspeccionOrigenReprogramacion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

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

        public DataSet DshgoMedidasArea_ObtenerPorArea(int dsgo_area_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedidasArea_ObtenerPorArea", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dsgo_area_id", SqlDbType.Int).Value = dsgo_area_id;

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

        public DataSet InspecExperto_Obtener(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecExperto_Obtener", con.ObjConnection);
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

        public DataSet InspecParticipante_Obtener(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecParticipante_Obtener", con.ObjConnection);
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

        //*****************
        public DataSet TodosInspectoresPorInspeccion_Obtener(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TodosInspectoresPorInspeccion_Obtener", con.ObjConnection);
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
        public DataSet InspecParticipante_Obtener(int inspeccion_id, int participante_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecParticipante_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;

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

        public DataSet FundamentoDesignacion_Obtener()
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_FundamentoDesignacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

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

        public DataSet InspeccionCopia_Obtener(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspeccionCopia_Obtener", con.ObjConnection);
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

        public DataSet InspeccionCopia_ObtenerPorInspeccionID(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecionCopia_Obtener", con.ObjConnection);
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

        public DataSet Inspeccion_Busqueda(DtoInspeccion miDtoI)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_Busqueda", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@in_tipo_programacion_id", SqlDbType.Int).Value = miDtoI.in_tipo_programacion_id;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoI.cve_ur;
                con.ObjCommand.Parameters.Add("@tipo_inspeccion_id", SqlDbType.Int).Value = miDtoI.tipo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = miDtoI.subtipo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoI.materia_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoI.operativo_id;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoI.inspector_id;
                con.ObjCommand.Parameters.Add("@in_estatus", SqlDbType.Int).Value = miDtoI.in_estatus;
                con.ObjCommand.Parameters.Add("@in_etapa", SqlDbType.Int).Value = miDtoI.in_etapa;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = miDtoI.mes_id;
                con.ObjCommand.Parameters.Add("@ordenar", SqlDbType.Int).Value = miDtoI.ordenar;
                con.ObjCommand.Parameters.Add("@ct_entidad", SqlDbType.Int).Value = miDtoI.ct_entidad;
                con.ObjCommand.Parameters.Add("@ct_municipio", SqlDbType.Int).Value = miDtoI.ct_municipio;
                con.ObjCommand.Parameters.Add("@xml_centro", SqlDbType.Xml).Value = miDtoI.xml_centro;
                con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = miDtoI.in_anio;


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

        public DataSet Programacion_Busqueda(DtoInspeccion miDtoI)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Programacion_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@in_tipo_programacion_id", SqlDbType.Int).Value = miDtoI.in_tipo_programacion_id;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoI.cve_ur;
                con.ObjCommand.Parameters.Add("@tipo_inspeccion_id", SqlDbType.Int).Value = miDtoI.tipo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = miDtoI.subtipo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = miDtoI.materia_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoI.operativo_id;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoI.inspector_id;
                con.ObjCommand.Parameters.Add("@in_estatus", SqlDbType.Int).Value = miDtoI.in_estatus;
                con.ObjCommand.Parameters.Add("@in_etapa", SqlDbType.Int).Value = miDtoI.in_etapa;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = miDtoI.mes_id;
                con.ObjCommand.Parameters.Add("@ordenar", SqlDbType.Int).Value = miDtoI.ordenar;
                con.ObjCommand.Parameters.Add("@ct_entidad", SqlDbType.Int).Value = miDtoI.ct_entidad;
                con.ObjCommand.Parameters.Add("@ct_municipio", SqlDbType.Int).Value = miDtoI.ct_municipio;
                con.ObjCommand.Parameters.Add("@xml_centro", SqlDbType.Xml).Value = miDtoI.xml_centro;
                con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = miDtoI.in_anio;
                con.ObjCommand.Parameters.Add("@mat_acronimo", SqlDbType.VarChar).Value = miDtoI.mat_acronimo;


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

        public DataSet ProgAtributoScian_ObtenerPorIniPer(int prog_atributo_idini, int prog_atributo_idper)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributoScian_ObtenerPorIniPer", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@prog_atributo_idini", SqlDbType.Int).Value = prog_atributo_idini;
                con.ObjCommand.Parameters.Add("@prog_atributo_idper", SqlDbType.Int).Value = prog_atributo_idper;

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

        public DataSet ProgAtributoRama_ObtenerPorIniPer(int prog_atributo_idini, int prog_atributo_idper)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributoRama_ObtenerPorIniPer", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@prog_atributo_idini", SqlDbType.Int).Value = prog_atributo_idini;
                con.ObjCommand.Parameters.Add("@prog_atributo_idper", SqlDbType.Int).Value = prog_atributo_idper;

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

        public DataSet Programacion_Mensual(int mes_id, int in_anio, int cve_ur, int participante_id, String in_fec_inspeccion)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Programacion_Mensual", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes_id;
                con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = in_anio;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;
                con.ObjCommand.Parameters.Add("@in_fec_inspeccion", SqlDbType.DateTime).Value = in_fec_inspeccion;

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

        public DataSet Notificacion_Busqueda(DtoNotificacion miDtoN)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Notificacion_Busqueda", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@notif_estatus_asignacion", SqlDbType.Int).Value = miDtoN.notif_estatus_asignacion;
                con.ObjCommand.Parameters.Add("@notif_estatus_entrega", SqlDbType.Int).Value = miDtoN.notif_estatus_entrega;
                con.ObjCommand.Parameters.Add("@notif_forma_entrega", SqlDbType.Int).Value = miDtoN.notif_forma_entrega;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = miDtoN.tipo_documento_id;

                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoN.inspector_id;
                con.ObjCommand.Parameters.Add("@ct_cve_municipio", SqlDbType.Int).Value = miDtoN.ct_cve_municipio;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoN.cve_ur;
                con.ObjCommand.Parameters.Add("@code_documento", SqlDbType.VarChar).Value = miDtoN.code_documento;

                con.ObjCommand.Parameters.Add("@in_ct_nombre", SqlDbType.VarChar).Value = miDtoN.in_ct_nombre;
                if (!String.IsNullOrEmpty(miDtoN.fecha_ini))
                    con.ObjCommand.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = miDtoN.fecha_ini;
                if (!String.IsNullOrEmpty(miDtoN.fecha_fin))
                    con.ObjCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = miDtoN.fecha_fin;
                con.ObjCommand.Parameters.Add("@tipo", SqlDbType.VarChar).Value = miDtoN.tipo;

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

        public DataSet RegistroActividad_Busqueda(DtoBusquedaRegistroActividad miDtoN)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_RegistroActividad_Busqueda", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@tipo_actividad", SqlDbType.VarChar).Value = miDtoN.tipo_actividad;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = miDtoN.cve_ur;


                if (!String.IsNullOrEmpty(miDtoN.fecha_ini_tx))
                    con.ObjCommand.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = miDtoN.fecha_ini;
                if (!String.IsNullOrEmpty(miDtoN.fecha_fin_tx))
                    con.ObjCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = miDtoN.fecha_fin;
                if (miDtoN.estatus == 1)
                    con.ObjCommand.Parameters.Add("@estatus_atendido", SqlDbType.Int).Value = miDtoN.estatus;
                if (miDtoN.estatus == 2)
                    con.ObjCommand.Parameters.Add("@estatus_noatendido", SqlDbType.Int).Value = miDtoN.estatus;

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

        public DataSet DoctoParrafoEtiqueta_Obtener(int docto_parrafo_texto_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoEtiqueta_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = docto_parrafo_texto_id;

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

        public DataSet SDoctoParrafoEtiqueta_Obtener(int s_docto_parrafo_texto_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDt = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SDoctoParrafoEtiqueta_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_docto_parrafo_texto_id", SqlDbType.Int).Value = s_docto_parrafo_texto_id;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDt, "resultado");

                return objDt;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public DataSet Programacion_Mensual_Datos(int mes_id, int in_anio, int cve_ur, int participante_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Programacion_Mensual_Datos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes_id;
                con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = in_anio;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;

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

        public DataSet Programacion_MensualPorInspector(String fecha_inicio, String fecha_fin, int participante_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Programacion_MensualPorInspector", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = fecha_inicio;
                con.ObjCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = fecha_fin;
                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;

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

        public DataSet Programacion_PorInspector(String fecha_inicio, String fecha_fin, int ordenar, int participante_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Programacion_PorInspector", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (!String.IsNullOrEmpty(fecha_inicio))
                    con.ObjCommand.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = fecha_inicio;
                if (!String.IsNullOrEmpty(fecha_fin))
                    con.ObjCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = fecha_fin;
                con.ObjCommand.Parameters.Add("@ordenar", SqlDbType.Int).Value = ordenar;
                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;

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

        public DataSet Programacion_PorInspectorparaDesahogo(String fecha_programada, String razon_social, String No_inspeccion, int participante_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Programacion_PorInspectorParaDesahogo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (!String.IsNullOrEmpty(fecha_programada))
                    con.ObjCommand.Parameters.Add("@fecha_programada", SqlDbType.VarChar).Value = fecha_programada;
                if (!String.IsNullOrEmpty(razon_social))
                    con.ObjCommand.Parameters.Add("@razon_social", SqlDbType.VarChar, 255).Value = razon_social;
                if (!String.IsNullOrEmpty(No_inspeccion))
                    con.ObjCommand.Parameters.Add("@no_inspeccion", SqlDbType.VarChar, 255).Value = No_inspeccion;
                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;

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

        public DataSet IndTemaFrecuente_Consultar(int ind_tema_frecuente_id, int indtfrec_consecutivo, int indtfrec_estatus)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndTemaFrecuente_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_tema_frecuente_id", SqlDbType.Int).Value = ind_tema_frecuente_id;
                con.ObjCommand.Parameters.Add("@indtfrec_consecutivo", SqlDbType.Int).Value = indtfrec_consecutivo;
                con.ObjCommand.Parameters.Add("@indtfrec_estatus", SqlDbType.Int).Value = indtfrec_estatus;

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

        public DataSet IndTemaFrecuente_Consultar(int ind_tema_frecuente_id, int indtfrec_consecutivo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndTemaFrecuente_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_tema_frecuente_id", SqlDbType.Int).Value = ind_tema_frecuente_id;
                con.ObjCommand.Parameters.Add("@indtfrec_consecutivo", SqlDbType.Int).Value = indtfrec_consecutivo;


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

        public DataSet IndicadorTemaNom_Consultar(int ind_tema_nom_id, int indtnom_consecutivo, int tema_padre_id, int submateria, int tipo, int estatus)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndicadorTemaNom_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_tema_nom_id", SqlDbType.Int).Value = ind_tema_nom_id;
                if (indtnom_consecutivo != -1) con.ObjCommand.Parameters.Add("@indtnom_consecutivo", SqlDbType.Int).Value = indtnom_consecutivo;
                con.ObjCommand.Parameters.Add("@tema_padre_id", SqlDbType.Int).Value = tema_padre_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria;
                con.ObjCommand.Parameters.Add("@indtnom_tipo", SqlDbType.Int).Value = tipo;
                con.ObjCommand.Parameters.Add("@indtnom_estatus", SqlDbType.Int).Value = estatus;

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

        public DataSet IndMedidaPlazo_Consultar(int ind_medida_plazo_id, int imp_consecutivo, int normatividad_id, int version_id = -1, int inspeccion_id = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndMedidaPlazo_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_medida_plazo_id", SqlDbType.Int).Value = ind_medida_plazo_id;
                con.ObjCommand.Parameters.Add("@imp_consecutivo", SqlDbType.Int).Value = imp_consecutivo;
                con.ObjCommand.Parameters.Add("@normatividad_id", SqlDbType.Int).Value = normatividad_id;
                if (version_id != -1)
                    con.ObjCommand.Parameters.Add("@version_id", SqlDbType.Int).Value = version_id;
                if (inspeccion_id != -1)
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
        public DataSet TableroMedidasPlazoDML(int normatividad_id, string sentencia = "SELECT", int ind_medida_plazo_id = -1, int imp_consecutivo = -1, string sys_usr = "", int nvimp_id = -1, string version_descripcion = "", string fecha_de_publicacion = "", int last_normatividad_id = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TableroMedidasPlazoDML", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@normatividad_id", SqlDbType.Int).Value = normatividad_id;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar, 20).Value = sentencia;
                if (ind_medida_plazo_id != -1)
                    con.ObjCommand.Parameters.Add("@ind_medida_plazo_id", SqlDbType.Int).Value = ind_medida_plazo_id;
                if (imp_consecutivo != -1)
                    con.ObjCommand.Parameters.Add("@imp_consecutivo", SqlDbType.Int).Value = imp_consecutivo;
                if (sys_usr != "")
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar, 20).Value = sys_usr;
                if (nvimp_id != -1)
                    con.ObjCommand.Parameters.Add("@nvimp_id", SqlDbType.Int).Value = nvimp_id;
                if (version_descripcion != "")
                    con.ObjCommand.Parameters.Add("@version_descripcion", SqlDbType.VarChar, 400).Value = version_descripcion;
                if (fecha_de_publicacion != "")
                    con.ObjCommand.Parameters.Add("@fecha_de_publicacion", SqlDbType.DateTime).Value = fecha_de_publicacion;
                if (last_normatividad_id != -1)
                    con.ObjCommand.Parameters.Add("@last_normatividad_id", SqlDbType.Int).Value = last_normatividad_id;

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
        public DataSet Inspector_Delegaciones_Obtener()
        {

            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Inspector_Delegaciones_Obtener", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;
            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();


            return objDataSet;
        }

        public DataSet Emplazamiento_Obtener(int inspeccion_comprobacion_id, int inspeccion_origen_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Emplazamiento_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_comprobacion_id", SqlDbType.Int).Value = inspeccion_comprobacion_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

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

        public DataSet Sancion_Obtener(int inspeccion_sancion_id, int inspeccion_origen_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Sancion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_sancion_id", SqlDbType.Int).Value = inspeccion_sancion_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

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

        public DataSet Sancion_Violacion_Obtener(int inspeccion_origen_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Sancion_violacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

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

        public DataSet Emplazamiento_Obtener_TMP_Fecha_Limite()
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Emplazamiento_Obtener_TMP_Fecha_Limite", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

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

        public DataSet Emplazamiento_ObtenerPorDesahogo(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Emplazamiento_ObtenerPorDesahogo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        #region Catalogos Institucionales
        public DataSet ObtenerEstados(int edo)
        {

            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Estados_Obtener", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;
            con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = edo;
            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();


            return objDataSet;
        }
        public DataSet ObtenerMunicipios(int edo, int mun)
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Municipios_Obtener", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;
            con.ObjCommand.Parameters.Add("@cmu_cve_edorep", SqlDbType.Int).Value = edo;
            con.ObjCommand.Parameters.Add("@cmu_cve_municipio", SqlDbType.Int).Value = mun;
            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();


            return objDataSet;
        }
        //*******obtener unidad responsable
        public DataSet UnidadResp_ObtenerConAleatoria(int ur, int edo, int mes, int anio)
        {

            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_UnidadResp_ObtenerConAleatoria", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = ur;
            con.ObjCommand.Parameters.Add("@cur_cve_edorep", SqlDbType.Int).Value = edo;
            con.ObjCommand.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
            con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();


            return objDataSet;
        }
        public DataSet ObtenerUnidadResp(int ur, int edo)
        {

            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_UnidadResp_Obtener", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;
            con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = ur;
            con.ObjCommand.Parameters.Add("@cur_cve_edorep", SqlDbType.Int).Value = edo;
            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();


            return objDataSet;
        }

        //***obtenercamara
        public DataSet Camara_ObtenerPorDescripcion(string cam_camara)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_Camara_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cam_camara", SqlDbType.VarChar).Value = cam_camara;

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

        public DataSet Rama_Industriales()
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_RamaIndustrial_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@rama_industrial_id", SqlDbType.VarChar).Value = "-1";

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




        //*************************
        //*******obtener unidad responsable
        public DataSet AreaSolicitud_Obtener(int ur)
        {

            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_AreaSolicitud_Obtener", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;
            con.ObjCommand.Parameters.Add("@ur", SqlDbType.Int).Value = ur;
            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();


            return objDataSet;
        }


        public DataSet Entidades_ObtenerPorUnidadResponsable(int cur_cve_ur)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Entidades_ObtenerPorUnidadResponsable", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = cur_cve_ur;

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

        public DataSet Entidades_ObtenerPorUnidadResponsable_Buesquedaempresa(int cur_cve_ur, int cen_cve_edorep, string catalogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Entidades_ObtenerPorUnidadResponsable_BusquedaEmpresa", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = cur_cve_ur;
                con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = cen_cve_edorep;
                con.ObjCommand.Parameters.Add("@catalogo", SqlDbType.VarChar).Value = catalogo;

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

        public DataSet Entidades_ObtenerPorUnidadResponsable(int cur_cve_ur, int cen_cve_edorep)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Entidades_ObtenerPorUnidadResponsable", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = cur_cve_ur;
                con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = cen_cve_edorep;

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

        public DataSet UnidadResp_ObtenerURPorEstado(int edo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_UnidadResp_ObtenerURPorEstado", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@edo_id", SqlDbType.Int).Value = edo_id;

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

        public DataSet UnidadResp_ObtenerURPorEstado2(int edo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_UnidadResp_ObtenerURPorEstado2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@edo_id", SqlDbType.Int).Value = edo_id;

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

        public DataSet RamaIndustrial_ObtenerPorID(int crf_cve_rama)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConRemote);
                con.ObjCommand = new SqlCommand("PA_RamasIndustriales_ObtenerRamaPorId", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ramaid", SqlDbType.Int).Value = crf_cve_rama;

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

        public DataSet IMSSActividad_ObtenerPorID(int imss_actividad_id)
        {
            SqlDataAdapter objAdapterRemote = null;
            DataSet objDataSetRemote = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionRemote = new SqlConnection(Constantes.StrConRemote);
                con.ObjCommandRemote = new SqlCommand("PA_IMSSActGrupDiv_ObtenerPorActividadID", con.ObjConnectionRemote);
                con.ObjCommandRemote.CommandType = CommandType.StoredProcedure;

                con.ObjCommandRemote.Parameters.Add("@imss_actividad_id", SqlDbType.Int).Value = imss_actividad_id;

                con.ObjCommandRemote.Connection.Open();
                objAdapterRemote = new SqlDataAdapter(con.ObjCommandRemote);
                objAdapterRemote.Fill(objDataSetRemote, "resultado");

                return objDataSetRemote;
            }
            finally
            {
                con.ObjConnectionRemote.Close();
                objAdapterRemote.Dispose();
                con.ObjCommandRemote.Dispose();
                con.ObjConnectionRemote.Dispose();
            }
        }

        public DataSet ObtenerCatSCIAN(int cae_id)
        {
            SqlDataAdapter objAdapterRemote = null;
            DataSet objDataSetRemote = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionRemote = new SqlConnection(Constantes.StrConRemote);
                con.ObjCommandRemote = new SqlCommand("PA_SCIAN_ObtenerPorID", con.ObjConnectionRemote);
                con.ObjCommandRemote.CommandType = CommandType.StoredProcedure;
                con.ObjCommandRemote.Parameters.Add("@cae_id", SqlDbType.Int).Value = cae_id;

                con.ObjCommandRemote.Connection.Open();
                objAdapterRemote = new SqlDataAdapter(con.ObjCommandRemote);
                objAdapterRemote.Fill(objDataSetRemote, "resultado");

                return objDataSetRemote;
            }
            finally
            {
                con.ObjConnectionRemote.Close();
                objAdapterRemote.Dispose();
                con.ObjCommandRemote.Dispose();
                con.ObjConnectionRemote.Dispose();
            }
        }

        //*******************
        public DataSet ObtenerCatSCIANBusqueda(string cae_clase, string texto)
        {
            SqlDataAdapter objAdapterRemote = null;
            DataSet objDataSetRemote = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionRemote = new SqlConnection(Constantes.StrConRemote);
                con.ObjCommandRemote = new SqlCommand("PA_SCIAN_Busqueda", con.ObjConnectionRemote);
                con.ObjCommandRemote.CommandType = CommandType.StoredProcedure;
                if (!string.IsNullOrEmpty(texto))
                    con.ObjCommandRemote.Parameters.Add("@texto", SqlDbType.VarChar).Value = texto;
                if (!string.IsNullOrEmpty(cae_clase))
                    con.ObjCommandRemote.Parameters.Add("@cae_clase", SqlDbType.VarChar).Value = cae_clase;

                con.ObjCommandRemote.Connection.Open();
                objAdapterRemote = new SqlDataAdapter(con.ObjCommandRemote);
                objAdapterRemote.Fill(objDataSetRemote, "resultado");

                return objDataSetRemote;
            }
            finally
            {
                con.ObjConnectionRemote.Close();
                objAdapterRemote.Dispose();
                con.ObjCommandRemote.Dispose();
                con.ObjConnectionRemote.Dispose();
            }
        }

        public DataSet Sindicato_ObtenerPorDescripcion(string sind_sindicato)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Sindicato_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sind_sindicato", SqlDbType.VarChar).Value = sind_sindicato;

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

        #region Contenido

        public DataSet ObtenerContenido(int infa_tipo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InfoApoyo_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@info_tipo", SqlDbType.Int).Value = infa_tipo;

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

        public List<DtoInfoApoyo> obtener_todos_info_apoyo()
        {
            List<DtoInfoApoyo> ListaInfoApoyo = new List<DtoInfoApoyo>();
            DtoInfoApoyo entidad = null;

            try
            {
                AbrirConexion();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PA_InfoApoyo_Consultar_Todos";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entidad = new DtoInfoApoyo();
                        entidad.info_apoyo_id = int.Parse(dr["info_apoyo_id"].ToString());
                        entidad.descripcion = dr["infa_descripcion"].ToString();
                        entidad.tipo = int.Parse(dr["infa_tipo"].ToString());
                        entidad.url = dr["infa_url"].ToString();
                        entidad.material = dr["infa_material"].ToString();
                        entidad.orden = int.Parse(dr["infa_orden"].ToString());
                        entidad.fecha_actualizacion = DateTime.Parse(dr["fecha_actualizacion"].ToString());
                        entidad.infa_emisor = dr["infa_emisor"].ToString();
                        ListaInfoApoyo.Add(entidad);
                    }
                }

            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "obtener_todos_info_apoyo";
                throw excepcion;
            }
            finally
            {
                CerrarConexion();
            }

            return ListaInfoApoyo;

        }

        public DataSet ObtenerContenidoPorId(int apoyo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InfoApoyo_ConsultarPorID", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@info_apoyo_id", SqlDbType.Int).Value = apoyo_id;

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

        public DataSet ObtenerContenidoPorOrden(int infa_orden, int infa_tipo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InfoApoyo_ConsultarPorOrden", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@infa_orden", SqlDbType.Int).Value = infa_orden;
                con.ObjCommand.Parameters.Add("@infa_tipo", SqlDbType.Int).Value = infa_tipo;

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

        #region Operativos


        public DataSet Operativos_Obtener(int prog_anual_id, int operativo_id, int oper_tipo_operativo, int mes_id, int ur, int panual_estatus, int oper_estatus)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Operativos_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@oper_tipo_operativo", SqlDbType.Int).Value = oper_tipo_operativo;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes_id;
                con.ObjCommand.Parameters.Add("@ur", SqlDbType.Int).Value = ur;
                con.ObjCommand.Parameters.Add("@prog_anual_estatus", SqlDbType.Int).Value = panual_estatus;
                con.ObjCommand.Parameters.Add("@oper_estatus", SqlDbType.Int).Value = oper_estatus;

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

        #region Programación
        public DataSet ProgAtributo2_ObtenerPorID(int Atributo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributo2_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_atributo_id", SqlDbType.Int).Value = Atributo_id;
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
        public DataSet ProgAtributo2SCIAN_ObtenerPorID(int Atributo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributo2SCIAN_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_atributo_id", SqlDbType.Int).Value = Atributo_id;
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

        #region Automatica
        public DataSet ProgramacionAutomatica_ObtenerTablero(int cve_ur, int comprobacionSanciones = 0)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgramacionAutomatica_ObtenerTablero", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@comprobacionSanciones", SqlDbType.Int).Value = comprobacionSanciones;

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

        public DataSet Emplazamiento_ObtenerTablero(int cve_ur, int dias_plazo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Emplazamiento_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@dias_plazo", SqlDbType.Int).Value = dias_plazo;

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

        public DataSet Sancion_ObtenerTablero(int cve_ur, int dias_plazo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Sancion_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@dias_plazo", SqlDbType.Int).Value = dias_plazo;

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

        public DataSet Emplazamiento_ObtenerPorID(int emplazamiento_id, int dias_plazo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Emplazamiento_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento_id;
                con.ObjCommand.Parameters.Add("@dias_plazo", SqlDbType.Int).Value = dias_plazo;
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

        public DataSet Sancion_ObtenerPorID(int sancion_id, int dias_plazo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Sancion_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sancion_id", SqlDbType.Int).Value = sancion_id;
                con.ObjCommand.Parameters.Add("@dias_plazo", SqlDbType.Int).Value = dias_plazo;
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

        public DataSet Emplazamiento_ObtenerMedidasRecorrido(int emplazamiento_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Emplazamiento_ObtenerMedidasRecorrido", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento_id;

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

        public DataSet EmplazamientoNumeral_ObtenerTablero(int emplazamiento_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_EmplazamientoNumeral_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento_id;

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

        public DataSet Reprogramacion_ObtenerTablero(int cve_ur, int dias_plazo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Reprogramacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@dias_plazo", SqlDbType.Int).Value = dias_plazo;

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

        public DataSet Reprogramacion_ObtenerPorID(int reprogramacion_id, int dias_plazo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Reprogramacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@reprogramacion_id", SqlDbType.Int).Value = reprogramacion_id;
                con.ObjCommand.Parameters.Add("@dias_plazo", SqlDbType.Int).Value = dias_plazo;

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

        public void Reprogramacion_Subtipo_Actualizar(int reprogramacion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Reprogramacion_Subtipo_Actualizar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@reprogramacion_id", SqlDbType.Int).Value = reprogramacion_id;

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

        #endregion

        #region DFT
        public DataSet Municipios_ObtenerMunicipiosPorEstadoId(int entidad_id)
        {
            SqlDataAdapter objAdapterRemote;
            DataSet objDataSetRemote = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnectionRemote = new SqlConnection(Constantes.StrConRemote);
            con.ObjCommandRemote = new SqlCommand("PA_Municipios_ObtenerMunicipiosPorEstadoId", con.ObjConnectionRemote);
            con.ObjCommandRemote.CommandType = CommandType.StoredProcedure;
            con.ObjCommandRemote.Parameters.Add("@estadoId", SqlDbType.Int).Value = entidad_id;

            con.ObjCommandRemote.Connection.Open();
            objAdapterRemote = new SqlDataAdapter(con.ObjCommandRemote);
            objAdapterRemote.Fill(objDataSetRemote, "resultado");

            con.ObjConnectionRemote.Close();
            objAdapterRemote.Dispose();
            con.ObjCommandRemote.Dispose();
            con.ObjConnectionRemote.Dispose();

            return objDataSetRemote;
        }

        public DataSet Municipios_ObtenerMunicipio(short entidad_id, short municipio_id)
        {
            SqlDataAdapter objAdapterRemote;
            DataSet objDataSetRemote = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnectionRemote = new SqlConnection(Constantes.StrConRemote);
            con.ObjCommandRemote = new SqlCommand("PA_Municipios_ObtenerMunicipioPorMunIdEdoId", con.ObjConnectionRemote);
            con.ObjCommandRemote.CommandType = CommandType.StoredProcedure;
            con.ObjCommandRemote.Parameters.Add("@idmun", SqlDbType.Int).Value = municipio_id;
            con.ObjCommandRemote.Parameters.Add("@idedo", SqlDbType.Int).Value = entidad_id;

            con.ObjCommandRemote.Connection.Open();
            objAdapterRemote = new SqlDataAdapter(con.ObjCommandRemote);
            objAdapterRemote.Fill(objDataSetRemote, "resultado");

            con.ObjConnectionRemote.Close();
            objAdapterRemote.Dispose();
            con.ObjCommandRemote.Dispose();
            con.ObjConnectionRemote.Dispose();

            return objDataSetRemote;
        }

        //**************
        public DataSet Municipios_ObtenerOtro(int entidad_id, int municipio_id)
        {
            SqlDataAdapter objAdapterRemote;
            DataSet objDataSetRemote = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnectionRemote = new SqlConnection(Constantes.StrConRemote);
            con.ObjCommandRemote = new SqlCommand("PA_Municipios_Obtener", con.ObjConnectionRemote);
            con.ObjCommandRemote.CommandType = CommandType.StoredProcedure;
            con.ObjCommandRemote.Parameters.Add("@cmu_cve_municipio", SqlDbType.Int).Value = municipio_id;
            con.ObjCommandRemote.Parameters.Add("@cmu_cve_edorep", SqlDbType.Int).Value = entidad_id;

            con.ObjCommandRemote.Connection.Open();
            objAdapterRemote = new SqlDataAdapter(con.ObjCommandRemote);
            objAdapterRemote.Fill(objDataSetRemote, "resultado");

            con.ObjConnectionRemote.Close();
            objAdapterRemote.Dispose();
            con.ObjCommandRemote.Dispose();
            con.ObjConnectionRemote.Dispose();

            return objDataSetRemote;
        }

        //*********
        public DataSet MotivosNoEntrega_Obtener(int motivo_id)
        {
            SqlDataAdapter objAdapterRemote;
            DataSet objDataSetRemote = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnectionRemote = new SqlConnection(Constantes.StrCon);
            con.ObjCommandRemote = new SqlCommand("PA_MotivosNoEntrega_Obtener", con.ObjConnectionRemote);
            con.ObjCommandRemote.CommandType = CommandType.StoredProcedure;
            con.ObjCommandRemote.Parameters.Add("@motivo_no_entrega_id", SqlDbType.Int).Value = motivo_id;


            con.ObjCommandRemote.Connection.Open();
            objAdapterRemote = new SqlDataAdapter(con.ObjCommandRemote);
            objAdapterRemote.Fill(objDataSetRemote, "resultado");

            con.ObjConnectionRemote.Close();
            objAdapterRemote.Dispose();
            con.ObjCommandRemote.Dispose();
            con.ObjConnectionRemote.Dispose();

            return objDataSetRemote;
        }
        public DataSet SeguridadSocialObtener()
        {
            SqlDataAdapter objAdapterRemote = null;
            DataSet objDataSetRemote = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionRemote = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommandRemote = new SqlCommand("PA_SeguridadSocialObtener", con.ObjConnectionRemote);
                con.ObjCommandRemote.CommandType = CommandType.StoredProcedure;


                con.ObjCommandRemote.Connection.Open();
                objAdapterRemote = new SqlDataAdapter(con.ObjCommandRemote);
                objAdapterRemote.Fill(objDataSetRemote, "resultado");

                return objDataSetRemote;
            }
            finally
            {
                con.ObjConnectionRemote.Close();
                objAdapterRemote.Dispose();
                con.ObjCommandRemote.Dispose();
                con.ObjConnectionRemote.Dispose();
            }
        }

        public DataSet Entidades_ObtenerTodasEntidades()
        {
            SqlDataAdapter objAdapterRemote;
            DataSet objDataSetRemote = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnectionRemote = new SqlConnection(Constantes.StrConRemote);
            con.ObjCommandRemote = new SqlCommand("PA_Entidades_ObtenerTodasEntidades", con.ObjConnectionRemote);
            con.ObjCommandRemote.CommandType = CommandType.StoredProcedure;

            con.ObjCommandRemote.Connection.Open();
            objAdapterRemote = new SqlDataAdapter(con.ObjCommandRemote);
            objAdapterRemote.Fill(objDataSetRemote, "resultado");

            con.ObjConnectionRemote.Close();
            objAdapterRemote.Dispose();
            con.ObjCommandRemote.Dispose();
            con.ObjConnectionRemote.Dispose();

            return objDataSetRemote;
        }

        public DataSet Entidades_ObtenerPorId(short entidad_id)
        {
            SqlDataAdapter objAdapterRemote;
            DataSet objDataSetRemote = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnectionRemote = new SqlConnection(Constantes.StrConRemote);
            con.ObjCommandRemote = new SqlCommand("PA_Entidades_ObtenerEntidadesPorId", con.ObjConnectionRemote);
            con.ObjCommandRemote.CommandType = CommandType.StoredProcedure;
            con.ObjCommandRemote.Parameters.Add("@entid", SqlDbType.Int).Value = entidad_id;

            con.ObjCommandRemote.Connection.Open();
            objAdapterRemote = new SqlDataAdapter(con.ObjCommandRemote);
            objAdapterRemote.Fill(objDataSetRemote, "resultado");

            con.ObjConnectionRemote.Close();
            objAdapterRemote.Dispose();
            con.ObjCommandRemote.Dispose();
            con.ObjConnectionRemote.Dispose();

            return objDataSetRemote;
        }

        public DataSet Empresa_Buscar(DtoBusqueda dtoBusqueda)
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_Empresa_Buscar", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;
            if (!string.IsNullOrEmpty(dtoBusqueda.nombre))
                con.ObjCommand.Parameters.Add("@emp_nombre", SqlDbType.VarChar).Value = dtoBusqueda.nombre;
            if (!string.IsNullOrEmpty(dtoBusqueda.rfc) && string.IsNullOrEmpty(dtoBusqueda.rfc_corto))
                con.ObjCommand.Parameters.Add("@emp_rfc", SqlDbType.VarChar).Value = dtoBusqueda.rfc;
            if (!string.IsNullOrEmpty(dtoBusqueda.rfc_corto))
                con.ObjCommand.Parameters.Add("@emp_rfc_corto", SqlDbType.VarChar).Value = dtoBusqueda.rfc_corto;
            if (!string.IsNullOrEmpty(dtoBusqueda.registro_patronal))
                con.ObjCommand.Parameters.Add("@ct_imss_registro", SqlDbType.VarChar).Value = dtoBusqueda.registro_patronal;
            if (!string.IsNullOrEmpty(dtoBusqueda.calle))
                con.ObjCommand.Parameters.Add("@ct_calle", SqlDbType.VarChar).Value = dtoBusqueda.calle;
            if (dtoBusqueda.entidad_federativa != -1)
                con.ObjCommand.Parameters.Add("@ct_cve_edorep", SqlDbType.VarChar).Value = dtoBusqueda.entidad_federativa;
            if (dtoBusqueda.municipio != -1)
                con.ObjCommand.Parameters.Add("@ct_cve_municipio", SqlDbType.VarChar).Value = dtoBusqueda.municipio;
            if (!string.IsNullOrEmpty(dtoBusqueda.cp))
                con.ObjCommand.Parameters.Add("@ct_cp", SqlDbType.VarChar).Value = dtoBusqueda.cp;
            if (dtoBusqueda.jurisdiccion > 0)
                con.ObjCommand.Parameters.Add("@ct_jurisdiccion", SqlDbType.VarChar).Value = dtoBusqueda.jurisdiccion;
            //if (dtoBusqueda.tipo_de_alta != -1)
            //    con.ObjCommand.Parameters.Add("@ct_tipo_alta", SqlDbType.VarChar).Value = dtoBusqueda.tipo_de_alta;
            //if (dtoBusqueda.estatus != -1)
            //    con.ObjCommand.Parameters.Add("@ct_estatus", SqlDbType.VarChar).Value = dtoBusqueda.estatus;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();

            return objDataSet;
        }

        public DataSet Empresa_Buscar2(DtoDFT dtoDFT)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Empresa_Buscar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.nombre))
                    con.ObjCommand.Parameters.Add("@emp_nombre", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.nombre;
                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.rfc) && string.IsNullOrEmpty(dtoDFT.dtoBusqueda.rfc_corto))
                    con.ObjCommand.Parameters.Add("@emp_rfc", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.rfc;
                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.rfc_corto))
                    con.ObjCommand.Parameters.Add("@emp_rfc_corto", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.rfc_corto;
                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.registro_patronal))
                    con.ObjCommand.Parameters.Add("@ct_imss_registro", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.registro_patronal;
                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.calle))
                    con.ObjCommand.Parameters.Add("@ct_calle", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.calle;
                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.cp))
                    con.ObjCommand.Parameters.Add("@ct_cp", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.cp;

                if (dtoDFT.dtoBusqueda.ct_entidad != -1)
                    con.ObjCommand.Parameters.Add("@ct_cve_edorep", SqlDbType.Int).Value = dtoDFT.dtoBusqueda.ct_entidad;
                if (dtoDFT.dtoBusqueda.ct_municipio != -1)
                    con.ObjCommand.Parameters.Add("@ct_cve_municipio", SqlDbType.Int).Value = dtoDFT.dtoBusqueda.ct_municipio;
                if (dtoDFT.dtoBusqueda.jurisdiccion > 0)
                    con.ObjCommand.Parameters.Add("@ct_jurisdiccion", SqlDbType.Int).Value = dtoDFT.dtoBusqueda.jurisdiccion;
                //if (dtoDFT.dtoBusqueda.tipo_de_alta != -1)
                //    con.ObjCommand.Parameters.Add("@ct_tipo_alta", SqlDbType.Int).Value = dtoDFT.dtoBusqueda.tipo_de_alta;
                //if (dtoDFT.dtoBusqueda.estatus != -1)
                //    con.ObjCommand.Parameters.Add("@ct_estatus", SqlDbType.Int).Value = dtoDFT.dtoBusqueda.estatus;

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

        public DataSet InspecParticipante_ObtenerPorTipo(int es_inspector, int es_notif, int es_firma, int cve_ur, string usr_estatus = null)
        {

            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecParticipante_ObtenerPorTipo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@par_es_inspector", SqlDbType.Int).Value = es_inspector;
                con.ObjCommand.Parameters.Add("@par_es_notificador", SqlDbType.Int).Value = es_notif;
                con.ObjCommand.Parameters.Add("@par_es_firmante", SqlDbType.Int).Value = es_firma;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@usr_estatus", SqlDbType.VarChar).Value = usr_estatus;

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

        public DataSet DFTObtenerDocumento()
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_DFTObtenerDocumento", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;
            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();


            return objDataSet;
        }

        public DataSet Notificacion_Obtener(int notificacion_id, int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Notificacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@notificacion_id", SqlDbType.Int).Value = notificacion_id;
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

        public DataSet Notificacion_ObtenerPorEtapa(int inspeccion_id, int etapa)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Notificacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@etapa", SqlDbType.Int).Value = etapa;
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

        public DataSet FormaConstatacion_Obtener()
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_FormaConstatacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
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
        //***********************************
        public DataSet SubmateriaAlcanceIndicador_Obtener(int inspeccion_id, int submateria_id, int indicador_id, int incluye_docto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaAlcanceIndicador_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@ind_se_incluye_en_docto", SqlDbType.Int).Value = incluye_docto;

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
        //***********
        public DataSet SubmateriaIndicador_ObtenerParaDocto(int inspeccion_id, int submateria_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaIndicador_ObtenerParaDocto", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;

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
        //**************************
        public DataSet SubmateriaIndicador_ObtenerParaDoctoConOperativo(int inspeccion_id, int submateria_id, int operativo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaIndicador_ObtenerParaDoctoConOperativo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo;

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
        //-----------
        public DataSet MedidaAlcanceIndicador_Obtener(int inspeccion_id, int submateria_id, int indicador_id, int medida_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidaAlcanceIndicador_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@medida_id", SqlDbType.Int).Value = medida_id;
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


        public DataSet NotifOtraActuacion_Obtener(int notif_id, int ur1, int ur, int mun, int edo, int forma, int estatus, int estatusentrega, string fechaini, string fechafin, int inspector, string no_solicitud, string razon_social)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_NotifOtraActuacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@notif_otra_actuacion_id", SqlDbType.Int).Value = notif_id;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = ur1;
                con.ObjCommand.Parameters.Add("@cve_ur_solicita", SqlDbType.Int).Value = ur;
                con.ObjCommand.Parameters.Add("@notifoa_cve_municipio", SqlDbType.Int).Value = mun;
                con.ObjCommand.Parameters.Add("@notifoa_cve_edorep", SqlDbType.Int).Value = edo;
                con.ObjCommand.Parameters.Add("@notifoa_forma_entrega", SqlDbType.Int).Value = forma;
                con.ObjCommand.Parameters.Add("@notifoa_estatus_asignacion", SqlDbType.Int).Value = estatus;
                con.ObjCommand.Parameters.Add("@notifoa_estatus_entrega", SqlDbType.Int).Value = estatusentrega;
                con.ObjCommand.Parameters.Add("@inspector", SqlDbType.Int).Value = inspector;
                if (no_solicitud != "")
                    con.ObjCommand.Parameters.Add("@no_solicitud", SqlDbType.VarChar).Value = no_solicitud;
                if (razon_social != "")
                    con.ObjCommand.Parameters.Add("@razon_social", SqlDbType.VarChar).Value = razon_social;
                if (fechaini != "")
                    con.ObjCommand.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaini;
                if (fechafin != "")
                    con.ObjCommand.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechafin;

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

        #region DNE
        public DataSet Centro_Buscar2(DtoDFT dtoDFT)
        {
            SqlDataAdapter objAdapterDNE = null;
            DataSet objDataSetDNE = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionDNE = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommandDNE = new SqlCommand("PA_CentroTrabajo_Buscar", con.ObjConnectionDNE);
                con.ObjCommandDNE.CommandType = CommandType.StoredProcedure;

                if (dtoDFT.centro_trabajo_id != -1)
                    con.ObjCommandDNE.Parameters.Add("@empresa_id", SqlDbType.Int).Value = dtoDFT.centro_trabajo_id;

                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.nombre))
                    con.ObjCommandDNE.Parameters.Add("@emp_nombre", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.nombre;
                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.rfc) && string.IsNullOrEmpty(dtoDFT.dtoBusqueda.rfc_corto))
                    con.ObjCommandDNE.Parameters.Add("@emp_rfc", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.rfc;
                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.rfc_corto))
                    con.ObjCommandDNE.Parameters.Add("@emp_rfc_corto", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.rfc_corto;
                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.registro_patronal))
                    con.ObjCommandDNE.Parameters.Add("@ct_imss_registro", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.registro_patronal;
                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.calle))
                    con.ObjCommandDNE.Parameters.Add("@ct_calle", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.calle;
                if (!string.IsNullOrEmpty(dtoDFT.dtoBusqueda.cp))
                    con.ObjCommandDNE.Parameters.Add("@ct_cp", SqlDbType.VarChar).Value = dtoDFT.dtoBusqueda.cp;

                if (dtoDFT.dtoBusqueda.ct_entidad != -1)
                    con.ObjCommandDNE.Parameters.Add("@ct_cve_edorep", SqlDbType.Int).Value = dtoDFT.dtoBusqueda.ct_entidad;
                if (dtoDFT.dtoBusqueda.ct_municipio != -1)
                    con.ObjCommandDNE.Parameters.Add("@ct_cve_municipio", SqlDbType.Int).Value = dtoDFT.dtoBusqueda.ct_municipio;
                if (dtoDFT.dtoBusqueda.jurisdiccion > 0)
                    con.ObjCommandDNE.Parameters.Add("@ct_jurisdiccion", SqlDbType.Int).Value = dtoDFT.dtoBusqueda.jurisdiccion;
                if (dtoDFT.dtoBusqueda.tipo_de_alta != -1)
                    con.ObjCommandDNE.Parameters.Add("@ct_tipo_alta", SqlDbType.Int).Value = dtoDFT.dtoBusqueda.tipo_de_alta;
                if (dtoDFT.dtoBusqueda.estatus != -1)
                    con.ObjCommandDNE.Parameters.Add("@ct_estatus", SqlDbType.Int).Value = dtoDFT.dtoBusqueda.estatus;

                con.ObjCommandDNE.Connection.Open();
                objAdapterDNE = new SqlDataAdapter(con.ObjCommandDNE);
                objAdapterDNE.Fill(objDataSetDNE, "resultado");
                return objDataSetDNE;


            }
            finally
            {
                con.ObjConnectionDNE.Close();
                objAdapterDNE.Dispose();
                con.ObjCommandDNE.Dispose();
                con.ObjConnectionDNE.Dispose(); ;
            }
        }

        public DataSet Centro_Buscar3(DtoBusqueda dtoBusqueda)
        {
            SqlDataAdapter objAdapterDNE = null;
            DataSet objDataSetDNE = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionDNE = new SqlConnection(Constantes.StrCon);
                con.ObjCommandDNE = new SqlCommand("PA_CentroTrabajo_Buscar", con.ObjConnectionDNE);
                con.ObjCommandDNE.CommandType = CommandType.StoredProcedure;

                if (!string.IsNullOrEmpty(dtoBusqueda.nombre))
                    con.ObjCommandDNE.Parameters.Add("@emp_nombre", SqlDbType.VarChar).Value = dtoBusqueda.nombre;
                if (!string.IsNullOrEmpty(dtoBusqueda.rfc) && string.IsNullOrEmpty(dtoBusqueda.rfc_corto))
                    con.ObjCommandDNE.Parameters.Add("@emp_rfc", SqlDbType.VarChar).Value = dtoBusqueda.rfc;
                if (!string.IsNullOrEmpty(dtoBusqueda.rfc_corto))
                    con.ObjCommandDNE.Parameters.Add("@emp_rfc_corto", SqlDbType.VarChar).Value = dtoBusqueda.rfc_corto;
                //if (!string.IsNullOrEmpty(dtoBusqueda.nombre))
                //    con.ObjCommandDNE.Parameters.Add("@ct_nombre", SqlDbType.VarChar).Value = dtoBusqueda.nombre;
                if (!string.IsNullOrEmpty(dtoBusqueda.registro_patronal))
                    con.ObjCommandDNE.Parameters.Add("@ct_imss_registro", SqlDbType.VarChar).Value = dtoBusqueda.registro_patronal;
                if (!string.IsNullOrEmpty(dtoBusqueda.calle))
                    con.ObjCommandDNE.Parameters.Add("@ct_calle", SqlDbType.VarChar).Value = dtoBusqueda.calle;
                if (!string.IsNullOrEmpty(dtoBusqueda.cp))
                    con.ObjCommandDNE.Parameters.Add("@ct_cp", SqlDbType.VarChar).Value = dtoBusqueda.cp;

                if (dtoBusqueda.ct_entidad != -1)
                    con.ObjCommandDNE.Parameters.Add("@ct_cve_edorep", SqlDbType.Int).Value = dtoBusqueda.ct_entidad;
                if (dtoBusqueda.ct_municipio != -1)
                    con.ObjCommandDNE.Parameters.Add("@ct_cve_municipio", SqlDbType.Int).Value = dtoBusqueda.ct_municipio;
                if (dtoBusqueda.estatus != -1)
                    con.ObjCommandDNE.Parameters.Add("@ct_estatus", SqlDbType.Int).Value = dtoBusqueda.estatus;

                con.ObjCommandDNE.Connection.Open();
                objAdapterDNE = new SqlDataAdapter(con.ObjCommandDNE);
                objAdapterDNE.Fill(objDataSetDNE, "resultado");

                return objDataSetDNE;
            }
            finally
            {
                con.ObjConnectionDNE.Close();
                objAdapterDNE.Dispose();
                con.ObjCommandDNE.Dispose();
                con.ObjConnectionDNE.Dispose();
            }
        }

        public DataSet Empresa_UltimasInspecciones_Obtener(DtoDFT dtoDFT)
        {
            SqlDataAdapter objAdapterDNE = null;
            DataSet objDataSetDNE = new DataSet();
            Constantes con = new Constantes();
            string StoreProcedure = string.Empty;
            try
            {

                con.ObjConnectionDNE = new SqlConnection(Constantes.StrCon);
                con.ObjCommandDNE = new SqlCommand("PA_Programacion_Empresa_UltimasInspecciones", con.ObjConnectionDNE);
                con.ObjCommandDNE.CommandType = CommandType.StoredProcedure;

                if (dtoDFT.empresa_id != -1) con.ObjCommandDNE.Parameters.Add("@empresa_id", SqlDbType.Int).Value = dtoDFT.empresa_id;
                if (dtoDFT.cve_ur != -1) con.ObjCommandDNE.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = dtoDFT.cve_ur;
                if (dtoDFT.centro_trabajo_id != -1) con.ObjCommandDNE.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = dtoDFT.centro_trabajo_id;

                con.ObjCommandDNE.Connection.Open();
                objAdapterDNE = new SqlDataAdapter(con.ObjCommandDNE);
                objAdapterDNE.Fill(objDataSetDNE, "resultado");
                return objDataSetDNE;
            }
            finally
            {
                con.ObjConnectionDNE.Close();
                objAdapterDNE.Dispose();
                con.ObjCommandDNE.Dispose();
                con.ObjConnectionDNE.Dispose();
            }
        }



        public DataSet Programacion_Empresa_Buscar(string emp_nombre, string emp_rfc, int cve_edorep, int cve_municipio, int estatus, string ramaindustrial)
        {
            SqlDataAdapter objAdapterDNE = null;
            DataSet objDataSetDNE = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionDNE = new SqlConnection(Constantes.StrCon);
                con.ObjCommandDNE = new SqlCommand("PA_Programacion_Empresa_Buscar", con.ObjConnectionDNE);
                con.ObjCommandDNE.CommandType = CommandType.StoredProcedure;

                if (!emp_nombre.Trim().Equals("")) con.ObjCommandDNE.Parameters.Add("@emp_nombre", SqlDbType.VarChar).Value = emp_nombre;
                if (!emp_rfc.Trim().Equals("")) con.ObjCommandDNE.Parameters.Add("@emp_rfc", SqlDbType.VarChar).Value = emp_rfc;
                if (cve_edorep != -1) con.ObjCommandDNE.Parameters.Add("@ct_cve_edorep", SqlDbType.Int).Value = cve_edorep;
                if (cve_municipio != -1) con.ObjCommandDNE.Parameters.Add("@ct_cve_municipio", SqlDbType.Int).Value = cve_municipio;
                if (estatus != -1) con.ObjCommandDNE.Parameters.Add("@ct_estatus", SqlDbType.Int).Value = estatus;
                if (!ramaindustrial.Trim().Equals("")) con.ObjCommandDNE.Parameters.Add("@rama_industrial_id", SqlDbType.VarChar).Value = ramaindustrial;

                con.ObjCommandDNE.Connection.Open();
                objAdapterDNE = new SqlDataAdapter(con.ObjCommandDNE);
                objAdapterDNE.Fill(objDataSetDNE, "resultado");
                return objDataSetDNE;
            }
            finally
            {
                con.ObjConnectionDNE.Close();
                objAdapterDNE.Dispose();
                con.ObjCommandDNE.Dispose();
                con.ObjConnectionDNE.Dispose();
            }
        }

        public DataSet CentroTrabajo_PorEmmpresaId_Buscar(int empresa_id, int cve_edorep, string domicilio)
        {
            SqlDataAdapter objAdapterDNE = null;
            DataSet objDataSetDNE = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionDNE = new SqlConnection(Constantes.StrCon);
                con.ObjCommandDNE = new SqlCommand("PA_CentroTrabajo_PorEmpresa_Buscar", con.ObjConnectionDNE);
                con.ObjCommandDNE.CommandType = CommandType.StoredProcedure;
                if (empresa_id != -1) con.ObjCommandDNE.Parameters.Add("@empresa_id", SqlDbType.Int).Value = empresa_id;
                if (cve_edorep != -1) con.ObjCommandDNE.Parameters.Add("@ct_cve_edorep", SqlDbType.Int).Value = cve_edorep;
                if (!domicilio.Trim().Equals("")) con.ObjCommandDNE.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = domicilio;

                con.ObjCommandDNE.Connection.Open();
                objAdapterDNE = new SqlDataAdapter(con.ObjCommandDNE);
                objAdapterDNE.Fill(objDataSetDNE, "resultado");
                return objDataSetDNE;
            }
            finally
            {
                con.ObjConnectionDNE.Close();
                objAdapterDNE.Dispose();
                con.ObjCommandDNE.Dispose();
                con.ObjConnectionDNE.Dispose();
            }




        }

        public DataSet CentroTrabajo_Buscar(string emp_nombre, string emp_rfc, int cve_edorep, int estatus)
        {
            SqlDataAdapter objAdapterDNE = null;
            DataSet objDataSetDNE = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionDNE = new SqlConnection(Constantes.StrCon);
                con.ObjCommandDNE = new SqlCommand("PA_CentroTrabajo_Buscar", con.ObjConnectionDNE);
                con.ObjCommandDNE.CommandType = CommandType.StoredProcedure;

                if (!emp_nombre.Trim().Equals("")) con.ObjCommandDNE.Parameters.Add("@emp_nombre", SqlDbType.VarChar).Value = emp_nombre;
                if (!emp_rfc.Trim().Equals("")) con.ObjCommandDNE.Parameters.Add("@emp_rfc", SqlDbType.VarChar).Value = emp_rfc;
                if (cve_edorep != -1) con.ObjCommandDNE.Parameters.Add("@ct_cve_edorep", SqlDbType.Int).Value = cve_edorep;
                if (estatus != -1) con.ObjCommandDNE.Parameters.Add("@ct_estatus", SqlDbType.Int).Value = estatus;

                con.ObjCommandDNE.Connection.Open();
                objAdapterDNE = new SqlDataAdapter(con.ObjCommandDNE);
                objAdapterDNE.Fill(objDataSetDNE, "resultado");
                return objDataSetDNE;
            }
            finally
            {
                con.ObjConnectionDNE.Close();
                objAdapterDNE.Dispose();
                con.ObjCommandDNE.Dispose();
                con.ObjConnectionDNE.Dispose();
            }




        }

        public DataSet CentroTrabajo_ObtenerDatosPorID(int centro_trabajo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionDNE = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommandDNE = new SqlCommand("PA_CentroTrabajo_ObtenerDatosPorID2", con.ObjConnectionDNE);
                con.ObjCommandDNE.CommandType = CommandType.StoredProcedure;

                con.ObjCommandDNE.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;
                //con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;

                con.ObjCommandDNE.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommandDNE);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;
            }
            finally
            {
                con.ObjConnectionDNE.Close();
                objAdapter.Dispose();
                con.ObjCommandDNE.Dispose();
                con.ObjConnectionDNE.Dispose();
            }
        }

        public DataSet EmpresaSolidaria_ObtenerPorCentroID(int centro_trabajo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnectionDNE = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommandDNE = new SqlCommand("PA_EmpresaSolidaria_Obtener", con.ObjConnectionDNE);
                con.ObjCommandDNE.CommandType = CommandType.StoredProcedure;

                con.ObjCommandDNE.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;

                con.ObjCommandDNE.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommandDNE);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;
            }
            finally
            {
                con.ObjConnectionDNE.Close();
                objAdapter.Dispose();
                con.ObjCommandDNE.Dispose();
                con.ObjConnectionDNE.Dispose();
            }
        }

        public DataSet Empresa_ConsultarPorId(int empresa_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionDNE = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommandDNE = new SqlCommand("PA_Empresa_ObtenerDatosPorID", con.ObjConnectionDNE);
                con.ObjCommandDNE.CommandType = CommandType.StoredProcedure;
                con.ObjCommandDNE.Parameters.Add("@empresa_id", SqlDbType.Int).Value = empresa_id;

                con.ObjCommandDNE.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommandDNE);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;
            }
            finally
            {
                con.ObjConnectionDNE.Close();
                objAdapter.Dispose();
                con.ObjCommandDNE.Dispose();
                con.ObjConnectionDNE.Dispose();
            }
        }

        public DataSet CentroTrabajo_ConsultarPorId(int centro_trabajo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnectionDNE = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommandDNE = new SqlCommand("PA_CentroTrabajo_ConsultarPorId", con.ObjConnectionDNE);
                con.ObjCommandDNE.CommandType = CommandType.StoredProcedure;
                con.ObjCommandDNE.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;

                con.ObjCommandDNE.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommandDNE);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;
            }
            finally
            {
                con.ObjConnectionDNE.Close();
                objAdapter.Dispose();
                con.ObjCommandDNE.Dispose();
                con.ObjConnectionDNE.Dispose();
            }
        }

        public DataSet CentroCamara_ObtenerPorCentroID(int centro_trabajo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_CentroCamara_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;

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



        public DataSet CentroSindicato_ObtenerPorCentroID(int centro_trabajo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_CentroSindicato_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;

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

        #region Desahogo

        public DataSet TablaProcesoAC_Obtener(int desahogo_id, int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaProcesoAC_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
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

        public bool Dshgo_Participantes_ConsultarEstado(int inspeccion_id, int desahogo_id, int tipo_documento, int materia_id)
        {
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            int resultado;
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Participantes_ConsultarEstado", con.ObjConnection);
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@tipo_documento", SqlDbType.Int).Value = tipo_documento;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Connection.Open();
                resultado = Convert.ToInt32(con.ObjCommand.ExecuteScalar());
                return (resultado == 1);

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public DataSet TipoRep_ConsultarporID(int TipoRep_ID, int dsecc_en_oficio, int trep_de_empresa)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TipoRep_ConsultarporID", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@tipo_representante_id", SqlDbType.Int).Value = TipoRep_ID;
                con.ObjCommand.Parameters.Add("@dsecc_en_oficio", SqlDbType.Int).Value = dsecc_en_oficio;
                con.ObjCommand.Parameters.Add("@trep_de_empresa", SqlDbType.Int).Value = trep_de_empresa;
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

        public DataSet Dshgo_Testigos_Consultar(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Testigo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DesahogoInstalacion_Obtener(int dshgo_instalacion_id, int desahogo_id, int tipo_instalacion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DesahogoInstalacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_instalacion_id", SqlDbType.Int).Value = dshgo_instalacion_id;
                con.ObjCommand.Parameters.Add("@desahogo_id ", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@tipo_instalacion_id", SqlDbType.Int).Value = tipo_instalacion_id;

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

        public DataSet DshgoCentroCamara_Obtener(DtoDshgoCentroCamara dshgocamara)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoCentroCamara_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_centro_camara_id", SqlDbType.Int).Value = dshgocamara.dshgo_centro_camara_id;
                con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id ", SqlDbType.Int).Value = dshgocamara.dshgo_centro_trabajo_id;
                con.ObjCommand.Parameters.Add("@dcc_dne_camara_id", SqlDbType.Int).Value = dshgocamara.dcc_dne_camara_id;

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

        public DataSet TipoID_ConsultarporID(int TipoID_ID)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TipoID_ConsultarporID", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@tipo_identificacion_id", SqlDbType.Int).Value = TipoID_ID;
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

        public DataSet DshgoMotivoInforme_Obtener(int desahogo_id, int motivo_informe_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMotivoInforme_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@motivo_informe_id", SqlDbType.Int).Value = motivo_informe_id;

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

        public DataSet Desahogo_Obtener(DtoDesahogo dtoD)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Desahogo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = dtoD.desahogo_id;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = dtoD.inspeccion_id;

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

        public DataSet ObtenerFechasExpediente(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtenerFechasExpediente", con.ObjConnection);
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
        public DataSet Calificacion_Expediente_Obtener(int inspeccion_id, int calificacion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Calificacion_Expediente_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;

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

        public DataSet TipoEstablecimiento_Obtener(int id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TipoEstablecimiento_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@tipo_establecimiento_id", SqlDbType.Int).Value = id;

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

        public DataSet TipoInstalacion_Obtener(int id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TipoInstalacion_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@tipo_instalacion_id", SqlDbType.Int).Value = id;

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

        public DataSet DshgoCentroTrabajo_Obtener(DtoDshgoCentroTrabajo DtoCT)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoCentroTrabajo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DtoCT.desahogo_id;
                con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = DtoCT.dshgo_centro_trabajo_id;
                con.ObjCommand.Parameters.Add("@dct_cae_id", SqlDbType.Int).Value = DtoCT.dct_cae_id;
                con.ObjCommand.Parameters.Add("@dct_dne_centro_trabajo_id", SqlDbType.Int).Value = DtoCT.dct_dne_centro_trabajo_id;

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

        public DataSet DshgoDomicilioFiscal_Obtener(DtoDshgoDomicilioFiscal DtoDF)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDomicilioFiscal_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_domicilio_fiscal_id", SqlDbType.Int).Value = DtoDF.dshgo_domicilio_fiscal_id;
                con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = DtoDF.dshgo_centro_trabajo_id;
                con.ObjCommand.Parameters.Add("@dne_centro_trabajo_id", SqlDbType.Int).Value = DtoDF.dne_centro_trabajo_id;

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

        public DataSet MotivoInforme_Obtener()
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoInforme_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

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

        public DataSet dshgoSeccion_ObtenerTablero(DtodshgoTablero tablero)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_dshgoSeccion_ObtenerTablero", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = tablero.desahogo_id;
                con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = tablero.subtipo_inspeccion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = tablero.materia_id;
                con.ObjCommand.Parameters.Add("@dsecc_en_oficio", SqlDbType.Int).Value = tablero.dsecc_en_oficio;
                con.ObjCommand.Parameters.Add("@dsecc_en_acta", SqlDbType.Int).Value = tablero.dsecc_en_acta;
                con.ObjCommand.Parameters.Add("@dsecc_en_negativa", SqlDbType.Int).Value = tablero.dsecc_en_negativa;
                con.ObjCommand.Parameters.Add("@dsecc_orden", SqlDbType.Int).Value = tablero.dsecc_orden;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = tablero.inspeccion_id;
                con.ObjCommand.Parameters.Add("@dsecc_seccion", SqlDbType.VarChar).Value = tablero.dsecc_seccion;

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

        public DataSet Dshgo_RepEmpresa_Obtener2(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_RepEmpresa_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (desahogo_id != -1) con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        //****
        public DataSet Dshgo_RepEmpresa_ObtenerPorTipo(int desahogo_id, int tipo_representante_id, int dshgo_rep_empresa_id, int dshgo_participante_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_RepEmpresa_ObtenerPorTipo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@dshgo_rep_empresa_id", SqlDbType.Int).Value = dshgo_rep_empresa_id;
                con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = dshgo_participante_id;
                con.ObjCommand.Parameters.Add("@tipo_representante_id", SqlDbType.Int).Value = tipo_representante_id;

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
        public DataSet Dshgo_Comision_Obtener(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Comision_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (desahogo_id != -1) con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet Dshgo_RepTrabajador_Obtener2(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_RepTrabajador_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (desahogo_id != -1) con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoExperto_Obtener(int inspeccion_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Experto_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                if (desahogo_id != -1) con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet TablaExperto_Obtener(int inspeccion_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaExperto_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                if (desahogo_id != -1) con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet Dshgo_Inspectores_Obtener(int inspeccion_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Inspectores_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        //sacar inspectores participantes en el desahogo
        public DataSet DshgoParticipanteInspectores_Obtener(int dshgo_participante_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoParticipanteInspectores_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = dshgo_participante_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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
        public DataSet Dshgo_Sindicato_Obtener(int dshgo_sindicato_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Sindicato_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_sindicato_id", SqlDbType.Int).Value = dshgo_sindicato_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet Dshgo_Area_Obtener(int dsgo_area_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Area_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dsgo_area_id", SqlDbType.Int).Value = dsgo_area_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoAlcance_Obtener(int inspeccion_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoAlcance_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet Dshgo_Trabajador_Detalle_Tabla(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Trabajador_Detalle_Tabla", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoParticipantes_Obtener(int dshgo_participante_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoParticipante_Obtener", con.ObjConnection);
                con.ObjCommand.CommandTimeout = 250;
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = dshgo_participante_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoParticipante_ObtenerParaCierre(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoParticipante_ObtenerParaCierre", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoParticipantes_ObtenerPorTipo(int desahogo_id, int dpart_tipo_participante)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoParticipante_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dpart_tipo_participante", SqlDbType.Int).Value = dpart_tipo_participante;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        //*****************
        public DataSet DshgoParticipante_Obtener_porTipo2(int desahogo_id, int dpart_tipo_participante)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoParticipante_Obtener_porTipo2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dpart_tipo_participante", SqlDbType.Int).Value = dpart_tipo_participante;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoTrabajadores_ObtenerTablero(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Trabajador_ObtenerTablero", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoTrabajadores_ObtenerTablero2(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Trabajador_ObtenerTablero2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoTrabajadoresDetalle_ObtenerPorID(int dshgo_trabajador_det_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Trabajador_Detalle_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_trabajador_det_id", SqlDbType.Int).Value = dshgo_trabajador_det_id;

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

        public DataSet DshgoTrabajadoresDetalle_ObtenerPorTrabajadorID(int dshgo_trabajador_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Trabajador_Detalle_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_trabajador_id", SqlDbType.Int).Value = dshgo_trabajador_id;

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

        public DataSet DshgoInterrogado_Obtener(int dshgo_participante_id, int dshgo_interrogado_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInterrogado_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_participante_id", SqlDbType.Int).Value = dshgo_participante_id;
                con.ObjCommand.Parameters.Add("@dshgo_interrogado_id", SqlDbType.Int).Value = dshgo_interrogado_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;


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
        public DataSet DshgoListadoPActivo_Obtener(int desahogo_id, int dshgo_listado_personal_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoListadoPActivo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@dshgo_listado_personal_id", SqlDbType.Int).Value = dshgo_listado_personal_id;
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

        public DataSet DshgoCaptura_ObtenerSinTerminar(int desahogo_id, int dsecc_en_oficio, int dsecc_en_acta, int dsecc_en_negativa, int materia_id, int subtipo_inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoCaptura_ObtenerSinTerminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@dsecc_en_oficio", SqlDbType.Int).Value = dsecc_en_oficio;
                con.ObjCommand.Parameters.Add("@dsecc_en_acta", SqlDbType.Int).Value = dsecc_en_acta;
                con.ObjCommand.Parameters.Add("@dsecc_en_negativa", SqlDbType.Int).Value = dsecc_en_negativa;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@subtipo_inspeccion_id", SqlDbType.Int).Value = subtipo_inspeccion_id;

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

        public DataSet DshgoTrabajadores_ObtenerTablero(int desahogo_id, int dtt_seccion)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Trabajador_ObtenerTablero", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@dtt_seccion", SqlDbType.Int).Value = dtt_seccion;

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

        public DataSet DshgoPreguntas_Obtener(int materia_id, int submateria_id, int dpreg_tipo_pregunta, string sentencia = "SELECT", string dpreg_pregunta = "", int dpreg_estatus = -1, int dpreg_consecutivo = -1, int dshgo_pregunta_id = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoPreguntas_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dshgo_pregunta_id != -1) con.ObjCommand.Parameters.Add("@dshgo_pregunta_id", SqlDbType.Int).Value = dshgo_pregunta_id;
                if (sentencia != "") con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                if (materia_id != -1) con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                if (submateria_id != -1) con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                if (dpreg_tipo_pregunta != -1) con.ObjCommand.Parameters.Add("@dpreg_tipo_pregunta", SqlDbType.Int).Value = dpreg_tipo_pregunta;
                if (dpreg_pregunta != "") con.ObjCommand.Parameters.Add("@dpreg_pregunta", SqlDbType.VarChar).Value = dpreg_pregunta;
                if (dpreg_estatus != -1) con.ObjCommand.Parameters.Add("@dpreg_estatus", SqlDbType.Int).Value = dpreg_estatus;
                if (dpreg_consecutivo != -1) con.ObjCommand.Parameters.Add("@dpreg_consecutivo", SqlDbType.Int).Value = dpreg_consecutivo;
                con.ObjCommand.Parameters.Add("@sys_usr_insert", SqlDbType.VarChar).Value = "Inspector";

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

        public DataSet Obtener_Supervisor_por_CVUR(int inspeccion_id)
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

        public DataSet Dshgo_Supuesto_Obtener(int supuesto_designacion_id, int esTestigo1, int esTestigo2, int designadopor)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Supuesto_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (supuesto_designacion_id != -1) con.ObjCommand.Parameters.Add("@supuesto_designacion_id", SqlDbType.Int).Value = supuesto_designacion_id;
                if (esTestigo1 != -1) con.ObjCommand.Parameters.Add("@esTestigo1", SqlDbType.Int).Value = esTestigo1;
                if (esTestigo2 != -1) con.ObjCommand.Parameters.Add("@esTestigo2", SqlDbType.Int).Value = esTestigo2;
                if (esTestigo2 != -1) con.ObjCommand.Parameters.Add("@designadopor", SqlDbType.Int).Value = designadopor;


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

        public DataSet DshgoPreguntaRespuesta_Obtener(int dshgo_pregunta_id, string sentencia = "SELECT", int dshgo_pregunta_respuesta = -1, int dpresp_orden = -1, string dpresp_respuesta = "")
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoPreguntaRespuesta_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;

                if (dshgo_pregunta_id != -1) con.ObjCommand.Parameters.Add("@dshgo_pregunta_id", SqlDbType.Int).Value = dshgo_pregunta_id;
                if (dshgo_pregunta_respuesta != -1) con.ObjCommand.Parameters.Add("@dshgo_pregunta_respuesta", SqlDbType.Int).Value = dshgo_pregunta_respuesta;
                if (dpresp_orden != -1) con.ObjCommand.Parameters.Add("@dpresp_orden", SqlDbType.Int).Value = dpresp_orden;
                if (dpresp_respuesta != "") con.ObjCommand.Parameters.Add("@dpresp_respuesta", SqlDbType.VarChar).Value = dpresp_respuesta;



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

        public DataSet DshgoInterrogatorio_Obtener(int dshgo_interrogatorio_id, int dshgo_pregunta_id, int dshgo_interrogado_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInterrogatorio_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                if (dshgo_interrogatorio_id != -1) con.ObjCommand.Parameters.Add("@dshgo_interrogatorio_id", SqlDbType.Int).Value = dshgo_interrogatorio_id;
                if (dshgo_pregunta_id != -1) con.ObjCommand.Parameters.Add("@dshgo_pregunta_id", SqlDbType.Int).Value = dshgo_pregunta_id;
                if (dshgo_interrogado_id != -1) con.ObjCommand.Parameters.Add("@dshgo_interrogado_id", SqlDbType.Int).Value = dshgo_interrogado_id;

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

        public DataSet DshgoInterrogatorioAbierta_Obtener(int dshgo_interrogatorio_abierta_id, int dshgo_interrogado_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInterrogatorioAbierta_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                if (dshgo_interrogatorio_abierta_id != -1) con.ObjCommand.Parameters.Add("@dshgo_interrogatorio_abierta_id", SqlDbType.Int).Value = dshgo_interrogatorio_abierta_id;
                if (dshgo_interrogado_id != -1) con.ObjCommand.Parameters.Add("@dshgo_interrogado_id", SqlDbType.Int).Value = dshgo_interrogado_id;


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

        public DataSet DshgoDocumento_Obtener(DtoDshgoDocumento dtoDocto, int no_otros = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDocumento_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dtoDocto.dshgo_documento_id;
                con.ObjCommand.Parameters.Add("@desahogo_id ", SqlDbType.Int).Value = dtoDocto.desahogo_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.tipo_documento_id;
                con.ObjCommand.Parameters.Add("@no_otros", SqlDbType.Int).Value = no_otros;
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

        public DataSet PA_DshgoDocumento_ObtenerConsultaRespuesta(DtoDshgoDocumento dtoDocto, int no_otros = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDocumento_ObtenerConsultaRespuesta", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dtoDocto.dshgo_documento_id;
                con.ObjCommand.Parameters.Add("@desahogo_id ", SqlDbType.Int).Value = dtoDocto.desahogo_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.tipo_documento_id;
                con.ObjCommand.Parameters.Add("@no_otros", SqlDbType.Int).Value = no_otros;
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

        public DataSet DshgoDocumentoAnexo_Obtener(DtoDshgoDocumento dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDocumentoAnexo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dtoDocto.dshgo_documento_id;
                con.ObjCommand.Parameters.Add("@desahogo_id ", SqlDbType.Int).Value = dtoDocto.desahogo_id;

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

        public DataSet MenuMedidas_Obtener(int participante_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MenuMedidas_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;

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

        public DataSet MenuMedidasSugeridas_Obtener(string menu_sentencia, int participante_id, int materia_id = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MenuMedidasSugeridas_Optimization", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.CommandTimeout = 600;
                con.ObjCommand.Parameters.Add("@menu_sentencia", SqlDbType.VarChar).Value = menu_sentencia;
                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;


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

        public DataSet DshgoSolidaria_ObtenerPorDshgoCentroTrabajoID(int dshgo_centro_trabajo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Solidaria_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = dshgo_centro_trabajo_id;


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

        public DataSet DshgoSolidaria_ValidarNumTrabajadores(int dshgo_centro_trabajo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Solidaria_ValidarNumTrabajadores", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = dshgo_centro_trabajo_id;


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

        public DataSet DshgoVariables_Obtener(int dshgo_documento_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoVariables_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dshgo_documento_id;


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

        public DataSet TablaIdentificación_Obtener(int desahogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaIdentificación_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;

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

        public DataSet Dshgo_MedidaAdm_Obtener(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_MedidaAdm_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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


        public DataSet TablaTestigos_Obtener(int desahogo, int Testigo)
        {
            //testigo 1 ó 2
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaTestigos_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;
                con.ObjCommand.Parameters.Add("@Testigo", SqlDbType.Int).Value = Testigo;

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

        public DataSet TablaComision_Obtener(int desahogo, int dcom_parte_representa)
        {
            //dcom_parte_representa:  1 comision empresa  ó 2 comision trabajador 
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaComision_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;
                con.ObjCommand.Parameters.Add("@dcom_parte_representa", SqlDbType.Int).Value = dcom_parte_representa;

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

        public DataSet TablaRepresentanteEmpresa_Obtener(int desahogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaRepresentanteEmpresa_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;

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

        public DataSet TablaSindicato_Obtener(int desahogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaSindicato_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;

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


        public DataSet TablaSolidario_Obtener(int desahogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaSolidario_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;

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

        public DataSet TablaProceso_Obtener(int desahogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaProceso_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;

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

        public DataSet TablaInstalacion_Obtener(int desahogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaInstalacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;

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

        public DataSet TablaCamara_Obtener(int desahogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaCamara_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;

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

        public DataSet TablaDomicilioNoCoincide_Obtener(int desahogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaDomicilioNoCoincide_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;

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

        public DataSet TablaIdentificaciónRepresentanteTrabajadores_Obtener(int desahogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaIdentificaciónRepresentanteTrabajadores_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;

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

        public DataSet TablaRepresentanteTrabajadores_Obtener(int desahogo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TablaRepresentanteTrabajadores_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;

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

        public DataSet IndMedida_ObtenerSubmateria(int imed_tipo_incumplimiento, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndMedida_ObtenerSubmateria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@imed_tipo_incumplimiento", SqlDbType.Int).Value = imed_tipo_incumplimiento;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet ConsultaRestriccionAcceso(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_ConsultaRestriccionAcceso_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet IndMedida_ObtenerSubmateria2(int imed_tipo_incumplimiento, int desahogo_id, int dsgo_area_id, int cumplimiento_espontaneo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_IndMedida_ObtenerSubmateria2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@imed_tipo_incumplimiento", SqlDbType.Int).Value = imed_tipo_incumplimiento;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@dsgo_area_id", SqlDbType.Int).Value = dsgo_area_id;
                con.ObjCommand.Parameters.Add("@dmed_cumplimiento_espontaneo", SqlDbType.Int).Value = cumplimiento_espontaneo;


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

        public DataSet Dshgo_Revision_ObtenerMedidasAdmin2(int desahogo_id, int indicador_id, int? solo_indicadores)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerMedidasAdmin2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@solo_indicadores", SqlDbType.Int).Value = solo_indicadores;

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

        public DataSet DshgoSolidaria_ObtenerPorID(int dshgo_solidaria_dne_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Solidaria_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_solidaria_dne_id", SqlDbType.Int).Value = dshgo_solidaria_dne_id;

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

        public DataSet DshgoMedida_Obtener(int desahogo_id, int dshgo_medida_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedida_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = dshgo_medida_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoDoctoVariableValores_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDoctoVariableValores_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@docto_valor_id", SqlDbType.Int).Value = dtoDocto.docto_valor_id;
                con.ObjCommand.Parameters.Add("@docto_variable_id", SqlDbType.Int).Value = dtoDocto.docto_variable_id;
                con.ObjCommand.Parameters.Add("@var_tipo_variable", SqlDbType.Int).Value = dtoDocto.var_tipo_variable;
                con.ObjCommand.Parameters.Add("@var_variable", SqlDbType.VarChar).Value = dtoDocto.var_variable;
                con.ObjCommand.Parameters.Add("@var_proceso", SqlDbType.Int).Value = dtoDocto.td_proceso;

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


        public DataSet MotivoNoFirma_Obtener()
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoNoFirma_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

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

        public DataSet DshgoDoctoParrafoTexto_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDoctoParrafoTexto_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.CommandTimeout = 180; // Equivalente a 3 min en responder con la base de datos

                con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.dp_tipo_documento_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@dp_variable", SqlDbType.VarChar).Value = dtoDocto.dp_variable;

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

        public DataSet DshgoAlcance_ObtenerTablero(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoAlcance_ObtenerTablero", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoAlcance_ObtenerNoTerminadas(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoAlcance_ObtenerTablero", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@no_terminadas", SqlDbType.Int).Value = 1;

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

        public DataSet DshgoMedDescatalogada_Obtener(int desahogo_id, int dshgo_med_descatalogada_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedDescatalogada_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@dshgo_med_descatalogada_id", SqlDbType.Int).Value = dshgo_med_descatalogada_id;

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

        public DataSet TodasAreasDshgoMedida_Obtener(int dshgo_medida_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TodasAreasDshgoMedida_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = dshgo_medida_id;

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

        //public DataSet DshgoRevision_ObtenerTodo(int desahogo_id)
        //{
        //    SqlDataAdapter objAdapter = null;
        //    DataSet objDataSet = new DataSet();
        //    Constantes con = new Constantes();

        //    try {
        //        con.ObjConnection = new SqlConnection(Constantes.StrCon);
        //        con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerIndicadoresIncisos", con.ObjConnection);
        //        con.ObjCommand.CommandType = CommandType.StoredProcedure;

        //        con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;


        //        con.ObjCommand.Connection.Open();
        //        objAdapter = new SqlDataAdapter(con.ObjCommand);
        //        objAdapter.Fill(objDataSet, "resultado");

        //        return objDataSet;
        //    } finally {
        //        con.ObjConnection.Close();
        //        objAdapter.Dispose();
        //        con.ObjCommand.Dispose();
        //        con.ObjConnection.Dispose();
        //    }
        //}

        //public DataSet DshgoRevision_ObtenerIndicadores(int dshgo_alcance_id)
        //{
        //    SqlDataAdapter objAdapter = null;
        //    DataSet objDataSet = new DataSet();
        //    Constantes con = new Constantes();

        //    try {
        //        con.ObjConnection = new SqlConnection(Constantes.StrCon);
        //        con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerIndicadoresIncisos", con.ObjConnection);
        //        con.ObjCommand.CommandType = CommandType.StoredProcedure;

        //        con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;

        //        con.ObjCommand.Connection.Open();
        //        objAdapter = new SqlDataAdapter(con.ObjCommand);
        //        objAdapter.Fill(objDataSet, "resultado");

        //        return objDataSet;
        //    } finally {
        //        con.ObjConnection.Close();
        //        objAdapter.Dispose();
        //        con.ObjCommand.Dispose();
        //        con.ObjConnection.Dispose();
        //    }
        //}

        //public DataSet DshgoRevision_ObtenerIncisos(int dshgo_alcance_id, int indicador_id)
        //{
        //    SqlDataAdapter objAdapter = null;
        //    DataSet objDataSet = new DataSet();
        //    Constantes con = new Constantes();

        //    try {
        //        con.ObjConnection = new SqlConnection(Constantes.StrCon);
        //        con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerIndicadoresIncisos", con.ObjConnection);
        //        con.ObjCommand.CommandType = CommandType.StoredProcedure;

        //        con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;
        //        con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
        //        con.ObjCommand.Parameters.Add("@con_incisos", SqlDbType.Int).Value = 1;

        //        con.ObjCommand.Connection.Open();
        //        objAdapter = new SqlDataAdapter(con.ObjCommand);
        //        objAdapter.Fill(objDataSet, "resultado");

        //        return objDataSet;
        //    } finally {
        //        con.ObjConnection.Close();
        //        objAdapter.Dispose();
        //        con.ObjCommand.Dispose();
        //        con.ObjConnection.Dispose();
        //    }
        //}

        public DataSet Dshgo_Revision_ObtenerIndicadores(int dshgo_alcance_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerIndicadoresIncisos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;

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

        public DataSet Dshgo_Revision_ObtenerIndicadoresComprobacionSanciones(int dshgo_alcance_id, int inspeccion_origen_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerIndicadoresIncisosComprobacionSanciones", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

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
        public DataSet Dshgo_Revision_ObtenerIndicadores(int dshgo_alcance_id, int indicador_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerIndicadoresIncisos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;

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

        public DataSet Dshgo_Revision_ObtenerIndicadorPorIncumplimientoDesahogoID(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@drev_respuesta", SqlDbType.Int).Value = 2;
                con.ObjCommand.Parameters.Add("@solo_indicadores", SqlDbType.Int).Value = 1;

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

        public DataSet Dshgo_Revision_ObtenerIncisosPorIncumplimientoDesahogoID(int desahogo_id, int indicador_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                //con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_Obtener", conexion);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                //con.ObjCommand.Parameters.Add("@con_incisos", SqlDbType.Int).Value = 1;
                con.ObjCommand.Parameters.Add("@drev_respuesta", SqlDbType.Int).Value = 2;

                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet);

                return objDataSet;
            }
            finally
            {
                objAdapter.Dispose();
            }
        }

        public DataSet Dshgo_Revision_ObtenerPorID(int dshgo_revision_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_revision_id", SqlDbType.Int).Value = dshgo_revision_id;
                con.ObjCommand.Parameters.Add("@solo_indicadores", SqlDbType.Int).Value = 1;

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

        public DataSet Dshgo_Revision_ObtenerIncisos(int dshgo_alcance_id, int indicador_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerIndicadoresIncisos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@con_incisos", SqlDbType.Int).Value = 1;

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

        public DataSet Dshgo_Revision_ObtenerIncisoaComprobacionSanciones(int dshgo_alcance_id, int indicador_id, int inspeccion_origen_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerIndicadoresIncisosComprobacionSanciones", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@con_incisos", SqlDbType.Int).Value = 1;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

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
        public DataSet Agregar_Alcance_Desahogo_Negativa(int inspeccion_id, int desahogo_id, string sys_usr, string sentencia = "INDICADORES", int indicador_id = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Agregar_Alcance_Desahogo_Negativa", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;

                if (sentencia == "INCISOS" && indicador_id != -1)
                {
                    con.ObjCommand.Parameters.Add("@con_incisos", SqlDbType.Int).Value = 1;
                    con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                }

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


        public DataSet Actualizar_Alcance_Desahogo_Negativa_CM(int desahogo_id, string sys_usr)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Actualizar_Medidas_Desahogo_Negativa_CM", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;

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

        

        public DataSet Agregar_Alcance_Desahogo_Negativa_ComprobacionSanciones(int inspeccion_id, int desahogo_id, string sys_usr, string sentencia = "INDICADORES", int indicador_id = -1, int inspeccion_origen_id=-1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Agregar_Alcance_Desahogo_Negativa_ComprobacionSanciones", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = sys_usr;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.VarChar).Value = inspeccion_origen_id;
                

                if (sentencia == "INCISOS" && indicador_id != -1)
                {
                    con.ObjCommand.Parameters.Add("@con_incisos", SqlDbType.Int).Value = 1;
                    con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                }

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

        public DataSet Dshgo_Revision_ObtenerIncisosPorIndicadorDependiente(int dshgo_alcance_id, int indicador_id, int indicador_depende_id, string ind_respuesta_depende)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerIndicadoresIncisos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@con_incisos", SqlDbType.Int).Value = 1;
                con.ObjCommand.Parameters.Add("@indicador_depende_id", SqlDbType.Int).Value = indicador_depende_id;
                con.ObjCommand.Parameters.Add("@ind_respuesta_depende", SqlDbType.VarChar).Value = ind_respuesta_depende;

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

        public DataSet Dshgo_Revision_ObtenerIndicadoresPorDesahogoID(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@solo_indicadores", SqlDbType.Int).Value = 1;


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

        public DataSet Dshgo_Revision_ObtenerIncisosPorDesahogoIndicadorID(int desahogo_id, int indicador_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;

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

        public DataSet Dshgo_Revision_ObtenerMedidasAdmin(int desahogo_id, int indicador_id, int? solo_indicadores)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerMedidasAdmin", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@solo_indicadores", SqlDbType.Int).Value = solo_indicadores;

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

        public DataSet Dshgo_Revision_ObtenerMedidasAdmin3(int inspeccion_id, int inspeccion_origen_id, int indicador_id, int? solo_indicadores)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerMedidasAdmin3", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@solo_indicadores", SqlDbType.Int).Value = solo_indicadores;

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

        public DataSet Dshgo_Medidas_Emplazamiento_Obtener(int desahogo_id, int inspeccion_origen_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Medidas_Emplazamiento_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

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

        public DataSet Emplazamiento_Medidas_Limpiar(int desahogo_id, int inspeccion_origen_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Emplazamiento_Medidas_Limpiar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@inspeccion_origen_id", SqlDbType.Int).Value = inspeccion_origen_id;

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



        public DataSet Dshgo_Revision_ObtenerIndicadoresDependientes(int dshgo_alcance_id, int indicador_depende_id, string ind_respuesta_depende)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_ObtenerIndicadoresIncisos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;
                con.ObjCommand.Parameters.Add("@indicador_depende_id", SqlDbType.Int).Value = indicador_depende_id;
                con.ObjCommand.Parameters.Add("@ind_respuesta_depende", SqlDbType.VarChar).Value = ind_respuesta_depende;

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

        public DataSet Dshgo_Revision_Borras_Incisos_Dependientes(int dshgo_alcance_id, int indicador_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_Borras_Incisos_Dependientes", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;

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

        public DataSet Dshgo_Revision_Info_Obtener(int dshgo_alcance_id, int indicador_id, int drev_respuesta)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_Info_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@drev_respuesta", SqlDbType.Int).Value = drev_respuesta;

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

        public DataSet Medidas_BusquedaAvanzada(DtoBusquedaAvanzada dtoBusq)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Medidas_BusquedaAvanzada", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@tema_id", SqlDbType.Int).Value = dtoBusq.tema_id;
                con.ObjCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = dtoBusq.tipo;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = dtoBusq.desahogo_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = dtoBusq.submateria_id;
                con.ObjCommand.Parameters.Add("@tipoBusqueda", SqlDbType.Int).Value = dtoBusq.tipoBusqueda;
                con.ObjCommand.Parameters.Add("@texto", SqlDbType.VarChar).Value = dtoBusq.texto;
                con.ObjCommand.Parameters.Add("@lugarBusqueda", SqlDbType.Int).Value = dtoBusq.lugarBusqueda;

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

        #region Calificacion

        public DataSet Calificacion_Obtener(DtoCalificacion DtoCalf)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Calicficacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (DtoCalf.calificacion_id != -1)
                    con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = DtoCalf.calificacion_id;
                if (DtoCalf.desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DtoCalf.desahogo_id;

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
        public DataSet ConsultaRestriccionAccesoDGIFT(DtoDshgoMedidaPrecautoriaConsulta DtoConsulta)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_ConsultaRestriccionAccesoRespuesta_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (DtoConsulta.fecha_ini != "")
                    con.ObjCommand.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = DtoConsulta.fecha_ini;
                if (DtoConsulta.fecha_fin != "")
                    con.ObjCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = DtoConsulta.fecha_fin;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DtoConsulta.desahogo_id;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = DtoConsulta.inspeccion_id;
                con.ObjCommand.Parameters.Add("@in_num_expediente", SqlDbType.VarChar).Value = DtoConsulta.in_num_expediente;
                con.ObjCommand.Parameters.Add("@dshgo_consulta_estatus", SqlDbType.Int).Value = DtoConsulta.dshgo_consulta_estatus;


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
        public DataSet ConsultaRestriccionAccesoRespuesta(DtoDshgoMedidaPrecautoriaConsulta DtoCalf)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ConsultaRestriccionAcceso_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DtoCalf.desahogo_id;


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
        public DataSet Calificacion_Consultar(DtoCalificacion DtoCalf)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Calificacion_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (DtoCalf.fecha_ini != "")
                    con.ObjCommand.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = DtoCalf.fecha_ini;
                if (DtoCalf.fecha_fin != "")
                    con.ObjCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = DtoCalf.fecha_fin;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = DtoCalf.cve_ur;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.Int).Value = DtoCalf.estatus;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DtoCalf.desahogo_id;
                if (!String.IsNullOrEmpty(DtoCalf.numExpediente))
                    con.ObjCommand.Parameters.Add("@in_num_expediente", SqlDbType.VarChar).Value = DtoCalf.numExpediente;


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
        public DataSet Calificacion_ConsultarAutomatica(DtoCalificacion DtoCalf)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalificacionAutomatica_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (DtoCalf.fecha_ini != "")
                    con.ObjCommand.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = DtoCalf.fecha_ini;
                if (DtoCalf.fecha_fin != "")
                    con.ObjCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = DtoCalf.fecha_fin;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = DtoCalf.cve_ur;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.Int).Value = DtoCalf.estatus;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DtoCalf.desahogo_id;


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
        public DataSet Calificacion_ConsultarPorParticipante(DtoCalificacion DtoCalf)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            string storeprocedure = string.Empty;

            try
            {
                if (DtoCalf.vista == "buscador principal")
                    storeprocedure = "PA_Calificacion_BuscadorPorParticipante";
                else
                    storeprocedure = "PA_Calificacion_ConsultarPorParticipante";

                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand(storeprocedure, con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = DtoCalf.participante_id;
                if (DtoCalf.fecha_ini != "")
                    con.ObjCommand.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = DtoCalf.fecha_ini;
                if (DtoCalf.fecha_fin != "")
                    con.ObjCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = DtoCalf.fecha_fin;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = DtoCalf.cve_ur;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.Int).Value = DtoCalf.estatus;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DtoCalf.desahogo_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = DtoCalf.calificacion_id;

                if (!String.IsNullOrEmpty(DtoCalf.numExpediente))
                    con.ObjCommand.Parameters.Add("@in_num_expediente", SqlDbType.VarChar).Value = DtoCalf.numExpediente;

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
        public DataSet CalificacionAutomatica_ConsultarPorParticipante(DtoCalificacion DtoCalf)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalificacionAutomatica_ConsultarPorParticipante", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = DtoCalf.participante_id;
                if (DtoCalf.fecha_ini != "")
                    con.ObjCommand.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = DtoCalf.fecha_ini;
                if (DtoCalf.fecha_fin != "")
                    con.ObjCommand.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = DtoCalf.fecha_fin;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = DtoCalf.cve_ur;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.Int).Value = DtoCalf.estatus;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = DtoCalf.desahogo_id;


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
        //consultar numero de documento
        /*public DataSet ObtenerNuevoNumeroDocumentoPorCalifDocumentoID(int ur, int tipo_documento, int anio)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtenerNuevoNumeroDocumentoPorCalifDocumentoID", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = ur;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = tipo_documento;
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
        }*/

        public DataSet CalifDocumento_Consultar(DtoCalifDocumento miDtoCD)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDocumento_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = miDtoCD.calif_documento_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = miDtoCD.tipo_documento_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = miDtoCD.calificacion_id;
                con.ObjCommand.Parameters.Add("@td_requiere_notificacion", SqlDbType.Int).Value = miDtoCD.aplica_notificacion;
                con.ObjCommand.Parameters.Add("@etapa", SqlDbType.Int).Value = miDtoCD.etapa;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = miDtoCD.inspeccion_id;
                con.ObjCommand.Parameters.Add("@td_aplica_automatica", SqlDbType.Int).Value = miDtoCD.td_aplica_automatica;
                con.ObjCommand.Parameters.Add("@code_documento", SqlDbType.VarChar).Value = miDtoCD.code_documento;


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

        public DataSet SExpedientes_Sancion_Inspeccion_Buscar(int por_pagina, int offset, int calif_estatus, int calificacion_id = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SExpedientes_Sancion_Inspeccion_Buscar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@por_pagina", SqlDbType.Int).Value = por_pagina;
                con.ObjCommand.Parameters.Add("@offset", SqlDbType.Int).Value = offset;
                con.ObjCommand.Parameters.Add("@calif_estatus", SqlDbType.Int).Value = calif_estatus;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;

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

        public DataSet doctoParrafoTexto_Actualizar_Parrafo(int docto_parrafo_texto_id, int docto_parrafo_id, string dpt_parrafo, int? cve_ur)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DoctoParrafoTexto_Actualizar_Parrafo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = docto_parrafo_id;
                con.ObjCommand.Parameters.Add("@dpt_parrafo", SqlDbType.VarChar).Value = dpt_parrafo;

                if (cve_ur != null)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;

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

        public DataSet Configuracion(DtoConfiguracion dtoConfiguracion)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Configuracion", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = dtoConfiguracion.sentencia;
                con.ObjCommand.Parameters.Add("@column", SqlDbType.VarChar).Value = dtoConfiguracion.column;
                con.ObjCommand.Parameters.Add("@value", SqlDbType.VarChar).Value = dtoConfiguracion.value;
                con.ObjCommand.Parameters.Add("@co_nombre", SqlDbType.VarChar).Value = dtoConfiguracion.co_nombre;
                con.ObjCommand.Parameters.Add("@co_code", SqlDbType.VarChar).Value = dtoConfiguracion.co_code;
                con.ObjCommand.Parameters.Add("@co_valor", SqlDbType.VarChar).Value = dtoConfiguracion.co_valor;
                con.ObjCommand.Parameters.Add("@co_dato_extra", SqlDbType.VarChar).Value = dtoConfiguracion.co_dato_extra;

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

        public DataSet Normatividad_Version(NormatividadVersion dtoNormatividadVersion, string orderBy = "normatividad_version_id")
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Normatividad_Versiones", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = dtoNormatividadVersion.sentencia;
                con.ObjCommand.Parameters.Add("@normatividad_version_id", SqlDbType.Int).Value = dtoNormatividadVersion.normatividad_version_id;
                con.ObjCommand.Parameters.Add("@nv_version", SqlDbType.VarChar).Value = dtoNormatividadVersion.nv_version;
                con.ObjCommand.Parameters.Add("@nv_descripcion", SqlDbType.VarChar).Value = dtoNormatividadVersion.nv_descripcion;

                if (dtoNormatividadVersion.nv_estatus != string.Empty)
                    con.ObjCommand.Parameters.Add("@nv_estatus", SqlDbType.VarChar).Value = dtoNormatividadVersion.nv_estatus;

                if (dtoNormatividadVersion.nv_estatus == "Activo" && dtoNormatividadVersion.estatus_actual == "Borrador")
                {
                    con.ObjCommand.Parameters.Add("@nv_fecha_publicacion", SqlDbType.DateTime).Value = DateTime.Now;
                }
                if (dtoNormatividadVersion.nv_activa == 1)
                    con.ObjCommand.Parameters.Add("@nv_activa", SqlDbType.Int).Value = dtoNormatividadVersion.nv_activa;
                if (dtoNormatividadVersion.nv_estatus == "Eliminado")
                    con.ObjCommand.Parameters.Add("@nv_fecha_eliminacion", SqlDbType.DateTime).Value = DateTime.Now;
                con.ObjCommand.Parameters.Add("@nv_duplicar", SqlDbType.Int).Value = dtoNormatividadVersion.nv_duplicar;
                con.ObjCommand.Parameters.Add("@order_by", SqlDbType.VarChar).Value = orderBy;

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

        public DataSet CalifDocumento_ObtenerParaPlantilla(int calif_documento_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDocumento_ObtenerParaPlantilla", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = calif_documento_id;


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

        //calif
        public DataSet CalifDoctoVariableValores_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDoctoVariableValores_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@docto_valor_id", SqlDbType.Int).Value = dtoDocto.docto_valor_id;
                con.ObjCommand.Parameters.Add("@docto_variable_id", SqlDbType.Int).Value = dtoDocto.docto_variable_id;
                con.ObjCommand.Parameters.Add("@var_tipo_variable", SqlDbType.Int).Value = dtoDocto.var_tipo_variable;
                con.ObjCommand.Parameters.Add("@var_variable", SqlDbType.VarChar).Value = dtoDocto.var_variable;
                con.ObjCommand.Parameters.Add("@var_proceso", SqlDbType.Int).Value = dtoDocto.td_proceso;

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

        public DataSet CalifDoctoParrafoTexto_Obtener(DtoDoctoBusqueda dtoDocto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDoctoParrafoTexto_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.CommandTimeout = 180; // Equivalente a 3 min en responder con la base de datos
                con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = dtoDocto.documento_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = dtoDocto.dp_tipo_documento_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_id;
                con.ObjCommand.Parameters.Add("@docto_parrafo_texto_id", SqlDbType.Int).Value = dtoDocto.docto_parrafo_texto_id;
                con.ObjCommand.Parameters.Add("@dp_variable", SqlDbType.VarChar).Value = dtoDocto.dp_variable;
                con.ObjCommand.CommandTimeout = 420;

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

        public DataSet CalifDoctoCopias_Consultar(int calif_documento_id, int cdc_copia_o_rubrica)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDoctoCopias_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = calif_documento_id;
                con.ObjCommand.Parameters.Add("@cdc_copia_o_rubrica", SqlDbType.Int).Value = cdc_copia_o_rubrica;

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

        public DataSet CalifViolacion_Consultar(int calif_violacion_id, int desahogo_id, int calificacion_id, int materia_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_violacion_id", SqlDbType.Int).Value = calif_violacion_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;

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

        public DataSet CalifViolacion_Consultar4(int calif_violacion_id, int desahogo_id, int calificacion_id, int materia_id, int cviol_procede)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_Consultar4", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_violacion_id", SqlDbType.Int).Value = calif_violacion_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@cviol_procede", SqlDbType.Int).Value = cviol_procede;


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

        public DataSet medidasAdinistrativasNoCumple(int calificacion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasAdinistrativasNoCumple", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;

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
        

        public DataSet CalifViolacion_Consultar2(int desahogo_id, int calificacion_id, int materia_id, int indicador_id, int? solo_indicadores)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_Consultar2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@solo_indicadores", SqlDbType.Int).Value = solo_indicadores;

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

        /*public DataSet CalifViolacion_Consultar3(int desahogo_id, int calificacion_id, int materia_id, int indicador_id, int? solo_indicadores)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_Consultar3", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@solo_indicadores", SqlDbType.Int).Value = solo_indicadores;

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
        }*/


        public DataSet CalifViolacion_Consultar_EmplazamientoMedidas(int desahogo_id, int calificacion_id, int materia_id, int indicador_id, int? solo_indicadores)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_Consultar_EmplazamientoMedidas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@solo_indicadores", SqlDbType.Int).Value = solo_indicadores;

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

        public DataSet CalifViolacion_Consultar_Violaciones(int desahogo_id, int calificacion_id, int materia_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_Consultar6", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;
                con.ObjCommand.Parameters.Add("@materia_id", SqlDbType.Int).Value = materia_id;
                

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

        public DataSet CalifViolacion_ConsultarNegativa(int calif_violacion_id, int calificacion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifViolacion_ConsultarNegativa", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_violacion_id", SqlDbType.Int).Value = calif_violacion_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;

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

        public DataSet CatalogosMedidas_Submateria(int submateria_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CatalogosMedidas_Submateria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;

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

        public DataSet CalifRequisitoRespuesta_ObtenerTablero(int calificacion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifRequisitoRespuesta_ObtenerTablero", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;
                con.ObjCommand.Parameters.Add("@creqfon_estatus", SqlDbType.Int).Value = 1;

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

        //obtener valores para las variables
        public DataSet CalifVariables_Obtener(int calif_documento_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifVariables_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = calif_documento_id;


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

        public DataSet VerificarDesahogoContieneMedida(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_VerificarDesahogoContieneMedida", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        //otra busqueda
        public DataSet MedidasAdminPorSubmateriaDesahogo_Obtener(int desahogo, int submateria)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasAdminPorSubmateriaDesahogo_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;
                con.ObjCommand.Parameters.Add("@submateria", SqlDbType.Int).Value = submateria;

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
        public DataSet MedidasAdminPorSubmateriaComprobacionSanciones_Obtener(int sancion_id, int submateria, int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasAdminPorSubmateriaComprobacionSanciones_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sancion_id", SqlDbType.Int).Value = sancion_id;
                con.ObjCommand.Parameters.Add("@submateria", SqlDbType.Int).Value = submateria;
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
        public DataSet ObtenerMedidasAdminComprobacionMedidasNoCumplen(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtenerMedidasAdminComprobacionMedidasNoCumplen", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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
        public DataSet MedidasAdminPorSubmateriaDesahogo_ObtenerEmplazamientoDocumental(int desahogo, int submateria)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasAdminPorSubmateriaDesahogo_ObtenerEmplazamientoDocumental", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo;
                con.ObjCommand.Parameters.Add("@submateria", SqlDbType.Int).Value = submateria;

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


        //el otro stored de medidas administrativas
        public DataSet MedidasAdminPorSubmateriaDesahogo_Obtener2(int emplazamiento_id, int submateria)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasAdminPorSubmateriaDesahogo_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento_id;
                con.ObjCommand.Parameters.Add("@submateria", SqlDbType.Int).Value = submateria;

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

        public DataSet MedidasRecorridoParaEmplazamiento_Obtener(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasRecorridoParaEmplazamiento_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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
        public DataSet MedidasRecorridoParaComprobacionSanciones_Obtener(int sancion_id, int submateria_id, int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasRecorridoComprobacionSanciones_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sancion_id", SqlDbType.Int).Value = sancion_id;
                con.ObjCommand.Parameters.Add("@submateria", SqlDbType.Int).Value = submateria_id;
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
        //la otra busqueda de medidas de recorrido
        public DataSet MedidasRecorridoParaEmplazamiento_Obtener2(int emplazamiento_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasRecorridoParaEmplazamiento_Obtener2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento_id;

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

        //la otra busqueda de medidas
        public DataSet MedidasAdminPorSubmateriaEmplazamiento_Obtener(int emplazamiento, int submateria)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasAdminPorSubmateriaEmplazamiento_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento;
                con.ObjCommand.Parameters.Add("@submateria", SqlDbType.Int).Value = submateria;


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

        #region CT
        public DataSet CT_ObtenerPorUsuarioClave(string dshgo_usuario_clave)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CT_ObtenerPorLogin", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_usuario_clave", SqlDbType.VarChar).Value = dshgo_usuario_clave;

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

        public DataSet CT_ObtenerPorExpedienteEmail(string in_num_expediente, string dct_email)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CT_ObtenerPorLogin", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@in_num_expediente", SqlDbType.VarChar).Value = in_num_expediente;
                con.ObjCommand.Parameters.Add("@dct_email", SqlDbType.VarChar).Value = dct_email;

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

        public DataSet CT_ObtenerPorInspeccionID(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CT_ObtenerPorLogin", con.ObjConnection);
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

        public DataSet CT_ObtenerTablero(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CT_ObtenerTablero", con.ObjConnection);
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

        public DataSet CT_ObtenerDatosInspeccionPorInspeccionID(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CT_ObtenerDatosInspeccion", con.ObjConnection);
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

        public DataSet CT_ObtenerDatosCitatorioPorInspeccionID(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CT_ObtenerDatosCitatorio", con.ObjConnection);
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

        public DataSet CT_ObtenerResultadoInspeccionPorInspeccionID(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CT_ObtenerResultadoInspeccion", con.ObjConnection);
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

        public DataSet ActividadRama_Busqueda(string cadenaBusqueda)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ActividadRama_Busqueda", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@cadenaBusqueda", SqlDbType.VarChar).Value = cadenaBusqueda;
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

        public DataSet ActividadRama_ObtenerClavePorDesc(string cadenaBusqueda)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ActividadRama_ObtenerClavePorDesc", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = cadenaBusqueda;
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

        public DataSet InspectorDisponibilidad_Obtener(int inspector_id, int inspector_disponibilidad_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspectorDisponibilidad_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;
                con.ObjCommand.Parameters.Add("@inspector_disponibilidad_id", SqlDbType.Int).Value = inspector_disponibilidad_id;

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

        public DataSet InspectorDisponibilidad_ConsultarFechas(int inspector_id, int inspector_disponibilidad_id, int mes, int anio)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspectorDisponibilidad_ConsultarFechas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;
                con.ObjCommand.Parameters.Add("@inspector_disponibilidad_id", SqlDbType.Int).Value = inspector_disponibilidad_id;
                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@mes", SqlDbType.Int).Value = mes;

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

        public DataSet ProgAtributosActividad_Obtener(int prog_atributo_id)
        {

            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributosActividad_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@prog_atributo_id", SqlDbType.VarChar).Value = prog_atributo_id;
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

        public DataSet InspecAdicional_Obtener(int inspeccion_id)
        {

            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecAdicional_Obtener", con.ObjConnection);
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

        public DataSet InspecAdicional_Obtener(int inspeccion_id, int inspector_id)
        {

            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecAdicional_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;
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

        public DataSet ProgAtributo_ValidarPorProgAnualID(int prog_anual_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributo_ValidarPorProgAnualID", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_anual_id", SqlDbType.Int).Value = prog_anual_id;

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

        public DataSet MotivoModificacion_Obtener()
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoModificacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

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

        public DataSet Modificacion_ObtenerPorInspeccionID(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Modificacion_Obtener", con.ObjConnection);
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

        public DataSet Inspeccion_ObtenerAleatoria(int anio, int mes, int cve_ur, int in_estatus, int ordenar, int cve_ur_comsion, int inspector_asignado, string nombre_razon_social)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_ObtenerAleatoria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@in_estatus", SqlDbType.Int).Value = in_estatus;
                con.ObjCommand.Parameters.Add("@ordenar", SqlDbType.Int).Value = ordenar;
                con.ObjCommand.Parameters.Add("@cve_ur_comision", SqlDbType.Int).Value = cve_ur_comsion;
                con.ObjCommand.Parameters.Add("@inspector_asignado", SqlDbType.Int).Value = inspector_asignado;
                con.ObjCommand.Parameters.Add("@nombre_razon_social", SqlDbType.VarChar).Value = nombre_razon_social;


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

        public DataSet Inspeccion_OperativoEspecial(int anio, int mes, int cve_ur, int operativo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_OperativoEspecial", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@in_anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@mes_id", SqlDbType.Int).Value = mes;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;

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

        public DataSet UnidadResponsable_ObtenerPorID(int cve_ur, int cur_cve_edorep)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_UnidadResp_ObtenerPorID", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@cur_cve_edorep", SqlDbType.Int).Value = cur_cve_edorep;

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

        public DataSet DshgoMedidaNoAdmin_Obtener(int desahogo_id, int dmed_cumplimiento_espontaneo)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedidaNoAdmin_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;


                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@dmed_cumplimiento_espontaneo", SqlDbType.Int).Value = dmed_cumplimiento_espontaneo;

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

        public DataSet Medidas_ObtenerMedidasPorTema(int tema_id, int tipo, int desahogo_id, int participante_id, int normatividad_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Medidas_ObtenerMedidasPorTema", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@tema_id", SqlDbType.Int).Value = tema_id;
                con.ObjCommand.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@participante_id", SqlDbType.Int).Value = participante_id;
                con.ObjCommand.Parameters.Add("@normatividad_id", SqlDbType.Int).Value = normatividad_id;


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

        public DataTable DshgoMedidaArea_ObtenerOpen(int ind_medida_id, int ind_info_adicional_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataTable objDataSet = new DataTable();
            Constantes con = new Constantes();

            try
            {
                con.ObjCommand = new SqlCommand("dbo.PA_DshgoMedidaArea_Obtener", conexion);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_medida_id", SqlDbType.Int).Value = ind_medida_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = ind_info_adicional_id;

                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet);

                return objDataSet;
            }
            finally
            {
                objAdapter.Dispose();
            }
        }

        public DataSet DshgoMedidaArea_Obtener(int ind_medida_id, int ind_info_adicional_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedidaArea_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_medida_id", SqlDbType.Int).Value = ind_medida_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = ind_info_adicional_id;

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


        public DataSet DshgoInfoAdicional_Obtener(int indicador_id, int ind_inciso_id, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInfoAdicional_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                con.ObjCommand.Parameters.Add("@ind_inciso_id", SqlDbType.Int).Value = ind_inciso_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoMedida_Valida_MedidasSugeridas(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedida_Valida_MedidasSugeridas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet Desahogo_ConsultarFormato(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Desahogo_ConsultarFormato", con.ObjConnection);
                con.ObjCommand.CommandTimeout = 250;
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet DshgoTrabajador_ConsultarFormato(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoTrabajador_ConsultarFormato", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public int Dshgo_Revision_Medidas_por_InfoID(int ind_info_adicional_id)
        {
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Revision_Medidas_por_InfoID", con.ObjConnection);
                con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = ind_info_adicional_id;

                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Connection.Open();
                return Convert.ToInt32(con.ObjCommand.ExecuteScalar());

            }
            finally
            {
                con.ObjConnection.Close();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public DataSet DshgoMedDescatalogadaArea_Obtener(int dshgo_med_descatalogada_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedDescatalogadaArea_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_med_descatalogada_id", SqlDbType.Int).Value = dshgo_med_descatalogada_id;

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

        public DataSet MedidasAutoComplet_Obtener(int desahogo_id, String texto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasAutoComplet_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@texto", SqlDbType.VarChar).Value = texto;

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

        public DataSet DshgoParrafoTexto_ObtenerFormato(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoParrafoTexto_ObtenerFormato", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet Inspeccion_VerificarAleatoria(int anio, int mes, int cve_ur)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_VerificarAleatoria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
                con.ObjCommand.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;

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

        public DataSet SubmateriaMedidasAdmin_Obtener(int desahogo_id, int submateria_id, int amp)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaMedidasAdmin_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                con.ObjCommand.Parameters.Add("@ampliacion", SqlDbType.Int).Value = amp;
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
        public DataSet SubmateriaMedidasAdminComprobacionSanciones_Obtener(int sancion_id, int submateria_id, int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaMedidasAdminComprobacionSanciones_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sancion_id", SqlDbType.Int).Value = sancion_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
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
        public DataSet SubmateriaMedidasAdmin_ObtenerEmplazamientoDocumental(int desahogo_id, int submateria_id, int amp)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaMedidasAdmin_ObtenerEmplazamientoDocumental", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                con.ObjCommand.Parameters.Add("@ampliacion", SqlDbType.Int).Value = amp;
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

        public DataSet SubmateriaMedidasAdmin_ObtenerEmplazamientoMedidas(int desahogo_id, int submateria_id, int amp)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaMedidasAdmin_ObtenerEmplazamientoMedidas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
                con.ObjCommand.Parameters.Add("@ampliacion", SqlDbType.Int).Value = amp;
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

        public DataSet Alcance_Submaterias_Indicadores_incisos_Obtener(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Alcance_Submaterias_Indicadores_incisos_Obtener", con.ObjConnection);
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

        public DataSet SubmateriaMedidasFisicas_ObtenerEmplazamientoMedidas(int imed_tipo_incumplimiento, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaMedidasFisica_ObtenerEmplazamientoMedidas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@imed_tipo_incumplimiento", SqlDbType.Int).Value = imed_tipo_incumplimiento;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;

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

        public DataSet SubmateriaMedidasAdmin_ObtenerEmplazamiento(int emplazamiento, int submateria_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaMedidasAdmin_ObtenerEmplazamiento", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
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

        //la otra función para obtener submaterias emplazamiento
        public DataSet SubmateriaMedidasAdmin_ObtenerEmplazamiento2(int emplazamiento, int submateria_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SubmateriaMedidasAdmin_ObtenerEmplazamiento2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@emplazamiento_id", SqlDbType.Int).Value = emplazamiento;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;
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

        public DataSet Notif_MotivoNoEntrega()
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Notif_MotivoNoEntrega", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

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

        public DataSet TodosDocumentos_ConsultarPorInspeccion(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_TodosDocumentos_ConsultarPorInspeccion", con.ObjConnection);
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

        public DataSet ObtenerConfirmacionDocumento(int inspeccion_id, int tipo_documento_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtenerConfirmacionDocumento", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = tipo_documento_id;

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

        public DataSet MedidasViolaciones_ParaConsulta(int calificacion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasViolaciones_ParaConsulta", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;

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

        public DataSet MedidasViolaciones_Consulta(int calificacion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MedidasViolaciones_Consulta", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;

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
        public DataSet Tablas_ObtenerInfo(String Tabla)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Tablas_ObtenerInfo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@Tabla", SqlDbType.VarChar).Value = Tabla;

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

        public DataSet UnidadResp_BuscarDescripcion(string cur_descripcion)
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_UnidadResp_BuscarDescripcion", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Parameters.Add("@cur_descripcion", SqlDbType.VarChar).Value = cur_descripcion;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();


            return objDataSet;
        }
        public DataSet CatalogoUnidadResp_BuscarPorUR(int? cve_ur)
        {
            SqlDataAdapter objAdapter;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            con.ObjConnection = new SqlConnection(Constantes.StrCon);
            con.ObjCommand = new SqlCommand("PA_CatalogoUnidadResp_BuscarPorUR", con.ObjConnection);
            con.ObjCommand.CommandType = CommandType.StoredProcedure;

            con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;

            con.ObjCommand.Connection.Open();
            objAdapter = new SqlDataAdapter(con.ObjCommand);
            objAdapter.Fill(objDataSet, "resultado");

            con.ObjConnection.Close();
            objAdapter.Dispose();
            con.ObjCommand.Dispose();
            con.ObjConnection.Dispose();


            return objDataSet;
        }


        public DataSet Participante_ObtenerUsuario(string inspector_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Participante_Usuario_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = int.Parse(inspector_id);

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


        public DataSet Perfil_ObtenerUsuarios(string email_usuario, string status)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_PerfilUsuario_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = status;
                con.ObjCommand.Parameters.Add("@usr_email", SqlDbType.VarChar).Value = email_usuario;
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

        #region PAS




        public DataSet SEtapa_ObtenerPorID(int s_etapa_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SEtapa_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_etapa_id", SqlDbType.Int).Value = s_etapa_id;

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

        public DataSet SEtapa_ObtenerPorNombre(string setapa_nombre)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SEtapa_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@setapa_nombre", SqlDbType.VarChar).Value = setapa_nombre;

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

        public DataSet SNotificacion_Obtener(int s_notif_solicitud_id, int s_expediente_etapa_id, int estatus, int sns_forma_entrega, int etapa_id, String sns_tipo_notif, int cve_edorep, int cve_mun, int cve_ur, string fecha1, string fecha2)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SNotificacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_notif_solicitud_id", SqlDbType.Int).Value = s_notif_solicitud_id;
                con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = s_expediente_etapa_id;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.Int).Value = estatus;
                con.ObjCommand.Parameters.Add("@sns_forma_entrega", SqlDbType.Int).Value = sns_forma_entrega;
                con.ObjCommand.Parameters.Add("@sns_tipo_notif", SqlDbType.VarChar).Value = sns_tipo_notif;
                con.ObjCommand.Parameters.Add("@etapa_id", SqlDbType.Int).Value = etapa_id;
                con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = cve_edorep;
                con.ObjCommand.Parameters.Add("@cve_mun", SqlDbType.Int).Value = cve_mun;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@fecha1", SqlDbType.VarChar).Value = fecha1;
                con.ObjCommand.Parameters.Add("@fecha2", SqlDbType.VarChar).Value = fecha2;

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

        public DataSet SNotificacionResultado_Obtener(int s_notif_resultado_id, int s_expediente_etapa_id, int estatus, int snr_forma_entrega, int etapa_id, String snr_tipo_notif, string ct_nombre, int cve_ur, string fecha1, string fecha2, int edo, int mun, int inspector_id, int estatus1, int cve_ur1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SNotificacionResultado_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_notif_resultado_id", SqlDbType.Int).Value = s_notif_resultado_id;
                con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = s_expediente_etapa_id;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.Int).Value = estatus;
                con.ObjCommand.Parameters.Add("@estatus1", SqlDbType.Int).Value = estatus1;
                con.ObjCommand.Parameters.Add("@sns_forma_entrega", SqlDbType.Int).Value = snr_forma_entrega;
                con.ObjCommand.Parameters.Add("@sns_tipo_notif", SqlDbType.VarChar).Value = snr_tipo_notif;
                con.ObjCommand.Parameters.Add("@etapa_id", SqlDbType.Int).Value = etapa_id;
                con.ObjCommand.Parameters.Add("@ct_nombre", SqlDbType.VarChar).Value = ct_nombre;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@cve_ur1", SqlDbType.Int).Value = cve_ur1;
                con.ObjCommand.Parameters.Add("@fecha1", SqlDbType.VarChar).Value = fecha1;
                con.ObjCommand.Parameters.Add("@fecha2", SqlDbType.VarChar).Value = fecha2;
                con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = edo;
                con.ObjCommand.Parameters.Add("@cve_mun", SqlDbType.Int).Value = mun;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;


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

        public DataSet NotifSancionador_Obtener(int notif_sancionador_id, int s_expediente_etapa_id, int estatus, int snr_forma_entrega, int etapa_id, String snr_tipo_notif, string ct_nombre, int cve_ur, string fecha1, string fecha2, int edo, int mun, int inspector_id, int estatus1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_NotifSancionador_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@notif_sancionador_id", SqlDbType.Int).Value = notif_sancionador_id;
                con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = s_expediente_etapa_id;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.Int).Value = estatus;
                con.ObjCommand.Parameters.Add("@estatus1", SqlDbType.Int).Value = estatus1;
                con.ObjCommand.Parameters.Add("@sns_forma_entrega", SqlDbType.Int).Value = snr_forma_entrega;
                con.ObjCommand.Parameters.Add("@sns_tipo_notif", SqlDbType.VarChar).Value = snr_tipo_notif;
                con.ObjCommand.Parameters.Add("@etapa_id", SqlDbType.Int).Value = etapa_id;
                con.ObjCommand.Parameters.Add("@ct_nombre", SqlDbType.VarChar).Value = ct_nombre;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@fecha1", SqlDbType.VarChar).Value = fecha1;
                con.ObjCommand.Parameters.Add("@fecha2", SqlDbType.VarChar).Value = fecha2;
                con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = edo;
                con.ObjCommand.Parameters.Add("@cve_mun", SqlDbType.Int).Value = mun;
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;


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

        public DataSet ObtenerUltimoDomicilioNotificaciones(int s_expediente_id, int s_expediente_etapa_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtenerUltimoDomicilioNotificaciones2", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@s_expediente_id", SqlDbType.Int).Value = s_expediente_id;
                con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = s_expediente_etapa_id;

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

        public DataSet SExpedienteEtapa_ObtenerUltimaEtapaAnterior(int s_expediente_etapa_id, int s_etapa_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SExpedienteEtapa_ObtenerUltimaEtapaAnterior", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = s_expediente_etapa_id;
                con.ObjCommand.Parameters.Add("@s_etapa_id", SqlDbType.Int).Value = s_etapa_id;

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

        public DataSet SExpediente_ObtenerEtapas(int s_expediente_id, int s_expediente_etapa_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SExpediente_ObtenerEtapas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@s_expediente_id", SqlDbType.Int).Value = s_expediente_id;
                con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = s_expediente_etapa_id;

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

        public DataSet ObtenerSExpedientesIDsPorInspeccionId(int inspeccion_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDt = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtenerSExpedientesIDsPorInspeccionId", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDt, "resultado");

                return objDt;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }

        public DataSet SExpediente_ObtenerEtapas(int s_expediente_id, int s_expediente_etapa_id, string proceso = null, string etapa_padre = null)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SExpediente_ObtenerEtapas", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@s_expediente_id", SqlDbType.Int).Value = s_expediente_id;
                con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = s_expediente_etapa_id;
                con.ObjCommand.Parameters.Add("@proceso", SqlDbType.VarChar).Value = proceso;
                con.ObjCommand.Parameters.Add("@etapa_padre", SqlDbType.VarChar).Value = etapa_padre;
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
        public DataSet SSolicitud_Cobro_Consulta_Res(int s_expediente_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SSolicitud_Cobro_Consulta_Res", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_expediente_id", SqlDbType.Int).Value = s_expediente_id;

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

        public DataSet SAcuerdo_Escrito_Particular_Consultar(int s_expediente_etapa_id, int s_acuerdo_escrito_particular_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SAcuerdoEscritoParticular_Consultar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = s_expediente_etapa_id;
                con.ObjCommand.Parameters.Add("@s_acuerdo_escrito_particular_id", SqlDbType.Int).Value = s_acuerdo_escrito_particular_id;

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
        public DataSet SAutoridadFiscal_Obtener(int s_autoridad_fiscal_id, int cen_cve_edorep)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SAutoridadFiscal_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_autoridad_fiscal_id", SqlDbType.VarChar).Value = s_autoridad_fiscal_id;
                con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.VarChar).Value = cen_cve_edorep;

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
        public DataSet SExpedienteEtapa_Obtener(DtoSExpedienteEtapa midto)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SExpedienteEtapa_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (midto.s_expediente_etapa_id != -1) con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = midto.s_expediente_etapa_id;
                if (midto.s_expediente_id != -1) con.ObjCommand.Parameters.Add("@s_expediente_id", SqlDbType.Int).Value = midto.s_expediente_id;
                if (midto.s_etapa_id != -1) con.ObjCommand.Parameters.Add("@s_etapa_id", SqlDbType.Int).Value = midto.s_etapa_id;
                if (midto.s_etapa_tipo_id != -1) con.ObjCommand.Parameters.Add("@s_etapa_tipo_id", SqlDbType.Int).Value = midto.s_etapa_tipo_id;
                if (midto.responsable_id != -1) con.ObjCommand.Parameters.Add("@responsable_id", SqlDbType.Int).Value = midto.responsable_id;
                if (midto.elaboro_id != -1) con.ObjCommand.Parameters.Add("@elaboro_id", SqlDbType.Int).Value = midto.elaboro_id;
                if (midto.reviso_id != -1) con.ObjCommand.Parameters.Add("@reviso_id", SqlDbType.Int).Value = midto.reviso_id;
                if (midto.responsable_atencion_id != -1) con.ObjCommand.Parameters.Add("@responsable_atencion_id", SqlDbType.Int).Value = midto.responsable_atencion_id;

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

        public DataSet NotifRequerir_Obtener(int s_notif_solicitud_id, int cve_ur)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_NotifRequerir_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_notif_solicitud_id", SqlDbType.Int).Value = s_notif_solicitud_id;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;

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

        public DataSet SAcuerdoNotificacion_Obtener(int s_expediente_etapa_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SAcuerdoNotificacion_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = s_expediente_etapa_id;


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

        public DataSet Tablero_Estatus_Resolucion_Expedientes(DtoBusquedaPAS dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Tablero_Estatus_Resolucion_Expedientes", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ct_entidad != -1)
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ct_entidad;
                if (dtoB.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = dtoB.cve_ur;
                if (dtoB.dictaminador != -1)
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.dictaminador;

                if (!String.IsNullOrEmpty(dtoB.fecDe))
                    con.ObjCommand.Parameters.Add("@fec_inicio", SqlDbType.DateTime).Value = dtoB.fecDe;
                if (!String.IsNullOrEmpty(dtoB.fecA))
                    con.ObjCommand.Parameters.Add("@fec_final", SqlDbType.DateTime).Value = dtoB.fecA;

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

        public DataSet SParticipante_Obtener(int s_participante_id, int cve_edorep)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SParticipante_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (s_participante_id != -1)
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = s_participante_id;
                if (cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = cve_edorep;

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

        public DataSet Tablero_EtapaProcesal(DtoBusquedaPAS dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Tablero_EtapaProcesal", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ct_entidad != -1)
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ct_entidad;
                if (dtoB.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = dtoB.cve_ur;
                if (dtoB.dictaminador != -1)
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.dictaminador;

                DateTime dt;
                if (DateTime.TryParse(dtoB.fecDe, out dt))
                    con.ObjCommand.Parameters.Add("@fec_inicio", SqlDbType.DateTime).Value = dt;
                if (DateTime.TryParse(dtoB.fecA, out dt))
                    con.ObjCommand.Parameters.Add("@fec_final", SqlDbType.DateTime).Value = dt;

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

        public DataSet Tablero_EtapaProcesal_Dos(DtoBusquedaPAS dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Tablero_EtapaProcesal_Dos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ct_entidad != -1)
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ct_entidad;
                if (dtoB.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = dtoB.cve_ur;
                if (dtoB.dictaminador != -1)
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.dictaminador;

                DateTime dt;
                if (DateTime.TryParse(dtoB.fecDe, out dt))
                    con.ObjCommand.Parameters.Add("@fec_inicio", SqlDbType.DateTime).Value = dt;
                if (DateTime.TryParse(dtoB.fecA, out dt))
                    con.ObjCommand.Parameters.Add("@fec_final", SqlDbType.DateTime).Value = dt;

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
        public DataSet Tablero_Impugnaciones(DtoBusquedaPAS dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Tablero_Impugnaciones", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ct_entidad != -1)
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ct_entidad;
                if (dtoB.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = dtoB.cve_ur;
                if (dtoB.participante_id != -1)
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.participante_id;

                DateTime dt;
                if (DateTime.TryParse(dtoB.fecDe, out dt))
                    con.ObjCommand.Parameters.Add("@fec_inicio", SqlDbType.DateTime).Value = dt;
                if (DateTime.TryParse(dtoB.fecA, out dt))
                    con.ObjCommand.Parameters.Add("@fec_final", SqlDbType.DateTime).Value = dt;

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
        public DataSet Tablero_RemitidosPorAutoridadFiscal(DtoBusquedaPAS dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Tablero_RemitidosPorAutoridadFiscal", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ct_entidad != -1)
                    con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = dtoB.ct_entidad;
                if (dtoB.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = dtoB.cve_ur;
                if (dtoB.dictaminador != -1)
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.dictaminador;
                if (dtoB.fecDe != "")
                    con.ObjCommand.Parameters.Add("@fecha1", SqlDbType.DateTime).Value = dtoB.fecDe;
                if (dtoB.fecA != "")
                    con.ObjCommand.Parameters.Add("@fecha2", SqlDbType.DateTime).Value = dtoB.fecA;


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
        public DataSet SResolucionCumplimiento_Reporte(DtoBusquedaPAS dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SResolucionCumplimiento_Reporte", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = dtoB.cve_ur;
                if (dtoB.ct_entidad != -1)
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ct_entidad;
                if (dtoB.participante_id != -1)
                    con.ObjCommand.Parameters.Add("@responsable_atencion_id", SqlDbType.Int).Value = dtoB.dictaminador;
                if (!String.IsNullOrEmpty(dtoB.fecDe))
                    con.ObjCommand.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = dtoB.fecDe;
                if (!String.IsNullOrEmpty(dtoB.fecA))
                    con.ObjCommand.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = dtoB.fecA;

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
        public DataSet Tablero_ReporteResolucionExpediente(DtoBusquedaPAS dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Tablero_ReporteResolucionExpediente", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ct_entidad != -1)
                    con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = dtoB.ct_entidad;
                if (dtoB.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = dtoB.cve_ur;
                if (dtoB.dictaminador != -1)
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.dictaminador;
                if (dtoB.fecDe != "")
                    con.ObjCommand.Parameters.Add("@fecha1", SqlDbType.DateTime).Value = Convert.ToDateTime(dtoB.fecDe);
                if (dtoB.fecA != "")
                    con.ObjCommand.Parameters.Add("@fecha2", SqlDbType.DateTime).Value = Convert.ToDateTime(dtoB.fecA);


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
        public DataSet Tablero_ResolucionesTipo(DtoBusquedaPAS dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Tablero_ResolucionesTipo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ct_entidad != -1)
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ct_entidad;
                if (dtoB.cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = dtoB.cve_ur;
                if (dtoB.dictaminador != -1)
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.dictaminador;

                if (!String.IsNullOrEmpty(dtoB.fecDe))
                    con.ObjCommand.Parameters.Add("@fec_inicio", SqlDbType.DateTime).Value = dtoB.fecDe;
                if (!String.IsNullOrEmpty(dtoB.fecA))
                    con.ObjCommand.Parameters.Add("@fec_final", SqlDbType.DateTime).Value = dtoB.fecA;

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
        public DataSet SParticipante_Obtener(int s_participante_id, int cve_edorep, int cur_cve_ur)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_SParticipante_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (s_participante_id != -1)
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = s_participante_id;
                if (cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = cve_edorep;
                if (cve_edorep != -1)
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = cur_cve_ur;

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

        #region Conteo de Inspecciones

        public DtoConteoInspecciones obtener_inspector_acronimo(int inspeccion_id)
        {

            DtoConteoInspecciones entidad = null;

            try
            {
                AbrirConexion();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DML_dshgo_conteo_inspecciones";
                cmd.Parameters.AddWithValue("@sentencia", "SEARCH");
                cmd.Parameters.AddWithValue("@inspeccion_id", inspeccion_id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entidad = new DtoConteoInspecciones();
                        entidad.Usuario_id = int.Parse(dr["usuario_id"].ToString());
                        entidad.Materia_acronimo = dr["mat_acronimo"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "Obtener_inspector_acronimo";
                throw excepcion;
            }
            finally
            {
                CerrarConexion();
            }

            return entidad;

        }



        public DtoConteoInspecciones obtener_conteo_inspeciones(DtoConteoInspecciones dtoConteoInspeciones)
        {

            DtoConteoInspecciones entidad = null;

            try
            {
                AbrirConexion();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DML_dshgo_conteo_inspecciones";
                cmd.Parameters.AddWithValue("@sentencia", "SELECT");
                cmd.Parameters.AddWithValue("@usuario_id", dtoConteoInspeciones.Usuario_id);
                cmd.Parameters.AddWithValue("@materia_acronimo", dtoConteoInspeciones.Materia_acronimo);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entidad = new DtoConteoInspecciones();
                        entidad.Dshgo_conteo_inspecciones_id = int.Parse(dr["dshgo_conteo_inspecciones_id"].ToString());
                        entidad.Usuario_id = int.Parse(dr["usuario_id"].ToString());
                        entidad.Materia_acronimo = dr["materia_acronimo"].ToString();
                        entidad.Total = int.Parse(dr["total"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "Obtener_inspector_acronimo";
                throw excepcion;
            }
            finally
            {
                CerrarConexion();
            }

            return entidad;

        }

        /// <summary>
        /// Consulta el total de inspeciones por materia de la programacion de inspeccion  de todos los inspectores
        /// </summary>
        /// <param name="miDtoDFT"></param>
        /// <returns></returns>
        public List<DtoConteoInspecciones> obtener_conteo_inspeciones_inspectores(DtoDFT miDtoDFT)
        {

            List<DtoConteoInspecciones> lista = new List<DtoConteoInspecciones>();
            DtoConteoInspecciones entidad = null;

            try
            {
                AbrirConexion();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DML_dshgo_conteo_inspecciones";
                cmd.Parameters.AddWithValue("@sentencia", "CONTEO");
                cmd.Parameters.AddWithValue("@materia_acronimo", miDtoDFT.mat_acronimo);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entidad = new DtoConteoInspecciones();
                        entidad.Dshgo_conteo_inspecciones_id = int.Parse(dr["dshgo_conteo_inspecciones_id"].ToString());
                        entidad.Usuario_id = int.Parse(dr["usuario_id"].ToString());
                        entidad.Materia_acronimo = dr["materia_acronimo"].ToString();
                        entidad.Total = int.Parse(dr["total"].ToString());
                        lista.Add(entidad);
                    }
                }

            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "obtener_conteo_inspeciones_inspectores";
                throw excepcion;
            }
            finally
            {
                CerrarConexion();
            }

            return lista;

        }

        #endregion


        #region Consulta calificacion usuario e inspeccion ID
        public DtoCalificacion obtener_calificacion_usuario_inspeccion(int calificacion_id)
        {

            DtoCalificacion entidad = null;

            try
            {
                AbrirConexion();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PA_Calificacion_consultar_usuario_inspecion_id";
                cmd.Parameters.AddWithValue("@calificacion_id", calificacion_id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entidad = new DtoCalificacion();
                        entidad.calificacion_id = int.Parse(dr["calificacion_id"].ToString());
                        entidad.calif_fec_asignacion = dr["calif_fec_asignacion"].ToString();
                        entidad.usuario_id = int.Parse(dr["usuario_id"].ToString());
                        entidad.core_usuario_id = dr["core_usuario_id"].ToString() == string.Empty ? 0 : int.Parse(dr["core_usuario_id"].ToString());
                        entidad.usr_email = dr["usr_email"].ToString();
                        entidad.inspeccion_id = int.Parse(dr["inspeccion_id"].ToString());
                        entidad.razon_social = dr["in_ct_razon_social"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "Obtener_inspector_acronimo";
                throw excepcion;
            }
            finally
            {
                CerrarConexion();
            }

            return entidad;

        }
        #endregion

        #region Consulta inspeccion usuario e inspeccion ID
        public List<DtoInspeccion> obtener_inspeccion_usuario(int inspeccion_id)
        {
            List<DtoInspeccion> listausuariosinpeccion = new List<DtoInspeccion>();
            DtoInspeccion entidad = null;

            try
            {
                AbrirConexion();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PA_Inspeccion_consultar_usuario_inspecion_id";
                cmd.Parameters.AddWithValue("@inspecion_id", inspeccion_id);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entidad = new DtoInspeccion();
                        entidad.usuario = new DtoUsuario();
                        entidad.inspeccionid = int.Parse(dr["inspeccion_id"].ToString());
                        entidad.razon_social = dr["in_ct_razon_social"].ToString();
                        entidad.fecha_emision = dr["in_fec_emision"].ToString();
                        entidad.fecha_inspeccion = Convert.ToDateTime(dr["in_fec_inspeccion"].ToString());
                        entidad.usuario.usuario_id = int.Parse(dr["usuario_id"].ToString());
                        entidad.usuario.core_usuario_id = dr["core_usuario_id"].ToString() == string.Empty ? 0 : int.Parse(dr["core_usuario_id"].ToString());
                        entidad.usuario.usr_email = dr["usr_email"].ToString();
                        listausuariosinpeccion.Add(entidad);
                    }
                }

            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "obtener_inspeccion_usuario";
                throw excepcion;
            }
            finally
            {
                CerrarConexion();
            }

            return listausuariosinpeccion;

        }
        #endregion

        #region Consulta de Historias de Inspeciones

        public List<DtoInspeccion> obtener_historial_inspeciones(DtoInspeccion dtoInspeccion)
        {

            List<DtoInspeccion> lista = new List<DtoInspeccion>();
            DtoInspeccion entidad = null;

            try
            {
                AbrirConexion();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "PA_Inspeccion_HistorialInspecciones";
                cmd.Parameters.AddWithValue("@centro_trabajo_id", dtoInspeccion.centrotrabajo_id);
                cmd.Parameters.AddWithValue("@num_expediente", dtoInspeccion.numero_expediente);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entidad = new DtoInspeccion();
                        entidad.inspeccionid = int.Parse(dr["inspeccion_id"].ToString());
                        entidad.numero_expediente = dr["numero_expediente"].ToString() != string.Empty ? dr["numero_expediente"].ToString() : "Sin expediente";
                        entidad.fecha_inspeccion = dr["fecha_inspeccion"].ToString() != string.Empty ? DateTime.Parse(dr["fecha_inspeccion"].ToString()) : DateTime.Now;
                        entidad.estatus_notificacion = dr["notif_estatus_ent"].ToString().Trim() != "" ? dr["notif_estatus_ent"].ToString() : "No aplica";
                        entidad.etapa = dr["etapa_sancion"].ToString().Trim() == "" ? (dr["etapa_inspeccion"].ToString()!="Cerrada"? dr["etapa_inspeccion"].ToString(): "Notificación - " +dr["notif_estatus_ent"].ToString()) : "SIPAS - " + dr["etapa_sancion"].ToString();
                        entidad.resolucion = dr["resolucion_sipas_id"].ToString().Trim() == "" ? dr["resolucion_siapi"].ToString() : dr["resolucion_sipas_id"].ToString();
                        entidad.multa = dr["sentido_resolucion_sipas_id"].ToString();
                        entidad.inspector = dr["inspector"].ToString();
                        entidad.num_solicitud = dr["num_solicitud"].ToString();
                        entidad.codigo_documento = dr["codigo_documento"].ToString();
                        lista.Add(entidad);
                    }
                }

            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "obtener_historial_inspeciones";
                throw excepcion;
            }
            finally
            {
                CerrarConexion();
            }

            return lista;

        }

        #endregion


        #region Listado de Expedientes Reportes SIPAS en SIAPI

        public DataSet Listado_Estatus_Resolucion_Expedientes(DtoBusqueda dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Listado_Estatus_Solucion_Expediente", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ddlEntidad != "-1")
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ddlEntidad;
                if (dtoB.ddlUnidadResponsable != "-1")
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = dtoB.ddlUnidadResponsable;
                if (dtoB.ddlDictaminador != "-1")
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.ddlDictaminador;

                if (!String.IsNullOrEmpty(dtoB.tbFecInicio))
                    con.ObjCommand.Parameters.Add("@fec_inicio", SqlDbType.DateTime).Value = dtoB.tbFecInicio;
                if (!String.IsNullOrEmpty(dtoB.tbFecFinal))
                    con.ObjCommand.Parameters.Add("@fec_final", SqlDbType.DateTime).Value = dtoB.tbFecFinal;

                con.ObjCommand.Parameters.Add("@tipo_parametro", SqlDbType.VarChar).Value = dtoB.parametroExpediente;

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

        public DataSet Listado_Resoluciones_Tipo(DtoBusqueda dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Listado_Resoluciones_Tipo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ddlEntidad != "-1")
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ddlEntidad;
                if (dtoB.ddlUnidadResponsable != "-1")
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = dtoB.ddlUnidadResponsable;
                if (dtoB.ddlDictaminador != "-1")
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.ddlDictaminador;

                if (!String.IsNullOrEmpty(dtoB.tbFecInicio))
                    con.ObjCommand.Parameters.Add("@fec_inicio", SqlDbType.DateTime).Value = dtoB.tbFecInicio;
                if (!String.IsNullOrEmpty(dtoB.tbFecFinal))
                    con.ObjCommand.Parameters.Add("@fec_final", SqlDbType.DateTime).Value = dtoB.tbFecFinal;

                con.ObjCommand.Parameters.Add("@tipo_parametro", SqlDbType.VarChar).Value = dtoB.parametroExpediente;

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

        public DataSet Listado_Impugnaciones(DtoBusqueda dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Listado_Impugnaciones", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ddlEntidad != "-1")
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ddlEntidad;

                if (dtoB.ddlUnidadResponsable != "-1")
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = dtoB.ddlUnidadResponsable;

                if (dtoB.ddlDictaminador != "-1")
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.ddlDictaminador;

                if (!String.IsNullOrEmpty(dtoB.tbFecInicio))
                    con.ObjCommand.Parameters.Add("@fec_inicio", SqlDbType.DateTime).Value = dtoB.tbFecInicio;

                if (!String.IsNullOrEmpty(dtoB.tbFecFinal))
                    con.ObjCommand.Parameters.Add("@fec_final", SqlDbType.DateTime).Value = dtoB.tbFecFinal;

                con.ObjCommand.Parameters.Add("@tipo_parametro", SqlDbType.VarChar).Value = dtoB.parametroExpediente;

                con.ObjCommand.Parameters.Add("@tipo_inpugnacion", SqlDbType.VarChar).Value = dtoB.parametroTipoInpugnaciones;

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

        public DataSet Listado_Etapa_Procesal(DtoBusqueda dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Listado_EtapaProcesal", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ddlEntidad != "-1")
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ddlEntidad;

                if (dtoB.ddlUnidadResponsable != "-1")
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.Int).Value = dtoB.ddlUnidadResponsable;

                if (dtoB.ddlDictaminador != "-1")
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.ddlDictaminador;

                if (!String.IsNullOrEmpty(dtoB.tbFecInicio))
                    con.ObjCommand.Parameters.Add("@fec_inicio", SqlDbType.DateTime).Value = dtoB.tbFecInicio;

                if (!String.IsNullOrEmpty(dtoB.tbFecFinal))
                    con.ObjCommand.Parameters.Add("@fec_final", SqlDbType.DateTime).Value = dtoB.tbFecFinal;

                con.ObjCommand.Parameters.Add("@tipo_parametroA", SqlDbType.VarChar).Value = dtoB.parametroExpediente;

                con.ObjCommand.Parameters.Add("@tipo_parametroB", SqlDbType.VarChar).Value = dtoB.parametroEtapaProcesalA;

                if (dtoB.parametroTitulo == "Alta de expediente") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "Alta=1";
                if (dtoB.parametroTitulo == "Emplazamiento") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "Emplazamiento=1";
                if (dtoB.parametroTitulo == "Comparecencia") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "Comparecencia=1";
                if (dtoB.parametroTitulo == "Acuerdo de cierre procedimiento") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "AcuerdoProcedimiento=1";
                if (dtoB.parametroTitulo == "Resolución") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "Resolucion=1";
                if (dtoB.parametroTitulo == "Solicitud de cobro") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "SolicitudCobro=1";
                if (dtoB.parametroTitulo == "Informe de cobro") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "InformeCobro=1";
                if (dtoB.parametroTitulo == "Acuerdo de terminación por improcedencia") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "AcuerdoImprocedencia=1";
                if (dtoB.parametroTitulo == "Acuerdos de archivo") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "AcuerdoArchivo=1";
                if (dtoB.parametroTitulo == "Acuerdos de trámite") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "AcuerdoTramite=1";
                if (dtoB.parametroTitulo == "Impugnación") con.ObjCommand.Parameters.Add("@tipo_parametroC", SqlDbType.VarChar).Value = "Impugnacion=1";

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

        public DataSet Listado_Remitidos_Autoridad_Fiscal(DtoBusqueda dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Listado_RemitidosPorAutoridadFiscal", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ddlEntidad != "-1")
                    con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = dtoB.ddlEntidad;

                if (dtoB.ddlUnidadResponsable != "-1")
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = dtoB.ddlUnidadResponsable;

                if (dtoB.ddlDictaminador != "-1")
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.ddlDictaminador;

                if (!String.IsNullOrEmpty(dtoB.tbFecInicio))
                    con.ObjCommand.Parameters.Add("@fecha1", SqlDbType.DateTime).Value = dtoB.tbFecInicio;

                if (!String.IsNullOrEmpty(dtoB.tbFecFinal))
                    con.ObjCommand.Parameters.Add("@fecha2", SqlDbType.DateTime).Value = dtoB.tbFecFinal;

                con.ObjCommand.Parameters.Add("@tipo_parametroA", SqlDbType.VarChar).Value = dtoB.parametroEtapaProcesalA;

                con.ObjCommand.Parameters.Add("@tipo_parametroB", SqlDbType.VarChar).Value = dtoB.parametroEtapaProcesalB;

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


        public DataSet Tablero_Front_Resolucion_Por_Expedientes(DtoBusqueda dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Tablero_Front_Resolucion_Por_Expedientes", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ddlEntidad != "-1")
                    con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = dtoB.ddlEntidad;
                if (dtoB.ddlUnidadResponsable != "-1")
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = dtoB.ddlUnidadResponsable;
                if (dtoB.ddlDictaminador != "-1")
                    con.ObjCommand.Parameters.Add("@s_participante_id", SqlDbType.Int).Value = dtoB.ddlDictaminador;

                if (!String.IsNullOrEmpty(dtoB.tbFecInicio))
                    con.ObjCommand.Parameters.Add("@fecha1", SqlDbType.DateTime).Value = dtoB.tbFecInicio;
                if (!String.IsNullOrEmpty(dtoB.tbFecFinal))
                    con.ObjCommand.Parameters.Add("@fecha2", SqlDbType.DateTime).Value = dtoB.tbFecFinal;

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

        public DataSet PA_Listado_Resolucion_Cumplimiento(DtoBusqueda dtoB)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Listado_Resolucion_Cumplimiento", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                if (dtoB.ddlEntidad != "-1")
                    con.ObjCommand.Parameters.Add("@cen_cve_edorep", SqlDbType.Int).Value = dtoB.ddlEntidad;
                if (dtoB.ddlUnidadResponsable != "-1")
                    con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = dtoB.ddlUnidadResponsable;
                if (dtoB.ddlDictaminador != "-1")
                    con.ObjCommand.Parameters.Add("@responsable_atencion_id", SqlDbType.Int).Value = dtoB.ddlDictaminador;

                if (!String.IsNullOrEmpty(dtoB.tbFecInicio))
                    con.ObjCommand.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = dtoB.tbFecInicio;
                if (!String.IsNullOrEmpty(dtoB.tbFecFinal))
                    con.ObjCommand.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = dtoB.tbFecFinal;

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

        public DataSet Dashboard_Obtener(int core_usuario_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dashboard_Historico_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = "SEARCH";
                con.ObjCommand.Parameters.Add("@core_id", SqlDbType.Int).Value = core_usuario_id;

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
        public DataSet ReporteDashboard_Obtener(int sys_fec_insert, int in_fec_inspeccion, int in_fec_emision, int sys_fec_insert_doc, String fec_inicio, String fec_final, string consulta, int cur_cve_ur = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand(consulta, con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                
                if (sys_fec_insert > 0)
                    con.ObjCommand.Parameters.Add("@sys_fec_insert", SqlDbType.Int).Value = sys_fec_insert;
                if (in_fec_inspeccion > 0)
                    con.ObjCommand.Parameters.Add("@in_fec_inspeccion", SqlDbType.Int).Value = in_fec_inspeccion;
                if (in_fec_emision > 0)
                    con.ObjCommand.Parameters.Add("@in_fec_emision", SqlDbType.Int).Value = in_fec_emision;
                if (sys_fec_insert_doc > 0)
                    con.ObjCommand.Parameters.Add("@sys_fec_insert_doc", SqlDbType.Int).Value = sys_fec_insert_doc;

                con.ObjCommand.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = fec_inicio;
                con.ObjCommand.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = fec_final;
                if (cur_cve_ur != -1)
                    con.ObjCommand.Parameters.Add("@cur_cve_ur", SqlDbType.VarChar).Value = cur_cve_ur;

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

        public List<DtoDashboard> Reporte_Dashboard_Obtener(int sys_fec_insert, int in_fec_inspeccion, int in_fec_emision, int sys_fec_insert_doc, String fec_inicio, String fec_final, string consulta, int cur_cve_ur = -1)
        {
            List<DtoDashboard> ListaDashboard = new List<DtoDashboard>();
            DtoDashboard entidad = null;
            Constantes con = new Constantes();
            try
            {

                AbrirConexion();


                DateTime fechainicial, fechafinal;
                fechainicial = DateTime.Parse(fec_inicio);
                fechafinal = DateTime.Parse(fec_final);

                String fecha_inicial_format = fechainicial.ToString("MM/dd/yyyy");
                String fecha_final_format = fechafinal.ToString("MM/dd/yyyy");



                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cmd.CommandTimeout = 3600; // Equivalente a 60 min en responder con la base de datos!

                if (sys_fec_insert > 0)
                    cmd.Parameters.AddWithValue("@sys_fec_insert", sys_fec_insert);
                if (in_fec_inspeccion > 0)
                    cmd.Parameters.AddWithValue("@in_fec_inspeccion", in_fec_inspeccion);
                if (in_fec_emision > 0)
                    cmd.Parameters.AddWithValue("@in_fec_emision", in_fec_emision);
                if (sys_fec_insert_doc > 0)
                    cmd.Parameters.AddWithValue("@sys_fec_insert_doc", sys_fec_insert_doc);

                cmd.Parameters.AddWithValue("@fecha_inicial", fecha_inicial_format);
                cmd.Parameters.AddWithValue("@fecha_final", fecha_final_format);

                if (cur_cve_ur != -1)
                    cmd.Parameters.AddWithValue("@cur_cve_ur", cur_cve_ur);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entidad = new DtoDashboard();                        
                        entidad.tabla_origen_doc = dr["tabla_origen_doc"].ToString();                        
                        entidad.numero_inspeccion = dr["inspeccion_id"].ToString();
                        entidad.sys_fec_insert = dr["sys_fec_insert"].ToString();
                        entidad.in_anio = dr["in_anio"].ToString();
                        entidad.mes_id = dr["mes_id"].ToString();
                        entidad.centro_trabajo_id = dr["centro_trabajo_id"].ToString();
                        entidad.cve_rama = dr["cve_rama"].ToString();
                        entidad.in_ct_rfc = dr["in_ct_rfc"].ToString();
                        entidad.in_fec_inspeccion = dr["in_fec_inspeccion"].ToString();
                        entidad.subtipo_inspeccion = dr["subtipo_inspeccion"].ToString();
                        entidad.fundamento_designacion = dr["fundamento_designacion"].ToString();
                        entidad.motivo_inspeccion = dr["motivo_inspeccion"].ToString();
                        entidad.inspector_id = dr["inspector_id"].ToString();
                        entidad.nombre_inspector = dr["nombre_inspector"].ToString();
                        entidad.materia_id = dr["materia_id"].ToString();
                        entidad.materia = dr["materia"].ToString();
                        entidad.cve_ur = dr["cve_ur"].ToString();
                        entidad.oficina = dr["oficina"].ToString();
                        entidad.etapa = dr["etapa"].ToString();
                        entidad.tipo_desahogo = dr["tipo_desahogo"].ToString();
                        entidad.in_num_expediente = dr["in_num_expediente"].ToString();
                        entidad.operativo = dr["operativo"].ToString();
                        entidad.listado_personal = dr["listado_personal"].ToString();
                        entidad.nalcances = dr["nalcances"].ToString();
                        entidad.submaterias = dr["submaterias"].ToString();
                        entidad.nind = dr["nind"].ToString();
                        entidad.nrevisiones = dr["nrevisiones"].ToString();
                        entidad.nrevisionesCumple = dr["nrevisionesCumple"].ToString();
                        entidad.nrevisionesNoCumple = dr["nrevisionesNoCumple"].ToString();
                        entidad.nrevisionesNoAplica = dr["nrevisionesNoAplica"].ToString();
                        entidad.nmed = dr["nmed"].ToString();
                        entidad.nmedespontaneo_si = dr["nmedespontaneo_si"].ToString();
                        entidad.nmedespontaneo_no = dr["nmedespontaneo_no"].ToString();
                        entidad.nvio = dr["nvio"].ToString();
                        entidad.nvio_procede = dr["nvio_procede"].ToString();
                        entidad.nvio_no_procede = dr["nvio_no_procede"].ToString();
                        entidad.documentos = dr["documentos"].ToString();
                        ListaDashboard.Add(entidad);
                    }
                }
            }
            catch (Exception ex)
            {
                ApplicationException excepcion = new ApplicationException("Se genero un error de aplicación con el siguiente mensaje: " + ex.Message, ex);
                excepcion.Source = "Reporte_Dashboard_Obtener";
                throw excepcion;
            }
            finally
            {
                CerrarConexion();
            }

            return ListaDashboard;

        }

        public void Dashboard_Actualizar(int dashboard_historico_id, int core_id, string sentencia, string doc_url = "", string estatus = "", int notificacion = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dashboard_Historico_Agregar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                if (doc_url != "")
                    con.ObjCommand.Parameters.Add("@doc_url", SqlDbType.VarChar).Value = doc_url;
                if (estatus != "")
                    con.ObjCommand.Parameters.Add("@estatus", SqlDbType.VarChar).Value = estatus;
                if (notificacion != -1)
                    con.ObjCommand.Parameters.Add("@notificacion", SqlDbType.Int).Value = notificacion;
                con.ObjCommand.Parameters.Add("@dashboard_historico_id", SqlDbType.Int).Value = dashboard_historico_id;
                con.ObjCommand.Parameters.Add("@core_id", SqlDbType.Int).Value = core_id;

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

        public void DML_Borrado_Desahogo(string sentencia, int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DML_Borrado_Desahogo", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
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

        public void Borrado_Medidas_PorInformeComision(int desahogo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Borrado_Medidas_PorInformeComision", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
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

        public DataSet SIncumplimientos_acuerdoCierreResolucion(int s_expediente_etapa_id, string num_solicitud, int indicadorId=-1, int submateriaId=-1, string sentencia = "SELECT", int inspeccion_id = -1, String medida = "")
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ObtenerIncumplimientosAcuerdoCierreResolucionSIPAS", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (s_expediente_etapa_id != -1)
                    con.ObjCommand.Parameters.Add("@s_expediente_etapa_id", SqlDbType.Int).Value = s_expediente_etapa_id;
                if (sentencia != "")
                    con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                if (num_solicitud != "")
                    con.ObjCommand.Parameters.Add("@num_solicitud", SqlDbType.VarChar).Value = num_solicitud;
                if (indicadorId != -1)
                    con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicadorId;
                if (submateriaId != -1)
                    con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateriaId;
                if (inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;
                if (medida != "")
                    con.ObjCommand.Parameters.Add("@valor", SqlDbType.VarChar).Value = medida;

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
        public DataSet MedDescatalogada_ObtenerPorMedidaFundamento(int desahogo_id, string medida, string fundamento)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedDescatalogada_ObtenerPorMedidaFundamento", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                if (desahogo_id != -1)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                if (medida != "")
                    con.ObjCommand.Parameters.Add("@medida", SqlDbType.VarChar).Value = medida;
                if (fundamento != "")
                    con.ObjCommand.Parameters.Add("@fundamento", SqlDbType.VarChar).Value = fundamento;

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

        #region Sidil
        public DataSet consultarListadoIdsCentrosTrabajo(string ids)
        {

            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CentroTrabajo_ObtenerCentrosTrabajoPorIDS", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@centros_trabajo_ids", SqlDbType.VarChar).Value = ids;

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

        public DataSet consultaListadoCargasColectivas(int usuario_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Consulta_Centros_Trabajos_Colectivos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuario_id;

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

        public DataSet colectivoInspecciones(DtoColectivoInspecciones dtoColectivoInspecciones, string sentencia)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Colectivo_Inspecciones", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;
                con.ObjCommand.Parameters.Add("@colectivo_id", SqlDbType.Int).Value = dtoColectivoInspecciones.colectivo_id;
                con.ObjCommand.Parameters.Add("@usuario_id", SqlDbType.Int).Value = dtoColectivoInspecciones.usuario_id;
                con.ObjCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = dtoColectivoInspecciones.nombre;
                con.ObjCommand.Parameters.Add("@total", SqlDbType.Int).Value = dtoColectivoInspecciones.total;

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


        public DataSet inspeccionesColectivasSinConcluir(int colectivo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Obtener_Ultima_Inspeccion_Sin_Concluir_Colectiva", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@colectivo_id", SqlDbType.Int).Value = colectivo_id;

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

        #region Consultas para servicios SIPAS 3
        public DataSet dshgoProcesos_Offline(DtoProcesosOffline dtoProcesos)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Procesos_Offline", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = dtoProcesos.sentencia;
                if (dtoProcesos.desahogo_id > 0)
                    con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = dtoProcesos.desahogo_id;
                con.ObjCommand.Parameters.Add("@marcado_offline", SqlDbType.Int).Value = dtoProcesos.marcado_offline;
                if (dtoProcesos.seccion_id > 0)
                    con.ObjCommand.Parameters.Add("@seccion_id", SqlDbType.Int).Value = dtoProcesos.seccion_id;
                if (dtoProcesos.core_usuario_id > 0)
                    con.ObjCommand.Parameters.Add("@core_usuario_id", SqlDbType.Int).Value = dtoProcesos.core_usuario_id;
                con.ObjCommand.Parameters.Add("@json_enviado", SqlDbType.Text).Value = dtoProcesos.json_enviado;
                con.ObjCommand.Parameters.Add("@json_respuesta", SqlDbType.Text).Value = dtoProcesos.json_respuesta;
                if (dtoProcesos.fecha_primer_envio_json == "Si")
                    con.ObjCommand.Parameters.Add("@fecha_primer_envio_json", SqlDbType.DateTime).Value = DateTime.Now;
                if (dtoProcesos.dispositivo_id != "" && dtoProcesos.dispositivo_id != null)
                    con.ObjCommand.Parameters.Add("@dispositivo_id", SqlDbType.VarChar).Value = dtoProcesos.dispositivo_id;

                if (dtoProcesos.dshgo_tipo_trabajador_id > 0)
                    con.ObjCommand.Parameters.Add("@dshgo_tipo_trabajador_id", SqlDbType.Int).Value = dtoProcesos.dshgo_tipo_trabajador_id;
                if (dtoProcesos.dtrab_num_hombres >= -1)
                    con.ObjCommand.Parameters.Add("@dtrab_num_hombres", SqlDbType.Int).Value = dtoProcesos.dtrab_num_hombres;
                if (dtoProcesos.dtrab_num_mujeres >= 0)
                    con.ObjCommand.Parameters.Add("@dtrab_num_mujeres", SqlDbType.Int).Value = dtoProcesos.dtrab_num_mujeres;
                if (dtoProcesos.dtrab_num_total >= 0)
                    con.ObjCommand.Parameters.Add("@dtrab_num_total", SqlDbType.Int).Value = dtoProcesos.dtrab_num_total;

                if (dtoProcesos.fecha_seleccion_offline != null)
                    con.ObjCommand.Parameters.Add("@fecha_seleccion_offline", SqlDbType.DateTime).Value = dtoProcesos.fecha_seleccion_offline;

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

        public DataSet PA_Incumplimientos_Consultar(int tipo_documento_id, int calificacion_id, string num_solicitud)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Incumplimientos", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@tipo_documento_id", SqlDbType.Int).Value = tipo_documento_id;
                con.ObjCommand.Parameters.Add("@calificacion_id", SqlDbType.Int).Value = calificacion_id;
                con.ObjCommand.Parameters.Add("@num_solicitud", SqlDbType.Text).Value = num_solicitud;

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

        public DataSet Reinscidencias_Medida(int ind_medida_id, int centro_trabajo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Reinscidencias_Medida", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_medida_id", SqlDbType.Int).Value = ind_medida_id;
                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;


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

        public DataSet Notificaciones_SIPAS(DtoNotificacionSIPAS notificacion)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Notificaciones_SIPAS", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = notificacion.sentencia;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.Int).Value = notificacion.estatus;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = notificacion.cve_ur;
                con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.Int).Value = notificacion.cve_edorep;
                con.ObjCommand.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = notificacion.tipo_documento;
                con.ObjCommand.Parameters.Add("@cve_mun", SqlDbType.Int).Value = notificacion.cve_municipio;
                con.ObjCommand.Parameters.Add("@fecha1", SqlDbType.VarChar).Value = notificacion.fecha1;
                con.ObjCommand.Parameters.Add("@fecha2", SqlDbType.VarChar).Value = notificacion.fecha2;
                con.ObjCommand.Parameters.Add("@notificacion_id", SqlDbType.VarChar).Value = notificacion.notificacion_id;
                if (notificacion.notificacion_id != -1)
                    con.ObjCommand.Parameters.Add("@notificacion_personal", SqlDbType.VarChar).Value = notificacion.notificacion_personal;
                if (notificacion.inspector_id != -1)
                    con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = notificacion.inspector_id;
                if (notificacion.fecha_entrega != null)
                    con.ObjCommand.Parameters.Add("@fecha_entrega", SqlDbType.DateTime).Value = notificacion.fecha_entrega;
                if (notificacion.fecha_envio != null)
                    con.ObjCommand.Parameters.Add("@fecha_envio", SqlDbType.DateTime).Value = notificacion.fecha_envio;
                if (notificacion.fecha_documento != null)
                    con.ObjCommand.Parameters.Add("@fecha_documento", SqlDbType.DateTime).Value = notificacion.fecha_documento;
                if (notificacion.fec_limite_entrega != null)
                    con.ObjCommand.Parameters.Add("@fec_limite_entrega", SqlDbType.DateTime).Value = notificacion.fec_limite_entrega;

                if (notificacion.num_guia != "")
                    con.ObjCommand.Parameters.Add("@num_guia", SqlDbType.VarChar).Value = notificacion.num_guia;
                if (notificacion.estatus_asignacion != -1)
                    con.ObjCommand.Parameters.Add("@estatus_asignacion", SqlDbType.Int).Value = notificacion.estatus_asignacion;
                if (notificacion.sys_usr != "")
                    con.ObjCommand.Parameters.Add("@sys_usr", SqlDbType.VarChar).Value = notificacion.sys_usr;
                if (notificacion.proceso_expediente_etapa_id != -1)
                    con.ObjCommand.Parameters.Add("@proceso_expediente_etapa_id", SqlDbType.Int).Value = notificacion.proceso_expediente_etapa_id;
                if (notificacion.expediente_etapa_notificacion_id != -1)
                    con.ObjCommand.Parameters.Add("@expediente_etapa_notificacion_id", SqlDbType.Int).Value = notificacion.expediente_etapa_notificacion_id;
                if (notificacion.inspeccion_id != -1)
                    con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = notificacion.inspeccion_id;
                if (notificacion.cve_ur_solicita != -1)
                    con.ObjCommand.Parameters.Add("@cve_ur_solicita", SqlDbType.Int).Value = notificacion.cve_ur_solicita;
                con.ObjCommand.Parameters.Add("@num_expediente_sipas", SqlDbType.VarChar).Value = notificacion.num_expediente_sipas;
                if (notificacion.forma_entrega != null && notificacion.forma_entrega != "")
                    con.ObjCommand.Parameters.Add("@forma_entrega", SqlDbType.VarChar).Value = notificacion.forma_entrega;
                if (notificacion.estatus_entrega != -1)
                    con.ObjCommand.Parameters.Add("@estatus_entrega", SqlDbType.Int).Value = notificacion.estatus_entrega;
                if (notificacion.razon_social != null && notificacion.razon_social != "")
                    con.ObjCommand.Parameters.Add("@razon_social", SqlDbType.VarChar).Value = notificacion.razon_social;
                if (notificacion.se_recibio != -1)
                    con.ObjCommand.Parameters.Add("@se_recibio", SqlDbType.Int).Value = notificacion.se_recibio;
                if (notificacion.quedo_pegado != -1)
                    con.ObjCommand.Parameters.Add("@quedo_pegado", SqlDbType.Int).Value = notificacion.quedo_pegado;
                if (notificacion.motivo_no_entrega_id != -1)
                    con.ObjCommand.Parameters.Add("@motivo_no_entrega_id", SqlDbType.Int).Value = notificacion.motivo_no_entrega_id;
                if (notificacion.otro_motivo != null)
                    con.ObjCommand.Parameters.Add("@otro_motivo", SqlDbType.VarChar).Value = notificacion.otro_motivo;
                if (notificacion.forma_constatacion_id != -1)
                    con.ObjCommand.Parameters.Add("@forma_constatacion_id", SqlDbType.Int).Value = notificacion.forma_constatacion_id;
                if (notificacion.nombre_recibio != null)
                    con.ObjCommand.Parameters.Add("@nombre_recibio", SqlDbType.VarChar).Value = notificacion.nombre_recibio;
                if (notificacion.dijo_ser != null)
                    con.ObjCommand.Parameters.Add("@dijo_ser", SqlDbType.VarChar).Value = notificacion.dijo_ser;
                if (notificacion.hechos_constatados != null)
                    con.ObjCommand.Parameters.Add("@hechos_constatados", SqlDbType.VarChar).Value = notificacion.hechos_constatados;
                if (notificacion.observaciones != null)
                    con.ObjCommand.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = notificacion.observaciones;
                if (notificacion.fecha_entrega_centro != null)
                    con.ObjCommand.Parameters.Add("@fecha_entrega_centro", SqlDbType.DateTime).Value = notificacion.fecha_entrega_centro;
                if(notificacion.es_comprobacion != -1)
                    con.ObjCommand.Parameters.Add("@es_comprobacion", SqlDbType.Int).Value = notificacion.es_comprobacion;
                con.ObjCommand.Parameters.Add("@num_solicitud_doc", SqlDbType.VarChar).Value = notificacion.num_solicitud_doc;
                if (notificacion.resolucion != null && notificacion.resolucion != "")
                    con.ObjCommand.Parameters.Add("@resolucion", SqlDbType.VarChar).Value = notificacion.resolucion;
                if (notificacion.fecha_resolucion != null && notificacion.fecha_resolucion != "")
                    con.ObjCommand.Parameters.Add("@fecha_resolucion", SqlDbType.VarChar).Value = notificacion.fecha_resolucion;

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

        public DataSet AutoridadesTurnan_Obtener(int cve_edorep, int cve_ur, int estatus = -1)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_AutoridadesTurnan_Obtener", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@cve_edorep", SqlDbType.VarChar).Value = cve_edorep;
                con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.VarChar).Value = cve_ur;
                con.ObjCommand.Parameters.Add("@estatus", SqlDbType.VarChar).Value = estatus;


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
    }
}
