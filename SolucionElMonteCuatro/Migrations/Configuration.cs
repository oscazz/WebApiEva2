namespace SolucionElMonteCuatro.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SolucionElMonteCuatro.Models.MonteDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SolucionElMonteCuatro.Models.MonteDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.addOrUp
            //llenado de datos con seeders
            context.Delitos.AddOrUpdate(c => c.Nombre,
                new Models.Delito() { Nombre = "homicidio",CondenaMinima=5, CondenaMaxima=20},
                new Models.Delito() { Nombre = "Femicidio",CondenaMinima=5,CondenaMaxima=20},
                new Models.Delito() { Nombre = "Robo con Intimidacion",CondenaMinima=1,CondenaMaxima=12 },
                new Models.Delito() { Nombre = "Robo en lugar no habitado",CondenaMinima=1,CondenaMaxima=5 },
                new Models.Delito() { Nombre = "Cohecho" ,CondenaMinima=5,CondenaMaxima=5}

                );
           
        }
    }
}
