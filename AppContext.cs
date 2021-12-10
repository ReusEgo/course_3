using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Policlinic_.Net_Core_
{
    class AppContext : DbContext
    {
        public DbSet<Policlinic> Policlinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Procedure> Procedures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = PoliclinicDB; Trusted_Connection=True");
        }
    }
}
