using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class Region
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDRegion { get; set; }
        [Required]
        public string Nombre { get; set; }

        public Region() { }
        public Region(string nombre)
        {
            Nombre = nombre;
        }
    }
}
