using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mavies;

namespace Mavies.Data
{
    public class MaviesContext : DbContext
    {
        public MaviesContext (DbContextOptions<MaviesContext> options)
            : base(options)
        {
        }

        public DbSet<Mavies.Movie> Movie { get; set; } = default!;
    }
}
