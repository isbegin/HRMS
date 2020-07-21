using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace entitieshrms
{
    class HRMSContext : DbContext
    {
        public HRMSContext() : base("HRMSDB")
        {

        }
        public DbSet<Annoucement> Annoucements { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<SystemLog> SystemLog { get; set; }
        public DbSet<WorkSchedule> WorkSchedule { get; set; }

    }
    }
