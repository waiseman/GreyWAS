using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GreyWAS.Shared;

namespace GreyWAS.Server.Data
{
    public class GreyWASServerContext : DbContext
    {
        public GreyWASServerContext (DbContextOptions<GreyWASServerContext> options)
            : base(options)
        {
        }

        public DbSet<GreyWAS.Shared.Student> Student { get; set; } = default!;
    }
}
