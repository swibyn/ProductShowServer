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
        ProductShowEntities dbModel = new ProductShowEntities();
        
        public tblUser getUserByUserName(string userName)
        {
            return dbModel.tblUsers.FirstOrDefault(o => o.username == userName);
            
        }

    }
}
