using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class DefaultController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialProject()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAdress()
        {
            var values = db.TblAdress.ToList();
            return PartialView(values);
        }


        [HttpGet]
        public ActionResult messajGonder()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult messajGonder(TblContact p)
        {
            var x = db.TblContact.Add(p);
            x.NameSurname = p.NameSurname;
            x.Mail = p.Mail;
            x.Subject = p.Subject;
            x.Message = p.Message;
            db.SaveChanges();
            
            return View();
        }

        public PartialViewResult Partialİstatistik()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }

    }
}