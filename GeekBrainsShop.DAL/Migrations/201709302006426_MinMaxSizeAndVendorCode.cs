namespace GeekBrainsShop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MinMaxSizeAndVendorCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Footwears", "VendorCode", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Footwears", "MinSize", c => c.Int(nullable: false));
            AddColumn("dbo.Footwears", "MaxSize", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Footwears", "MaxSize");
            DropColumn("dbo.Footwears", "MinSize");
            DropColumn("dbo.Footwears", "VendorCode");
        }
    }
}
