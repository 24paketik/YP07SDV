using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wpf
{
    internal class ApplicationContext:DbContext
    {
        public DbSet<AttachedProduct> attachedProducts { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=46.42.17.183;Database=St2_Smirnov_Salon1;Trusted_Connection=True;");
        }
    }
}
