using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConVPresMultimonedum
{
    public int IdPpto { get; set; }

    public int IdEmpresa { get; set; }

    public string IdDivision { get; set; } = null!;

    public string IdUnidadAdm { get; set; } = null!;

    public int IdPeriodo { get; set; }

    public string? IdCuentaPres { get; set; }

    public int IdCentro { get; set; }

    public string IdCimp { get; set; } = null!;

    public string IdProyecto { get; set; } = null!;

    public int IdTipoDocto { get; set; }

    public decimal IdMoneda { get; set; }

    public int SaldoReal { get; set; }

    public byte? Imputable { get; set; }

    public decimal? SaldoPres { get; set; }

    public decimal? SaldoPresProy { get; set; }
}
