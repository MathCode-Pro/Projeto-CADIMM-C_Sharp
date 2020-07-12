using Cadimm.Data;
using Cadimm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Services
{
    public class EstadoService
    {
        private readonly CadimmContext _context;

        public EstadoService(CadimmContext context)
        {
            _context = context;
        }

        public async Task<List<Estado>> BuscarEstadosAssync()
        {
            return await _context.Estado.OrderBy(x => x.Sigla).ToListAsync();
        }
    }
}
