using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTransporteCium
{
    public decimal TransporteId { get; set; }

    public string TransporteCodigo { get; set; } = null!;

    public string TransporteGlosa { get; set; } = null!;

    public decimal PEntCiaTransId { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
