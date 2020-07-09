using K4os.Compression.LZ4.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Membro Membro { get; private set; }
        public int MembroId { get; set; }
        public DadosEleitor()
        {
        }

        public DadosEleitor(int id, int titulo, int zona, int secao, Membro membro)
        {
            Id = id;
            Titulo = titulo;
            Zona = zona;
            Secao = secao;
            Membro = membro;
        }
    }
}
