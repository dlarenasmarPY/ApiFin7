using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseResponse.BancoEstado;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseRequest.BancoEstado
{
    public class PlantillaBancoEstadoRequest : IUseCaseRequest<PlantillaBancoEstadoResponse>
    {
        public string Usuario { get; set; }

        public DateTime Fecha { get; set; }

        public int EmpId { get; set; }

        public int Estado { get; set; }
    }

}
