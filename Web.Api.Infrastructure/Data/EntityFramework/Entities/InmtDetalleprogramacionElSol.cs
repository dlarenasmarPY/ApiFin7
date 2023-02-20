using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmtDetalleprogramacionElSol
{
    public int PProgramacionId { get; set; }

    public decimal PTprId { get; set; }

    public short TinmId { get; set; }

    public int Periodo { get; set; }

    public int CantidadProg { get; set; }

    public double MontoProg { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
