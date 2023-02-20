using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTVersionCarOfeDoctoRespaldo
{
    public decimal PCartaOfertaId { get; set; }

    public short TdoId { get; set; }

    public byte SituacionId { get; set; }

    public byte DocEstado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string Comentario { get; set; } = null!;

    public int InstCod { get; set; }

    public short CausalId { get; set; }

    public int NumeroVersion { get; set; }
}
