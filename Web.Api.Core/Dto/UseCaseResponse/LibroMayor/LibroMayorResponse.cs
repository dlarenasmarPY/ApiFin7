using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Interfaces;
using Web.Api.Core.Domain.Entities;

namespace Web.Api.Core.Dto.UseCaseResponse.LibroMayor
{
    public class LibroMayorResponse : UseCaseResponseMessage
    {
        public List<Web.Api.Core.Domain.Entities.LibroMayor> dto { get; }

        public IEnumerable<Error> Errors { get; }

        public LibroMayorResponse(IEnumerable<Error> errors, bool success = false, string message = null)
          : base(success, message)
        {
            this.Errors = errors;
        }

        public LibroMayorResponse(List<Web.Api.Core.Domain.Entities.LibroMayor> Dto, bool success = false, string message = null)
          : base(success, message)
        {
            this.dto = Dto;
        }
    }
}
