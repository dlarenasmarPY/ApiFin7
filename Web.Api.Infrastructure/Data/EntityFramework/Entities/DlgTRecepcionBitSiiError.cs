using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTRecepcionBitSiiError
{
    public decimal PRecepcionBitId { get; set; }

    public int Linea { get; set; }

    public string IntGlosaError { get; set; } = null!;

    public string BitArchivo { get; set; } = null!;
}
