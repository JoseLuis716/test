﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;


namespace DATOS
{
    public class DepartamentoDALC
    {
        public void Agregar(Departamento dpto)
        {
            using (var db = new ProyectosContext())
            {
                //para que lo que este dentro la conexion se cierre y no use recursos del servidor
                db.Departamento.Add(dpto);
                db.SaveChanges();
            }
        }
        public List<Departamento> ListarDepartamentos()
        {
            using (var db = new ProyectosContext())
            {
                return db.Departamento.ToList();
            }
        }
        public Departamento GetDepartamento(int id)
        {
            using (var db = new ProyectosContext())
            {
                //  return db.Departamento.Find(id);
                //usando where
                return db.Departamento.Where(d => d.DepartamentoId == id).FirstOrDefault();
            }
        }

        public void Editar(Departamento dpto)
        {
            using (var db = new ProyectosContext())
            {
                var d = db.Departamento.Find(dpto.DepartamentoId);
                d.NombreDepartamento = dpto.NombreDepartamento;
                db.SaveChanges();
            }
        }
        public void Eliminar(int id)
        {
            using (var db = new ProyectosContext())
            {
                var d = db.Departamento.Find(id);
                db.Departamento.Remove(d);
                db.SaveChanges();
            }
        }
    }
}
