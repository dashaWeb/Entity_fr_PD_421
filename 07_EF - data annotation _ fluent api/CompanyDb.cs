using _07_EF___data_annotation___fluent_api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_EF___data_annotation___fluent_api
{
    internal class CompanyDB : DbContext
    {
        public CompanyDB()
        {
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent Api configuration
            modelBuilder.Entity<Department>().ToTable("Positions");
            modelBuilder.Entity<Department>()
                .Property(d => d.Name)
                .IsRequired() // not null
                .HasMaxLength(100) // nvarchar(100)
                .HasColumnName("FirstName");
            modelBuilder.Entity<Department>()
                .Property(d => d.Phone)
                .IsRequired() // not null
                .IsFixedLength(true)
                .HasMaxLength(20)// nvarchar(100)
                .IsUnicode(true);

            modelBuilder.Entity<Worker>().HasKey(d => d.Number);
            modelBuilder.Entity<Worker>()
                .Property(w => w.Name)
                .IsRequired()
                .HasMaxLength(100);

            // one to many (1 ... *)
            modelBuilder.Entity<Worker>()
                .HasOne(f => f.Country)
                .WithMany(f => f.Workers)
                .HasForeignKey(f => f.CountryId);

            modelBuilder.Entity<Worker>()
                .HasOne(f => f.Department)
                .WithMany(f => f.Workers)
                .HasForeignKey(f => f.DepartmentId);

            // many to many
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Workers)
                .WithMany(p => p.Projects);


            modelBuilder.SeedCountries();
            modelBuilder.SeedDepartments();
            modelBuilder.SeedProjects();
            modelBuilder.SeedWorkers();

        }
    }
}
