using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ConsultaInformacion.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        
        public int IdPropietario { get; set; }

        [Required(ErrorMessage = "la marca es obligatoria")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "la placa es obligatoria")]
        [Display(Name = "Placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "el modelo es obligatorio")]
        [Display(Name = "Modelo")]
        public int Modelo { get; set; }

        public string CiudadOrigen { get; set; }

        public string CiudadDestino { get; set; }

    }
}
