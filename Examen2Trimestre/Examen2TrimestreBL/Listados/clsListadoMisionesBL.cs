using Examen2TrimestreDAL.Listados;
using Examen2TrimestreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2TrimestreBL.Listados
{
    public class clsListadoMisionesBL
    {

        public List<Mision> getListadoMisionesPorCompletar()
        {

            List<Mision> listado;

            try
            {
                listado = new clsListadoMisionesDAL().getListadoMisionesPorCompletar();
            }
            catch (Exception e)
            {
                throw e;
            }

            return listado;

        }

    }
}
