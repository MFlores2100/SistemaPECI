using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class Persona
    {
        [Key]
        public int IDPersona { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }

        public Persona() { }

        public Persona(int IdPersona, string nombre, string apellido) {
            IDPersona = IdPersona;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
