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

<<<<<<< HEAD
        public System.Data.Entity.DbSet<DhakaCreditGym.Models.Employees> Employees { get; set; }
=======
        public System.Data.Entity.DbSet<DhakaCreditGym.Models.Members> Members { get; set; }
>>>>>>> 0caa13698cc74e23215b4bbfd4fddcc7c354e813
    }
}