using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DhakaCreditGym.Models
{
    public class GymEntity: DbContext
    {
        public GymEntity() : base("cccul_db") { }

        public System.Data.Entity.DbSet<DhakaCreditGym.Models.Employees> Employees { get; set; }
    }
}