namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies(Id,Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES(1,'Hangover',1,'6/11/2009','4/5/2016',5)");
            Sql("INSERT INTO Movies(Id,Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES(2,'Die Hard',1,'3/5/1995','4/5/2016',2)");
            Sql("INSERT INTO Movies(Id,Name,GenreId,ReleaseDate,DateAdded,NumberInStock) VALUES(3,'The Terminator',1,'5/4/1997','4/5/2016',3)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
