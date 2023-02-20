using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosUnidadesMedidum
{
    public decimal ProductoUnidadMedidaId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public double UnidadMedConversion { get; set; }

    public byte UnidadMedMultDivide { get; set; }

    public double UnidadMedValorPeso { get; set; }

    public byte UnidadMedPeso { get; set; }

    public double UnidadMedValorVolumen { get; set; }

    public byte UnidadMedVolumen { get; set; }

    public double UnidadMedValorLargo { get; set; }

    public double UnidadMedValorAncho { get; set; }

    public double UnidadMedValorAlto { get; set; }

    public byte UnidadMedDimension { get; set; }

    public DateTime UnidadMedFechaVigencia { get; set; }

    public virtual ICollection<LogTUnidadesMedidaEntidad> LogTUnidadesMedidaEntidads { get; } = new List<LogTUnidadesMedidaEntidad>();

    public virtual ExiTProducto PProducto { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMed { get; set; } = null!;
}
