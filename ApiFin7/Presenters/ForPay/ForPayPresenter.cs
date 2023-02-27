using Web.Api.Core.Dto.UseCaseResponse;
using Web.Api.Core.Interfaces;
using Web.Api.Serialization;

namespace Web.Api.Presenters.ForPay
{
    public class ForPayPresenter : IOutputPort<ForPayResponse>
    {
        public JsonContentResult ContentResult { get; }

        public ForPayPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(ForPayResponse response)
        {
            ContentResult.StatusCode = (response.Success ? 200 : 401);
            ContentResult.Content = (response.Success ? JsonSerializer.SerializeObject(response.dto) : JsonSerializer.SerializeObject(response.Errors));
        }
    }
}
