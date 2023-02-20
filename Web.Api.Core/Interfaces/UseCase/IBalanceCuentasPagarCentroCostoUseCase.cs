using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseRequest;
using Web.Api.Core.Dto.UseCaseResponse;

namespace Web.Api.Core.Interfaces.UseCase
{
    public interface IBalanceCuentasPagarCentroCostoUseCase :
    IUseCaseRequestHandler<balanceCuentasPorPagarRequest, balanceCuentasPorPagarResponse>
    {
    }
}
