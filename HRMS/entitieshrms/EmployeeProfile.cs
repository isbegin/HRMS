using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entitieshrms
{
    public class EmployeeProfile
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; }
        public string EmployeeGroup { get; set; }
        public string EmployeeEmail { get; set; }
    }
}
