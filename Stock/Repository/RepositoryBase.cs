using Stock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Repository
{
    internal class RepositoryBase
    {
        protected StockContext _dbContect = new StockContext();
    }
}
