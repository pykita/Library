namespace Library.Factory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "CreatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "CreatedDate");
        }
    }
}
