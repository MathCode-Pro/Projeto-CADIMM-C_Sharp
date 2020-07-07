using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class Membro
    {
        public int Id { get; private set; }
        public String Nome { get; private set; }
        public String Email { get; private set; }
        public DateTime Nascimento { get; private set; }
        public String NomePai { get; private set; }
        public String NomeMae { get; private set; }
        public int Cpf { get; private set; }
        public int Rg { get; private set; }
        public String EstadoCivil { get; private set; }
        public String Escolaridade { get; private set; }
        public bool Filiado { get; private set; }

        public Membro(int id, string nome, string email, DateTime nascimento, string nomePai, string nomeMae, int cpf, int rg, string estadoCivil, string escolaridade, bool filiado)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
            NomePai = nomePai;
            NomeMae = nomeMae;
            Cpf = cpf;
            Rg = rg;
            EstadoCivil = estadoCivil;
            Escolaridade = escolaridade;
            Filiado = filiado;
        }
    }
}
