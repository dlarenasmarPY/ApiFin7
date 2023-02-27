using Microsoft.AspNetCore.Mvc;
using Web.Api.Core.Dto.UseCaseRequest;
using Web.Api.Core.Interfaces.UseCase;
using Web.Api.Models.Reportes;
using Web.Api.Presenters.CuentasPorPagar;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuentasPorPagarController : ControllerBase
    {
        private IBalanceCuentasPagarCentroCostoUseCase _bcpcc;

        private GetBalanceCxPPresenter _bcpccPresenter;

        private GetBalanceCxPProvisionPresenter _bcpccpPresenter;

        private IBalanceCuentasPorPagarCentroCostoProvisionUseCase _bcpccp;

        public CuentasPorPagarController(IBalanceCuentasPagarCentroCostoUseCase bcpcc, GetBalanceCxPPresenter bcpccPresenter, GetBalanceCxPProvisionPresenter bcpccpPresenter, IBalanceCuentasPorPagarCentroCostoProvisionUseCase bcpccp)
        {
            _bcpcc = bcpcc;
            _bcpccPresenter = bcpccPresenter;
            _bcpccpPresenter = bcpccpPresenter;
            _bcpccp = bcpccp;
        }

        [HttpPost]
        [Route("GetBalanceCuentasPorCobrar")]
        public async Task<ActionResult> GetBalanceCuentasPorCobrar([FromBody] BalanceCuentaPorPagarRequest request)
        {
            await _bcpcc.Handle(new balanceCuentasPorPagarRequest
            {
                IdEmpresa = request.IdEmpresa,
                CuentaFin = request.CuentaFin,
                CuentaInicio = request.CuentaInicio,
                Periodo = request.Periodo
            }, _bcpccPresenter);
            return _bcpccPresenter.ContentResult;
        }

        [HttpPost]
        [Route("GetBalanceCuentasPorCobrarProvision")]
        public async Task<ActionResult> GetBalanceCuentasPorCobrarProvision([FromBody] BalanceCuentaPorPagarProvisionRequest request)
        {
            await _bcpccp.Handle(new BalanceCuentasPorPagarCentroCostoProvisionRequest
            {
                Empresa = request.Empresa,
                CtaCodigo1 = request.CtaCodigo1,
                CtaCodigo2 = request.CtaCodigo2,
                FechaTermino = request.FechaTermino,
                Periodo = request.Periodo
            }, _bcpccpPresenter);
            return _bcpccpPresenter.ContentResult;
        }
    }
}
