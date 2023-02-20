using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbtEstadosRevisaDte
{
    public byte RecDetEstado { get; set; }

    public byte AccionEstado { get; set; }

    public string AccionReclamo { get; set; } = null!;

    public DateTime FechaReclamo { get; set; }

    public byte TipoProcesoDte { get; set; }
}
