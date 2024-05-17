namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAutherandCategoryfromCourseTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "category_Id", "dbo.Categories");
            DropForeignKey("dbo.Courses", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "category_Id" });
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            DropColumn("dbo.Courses", "category_Id");
            DropColumn("dbo.Courses", "Author_Id");
            DropTable("dbo.Authors");
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Courses", "Author_Id", c => c.Int());
            AddColumn("dbo.Courses", "category_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Author_Id");
            CreateIndex("dbo.Courses", "category_Id");
            AddForeignKey("dbo.Courses", "Author_Id", "dbo.Authors", "Id");
            AddForeignKey("dbo.Courses", "category_Id", "dbo.Categories", "Id");
        }
    }
}
