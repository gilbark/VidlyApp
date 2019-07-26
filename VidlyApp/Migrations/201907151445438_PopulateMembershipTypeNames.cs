namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET TypeName = 'Pay as You Go' WHERE Id=1 ");
            Sql("UPDATE MembershipTypes SET TypeName = 'Monthly' WHERE Id=2 ");
            Sql("UPDATE MembershipTypes SET TypeName = 'Quarterly' WHERE Id=3");
            Sql("UPDATE MembershipTypes SET TypeName = 'Annualy' WHERE Id=4");
        }

        public override void Down()
        {
        }
    }
}
