using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class Provincia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDProvincia { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int IDCanton { get; set; }
        [ForeignKey("IDCanton")]
        public Canton Canton { get; set; }

        public Provincia() { }
        public Provincia(string nombre, int idCanton){
            Nombre = nombre;
            IDCanton = idCanton;
        }
    }
}
