namespace TecGurusMiddleMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    // Enable-Migrations –ContextTypeName TecGurusMiddleMVC.CodeFirstExample.DBContextCodeFirst

    internal sealed class Configuration : DbMigrationsConfiguration<TecGurusMiddleMVC.CodeFirstExample.DBContextCodeFirst>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        // Puedeo insertar catalogos. Sembrar
        protected override void Seed(TecGurusMiddleMVC.CodeFirstExample.DBContextCodeFirst context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
