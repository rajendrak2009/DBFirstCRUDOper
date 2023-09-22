using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DBFirstCRUDOper.Models;

namespace DBFirstCRUDOper.Data
{
    public class DBFirstCRUDOperContext : DbContext
    {
        public DBFirstCRUDOperContext (DbContextOptions<DBFirstCRUDOperContext> options)
            : base(options)
        {
        }

        public DbSet<DBFirstCRUDOper.Models.Product> Product { get; set; } = default!;
    }
}
