using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevFolio.Models;

namespace DevFolio.Controllers
{
    public class ContactController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult MessageList()
        {
            var value = db.TblContact.ToList();
            return View(value);
        }


        public ActionResult iletisim()
        {
            var values = db.TblAdress.ToList();
            return View(values);
        }




        //[HttpGet]
        //public ActionResult mesaj()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult mesaj(TblContact p)
        //{
            
        //    return View();
        //}

        
      
    }
}