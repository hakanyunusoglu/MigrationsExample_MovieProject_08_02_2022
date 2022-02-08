namespace MigrationExample08_02_2022.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMovieTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        MovieName = c.String(),
                        MovieDescription = c.String(),
                        MovieTitle = c.String(),
                        MovieImage = c.String(),
                    })
                .PrimaryKey(t => t.MovieID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
