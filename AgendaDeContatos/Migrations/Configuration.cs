namespace AgendaDeContatos.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AgendaDeContatos.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AgendaDeContatos.EntidadesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AgendaDeContatos.EntidadesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Contatos.AddOrUpdate(
                  p => p.nome,
                  new Contato
                  {
                      nome = "Ederson",
                      cpf = 99999999999,
                      rg = 999999999,
                      telefone1 = 21999999999,
                     

                  });
            context.SaveChanges();
                  


            



    }
    }
}
