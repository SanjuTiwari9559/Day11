namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAuthwrFromCourseTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "author_Id" });
            CreateIndex("dbo.Courses", "Author_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            CreateIndex("dbo.Courses", "author_Id");
        }
    }
}
