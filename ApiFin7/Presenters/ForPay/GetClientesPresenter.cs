using Web.Api.Core.Dto.UseCaseResponse.ForPay;
using Web.Api.Core.Interfaces;
using Web.Api.Serialization;

namespace Web.Api.Presenters.ForPay
{
    public class GetClientesPresenter : IOutputPort<GetClientesPromesaResponse>
    {
        public JsonContentResult ContentResult { get; }

        public GetClientesPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetClientesPromesaResponse response)
        {
            ContentResult.StatusCode = (response.Success ? 200 : 401);
            ContentResult.Content = (response.Success ? JsonSerializer.SerializeObject(response.dto) : JsonSerializer.SerializeObject(response.Errors));
        }
    }
}
