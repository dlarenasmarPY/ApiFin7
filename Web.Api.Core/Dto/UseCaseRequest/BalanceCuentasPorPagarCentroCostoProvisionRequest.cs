using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseResponse;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseRequest
{
    public class BalanceCuentasPorPagarCentroCostoProvisionRequest :
    IUseCaseRequest<BalanceCuentasPorPagarProvisionResponse>
    {
        public int? Empresa { get; set; }

        public DateTime? FechaTermino { get; set; }

        public int? CtaCodigo1 { get; set; }

        public int? CtaCodigo2 { get; set; }

        public int? Periodo { get; set; }
    }
}
