using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public class Company
    {
        public string Name { get; set; }
        private List<Employee> Employees { get; set; }

        public Company(string name)
        {
           Employee=new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public Employee GetEmployeeById(int id)
        {
            foreach (Employee emp in Employees)
            {
                if(Employee emp in Employees)
                {
                    return emp;
                }
            }
        }
     

        public void RemoveEmployee(Employee employee)
        {
            if (!Employees.Contains(employee))
            {
                throw new EmployeeNotFound(employee.Id);
            }
            Employees.Remove(employee);
        }

    }


}

