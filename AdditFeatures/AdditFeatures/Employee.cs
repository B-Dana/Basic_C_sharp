﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditFeatures
{
    public class Employee
    {
        public Employee(string name) : this(name, 105)
        {
        }
        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public string Name { get; set; }
        public int ID { get; set; }

    }
}
