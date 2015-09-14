using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lmp.ProductShow.Model;

namespace Lmp.ProductShow.DAL
{
    public class AdminDAL
    {
        ProductShowEntities dbModel = new ProductShowEntities();
        public List<tblAdmin> getAllAdmins()
        {
            return dbModel.tblAdmins.ToList();
        }

        public int addAdmin(tblAdmin admin) {
           tblAdmin mAdmin = dbModel.tblAdmins.Add(admin);
           int effectedRow = dbModel.SaveChanges();
           return effectedRow;
        }

        public tblAdmin getAdmin(string userName) {
            return dbModel.tblAdmins.FirstOrDefault(o => o.username == userName);
        }

        public tblAdmin getAdmin(int id)
        {
            return dbModel.tblAdmins.FirstOrDefault(o => o.id == id);
        }

        public int deleteAdmin(int id) { 
            dbModel.tblAdmins.Remove(getAdmin(id));
            return dbModel.SaveChanges();
        }


    }
}
