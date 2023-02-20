using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTTipoImpuesto
{
    public decimal TipoImpId { get; set; }

    public byte TipoImpCod { get; set; }

    public string TipoImpDes { get; set; } = null!;

    public byte IndImpuestoProd { get; set; }

    public byte IndCuentaCont { get; set; }

    public virtual ICollection<LogTImpuesto> LogTImpuestos { get; } = new List<LogTImpuesto>();
}
