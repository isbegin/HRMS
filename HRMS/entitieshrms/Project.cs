using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entitieshrms
{
    public class Project 
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectDate { get; set; }
        public String ProjectManager { get; set; }
        public List<string> ProjectMembers{ get; set; }
        public string ProjectClient { get; set; }
    }
}
