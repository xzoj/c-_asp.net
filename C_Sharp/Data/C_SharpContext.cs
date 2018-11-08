using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace C_Sharp.Models
{
    public class C_SharpContext : DbContext
    {
        public C_SharpContext (DbContextOptions<C_SharpContext> options)
            : base(options)
        {
        }

        public DbSet<C_Sharp.Models.Student> Student { get; set; }
    }
}
