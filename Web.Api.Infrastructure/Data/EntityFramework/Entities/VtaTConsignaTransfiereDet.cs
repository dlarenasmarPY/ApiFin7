using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTConsignaTransfiereDet
{
    public decimal ConsignaTransfiereDetId { get; set; }

    public decimal PConsignaTransfiereCabId { get; set; }

    public decimal PDoctoVentaDetId { get; set; }

    public double CtdCantidad { get; set; }

    public double CtdCantidadStock { get; set; }

    public double CtdPrecioUnitario { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
