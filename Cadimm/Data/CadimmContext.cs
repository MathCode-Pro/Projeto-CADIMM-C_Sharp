using Microsoft.EntityFrameworkCore;
using Cadimm.Models;

namespace Cadimm.Data
{
    public class CadimmContext : DbContext
    {
        public CadimmContext (DbContextOptions<CadimmContext> options)
            : base(options)
        {
        }

        public DbSet<Membro> Membro { get; set; }
        public DbSet<Conjugue> Conjugue { get; set; }
        public DbSet<DadosEleitor> DadosEleitor { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Filiacao> Filiacao { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Estado> Estado { get; set; }
    }
}
