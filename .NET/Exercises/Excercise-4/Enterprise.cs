﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    public class Enterprise
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public Employee[]? Employees { get; set; } = new Employee[0];
    }
}
