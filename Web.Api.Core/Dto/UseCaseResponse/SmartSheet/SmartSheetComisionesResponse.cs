using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseResponse.SmartSheet
{
    public class SmartSheetComisionesResponse : UseCaseResponseMessage
    {
        public List<SmartSheetComisiones> dto { get; }

        public IEnumerable<Error> Errors { get; }

        public SmartSheetComisionesResponse(IEnumerable<Error> errors, bool success = false, string message = null)
          : base(success, message)
        {
            this.Errors = errors;
        }

        public SmartSheetComisionesResponse(List<SmartSheetComisiones> Dto, bool success = false, string message = null)
          : base(success, message)
        {
            this.dto = Dto;
        }
    }
}
