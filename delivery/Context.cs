using delivery.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace delivery
{
    public class Context : DbContext
    {
        public Context() : base("delivery") { }

        public DbSet<Contato> Contatos { get; set; }
    }
}