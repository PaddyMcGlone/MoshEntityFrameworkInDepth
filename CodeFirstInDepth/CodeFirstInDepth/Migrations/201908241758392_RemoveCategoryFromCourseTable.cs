namespace CodeFirstInDepth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCategoryFromCourseTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Category_CategoryId" });
            DropColumn("dbo.Courses", "Category_CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Category_CategoryId", c => c.Int());
            CreateIndex("dbo.Courses", "Category_CategoryId");
            AddForeignKey("dbo.Courses", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
