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
        private Entities dbModel
        {
            get
            {
                return DBModel.entities;
            }
        }

        public List<tblAdmin> getAllAdmins()
        {
            return dbModel.tblAdmin.ToList();
        }

        public int addAdmin(tblAdmin admin) {
            tblAdmin mAdmin = dbModel.tblAdmin.Add(admin);
           int effectedRow = dbModel.SaveChanges();
           return effectedRow;
        }

        public tblAdmin getAdmin(string userName) {
            return dbModel.tblAdmin.FirstOrDefault(o => o.username == userName);
        }

        public tblAdmin getAdmin(int id)
        {
            return dbModel.tblAdmin.FirstOrDefault(o => o.id == id);
        }

        public int deleteAdmin(int id) {
            dbModel.tblAdmin.Remove(getAdmin(id));
            return dbModel.SaveChanges();
        }


    }
}
