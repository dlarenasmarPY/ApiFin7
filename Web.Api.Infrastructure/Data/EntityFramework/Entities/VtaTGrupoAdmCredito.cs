using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTGrupoAdmCredito
{
    public decimal GrupoAdmCredito { get; set; }

    public decimal PVendHolding { get; set; }

    public decimal PCliHolding { get; set; }

    public double CliMtoLineaCredito { get; set; }

    public decimal PMonedaId { get; set; }
}
