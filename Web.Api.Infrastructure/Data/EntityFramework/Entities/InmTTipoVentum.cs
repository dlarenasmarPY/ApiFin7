using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTTipoVentum
{
    public short TventaId { get; set; }

    public string TventaGlosa { get; set; } = null!;

    public virtual ICollection<InmTCotizacion> InmTCotizacions { get; } = new List<InmTCotizacion>();

    public virtual ICollection<InmTInstanciaVentum> InmTInstanciaVenta { get; } = new List<InmTInstanciaVentum>();

    public virtual ICollection<InmTItemFinanciamiento> ItemFins { get; } = new List<InmTItemFinanciamiento>();
}
