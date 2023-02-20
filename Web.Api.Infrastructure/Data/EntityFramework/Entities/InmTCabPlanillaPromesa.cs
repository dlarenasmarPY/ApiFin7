using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCabPlanillaPromesa
{
    public decimal TipoDocId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Ruta { get; set; } = null!;

    public decimal TipoDoc { get; set; }

    public byte TipoPromesa { get; set; }
}
