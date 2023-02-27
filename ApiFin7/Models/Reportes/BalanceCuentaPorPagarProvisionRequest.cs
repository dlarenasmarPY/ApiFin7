namespace Web.Api.Models.Reportes
{
    public class BalanceCuentaPorPagarProvisionRequest
    {
        public int? Empresa { get; set; }

        public DateTime? FechaTermino { get; set; }

        public int? CtaCodigo1 { get; set; }

        public int? CtaCodigo2 { get; set; }

        public int? Periodo { get; set; }
    }
}
