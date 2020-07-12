using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class Cidade
    {
        public int Id { get; private set; }
        public int EstadoId { get; set; }

        [Display(Name = "Cidade")]
        public string Nome { get; private set; }
        public Estado Estado { get; set; }
        public Cidade()
        {
        }

        public Cidade(int id, string nome, Estado estado)
        {
            Id = id;
            Nome = nome;
            Estado = estado;
        }
    }
}
