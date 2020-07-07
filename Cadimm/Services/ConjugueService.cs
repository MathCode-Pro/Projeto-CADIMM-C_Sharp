using Cadimm.Data;
using Cadimm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Services
{
    public class ConjugueService
    {
        private readonly CadimmContext _context;

        public ConjugueService(CadimmContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(Conjugue obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
    }
}
