using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto.UseCaseRequest.BancoEstado;

namespace Web.Api.Core.Interfaces.Gateways.Repositories
{
    public interface IBancoEstadoRepository
    {
        Task<List<PlantillaBancoEstado>> getPlantillaBancoEstado(PlantillaBancoEstadoRequest request);
    }
}
