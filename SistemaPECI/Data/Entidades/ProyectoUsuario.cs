using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class ProyectoUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDProyectoUsuario { get; set; }
        [Required]
        public int IDProyecto { get; set; }
        [Required]
        public int IDUsuario { get; set; }
        [ForeignKey("IDProyecto")]
        public Proyecto Proyecto { get; set; }
        [ForeignKey("IDUsuario")]
        public Usuario Usuario { get; set; }

        public ProyectoUsuario() { }
        public ProyectoUsuario(int idProyecto, int idUsuario)
        {
            IDProyecto = idProyecto;
            IDUsuario = idUsuario;
        }
    }
}
