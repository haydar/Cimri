namespace Cimri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ibanChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserCompanies", "Iban", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserCompanies", "Iban");
        }
    }
}
