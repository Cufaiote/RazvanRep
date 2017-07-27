namespace SalesDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesDatabase.Sales>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SalesDatabase.Sales context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(
              p => p.Name,
              new Models.Product { Name = "Mere" },
              new Models.Product { Name = "Pere"},
              new Models.Product { Name = "Chestii"}
            );

            context.Products.AddOrUpdate(
              p => p.Quantity,
              new Models.Product { Quantity = 200 },
              new Models.Product { Quantity = 100 },
              new Models.Product { Quantity = 20002.75f }
              );

            context.Products.AddOrUpdate(
              p => p.Price,
              new Models.Product { Price = 3 },
              new Models.Product { Price = 5 },
              new Models.Product { Price = 999.99f }
              );

            context.Customers.AddOrUpdate(
                p => p.Name,
                new Models.Customer { Name = "Gigi Barbu", Email = "Gigi@exact.com", CreditCardNumber = "1000-2000-3000-4000" },
                new Models.Customer { Name = "Ana Maria", Email = "Ana@sigur.ro", CreditCardNumber = "1000-1001-1002-1003" },
                new Models.Customer { Name = "Pop Ion", Email = "Pop@indubitabil.com", CreditCardNumber = "1111-2222-3333-4444" }
                );

            context.Saless.AddOrUpdate(
               );
            //
        }
    }
}
