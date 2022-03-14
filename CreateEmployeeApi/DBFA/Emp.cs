using System;
using System.Collections.Generic;

#nullable disable

namespace CreateEmployeeApi.DBFA
{
    public partial class Emp
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int? Salary { get; set; }
    }
}
