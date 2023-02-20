using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEmpresaCuentaFinanza
{
    public decimal PEmpId { get; set; }

    public short TipCtaFin { get; set; }

    public decimal PCtaId { get; set; }
}
