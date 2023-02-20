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
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto.UseCaseRequest.ForPay;
using Web.Api.Core.Dto.UseCaseResponse.ForPay;
using Web.Api.Core.Interfaces.UseCase.ForPay;

namespace Web.Api.Core.UseCases
{
    public class getClienteForPay : IgetClienteForPay,
   IUseCaseRequestHandler<GetClientesPromesaRequest, GetClientesPromesaResponse>
    {
        private IForPayRepository _repository;

        public getClienteForPay(IForPayRepository repository) => this._repository = repository;

        public async Task<bool> Handle(
          GetClientesPromesaRequest message,
          IOutputPort<GetClientesPromesaResponse> outputPort)
        {
            try
            {
                Task<List<ClientePromesaDto>> clientesPromesa = this._repository.GetClientesPromesa();
                IOutputPort<GetClientesPromesaResponse> outputPort1 = outputPort;
                outputPort1.Handle(new GetClientesPromesaResponse(await clientesPromesa, true, ""));
                outputPort1 = (IOutputPort<GetClientesPromesaResponse>)null;
                return true;
            }
            catch (Exception ex)
            {
                outputPort.Handle(new GetClientesPromesaResponse((IEnumerable<Error>)new Error[1]
                {
          new Error("error al traer la información", ex.Message)
                }));
                return false;
            }
        }
    }
}
