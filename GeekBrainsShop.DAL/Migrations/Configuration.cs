namespace GeekBrainsShop.DAL.Migrations
{
    using GeekBrainsShop.Domain.Employees;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GeekBrainsShop.DAL.Employees.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GeekBrainsShop.DAL.Employees.LibraryContext context)
        {
            context.Footwear.AddOrUpdate(x => x.FootwearId,
                new Footwear() { FootwearId = 1, Price = 1500, MinSize = 39, MaxSize = 46, VendorCode = "MX23-33X", ImageLink = @"/Content/Images/classic_1_small.jpg", TrademarkId = 1, IsSale = true, IsTop = false, IsNew = false, Subscribe = "asddf", SeasonId = 1 },
                new Footwear() { FootwearId = 2, Price = 2500, MinSize = 39, MaxSize = 46, VendorCode = "MX13-35X", ImageLink = @"/Content/Images/classic_2_small.jpg", TrademarkId = 1, SalePrice = 1500, IsSale = false, IsTop = true, IsNew = false, Subscribe = "asddf", SeasonId = 2 },
                new Footwear() { FootwearId = 3, Price = 3500, MinSize = 40, MaxSize = 45, VendorCode = "LX23-32M", ImageLink = @"/Content/Images/classic_3_small.jpg", TrademarkId = 1, IsSale = true, IsTop = true, IsNew = false, Subscribe = "asddf", SeasonId = 1 },
                new Footwear() { FootwearId = 4, Price = 1500, MinSize = 40, MaxSize = 46, VendorCode = "KL63-18L", ImageLink = @"/Content/Images/sport_1_small.jpg", TrademarkId = 4, SalePrice = 1500, IsSale = true, IsTop = true, IsNew = true, Subscribe = "asddf", SeasonId = 2 },
                new Footwear() { FootwearId = 5, Price = 2500, MinSize = 41, MaxSize = 46, VendorCode = "MF22-30S", ImageLink = @"/Content/Images/classic_1_small.jpg", TrademarkId = 1, IsSale = false, IsTop = false, IsNew = true, Subscribe = "asddf", SeasonId = 1 },
                new Footwear() { FootwearId = 6, Price = 3500, MinSize = 39, MaxSize = 45, VendorCode = "MG53-12Z", ImageLink = @"/Content/Images/classic_2_small.jpg", TrademarkId = 1, SalePrice = 2000, IsSale = false, IsTop = true, IsNew = true, Subscribe = "asddf", SeasonId = 1 },
                new Footwear() { FootwearId = 7, Price = 1500, MinSize = 39, MaxSize = 44, VendorCode = "SD60-64A", ImageLink = @"/Content/Images/classic_3_small.jpg", TrademarkId = 1, IsSale = true, IsTop = false, IsNew = true, Subscribe = "asddf", SeasonId = 2 },
                new Footwear() { FootwearId = 8, Price = 2500, MinSize = 39, MaxSize = 45, VendorCode = "ZK00-22F", ImageLink = @"/Content/Images/sport_1_small.jpg", TrademarkId = 4, SalePrice = 2000, IsSale = false, IsTop = false, IsNew = false, Subscribe = "asddf", SeasonId = 1 });

            context.Trademark.AddOrUpdate(x => x.TrademarkId,
                new Trademark() { TrademarkId = 1, TrademarkName = "Zenden" },
                new Trademark() { TrademarkId = 2, TrademarkName = "Zenden Wooman" },
                new Trademark() { TrademarkId = 3, TrademarkName = "Zenden Active" },
                new Trademark() { TrademarkId = 4, TrademarkName = "Zenden Collection" },
                new Trademark() { TrademarkId = 5, TrademarkName = "Zenden Comfort" },
                new Trademark() { TrademarkId = 6, TrademarkName = "Dixer" },
                new Trademark() { TrademarkId = 7, TrademarkName = "Instreet" },
                new Trademark() { TrademarkId = 8, TrademarkName = "Rieker" },
                new Trademark() { TrademarkId = 9, TrademarkName = "Thomas Munz" },
                new Trademark() { TrademarkId = 10, TrademarkName = "Marco Tozzi" });

            context.Season.AddOrUpdate(x => x.SeasonId,
                new Season() { SeasonId = 1, SeasonName = "Лето" },
                new Season() { SeasonId = 2, SeasonName = "Весная/Осень" },
                new Season() { SeasonId = 2, SeasonName = "Зима" },
                new Season() { SeasonId = 2, SeasonName = "Всесезон" });

            context.SaveChanges();
        }
    }
}
