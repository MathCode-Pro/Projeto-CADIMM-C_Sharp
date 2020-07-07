using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class Conjugue
    {
        public int Id { get; private set; }
        public String Nome { get; private set; }

        public Conjugue(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
