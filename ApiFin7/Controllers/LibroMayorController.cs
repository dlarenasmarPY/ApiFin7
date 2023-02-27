using Microsoft.AspNetCore.Mvc;
using Web.Api.Core.Interfaces.UseCase.LibroMayor;
using Web.Api.Presenters.LibroMayor;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibroMayorController : ControllerBase
    {
        private IgetLibroMayor _usecase;

        private LibroMayorPresenter _presenter;

        public LibroMayorController(IgetLibroMayor usecase, LibroMayorPresenter presenter)
        {
            _usecase = usecase;
            _presenter = presenter;
        }

        [HttpGet]
        [Route("GetReporteClientes")]
        public async Task<ActionResult> GetLibroMayor([FromQuery] Web.Api.Models.LibroMayor.LibroMayorRequest request)
        {
            await _usecase.Handle(new Web.Api.Core.Dto.UseCaseRequest.LibroMayor.LibroMayorRequest
            {
                anio = request.anio,
                comEstado = request.comEstado,
                empresa = request.empresa,
                periodomes = request.periodomes
            }, _presenter);
            return _presenter.ContentResult;
        }
    }
}
