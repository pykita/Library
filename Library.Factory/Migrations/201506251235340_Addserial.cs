namespace Library.Factory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addserial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Serial", c => c.String());
            AddColumn("dbo.Books", "Modify", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Modify");
            DropColumn("dbo.Books", "Serial");
        }
    }
}
