using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entitieshrms
{
    public class Attendance 
    {
        [Key]
        public int EmployeeID { get; set; }
        public int WeeklyAttendance { get; set; }
        public int MonthlyAttandance { get; set; }

        public int WorkingDaysInMonth { get; set; }
        public int PresentDays { get; set; }
    }
}
