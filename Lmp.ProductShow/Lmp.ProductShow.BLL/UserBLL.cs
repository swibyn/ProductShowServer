using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lmp.ProductShow.DAL;
using Lmp.ProductShow.Model;

namespace Lmp.ProductShow.BLL
{
    class UserBLL
    {
        UserDAL userDAL = new UserDAL();

        public tblUser login(string userName, string password)
        {
            tblUser user = userDAL.getUserByUserName(userName);
            if (user != null){
                if (String.Equals(password,user.password)){
                    return user;
                }
            }
            return null;
        }
        
    }
}
