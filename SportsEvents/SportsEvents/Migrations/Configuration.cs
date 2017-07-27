namespace SportsEvents.Migrations
{
    using SportsEvents.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SportsEvents.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.ApplicationDbContext context)
        {
            #region
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            #endregion

            var events = new List<Event>
            {
                new Event{ EventName = "International Champion Cup: Real Madrid - FC Barcelona", Sport="Football"},
                new Event{ EventName = "International Champion Cup: Juventus - AS Roma", Sport="Football"},
                new Event{ EventName = "Australian Open ATP: Federer R. - Nadal R.", Sport="Tennis"},
                new Event{ EventName = "UEFA Champions League: FC Viitorul - APOEL", Sport="Football"},
                new Event{ EventName = "NBA West Conference: Los Angeles Clippers - Golden State Warriors", Sport="Basketball"},
                new Event{ EventName = "Champions League: Flensburg-H - Veszprem", Sport="Handball"},
            };

            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();
        }
    }
}
