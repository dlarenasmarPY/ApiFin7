using Web.Api.Core.Dto.UseCaseResponse;
using Web.Api.Core.Interfaces;
using Web.Api.Serialization;

namespace Web.Api.Presenters.CuentasPorPagar
{
    public class GetBalanceCxPProvisionPresenter : IOutputPort<BalanceCuentasPorPagarProvisionResponse>
    {
        public JsonContentResult ContentResult { get; }

        public GetBalanceCxPProvisionPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(BalanceCuentasPorPagarProvisionResponse response)
        {
            ContentResult.StatusCode = (response.Success ? 200 : 401);
            ContentResult.Content = (response.Success ? JsonSerializer.SerializeObject(response.dto) : JsonSerializer.SerializeObject(response.Errors));
        }
    }
}
