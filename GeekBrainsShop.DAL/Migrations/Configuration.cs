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
                new Footwear() { FootwearId = 1, Price = 1500, ImageLink = @"~\Content\Images\classic_1.jpg", TrademarkId = 1 },
                new Footwear() { FootwearId = 2, Price = 2500, ImageLink = @"~\Content\Images\classic_2.jpg", TrademarkId = 1 });

            context.Trademark.AddOrUpdate(x => x.TrademarkId,
                new Trademark() { TrademarkId = 1, TrademarkName = "Hrenden" });

            context.SaveChanges();
        }
    }
}
