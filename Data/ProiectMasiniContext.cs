using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectMasini.Models;

namespace ProiectMasini.Data
{
    public class ProiectMasiniContext : DbContext
    {
        public ProiectMasiniContext (DbContextOptions<ProiectMasiniContext> options)
            : base(options)
        {
        }

        public DbSet<ProiectMasini.Models.Car> Car { get; set; }
    }
}
