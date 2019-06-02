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
    public class TagsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TagsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(string tag)
        {
            CommonViewModel model = new CommonViewModel();
            model.ApplicationUser = new ApplicationUser();
            model.CountQuestions = await _db.Questions.ToListAsync();
            model.RepliesCount = await _db.Replies.ToListAsync();
            model.Tags = new Tags();

            model.Tags.CurrentTag = tag;

            try
            {
                var claimsIdentity = (ClaimsIdentity)this.User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                if (claim != null)
                {
                    model.ApplicationUser = await _db.ApplicationUser.FindAsync(claim.Value);
                }
            }
            catch
            {

            }
            

            return View(model);
        }

        public async Task<IActionResult> AllTags()
        {
            CommonViewModel model = new CommonViewModel();
            model.ApplicationUser = new ApplicationUser();
            model.CountQuestions = await _db.Questions.ToListAsync();
            model.Tags = new Tags();

            try
            {
                var claimsIdentity = (ClaimsIdentity)this.User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                if (claim != null)
                {
                    model.ApplicationUser = await _db.ApplicationUser.FindAsync(claim.Value);
                }
            }
            catch { }
            

            return View(model);
        }

    }
}