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

        public SortedDictionary<Estado, List<Cidade>> Cidade_Estado = new SortedDictionary<Estado, List<Cidade>>();
        public int MembroId { get; set; }
        public int CidadeId { get; set; }

        public Endereco()
        {
        }

        public Endereco(int id, string rua, string complemento, string setor, int cep)
        {
            Id = id;
            Rua = rua;
            Complemento = complemento;
            Setor = setor;
            Cep = cep;
        }

        public void AddCidadeEstado(Estado estado, List<Cidade> cidades)
        {
            Cidade_Estado.Add(estado, cidades);
        }
    }
}
