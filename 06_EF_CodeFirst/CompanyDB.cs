using _06_EF_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_EF_CodeFirst
{
    internal class CompanyDB:DbContext
    {
        public CompanyDB()
        {
            /*this.Database.EnsureDeleted();
            this.Database.EnsureCreated();*/
        }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"
                                         Data Source = (localdb)\ProjectModels;
                                         Initial Catalog = Company_PD_421;
                                         Integrated Security = True;
                                         Connect Timeout = 2;
                                         Encrypt = False;
                                         Trust Server Certificate = False;
                                         Application Intent = ReadWrite;
                                         Multi Subnet Failover = False
                                        ");
        }
    }
}
