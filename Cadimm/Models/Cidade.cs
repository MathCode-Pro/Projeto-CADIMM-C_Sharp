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

        [Display(Name = "Cidade")]
        public string Nome { get; set; }
        public Estado Estado { get; private set; }
        public int EstadoId { get; set; }
        public Cidade()
        {
        }

        public Cidade(int id, Estado estado)
        {
            Id = id;
            Estado = estado;
        }
    }
}
