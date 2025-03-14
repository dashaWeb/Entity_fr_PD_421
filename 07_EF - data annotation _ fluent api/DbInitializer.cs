using _07_EF___data_annotation___fluent_api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_EF___data_annotation___fluent_api
{
    public static class DbInitializer
    {
        // seeder - initializator
        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new Country[]
                {
                    new Country() {
                        Id = 1,
                        Name = "Ukraine"
                    },
                    new Country() {
                        Id = 2,
                        Name = "Poland"
                    },
                    new Country() {
                        Id = 3,
                        Name = "USA"
                    }
                });

        }
        public static void SeedDepartments(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(new Department[]
                {
                    new Department() {
                        Id = 1,
                         Name = "Management", Phone = "14-85-96"
                    },
                    new Department() {
                        Id = 2,
                       Name = "Programming", Phone = "74-85-96"
                    },
                    new Department() {
                        Id = 3,
                        Name = "Design", Phone = "12-96-54"
                    }
                });
        }
        public static void SeedProjects(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(new Project[]
                {
                    new Project() {
                        Id = 1,
                        Name = "Tetris", LaunchDate = new DateTime(1982, 12, 12),
                    },
                    new Project() {
                        Id = 2,
                        Name = "PacMan", LaunchDate = new DateTime(2003, 12, 12),
                    },
                    new Project() {
                        Id = 3,
                        Name = "CS", LaunchDate = new DateTime(2012, 12, 12),
                    }
                });
        }
        public static void SeedWorkers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().HasData(new Worker[]
                {
                    new Worker() {
                        Number = 1,
                        Name = "Emma",
                        Surname = "Miller",
                        Salary = 2500,
                        Birthdate = new DateTime(2005, 2, 3),
                        CountryId = 1,
                        DepartmentId = 1,
                    },
                    new Worker() {
                        Number = 2,
                        Name = "Oleg",
                        Surname = "King",
                        Salary = 3300,
                        Birthdate = new DateTime(2007, 4, 23),
                        CountryId = 2,
                        DepartmentId = 2,
                    },
                    new Worker() {
                        Number = 3,
                        Name = "Tomm",
                        Surname = "Joe",
                        Salary = 4300,
                        Birthdate = new DateTime(2002, 12, 12),
                        CountryId = 3,
                        DepartmentId = 3,
                    }
                });
        }
    }
}
