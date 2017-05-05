using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClankWebApp.Models
{
    public class ClankWebAppContext : DbContext
    {
        public ClankWebAppContext (DbContextOptions<ClankWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<ClankWebApp.Models.Movie> Movie { get; set; }
    }
}
