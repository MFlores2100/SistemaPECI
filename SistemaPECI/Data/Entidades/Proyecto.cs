using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class Proyecto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDProyecto { get; set; }
        [Required]
        public string CodigoPINE { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int AnioInicio { get; set; } = DateTime.Now.Year;
        [Required]
        public int Duracion { get; set; } //Duración en años
        public string Material { get; set; }
        public string ManoObra { get; set; }
        [Required]
        public string Estado { get; set; }
        public string Responsable { get; set; }
        [Required]
        public int IDRegion { get; set; }
        [ForeignKey("IDRegion")]
        public Region Region { get; set; }

        public Proyecto() { }

        public Proyecto(string codigoPINE, string nombre, string descripcion, int anioInicio, int duracion, 
            string material, string manoObra, string estado, string responsable, int idRegion){
            CodigoPINE = codigoPINE;
            Nombre = nombre;
            Descripcion = descripcion;
            AnioInicio = anioInicio;
            Duracion = duracion;
            Material = material;
            ManoObra = manoObra;
            Estado = estado;
            Responsable = responsable;
            IDRegion = idRegion;
        }
    }
}
