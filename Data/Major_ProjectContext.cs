using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Major_Project.Models;

namespace Major_Project.Data
{
    public class Major_ProjectContext : DbContext
    {
        public Major_ProjectContext (DbContextOptions<Major_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Major_Project.Models.Customer> Customer { get; set; }

        public DbSet<Major_Project.Models.Staff> Staff { get; set; }

        public DbSet<Major_Project.Models.Car> Car { get; set; }

        public DbSet<Major_Project.Models.Store> Store { get; set; }

        public DbSet<Major_Project.Models.Buy> Buy { get; set; }
    }
}
