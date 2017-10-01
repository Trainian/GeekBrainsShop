namespace GeekBrainsShop.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footwears",
                c => new
                    {
                        FootwearId = c.Int(nullable: false, identity: true),
                        VendorCode = c.String(nullable: false, maxLength: 250),
                        MinSize = c.Int(nullable: false),
                        MaxSize = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        SalePrice = c.Int(),
                        Subscribe = c.String(nullable: false, maxLength: 2500),
                        ImageLink = c.String(nullable: false, maxLength: 500),
                        IsSale = c.Boolean(nullable: false),
                        IsTop = c.Boolean(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        TrademarkId = c.Int(nullable: false),
                        SeasonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FootwearId)
                .ForeignKey("dbo.Seasons", t => t.SeasonId, cascadeDelete: true)
                .ForeignKey("dbo.Trademarks", t => t.TrademarkId, cascadeDelete: true)
                .Index(t => t.TrademarkId)
                .Index(t => t.SeasonId);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        SeasonId = c.Int(nullable: false, identity: true),
                        SeasonName = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.SeasonId);
            
            CreateTable(
                "dbo.Trademarks",
                c => new
                    {
                        TrademarkId = c.Int(nullable: false, identity: true),
                        TrademarkName = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.TrademarkId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Footwears", "TrademarkId", "dbo.Trademarks");
            DropForeignKey("dbo.Footwears", "SeasonId", "dbo.Seasons");
            DropIndex("dbo.Footwears", new[] { "SeasonId" });
            DropIndex("dbo.Footwears", new[] { "TrademarkId" });
            DropTable("dbo.Trademarks");
            DropTable("dbo.Seasons");
            DropTable("dbo.Footwears");
        }
    }
}
