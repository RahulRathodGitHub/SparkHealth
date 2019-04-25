using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lapbase.Models
{
    public class LapbaseContext : DbContext
    {
        public LapbaseContext(DbContextOptions<LapbaseContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patient { get; set; }
    }
}
