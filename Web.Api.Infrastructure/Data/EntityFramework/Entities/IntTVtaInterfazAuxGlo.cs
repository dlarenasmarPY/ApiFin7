using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTVtaInterfazAuxGlo
{
    public string IntTmpOwner { get; set; } = null!;

    public decimal PDoctoVentaDetId { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public short DvgLinea { get; set; }

    public string DvgGlosaItem { get; set; } = null!;

    public string IntBitArchivo { get; set; } = null!;
}
