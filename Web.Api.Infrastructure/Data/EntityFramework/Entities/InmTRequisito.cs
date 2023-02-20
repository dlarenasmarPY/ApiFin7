using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTRequisito
{
    public short EventoId { get; set; }

    public short RequisitoId { get; set; }

    public string RequisitoGlosa { get; set; } = null!;

    public byte RequeridoId { get; set; }

    public byte VigenteId { get; set; }
}
