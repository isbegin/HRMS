namespace entitieshrms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hrmsinit1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeProfiles", "WeeklyAttendance", c => c.Int());
            AddColumn("dbo.EmployeeProfiles", "MonthlyAttandance", c => c.Int());
            AddColumn("dbo.EmployeeProfiles", "WorkingDaysInMonth", c => c.Int());
            AddColumn("dbo.EmployeeProfiles", "PresentDays", c => c.Int());
            AddColumn("dbo.EmployeeProfiles", "id", c => c.Int());
            AddColumn("dbo.EmployeeProfiles", "PublicHolidays", c => c.DateTime());
            AddColumn("dbo.EmployeeProfiles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.EmployeeProfiles", "EmployeeID", c => c.Int());
            DropTable("dbo.Attendances");
            DropTable("dbo.WorkSchedules");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WorkSchedules",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PublicHolidays = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        WeeklyAttendance = c.Int(nullable: false),
                        MonthlyAttandance = c.Int(nullable: false),
                        WorkingDaysInMonth = c.Int(nullable: false),
                        PresentDays = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            AlterColumn("dbo.EmployeeProfiles", "EmployeeId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.EmployeeProfiles", "Discriminator");
            DropColumn("dbo.EmployeeProfiles", "PublicHolidays");
            DropColumn("dbo.EmployeeProfiles", "id");
            DropColumn("dbo.EmployeeProfiles", "PresentDays");
            DropColumn("dbo.EmployeeProfiles", "WorkingDaysInMonth");
            DropColumn("dbo.EmployeeProfiles", "MonthlyAttandance");
            DropColumn("dbo.EmployeeProfiles", "WeeklyAttendance");
        }
    }
}
