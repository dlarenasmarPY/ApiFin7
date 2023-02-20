using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTDoctoVentaDetCon
{
    public decimal DoctoVentaDetConId { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public decimal PDoctoVentaDetId { get; set; }

    public decimal PDoctoVentaCabProId { get; set; }

    public double DvoPorcentaje { get; set; }

    public double DvoMontoDistribuido { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
