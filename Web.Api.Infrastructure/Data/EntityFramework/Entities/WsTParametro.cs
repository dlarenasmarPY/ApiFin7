using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WsTParametro
{
    public decimal? PEmpId { get; set; }

    public short? DivCodigo { get; set; }

    public decimal? PTipoOpeAjuEntId { get; set; }

    public byte? ProNegocioCodAjuEnt { get; set; }

    public string? IdFuncionalidadAjuEnt { get; set; }

    public decimal? PTipoOpeAjuSalId { get; set; }

    public byte? ProNegocioCodAjuSal { get; set; }

    public string? IdFuncionalidadAjuSal { get; set; }

    public decimal? PTipoOpeDesTraId { get; set; }

    public byte? ProNegocioCodDesTra { get; set; }

    public string? IdFuncionalidadDesTra { get; set; }

    public decimal? PTprId { get; set; }

    public string? PryNumero { get; set; }

    public int? Crecodigo { get; set; }

    public int? CdiCodigo { get; set; }

    public decimal? UnidadEmisoraDefecto { get; set; }

    public short? TipoDoctoNcdefecto { get; set; }

    public string? UrldatosWms { get; set; }
}
