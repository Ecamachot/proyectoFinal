using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DirectorioPNP2018.Models;

namespace DirectorioPNP2018.Controllers
{
    public class HomeController : Controller

    {
        private DirectorioPNPEntities db = new DirectorioPNPEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult resultado()

        {
            string q = this.Request.Params.Get("nombreComun");
            string d = this.Request.Params.Get("departamento");
            return View(db.UnidadPNPs.Where(u => u.nombreComun.Contains(q) && u.departamento.Equals(d)).ToList());
            


        }
    }

}