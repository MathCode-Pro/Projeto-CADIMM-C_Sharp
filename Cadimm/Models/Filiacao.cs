using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class Filiacao
    {
        public int Id { get; private set; }
        public String FiliadoEm { get; private set; }
        public bool seraConsagrado { get; private set; }
        public String ConsagAtual { get; private set; }
        public String ConsagPretendida { get; private set; }
        private Membro Membro { get; set; }

        [Display(Name = "Membro")]
        public int MembroId { get; private set; }
        public Filiacao()
        {
        }

        public Filiacao(int id, string filiadoEm, bool seraConsagrado, string consagAtual, string consagPretendida, Membro membro)
        {
            Id = id;
            FiliadoEm = filiadoEm;
            this.seraConsagrado = seraConsagrado;
            ConsagAtual = consagAtual;
            ConsagPretendida = consagPretendida;
            Membro = membro;
        }
    }
}
