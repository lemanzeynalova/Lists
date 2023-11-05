using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
        public class Employee : Person
        {
            public decimal Salary { get; set; }
            public string Position { get; set; }
            public Gender Gender { get; set; }
        }

        public class EmployeeNotFound : Exception
        {
            public EmployeeNotFound(int id) : base($"Employee with ID {id} not found.") { }
        }

    
}
