using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTCotizacionDetGlosa
{
    public decimal CotizDetGlosaId { get; set; }

    public decimal PCotizDetId { get; set; }

    public decimal PGlosaId { get; set; }

    public string GlosaDes { get; set; } = null!;

    public int Linea { get; set; }

    public byte? IndProdServ { get; set; }

    public int? ProdServId { get; set; }

    public virtual AdqTCotizacionDet PCotizDet { get; set; } = null!;

    public virtual AdqTGlosa PGlosa { get; set; } = null!;
}
