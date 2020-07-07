using System;
using System.Collections.Generic;
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
