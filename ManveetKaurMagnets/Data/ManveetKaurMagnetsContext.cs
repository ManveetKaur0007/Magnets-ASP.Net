using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManveetKaurMagnets.Models;

namespace ManveetKaurMagnets.Data
{
    public class ManveetKaurMagnetsContext : DbContext
    {
        public ManveetKaurMagnetsContext (DbContextOptions<ManveetKaurMagnetsContext> options)
            : base(options)
        {
        }

        public DbSet<ManveetKaurMagnets.Models.Magnets> Magnets { get; set; }
    }
}
