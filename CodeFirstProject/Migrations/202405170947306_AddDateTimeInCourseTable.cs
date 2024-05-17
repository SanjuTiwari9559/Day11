namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTimeInCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "time");
        }
    }
}
