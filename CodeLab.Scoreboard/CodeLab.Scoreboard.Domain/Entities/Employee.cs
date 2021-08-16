﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Scoreboard.Domain.Entities
{
    public class Employee
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public bool IsRetired { get; private set; }

        public Employee(string name)
        {
            Name = name;
            IsRetired = false;
        }

        public Employee(string name, string lastName = null, DateTime? birthDate = null) : this(name)
        {
            LastName = lastName;
            BirthDate = birthDate;
        }

    }
}