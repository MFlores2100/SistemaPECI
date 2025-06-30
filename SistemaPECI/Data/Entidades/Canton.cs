using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class Canton
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDCanton { get; set; }
        [Required]
        public string Nombre { get; set; }

        public Canton() { }
        public Canton(string nombre){
            Nombre = nombre;
        }
    }
}
