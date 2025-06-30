using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPECI.Data.Entidades
{
    public class ListaPrecios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDListaPrecios { get; set; }
        [Required]
        public double InflacionCR { get; set; }
        [Required]
        public double InflacionUSA { get; set; }
        [Required]
        public double TipoCambioVentaFinal { get; set; }
        [Required]
        public double VariacionTipoCambioFinal { get; set; }
        [Required]
        public double TipoCambioVentaPromedio { get; set; }
        [Required]
        public double VariacionTipoCambioPromedio { get; set; }
        [Required]
        public double TasaImpuestosSobreMateriales { get; set; }
        [Required]
        public double CostosIndirectos { get; set; }
        [Required]
        public double CostosPromedioOperacion { get; set; }

        public ListaPrecios() { }
        public ListaPrecios(double inflacionCR, double inflacionEEUU, double tipoCambioVentaFinal, double variacionTipoCambioFinal, double tipoCambioVentaPromedio, 
            double variacionTipoCambioVentaPromedio, double tasaImpuestosSobreMateriales, double costosIndirectos, double costosPromedioOperacion){

            InflacionCR = inflacionCR;
            InflacionUSA = inflacionEEUU;
            TipoCambioVentaFinal = tipoCambioVentaFinal;
            VariacionTipoCambioFinal = variacionTipoCambioFinal;
            TipoCambioVentaPromedio = tipoCambioVentaPromedio;
            VariacionTipoCambioPromedio = variacionTipoCambioVentaPromedio;
            TasaImpuestosSobreMateriales = tasaImpuestosSobreMateriales;
            CostosIndirectos = costosIndirectos;
            CostosPromedioOperacion = costosPromedioOperacion;
        }
    }
}
