using Web.Api.Core.Dto.UseCaseResponse.LibroMayor;
using Web.Api.Core.Interfaces;
using Web.Api.Serialization;

namespace Web.Api.Presenters.LibroMayor
{
    public class LibroMayorPresenter : IOutputPort<LibroMayorResponse>
    {
        public JsonContentResult ContentResult { get; }

        public LibroMayorPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(LibroMayorResponse response)
        {
            ContentResult.StatusCode = (response.Success ? 200 : 401);
            ContentResult.Content = (response.Success ? JsonSerializer.SerializeObject(response.dto) : JsonSerializer.SerializeObject(response.Errors));
        }
    }
}
