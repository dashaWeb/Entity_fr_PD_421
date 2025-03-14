﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_EF___data_annotation___fluent_api.Entities
{
    public class Country
    {
        public Country()
        {
            Workers = new HashSet<Worker>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Property
        public ICollection<Worker> Workers { get; set; }
    }
}
