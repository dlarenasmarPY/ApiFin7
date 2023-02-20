using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class BesTBitacoraWsIcon
{
    public decimal BitId { get; set; }

    public decimal POcCabId { get; set; }

    public int CorrLogtNum { get; set; }

    public string XmlDocto { get; set; } = null!;

    public string IdUsuario { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public string RespuestaIconstruye { get; set; } = null!;
}
