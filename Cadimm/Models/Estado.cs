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

        [Display(Name = "Estado")]
        public string Nome { get; private set; }
        public ICollection<Cidade> Cidade { get; private set; }

        public Estado()
        {
        }

        public Estado(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddCidade(Cidade cidade)
        {
            Cidade.Add(cidade);
        }
    }
}
