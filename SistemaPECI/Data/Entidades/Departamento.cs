using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDDepartamento { get; set; }
        [Required]
        public string NombreDepartamento { get; set; }
        [Required]
        public string Descripcion { get; set; }

        public Departamento() { }

        public Departamento(int idDepartamento, string nombreDepartamento, string descripcion){
            IDDepartamento = idDepartamento;
            NombreDepartamento = nombreDepartamento;
            Descripcion = descripcion;
        }
    }
}
