using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseRequest.LibroMayor;
using Web.Api.Core.Dto.UseCaseResponse.LibroMayor;

namespace Web.Api.Core.Interfaces.UseCase.LibroMayor
{
    public interface IgetLibroMayor : IUseCaseRequestHandler<LibroMayorRequest, LibroMayorResponse>
    {
    }
}
