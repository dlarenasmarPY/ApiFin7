using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseRequest.ForPay;
using Web.Api.Core.Dto.UseCaseResponse.ForPay;

namespace Web.Api.Core.Interfaces.UseCase.ForPay
{
    public interface IgetClienteForPay :
    IUseCaseRequestHandler<GetClientesPromesaRequest, GetClientesPromesaResponse>
    {
    }
}
