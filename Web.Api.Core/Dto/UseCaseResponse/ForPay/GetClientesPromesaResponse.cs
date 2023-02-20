using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseResponse.ForPay
{
    public class GetClientesPromesaResponse : UseCaseResponseMessage
    {
        public List<ClientePromesaDto> dto { get; }

        public IEnumerable<Error> Errors { get; }

        public GetClientesPromesaResponse(IEnumerable<Error> errors, bool success = false, string message = null)
          : base(success, message)
        {
            this.Errors = errors;
        }

        public GetClientesPromesaResponse(List<ClientePromesaDto> Dto, bool success = false, string message = null)
          : base(success, message)
        {
            this.dto = Dto;
        }
    }
}
