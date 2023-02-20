using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTFactorConversion
{
    public decimal FactorConversionId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public double FactorConversion { get; set; }

    public byte UnidadMedMultDivide { get; set; }

    public decimal PUnidadMedDestinoId { get; set; }
}
