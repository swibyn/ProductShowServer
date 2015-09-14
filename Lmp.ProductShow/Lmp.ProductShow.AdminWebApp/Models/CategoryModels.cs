using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Lmp.ProductShow.Model;

namespace Lmp.ProductShow.AdminWebApp.Models
{
    public class CategoryModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        public string name { get; set; }
        public Nullable<long> parent { get; set; }

        public tblCategory totblCategory()
        {
            return new tblCategory() { id = this.id, name = this.name, parent = this.parent };
        }
    }

}