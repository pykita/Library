namespace Library.Factory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "CreatedDate", c => c.String());
        }
    }
}
