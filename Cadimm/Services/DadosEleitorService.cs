﻿using Cadimm.Data;
using Cadimm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Services
{
    public class DadosEleitorService
    {
        private readonly CadimmContext _context;

        public DadosEleitorService(CadimmContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(DadosEleitor obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
    }
}
