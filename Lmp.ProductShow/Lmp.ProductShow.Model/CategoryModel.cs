using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lmp.ProductShow.Model
{
    public class CategoryModel
    {
        public long id;
        public string name;
        public long parent;
        public List<CategoryModel> children;
    }
}
