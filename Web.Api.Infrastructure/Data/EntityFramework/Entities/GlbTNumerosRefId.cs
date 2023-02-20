using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTNumerosRefId
{
    public string NcoNombreVariable { get; set; } = null!;

    public byte SisCodOri { get; set; }

    public decimal CabReferenciaId { get; set; }

    public decimal DetReferenciaId { get; set; }
}
