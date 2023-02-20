using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseResponse.BancoEstado
{
    public class PlantillaBancoEstadoResponse : UseCaseResponseMessage
    {
        public List<PlantillaBancoEstado> dto { get; }

        public IEnumerable<Error> Errors { get; }

        public PlantillaBancoEstadoResponse(IEnumerable<Error> errors, bool success = false, string message = null)
          : base(success, message)
        {
            this.Errors = errors;
        }

        public PlantillaBancoEstadoResponse(
          List<PlantillaBancoEstado> Dto,
          bool success = false,
          string message = null)
          : base(success, message)
        {
            this.dto = Dto;
        }
    }

}
