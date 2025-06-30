using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class RegistroAuditoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDAuditoria { get; set; }
        [Required]
        public DateTime FechaHora { get; set; } = DateTime.Now;
        [Required]
        public string TipoOperacion { get; set; }
        [Required]
        public string EntidadAfectada { get; set; }
        public string DatosPrevios { get; set; }
        public string DatosNuevos { get; set; }
        // Relación de uno-a-muchos con DetalleAuditoria
        public ICollection<DetalleAuditoria> DetallesAuditoria { get; set; }

        public RegistroAuditoria () { }

        public RegistroAuditoria(string tipoOperacion, string entidadAfectada, string datosPrevios, string datosNuevos){
            FechaHora = DateTime.Now;
            TipoOperacion = tipoOperacion;
            EntidadAfectada = entidadAfectada;
            DatosPrevios = datosPrevios;
            DatosNuevos = datosNuevos;
        }
    }
}
