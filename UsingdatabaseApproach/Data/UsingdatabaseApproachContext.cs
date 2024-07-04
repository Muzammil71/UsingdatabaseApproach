using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsingdatabaseApproach.Models;

namespace UsingdatabaseApproach.Data
{
    public class UsingdatabaseApproachContext : DbContext
    {
        public UsingdatabaseApproachContext (DbContextOptions<UsingdatabaseApproachContext> options)
            : base(options)
        {
        }

        public DbSet<UsingdatabaseApproach.Models.Medicine> Medicine { get; set; } = default!;
    }
}
