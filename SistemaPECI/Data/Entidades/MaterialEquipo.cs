using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaPECI.Data.Entidades
{
    public class MaterialEquipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDMaterialEquipo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public double Precio { get; set; }

        public MaterialEquipo() { }
        public MaterialEquipo(string nombre, int cantidad, double precio){
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
