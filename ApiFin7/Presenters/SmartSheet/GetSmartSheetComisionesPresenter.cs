using Web.Api.Core.Dto.UseCaseResponse.BancoEstado;
using Web.Api.Core.Dto.UseCaseResponse.SmartSheet;
using Web.Api.Core.Interfaces;
using Web.Api.Serialization;

namespace Web.Api.Presenters.SmartSheet
{
    public class GetSmartSheetComisionesPresenter : IOutputPort<SmartSheetComisionesResponse>
    {
        public JsonContentResult ContentResult { get; }

        public GetSmartSheetComisionesPresenter() => this.ContentResult = new JsonContentResult();

        public void Handle(SmartSheetComisionesResponse response)
        {
            this.ContentResult.StatusCode = new int?(response.Success ? 200 : 401);
            this.ContentResult.Content = response.Success ? JsonSerializer.SerializeObject((object)response.dto) : JsonSerializer.SerializeObject((object)response.Errors);
        }
    }
}
