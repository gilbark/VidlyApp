namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(1,'Comedy')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(2,'Action')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(3,'Family')");
            Sql("INSERT INTO Genres(Id, GenreName) VALUES(4,'Romance')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
