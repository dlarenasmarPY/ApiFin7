using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParTramoAsigFam
{
    public decimal TramoId { get; set; }

    public DateTime TraFecVigencia { get; set; }

    public string TraCodTramo { get; set; } = null!;

    public decimal TraDesdePesos { get; set; }

    public decimal TraTopePesos { get; set; }

    public decimal TraValorSimplePesos { get; set; }

    public decimal TraValorInvalidapesos { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
