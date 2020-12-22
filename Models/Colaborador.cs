using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AtividadeCibergestion.Models
{
    public class Colaborador
    {
        [DisplayName("Código")]
        public int ID { get; set; }
        [DisplayName("Nome"), Required]
        public string NomeColaborador { get; set; }
        [DisplayName("Telefone"), Required]
        public string TelefoneColaborador { get; set; }
        [DisplayName("Tipo"), Required]
        public Tipo TipoTelefone { get; set; }
    }

    public enum Tipo
    {
        Celular,
        Residencial,
        Trabalho,
        Whatsapp
    }
}