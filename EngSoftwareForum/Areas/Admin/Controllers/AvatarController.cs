using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting; //*get RootPath
using Microsoft.AspNetCore.Http;    //*IFormFile
using System.IO;                    //*Directory
using EngSoftwareForum.Models;
using System.Security.Claims;
using EngSoftwareForum.Data;
using Microsoft.EntityFrameworkCore;
using EngSoftwareForum.Utility;
using Microsoft.AspNetCore.Authorization;

namespace EngSoftwareForum.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    public class AvatarController : Controller
    {
        

        private readonly IHostingEnvironment _appEnvironment;
        private readonly ApplicationDbContext _db;

        public AvatarController(IHostingEnvironment appEnvironment, ApplicationDbContext db)

        {
            //----< Init: Controller >----

            _appEnvironment = appEnvironment;
            _db = db;

            //----</ Init: Controller >----
        }

        [HttpGet] //1.Load

        public IActionResult Index()

        {
            //--< Upload Form >--

            

            return View();

            //--</ Upload Form >--
        }

        [HttpPost] //Postback

        public async Task<IActionResult> Index(IFormFile file)

        {
            //--------< Upload_ImageFile() >--------

            //< check >

            if (file == null || file.Length == 0) return Content("file not selected");

            //</ check >

            //< get Path >

            string path_Root = _appEnvironment.WebRootPath;


            CommonViewModel model = new CommonViewModel();
            model.ApplicationUser = new ApplicationUser();
            

            //Procura dados do usuario no database
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            var applicationUser = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == claim.Value);
            applicationUser.AvatarSet = 1; //muda para 1 quando o avatar é selecionado
            model.ApplicationUser = applicationUser;

            if (applicationUser == null)
            {
                return NotFound();
            }

            await _db.SaveChangesAsync();


            string path_to_Images = path_Root + "\\Images\\" + claim.Value +".png";

            //</ get Path >

            //< Copy File to Target >

            using (var stream = new FileStream(path_to_Images, FileMode.Create))

            {

                await file.CopyToAsync(stream);

            }

            //</ Copy File to Target >

            //< output >

            ViewData["FilePath"] = path_to_Images;

            return RedirectToAction("Index", "Questions");

            //</ output >

            //--------</ Upload_ImageFile() >--------

        }
    }
}
