using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_EF_CodeFirst.Entities
{
    public class Worker
    {
        public Worker()
        {
            Projects = new HashSet<Project>();
        }
        // id / ID / Id / WorkerId--> PK 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
        public string FullName { get => Name + " " + Surname; } 
        public /*Nullable<DateTime>*/ DateTime ?Birthdate { get; set; }

       
        // foreign key
        public int CountryId { get; set; }
        public int DepartmentId { get; set; }

        // Property navigation 
        public Country Country { get; set; }
        public Department Department { get; set; }

        // many to many
        public ICollection<Project> Projects { get; set; }
    }
}
