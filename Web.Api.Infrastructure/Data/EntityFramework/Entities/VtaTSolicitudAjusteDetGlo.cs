using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTSolicitudAjusteDetGlo
{
    public decimal PSolicitudAjusteCabId { get; set; }

    public decimal PSolicitudAjusteDetId { get; set; }

    public short SagLinea { get; set; }

    public string SagGlosaItem { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
