using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lmp.ProductShow.Model;
using Lmp.ProductShow.DAL;

namespace Lmp.ProductShow.BLL
{
    public  class AdminBLL
    {
        AdminDAL adminDAL = new AdminDAL();

        public List<tblAdmin> getAllAdmins()
        {
            return adminDAL.getAllAdmins();
        }

        public int addAdmin(tblAdmin admin)
        {
            if (adminDAL.getAdmin(admin.username) != null)
            {
                return 0;
            }
            else
            {
                return adminDAL.addAdmin(admin);
            }            
        }

        public tblAdmin loginIn(tblAdmin admin)
        {
            var mAdmin = adminDAL.getAdmin(admin.username);
            if (admin.password == mAdmin.password)
            {
                return mAdmin;
            }
            else
            {
                return null;
            }
        }

        public int deleteAdmin(int id)
        {
            return adminDAL.deleteAdmin(id);
        }
    }
}
