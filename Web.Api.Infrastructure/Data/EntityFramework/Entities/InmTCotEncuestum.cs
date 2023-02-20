using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCotEncuestum
{
    public decimal PCotizacionId { get; set; }

    public short PreguntaId { get; set; }

    public string RespuestaGlosa { get; set; } = null!;
}
