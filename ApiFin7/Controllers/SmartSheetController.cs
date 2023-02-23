using Microsoft.AspNetCore.Mvc;
using Web.Api.Core.Dto.UseCaseRequest.BancoEstado;
using Web.Api.Core.Dto.UseCaseResponse.BancoEstado;
using Web.Api.Core.Interfaces.UseCase.BancoEstado;
using Web.Api.Core.Interfaces;
using Web.Api.Core.Interfaces.UseCase.SmartSheet;
using Web.Api.Models.BancoEstado;
using Web.Api.Presenters.BancoEstado;
using Web.Api.Core.Dto.UseCaseRequest.SmartSheet;
using Web.Api.Core.Dto.UseCaseResponse.SmartSheet;
using Web.Api.Models.SmartSheet;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmartSheetController : ControllerBase
    {
        private IGetSmartSheetComisiones _comisiones;
        private Presenters.SmartSheet.GetSmartSheetComisionesPresenter _presenter;
        public SmartSheetController(Presenters.SmartSheet.GetSmartSheetComisionesPresenter presenter,IGetSmartSheetComisiones comisiones)
        {
            _presenter = presenter;
            _comisiones = comisiones;
        }

        [HttpGet]
        [Route("GetSmartSheetComisiones")]
        public async Task<ActionResult> GetSmartSheetComisiones([FromQuery] ModelGetSmartSheetComisionesRequest request)
        {
            SmartSheetComisionesRequest message = new SmartSheetComisionesRequest();
            message.Zona = request.Zona;
            message.FechaDesde = request.FechaDesde;
            message.FechaHasta = request.FechaHasta;
            int num = await _comisiones.Handle(message, (IOutputPort<SmartSheetComisionesResponse>)_presenter) ? 1 : 0;
            return (ActionResult)this._presenter.ContentResult;
        }
    }
}
