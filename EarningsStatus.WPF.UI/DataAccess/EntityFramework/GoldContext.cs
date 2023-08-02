using EarningsStatus.WPF.UI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarningsStatus.WPF.UI.DataAccess.EntityFramework
{
    public class GoldContext : DbContext
    {
        public GoldContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;initial catalog=EarningsStatusDb;integrated security=true;MultipleActiveResultSets=True");
        }

        public DbSet<Gold>? Golds { get; set; }
    }
}
