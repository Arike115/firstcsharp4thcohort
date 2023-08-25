using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcsharp.Topics
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { Id = 1, Name = "Preety", DepartmentId = 30 },
                new Employee { Id = 2, Name = "Priyanka", DepartmentId = 20 },
                new Employee { Id = 3, Name = "Anurag", DepartmentId = 30 },
                new Employee { Id = 3, Name = "Pranaya", DepartmentId = 20 },
                new Employee { Id = 3, Name = "Hina", DepartmentId = 20 },
                new Employee { Id = 6, Name = "Sambit", DepartmentId = 10 },
                new Employee { Id = 7, Name = "Happy", DepartmentId = 0},
                new Employee { Id = 8, Name = "Tarun", DepartmentId = 0},
                new Employee { Id = 9, Name = "Santosh", DepartmentId = 10 },
                new Employee { Id = 10, Name = "Raja", DepartmentId = 10},
                new Employee { Id = 11, Name = "Sudhanshu", DepartmentId = 10}
            };
        }
    }
}
