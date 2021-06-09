using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using ENTIDAD;
using NEGOCIO;

namespace WEB_PROYECTOS.Controllers
{
    public class DepartamentoController : Controller
    {
      
        // GET: Departamento
        public ActionResult Index()
        {
            var dptos = DepartamentoCN.ListarDepartamentos();
            return View(dptos);
        }
        [HttpGet] //cuando se solicita info, no es necesario poner httpget
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost] //envia info al presiona el boton de crear
        public ActionResult Crear(Departamento dpto)
        {
            //metodo que envia los datos 
            try
            {
                if (dpto.NombreDepartamento == null)
                {
                    ModelState.AddModelError("", "Debe ingresar el nombre del departamento");
                    return View(dpto);
                }
                DepartamentoCN.Agregar(dpto);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ha ocurrido un error al agregar departamento ");
                return View(dpto);
            }
            //  return View();
        }
        public ActionResult GetDepartamento(int id)
        {
            var dpto = DepartamentoCN.GetDepartamento(id);
            return View(dpto);
        }
        public ActionResult Editar(int id)
        {
            var dpto = DepartamentoCN.GetDepartamento(id);
            return View(dpto);
        }
        [HttpPost] //envia info al presiona el boton de crear
        public ActionResult Editar(Departamento dpto)
        {
            try
            {
                if (dpto.NombreDepartamento == null)
                {
                    ModelState.AddModelError("", "Debe ingresar el nombre del departamento");
                    return View(dpto);
                }

                DepartamentoCN.Editar(dpto);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Debe ingresar el nombre del departamento");
                return View(dpto);
            }
        }
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var dpto = DepartamentoCN.GetDepartamento(id.Value);
            return View(dpto);
        }
        [HttpPost] //envia info al presiona el boton
        public ActionResult Eliminar(int id)
        {
            try
            {
                DepartamentoCN.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Error al eliminar");
                return View();
            }
        }
    }
}