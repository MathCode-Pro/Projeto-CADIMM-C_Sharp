using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class DadosEleitor
    {
        public int Id { get; private set; }
        public int Titulo { get; private set; }
        public int Zona { get; private set; }
        public int Secao { get; private set; }

        public DadosEleitor(int id, int titulo, int zona, int secao)
        {
            Id = id;
            Titulo = titulo;
            Zona = zona;
            Secao = secao;
        }
    }
}
