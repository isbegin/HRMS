using System;
using System.ComponentModel.DataAnnotations;

namespace entitieshrms
{
    public class Annoucement 
    {
        [Key]
        public int AnnouncementId { get; set; }
        public string AnnoucementBy { get; set; }
        public DateTime AnnoucementDate { get; set; }
        public string AnnouncementMessage { get; set; }

    }
}
