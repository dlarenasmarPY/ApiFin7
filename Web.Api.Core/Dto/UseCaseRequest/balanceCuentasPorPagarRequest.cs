using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseResponse;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseRequest
{
    public class balanceCuentasPorPagarRequest : IUseCaseRequest<balanceCuentasPorPagarResponse>
    {
        public int IdEmpresa { get; set; }

        public int CuentaInicio { get; set; }

        public int CuentaFin { get; set; }

        public DateTime Periodo { get; set; }
    }
}
