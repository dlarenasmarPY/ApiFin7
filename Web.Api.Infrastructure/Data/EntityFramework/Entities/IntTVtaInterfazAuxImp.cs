using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTVtaInterfazAuxImp
{
    public string IntTmpOwner { get; set; } = null!;

    public decimal PDoctoVentaDetId { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public decimal PImpuestoId { get; set; }

    public double DviPorcentaje { get; set; }

    public string IntBitArchivo { get; set; } = null!;
}
