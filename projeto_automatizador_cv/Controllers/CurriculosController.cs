﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_automatizador_cv.Models;

namespace projeto_automatizador_cv.Controllers
{
    [Authorize]    
    public class CurriculosController : Controller

    {
        private readonly AppDbContext _context;
        public CurriculosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Curriculos.ToListAsync();

            return View(dados);
        }

        //CREATE
        public IActionResult Create()
        {
            var novoItem = new Curriculo();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Curriculo curriculo)
        {
            if (ModelState.IsValid)
            {
                _context.Curriculos.Add(curriculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(curriculo);
        }

        //EDIT
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Curriculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, Curriculo curriculo)
        {
            if (id != curriculo.Candidato)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Curriculos.Update(curriculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        //DETAILS
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Curriculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        //DELETE
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Curriculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Curriculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Curriculos.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
