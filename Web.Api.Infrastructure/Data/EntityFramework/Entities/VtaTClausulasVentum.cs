using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTClausulasVentum
{
    public decimal ClausulaVentaId { get; set; }

    public string DescriClauVtaI { get; set; } = null!;

    public string DescriClauVta { get; set; } = null!;

    public byte IndFlete { get; set; }

    public byte IndSeguro { get; set; }

    public byte IndOtroGasto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public short CodigoSiiClauVta { get; set; }
}
