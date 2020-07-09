using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class Conjugue
    {
        public int Id { get; private set; }

        [Display(Name = "Nome do Conjugue")]
        public String Nome { get; private set; }
        public Membro Membro { get; private set; }

        [Display(Name = "Telefones do Conjugue")]
        public ICollection<Telefone> Telefones { get; private set; }
        public int MembroId { get; set; }

        public Conjugue()
        {
        }

        public Conjugue(int id, string nome, Membro membro)
        {
            Id = id;
            Nome = nome;
            Membro = membro;
        }

        public void AddTelefone(Telefone telefone)
        {
            Telefones.Add(telefone);
        }
    }
}
