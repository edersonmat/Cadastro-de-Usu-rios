using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaDeContatos.Models
{
    public class Contato
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public Int64 cpf { get; set; }
        public int rg { get; set; }
        public Int64 telefone1 { get; set; }
        
    }
}