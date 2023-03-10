using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseResponse
{
    public class balanceCuentasPorPagarResponse : UseCaseResponseMessage
    {
        public List<BalanceCuentasPagarCentroCosto> dto { get; }

        public IEnumerable<Error> Errors { get; }

        public balanceCuentasPorPagarResponse(IEnumerable<Error> errors, bool success = false, string message = null)
          : base(success, message)
        {
            this.Errors = errors;
        }

        public balanceCuentasPorPagarResponse(
          List<BalanceCuentasPagarCentroCosto> Dto,
          bool success = false,
          string message = null)
          : base(success, message)
        {
            this.dto = Dto;
        }
    }
}
