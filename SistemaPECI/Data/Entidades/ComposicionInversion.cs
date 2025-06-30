using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class ComposicionInversion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDComposicionInversion { get; set; }
        [Required]
        public double Anual { get; set; }
        [Required]
        public double Acumulado { get; set; }
        [Required]
        public double Porcentaje { get; set; }
        [Required]
        public int IDProyecto { get; set; }
        [ForeignKey("IDProyecto")]
        public Proyecto Proyecto { get; set; }

        public ComposicionInversion() { }

        public ComposicionInversion(double anual, double acumulado, double porcentaje, int idProyecto)
        {
            Anual = anual;
            Acumulado = acumulado;
            Porcentaje = porcentaje;
            IDProyecto = idProyecto;
        }
    }
}
