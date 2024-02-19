using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class ServiceController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult ServiceList()
        {
            var value = db.TblService.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddService(TblService p)
        {
            db.TblService.Add(p);
            db.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public ActionResult DeleteService(int id)
        {
            var value = db.TblService.Find(id);
            db.TblService.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public ActionResult UpdateService(int id)
        {
            var value = db.TblService.Find(id);
            return View(value);
        }
    }
}