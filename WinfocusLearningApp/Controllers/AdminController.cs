using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WinfocusLearningApp.DataEntity;

namespace WinfocusLearningApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly Winfocus_CS dbEntities=new Winfocus_CS();
        private static TimeZoneInfo INDIANTIME = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> StudyMaterialType(int?id)
        {
            DateTime indianTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIANTIME);
            if (TempData["StatusMessage"] != null)
            {
                ViewBag.StatusMessage = TempData["StatusMessage"].ToString();
            }

            if (TempData["ErrorMessage"] != null)
            {
                ViewBag.ErrorMessage = TempData["ErrorMessage"].ToString();
            }

            TblMaterial inf = new TblMaterial();
            
            if (id == null)
            {

                ViewBag.AccademicYear = new SelectList(Enumerable.Empty<SelectListItem>());
                //  ViewBag.AccademicYear = new SelectList(db.Programmes.Where(p => p.IsDeleted == 0), "Id", "Name");
                //  ViewBag.SubProgramId = new SelectList(Enumerable.Empty<SelectListItem>());

            }
            else
            {
                ViewBag.AccademicYear = new SelectList(Enumerable.Empty<SelectListItem>());
                // inf = db.TblMaterials.Find(id);
                //   ViewBag.ProgramId = new SelectList(db.Programmes.Where(p => p.IsDeleted == 0), "Id", "Name", inf.ProgramId);


            }

            return View(inf);
        }
    }
}