﻿using System;
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



        //REPLY AREA BEGINS
        //GET - EDIT
        public async Task<IActionResult> EditReply(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var reply_par = await _db.Replies.FindAsync(id);
            if (reply_par == null)
            {
                return NotFound();
            }
            return View(reply_par);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditReply(Replies reply_par)
        {
            if (ModelState.IsValid)
            {
                _db.Update(reply_par);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
                //return View();
            }

            return View(reply_par);
        }


        //GET - DELETE
        public async Task<IActionResult> DeleteReply(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var question_par = await _db.Replies.FindAsync(id);
            if (question_par == null)
            {
                return NotFound();
            }
            return View(question_par);
        }

        [HttpPost, ActionName("DeleteReply")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedReply(int? id)
        {
            var questio_par = await _db.Replies.FindAsync(id);

            if (questio_par == null)
            {
                return View();
            }

            _db.Replies.Remove(questio_par);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //REPLY AREA ENDS




        //GET - DETAILS
        public async Task<IActionResult> Details(int? id)
        {
            CommonViewModel model = new CommonViewModel();
            model.Questions = new Questions();
            model.RepliesLOL = new Replies();

            if (id == null)
            {
                return NotFound();
            }
            model.Questions = await _db.Questions.FindAsync(id);
            if (model.Questions== null)
            {
                return NotFound();
            }

            if (id == null)
            {
                return NotFound();
            }
            var RepliesLOL = await _db.Replies.ToListAsync();
            if (RepliesLOL == null)
            {
                return NotFound();
            }

            ViewBag.Replies = RepliesLOL;

            return View(model);
        }



        //GET - DETAILS - REPLY
        //GET - CREATE
        public async Task<IActionResult> Answer(int? id)
        {
            CommonViewModel model = new CommonViewModel();
            model.Questions = new Questions();

            if (id == null)
            {
                return NotFound();
            }
            model.Questions = await _db.Questions.FindAsync(id);
            if (model.Questions == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Answer(CommonViewModel reply_par)
        {
            CommonViewModel model = new CommonViewModel(); //para poder salvar em replies no db
            model.RepliesLOL = new Replies();
            model.RepliesLOL = reply_par.RepliesLOL;
            reply_par.Questions.Title = "JustATitle";
            reply_par.Questions.Question = "JustATitle";

            model.RepliesLOL.QuestionID = reply_par.Questions.Id; //salva o id da pergunta na tabela de replies

            if (model.RepliesLOL.ReplyString != null)
            {
                _db.Add(model.RepliesLOL);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

    }
}

