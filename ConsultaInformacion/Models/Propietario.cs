using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ConsultaInformacion.Models
{
    public class Propietario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del propietario es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 1)]
        [Display(Name ="Nombre propietario")]
        public string NombrePropietario { get; set; }

        [Required(ErrorMessage = "la cédula es obligatoria")]
        [Display(Name = "Cédula")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "El celular  es obligatoria")]
        public int Celular { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string Correo { get; set; }
    }
}
