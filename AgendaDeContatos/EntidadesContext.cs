using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgendaDeContatos.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AgendaDeContatos
{
    public class EntidadesContext : DbContext
    {
        public EntidadesContext() : base("EntidadesContext") { }
        public DbSet<Contato> Contatos { get; set; }
    }
}