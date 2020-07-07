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
        public String Nome { get; private set; }
        public Membro Membro { get; private set; }

        [Display(Name ="Membro")]
        public int MembroId { get; private set; }

        public Conjugue()
        {
        }

        public Conjugue(int id, string nome, Membro membro)
        {
            Id = id;
            Nome = nome;
            Membro = membro;
        }
    }
}
