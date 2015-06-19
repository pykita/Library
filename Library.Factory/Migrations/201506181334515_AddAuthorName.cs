namespace Library.Factory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthorName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "AuthorName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "AuthorName");
        }
    }
}
