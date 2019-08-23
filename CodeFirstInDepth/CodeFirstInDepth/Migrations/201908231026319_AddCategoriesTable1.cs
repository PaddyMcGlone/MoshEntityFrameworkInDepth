namespace CodeFirstInDepth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
                Sql("INSERT INTO Categories VALUES(1, 'Web development')");
                Sql("INSERT INTO Categories VALUES(2, 'Programming languages')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
