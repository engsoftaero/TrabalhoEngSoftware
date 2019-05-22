using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
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
            CommonViewModel model = new CommonViewModel();
            model.ApplicationUser = new ApplicationUser();
            model.CountQuestions = await _db.Questions.ToListAsync();

            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                model.ApplicationUser = await _db.ApplicationUser.FindAsync(claim.Value);
            }

            return View(model);
        }

        //GET - CREATE
        public async Task<IActionResult> Create()
        {
            CommonViewModel model = new CommonViewModel();
            model.Questions = new Questions();
            model.ApplicationUser = new ApplicationUser();

            //Procura dados do usuario no database
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            model.ApplicationUser = await _db.ApplicationUser.FindAsync(claim.Value);
            model.Questions.UserID = model.ApplicationUser.Name;
            model.Questions.UserKey = model.ApplicationUser.Id;

            return View(model);
        }

        //POST CREATE
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CommonViewModel question_par)
        {
            
            if (ModelState.IsValid)
            {
                //if valid
                question_par.Questions.VoteGQ = 0; //necessary?
                _db.Add(question_par.Questions);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            return View(question_par.Questions);
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
            model.ApplicationUser = new ApplicationUser();

            //Procura dados do usuario no database
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                model.ApplicationUser = await _db.ApplicationUser.FindAsync(claim.Value);
            }

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
        
        public async Task<IActionResult> Answer(int? id)
        {
            CommonViewModel model = new CommonViewModel();
            model.Questions = new Questions();
            model.RepliesLOL = new Replies();
            model.ApplicationUser = new ApplicationUser();

            //Procura dados do usuario no database
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            model.ApplicationUser = await _db.ApplicationUser.FindAsync(claim.Value);
            model.RepliesLOL.UserID = model.ApplicationUser.Name;
            model.RepliesLOL.UserKey = model.ApplicationUser.Id; //adiciona a key do usuario na resposta

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






        
        
        public async Task<IActionResult> UpvoteQuestion(int? id)
        {
            CommonViewModel model = new CommonViewModel();
            model.ApplicationUser = new ApplicationUser();

            //Procura dados do usuario no database
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                model.ApplicationUser = await _db.ApplicationUser.FindAsync(claim.Value);
            }

            if (claimsIdentity.IsAuthenticated == false)
            {
                return RedirectToAction("Details", new { id });
            }


            if (id == null)
            {
                return NotFound();
            }


            var currentQuestion = _db.Questions.Find(id);
            if (currentQuestion == null)
                return NotFound();


            if ((currentQuestion.UsersUpVoteQ == null))
            {
                
                currentQuestion.VoteGQ = currentQuestion.VoteGQ + 1;
              

                if (currentQuestion.UsersDownVoteQ == null)
                {
                    string UsersUpVoteQ = currentQuestion.UsersUpVoteQ + ';' + model.ApplicationUser.Name;
                    currentQuestion.UsersUpVoteQ = UsersUpVoteQ;
                }

                else if (currentQuestion.UsersDownVoteQ.Contains(model.ApplicationUser.Name))
                {
                    string nomes_atualizados = "";
                    var nomes = currentQuestion.UsersDownVoteQ.Split(";");
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        if (nomes[i] == model.ApplicationUser.Name)
                        {
                            nomes[i] = "";
                        }

                        nomes_atualizados = nomes_atualizados + nomes[i] + ";";
                    }

                    currentQuestion.UsersDownVoteQ = nomes_atualizados;
 
                }
                else
                {
                    string UsersUpVoteQ = currentQuestion.UsersUpVoteQ + ';' + model.ApplicationUser.Name;
                    currentQuestion.UsersUpVoteQ = UsersUpVoteQ;
                }


                _db.SaveChanges(); //salva as mudanças na db

                return RedirectToAction("Details", new { id });

            }
            else if (currentQuestion.UsersUpVoteQ.Contains(model.ApplicationUser.Name))
            {
                return RedirectToAction("Details", new { id });
            }



            currentQuestion.VoteGQ = currentQuestion.VoteGQ + 1;

            if (currentQuestion.UsersDownVoteQ == null)
            {
                string UsersUpVoteQ = currentQuestion.UsersUpVoteQ + ';' + model.ApplicationUser.Name;
                currentQuestion.UsersUpVoteQ = UsersUpVoteQ;
            }

            else if (currentQuestion.UsersDownVoteQ.Contains(model.ApplicationUser.Name))
            {
                string nomes_atualizados = "";
                var nomes = currentQuestion.UsersDownVoteQ.Split(";");
                for (int i = 0; i < nomes.Length; i++)
                {
                    if (nomes[i] == model.ApplicationUser.Name)
                    {
                        nomes[i] = "";
                    }

                    nomes_atualizados = nomes_atualizados + nomes[i] + ";";
                }

                currentQuestion.UsersDownVoteQ = nomes_atualizados;

            }
            else
            {
                string UsersUpVoteQ = currentQuestion.UsersUpVoteQ + ';' + model.ApplicationUser.Name;
                currentQuestion.UsersUpVoteQ = UsersUpVoteQ;
            }

            _db.SaveChanges(); //salva as mudanças na db


            return RedirectToAction("Details", new { id });

        }


        public async Task<IActionResult> DownvoteQuestion(int? id)
        {
            CommonViewModel model = new CommonViewModel();
            model.ApplicationUser = new ApplicationUser();

            //Procura dados do usuario no database
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                model.ApplicationUser = await _db.ApplicationUser.FindAsync(claim.Value);
            }

            if (claimsIdentity.IsAuthenticated == false)
            {
                return RedirectToAction("Details", new { id });
            }
         

            if (id == null)
            {
                return NotFound();
            }


            var currentQuestion = _db.Questions.Find(id);
            if (currentQuestion == null)
                return NotFound();

            
            if ((currentQuestion.UsersDownVoteQ == null))
            {
                
                currentQuestion.VoteGQ = currentQuestion.VoteGQ - 1;
                

                if (currentQuestion.UsersUpVoteQ == null)
                {
                    string UsersDownVoteQ = currentQuestion.UsersDownVoteQ + ';' + model.ApplicationUser.Name;
                    currentQuestion.UsersDownVoteQ = UsersDownVoteQ;
                }

                else if (currentQuestion.UsersUpVoteQ.Contains(model.ApplicationUser.Name))
                {
                    string nomes_atualizados = "";
                    var nomes = currentQuestion.UsersUpVoteQ.Split(";");
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        if (nomes[i] == model.ApplicationUser.Name)
                        {
                            nomes[i] = "";
                        }

                        nomes_atualizados = nomes_atualizados + nomes[i] + ";";
                    }

                    currentQuestion.UsersUpVoteQ = nomes_atualizados;
                }
                else
                {
                    string UsersDownVoteQ = currentQuestion.UsersDownVoteQ + ';' + model.ApplicationUser.Name;
                    currentQuestion.UsersDownVoteQ = UsersDownVoteQ;
                }
                

                _db.SaveChanges(); //salva as mudanças na db

                return RedirectToAction("Details", new { id });
            }
            else if (currentQuestion.UsersDownVoteQ.Contains(model.ApplicationUser.Name))
            {
                return RedirectToAction("Details", new { id });
            }



           
            currentQuestion.VoteGQ = currentQuestion.VoteGQ - 1;


            if (currentQuestion.UsersUpVoteQ == null)
            {
                string UsersDownVoteQ = currentQuestion.UsersDownVoteQ + ';' + model.ApplicationUser.Name;
                currentQuestion.UsersDownVoteQ = UsersDownVoteQ;
            }

            else if (currentQuestion.UsersUpVoteQ.Contains(model.ApplicationUser.Name))
            {
                string nomes_atualizados = "";
                var nomes = currentQuestion.UsersUpVoteQ.Split(";");
                for (int i = 0; i < nomes.Length; i++)
                {
                    if (nomes[i] == model.ApplicationUser.Name)
                    {
                        nomes[i] = "";
                    }

                    nomes_atualizados = nomes_atualizados + nomes[i] + ";";
                }

                currentQuestion.UsersUpVoteQ = nomes_atualizados;
            }
            else
            {
                string UsersDownVoteQ = currentQuestion.UsersDownVoteQ + ';' + model.ApplicationUser.Name;
                currentQuestion.UsersDownVoteQ = UsersDownVoteQ;
            }

            _db.SaveChanges(); //salva as mudanças na db



            return RedirectToAction("Details", new { id });

        }







        //Gammification Answers

        public async Task<IActionResult> UpvoteReplies(int? id)
        {
            CommonViewModel model = new CommonViewModel();
            model.ApplicationUser = new ApplicationUser();

            //Procura dados do usuario no database
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                model.ApplicationUser = await _db.ApplicationUser.FindAsync(claim.Value);
            }

            if (id == null)
            {
                return NotFound();
            }


            var currentReply = _db.Replies.Find(id);
            id = currentReply.QuestionID;
            if (currentReply == null)
                return NotFound();

            if (claimsIdentity.IsAuthenticated == false)
            {
                return RedirectToAction("Details", new { id });
            }

            if ((currentReply.UsersUpVoteR == null))
            {

                currentReply.VoteGR = currentReply.VoteGR + 1;


                if (currentReply.UsersDownVoteR == null)
                {
                    string UsersUpVoteR = currentReply.UsersUpVoteR + ';' + model.ApplicationUser.Name;
                    currentReply.UsersUpVoteR = UsersUpVoteR;
                }

                else if (currentReply.UsersDownVoteR.Contains(model.ApplicationUser.Name))
                {
                    string nomes_atualizados = "";
                    var nomes = currentReply.UsersDownVoteR.Split(";");
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        if (nomes[i] == model.ApplicationUser.Name)
                        {
                            nomes[i] = "";
                        }

                        nomes_atualizados = nomes_atualizados + nomes[i] + ";";
                    }

                    currentReply.UsersDownVoteR = nomes_atualizados;

                }
                else
                {
                    string UsersUpVoteR = currentReply.UsersUpVoteR + ';' + model.ApplicationUser.Name;
                    currentReply.UsersUpVoteR = UsersUpVoteR;
                }


                _db.SaveChanges(); //salva as mudanças na db

                return RedirectToAction("Details", new { id });

            }
            else if (currentReply.UsersUpVoteR.Contains(model.ApplicationUser.Name))
            {
                return RedirectToAction("Details", new { id });
            }



            currentReply.VoteGR = currentReply.VoteGR + 1;

            if (currentReply.UsersDownVoteR == null)
            {
                string UsersUpVoteR = currentReply.UsersUpVoteR + ';' + model.ApplicationUser.Name;
                currentReply.UsersUpVoteR = UsersUpVoteR;
            }

            else if (currentReply.UsersDownVoteR.Contains(model.ApplicationUser.Name))
            {
                string nomes_atualizados = "";
                var nomes = currentReply.UsersDownVoteR.Split(";");
                for (int i = 0; i < nomes.Length; i++)
                {
                    if (nomes[i] == model.ApplicationUser.Name)
                    {
                        nomes[i] = "";
                    }

                    nomes_atualizados = nomes_atualizados + nomes[i] + ";";
                }

                currentReply.UsersDownVoteR = nomes_atualizados;

            }
            else
            {
                string UsersUpVoteR = currentReply.UsersUpVoteR + ';' + model.ApplicationUser.Name;
                currentReply.UsersUpVoteR = UsersUpVoteR;
            }

            _db.SaveChanges(); //salva as mudanças na db


            return RedirectToAction("Details", new { id });

        }


        public async Task<IActionResult> DownvoteReplies(int? id)
        {
            CommonViewModel model = new CommonViewModel();
            model.ApplicationUser = new ApplicationUser();

            //Procura dados do usuario no database
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                model.ApplicationUser = await _db.ApplicationUser.FindAsync(claim.Value);
            }

            if (id == null)
            {
                return NotFound();
            }


            var currentReply = _db.Replies.Find(id);
            if (currentReply == null)
                return NotFound();
            id = currentReply.QuestionID;


            if (claimsIdentity.IsAuthenticated == false)
            {
                return RedirectToAction("Details", new { id });
            }


            if ((currentReply.UsersDownVoteR == null))
            {

                currentReply.VoteGR = currentReply.VoteGR - 1;


                if (currentReply.UsersUpVoteR == null)
                {
                    string UsersDownVoteR = currentReply.UsersDownVoteR + ';' + model.ApplicationUser.Name;
                    currentReply.UsersDownVoteR = UsersDownVoteR;
                }

                else if (currentReply.UsersUpVoteR.Contains(model.ApplicationUser.Name))
                {
                    string nomes_atualizados = "";
                    var nomes = currentReply.UsersUpVoteR.Split(";");
                    for (int i = 0; i < nomes.Length; i++)
                    {
                        if (nomes[i] == model.ApplicationUser.Name)
                        {
                            nomes[i] = "";
                        }

                        nomes_atualizados = nomes_atualizados + nomes[i] + ";";
                    }

                    currentReply.UsersUpVoteR = nomes_atualizados;
                }
                else
                {
                    string UsersDownVoteR = currentReply.UsersDownVoteR + ';' + model.ApplicationUser.Name;
                    currentReply.UsersDownVoteR = UsersDownVoteR;
                }


                _db.SaveChanges(); //salva as mudanças na db

                return RedirectToAction("Details", new { id });

            }
            else if (currentReply.UsersDownVoteR.Contains(model.ApplicationUser.Name))
            {
                return RedirectToAction("Details", new { id });
            }




            currentReply.VoteGR = currentReply.VoteGR - 1;


            if (currentReply.UsersUpVoteR == null)
            {
                string UsersDownVoteR = currentReply.UsersDownVoteR + ';' + model.ApplicationUser.Name;
                currentReply.UsersDownVoteR = UsersDownVoteR;
            }

            else if (currentReply.UsersUpVoteR.Contains(model.ApplicationUser.Name))
            {
                string nomes_atualizados = "";
                var nomes = currentReply.UsersUpVoteR.Split(";");
                for (int i = 0; i < nomes.Length; i++)
                {
                    if (nomes[i] == model.ApplicationUser.Name)
                    {
                        nomes[i] = "";
                    }

                    nomes_atualizados = nomes_atualizados + nomes[i] + ";";
                }

                currentReply.UsersUpVoteR = nomes_atualizados;
            }
            else
            {
                string UsersDownVoteR = currentReply.UsersDownVoteR + ';' + model.ApplicationUser.Name;
                currentReply.UsersDownVoteR = UsersDownVoteR;
            }

            _db.SaveChanges(); //salva as mudanças na db



            return RedirectToAction("Details", new { id });

        }


    }
}

