using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitieshrms
{
    class DepartmentModule
    {
        public WorkSchedule WorkSchedule { get; set; }
        public Project Projects { get; set; }
        public Department Departments { get; set; }
        public SystemLog SystemLog { get; set; }
    }
}
