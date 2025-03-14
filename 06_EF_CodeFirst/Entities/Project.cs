﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_EF_CodeFirst.Entities
{
    public class Project
    {
        public Project()
        {
            Workers = new HashSet<Worker>();
        }
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime LaunchDate { get; set; }

        // Navigation Property
        public ICollection<Worker> Workers { get; set; }
    }
}
