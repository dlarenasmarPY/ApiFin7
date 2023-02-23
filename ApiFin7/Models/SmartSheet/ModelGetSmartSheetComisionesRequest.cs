namespace Web.Api.Models.SmartSheet
{
    public class ModelGetSmartSheetComisionesRequest
    {
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int Zona { get; set; }
    }
}
