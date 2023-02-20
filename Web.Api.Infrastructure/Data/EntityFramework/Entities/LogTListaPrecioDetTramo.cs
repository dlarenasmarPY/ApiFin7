using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTListaPrecioDetTramo
{
    public decimal PListaPreDetId { get; set; }

    public decimal PListaPreCabId { get; set; }

    public short LprDetCorr { get; set; }

    public double PrecioUnitario { get; set; }

    public double PrecioMinimo { get; set; }

    public double CantMinima { get; set; }

    public double CantMaxima { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
