using Microsoft.AspNetCore.Mvc;
using Web.Api.Core.Dto.UseCaseRequest.BancoEstado;
using Web.Api.Core.Dto.UseCaseResponse.BancoEstado;
using Web.Api.Core.Interfaces;
using Web.Api.Core.Interfaces.UseCase.BancoEstado;
using Web.Api.Models.BancoEstado;
using Web.Api.Presenters.BancoEstado;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BancoEstadoController : ControllerBase
    {
        private IGetPlantillaUseCase _usecase;
        private GetPlantillaPresenter _presenter;
        public BancoEstadoController(IGetPlantillaUseCase usecase, GetPlantillaPresenter presenter)
        {
            this._usecase = usecase;
            this._presenter = presenter;
        }

        [HttpGet]
        [Route("GetPlantillaBancoEstado")]
        public async Task<ActionResult> GetPlantillaBancoEstado([FromQuery] ModelGetPlantillaRequest request)
        {
            IGetPlantillaUseCase usecase = this._usecase;
            PlantillaBancoEstadoRequest message = new PlantillaBancoEstadoRequest();
            message.EmpId = request.EmpId;
            message.Fecha = request.Fecha;
            message.Usuario = request.Usuario;
            message.Estado = request.Estado;
            GetPlantillaPresenter presenter = this._presenter;
            int num = await usecase.Handle(message, (IOutputPort<PlantillaBancoEstadoResponse>)presenter) ? 1 : 0;
            return (ActionResult)this._presenter.ContentResult;
        }
    }
}
