using System;
using System.Data;
using System.Web.UI;
using CompInspeccion;
using System.Net;
using System.Collections;
using System.Collections.Generic;

namespace Servicios.Generales
{
    public class ObtenerMedidasDesahogo
    {
        ComponentInsp miComponente = new ComponentInsp();

        public string[] ObtenerNumeralMedidasDesahogo(int desahogoId)
        {
            DataSet ds,ds_recorrido,ds_recorrido2;
            List<string> medidasDesahogoOrigenLista = new List<string>();
            string[] medidasDesahogoOrigen;
            try
            {
                //Medidas documentales
                ds = miComponente.Dshgo_MedidaAdm_Obtener(desahogoId);
                //Medidas no administrativas
                ds_recorrido = miComponente.DshgoMedidaNoAdmin_Obtener(desahogoId, 1);//cumplimiento espontáneo

                ds_recorrido2 = miComponente.DshgoMedidaNoAdmin_Obtener(desahogoId, 0);//no cumplimiento espontáneo


                foreach (DataRow row in ds.Tables["resultado"].Rows)
                {
                    string medida = row["imed_medida"].ToString();
                    medidasDesahogoOrigenLista.Add(medida);
                }
                foreach (DataRow row in ds_recorrido.Tables["resultado"].Rows)
                {
                    string medida = row["medida"].ToString();
                    medidasDesahogoOrigenLista.Add(medida);
                }
                foreach (DataRow row in ds_recorrido.Tables["resultado1"].Rows)
                {
                    string medida = row["medida"].ToString();
                    medidasDesahogoOrigenLista.Add(medida);
                }
                foreach (DataRow row in ds_recorrido2.Tables["resultado"].Rows)
                {
                    string medida = row["medida"].ToString();
                    medidasDesahogoOrigenLista.Add(medida);
                }
                foreach (DataRow row in ds_recorrido2.Tables["resultado1"].Rows)
                {
                    string medida = row["medida"].ToString();
                    medidasDesahogoOrigenLista.Add(medida);
                }
            }

            catch (Exception ex)
            {
                return null;
            }
            medidasDesahogoOrigen = medidasDesahogoOrigenLista.ToArray();
            return medidasDesahogoOrigen;
        }
    }
}
