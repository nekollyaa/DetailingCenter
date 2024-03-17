using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailingCenterDbLib
{
    public class Employee
    {
        public long? SqlId { get; init; }
        public string Name { get; init; }
        public string Surname { get; init; }
        public string Patronymic { get; init; }
        public string Phone { get; init; }
        public string Education { get; init; }
        public string Position { get; init; }
        public string Salary { get; init; }
    }
}
