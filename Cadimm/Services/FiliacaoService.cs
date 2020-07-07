using Cadimm.Data;
using Cadimm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Services
{
    public class FiliacaoService
    {
        private readonly CadimmContext _context;

        public FiliacaoService(CadimmContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(Filiacao obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
    }
}
