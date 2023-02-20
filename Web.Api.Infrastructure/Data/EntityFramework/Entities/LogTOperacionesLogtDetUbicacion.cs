using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTOperacionesLogtDetUbicacion
{
    public decimal OpeLogtDetUbiId { get; set; }

    public decimal POpeLogtDetId { get; set; }

    public decimal PDocReferenciaId { get; set; }

    public decimal PUbicacionId { get; set; }

    public double CantEntrada { get; set; }

    public double CantEntrada2 { get; set; }

    public double CantSalida { get; set; }

    public double CantSalida2 { get; set; }

    public virtual LogTOperacionesLogtDet POpeLogtDet { get; set; } = null!;

    public virtual ExiTUbicacione PUbicacion { get; set; } = null!;
}
