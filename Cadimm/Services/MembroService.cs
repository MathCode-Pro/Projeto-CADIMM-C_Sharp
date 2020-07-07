using Cadimm.Data;
using Cadimm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Services
{
    public class MembroService
    {
        private readonly CadimmContext _context;

        public MembroService(CadimmContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(Membro obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Membro>> BuscarMembros()
        {
            return await _context.Membro.ToListAsync();
        }
    }
}
