using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FStore.Model
{
    public class TContexts : DbContext
    {

        public TContexts()
        {
        }

        public TContexts(DbContextOptions<TContexts> options)
            : base(options)
        {
        }

        public virtual DbSet<Models> Furniturestore { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-0V1OG2K4\\SQLEXPRESS;Initial Catalog=Furniturestore;Integrated Security=True;");
            }
        }

    }
}
