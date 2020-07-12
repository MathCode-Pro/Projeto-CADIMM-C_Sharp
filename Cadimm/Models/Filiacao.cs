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

        [Display(Name = "Filiado em")]
        public string FiliadoEm { get; private set; }

        [Display(Name = "Será Consagrado?")]
        public bool seraConsagrado { get; private set; }

        [Display(Name = "Consagração Atual")]
        public string ConsagAtual { get; private set; }

        [Display(Name = "Consagração Pretendida")]
        public string ConsagPretendida { get; private set; }
        public int MembroId { get; private set; }
        public Filiacao()
        {
        }

        public Filiacao(int id, string filiadoEm, bool seraConsagrado, string consagAtual, string consagPretendida)
        {
            Id = id;
            FiliadoEm = filiadoEm;
            this.seraConsagrado = seraConsagrado;
            ConsagAtual = consagAtual;
            ConsagPretendida = consagPretendida;       
        }
    }
}
