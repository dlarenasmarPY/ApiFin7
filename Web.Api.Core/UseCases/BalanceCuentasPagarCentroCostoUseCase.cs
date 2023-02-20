using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseRequest;
using Web.Api.Core.Dto.UseCaseResponse;
using Web.Api.Core.Interfaces.UseCase;
using Web.Api.Core.Interfaces;
using Web.Api.Core.Dto;
using Web.Api.Core.Interfaces.Gateways.Repositories;

namespace Web.Api.Core.UseCases
{
    public class BalanceCuentasPagarCentroCostoUseCase :
    IBalanceCuentasPagarCentroCostoUseCase,
    IUseCaseRequestHandler<balanceCuentasPorPagarRequest, balanceCuentasPorPagarResponse>
    {
        private ICuentasPorPagarRepository _repository;

        public BalanceCuentasPagarCentroCostoUseCase(ICuentasPorPagarRepository repository) => this._repository = repository;

        public async Task<bool> Handle(
          balanceCuentasPorPagarRequest message,
          IOutputPort<balanceCuentasPorPagarResponse> outputPort)
        {
            try
            {
                IOutputPort<balanceCuentasPorPagarResponse> outputPort1 = outputPort;
                outputPort1.Handle(new balanceCuentasPorPagarResponse(await this._repository.GetBalanceCuentasPagarCentroCostos(message), true, ""));
                outputPort1 = (IOutputPort<balanceCuentasPorPagarResponse>)null;
                return true;
            }
            catch (Exception ex)
            {
                outputPort.Handle(new balanceCuentasPorPagarResponse((IEnumerable<Error>)new Error[1]
                {
          new Error("error al traer la información", ex.Message)
                }));
                return false;
            }
        }
    }
}
