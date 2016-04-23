using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Listado de Productos de base de datos Northwind.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pagina de contacto.";

            return View();
        }


        public ActionResult Listado()
        {
            ViewBag.Message = "Listado de Productos de base de datos Northwind.";
            return View();
        }
    }
}