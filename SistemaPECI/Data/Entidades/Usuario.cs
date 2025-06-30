using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDUsuario { get; set; }
        [Required]
        public string NombreUsuario { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Contrasenia { get; set; }
        [Required]
        public string Rol { get; set; }
        [Required]
        public int IDPersona { get; set; }
        [ForeignKey("IDPersona")]
        public Persona Persona { get; set; }
        [Required]
        public int IDDepartamento { get; set; }
        [ForeignKey("IDDepartamento")]
        public Departamento Departamento { get; set; }

        public Usuario() { }

        public Usuario(string nombreUsuario, string correo, string contrasenia, string rol, int idPersona, int idDepartamento)
        {
            NombreUsuario = nombreUsuario;
            Correo = correo;
            Contrasenia = contrasenia;
            Rol = rol;
            IDPersona = idPersona;
            IDDepartamento = idDepartamento;
        }

    }
}
