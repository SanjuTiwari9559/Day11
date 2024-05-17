namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameInCouseTableInPlaceofTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String());
            DropColumn("dbo.Courses", "title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "title", c => c.String());
            DropColumn("dbo.Courses", "Name");
        }
    }
}
