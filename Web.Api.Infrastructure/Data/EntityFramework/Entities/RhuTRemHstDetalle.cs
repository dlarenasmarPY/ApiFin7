using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemHstDetalle
{
    public decimal PliqDetId { get; set; }

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

    public string LqDbaseRecibo { get; set; } = null!;

    public decimal LqDorigenMov { get; set; }

    public string CnTorigenMov { get; set; } = null!;

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
}
