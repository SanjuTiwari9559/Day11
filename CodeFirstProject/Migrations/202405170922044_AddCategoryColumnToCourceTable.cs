namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryColumnToCourceTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "category_Id", c => c.Int());
            CreateIndex("dbo.Courses", "category_Id");
            AddForeignKey("dbo.Courses", "category_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "category_Id", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "category_Id" });
            DropColumn("dbo.Courses", "category_Id");
        }
    }
}
