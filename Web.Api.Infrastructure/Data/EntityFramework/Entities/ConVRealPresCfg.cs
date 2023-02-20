using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConVRealPresCfg
{
    public int IdPpto { get; set; }

    public int IdEmpresa { get; set; }

    public int IdDivision { get; set; }

    public string IdUnidadAdm { get; set; } = null!;

    public int IdPeriodo { get; set; }

    public string? IdCuenta { get; set; }

    public int IdCentro { get; set; }

    public decimal IdCimp { get; set; }

    public string IdProyecto { get; set; } = null!;

    public int IdNivel { get; set; }

    public int IdTipoDocto { get; set; }

    public decimal IdMoneda { get; set; }

    public string? Origen { get; set; }

    public int? Imputable { get; set; }

    public decimal? SaldoReal { get; set; }

    public decimal? SaldoPres { get; set; }

    public decimal? SaldoPresProy { get; set; }
}
