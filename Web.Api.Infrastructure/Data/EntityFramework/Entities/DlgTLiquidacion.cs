using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTLiquidacion
{
    public decimal PDoctoLegalCabId { get; set; }

    public decimal PEntId { get; set; }

    public double LiqIvapropio { get; set; }

    public double LiqIvaterceros { get; set; }

    public double LiqValComNeto { get; set; }

    public double LiqValComExe { get; set; }

    public double LiqValComIva { get; set; }
}
