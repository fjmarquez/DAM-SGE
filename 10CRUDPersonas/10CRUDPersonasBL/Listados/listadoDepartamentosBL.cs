using _10CRUDPersonasDAL.Listados;
using _10CRUDPersonasEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CRUDPersonasBL.Listados
{
    public class listadoDepartamentosBL
    {

        public List<clsDepartamento> getListadoDepartamentos()
        {
            List<clsDepartamento> list = new listadoDepartamentosDAL().getListadoDepartamentos();

            return list;
        }

        public clsDepartamento getDepartamentoPorID(int ID)
        {
            clsDepartamento departamento = new listadoDepartamentosDAL().getDepartamentoPorID(ID);

            return departamento;
        }


    }
}
