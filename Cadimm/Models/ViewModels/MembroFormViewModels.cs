using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models.ViewModels
{
    public class MembroFormViewModels
    {
        public Membro Membro { get; set; }
        public Conjugue Conjugue { get; set; }
        public DadosEleitor DadosEleitor { get; set; }
        public Endereco Endereco { get; set; }
        public Filiacao Filiacao { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
        public ICollection<Cidade> Cidades { get; set; }
        public ICollection<Estado> Estados { get; set; }
    }
}
