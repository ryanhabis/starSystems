using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using starSystems.Models;

namespace starSystems.Data
{
    public class starSystemsContext : DbContext
    {
        public starSystemsContext (DbContextOptions<starSystemsContext> options)
            : base(options)
        {
        }

        public DbSet<starSystems.Models.Planets> Planets { get; set; } = default!;
    }
}
