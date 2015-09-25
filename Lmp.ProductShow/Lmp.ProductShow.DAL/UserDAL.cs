using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lmp.ProductShow.Model;


namespace Lmp.ProductShow.DAL
{
    public class UserDAL
    {
        //Entities dbModel = new Entities();

        private Entities dbModel
        {
            get
            {
                return DBModel.entities;
            }
        }
        public tblUser getUserByUserName(string userName)
        {
            return dbModel.tblUser.FirstOrDefault(o => o.username == userName);
            
        }

    }
}
