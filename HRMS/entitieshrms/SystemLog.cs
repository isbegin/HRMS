using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entitieshrms
{
   public class SystemLog 
    {
        [Key]
        public int LogId { get; set; }
        public string LogText { get; set; }
        public DateTime LogDateTime { get; set; }
    }
}
