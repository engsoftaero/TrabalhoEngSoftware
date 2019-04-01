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
    }
}