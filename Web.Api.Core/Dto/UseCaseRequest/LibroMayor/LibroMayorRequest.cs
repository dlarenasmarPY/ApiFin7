using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Dto.UseCaseResponse.LibroMayor;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseRequest.LibroMayor
{
    public class LibroMayorRequest : IUseCaseRequest<LibroMayorResponse>
    {
        public int anio { get; set; }

        public List<int> periodomes { get; set; }

        public int empresa { get; set; }

        public int comEstado { get; set; }
    }
}
