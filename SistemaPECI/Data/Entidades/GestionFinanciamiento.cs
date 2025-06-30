using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class GestionFinanciamiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDGestionFinanciamiento { get; set; }
        [Required]
        public bool Opex { get; set; } //Indica si es OPEX
        [Required]
        public bool Capex { get; set; } //Indica si es CAPEX
        public double Material { get; set; }
        public double ManoObra { get; set; }
        public double TotalMaterialObra { get; set; }
        [Required]
        public double DesgloseMeses { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public double Monto { get; set; }
        [Required]
        public int IDProyecto { get; set; }
        [Required]
        public int IDRegion { get; set; }
        [ForeignKey("IDProyecto")]
        public Proyecto Proyecto { get; set; }
        [ForeignKey("IDRegion")]
        public Region Region { get; set; }

        public GestionFinanciamiento() { }

        public GestionFinanciamiento(bool opex, bool capex, double material, double manoObra, double totalMaterialObra,
            double desgloseMeses, string descripcion, double monto, int idProyecto, int idRegion)
        {
            Opex = opex;
            Capex = capex;
            Material = material;
            ManoObra = manoObra;
            TotalMaterialObra = totalMaterialObra;
            DesgloseMeses = desgloseMeses;
            Descripcion = descripcion;
            Monto = monto;
            IDProyecto = idProyecto;
            IDRegion = idRegion;
        }
    }
}
