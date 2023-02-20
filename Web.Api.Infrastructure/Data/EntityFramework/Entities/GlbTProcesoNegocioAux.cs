using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTProcesoNegocioAux
{
    public decimal ProNegocioAuxId { get; set; }

    public short ProNegocioCod { get; set; }

    public byte TauId { get; set; }

    public byte SisCodOri { get; set; }
}
