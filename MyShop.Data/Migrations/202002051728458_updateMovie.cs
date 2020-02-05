namespace MyShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMovie : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Movies", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "ID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Movies", "ID");
        }
    }
}
