namespace Library.Factory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Year : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Year", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Year");
        }
    }
}
