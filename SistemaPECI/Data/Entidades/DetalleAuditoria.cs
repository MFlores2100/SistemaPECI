using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class DetalleAuditoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDDetalleAuditoria { get; set; }
        [Required]
        public int IDUsuario { get; set; }
        [ForeignKey("IDUsuario")]
        public Usuario Usuario { get; set; }
        [Required]
        public int IDAuditoria { get; set; }
        [ForeignKey("IDAuditoria")]
        public RegistroAuditoria Auditoria { get; set; }

        public DetalleAuditoria () { }
        public DetalleAuditoria(int idUsuario, int idAuditoria){
            IDUsuario = idUsuario;
            IDAuditoria = idAuditoria;
        }

    }
}
