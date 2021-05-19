using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MarriageAgency.Models;

    public class MarriageAgencyContext : DbContext
    {
        public MarriageAgencyContext (DbContextOptions<MarriageAgencyContext> options)
            : base(options)
        {
        }

        public DbSet<MarriageAgency.Models.Position> Position { get; set; }

        public DbSet<MarriageAgency.Models.Worker> Worker { get; set; }
    }
