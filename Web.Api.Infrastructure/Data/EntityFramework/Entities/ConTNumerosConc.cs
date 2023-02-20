using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTNumerosConc
{
    public string NcoNombreVariable { get; set; } = null!;

    public int NcoValorVariable { get; set; }

    public byte SisCodOri { get; set; }

    public bool NcoIndVigencia { get; set; }

    public DateTime NcoFechaVigencia { get; set; }
}
