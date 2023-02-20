using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTCotizacionDetEspTec
{
    public decimal CotizDetEspTecId { get; set; }

    public decimal PCotizDetId { get; set; }

    public decimal PProductoEspTecId { get; set; }

    public decimal PProductoEspTecDetId { get; set; }

    public int Linea { get; set; }

    public string GlosaDes { get; set; } = null!;

    public virtual AdqTCotizacionDet PCotizDet { get; set; } = null!;

    public virtual ExiTProductosEspTecCab PProductoEspTec { get; set; } = null!;
}
