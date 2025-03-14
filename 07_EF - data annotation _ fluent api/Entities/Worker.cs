using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_EF___data_annotation___fluent_api.Entities
{
    public class Worker
    {
        public Worker()
        {
            Projects = new HashSet<Project>();
        }
        // id / ID / Id / WorkerId--> PK 
        //[Key] // primary key
        public int Number { get; set; }
        /*[Column("FirstName")]
        [Required] // not null
        [MaxLength(50)] // length line*/
        public string Name { get; set; }
        //[Required, Column("LastName"), MaxLength(50)]
        public string Surname { get; set; }
        public double Salary { get; set; }
        public string FullName { get => Name + " " + Surname; }
        [NotMapped]
        public string Email { get; set; }
        public /*Nullable<DateTime>*/ DateTime? Birthdate { get; set; }


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
