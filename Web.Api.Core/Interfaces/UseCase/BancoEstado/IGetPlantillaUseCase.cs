using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseRequest.BancoEstado;
using Web.Api.Core.Dto.UseCaseResponse.BancoEstado;

namespace Web.Api.Core.Interfaces.UseCase.BancoEstado
{
    public interface IGetPlantillaUseCase :
    IUseCaseRequestHandler<PlantillaBancoEstadoRequest, PlantillaBancoEstadoResponse>
    {

    }
}
