using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class DetalleRegion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDDetalleRegion { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public string DireccionExacta { get; set; } = string.Empty;
        [Required]
        public int IDRegion { get; set; }
        [ForeignKey("IDRegion")]
        public Region Region { get; set; }
        [Required]
        public int IDProvincia { get; set; }
        [ForeignKey("IDProvincia")]
        public Provincia Provincia { get; set; }

        public DetalleRegion() { }
        public DetalleRegion(string descripcion, string direccionExacta, int idRegion, int idProvincia){
            Descripcion = descripcion;
            DireccionExacta = direccionExacta;
            IDRegion = idRegion;
            IDProvincia = idProvincia;
        }
    }
}
