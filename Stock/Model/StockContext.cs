using Stock.Model.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Model
{
    public class StockContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public StockContext()
            : base("DefaultConnection")
        {
        }
    }
}
