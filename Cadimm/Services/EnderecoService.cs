using Cadimm.Data;
using Cadimm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Services
{
    public class EnderecoService
    {
        private readonly CadimmContext _context;

        public EnderecoService(CadimmContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(Endereco obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }   
    }
}
