using DevFolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevFolio.Controllers
{
    public class StatisticController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projeCount = db.TblProject.Count();
            ViewBag.Skillcount = db.TblSkill.Count();
            ViewBag.skillAvgValue = db.TblSkill.Average(x => x.SkillValue);
            ViewBag.lasSkillTitleName = db.GetLasSkillTitle().FirstOrDefault();
            ViewBag.feature = db.TblFeature.Count();
            ViewBag.getProjectTitle = db.GetLasSkillTitle().FirstOrDefault();
            ViewBag.sosyalMedia = db.TblSocialMedia.Count();
            return View();
        }
    }
}