using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TabSdoVacTmp
{
    public string? EntRut { get; set; }

    public string? EntRazonSocial { get; set; }

    public decimal? PEmpId { get; set; }

    public string? AuxEmpresa { get; set; }

    public decimal? CtoId { get; set; }

    public decimal? CtoNumero { get; set; }

    public double? FlegDefDiasBase { get; set; }

    public double? FlegMabDiasPro { get; set; }

    public DateTime? FlegDatFecBase { get; set; }

    public double? AuxDiasDev { get; set; }

    public double? AuxDiasAbo { get; set; }

    public double? AuxDiasUsa { get; set; }

    public double? AuxDiasSdo { get; set; }
}
