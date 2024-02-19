using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class ProfileController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();


        public ActionResult ProfileList()
        {
            var values = db.TblProfile.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddProfil()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProfil(TblProfile p)
        {
            db.TblProfile.Add(p);
            db.SaveChanges();
            return RedirectToAction("ProfileList");
        }


        public ActionResult DeleteProfile(int id)
        {
            var values = db.TblProfile.Find(id);
            db.TblProfile.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ProfileList");
        }

        public ActionResult UpdateProfile(int id)
        {
            var values = db.TblProfile.Find(id);
            return View(values);
        }
    }
}