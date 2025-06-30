using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class ProyectoRegion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDProyectoRegion { get; set; }
        [Required]
        public int IDProyecto { get; set; }
        [ForeignKey("IDProyecto")]
        public Proyecto Proyecto { get; set; }
        [Required]
        public int IDRegion { get; set; }
        [ForeignKey("IDRegion")]
        public Region Region { get; set; }

        public ProyectoRegion() { }
        public ProyectoRegion(int idProyecto, int idRegion)
        {
            IDProyecto = idProyecto;
            IDRegion = idRegion;
        }
    }
}
