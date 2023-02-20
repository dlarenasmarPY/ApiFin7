
using Web.Api.Core.Dto.UseCaseResponse.BancoEstado;
using Web.Api.Core.Interfaces;
using Web.Api.Serialization;


namespace Web.Api.Presenters.BancoEstado
{
    public class GetPlantillaPresenter : IOutputPort<PlantillaBancoEstadoResponse>
    {
        public JsonContentResult ContentResult { get; }

        public GetPlantillaPresenter() => this.ContentResult = new JsonContentResult();

        public void Handle(PlantillaBancoEstadoResponse response)
        {
            this.ContentResult.StatusCode = new int?(response.Success ? 200 : 401);
            this.ContentResult.Content = response.Success ? JsonSerializer.SerializeObject((object)response.dto) : JsonSerializer.SerializeObject((object)response.Errors);
        }
    }
}
