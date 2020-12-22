using AtividadeCibergestion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtividadeCibergestion.DAO
{
    public class ColaboradorInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ColaboradorContext>
    {
        protected override void Seed(ColaboradorContext context)
        {
            var colaboradores = new List<Colaborador>
            {
            new Colaborador{NomeColaborador="Gabriel", TelefoneColaborador="(11) 986133429", TipoTelefone=Tipo.Celular},
            new Colaborador{NomeColaborador="José", TelefoneColaborador="Label", TipoTelefone=Tipo.Residencial}
            };

            colaboradores.ForEach(s => context.Colaboradores.Add(s));
            context.SaveChanges();            
        }
    }
}