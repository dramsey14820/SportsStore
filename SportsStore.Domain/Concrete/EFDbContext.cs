using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {

        #region Properties

        // Product is our "model" and Products is the name of our table.
        public DbSet<Product> Products { get; set; }

        #endregion
    }
}
