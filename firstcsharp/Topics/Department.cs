using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcsharp.Topics
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public static List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department { Id = 10, Name = "IT"       },
                new Department { Id = 20, Name = "HR"       },
                new Department { Id = 30, Name = "Payroll"  },
                new Department { Id = 40, Name = "Media"},
            };
        }
    }
}
