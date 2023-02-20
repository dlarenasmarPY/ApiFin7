using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTConsignaLiquidaDet
{
    public decimal ConsignaLiquidaDetId { get; set; }

    public decimal PConsignaLiquidaCabId { get; set; }

    public decimal PDoctoVentaDetId { get; set; }

    public double LcdCantidad { get; set; }

    public double LcdPrecioUnitario { get; set; }

    public double LcdMtoGasto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
