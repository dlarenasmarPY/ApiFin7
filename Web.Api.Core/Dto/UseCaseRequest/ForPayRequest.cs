using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseResponse;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseRequest
{
    public class ForPayRequest : IUseCaseRequest<ForPayResponse>
    {
        public string rut { get; set; }

        public string empresa { get; set; }

        public string proyecto { get; set; }
    }
}
