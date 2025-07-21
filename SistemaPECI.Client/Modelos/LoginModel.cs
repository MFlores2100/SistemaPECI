using System.ComponentModel.DataAnnotations;

namespace SistemaPECI.Client.Modelos
{
    public class LoginModel
    {
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo no válido")]
        public string Correo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Contraseña { get; set; } = string.Empty;

        

    }
}
