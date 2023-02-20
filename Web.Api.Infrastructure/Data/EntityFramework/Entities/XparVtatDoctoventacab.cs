using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class XparVtatDoctoventacab
{
    public decimal Doctoventacabid { get; set; }

    public string? Tiporeferencia1 { get; set; }

    public string? Folioreferencia1 { get; set; }

    public DateTime? Fechareferencia1 { get; set; }

    public string? Razonreferencia1 { get; set; }

    public string? Tiporeferencia2 { get; set; }

    public string? Folioreferencia2 { get; set; }

    public DateTime? Fechareferencia2 { get; set; }

    public string? Razonreferencia2 { get; set; }

    public string? Tiporeferencia3 { get; set; }

    public string? Folioreferencia3 { get; set; }

    public DateTime? Fechareferencia3 { get; set; }

    public string? Razonreferencia3 { get; set; }

    public string? Tiporeferencia4 { get; set; }

    public string? Folioreferencia4 { get; set; }

    public DateTime? Fechareferencia4 { get; set; }

    public string? Razonreferencia4 { get; set; }

    public string? Tiporeferencia5 { get; set; }

    public string? Folioreferencia5 { get; set; }

    public DateTime? Fechareferencia5 { get; set; }

    public string? Razonreferencia5 { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
