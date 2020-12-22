using AtividadeCibergestion.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AtividadeCibergestion.DAO
{
    public class ColaboradorContext : DbContext
    {
        public ColaboradorContext() : base("ColaboradorContext")
        {
        }

        public DbSet<Colaborador> Colaboradores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}