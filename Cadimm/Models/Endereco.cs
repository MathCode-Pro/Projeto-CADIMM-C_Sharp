using K4os.Compression.LZ4.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string Rua { get; private set; }
        public string Complemento { get; private set; }
        public string Setor { get; private set; }

        [Display(Name = "CEP")]
        public int Cep { get; private set; }

        public Estado Estado { get; set; }
        public Cidade Cidade { get; set; }
        public int MembroId { get; set; }

        [Display(Name = "Cidade")]
        public int CidadeId { get; set; }

        [Display(Name = "Estado")]
        public int EstadoId { get; set; }

        public Endereco()
        {
        }

        public Endereco(int id, string rua, string complemento, string setor, int cep, Estado estado, Cidade cidade)
        {
            Id = id;
            Rua = rua;
            Complemento = complemento;
            Setor = setor;
            Cep = cep;
            Estado = estado;
            Cidade = cidade;
        }
    }
}
