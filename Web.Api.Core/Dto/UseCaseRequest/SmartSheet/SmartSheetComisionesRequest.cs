using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseResponse.ForPay;
using Web.Api.Core.Dto.UseCaseResponse.SmartSheet;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseRequest.SmartSheet
{
    public class SmartSheetComisionesRequest : IUseCaseRequest<SmartSheetComisionesResponse>
    {
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int Zona { get; set; }
    }
}
