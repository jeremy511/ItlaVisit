using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTier;
using DataTier;
using System.Data;

namespace BusinessTier
{
    public class B_USER
    {
       D_USER objData = new D_USER();
        public void InsertUser(E_USER user)
        {
            objData.InsertUser(user);
        }
        public DataTable LoginUser(E_USER user)
        {
            return objData.LoginUser(user);
        }

    }
}
