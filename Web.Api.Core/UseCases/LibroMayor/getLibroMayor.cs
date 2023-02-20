using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseRequest.LibroMayor;
using Web.Api.Core.Dto.UseCaseResponse.LibroMayor;
using Web.Api.Core.Interfaces.UseCase.LibroMayor;
using Web.Api.Core.Interfaces;
using Web.Api.Core.Dto;
using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Core.Domain.Entities;

namespace Web.Api.Core.UseCases.LibroMayor
{
    public class getLibroMayor :
    IgetLibroMayor,
    IUseCaseRequestHandler<LibroMayorRequest, LibroMayorResponse>
    {
        private ILibroMayorRepository _repository;

        public getLibroMayor(ILibroMayorRepository repository) => this._repository = repository;

        public async Task<bool> Handle(
          LibroMayorRequest message,
          IOutputPort<LibroMayorResponse> outputPort)
        {
            try
            {
                Task<List<Web.Api.Core.Domain.Entities.LibroMayor>> libroMayor =  _repository.GetLibroMayor(message);
                IOutputPort<LibroMayorResponse> outputPort1 = outputPort;
                outputPort1.Handle(new LibroMayorResponse(await libroMayor, true, ""));
                outputPort1 = (IOutputPort<LibroMayorResponse>)null;
                return true;
            }
            catch (Exception ex)
            {
                outputPort.Handle(new LibroMayorResponse((IEnumerable<Error>)new Error[1]
                {
          new Error("error al traer la información", ex.Message)
                }));
                return false;
            }
        }
    }
}
