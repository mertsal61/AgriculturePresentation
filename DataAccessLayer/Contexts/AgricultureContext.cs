using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class AgricultureContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MERT\\SQLEXPRESS;database=DbAgriculture;integrated security=true");
        }
        public DbSet<Adress> adresses { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Annoucement> annoucements { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Team> teams { get; set; }
    }
}
