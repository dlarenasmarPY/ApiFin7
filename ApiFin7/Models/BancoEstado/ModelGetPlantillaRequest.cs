namespace Web.Api.Models.BancoEstado
{
    public class ModelGetPlantillaRequest
    {
        public string Usuario { get; set; }

        public DateTime Fecha { get; set; }

        public int EmpId { get; set; }

        public int Estado
        {
            get; set;
        }
    }
}
