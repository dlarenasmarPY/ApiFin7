using Microsoft.AspNetCore.Mvc;
using Web.Api.Core.Interfaces.UseCase.ForPay;
using Web.Api.Core.Interfaces.UseCase;
using Web.Api.Presenters.ForPay;
using Web.Api.Core.Dto.UseCaseRequest.ForPay;
using Web.Api.Core.Dto.UseCaseRequest;
using Web.Api.Models.ForPay;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForPayController : ControllerBase
    {
        private IgetClienteForPay _usecase;

        private ForPayPresenter _presenter;

        private GetClientesPresenter _presenterGetClientes;

        private IForPayUseCase _useCaseReport;

        public ForPayController(IgetClienteForPay usecase, ForPayPresenter presenter, GetClientesPresenter presenterGetClientes, IForPayUseCase useCaseReport)
        {
            _usecase = usecase;
            _presenter = presenter;
            _presenterGetClientes = presenterGetClientes;
            _useCaseReport = useCaseReport;
        }

        [HttpPost]
        [Route("GetReporteCuotas")]
        public async Task<ActionResult> GetReporteCuotas([FromBody] ReporteCuotasPromesaRequest request)
        {
            await _useCaseReport.Handle(new ForPayRequest
            {
                empresa = request.empresa,
                proyecto = request.proyecto,
                rut = request.rut
            }, _presenter);
            return _presenter.ContentResult;
        }

        [HttpGet]
        [Route("GetReporteClientes")]
        public async Task<ActionResult> GetReporteClientes()
        {
            await _usecase.Handle(new GetClientesPromesaRequest(), _presenterGetClientes);
            return _presenterGetClientes.ContentResult;
        }

    }
}
