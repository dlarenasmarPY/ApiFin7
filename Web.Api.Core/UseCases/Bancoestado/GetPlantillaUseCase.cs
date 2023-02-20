using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseRequest.BancoEstado;
using Web.Api.Core.Dto.UseCaseResponse.BancoEstado;
using Web.Api.Core.Interfaces.UseCase.BancoEstado;
using Web.Api.Core.Interfaces;
using Web.Api.Core.Dto;
using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Core.Domain.Entities;

namespace Web.Api.Core.UseCases.Bancoestado
{
    public class GetPlantillaUseCase :
    IGetPlantillaUseCase,
    IUseCaseRequestHandler<PlantillaBancoEstadoRequest, PlantillaBancoEstadoResponse>
    {
        private IBancoEstadoRepository _repository;

        public GetPlantillaUseCase(IBancoEstadoRepository repository) => this._repository = repository;

        public async Task<bool> Handle(
          PlantillaBancoEstadoRequest message,
          IOutputPort<PlantillaBancoEstadoResponse> outputPort)
        {
            try
            {
                Task<List<PlantillaBancoEstado>> plantillaBancoEstado = this._repository.getPlantillaBancoEstado(message);
                IOutputPort<PlantillaBancoEstadoResponse> outputPort1 = outputPort;
                outputPort1.Handle(new PlantillaBancoEstadoResponse(await plantillaBancoEstado, true, ""));
                outputPort1 = (IOutputPort<PlantillaBancoEstadoResponse>)null;
                return true;
            }
            catch (Exception ex)
            {
                outputPort.Handle(new PlantillaBancoEstadoResponse((IEnumerable<Error>)new Error[1]
                {
          new Error("error al traer la información", ex.Message)
                }));
                return false;
            }
        }
    }
}
