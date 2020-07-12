using Cadimm.Data;
using Cadimm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Services
{
    public class TelefoneService
    {
        private readonly CadimmContext _context;

        public TelefoneService(CadimmContext context)
        {
            _context = context;
        }
        internal async Task InsertAsync(ICollection<Telefone> telefones)
        {
            foreach (Telefone telefone in telefones)
            {
                _context.Add(telefone);
                await _context.SaveChangesAsync();

            }
        }
    }
}
