using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTRutaDespacho
{
    public int RdeId { get; set; }

    public string RdeGlosa { get; set; } = null!;

    public decimal PTipoVehId { get; set; }
}
