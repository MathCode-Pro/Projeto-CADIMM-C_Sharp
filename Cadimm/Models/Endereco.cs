using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class Endereco
    {
        public int Id { get; private set; }
        public String Rua { get; private set; }
        public String Complemento { get; private set; }
        public String Setor { get; private set; }
        public int Cep { get; private set; }

        private SortedDictionary<string, string> Cidade_Estado { get; set; } = new SortedDictionary<string, string>();

        public Endereco(int id, string rua, string complemento, string setor, int cep)
        {
            Id = id;
            Rua = rua;
            Complemento = complemento;
            Setor = setor;
            Cep = cep;
        }
    }
}
