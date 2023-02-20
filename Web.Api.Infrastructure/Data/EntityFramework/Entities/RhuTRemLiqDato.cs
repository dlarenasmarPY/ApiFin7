using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemLiqDato
{
    public decimal LiqDatId { get; set; }

    public decimal PLiqId { get; set; }

    public short LqDsecCalculo { get; set; }

    public decimal PConcRemId { get; set; }

    public decimal LqTperId { get; set; }

    public decimal LqTperIdDev { get; set; }

    public double LqDvalor { get; set; }

    public double LqDvalorSinTope { get; set; }

    public double LqDvalorDeflac { get; set; }

    public string LqDvalBaseAlf { get; set; } = null!;

    public DateTime LqDvalBaseFec { get; set; }

    public double LqDvalBaseNum { get; set; }

    public decimal LqDorigenMov { get; set; }

    public decimal LqDrefOrigenId { get; set; }

    public decimal LqDrefPago { get; set; }

    public decimal LqDestadoPago { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemLiqAntecedente PLiq { get; set; } = null!;
}
