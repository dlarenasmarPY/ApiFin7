using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTOcDetEspTec
{
    public decimal OcDetEspTecId { get; set; }

    public decimal POcDetId { get; set; }

    public decimal PProductoEspTecId { get; set; }

    public decimal PProductoEspTecDetId { get; set; }

    public virtual AdqTOcDet POcDet { get; set; } = null!;

    public virtual ExiTProductosEspTecCab PProductoEspTec { get; set; } = null!;
}
