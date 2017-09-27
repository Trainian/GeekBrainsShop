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
                new Footwear() { FootwearId = 1, Price = 1500, ImageLink = @"/Content/Images/classic_1_small.jpg", TrademarkId = 1, IsSale = true, IsTop = false },
                new Footwear() { FootwearId = 2, Price = 2500, ImageLink = @"/Content/Images/classic_2_small.jpg", TrademarkId = 1, SalePrice = 3500, IsSale = false, IsTop = true },
                new Footwear() { FootwearId = 3, Price = 3500, ImageLink = @"/Content/Images/classic_3_small.jpg", TrademarkId = 1, IsSale = true, IsTop = true },
                new Footwear() { FootwearId = 4, Price = 1500, ImageLink = @"/Content/Images/sport_1_small.jpg", TrademarkId = 2, SalePrice = 2500, IsSale = false, IsTop = false },
                new Footwear() { FootwearId = 5, Price = 2500, ImageLink = @"/Content/Images/classic_1_small.jpg", TrademarkId = 1, IsSale = true, IsTop = false },
                new Footwear() { FootwearId = 6, Price = 3500, ImageLink = @"/Content/Images/classic_2_small.jpg", TrademarkId = 1, SalePrice = 4500, IsSale = false, IsTop = true },
                new Footwear() { FootwearId = 7, Price = 1500, ImageLink = @"/Content/Images/classic_3_small.jpg", TrademarkId = 1, IsSale = true, IsTop = true },
                new Footwear() { FootwearId = 8, Price = 2500, ImageLink = @"/Content/Images/sport_1_small.jpg", TrademarkId = 2, SalePrice = 3500, IsSale = false, IsTop = false });

            context.Trademark.AddOrUpdate(x => x.TrademarkId,
                new Trademark() { TrademarkId = 1, TrademarkName = "Hrenden" },
                new Trademark() { TrademarkId = 2, TrademarkName = "Diher" });

            context.SaveChanges();
        }
    }
}
