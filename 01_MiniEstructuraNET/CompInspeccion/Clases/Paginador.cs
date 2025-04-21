using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace CompInspeccion.Clases
{
    public class Paginador
    {
        /// <summary>
        /// Metodo que permite crear la paginacion de un listado
        /// </summary>
        /// <param name="current_page">Pagina actual</param>
        /// <param name="last_page">Total de pagina</param>
        /// <param name="pagerSpan">Cantidad del total de pagina a mostrar </param>
        /// <returns>Devuelve las paginas en botones de primero, anterior,numero de paginas, siguiente o final </returns>
        public List<ListItem> Crear(int current_page, int last_page, int pagerSpan)
        {
            List<ListItem> pages = new List<ListItem>();
            int startIndex, endIndex;

            startIndex = current_page > 1 && current_page + pagerSpan - 1 < pagerSpan ? current_page : 1;
            endIndex = last_page > pagerSpan ? pagerSpan : last_page;
            if (current_page > pagerSpan % 2)
            {
                if (current_page == 2)
                {
                    endIndex = 5;
                }
                else
                {
                    endIndex = current_page + 2;
                }
            }
            else
            {
                endIndex = (pagerSpan - current_page) + 1;
            }

            if (endIndex - (pagerSpan - 1) > startIndex)
            {
                startIndex = endIndex - (pagerSpan - 1);
            }

            if (endIndex > last_page)
            {
                endIndex = last_page;
                startIndex = ((endIndex - pagerSpan) + 1) > 0 ? (endIndex - pagerSpan) + 1 : 1;
            }
            
            if (current_page > 1)
            {
                pages.Add(new ListItem("<", (current_page - 1).ToString()));
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                pages.Add(new ListItem(i.ToString(), i.ToString(), i != current_page));
            }
            
            if (current_page < last_page)
            {
                pages.Add(new ListItem(">", (current_page + 1).ToString()));
            }

            return pages;
        }
    }
}
