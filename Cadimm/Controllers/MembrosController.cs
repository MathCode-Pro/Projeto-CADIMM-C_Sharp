using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cadimm.Data;
using Cadimm.Models;
using Cadimm.Services;
using Cadimm.Models.ViewModels;

namespace Cadimm.Controllers
{
    public class MembrosController : Controller
    {
        private readonly CadimmContext _context;
        private readonly EstadoService _estadoService;
        private readonly CidadeService _cidadeService;
        private readonly ConjugueService _conjugueService;
        private readonly DadosEleitorService _dadosEleitorService;
        private readonly EnderecoService _enderecoService;
        private readonly FiliacaoService _filiacaoService;
        private readonly TelefoneService _telefoneService;

        public MembrosController(CadimmContext context, EstadoService estadoService, CidadeService cidadeService, ConjugueService conjugueService, DadosEleitorService dadosEleitorService, EnderecoService enderecoService, FiliacaoService filiacaoService, TelefoneService telefoneService)
        {
            _context = context;
            _estadoService = estadoService;
            _cidadeService = cidadeService;
            _conjugueService = conjugueService;
            _dadosEleitorService = dadosEleitorService;
            _enderecoService = enderecoService;
            _filiacaoService = filiacaoService;
            _telefoneService = telefoneService;
        }



        // GET: Membros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Membro.ToListAsync());
        }

        // GET: Membros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membro = await _context.Membro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (membro == null)
            {
                return NotFound();
            }

            return View(membro);
        }

        // GET: Membros/Create
        public async Task<IActionResult> Create()
        {

            List<Estado> estados = await _estadoService.BuscarEstadosAssync();

            estados.Insert(0, new Estado(-1, "Selecione o Estado", null));

            MembroFormViewModels viewModel = new MembroFormViewModels() { Estados = estados };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetCidades(int estadoId)
        {
            var cidade = await _context.Cidade.OrderBy(c => c.Nome).Where(c => c.EstadoId == estadoId).Select(y => new { y.Id, Value = y.Nome }).ToListAsync();

            return Json(new { cidade });
        }

        // POST: Membros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Nascimento,NomePai,NomeMae,Cpf,Rg,EstadoCivil,Escolaridade,Filiado")] Membro membro, Conjugue conjugue, DadosEleitor dadosEleitor, Endereco endereco, Filiacao filiacao, Telefone telefone, int id)
        {
            if (ModelState.IsValid)
            {
                _context.Add(membro);
                _context.Add(conjugue);
                _context.Add(dadosEleitor);
                _context.Add(endereco);
                _context.Add(filiacao);
                _context.Add(telefone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(membro);
        }

        // GET: Membros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membro = await _context.Membro.FindAsync(id);
            if (membro == null)
            {
                return NotFound();
            }
            return View(membro);
        }

        // POST: Membros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Nascimento,NomePai,NomeMae,Cpf,Rg,EstadoCivil,Escolaridade,Filiado")] Membro membro)
        {
            if (id != membro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembroExists(membro.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(membro);
        }

        // GET: Membros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membro = await _context.Membro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (membro == null)
            {
                return NotFound();
            }

            return View(membro);
        }

        // POST: Membros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var membro = await _context.Membro.FindAsync(id);
            _context.Membro.Remove(membro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembroExists(int id)
        {
            return _context.Membro.Any(e => e.Id == id);
        }
    }
}
