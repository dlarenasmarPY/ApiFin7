namespace Web.Api.Models.Reportes
{
    public class BalanceCuentaPorPagarRequest
    {
        public int IdEmpresa { get; set; }

        public int CuentaInicio { get; set; }

        public int CuentaFin { get; set; }

        public DateTime Periodo { get; set; }
    }
}
