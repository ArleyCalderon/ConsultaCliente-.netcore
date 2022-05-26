using System.ComponentModel.DataAnnotations;
namespace ConsultaInformacion.Models

{
    public class Ad_Login
    {
        [Required(ErrorMessage = "el usuario es obligatorio")]
        [Display(Name = "Admin_id")]
        public string Admin_id { get; set; }

        [Required(ErrorMessage = "la contraseña es obligatoria")]
        [Display(Name = "Admin_Pass")]
        public string Admin_Pass { get; set; }

    }
}
