using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTTipoCliente
{
    public short TcliId { get; set; }

    public string TcliGlosa { get; set; } = null!;

    public virtual ICollection<InmTClienteTipoDocto> InmTClienteTipoDoctos { get; } = new List<InmTClienteTipoDocto>();

    public virtual ICollection<InmTCotizacion> InmTCotizacions { get; } = new List<InmTCotizacion>();
}
