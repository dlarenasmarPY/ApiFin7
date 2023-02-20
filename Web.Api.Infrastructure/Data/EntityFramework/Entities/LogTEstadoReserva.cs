using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTEstadoReserva
{
    public short CodEstadoReserva { get; set; }

    public byte FormaAtencionCod { get; set; }

    public byte ConEstCod { get; set; }

    public string GlosaEstadoReserva { get; set; } = null!;
}
