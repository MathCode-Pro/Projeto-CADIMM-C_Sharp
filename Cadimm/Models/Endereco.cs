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
        public int Cep { get; private set; }

        public SortedDictionary<string, List<string>> Cidade_Estado = new SortedDictionary<string, List<string>>();
        private ICollection<Membro> Membros { get; set; }

        [Display(Name = "Membro")]
        public int MembroId { get; private set; }
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

        public void AddCidadeEstado(string estado, List<string> cidade)
        {
            Cidade_Estado.Add(estado, cidade);
        }
    }
}
