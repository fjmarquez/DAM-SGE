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
            List<clsDepartamento> list;

            try
            {
                list = new listadoDepartamentosDAL().getListadoDepartamentos();
            }catch(Exception e)
            {
                throw e;
            }
            

            return list;
        }

        public clsDepartamento getDepartamentoPorID(int ID)
        {
            clsDepartamento departamento;

            try
            {
                departamento = new listadoDepartamentosDAL().getDepartamentoPorID(ID);
            }catch(Exception e)
            {
                throw e;
            }
            

            return departamento;
        }


    }
}
