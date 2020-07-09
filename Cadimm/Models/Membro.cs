using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Models
{
    public class Membro
    {
        public int Id { get; private set; }
        public String Nome { get; private set; }

        [Display(Name = "E-mail")]
        public String Email { get; private set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime Nascimento { get; private set; }

        [Display(Name = "Nome do Pai")]
        public String NomePai { get; private set; }

        [Display(Name = "Nome da Mãe")]
        public String NomeMae { get; private set; }

        [Display(Name = "CPF")]
        public int Cpf { get; private set; }

        [Display(Name = "RG")]
        public int Rg { get; private set; }

        [Display(Name = "Estado Civil")]
        public String EstadoCivil { get; private set; }
        public String Escolaridade { get; private set; }

        [Display(Name = "Filiado a CADIMM?")]
        public bool Filiado { get; private set; }
        public ICollection<Telefone> Telefones { get; private set; }
        public Conjugue Conjugue { get; set; }
        public DadosEleitor DadosEleitor { get; set; }
        public ICollection<Endereco> Enderecos { get; private set; }
        public Filiacao Filiacao { get; private set; }

        public Membro()
        {
        }

        public Membro(int id, string nome, string email, DateTime nascimento, string nomePai, string nomeMae, int cpf, int rg, string estadoCivil, string escolaridade, bool filiado, Conjugue conjugue, DadosEleitor dadosEleitor, Filiacao filiacao)
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
            Conjugue = conjugue;
            DadosEleitor = dadosEleitor;
            Filiacao = filiacao;
        }

        public void AddTelefone(Telefone telefone)
        {
            Telefones.Add(telefone);
        }
        public void AddEndereco(Endereco endereco)
        {
            Enderecos.Add(endereco);
        }
    }
}
