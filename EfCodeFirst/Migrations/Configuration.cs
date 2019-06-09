namespace EfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EfCodeFirst.Models.BlogContexModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EfCodeFirst.Models.BlogContexModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //esto es un metodo que se ejecuta cuando ejecutamos el update-databsae
            //Esto lo hacemos si queremos hacer un insert, delete, etc sin tener que crear vista o que se yo
            context.comentarios.AddOrUpdate(x => x.Id, new Models.ComentarioModel()
            {
                Id = 001,
                Autor = "eje-autor-comentario",
                BlogPostId = 001,
                Contenido = "eje-contenido-comentario"
            });
        }
    }
}
