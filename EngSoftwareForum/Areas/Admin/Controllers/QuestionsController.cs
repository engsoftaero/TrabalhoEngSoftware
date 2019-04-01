using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EngSoftwareForum.Data;
using EngSoftwareForum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EngSoftwareForum.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestionsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public QuestionsController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET ACTION METHOD
        public async Task<IActionResult> Index()
        {
            return View(await _db.Questions.ToListAsync());
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST CREATE
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Questions question_par)
        {
            if (ModelState.IsValid)
            {
                //if valid
                _db.Add(question_par);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            return View(question_par);
        }

        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var question_par = await _db.Questions.FindAsync(id);
            if (question_par == null)
            {
                return NotFound();
            }
            return View(question_par);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Questions question_par)
        {
            if (ModelState.IsValid)
            {
                _db.Update(question_par);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(question_par);
        }


        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var question_par = await _db.Questions.FindAsync(id);
            if (question_par == null)
            {
                return NotFound();
            }
            return View(question_par);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var questio_par = await _db.Questions.FindAsync(id);

            if (questio_par == null)
            {
                return View();
            }

            _db.Questions.Remove(questio_par);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var question_par = await _db.Questions.FindAsync(id);
            if (question_par == null)
            {
                return NotFound();
            }
            return View(question_par);
        }

    }
}