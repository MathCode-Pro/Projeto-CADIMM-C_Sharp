using Cadimm.Data;
using Cadimm.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadimm.Services
{
    public class CidadeService
    {
        private readonly CadimmContext _context;

        public CidadeService(CadimmContext context)
        {
            _context = context;
        }
    }
}
