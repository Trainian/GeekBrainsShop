namespace GeekBrainsShop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_IsNew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Footwears", "IsNew", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Footwears", "IsNew");
        }
    }
}
