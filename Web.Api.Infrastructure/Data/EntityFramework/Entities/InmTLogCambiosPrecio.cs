using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTLogCambiosPrecio
{
    public decimal PEmpId { get; set; }

    public decimal PTprId { get; set; }

    public decimal PinmuebleId { get; set; }

    public double PrecioVenta { get; set; }

    public double MontoMon { get; set; }

    public double MontoPorc { get; set; }

    public double PrecioVentaMod { get; set; }

    public DateTime FechaCambio { get; set; }

    public string Usuario { get; set; } = null!;

    public double PrecioStock { get; set; }

    public double PrecioStockMod { get; set; }

    public double PrecioLista { get; set; }

    public double PrecioListaMod { get; set; }

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double MontoMonPlista { get; set; }

    public double MontoPorPlista { get; set; }
}
