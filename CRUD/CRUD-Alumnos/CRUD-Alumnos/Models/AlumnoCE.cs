using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Alumnos.Models
{
    //para referirse a la base de datos puede ser asi
    public class AlumnoCE
    {
        public int Id { get; set; }
        [Required]
        [Display (Name ="Ingrese Nombres")]
        public string Nombres { get; set; }
        [Required]
        [Display(Name = "Ingrese Apellidos")]
        public string Apellidos { get; set; }
        [Required]
        [Display(Name = "Ingrese Edad")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "Solo puede poner 'H' o 'M'")]
        [Display(Name = "Ingrese Genero")]
        public string Genero { get; set; }
        [Required]
        [Display(Name = "Ciudad")]
        public int Cod_Ciudad { get; set; }
        public string Nombre { get; set; }
        public System.DateTime Fecha_Registro { get; set; }
        public string NombreCompleto { get { return Nombres + " " + Apellidos; } }
    }

    //o tambien con un public partial class
    [MetadataType(typeof(AlumnoCE))]
    public partial class Alumnos
    {
        //y aqui pueden agregarse nuevas referencias
        public string NombreCompleto { get { return Nombres + " " + Apellidos; } }
    }
}