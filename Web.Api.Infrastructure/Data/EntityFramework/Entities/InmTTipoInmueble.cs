using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTTipoInmueble
{
    public short TinmId { get; set; }

    public string TinmGlosa { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public double Monto { get; set; }

    public decimal PTprId { get; set; }

    public string TinmGlosaLarga { get; set; } = null!;

    public string NomArchPlano { get; set; } = null!;
}
