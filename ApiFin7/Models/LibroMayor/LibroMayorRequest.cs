namespace Web.Api.Models.LibroMayor
{
    public class LibroMayorRequest
    {
        public int anio { get; set; }

        public List<int> periodomes { get; set; }

        public int empresa { get; set; }

        public int comEstado { get; set; }
    }
}
