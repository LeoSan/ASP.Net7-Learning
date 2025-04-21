using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using CompInspeccion;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inspeccion_PA
{
    public class Catalogos
    {
        public static void SeguridadSocial(RadioButtonList rbList, Page page)
        {
            ComponentInsp miComponente = new ComponentInsp();
            try
            {
                rbList.DataSource = miComponente.SeguridadSocialObtener();
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, page.AppRelativeVirtualPath, ex.Message);
                return;
            }
            rbList.DataMember = "resultado";
            rbList.DataBind();
        }
        public static void EntidadesFederativas(DropDownList ddl, Page page)
        {
            ComponentInsp miComponente = new ComponentInsp();
            try
            {
                ddl.DataSource = miComponente.Entidades_ObtenerTodasEntidades();
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, page.AppRelativeVirtualPath, ex.Message);
                return;
            }
            ddl.DataMember = "resultado";
            ddl.DataBind();
        }
        public static void Municipios(DropDownList ddl, int entidad_id, Page page)
        {
            ComponentInsp miComponente = new ComponentInsp();
            try
            {
                ddl.DataSource = miComponente.Municipios_ObtenerMunicipiosPorEstadoId(entidad_id);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, page.AppRelativeVirtualPath, ex.Message);
                return;
            }
            ddl.DataMember = "resultado";
            ddl.DataBind();
        }
        public static string EntidadesFederativas_ObtenerPorID(int cve_edorep, Page Page)
        {
            DataSet ds;
            ComponentInsp miComponente = new ComponentInsp();
            try
            {
                ds = miComponente.Entidades_ObtenerPorId((short)cve_edorep);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return "";
            }
            if (ds.Tables["resultado"].Rows.Count < 1) return "";

            return ds.Tables["resultado"].Rows[0]["cen_descripcion"].ToString();
        }
        public static string Municipios_ObtenerPorID(int cve_edorep, int cve_municipio, Page Page)
        {
            DataSet ds;
            ComponentInsp miComponente = new ComponentInsp();
            try
            {
                ds = miComponente.Municipios_ObtenerMunicipio((short)cve_edorep, (short)cve_municipio);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return "";
            }
            if (ds.Tables["resultado"].Rows.Count < 1) return "";

            return ds.Tables["resultado"].Rows[0]["cmu_descripcion"].ToString();
        }

		public static string UnidadResponsable_ObtenerPorID(int cve_ur, Page Page)
		{
			DataSet ds;
			ComponentInsp miComponente = new ComponentInsp();
			try {
				ds = miComponente.UnidadResponsable_ObtenerPorID(cve_ur);
			} catch (Exception ex) {
				utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
				utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
				return "";
			}
			if (ds.Tables["resultado"].Rows.Count < 1) return "";

			return ds.Tables["resultado"].Rows[0]["cur_descripcion"].ToString();
		}

        public static string ObtenerEstadoPorUR(int ur, Page Page)
        {
            ComponentInsp miComponente = new ComponentInsp();
            DataSet ds;
            try
            {
                ds = miComponente.Entidades_ObtenerPorUnidadResponsable(ur);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return "";
            }
            if (ds.Tables["resultado"].Rows.Count > 0) return ds.Tables["resultado"].Rows[0]["cen_descripcion"].ToString();

            return "";

        }
	}
}
