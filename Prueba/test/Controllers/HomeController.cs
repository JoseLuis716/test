using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.model;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        ProductosBL _bl = new ProductosBL();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.ListaProductos = _bl.ConsultarProductos().ToList();

            return View();
        }
    }
}