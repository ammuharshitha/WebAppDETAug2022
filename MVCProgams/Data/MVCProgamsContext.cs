using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCProgams.Models;
using MVCDemo.Models;

namespace MVCProgams.Data
{
    public class MVCProgamsContext : DbContext
    {
        public MVCProgamsContext (DbContextOptions<MVCProgamsContext> options)
            : base(options)
        {
        }

        public DbSet<MVCProgams.Models.Booking> Booking { get; set; } = default!;

        public DbSet<MVCDemo.Models.Friend>? Friend { get; set; }
    }
}
