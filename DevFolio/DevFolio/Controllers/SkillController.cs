using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class SkillController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult SkillList()
        {
            var values = db.TblSkill.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSkiil()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkiil(TblSkill p)
        {
            db.TblSkill.Add(p);
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public ActionResult DeleteSkiil(int id)
        {
            var value = db.TblSkill.Find(id);
            db.TblSkill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSkill(TblSkill p)
        {
            var value = db.TblSkill.Find(p.SkillID);
            value.SkillTitle = p.SkillTitle;
            value.SkillValue = p.SkillValue;
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}