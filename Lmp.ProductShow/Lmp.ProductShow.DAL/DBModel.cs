using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lmp.ProductShow.Model;


namespace Lmp.ProductShow.DAL
{
    public static class DBModel
    {
        private static Lazy<Entities> _entities = new Lazy<Entities>();

        public static Entities entities {
            get 
            {
                return DBModel._entities.Value;
            }
        }

    }
}
