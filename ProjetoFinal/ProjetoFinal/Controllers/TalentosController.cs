using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Data;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers
{
    public class TalentosController : Controller
    {
        private readonly ProjetoFinalContext _context;
        private readonly IWebHostEnvironment _hostEnviroment;

        public TalentosController(ProjetoFinalContext context, IWebHostEnvironment hostEnviroment)
        {
            _context = context;
            this._hostEnviroment = hostEnviroment;
        }

        // GET: Talentoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Talento.ToListAsync());
        }

        public async Task<IActionResult> ShowTalents(string area)
        {
            ViewData["Categoria"] = area;

            return View(await _context.Talento.Where(item => item.Profissao.Contains(area)).ToListAsync());
        }


        /*
        public string ShowTalentos(string area)
        {
            return "passando >> " + area;
        }*/


        // GET: Talentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var talento = await _context.Talento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (talento == null)
            {
                return NotFound();
            }

            return View(talento);
        }

        // GET: Talentoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Talentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Imagem, Nome, Localidade, Sobre, Profissao, Email, Telefone, Formacao, Local1, Funcao1, Atividade1, Local2, Funcao2, Atividade2, Instituicao1, CargaHoraria1, Instituicao2, CargaHoraria2, Aprendeu, Habilidades, Area, Nivel")] Talento talento)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnviroment.WebRootPath;

                string fileName = Path.GetFileNameWithoutExtension(talento.Imagem.FileName);
                string extension = Path.GetExtension(talento.Imagem.FileName);
                string newFileName = string.Format("{0}{1}{2}", fileName, DateTime.Now.ToString("yymmssfff"), extension);

                talento.ImagemNome = newFileName;

                string path = Path.Combine(string.Format("{0}/img/userImage", wwwRootPath), newFileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await talento.Imagem.CopyToAsync(fileStream);
                }

                _context.Add(talento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(talento);
        }

        // GET: Talentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var talento = await _context.Talento.FindAsync(id);
            if (talento == null)
            {
                return NotFound();
            }
            return View(talento);
        }

        // POST: Talentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Imagem,Nome,Cidade,Estado,Bio,Profissao,Email,Telefone,Area,Nivel")] Talento talento)
        {
            if (id != talento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(talento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TalentoExists(talento.Id))
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
            return View(talento);
        }

        // GET: Talentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var talento = await _context.Talento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (talento == null)
            {
                return NotFound();
            }

            return View(talento);
        }

        // POST: Talentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var talento = await _context.Talento.FindAsync(id);
            _context.Talento.Remove(talento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TalentoExists(int id)
        {
            return _context.Talento.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Areas()
        {
            return View(await _context.Talento.ToListAsync());
        }
    }
}
