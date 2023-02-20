using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTAfluencium
{
    public short AfluId { get; set; }

    public string AfluGlosa { get; set; } = null!;

    public byte IndVigencia { get; set; }

    public virtual ICollection<InmTCotizacion> InmTCotizacions { get; } = new List<InmTCotizacion>();
}
