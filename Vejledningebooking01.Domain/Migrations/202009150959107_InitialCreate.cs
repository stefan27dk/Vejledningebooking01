namespace Vejledningebooking01.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Calendars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Holds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Calendar_Id = c.Int(),
                        Student_Id = c.Int(),
                        Teacher_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Calendars", t => t.Calendar_Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .Index(t => t.Calendar_Id)
                .Index(t => t.Student_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Timeslots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Calendar_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Calendars", t => t.Calendar_Id)
                .Index(t => t.Calendar_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Timeslots", "Calendar_Id", "dbo.Calendars");
            DropForeignKey("dbo.Holds", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.Holds", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Holds", "Calendar_Id", "dbo.Calendars");
            DropIndex("dbo.Timeslots", new[] { "Calendar_Id" });
            DropIndex("dbo.Holds", new[] { "Teacher_Id" });
            DropIndex("dbo.Holds", new[] { "Student_Id" });
            DropIndex("dbo.Holds", new[] { "Calendar_Id" });
            DropTable("dbo.Timeslots");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Holds");
            DropTable("dbo.Calendars");
            DropTable("dbo.Bookings");
        }
    }
}
