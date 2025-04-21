using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CompInspeccion
{
    class Eliminar
    {

        internal SqlConnection conexion;

        public void EliminarAbrirConexion()
        {
            conexion = new SqlConnection(Constantes.StrCon);
            conexion.Open();
        }

        public void EliminarCerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
        }

		public void EliminarContenido(int apoyo_id)
		{
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InfoApoyo_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@info_apoyo_id", SqlDbType.Int).Value = apoyo_id;

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

        public void InspectorDisponibilidad_Eliminar(int inspector_disponibilidad_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspectorDisponibilidad_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspector_disponibilidad_id", SqlDbType.Int).Value = inspector_disponibilidad_id;

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


        public void OperativoDocto_Eliminar(int operativo_docto_id)
        {
            //
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoDocto_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_docto_id", SqlDbType.Int).Value = operativo_docto_id;

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

        public void OperativosProg_Eliminar(int operativo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativosProg_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;

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

        public void OperativoDocto_EliminarPorOperativoId(int operativo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoDocto_EliminarPorOperativoId", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;

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

        public void OperativoAlcance_EliminarPorOperativoId(int operativo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAlcance_EliminarPorOperativoId", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;

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


        //
        public void OperativoAsignacion_EliminarPorOperativoId(int operativo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAsignacion_EliminarPorOperativoId", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;

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

        //PA_OperativoEntidad_EliminarPorOperativoId

        public void OperativoEntidad_EliminarPorOperativoId(int operativo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoEntidad_EliminarPorOperativoId", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;

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

        public void ProgAtributosActividad_Eliminar(int prog_actividad_federal_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_ProgAtributosActividad_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@prog_actividad_scian", SqlDbType.Int).Value = prog_actividad_federal_id;

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

        public void InspecAdicional_Eliminar(int inspec_adicional_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecAdicional_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspec_adicional_id", SqlDbType.Int).Value = inspec_adicional_id;

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

        public void InspecExperto_Eliminar(int inspec_experto_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspecExperto_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspec_experto_id", SqlDbType.Int).Value = inspec_experto_id;

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

		public void InspeccionCopia_EliminarPorInspeccionID(int inspec_copia_id)
		{
			Constantes con = new Constantes();
			try {
				con.ObjConnection = new SqlConnection(Constantes.StrCon);
				con.ObjCommand = new SqlCommand("PA_InspecionCopia_Eliminar", con.ObjConnection);
				con.ObjCommand.CommandType = CommandType.StoredProcedure;

				con.ObjCommand.Parameters.Add("@inspec_copia_id", SqlDbType.Int).Value = inspec_copia_id;

				con.ObjCommand.Connection.Open();
				con.ObjCommand.ExecuteNonQuery();
			} finally {
				con.ObjConnection.Close();
				con.ObjCommand.Dispose();
				con.ObjConnection.Dispose();
			}
		}

        public void InspeccionCopia_Eliminar(int inspec_copia_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspeccionCopia_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspec_copia_id", SqlDbType.Int).Value = inspec_copia_id;

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

        public void Usuario_Eliminar(int usuario_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Usuario_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@usuario_id", SqlDbType.Int).Value = usuario_id;

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

        public void Inspector_Eliminar(int inspector_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspector_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = inspector_id;

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

		internal void InspeccionAlcance_Eliminar(int inspeccion_id)
		{
			Constantes con = new Constantes();
			try {
				con.ObjConnection = new SqlConnection(Constantes.StrCon);
				con.ObjCommand = new SqlCommand("PA_InspeccionAlcance_Eliminar", con.ObjConnection);
				con.ObjCommand.CommandType = CommandType.StoredProcedure;

				con.ObjCommand.Parameters.Add("@inspeccion_id", SqlDbType.Int).Value = inspeccion_id;

				con.ObjCommand.Connection.Open();
				con.ObjCommand.ExecuteNonQuery();
			} finally {
				con.ObjConnection.Close();
				con.ObjCommand.Dispose();
				con.ObjConnection.Dispose();
			}
		}

        //eliminar inspeccion indicador
        internal void InspeccionIndicador_Eliminar(int inspeccion_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InspeccionIndicador_Eliminar", con.ObjConnection);
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

        internal void OperativoAlcance_Eliminar(int operativo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAlcance_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;

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

        internal void OperativoAlcance_EliminarPorOperativoPorSubmateria(int operativo_id,int submateria_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAlcance_EliminarPorOperativoPorSubmateria", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;
                con.ObjCommand.Parameters.Add("@submateria_id", SqlDbType.Int).Value = submateria_id;

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

        internal void MotivoSubtipo_Eliminar(int motivo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoSubtipo_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@motivo_id", SqlDbType.Int).Value = motivo_id;

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

        internal void MotivoMateria_Eliminar(int motivo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoMateria_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@motivo_id", SqlDbType.Int).Value = motivo_id;

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

        internal void InfoAdicional_Eliminar(int indicador_id, int ind_inciso_id, int info_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_InfoAdicional_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@indicador_id", SqlDbType.Int).Value = indicador_id;
                if(ind_inciso_id != -1)
                con.ObjCommand.Parameters.Add("@ind_inciso_id", SqlDbType.Int).Value = ind_inciso_id;
                con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = info_id;


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

        public void DocumentoEliminarPorID(int documento_id, String tipo_borrado = "documento")
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Documento_Borrar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@documento_id", SqlDbType.Int).Value = documento_id;
                con.ObjCommand.Parameters.Add("@tipo_borrado", SqlDbType.VarChar).Value = tipo_borrado;

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

        public void OperativoIndicador_Eliminar(int operativo_indicador_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoIndicador_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_indicador_id", SqlDbType.Int).Value = operativo_indicador_id;

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

        public void OperativoIndicador_EliminarPorOperativoId(int operativo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoIndicador_EliminarPorOperativoId", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = operativo_id;

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
        public void Dshgo_Area_Eliminar(int dshgo_area_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Area_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_area_id", SqlDbType.Int).Value = dshgo_area_id;

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

        public void DshgoAlcance_Eliminar(int dshgo_alcance_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoAlcance_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_alcance_id", SqlDbType.Int).Value = dshgo_alcance_id;

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

        public int DshgoInspector_Eliminar(int dshgo_inspector_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Inspector_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_inspector_id", SqlDbType.Int).Value = dshgo_inspector_id;

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

        public int DshgoExperto_Eliminar(int dshgo_experto_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Experto_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_experto", SqlDbType.Int).Value = dshgo_experto_id;

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


        public void DshgoParticipantes_Eliminar(int dshgo_participante_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Participante_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_Participante_id", SqlDbType.Int).Value = dshgo_participante_id;

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

        public void DshgoTestigo_Eliminar(int dshgo_testigo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Testigo_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_testigo_id", SqlDbType.Int).Value = dshgo_testigo_id;

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

        public void DshgoTrabajadoresDetalle_EliminarPorID(int dshgo_trabajador_det_id)
		{
			Constantes con = new Constantes();
			try {
				con.ObjConnection = new SqlConnection(Constantes.StrCon);
				con.ObjCommand = new SqlCommand("PA_Dshgo_Trabajador_Detalle_Eliminar", con.ObjConnection);
				con.ObjCommand.CommandType = CommandType.StoredProcedure;

				con.ObjCommand.Parameters.Add("@dshgo_trabajador_det_id", SqlDbType.Int).Value = dshgo_trabajador_det_id;

				con.ObjCommand.Connection.Open();
				con.ObjCommand.ExecuteNonQuery();
			} finally {
				con.ObjConnection.Close();
				con.ObjCommand.Dispose();
				con.ObjConnection.Dispose();
			}
		}

        internal void DesahogoInstalacion_Eliminar(int desahogo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DesahogoInstalacion_Eliminar", con.ObjConnection);
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

        //*********
		public void DshgoCentroCamara_Eliminar(int dshgo_centro_trabajo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoCentroCamara_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_centro_trabajo_id", SqlDbType.Int).Value = dshgo_centro_trabajo_id;

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

        public void DshgoDocumento_Eliminar(int dshgo_documento_id, string tipo_borrado, string sentencia = "eliminar")
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoDocumento_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_documento_id", SqlDbType.Int).Value = dshgo_documento_id;
                con.ObjCommand.Parameters.Add("@tipo_borrado", SqlDbType.VarChar).Value = tipo_borrado;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;

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

        public void DshgoInterrogado_Eliminar(int dshgo_interrogado_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInterrogado_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_interrogado_id", SqlDbType.Int).Value = dshgo_interrogado_id;

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

        public void DshgoSolidaria_EliminarPorID(int dshgo_solidaria_dne_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Dshgo_Solidaria_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_solidaria_dne_id", SqlDbType.Int).Value = dshgo_solidaria_dne_id;

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

        public void DshgoMedida_Eliminar(int dshgo_medida_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedida_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

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

        public void DshgoMedDescatalogada_Eliminar(int dshgo_med_descatalogada_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedDescatalogada_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

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

        public void DshgoMotivoInforme_Eliminar(int motivo_informe_id, int desahogo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMotivoInforme_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@motivo_informe_id", SqlDbType.Int).Value = motivo_informe_id;
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

        public void DshgoMedida_Eliminar(int ind_medida_id, int desahogo_id, int ind_info_adicional_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedida_EliminarPorIndMedidaId", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_medida_id", SqlDbType.Int).Value = ind_medida_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = ind_info_adicional_id;

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

        public void DshgoMedida_EliminarOpen(int ind_medida_id, int desahogo_id, int ind_info_adicional_id)
        {
            Constantes con = new Constantes();
            try
            {
 
                con.ObjCommand = new SqlCommand("PA_DshgoMedida_EliminarPorIndMedidaId", conexion);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@ind_medida_id", SqlDbType.Int).Value = ind_medida_id;
                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = desahogo_id;
                con.ObjCommand.Parameters.Add("@ind_info_adicional_id", SqlDbType.Int).Value = ind_info_adicional_id;

                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {
                con.ObjCommand.Dispose();

            }
        }

        public void DshgoMedida_EliminarTodas(int desahogo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Medida_EliminarTodas", con.ObjConnection);
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

        public void DshgoInterrogatorio_Eliminar(int dshgo_interrogado_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInterrogatorio_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_interrogado_id", SqlDbType.Int).Value = dshgo_interrogado_id;

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

        public void DshgoListadoPActivo_Eliminar(int dshgo_listado_personal_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoListadoPActivo_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_listado_personal_id", SqlDbType.Int).Value = dshgo_listado_personal_id;

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
        
        public void DshgoListadoPersonal_Eliminar_Masivamente (int dshgo_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoListadoPMasivo_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@desahogo_id", SqlDbType.Int).Value = dshgo_id;

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

        public void DshgoInterrogatorioAbierta_Eliminar(int dshgo_interrogado_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInterrogatorioAbierta_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_interrogado_id", SqlDbType.Int).Value = dshgo_interrogado_id;

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
        
        public void DshgoInterrogatorioAbierta_EliminarUnica(int dshgo_interrogatorio_abierta_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoInterrogatorioAbierta_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_interrogatorio_abierta_id", SqlDbType.Int).Value = dshgo_interrogatorio_abierta_id;
                con.ObjCommand.Parameters.Add("@dshgo_interrogado_id", SqlDbType.Int).Value = -1;

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

        public void DshgoMedidaArea_Eliminar(int dshgo_medida_id, int dsgo_area_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedidaArea_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = dshgo_medida_id;
                con.ObjCommand.Parameters.Add("@dsgo_area_id", SqlDbType.Int).Value = dsgo_area_id;

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

        public void DshgoMedidaArea_EliminarOpen(int dshgo_medida_id, int dsgo_area_id)
        {
            Constantes con = new Constantes();
            try
            {

                con.ObjCommand = new SqlCommand("PA_DshgoMedidaArea_Eliminar",conexion);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_medida_id", SqlDbType.Int).Value = dshgo_medida_id;
                con.ObjCommand.Parameters.Add("@dsgo_area_id", SqlDbType.Int).Value = dsgo_area_id;

                con.ObjCommand.ExecuteNonQuery();
            }
            finally
            {

                con.ObjCommand.Dispose();

            }
        }

        public void DshgoMedDescatalogadaArea_Eliminar(int dshgo_med_descatalogada_id, int dsgo_area_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_DshgoMedDescatalogadaArea_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@dshgo_med_descatalogada_id", SqlDbType.Int).Value = dshgo_med_descatalogada_id;
                con.ObjCommand.Parameters.Add("@dsgo_area_id", SqlDbType.Int).Value = dsgo_area_id;

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

		public void Inspeccion_EliminarAleatoria(int anio, int mes, int cve_ur)
		{
			Constantes con = new Constantes();
			try {
				con.ObjConnection = new SqlConnection(Constantes.StrCon);
				con.ObjCommand = new SqlCommand("PA_Inspeccion_EliminarAleatoria", con.ObjConnection);
				con.ObjCommand.CommandType = CommandType.StoredProcedure;

				con.ObjCommand.Parameters.Add("@anio", SqlDbType.Int).Value = anio;
				con.ObjCommand.Parameters.Add("@mes", SqlDbType.Int).Value = mes;
				con.ObjCommand.Parameters.Add("@cve_ur", SqlDbType.Int).Value = cve_ur;

				con.ObjCommand.Connection.Open();
				con.ObjCommand.ExecuteNonQuery();
			} finally {
				con.ObjConnection.Close();
				con.ObjCommand.Dispose();
				con.ObjConnection.Dispose();
			}
		}

        public void CalifDoctoCopias_Eliminar(int calif_docto_copias_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDoctoCopias_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_docto_copias_id", SqlDbType.Int).Value = calif_docto_copias_id;

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

        public void CalifDocumento_Eliminar(int calif_documento_id, string sentencia = "eliminar")
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDocumento_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@calif_documento_id", SqlDbType.Int).Value = calif_documento_id;
                con.ObjCommand.Parameters.Add("@sentencia", SqlDbType.VarChar).Value = sentencia;                

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

        public void CalifDocumento_EliminarPlus(string calif_documento_ids, int calificacion_id)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_CalifDocumento_EliminarPlus", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;
                                
                con.ObjCommand.Parameters.Add("@calif_documento_ids", SqlDbType.VarChar).Value = calif_documento_ids;
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

        public void CentroSindicato_Eliminar(int centro_trabajo_id, int cs_orden)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrConDNE);
                con.ObjCommand = new SqlCommand("PA_CentroSindicato_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@centro_trabajo_id", SqlDbType.Int).Value = centro_trabajo_id;
                con.ObjCommand.Parameters.Add("@cs_orden", SqlDbType.Int).Value = cs_orden;

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

        public DataSet Obtener_Resultado_EliminarMotivoInspeccion(int motivo_id)
        {
            SqlDataAdapter objAdapter = null;
            DataSet objDataSet = new DataSet();
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_MotivoInspeccion_Eliminar", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@motivo_inspeccion_id", SqlDbType.Int).Value = motivo_id;

                con.ObjCommand.Connection.Open();
                objAdapter = new SqlDataAdapter(con.ObjCommand);
                objAdapter.Fill(objDataSet, "resultado");

                return objDataSet;
            }
            finally
            {
                con.ObjConnection.Close();
                objAdapter.Dispose();
                con.ObjCommand.Dispose();
                con.ObjConnection.Dispose();
            }
        }
        public void PA_Inspeccion_Eliminar_SinConcluir(int inspeccion_id)
        {
            Constantes con = new Constantes();

            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_Inspeccion_Eliminar_SinConcluir", con.ObjConnection);
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

        public int OperativoAsignacion_Eliminar(DtoOperativoAsignacion miDtoOA)
        {
            Constantes con = new Constantes();
            try
            {
                con.ObjConnection = new SqlConnection(Constantes.StrCon);
                con.ObjCommand = new SqlCommand("PA_OperativoAsignacion_EliminarPorOperativoId", con.ObjConnection);
                con.ObjCommand.CommandType = CommandType.StoredProcedure;

                con.ObjCommand.Parameters.Add("@operativo_id", SqlDbType.Int).Value = miDtoOA.operativo_id;
                
                con.ObjCommand.Parameters.Add("@inspector_id", SqlDbType.Int).Value = miDtoOA.inspector_id;

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
