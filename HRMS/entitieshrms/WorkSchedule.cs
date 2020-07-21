using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entitieshrms
{
    public class WorkSchedule 
    {
        [Key]
        public int id { get; set; }
        public DateTime PublicHolidays { get; set; }
    }
}
