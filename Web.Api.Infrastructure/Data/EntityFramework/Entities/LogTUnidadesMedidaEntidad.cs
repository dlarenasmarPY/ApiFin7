using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTUnidadesMedidaEntidad
{
    public decimal UnidadMedEntId { get; set; }

    public decimal PProductoUnidadMedidaId { get; set; }

    public decimal PEntId { get; set; }

    public double UnidadMedConversion { get; set; }

    public byte UnidadMedMultDivide { get; set; }

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual ExiTProductosUnidadesMedidum PProductoUnidadMedida { get; set; } = null!;
}
