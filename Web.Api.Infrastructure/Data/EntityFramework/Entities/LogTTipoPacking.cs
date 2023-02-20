using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTTipoPacking
{
    public decimal TipoPackingId { get; set; }

    public string TipoPackingCod { get; set; } = null!;

    public string TipoPackingDes { get; set; } = null!;
}
