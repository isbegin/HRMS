namespace entitieshrms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hrmsinit2 : DbMigration
    {
        public override void Up()
        {
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
            
            CreateTable(
                "dbo.WorkSchedules",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PublicHolidays = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AlterColumn("dbo.EmployeeProfiles", "EmployeeId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.EmployeeProfiles", "WeeklyAttendance");
            DropColumn("dbo.EmployeeProfiles", "MonthlyAttandance");
            DropColumn("dbo.EmployeeProfiles", "WorkingDaysInMonth");
            DropColumn("dbo.EmployeeProfiles", "PresentDays");
            DropColumn("dbo.EmployeeProfiles", "id");
            DropColumn("dbo.EmployeeProfiles", "PublicHolidays");
            DropColumn("dbo.EmployeeProfiles", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeProfiles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.EmployeeProfiles", "PublicHolidays", c => c.DateTime());
            AddColumn("dbo.EmployeeProfiles", "id", c => c.Int());
            AddColumn("dbo.EmployeeProfiles", "PresentDays", c => c.Int());
            AddColumn("dbo.EmployeeProfiles", "WorkingDaysInMonth", c => c.Int());
            AddColumn("dbo.EmployeeProfiles", "MonthlyAttandance", c => c.Int());
            AddColumn("dbo.EmployeeProfiles", "WeeklyAttendance", c => c.Int());
            AlterColumn("dbo.EmployeeProfiles", "EmployeeID", c => c.Int());
            DropTable("dbo.WorkSchedules");
            DropTable("dbo.Attendances");
        }
    }
}
