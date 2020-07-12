using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class Estado
    {
        public int Id { get; private set; }
        public string Sigla { get; private set; }

        [Display(Name = "Estado")]
        public string Nome { get; private set; }
        public ICollection<Cidade> Cidade { get; set; }

        public Estado()
        {
        }

        public Estado(int id, string sigla, string nome)
        {
            Id = id;
            Sigla = sigla;
            Nome = nome;
        }
    }
}
