using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class AdressController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult AdressList()
        {
            var values = db.TblAdress.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAdress()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdress(TblAdress p)
        {
            db.TblAdress.Add(p);
            db.SaveChanges();
            return RedirectToAction("AdressList");
        }

        public ActionResult DeleteAdress(int id)
        {
           var values= db.TblAdress.Find(id);
            db.TblAdress.Remove(values);
            db.SaveChanges();
            return RedirectToAction("AdressList");
        }

        [HttpGet]
        public ActionResult UpdateAdress(int id)
        {
            var values = db.TblAdress.Find(id);
            return View(values);
        }
    }
}