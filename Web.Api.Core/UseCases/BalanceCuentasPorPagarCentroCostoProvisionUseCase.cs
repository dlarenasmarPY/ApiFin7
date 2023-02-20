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
    public class BalanceCuentasPorPagarCentroCostoProvisionUseCase :
    IBalanceCuentasPorPagarCentroCostoProvisionUseCase,
    IUseCaseRequestHandler<BalanceCuentasPorPagarCentroCostoProvisionRequest, BalanceCuentasPorPagarProvisionResponse>
    {
        private ICuentasPorPagarRepository _repository;

        public BalanceCuentasPorPagarCentroCostoProvisionUseCase(ICuentasPorPagarRepository repository) => this._repository = repository;

        public async Task<bool> Handle(
          BalanceCuentasPorPagarCentroCostoProvisionRequest message,
          IOutputPort<BalanceCuentasPorPagarProvisionResponse> outputPort)
        {
            try
            {
                outputPort.Handle(new BalanceCuentasPorPagarProvisionResponse(await this._repository.getBalanceProvision(message), true, ""));
                return true;
            }
            catch (Exception ex)
            {
                outputPort.Handle(new BalanceCuentasPorPagarProvisionResponse((IEnumerable<Error>)new Error[1]
                {
          new Error("error al traer la información", ex.Message)
                }));
                return false;
            }
        }
    }
}
