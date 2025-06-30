using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class MaterialRequerido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDMaterialRequerido { get; set; }
        [Required]
        public string TipoMaterial { get; set; }
        [Required]
        public string Cantidad { get; set; }
        [Required]
        public int IDProyecto { get; set; }
        [Required]
        public int IDMaterialEquipo { get; set; }
        [ForeignKey("IDProyecto")]
        public Proyecto Proyecto { get; set; }
        [ForeignKey("IDMaterialEquipo")]
        public MaterialEquipo MaterialEquipo { get; set; }

        public MaterialRequerido() { }
        public MaterialRequerido(string tipoMaterial, string cantidad, int idProyecto, int idMaterialEquipo)
        {
            TipoMaterial = tipoMaterial;
            Cantidad = cantidad;
            IDProyecto = idProyecto;
            IDMaterialEquipo = idMaterialEquipo;
        }
    }
}
