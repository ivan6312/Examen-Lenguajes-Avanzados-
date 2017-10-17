using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ivan.Models
{
    public class IvanContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public IvanContext() : base("name=IvanContext")
        {
        }

        public System.Data.Entity.DbSet<Ivan.Models.Autos> Autos { get; set; }

        public System.Data.Entity.DbSet<Ivan.Models.Central> Centrals { get; set; }

        public System.Data.Entity.DbSet<Ivan.Models.Choferes> Choferes { get; set; }

        public System.Data.Entity.DbSet<Ivan.Models.Gastos> Gastos { get; set; }

        public System.Data.Entity.DbSet<Ivan.Models.Usuarios> Usuarios { get; set; }

        public System.Data.Entity.DbSet<Ivan.Models.Viajes> Viajes { get; set; }
    }
}
