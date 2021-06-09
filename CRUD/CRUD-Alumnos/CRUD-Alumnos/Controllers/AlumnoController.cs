using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_Alumnos.Models;

namespace CRUD_Alumnos.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            try
            {
                using (var db = new AlumnosContext())
                {
                    var data = (from a in db.Alumnos
                               join c in db.Ciudad on a.Cod_Ciudad equals c.id
                               select new AlumnoCE()
                               {
                                   Id = a.Id,
                                   Nombres = a.Nombres,
                                   Apellidos = a.Apellidos,
                                   Edad = a.Edad,
                                   Genero = a.Genero,
                                   Cod_Ciudad = a.Cod_Ciudad,
                                   Fecha_Registro = a.Fecha_Registro,
                                   Nombre = c.Nombre

                               }).ToList();
                   
                    return View(data);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Error al editar alumno " + e.Message);
                return View();
            }
            //try
            //{
            //    using (var db = new AlumnosContext())
            //    {
            //        //filtro para mostrar solo los mayores a 18
            //        List<Alumnos> lista = db.Alumnos.Where(alumno => alumno.Edad > 18).ToList();
            //        //filtro
            //        List<Alumnos> listaOrdenada = db.Alumnos.OrderBy(alumno => alumno.Edad).ToList();
            //        //LINQ to SQL
            //        List<Alumnos> lista2 = (from a in db.Alumnos
            //                                orderby a.Edad descending
            //                                select a).ToList();

            //        return View(db.Alumnos.ToList());
            //    }
            //}
            //catch (Exception err)
            //{
            //    ModelState.AddModelError("", "Error al Cargar vista " + err.Message);
            //    return View();
            //}



        }

        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Agregar(Alumnos A)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                try
                {
                    //metodo recomendado
                    using (var db = new AlumnosContext())
                    {
                        //Tenemos que agregar la fecha de registro
                        A.Fecha_Registro = DateTime.Now;
                        //para asegurar que la conexion no se quede abierta
                        db.Alumnos.Add(A);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("","Error al registrar alumno "+e.Message);
                    return View();
                }
                
            }
           
        }
        public ActionResult Agregar2()
        {
            return View();
        }
        public ActionResult ListaCiudades()
        {
            using (var db = new AlumnosContext())
            {
                return PartialView(db.Ciudad.ToList());
            }
        }
        public ActionResult MostrarCiudad(int id)
        {
            using (var db = new AlumnosContext())
            {
                return PartialView(db.Ciudad.Find(id));
            }
        }

        public ActionResult Editar(int id)
        {
            if (!ModelState.IsValid)
                return View();
            try
            {
                using (var db = new AlumnosContext())
                {
                    //Alumnos al = db.Alumnos.Where(alum => alum.Id == id).FirstOrDefault();
                    Alumnos segundaforma = db.Alumnos.Find(id);//el find solo cuando se sabe que tiene una clave primaria
                    if (segundaforma != null)
                    {
                        return View(segundaforma);
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "No se ha encontrado el alumno ");
                        return RedirectToAction("Index");
                    }
                   
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", "Error al editar alumno " + e.Message);
                return RedirectToAction("Index");
            }


        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Alumnos Alumn)
        {
            try
            {
                using (var db = new AlumnosContext())
                {

                    Alumnos editAlumno = db.Alumnos.Find(Alumn.Id);
                    if (editAlumno != null){
                        /// si existe
                        editAlumno.Nombres = Alumn.Nombres;
                        editAlumno.Apellidos = Alumn.Apellidos;
                        editAlumno.Edad = Alumn.Edad;
                        editAlumno.Genero = Alumn.Genero;
                        editAlumno.Cod_Ciudad = Alumn.Cod_Ciudad;

                        db.SaveChanges();
                        //redireccionamos al index
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Error al editar alumno ");
                        return View();
                    }
                }
                   
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Error al editar alumno " + e.Message);
                return View();
            }
          
        }

        public ActionResult DetallesAlumno(int id)
        {
            try
            {
                using (var db = new AlumnosContext())
                {
                    var data = (from a in db.Alumnos
                               join c in db.Ciudad on a.Cod_Ciudad equals c.id
                               where a.Id == id
                               select new AlumnoCE()
                               {
                                   Id = a.Id,
                                   Nombres = a.Nombres,
                                   Apellidos = a.Apellidos,
                                   Edad = a.Edad,
                                   Genero = a.Genero,
                                   Cod_Ciudad = a.Cod_Ciudad,
                                   Fecha_Registro = a.Fecha_Registro,
                                   Nombre = c.Nombre
                                   
                               }).SingleOrDefault(); //.SingleOrDefault<AlumnoCE>();
                    return View(data);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Error al editar alumno " + e.Message);
                return View();
            }
        }
        public ActionResult VerCiduad(int id)
        {
            try
            {
                using (var db = new AlumnosContext())
                {
                     Alumnos detalleAlumno = db.Alumnos.Find(id);
                    //var lista = from persona in db.Alumnos
                    //            join ciudad in db.Ciudad
                    //            on persona.Cod_Ciudad equals ciudad.id;

                    return View(detalleAlumno);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Error al editar alumno " + e.Message);
                return View();
            }
        }

        public ActionResult EliminarAlumno(int id)
        {
            try
            {
                using (var db = new AlumnosContext())
                {
                    Alumnos EliminarAlumno = db.Alumnos.Find(id);
                    db.Alumnos.Remove(EliminarAlumno);
                    db.SaveChanges();
                    //redireccionamos al index
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Error al editar alumno " + e.Message);
                return View();
            }
        }

        public static string NombreCiudad( int cod)
        {
            using (var db = new AlumnosContext())
            {
                return db.Ciudad.Find(cod).Nombre;
            }
        }
    }
}