using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NMStest.Data
{
    public class NMScontext: DbContext
    {
        public NMScontext(DbContextOptions<NMScontext> options) : base(options)
        {
            
        }
        public DbSet<NMStest.Models.Planet> Planet { get; set; }
        public DbSet<NMStest.Models.Resource> Resource { get; set; }
        public DbSet<NMStest.Models.StarSystems> StarSystems { get; set; }

    }
}
