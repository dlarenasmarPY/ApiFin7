using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto;
using Web.Api.Core.Dto.UseCaseRequest.BancoEstado;
using Web.Api.Core.Dto.UseCaseRequest.SmartSheet;
using Web.Api.Core.Dto.UseCaseResponse.BancoEstado;
using Web.Api.Core.Dto.UseCaseResponse.SmartSheet;
using Web.Api.Core.Interfaces;
using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Core.Interfaces.UseCase.SmartSheet;

namespace Web.Api.Core.UseCases.SmartSheet
{
    public class GetSmartSheetComisiones : IGetSmartSheetComisiones, IUseCaseRequestHandler<SmartSheetComisionesRequest, SmartSheetComisionesResponse>
    {
        private ISmartSheetRepository _repository;

        public GetSmartSheetComisiones(ISmartSheetRepository repository) => this._repository = repository;
        public async Task<bool> Handle(SmartSheetComisionesRequest message, IOutputPort<SmartSheetComisionesResponse> outputPort)
        {
            try
            {
                Task<List<SmartSheetComisiones>> plantillaBancoEstado = this._repository.getDataComisiones(message);
                IOutputPort<SmartSheetComisionesResponse> outputPort1 = outputPort;
                outputPort1.Handle(new SmartSheetComisionesResponse(await plantillaBancoEstado, true, ""));
                outputPort1 = (IOutputPort<SmartSheetComisionesResponse>)null;
                return true;
            }
            catch (Exception ex)
            {
                outputPort.Handle(new SmartSheetComisionesResponse((IEnumerable<Error>)new Error[1]
                {
          new Error("error al traer la información", ex.Message)
                }));
                return false;
            }
        }
    }
}
