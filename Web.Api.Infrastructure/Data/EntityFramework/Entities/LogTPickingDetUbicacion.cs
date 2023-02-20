using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTPickingDetUbicacion
{
    public decimal PickingDetUbiId { get; set; }

    public decimal PPickingDetId { get; set; }

    public decimal PUbicacionId { get; set; }

    public double CantPrepStock { get; set; }

    public double CantPrepStock2 { get; set; }

    public virtual LogTPickingDet PPickingDet { get; set; } = null!;

    public virtual ExiTUbicacione PUbicacion { get; set; } = null!;
}
