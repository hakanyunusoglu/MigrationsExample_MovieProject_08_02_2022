namespace MigrationExample08_02_2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationshipBetweenCategoryAndMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Category_CategoryID", c => c.Int());
            CreateIndex("dbo.Movies", "Category_CategoryID");
            AddForeignKey("dbo.Movies", "Category_CategoryID", "dbo.Categories", "CategoryID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Movies", new[] { "Category_CategoryID" });
            DropColumn("dbo.Movies", "Category_CategoryID");
        }
    }
}
