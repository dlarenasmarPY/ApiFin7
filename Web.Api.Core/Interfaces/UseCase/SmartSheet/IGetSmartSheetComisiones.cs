using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseRequest.SmartSheet;
using Web.Api.Core.Dto.UseCaseResponse.SmartSheet;

namespace Web.Api.Core.Interfaces.UseCase.SmartSheet
{
    public interface IGetSmartSheetComisiones: IUseCaseRequestHandler<SmartSheetComisionesRequest, SmartSheetComisionesResponse>
    {

    }
}
