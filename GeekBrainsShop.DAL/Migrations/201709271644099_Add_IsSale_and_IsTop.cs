namespace GeekBrainsShop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_IsSale_and_IsTop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Footwears", "IsSale", c => c.Boolean(nullable: false));
            AddColumn("dbo.Footwears", "IsTop", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Footwears", "IsTop");
            DropColumn("dbo.Footwears", "IsSale");
        }
    }
}
