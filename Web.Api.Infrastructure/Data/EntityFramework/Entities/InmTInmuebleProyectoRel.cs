using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTInmuebleProyectoRel
{
    public decimal PTprId { get; set; }

    public decimal PinmuebleId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PTprIdRel { get; set; }

    public decimal PinmuebleIdRel { get; set; }

    public string PryNumeroRel { get; set; } = null!;
}
