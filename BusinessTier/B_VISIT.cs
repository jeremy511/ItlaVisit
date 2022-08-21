using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using EntityTier;

namespace BusinessTier
{
    public class B_VISIT
    {
        D_VISIT OBJ_DATA = new D_VISIT();
        public List<E_VISIT> ListAllVisit()
        {
            return OBJ_DATA.ListAllVisit();
        }


        public void InsertVisit(E_VISIT visit)
        {
            OBJ_DATA.InsertVisit(visit);
        }

        public void EditVisit(E_VISIT visit)
        {
            OBJ_DATA.EditVisit(visit);
        }

        public void DeleteVisit(E_VISIT visit)
        {
            OBJ_DATA.DeleteVisit(visit);
        }
    }
}
